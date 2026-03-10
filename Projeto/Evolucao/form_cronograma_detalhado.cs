using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.ProviderBase;
using System.IO;
using System.Xml;
using System.Data.OleDb;
using System.Reflection;




namespace Evolucao
{
    public partial class form_cronograma_detalhado : Form
    {
        string fresa, torno, cnc_des, tempera, retifica, cnc_acab, erosao_edm, erosao_ewc, polimento;
        string fresa_real, torno_real, cnc_des_real, tempera_real, retifica_real, cnc_acab_real, erosao_edm_real, erosao_ewc_real, polimento_real;
        double total_horas_prev;
        double total_horas_trab;

        //acerta horas des/pm/elet

        string cod_rota_desenho;
        double total_tudo;
        double total_pm;
        double total_acab;

        bool sem_entrada;
        int n_ope;
        bool primeira;
        //variaveis do verificar datas
        DateTime primeiro_dia = new DateTime();
        DateTime ultimo_dia = new DateTime();

        int ano_primeiro;// = achar_primeira_semana().Year;
        int ano_ultimo;// = achar_ultima_semana().Year;

        int primeira_semana;// = 1 + conferir_semana(primeiro_dia) / 7;
        int ultima_semana;// = 1 + conferir_semana(ultimo_dia) / 7;
        int n_semana;// = ultima_semana - primeira_semana;
        int[,] semana_ano = new int[50, 2];
        int prim_var;
        int ano_var;

        //para saber de todas as funcoes
        DateTime primeiro_dia2 = new DateTime();
        DateTime ultimo_dia2 = new DateTime();

        int ano_primeiro2;// = achar_primeira_semana().Year;
        int ano_ultimo2;// = achar_ultima_semana().Year;

        int primeira_semana2;// = 1 + conferir_semana(primeiro_dia) / 7;
        int ultima_semana2;// = 1 + conferir_semana(ultimo_dia) / 7;
        int n_semana2;// = ultima_semana - primeira_semana;
        int[,] semana_ano2 = new int[50, 2];
        int prim_var2;
        int ano_var2;

        double porc_fresa;
        double porc_eletrodo;
        double porc_torno;
        double porc_cnc_des;
        double porc_cnc_acab;
        double porc_erosao_ewc;
        double porc_erosao_edm;
        double porc_polimento;
        double porc_tempera;
        double porc_retifica;
        double porc_projeto;
        double porc_porta_molde;

        //pega os primeiros dias previstos de cada operação
        DateTime primeiro_dia_prev_fresa = new DateTime();
        DateTime primeiro_dia_prev_torno = new DateTime();
        DateTime primeiro_dia_prev_cnc_desb = new DateTime();
        DateTime primeiro_dia_prev_tempera = new DateTime();
        DateTime primeiro_dia_prev_retifica = new DateTime();
        DateTime primeiro_dia_prev_cnc_acab = new DateTime();
        DateTime primeiro_dia_prev_erosao_ewc = new DateTime();
        DateTime primeiro_dia_prev_erosao_edm = new DateTime();
        DateTime primeiro_dia_prev_polimento = new DateTime();
        DateTime primeiro_dia_prev_porta_molde = new DateTime();
        DateTime primeiro_dia_prev_projeto = new DateTime();

        //pega os primeiros dias reais de cada operação
        DateTime primeiro_dia_exec_fresa = new DateTime();
        DateTime primeiro_dia_exec_torno = new DateTime();
        DateTime primeiro_dia_exec_cnc_desb = new DateTime();
        DateTime primeiro_dia_exec_tempera = new DateTime();
        DateTime primeiro_dia_exec_retifica = new DateTime();
        DateTime primeiro_dia_exec_cnc_acab = new DateTime();
        DateTime primeiro_dia_exec_erosao_ewc = new DateTime();
        DateTime primeiro_dia_exec_erosao_edm = new DateTime();
        DateTime primeiro_dia_exec_polimento = new DateTime();
        DateTime primeiro_dia_exec_projeto = new DateTime();
        DateTime primeiro_dia_exec_porta_molde = new DateTime();

        //pega os ultimos dias previstos de cada operação
        DateTime ultimo_dia_prev_fresa = new DateTime();
        DateTime ultimo_dia_prev_torno = new DateTime();
        DateTime ultimo_dia_prev_cnc_desb = new DateTime();
        DateTime ultimo_dia_prev_tempera = new DateTime();
        DateTime ultimo_dia_prev_retifica = new DateTime();
        DateTime ultimo_dia_prev_cnc_acab = new DateTime();
        DateTime ultimo_dia_prev_erosao_ewc = new DateTime();
        DateTime ultimo_dia_prev_erosao_edm = new DateTime();
        DateTime ultimo_dia_prev_polimento = new DateTime();
        DateTime ultimo_dia_prev_projeto = new DateTime();
        DateTime ultimo_dia_prev_porta_molde = new DateTime();

        //pega os ultimos dias reais de cada operação
        DateTime ultimo_dia_exec_fresa = new DateTime();
        DateTime ultimo_dia_exec_torno = new DateTime();
        DateTime ultimo_dia_exec_cnc_desb = new DateTime();
        DateTime ultimo_dia_exec_tempera = new DateTime();
        DateTime ultimo_dia_exec_retifica = new DateTime();
        DateTime ultimo_dia_exec_cnc_acab = new DateTime();
        DateTime ultimo_dia_exec_erosao_ewc = new DateTime();
        DateTime ultimo_dia_exec_erosao_edm = new DateTime();
        DateTime ultimo_dia_exec_polimento = new DateTime();
        DateTime ultimo_dia_exec_projeto = new DateTime();
        DateTime ultimo_dia_exec_porta_molde = new DateTime();


        string funcao;
        public bool abrir_os;
        public string os_atual;
        string ent_real;
        string fec_real;
        string ent_prev;
        string fec_prev;
        double total_horas_fresa;
        double total_horas_torno;
        double total_horas_Cnc_des;
        double total_horas_Tempera;
        double total_horas_Retifica;
        double total_horas_Cnc_acab;
        double total_horas_Erosao_ewc;
        double total_horas_Erosao_edm;
        double total_horas_Polimento;
        double total_horas_Eletrodo;
        double total_horas_Projeto;
        double total_horas_Porta_molde;
        double total_exec_fresa;
        double total_exec_torno;
        int posicao_atual;
        double total_exec_Cnc_des;
        double total_exec_Tempera;
        double total_exec_Retifica;
        double total_exec_Cnc_acab;
        double total_exec_Erosao_ewc;
        double total_exec_Erosao_edm;
        double total_exec_Polimento;
        double total_exec_Projeto;
        double total_exec_Porta_molde;
        double total_exec_Eletrodo;
        //DataSet posicoes = new DataSet();
        
        public form_cronograma_detalhado()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void abrir()
        {
            string nova_os = tb_molde.Text;
            dsDesenhos.Clear();
            this.datDesenhos.SelectCommand.CommandText =
                "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "'";
            this.fbConnection1.Open();
            this.datDesenhos.SelectCommand.Connection = fbConnection1;
            this.datDesenhos.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            datDesenhos.Fill(DESENHOS);
            if (tb_molde.Text == "")
            {
                MessageBox.Show("Essa OS não existe");
            }
            else
            {
                
                funcao = "%";
                ok();
                somar_horas();
               // popular_grid();
                Atualizar();
            }
            
            
        }

        private void Atualizar()
        {
            this.BindingContext[dsDesenhos, "DESENHOS"].EndCurrentEdit();
            //fbConnection1.Open();
            if (dsDesenhos.HasChanges())
            {

                //MessageBox.Show("CHEGOU NO ATUALIZAR do rotas");
                datDesenhos.UpdateCommand = cbDesenhos.GetUpdateCommand();
                datDesenhos.InsertCommand = cbDesenhos.GetInsertCommand();
                datDesenhos.DeleteCommand = cbDesenhos.GetDeleteCommand();
                datDesenhos.Update(dsDesenhos, "DESENHOS");
                dsDesenhos.AcceptChanges();

            }
            fbConnection1.Close(); 

        }

        private void somar_horas()
        {
            total_horas_trab = total_exec_Cnc_acab + total_exec_Cnc_des + total_exec_Erosao_edm +
                total_exec_Erosao_ewc + total_exec_fresa + total_exec_Eletrodo + total_exec_Polimento +
                total_exec_Porta_molde + total_exec_Projeto + total_exec_Retifica + total_exec_Tempera + total_exec_torno;
            total_horas_prev = total_horas_Cnc_acab + total_horas_Cnc_des + total_horas_Erosao_edm +
                total_horas_Erosao_ewc + total_horas_fresa + total_horas_Eletrodo + total_horas_Polimento +
                total_horas_Porta_molde + total_horas_Projeto + total_horas_Retifica + total_horas_Tempera + total_horas_torno;
            tb_total_prev.Text = total_horas_prev.ToString("n2");
            tb_total_trab.Text = total_horas_trab.ToString("n2");

        }

        private void ok()
        {
            
            
            dsOp.Clear();
            comando_select.CommandText = "SELECT DESENHO_OP_ATUAL, N_PDF" +
            " FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_molde.Text + "" +
            "' ORDER BY N_PDF";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datOp.SelectCommand = comando_select;

            datOp.Fill(posicoes);

            dgvPosicoes.DataSource = posicoes;
            dgvPosicoes.DataMember = posicoes.Tables[0].TableName;
            dgvPosicoes.Columns[0].Visible = false;
            dgvPosicoes.Columns[1].Width = 33;
            fbConnection1.Close(); 
            /*
            this.datOp.SelectCommand.CommandText =
                "SELECT DESENHO_OP_ATUAL, N_PDF FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_molde.Text + " - %" + "' AND N_PDF != '' ORDER BY N_PDF";
            this.fbConnection1.Open();
            this.datOp.SelectCommand.Connection = fbConnection1;
            this.datOp.SelectCommand.ExecuteNonQuery();
            datOp.Fill(OP);
            //dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cod_peca Like '" + cod_peca_desenhos.Text + " -" + "*'";
            this.fbConnection1.Close(); 
            dgvPosicoes.Columns[0].Visible = false;
             * */
            //dgvPosicoes.Columns[1].Width = 20;


                popula_fresa(link_fresa.Text, "%", tb_molde.Text);
                popula_torno(link_torno.Text, "%", tb_molde.Text);
                popula_cnc_des(link_cnc_desb.Text, "%", tb_molde.Text);
                popula_Tempera(link_tempera.Text, "%", tb_molde.Text);
                popula_Retifica(link_retifica.Text, "%", tb_molde.Text);
                popula_cnc_aca(link_cnc_acab.Text, "%", tb_molde.Text);
                popula_erosao_ewc(link_erosao_ewc.Text, "%", tb_molde.Text);
                popula_erosao_edm(link_erosao_edm.Text, "%", tb_molde.Text);
                popula_polimento(link_polimento.Text, "%", tb_molde.Text);
                popula_projeto("%", "PROJETO", tb_molde.Text);
                popula_porta_molde("%", "PORTA_MOLDE", tb_molde.Text);
                popula_eletrodo("ELETRODO", "%", tb_molde.Text);
                //popula_montagem(link_montagem.Text, "%", tb_molde.Text);         
                
            


        }
        private void popula_eletrodo(string operacao, string pos, string desenho)
        {
            total_exec_Eletrodo = 0;
            total_horas_Eletrodo = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO LIKE '" + operacao + "%' AND FUNCAO_ROTA LIKE 'ELETRODO'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgveletrodo.DataSource = posicoes;
            dgveletrodo.DataMember = posicoes.Tables[0].TableName;
            dgveletrodo.Columns[0].Width = 15;
            dgveletrodo.Columns[0].HeaderText = "Pos";
            dgveletrodo.Columns[1].Width = 30;
            dgveletrodo.Columns[1].HeaderText = "Início";
            dgveletrodo.Columns[2].Width = 30;
            dgveletrodo.Columns[2].HeaderText = "Fim";
            dgveletrodo.Columns[3].Width = 20;
            dgveletrodo.Columns[3].HeaderText = "HP";
            dgveletrodo.Columns[4].Width = 20;
            dgveletrodo.Columns[4].HeaderText = "HE";
            dgveletrodo.Columns[5].Width = 30;
            dgveletrodo.Columns[5].HeaderText = "Ent";
            dgveletrodo.Columns[6].Width = 30;
            dgveletrodo.Columns[6].HeaderText = "Fec";
            dgveletrodo.Columns[7].Width = 30;
            dgveletrodo.Columns[7].HeaderText = "Atual";
            dgveletrodo.Columns[8].Width = 30;
            dgveletrodo.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgveletrodo.RowCount; i++)
            {
                try
                {
                    if (dgveletrodo.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Eletrodo = total_horas_Eletrodo + Convert.ToDouble(dgveletrodo.Rows[i].Cells[3].Value);
                    }
                    if (dgveletrodo.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Eletrodo = total_exec_Eletrodo + Convert.ToDouble(dgveletrodo.Rows[i].Cells[4].Value);
                    }
                    try
                    {
                        if (dgveletrodo.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgveletrodo.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            if (Convert.ToDateTime(dgveletrodo.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[6].Value))
                                dgveletrodo.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgveletrodo.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgveletrodo.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgveletrodo.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgveletrodo.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgveletrodo.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgveletrodo.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgveletrodo.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgveletrodo.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgveletrodo.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgveletrodo.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgveletrodo.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_eletrodo.Text = total_horas_Eletrodo.ToString("n2");
            tb_exec_eletrodo.Text = total_exec_Eletrodo.ToString("n2");

            double porc_eletrodo_parcial;
            for (int i = 0; i < dgveletrodo.RowCount; i++)
            {
                try
                {
                    if (dgveletrodo.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_eletrodo.Text != "" && dgveletrodo.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_eletrodo_parcial = (Convert.ToDouble(dgveletrodo.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_eletrodo.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgveletrodo.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgveletrodo.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            porc_eletrodo = porc_eletrodo + porc_eletrodo_parcial * 100;
                        }
                        else
                        {
                            if (dgveletrodo.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgveletrodo.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgveletrodo.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_eletrodo = porc_eletrodo + ((porc_eletrodo_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_eletrodo = porc_eletrodo + (((Convert.ToDouble(dgveletrodo.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgveletrodo.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_eletrodo_parcial) * 100);
                                }
                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_eletrodo.Text = porc_eletrodo.ToString("n0");
            porc_eletrodo = 0;

        }

        private void popula_porta_molde(string operacao, string pos, string desenho)
        {
            total_horas_Porta_molde = 0;
            total_exec_Porta_molde = 0;
            //VERIFICAR PROBLEMAS NOS SALDO DE HORAS

            comando_select.CommandText = "SELECT OPERACAO_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS," +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO LIKE '%' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;

            datRotas_campo.Fill(posicoes);

            
            dgvporta_molde.DataSource = posicoes;
            dgvporta_molde.DataMember = posicoes.Tables[0].TableName;
            //posicoes.Tables[0].Columns[4].DataType = System.Type.GetType("Double");
            //
            //dgvFresa.AlternatingRowsDefaultCellStyle.Format = "n2";
            //dgvFresa.row
            dgvporta_molde.Columns[0].Width = 40;
            dgvporta_molde.Columns[0].HeaderText = "Oper";
            dgvporta_molde.Columns[1].Width = 30;
            dgvporta_molde.Columns[1].HeaderText = "Início";
            dgvporta_molde.Columns[2].Width = 30;
            dgvporta_molde.Columns[2].HeaderText = "Fim";
            dgvporta_molde.Columns[3].Width = 20;
            dgvporta_molde.Columns[3].HeaderText = "HP";
            dgvporta_molde.Columns[4].Width = 20;
            dgvporta_molde.Columns[4].HeaderText = "HE";
            dgvporta_molde.Columns[5].Width = 30;
            dgvporta_molde.Columns[5].HeaderText = "Ent";
            dgvporta_molde.Columns[6].Width = 30;
            dgvporta_molde.Columns[6].HeaderText = "Fec";
            dgvporta_molde.Columns[7].Width = 30;
            dgvporta_molde.Columns[7].HeaderText = "Atual";
            dgvporta_molde.Columns[8].Width = 30;
            dgvporta_molde.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvporta_molde.RowCount; i++)
            {
                try
                {

                    if (dgvporta_molde.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Porta_molde = total_horas_Porta_molde + Convert.ToDouble(dgvporta_molde.Rows[i].Cells[3].Value);
                    }
                    if (dgvporta_molde.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Porta_molde = total_exec_Porta_molde + Convert.ToDouble(dgvporta_molde.Rows[i].Cells[4].Value);
                    }
                    //finalizados
                    if (dgvporta_molde.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvporta_molde.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvporta_molde.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvporta_molde.Rows[i].Cells[6].Value))
                                dgvporta_molde.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            //na data
                            else
                                dgvporta_molde.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                        catch
                        {
                            dgvporta_molde.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvporta_molde.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvporta_molde.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvporta_molde.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvporta_molde.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvporta_molde.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvporta_molde.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvporta_molde.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvporta_molde.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvporta_molde.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }


                }
                catch { }
            }
            tb_previsao_porta_molde.Text = total_horas_Porta_molde.ToString("n2");
            tb_exec_porta_molde.Text = total_exec_Porta_molde.ToString("n2");
            porc_porta_molde = (total_exec_Porta_molde / total_horas_Porta_molde) * 100;
            //MessageBox.Show(porc_porta_mol
            /*
            for (int i = 0; i < dgvporta_molde.RowCount; i++)
            {
                if (dgvporta_molde.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_porta_molde.Text != "")
                {
                    porc_porta_molde_parcial = (Convert.ToDouble(dgvporta_molde.Rows[i].Cells[3].Value.ToString()) /
                        Convert.ToDouble(tb_previsao_porta_molde.Text));
                    //MessageBox.Show(porc_fresa_parcial.ToString());
                    if (dgvporta_molde.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                        dgvporta_molde.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        porc_porta_molde = porc_porta_molde + porc_porta_molde_parcial * 100;
                    }
                    else
                    {
                        if (dgvporta_molde.Rows[i].Cells[4].Value.ToString() != "")
                        {
                            if (Convert.ToDouble(dgvporta_molde.Rows[i].Cells[4].Value.ToString()) >
                                Convert.ToDouble(dgvporta_molde.Rows[i].Cells[3].Value.ToString()))
                            {
                                porc_porta_molde = porc_porta_molde + ((porc_porta_molde_parcial * 90 / 100) * 100);
                            }
                            else
                            {
                                porc_porta_molde = porc_porta_molde + (((Convert.ToDouble(dgvporta_molde.Rows[i].Cells[4].Value.ToString()) /
                                                Convert.ToDouble(dgvporta_molde.Rows[i].Cells[3].Value.ToString())) *
                                                porc_porta_molde_parcial) * 100);
                            }
                            //MessageBox.Show(porc_fresa.ToString());
                        }
                    }
                }
            }
             * */
            tb_porc_porta_molde.Text = porc_porta_molde.ToString("n0");
            porc_porta_molde = 0;



            //return posicoes;

        }



        private void popula_projeto(string operacao, string pos, string desenho)
        {
            total_horas_Projeto = 0;
            total_exec_Projeto = 0;
            //VERIFICAR PROBLEMAS NOS SALDO DE HORAS

            comando_select.CommandText = "SELECT OPERACAO_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS," +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO LIKE '%' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;

            datRotas_campo.Fill(posicoes);


            dgvProjeto.DataSource = posicoes;
            dgvProjeto.DataMember = posicoes.Tables[0].TableName;
            //posicoes.Tables[0].Columns[4].DataType = System.Type.GetType("Double");
            //
            //dgvFresa.AlternatingRowsDefaultCellStyle.Format = "n2";
            //dgvFresa.row
            dgvProjeto.Columns[0].Width = 40;
            dgvProjeto.Columns[0].HeaderText = "Oper";
            dgvProjeto.Columns[1].Width = 30;
            dgvProjeto.Columns[1].HeaderText = "Início";
            dgvProjeto.Columns[2].Width = 30;
            dgvProjeto.Columns[2].HeaderText = "Fim";
            dgvProjeto.Columns[3].Width = 20;
            dgvProjeto.Columns[3].HeaderText = "HP";
            dgvProjeto.Columns[4].Width = 20;
            dgvProjeto.Columns[4].HeaderText = "HE";
            dgvProjeto.Columns[5].Width = 30;
            dgvProjeto.Columns[5].HeaderText = "Ent";
            dgvProjeto.Columns[6].Width = 30;
            dgvProjeto.Columns[6].HeaderText = "Fec";
            dgvProjeto.Columns[7].Width = 30;
            dgvProjeto.Columns[7].HeaderText = "Atual";
            dgvProjeto.Columns[8].Width = 30;
            dgvProjeto.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvProjeto.RowCount; i++)
            {
                try
                {

                    if (dgvProjeto.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Projeto = total_horas_Projeto + Convert.ToDouble(dgvProjeto.Rows[i].Cells[3].Value);
                    }
                    if (dgvProjeto.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Projeto = total_exec_Projeto + Convert.ToDouble(dgvProjeto.Rows[i].Cells[4].Value);
                    }
                    //finalizados
                    if (dgvProjeto.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvProjeto.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvProjeto.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvProjeto.Rows[i].Cells[6].Value))
                                dgvProjeto.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            //na data
                            else
                                dgvProjeto.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                        catch
                        {
                            dgvProjeto.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvProjeto.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvProjeto.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvProjeto.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvProjeto.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvProjeto.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvProjeto.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvProjeto.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvProjeto.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvProjeto.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }


                }
                catch { }
            }

            tb_previsao_projeto.Text = total_horas_Projeto.ToString("n2");
            tb_exec_projeto.Text = total_exec_Projeto.ToString("n2");

            double porc_projeto_parcial;
            for (int i = 0; i < dgvProjeto.RowCount; i++)
            {
                if (dgvProjeto.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_projeto.Text != "")
                {
                    porc_projeto_parcial = (Convert.ToDouble(dgvProjeto.Rows[i].Cells[3].Value.ToString()) /
                        Convert.ToDouble(tb_previsao_projeto.Text));
                    //MessageBox.Show(porc_fresa_parcial.ToString());
                    if (dgvProjeto.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                        dgvProjeto.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        porc_projeto = porc_projeto + porc_projeto_parcial * 100;
                    }
                    else
                    {
                        if (dgvProjeto.Rows[i].Cells[4].Value.ToString() != "")
                        {
                            if (Convert.ToDouble(dgvProjeto.Rows[i].Cells[4].Value.ToString()) >
                                Convert.ToDouble(dgvProjeto.Rows[i].Cells[3].Value.ToString()))
                            {
                                porc_projeto = porc_projeto + ((porc_projeto_parcial * 90 / 100) * 100);
                            }
                            else
                            {
                                porc_projeto = porc_projeto + (((Convert.ToDouble(dgvProjeto.Rows[i].Cells[4].Value.ToString()) /
                                                Convert.ToDouble(dgvProjeto.Rows[i].Cells[3].Value.ToString())) *
                                                porc_projeto_parcial) * 100);
                            }
                            //MessageBox.Show(porc_fresa.ToString());
                        }
                    }
                }
            }
            tb_porc_projeto.Text = porc_projeto.ToString("n0");
            porc_projeto= 0;

        }

        private void popula_fresa(string operacao, string pos, string desenho)
        {
            total_horas_fresa = 0;
            total_exec_fresa = 0;
            //VERIFICAR PROBLEMAS NOS SALDO DE HORAS
            
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS," +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA " + 
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO LIKE '" + operacao + "%' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvfresa.DataSource = posicoes;
            dgvfresa.DataMember = posicoes.Tables[0].TableName;
            dgvfresa.Columns[0].Width = 15;
            dgvfresa.Columns[0].HeaderText = "Pos";
            dgvfresa.Columns[1].Width = 30;
            dgvfresa.Columns[1].HeaderText = "Início";
            dgvfresa.Columns[2].Width = 30;
            dgvfresa.Columns[2].HeaderText = "Fim";
            dgvfresa.Columns[3].Width = 20;
            dgvfresa.Columns[3].HeaderText = "HP";
            dgvfresa.Columns[4].Width = 20;
            dgvfresa.Columns[4].HeaderText = "HE";
            dgvfresa.Columns[5].Width = 30;
            dgvfresa.Columns[5].HeaderText = "Ent";
            dgvfresa.Columns[6].Width = 30;
            dgvfresa.Columns[6].HeaderText = "Fec";
            dgvfresa.Columns[7].Width = 30;
            dgvfresa.Columns[7].HeaderText = "Atual";
            dgvfresa.Columns[8].Width = 30;
            dgvfresa.Columns[8].HeaderText = "Cod";
            
            
            this.fbConnection1.Close(); 
            
            for (int i = 0; i < dgvfresa.RowCount; i++)
            {
                try
                {

                    if (dgvfresa.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_fresa = total_horas_fresa + Convert.ToDouble(dgvfresa.Rows[i].Cells[3].Value);
                    }
                    if (dgvfresa.Rows[i].Cells[4].Value.ToString() != "")
                    {                        
                        total_exec_fresa = total_exec_fresa + Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value);
                    }
                    //finalizados
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvfresa.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvfresa.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvfresa.Rows[i].Cells[6].Value))
                                dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            //na data
                            else
                                dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                        catch
                        {
                            dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvfresa.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvfresa.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    

                }
                catch { }
            }

            tb_previsao_fresa.Text = total_horas_fresa.ToString("n2");
            tb_exec_fresa.Text = total_exec_fresa.ToString("n2");

            double porc_fresa_parcial;
            for (int i = 0; i < dgvfresa.RowCount; i++)
            {
                //MessageBox.Show(porc_fresa.ToString());
                try
                {
                    if (dgvfresa.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_fresa.Text != "" && dgvfresa.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_fresa_parcial = (Convert.ToDouble(dgvfresa.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_fresa.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgvfresa.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            porc_fresa = porc_fresa + porc_fresa_parcial * 100;
                        }
                        else
                        {
                            if (dgvfresa.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgvfresa.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_fresa = porc_fresa + ((porc_fresa_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_fresa = porc_fresa + (((Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgvfresa.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_fresa_parcial) * 100);
                                }
                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch { }
            }
           // MessageBox.Show(porc_fresa.ToString());
            tb_porc_fresa.Text = porc_fresa.ToString("n0");
            porc_fresa = 0;

            

            //return posicoes;
            
        }
        private void popula_torno(string operacao, string pos, string desenho)
        {
            
            total_horas_torno = 0;
            total_exec_torno = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvtorno.DataSource = posicoes;
            dgvtorno.DataMember = posicoes.Tables[0].TableName;
            dgvtorno.Columns[0].Width = 15;
            dgvtorno.Columns[0].HeaderText = "Pos";
            dgvtorno.Columns[1].Width = 30;
            dgvtorno.Columns[1].HeaderText = "Início";
            dgvtorno.Columns[2].Width = 30;
            dgvtorno.Columns[2].HeaderText = "Fim";
            dgvtorno.Columns[3].Width = 20;
            dgvtorno.Columns[3].HeaderText = "HP";
            dgvtorno.Columns[4].Width = 20;
            dgvtorno.Columns[4].HeaderText = "HE";
            dgvtorno.Columns[5].Width = 30;
            dgvtorno.Columns[5].HeaderText = "Ent";
            dgvtorno.Columns[6].Width = 30;
            dgvtorno.Columns[6].HeaderText = "Fec";
            dgvtorno.Columns[7].Width = 30;
            dgvtorno.Columns[7].HeaderText = "Atual";
            dgvtorno.Columns[8].Width = 30;
            dgvtorno.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvtorno.RowCount; i++)
            {
                try
                {
                    if (dgvtorno.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_torno = total_horas_torno + Convert.ToDouble(dgvtorno.Rows[i].Cells[3].Value);
                    }
                    if (dgvtorno.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_torno = total_exec_torno + Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value);
                    }

                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvtorno.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        try
                        {
                        if (Convert.ToDateTime(dgvtorno.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvtorno.Rows[i].Cells[6].Value))
                            dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                        else
                            dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                        catch
                        {
                            dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgvtorno.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvtorno.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_torno.Text = total_horas_torno.ToString("n2");
            tb_exec_torno.Text = total_exec_torno.ToString("n2");
            double porc_torno_parcial;
            for (int i = 0; i < dgvtorno.RowCount; i++)
            {
                try
                {
                    if (dgvtorno.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_torno.Text != "" && dgvtorno.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_torno_parcial = (Convert.ToDouble(dgvtorno.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_torno.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgvtorno.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            porc_torno = porc_torno + porc_torno_parcial * 100;
                        }
                        else
                        {
                            if (dgvtorno.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgvtorno.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_torno = porc_torno + ((porc_torno_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_torno = porc_torno + (((Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgvtorno.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_torno_parcial) * 100);
                                }
                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_torno.Text = porc_torno.ToString("n0");
            porc_torno = 0;

        
        }
        private void popula_cnc_des(string operacao, string pos, string desenho)
        {
            total_exec_Cnc_des = 0;
            total_horas_Cnc_des = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS," +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvcnc_des.DataSource = posicoes;
            dgvcnc_des.DataMember = posicoes.Tables[0].TableName;
            dgvcnc_des.Columns[0].Width = 15;
            dgvcnc_des.Columns[0].HeaderText = "Pos";
            dgvcnc_des.Columns[1].Width = 30;
            dgvcnc_des.Columns[1].HeaderText = "Início";
            dgvcnc_des.Columns[2].Width = 30;
            dgvcnc_des.Columns[2].HeaderText = "Fim";
            dgvcnc_des.Columns[3].Width = 20;
            dgvcnc_des.Columns[3].HeaderText = "HP";
            dgvcnc_des.Columns[4].Width = 20;
            dgvcnc_des.Columns[4].HeaderText = "HE";
            dgvcnc_des.Columns[5].Width = 30;
            dgvcnc_des.Columns[5].HeaderText = "Ent";
            dgvcnc_des.Columns[6].Width = 30;
            dgvcnc_des.Columns[6].HeaderText = "Fec";
            dgvcnc_des.Columns[7].Width = 30;
            dgvcnc_des.Columns[7].HeaderText = "Atual";
            dgvcnc_des.Columns[8].Width = 30;
            dgvcnc_des.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvcnc_des.RowCount; i++)
            {
                try
                {
                    if (dgvcnc_des.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Cnc_des = total_horas_Cnc_des + Convert.ToDouble(dgvcnc_des.Rows[i].Cells[3].Value);
                    }
                    if (dgvcnc_des.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Cnc_des = total_exec_Cnc_des + Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value);
                    }
                    try
                    {
                        if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            if (Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[6].Value))
                                dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;

                        }
                    }
                    catch
                    {
                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvcnc_des.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_cnc_des.Text = total_horas_Cnc_des.ToString("n2");
            tb_exec_cnc_desb.Text = total_exec_Cnc_des.ToString("n2");

            double porc_cnc_des_parcial;
            for (int i = 0; i < dgvcnc_des.RowCount; i++)
            {
                try
                {
                    if (dgvcnc_des.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_cnc_des.Text != "" && dgvcnc_des.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_cnc_des_parcial = (Convert.ToDouble(dgvcnc_des.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_cnc_des.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {

                            porc_cnc_des = porc_cnc_des + porc_cnc_des_parcial * 100;
                        }
                        else
                        {
                            if (dgvcnc_des.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgvcnc_des.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_cnc_des = porc_cnc_des + ((porc_cnc_des_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_cnc_des = porc_cnc_des + (((Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgvcnc_des.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_cnc_des_parcial) * 100);
                                }
                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_cnc_des.Text = porc_cnc_des.ToString("n0");
            porc_cnc_des = 0;
        }
        private void popula_Tempera(string operacao, string pos, string desenho)
        {
            
            total_horas_Tempera = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvtempera.DataSource = posicoes;
            dgvtempera.DataMember = posicoes.Tables[0].TableName;
            dgvtempera.Columns[0].Width = 15;
            dgvtempera.Columns[0].HeaderText = "Pos";
            dgvtempera.Columns[1].Width = 30;
            dgvtempera.Columns[1].HeaderText = "Início";
            dgvtempera.Columns[2].Width = 30;
            dgvtempera.Columns[2].HeaderText = "Fim";
            dgvtempera.Columns[3].Width = 20;
            dgvtempera.Columns[3].HeaderText = "HP";
            dgvtempera.Columns[4].Width = 20;
            dgvtempera.Columns[4].HeaderText = "HE";
            dgvtempera.Columns[5].Width = 30;
            dgvtempera.Columns[5].HeaderText = "Ent";
            dgvtempera.Columns[6].Width = 30;
            dgvtempera.Columns[6].HeaderText = "Fec";
            dgvtempera.Columns[7].Width = 30;
            dgvtempera.Columns[7].HeaderText = "Atual";
            dgvtempera.Columns[8].Width = 30;
            dgvtempera.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvtempera.RowCount; i++)
            {
                try
                {
                    if (dgvtempera.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Tempera = total_horas_Tempera + Convert.ToDouble(dgvtempera.Rows[i].Cells[3].Value);
                    }
                    try
                    {
                        if (dgvtempera.Rows[i].Cells[7].Value.ToString() == "FINALIZADO")
                        {
                            if (Convert.ToDateTime(dgvtempera.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvtempera.Rows[i].Cells[6].Value))
                                dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgvtempera.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvtempera.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvtempera.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgvtempera.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvtempera.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_tempera.Text = total_horas_Tempera.ToString();
            //int porc_tempera_parcial;
            for (int i = 0; i < dgvtempera.RowCount; i++)
            {
                    if (dgvtempera.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                        dgvtempera.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        porc_tempera++;
                        //MessageBox.Show(porc_tempera.ToString());
                    }
                    
                    
                
            }
            double porc;
            double count = dgvtempera.RowCount;

            //MessageBox.Show(count.ToString());
            if (count > 0)
            {
                porc = (porc_tempera / count) * 100;
            
            
                
                 tb_porc_tempera.Text = porc.ToString("n0");
            }
            else
                tb_porc_tempera.Text = "0";
            porc_tempera = 0;
        }
        private void popula_Retifica(string operacao, string pos, string desenho)
        {
            total_exec_Retifica = 0;
            total_horas_Retifica = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvretifica.DataSource = posicoes;
            dgvretifica.DataMember = posicoes.Tables[0].TableName;
            dgvretifica.Columns[0].Width = 15;
            dgvretifica.Columns[0].HeaderText = "Pos";
            dgvretifica.Columns[1].Width = 30;
            dgvretifica.Columns[1].HeaderText = "Início";
            dgvretifica.Columns[2].Width = 30;
            dgvretifica.Columns[2].HeaderText = "Fim";
            dgvretifica.Columns[3].Width = 20;
            dgvretifica.Columns[3].HeaderText = "HP";
            dgvretifica.Columns[4].Width = 20;
            dgvretifica.Columns[4].HeaderText = "HE";
            dgvretifica.Columns[5].Width = 30;
            dgvretifica.Columns[5].HeaderText = "Ent";
            dgvretifica.Columns[6].Width = 30;
            dgvretifica.Columns[6].HeaderText = "Fec";
            dgvretifica.Columns[7].Width = 30;
            dgvretifica.Columns[7].HeaderText = "Atual";
            dgvretifica.Columns[8].Width = 30;
            dgvretifica.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvretifica.RowCount; i++)
            {
                try
                {
                    if (dgvretifica.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Retifica = total_horas_Retifica + Convert.ToDouble(dgvretifica.Rows[i].Cells[3].Value);
                    }
                    if (dgvretifica.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Retifica = total_exec_Retifica + Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value);
                    }
                    try
                    {
                        if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvretifica.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            if (Convert.ToDateTime(dgvretifica.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvretifica.Rows[i].Cells[6].Value))
                                dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgvretifica.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvretifica.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_retifica.Text = total_horas_Retifica.ToString("n2");
            tb_exec_retifica.Text = total_exec_Retifica.ToString("n2");
            double porc_retifica_parcial;
            for (int i = 0; i < dgvretifica.RowCount; i++)
            {
                try
                {
                    if (dgvretifica.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_retifica.Text != "" && dgvretifica.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_retifica_parcial = (Convert.ToDouble(dgvretifica.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_retifica.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgvretifica.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            porc_retifica = porc_retifica + porc_retifica_parcial * 100;
                        }
                        else
                        {
                            if (dgvretifica.Rows[i].Cells[4].Value.ToString() != "")
                            {

                                if (Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgvretifica.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_retifica = porc_retifica + ((porc_retifica_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_retifica = porc_retifica + (((Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgvretifica.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_retifica_parcial) * 100);
                                }

                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch {
                    //MessageBox.Show("erro");
                }
            }
            //MessageBox.Show(porc_retifica.ToString("n0"));
            tb_porc_retifica.Text = porc_retifica.ToString("n0");
            porc_retifica = 0;
        }
        private void popula_cnc_aca(string operacao, string pos, string desenho)
        {
            total_exec_Cnc_acab = 0;
            total_horas_Cnc_acab = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND (OPERACAO_CAMPO = '" + operacao + "' OR OPERACAO_CAMPO = 'CNC HAAS') AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvcnc_acab.DataSource = posicoes;
            dgvcnc_acab.DataMember = posicoes.Tables[0].TableName;
            dgvcnc_acab.Columns[0].Width = 15;
            dgvcnc_acab.Columns[0].HeaderText = "Pos";
            dgvcnc_acab.Columns[1].Width = 30;
            dgvcnc_acab.Columns[1].HeaderText = "Início";
            dgvcnc_acab.Columns[2].Width = 30;
            dgvcnc_acab.Columns[2].HeaderText = "Fim";
            dgvcnc_acab.Columns[3].Width = 20;
            dgvcnc_acab.Columns[3].HeaderText = "HP";
            dgvcnc_acab.Columns[4].Width = 20;
            dgvcnc_acab.Columns[4].HeaderText = "HE";
            dgvcnc_acab.Columns[5].Width = 30;
            dgvcnc_acab.Columns[5].HeaderText = "Ent";
            dgvcnc_acab.Columns[6].Width = 30;
            dgvcnc_acab.Columns[6].HeaderText = "Fec";
            dgvcnc_acab.Columns[7].Width = 30;
            dgvcnc_acab.Columns[7].HeaderText = "Atual";
            dgvcnc_acab.Columns[8].Width = 30;
            dgvcnc_acab.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                try
                {
                    if (dgvcnc_acab.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Cnc_acab = total_horas_Cnc_acab + Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[3].Value);
                    }
                    if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Cnc_acab = total_exec_Cnc_acab + Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value);
                    }
                    try
                    {
                        if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            if (Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[6].Value))
                                dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvcnc_acab.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_cnc_acab.Text = total_horas_Cnc_acab.ToString("n2");
            tb_exec_cnc_acab.Text = total_exec_Cnc_acab.ToString("n2");

            double porc_cnc_acab_parcial;
            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                try
                {
                    if (dgvcnc_acab.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_cnc_acab.Text != "" && dgvcnc_acab.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_cnc_acab_parcial = (Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_cnc_acab.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            porc_cnc_acab = porc_cnc_acab + porc_cnc_acab_parcial * 100;
                        }
                        else
                        {
                            if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_cnc_acab = porc_cnc_acab + ((porc_cnc_acab_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_cnc_acab = porc_cnc_acab + (((Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_cnc_acab_parcial) * 100);
                                }
                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_cnc_acab.Text = porc_cnc_acab.ToString("n0");
            porc_cnc_acab = 0;
        }
        private void popula_erosao_ewc(string operacao, string pos, string desenho)
        {
            total_exec_Erosao_ewc = 0;
            total_horas_Erosao_ewc = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgverosao_ewc.DataSource = posicoes;
            dgverosao_ewc.DataMember = posicoes.Tables[0].TableName;
            dgverosao_ewc.Columns[0].Width = 15;
            dgverosao_ewc.Columns[0].HeaderText = "Pos";
            dgverosao_ewc.Columns[1].Width = 30;
            dgverosao_ewc.Columns[1].HeaderText = "Início";
            dgverosao_ewc.Columns[2].Width = 30;
            dgverosao_ewc.Columns[2].HeaderText = "Fim";
            dgverosao_ewc.Columns[3].Width = 20;
            dgverosao_ewc.Columns[3].HeaderText = "HP";
            dgverosao_ewc.Columns[4].Width = 20;
            dgverosao_ewc.Columns[4].HeaderText = "HE";
            dgverosao_ewc.Columns[5].Width = 30;
            dgverosao_ewc.Columns[5].HeaderText = "Ent";
            dgverosao_ewc.Columns[6].Width = 30;
            dgverosao_ewc.Columns[6].HeaderText = "Fec";
            dgverosao_ewc.Columns[7].Width = 30;
            dgverosao_ewc.Columns[7].HeaderText = "Atual";
            dgverosao_ewc.Columns[8].Width = 30;
            dgverosao_ewc.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgverosao_ewc.RowCount; i++)
            {
                try
                {
                    if (dgverosao_ewc.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Erosao_ewc = total_horas_Erosao_ewc + Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[3].Value);
                    }
                    if (dgverosao_ewc.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Erosao_ewc = total_exec_Erosao_ewc + Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value);
                    }
                    try
                    {
                        if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "FINALIZADO")
                        {
                            if (Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[6].Value))
                                dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgverosao_ewc.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_erosao_ewc.Text = total_horas_Erosao_ewc.ToString("n2");
            tb_exec_erosao_ewc.Text = total_exec_Erosao_ewc.ToString("n2");

            double porc_erosao_ewc_parcial;
            for (int i = 0; i < dgverosao_ewc.RowCount; i++)
            {
                try
                {
                    if (dgverosao_ewc.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_erosao_ewc.Text != "" && dgverosao_ewc.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_erosao_ewc_parcial = (Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_erosao_ewc.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            porc_erosao_ewc = porc_erosao_ewc + porc_erosao_ewc_parcial * 100;
                        }
                        else
                        {
                            if (dgverosao_ewc.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_erosao_ewc = porc_erosao_ewc + ((porc_erosao_ewc_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_erosao_ewc = porc_erosao_ewc + (((Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_erosao_ewc_parcial) * 100);
                                }
                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch { }
            }
            
            tb_porc_erosao_ewc.Text = porc_erosao_ewc.ToString("n0");
            porc_erosao_ewc = 0;
        
        }
        private void popula_erosao_edm(string operacao, string pos, string desenho)
        {
            total_exec_Erosao_edm = 0;
            total_horas_Erosao_edm = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgverosao_edm.DataSource = posicoes;
            dgverosao_edm.DataMember = posicoes.Tables[0].TableName;
            dgverosao_edm.Columns[0].Width = 15;
            dgverosao_edm.Columns[0].HeaderText = "Pos";
            dgverosao_edm.Columns[1].Width = 30;
            dgverosao_edm.Columns[1].HeaderText = "Início";
            dgverosao_edm.Columns[2].Width = 30;
            dgverosao_edm.Columns[2].HeaderText = "Fim";
            dgverosao_edm.Columns[3].Width = 20;
            dgverosao_edm.Columns[3].HeaderText = "HP";
            dgverosao_edm.Columns[4].Width = 20;
            dgverosao_edm.Columns[4].HeaderText = "HE";
            dgverosao_edm.Columns[5].Width = 30;
            dgverosao_edm.Columns[5].HeaderText = "Ent";
            dgverosao_edm.Columns[6].Width = 30;
            dgverosao_edm.Columns[6].HeaderText = "Fec";
            dgverosao_edm.Columns[7].Width = 30;
            dgverosao_edm.Columns[7].HeaderText = "Atual";
            dgverosao_edm.Columns[8].Width = 30;
            dgverosao_edm.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgverosao_edm.RowCount; i++)
            {
                try
                {
                    if (dgverosao_edm.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Erosao_edm = total_horas_Erosao_edm + Convert.ToDouble(dgverosao_edm.Rows[i].Cells[3].Value);
                    }
                    if (dgverosao_edm.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_exec_Erosao_edm = total_exec_Erosao_edm + Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value);
                    }
                    try
                    {
                        if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            if (Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[6].Value))
                                dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgverosao_edm.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_erosao_edm.Text = total_horas_Erosao_edm.ToString("n2");
            tb_exec_erosao_edm.Text = total_exec_Erosao_edm.ToString("n2");

            double porc_erosao_edm_parcial;
            for (int i = 0; i < dgverosao_edm.RowCount; i++)
            {
                try
                {
                    if (dgverosao_edm.Rows[i].Cells[3].Value.ToString() != "" && tb_previsao_erosao_edm.Text != "" && dgverosao_edm.Rows[i].Cells[3].Value.ToString() != "0")
                    {
                        porc_erosao_edm_parcial = (Convert.ToDouble(dgverosao_edm.Rows[i].Cells[3].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_erosao_edm.Text));
                        //MessageBox.Show(porc_fresa_parcial.ToString());
                        if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                            dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            porc_erosao_edm = porc_erosao_edm + porc_erosao_edm_parcial * 100;
                        }
                        else
                        {
                            if (dgverosao_edm.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value.ToString()) >
                                    Convert.ToDouble(dgverosao_edm.Rows[i].Cells[3].Value.ToString()))
                                {
                                    porc_erosao_edm = porc_erosao_edm + ((porc_erosao_edm_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_erosao_edm = porc_erosao_edm + (((Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value.ToString()) /
                                                    Convert.ToDouble(dgverosao_edm.Rows[i].Cells[3].Value.ToString())) *
                                                    porc_erosao_edm_parcial) * 100);
                                }
                                //MessageBox.Show(porc_fresa.ToString());
                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_erosao_edm.Text = porc_erosao_edm.ToString("n0");
            porc_erosao_edm = 0;
        
        }
        private void popula_polimento(string operacao, string pos, string desenho)
        {
            
            total_horas_Polimento = 0;
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvpolimento.DataSource = posicoes;
            dgvpolimento.DataMember = posicoes.Tables[0].TableName;
            dgvpolimento.Columns[0].Width = 15;
            dgvpolimento.Columns[0].HeaderText = "Pos";
            dgvpolimento.Columns[1].Width = 30;
            dgvpolimento.Columns[1].HeaderText = "Início";
            dgvpolimento.Columns[2].Width = 30;
            dgvpolimento.Columns[2].HeaderText = "Fim";
            dgvpolimento.Columns[3].Width = 20;
            dgvpolimento.Columns[3].HeaderText = "HP";
            dgvpolimento.Columns[4].Width = 20;
            dgvpolimento.Columns[4].HeaderText = "HE";
            dgvpolimento.Columns[5].Width = 30;
            dgvpolimento.Columns[5].HeaderText = "Ent";
            dgvpolimento.Columns[6].Width = 30;
            dgvpolimento.Columns[6].HeaderText = "Fec";
            dgvpolimento.Columns[7].Width = 30;
            dgvpolimento.Columns[7].HeaderText = "Atual";
            dgvpolimento.Columns[8].Width = 30;
            dgvpolimento.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvpolimento.RowCount; i++)
            {
                try
                {
                    if (dgvpolimento.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Polimento = total_horas_Polimento + Convert.ToDouble(dgvpolimento.Rows[i].Cells[3].Value);
                    }
                    try
                    {
                        if (dgvpolimento.Rows[i].Cells[7].Value.ToString() == "FINALIZADO")
                        {
                            if (Convert.ToDateTime(dgvpolimento.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvpolimento.Rows[i].Cells[6].Value))
                                dgvpolimento.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgvpolimento.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgvpolimento.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }

                        
                    //parada
                    if (dgvpolimento.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvpolimento.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //aguardando
                    if (dgvpolimento.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvpolimento.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Em andamento
                    if (dgvpolimento.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvpolimento.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (Convert.ToDateTime(dgvpolimento.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && 
                        dgvpolimento.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                        
                    {
                        dgvpolimento.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_polimento.Text = total_horas_Polimento.ToString();
            //if (tb_previsao_polimento.Text == "0")
            //    tb_previsao_polimento.Text = "1";
            for (int i = 0; i < dgvpolimento.RowCount; i++)
            {
                if (dgvpolimento.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" ||
                    dgvpolimento.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                {
                    porc_polimento++;
                    //MessageBox.Show(porc_tempera.ToString());
                }



            }
            double porc;
            double count = dgvpolimento.RowCount;

            //MessageBox.Show(count.ToString());
            if (count > 0)
            {
                porc = (porc_polimento / count) * 100;



                tb_porc_polimento.Text = porc.ToString("n0");
            }
            else
                tb_porc_polimento.Text = "0";
            porc_polimento = 0;
        
        
        }
        /*
        private void popula_montagem(string operacao, string pos, string desenho)
        {
           
            total_horas_Montagem = 0;
            
            comando_select.CommandText = "SELECT N_PDF_CAMPO, DATA_ENTRADA_PREV," +
            "DATA_FECHAMENTO_PREV, PREVISAO_PRODUCAO, SALDO_HORAS, " +
            " DATA_ENTRADA, DATA_FECHAMENTO, POSICAO_ATUAL, COD_ROTA_CAMPO, FUNCAO_ROTA  " +
            " FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' AND N_PDF_CAMPO LIKE '" + pos +
            "' AND OPERACAO_CAMPO = '" + operacao + "' AND FUNCAO_ROTA LIKE '" + funcao + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datRotas_campo.SelectCommand = comando_select;
            datRotas_campo.Fill(posicoes);
            dgvMontagem.DataSource = posicoes;
            dgvMontagem.DataMember = posicoes.Tables[0].TableName;
            dgvMontagem.Columns[0].Width = 15;
            dgvMontagem.Columns[0].HeaderText = "Pos";
            dgvMontagem.Columns[1].Width = 30;
            dgvMontagem.Columns[1].HeaderText = "Início";
            dgvMontagem.Columns[2].Width = 30;
            dgvMontagem.Columns[2].HeaderText = "Fim";
            dgvMontagem.Columns[3].Width = 20;
            dgvMontagem.Columns[3].HeaderText = "HP";
            dgvMontagem.Columns[4].Width = 20;
            dgvMontagem.Columns[4].HeaderText = "HE";
            dgvMontagem.Columns[5].Width = 30;
            dgvMontagem.Columns[5].HeaderText = "Ent";
            dgvMontagem.Columns[6].Width = 30;
            dgvMontagem.Columns[6].HeaderText = "Fec";
            dgvMontagem.Columns[7].Width = 30;
            dgvMontagem.Columns[7].HeaderText = "Atual";
            dgvMontagem.Columns[8].Width = 30;
            dgvMontagem.Columns[8].HeaderText = "Cod";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvMontagem.RowCount; i++)
            {
                try
                {
                    if (dgvMontagem.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_Montagem = total_horas_Montagem + Convert.ToDouble(dgvMontagem.Rows[i].Cells[3].Value);
                    }
                    try
                    {
                        if (dgvMontagem.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvMontagem.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                        {
                            if (Convert.ToDateTime(dgvMontagem.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvMontagem.Rows[i].Cells[6].Value))
                                dgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.MediumTurquoise;
                            else
                                dgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    catch
                    {
                        dgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    //parada
                    if (dgvMontagem.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        dgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                    //Em andamento
                    if (dgvMontagem.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        dgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    //aguardando
                    if (dgvMontagem.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        dgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (Convert.ToDateTime(dgvMontagem.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && 
                        dgvMontagem.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                        
                    {
                        dgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                catch { }
            }
            tb_previsao_Montagem.Text = total_horas_Montagem.ToString();
        
        
        }
         * */

        private void form_cronograma_detalhado_Load(object sender, EventArgs e)
        {
            if (abrir_os == true)
            {
                tb_molde.Text = os_atual;
                string nova_os = tb_molde.Text;
                dsDesenhos.Clear();
                this.datDesenhos.SelectCommand.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "'";
                this.fbConnection1.Open();
                this.datDesenhos.SelectCommand.Connection = fbConnection1;
                this.datDesenhos.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
                datDesenhos.Fill(DESENHOS);
                if (tb_molde.Text == "")
                {
                    MessageBox.Show("Essa OS não existe");
                }
                else
                {
                    funcao = "%";
                    ok();
                    somar_horas();
                    Atualizar();
                }
            }
            //dgvFresa.AutoGenerateColumns = false;
        }

        

        private void label_a_torno_Click(object sender, EventArgs e)
        {
            dgvtorno.Width = 90;
            dgvcnc_des.Visible = true;
        }

        private void label_p_torno_Click(object sender, EventArgs e)
        {
            dgvtorno.Width = 180;
            dgvcnc_des.Visible = false;
        }

        private void label_a_cnc_desb_Click(object sender, EventArgs e)
        {
            dgvcnc_des.Width = 90;
            dgvtempera.Visible = true;
        }

        private void label_p_cnc_desb_Click(object sender, EventArgs e)
        {
            dgvcnc_des.Width = 180;
            dgvtempera.Visible = false;
        }

        private void label_a_tempera_Click(object sender, EventArgs e)
        {
            dgvtempera.Width = 90;
            dgvretifica.Visible = true;
        }

        private void label_p_retifica_Click(object sender, EventArgs e)
        {
            dgvtempera.Width = 180;
            dgvretifica.Visible = false;
        }

        private void label_a_retifica_Click(object sender, EventArgs e)
        {
            dgvretifica.Width = 90;
            dgvcnc_acab.Visible = true;
        }

        private void label_prox_retifica_Click(object sender, EventArgs e)
        {
            dgvretifica.Width = 180;
            dgvcnc_acab.Visible = false;
        }

        private void label_a_cnc_acab_Click(object sender, EventArgs e)
        {
            dgvcnc_acab.Width = 90;
            dgverosao_ewc.Visible = true;
        }

        private void label_p_cnc_acab_Click(object sender, EventArgs e)
        {
            dgvcnc_acab.Width = 180;
            dgverosao_ewc.Visible = false;
        }

        private void label_a_erosao_ewc_Click(object sender, EventArgs e)
        {
            dgverosao_ewc.Width = 90;
            dgverosao_edm.Visible = true;
        }

        private void label_p_erosao_ewc_Click(object sender, EventArgs e)
        {
            dgverosao_ewc.Width = 180;
            dgverosao_edm.Visible = false;
        }

        private void label_a_erosao_edm_Click(object sender, EventArgs e)
        {
            dgverosao_edm.Width = 90;
            dgvpolimento.Visible = true;
        }

        private void label_p_erosao_edm_Click(object sender, EventArgs e)
        {
            dgverosao_edm.Width = 180;
            dgvpolimento.Visible = false;
        }

        private void label_a_polimento_Click(object sender, EventArgs e)
        {
            dgvpolimento.Width = 90;
            dgveletrodo.Visible = true;
        }

        private void label_p_polimento_Click(object sender, EventArgs e)
        {
            dgvpolimento.Width = 180;
            dgveletrodo.Visible = false;
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            this.datImp_os.UpdateCommand.CommandText =
                    "UPDATE IMP_OS SET N_IMP_OS = '" + tb_molde.Text + "'";
            this.fbConnection1.Open();
            this.datImp_os.UpdateCommand.Connection = fbConnection1;
            this.datImp_os.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 

            this.datImp_os.SelectCommand.CommandText =
            "SELECT * FROM IMP_OS";
            this.fbConnection1.Open();
            this.datImp_os.SelectCommand.Connection = fbConnection1;
            this.datImp_os.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            insere_fresa();
            insere_torno();
            insere_cnc_desb();
            insere_retifica();
            insere_cnc_acab();
            insere_erosao_ewc();
            insere_erosao_edm();
            
            dsOperacoes operacoes = new dsOperacoes();
            fbConnection1.Open();
            datImp_fresa.Fill(operacoes.IMP_FRESA);
            datImp_torno.Fill(operacoes.IMP_TORNO);
            datImp_cnc_desb.Fill(operacoes.IMP_CNC_DESBASTE);
            datImp_retifica.Fill(operacoes.IMP_RETIFICA);
            datImp_cnc_acab.Fill(operacoes.IMP_CNC_ACAB);
            datImp_erosao_edm.Fill(operacoes.IMP_EROSAO_EDM);
            datImp_erosao_ewc.Fill(operacoes.IMP_EROSAO_EWC);
            datImp_os.Fill(operacoes.IMP_OS);


            fbConnection1.Close(); 
            
            crOperacoes nova = new crOperacoes();
            nova.SetDataSource(operacoes);
            
            
            form_imprimir imprimir = new form_imprimir(nova);
            imprimir.Show();


            
        }

        private void insere_fresa()
        {
            //apaga registros anteriores
            this.datImp_fresa.DeleteCommand.CommandText =
                "DELETE FROM IMP_FRESA";
            this.fbConnection1.Open();
            this.datImp_fresa.DeleteCommand.Connection = fbConnection1;
            this.datImp_fresa.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvfresa.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    if (dgvfresa.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        total_horas_fresa = total_horas_fresa + Convert.ToDouble(dgvfresa.Rows[i].Cells[3].Value);
                    }
                    //finalizados
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvfresa.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvfresa.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvfresa.Rows[i].Cells[6].Value))
                                posicao_atual = 3;
                            //na data
                            else
                                posicao_atual = 5;
                        }
                        catch
                        {
                            dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvfresa.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvfresa.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvfresa.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }


                }
                catch { }
                if (dgvfresa.Rows[i].Cells[3].Value.ToString() == "")
                    dgvfresa.Rows[i].Cells[3].Value = "0";
                if (dgvfresa.Rows[i].Cells[4].Value.ToString() == "")
                    dgvfresa.Rows[i].Cells[4].Value = "0";
                //insere os novos dados
                try
                {
                     ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvfresa.Rows[i].Cells[1].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvfresa.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                try
                {
                    ent_real = "'" + Convert.ToString(Convert.ToDateTime(dgvfresa.Rows[i].Cells[5].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_real = "null"; }
                try
                {
                    fec_real = "'" + Convert.ToString(Convert.ToDateTime(dgvfresa.Rows[i].Cells[6].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_real = "null"; }

                this.datImp_fresa.InsertCommand.CommandText =
                "INSERT INTO IMP_FRESA (POSICAO_IMP_FRESA, INICIO_IMP_FRESA, " +
                "FIM_IMP_FRESA, ENTRADA_IMP_FRESA, FECHAMENTO_IMP_FRESA, HORAS_TRAB_IMP_FRESA, " +
                "HORAS_PREV_IMP_FRESA, SIT_ATUAL_IMP_FRESA)" +
                "VALUES ('" + dgvfresa.Rows[i].Cells[0].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + "," +
                ent_real + "," + fec_real+ ",'" +
                dgvfresa.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                dgvfresa.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_fresa.InsertCommand.Connection = fbConnection1;
                this.datImp_fresa.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
                
                

            }


            //seleciona os registros inseridos
            this.datImp_fresa.SelectCommand.CommandText =
            "SELECT * FROM IMP_FRESA ORDER BY COD_IMP_FRESA";
            this.fbConnection1.Open();
            this.datImp_fresa.SelectCommand.Connection = fbConnection1;
            this.datImp_fresa.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 

            
        }

        private void insere_torno()
        {
            //apaga registros anteriores
            this.datImp_torno.DeleteCommand.CommandText =
                "DELETE FROM IMP_TORNO";
            this.fbConnection1.Open();
            this.datImp_torno.DeleteCommand.Connection = fbConnection1;
            this.datImp_torno.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvtorno.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    //finalizados
                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvtorno.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvtorno.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvtorno.Rows[i].Cells[6].Value))
                                posicao_atual = 3;
                            //na data
                            else
                                posicao_atual = 5;
                        }
                        catch
                        {
                            dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvtorno.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvtorno.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvtorno.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }


                }
                catch { }
                if (dgvtorno.Rows[i].Cells[3].Value.ToString() == "")
                    dgvtorno.Rows[i].Cells[3].Value = "0";
                if (dgvtorno.Rows[i].Cells[4].Value.ToString() == "")
                    dgvtorno.Rows[i].Cells[4].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvtorno.Rows[i].Cells[1].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvtorno.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                try
                {
                    ent_real = "'" + Convert.ToString(Convert.ToDateTime(dgvtorno.Rows[i].Cells[5].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_real = "null"; }
                try
                {
                    fec_real = "'" + Convert.ToString(Convert.ToDateTime(dgvtorno.Rows[i].Cells[6].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_real = "null"; }

                this.datImp_torno.InsertCommand.CommandText =
                "INSERT INTO IMP_TORNO (POSICAO_IMP_TORNO, INICIO_IMP_TORNO, " +
                "FIM_IMP_TORNO, ENTRADA_IMP_TORNO, FECHAMENTO_IMP_TORNO, HORAS_TRAB_IMP_TORNO, " +
                "HORAS_PREV_IMP_TORNO, SIT_ATUAL_IMP_TORNO)" +
                "VALUES ('" + dgvtorno.Rows[i].Cells[0].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + "," +
                ent_real + "," + fec_real + ",'" +
                dgvtorno.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                dgvtorno.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_torno.InsertCommand.Connection = fbConnection1;
                this.datImp_torno.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }


            //seleciona os registros inseridos
            this.datImp_torno.SelectCommand.CommandText =
            "SELECT * FROM IMP_TORNO ORDER BY CODIGO_IMP_TORNO";
            this.fbConnection1.Open();
            this.datImp_torno.SelectCommand.Connection = fbConnection1;
            this.datImp_torno.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_cnc_desb()
        {
            //apaga registros anteriores
            this.datImp_cnc_desb.DeleteCommand.CommandText =
                "DELETE FROM IMP_CNC_DESBASTE";
            this.fbConnection1.Open();
            this.datImp_cnc_desb.DeleteCommand.Connection = fbConnection1;
            this.datImp_cnc_desb.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvcnc_des.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    //finalizados
                    if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[6].Value))
                                posicao_atual = 3;
                            //na data
                            else
                                posicao_atual = 5;
                        }
                        catch
                        {
                            dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvcnc_des.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvcnc_des.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }


                }
                catch { }
                if (dgvcnc_des.Rows[i].Cells[3].Value.ToString() == "")
                    dgvcnc_des.Rows[i].Cells[3].Value = "0";
                if (dgvcnc_des.Rows[i].Cells[4].Value.ToString() == "")
                    dgvcnc_des.Rows[i].Cells[4].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[1].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                try
                {
                    ent_real = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[5].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_real = "null"; }
                try
                {
                    fec_real = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[6].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_real = "null"; }

                this.datImp_cnc_desb.InsertCommand.CommandText =
                "INSERT INTO IMP_CNC_DESBASTE (POSICAO_IMP_CNC_DESBASTE, INICIO_IMP_CNC_DESBASTE, " +
                "FIM_IMP_CNC_DESBASTE, ENTRADA_IMP_CNC_DESBASTE, FECHAMENTO_IMP_CNC_DESBASTE, HORAS_TRAB_IMP_CNC_DESBASTE, " +
                "HORAS_PREV_IMP_CNC_DESBASTE, SIT_ATUAL_IMP_CNC_DESBASTE)" +
                "VALUES ('" + dgvcnc_des.Rows[i].Cells[0].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + "," +
                ent_real + "," + fec_real + ",'" +
                dgvcnc_des.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                dgvcnc_des.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_cnc_desb.InsertCommand.Connection = fbConnection1;
                this.datImp_cnc_desb.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }


            //seleciona os registros inseridos
            this.datImp_cnc_desb.SelectCommand.CommandText =
            "SELECT * FROM IMP_CNC_DESBASTE ORDER BY CODIGO_IMP_CNC_DESBASTE";
            this.fbConnection1.Open();
            this.datImp_cnc_desb.SelectCommand.Connection = fbConnection1;
            this.datImp_cnc_desb.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_retifica()
        {
            //apaga registros anteriores
            this.datImp_retifica.DeleteCommand.CommandText =
                "DELETE FROM IMP_RETIFICA";
            this.fbConnection1.Open();
            this.datImp_retifica.DeleteCommand.Connection = fbConnection1;
            this.datImp_retifica.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvretifica.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {
                    if (dgvretifica.Rows[i].Cells[1].Value.ToString() == "")
                        dgvretifica.Rows[i].Cells[1].Value = dgvretifica.Rows[i].Cells[5].Value;
                    if (dgvretifica.Rows[i].Cells[2].Value.ToString() == "")
                        dgvretifica.Rows[i].Cells[2].Value = dgvretifica.Rows[i].Cells[6].Value;
                    //finalizados
                    if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvretifica.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvretifica.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvretifica.Rows[i].Cells[6].Value))
                                posicao_atual = 3;
                            //na data
                            else
                                posicao_atual = 5;
                        }
                        catch
                        {
                            dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvretifica.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvretifica.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvretifica.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }


                }
                catch { }
                if (dgvretifica.Rows[i].Cells[3].Value.ToString() == "")
                    dgvretifica.Rows[i].Cells[3].Value = "0";
                if (dgvretifica.Rows[i].Cells[4].Value.ToString() == "")
                    dgvretifica.Rows[i].Cells[4].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvretifica.Rows[i].Cells[1].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvretifica.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                try
                {
                    ent_real = "'" + Convert.ToString(Convert.ToDateTime(dgvretifica.Rows[i].Cells[5].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_real = "null"; }
                try
                {
                    fec_real = "'" + Convert.ToString(Convert.ToDateTime(dgvretifica.Rows[i].Cells[6].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_real = "null"; }

                this.datImp_retifica.InsertCommand.CommandText =
                "INSERT INTO IMP_RETIFICA (POSICAO_IMP_RETIFICA, INICIO_IMP_RETIFICA, " +
                "FIM_IMP_RETIFICA, ENTRADA_IMP_RETIFICA, FECHAMENTO_IMP_RETIFICA, HORAS_TRAB_IMP_RETIFICA, " +
                "HORAS_PREV_IMP_RETIFICA, SIT_ATUAL_IMP_RETIFICA)" +
                "VALUES ('" + dgvretifica.Rows[i].Cells[0].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + "," +
                ent_real + "," + fec_real + ",'" +
                dgvretifica.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                dgvretifica.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_retifica.InsertCommand.Connection = fbConnection1;
                this.datImp_retifica.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }


            //seleciona os registros inseridos
            this.datImp_retifica.SelectCommand.CommandText =
            "SELECT * FROM IMP_RETIFICA ORDER BY CODIGO_IMP_RETIFICA";
            this.fbConnection1.Open();
            this.datImp_retifica.SelectCommand.Connection = fbConnection1;
            this.datImp_retifica.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_erosao_ewc()
        {
            //apaga registros anteriores
            this.datImp_erosao_ewc.DeleteCommand.CommandText =
                "DELETE FROM IMP_EROSAO_EWC";
            this.fbConnection1.Open();
            this.datImp_erosao_ewc.DeleteCommand.Connection = fbConnection1;
            this.datImp_erosao_ewc.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgverosao_ewc.RowCount; i++)
            {
                //MessageBox.Show("chegou");
                //escolhe a posicao atual
                try
                {

                    //finalizados
                    if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[6].Value))
                                posicao_atual = 3;
                            //na data
                            else
                                posicao_atual = 5;
                        }
                        catch
                        {
                            dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgverosao_ewc.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgverosao_ewc.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }


                }
                catch { }
                if (dgverosao_ewc.Rows[i].Cells[3].Value.ToString() == "")
                    dgverosao_ewc.Rows[i].Cells[3].Value = "0";
                if (dgverosao_ewc.Rows[i].Cells[4].Value.ToString() == "")
                    dgverosao_ewc.Rows[i].Cells[4].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[1].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                try
                {
                    ent_real = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[5].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_real = "null"; }
                try
                {
                    fec_real = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[6].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_real = "null"; }

                this.datImp_erosao_ewc.InsertCommand.CommandText =
                "INSERT INTO IMP_EROSAO_EWC (POSICAO_IMP_EROSAO_EWC, INICIO_IMP_EROSAO_EWC, " +
                "FIM_IMP_EROSAO_EWC, ENTRADA_IMP_EROSAO_EWC, FECHAMENTO_IMP_EROSAO_EWC, HORAS_TRAB_IMP_EROSAO_EWC, " +
                "HORAS_PREV_IMP_EROSAO_EWC, SIT_ATUAL_IMP_EROSAO_EWC)" +
                "VALUES ('" + dgverosao_ewc.Rows[i].Cells[0].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + "," +
                ent_real + "," + fec_real + ",'" +
                dgverosao_ewc.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                dgverosao_ewc.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_erosao_ewc.InsertCommand.Connection = fbConnection1;
                this.datImp_erosao_ewc.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }


            //seleciona os registros inseridos
            this.datImp_erosao_ewc.SelectCommand.CommandText =
            "SELECT * FROM IMP_EROSAO_EWC ORDER BY CODIGO_IMP_EROSAO_EWC";
            this.fbConnection1.Open();
            this.datImp_erosao_ewc.SelectCommand.Connection = fbConnection1;
            this.datImp_erosao_ewc.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_cnc_acab()
        {
            //apaga registros anteriores
            this.datImp_cnc_acab.DeleteCommand.CommandText =
                "DELETE FROM IMP_CNC_ACAB";
            this.fbConnection1.Open();
            this.datImp_cnc_acab.DeleteCommand.Connection = fbConnection1;
            this.datImp_cnc_acab.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    //finalizados
                    if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[6].Value))
                                posicao_atual = 3;
                            //na data
                            else
                                posicao_atual = 5;
                        }
                        catch
                        {
                            dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvcnc_acab.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvcnc_acab.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }


                }
                catch { }
                if (dgvcnc_acab.Rows[i].Cells[3].Value.ToString() == "")
                    dgvcnc_acab.Rows[i].Cells[3].Value = "0";
                if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() == "")
                    dgvcnc_acab.Rows[i].Cells[4].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[1].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                try
                {
                    ent_real = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[5].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_real = "null"; }
                try
                {
                    fec_real = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[6].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_real = "null"; }

                this.datImp_cnc_acab.InsertCommand.CommandText =
                "INSERT INTO IMP_CNC_ACAB (POSICAO_IMP_CNC_ACAB, INICIO_IMP_CNC_ACAB, " +
                "FIM_IMP_CNC_ACAB, ENTRADA_IMP_CNC_ACAB, FECHAMENTO_IMP_CNC_ACAB, HORAS_TRAB_IMP_CNC_ACAB, " +
                "HORAS_PREV_IMP_CNC_ACAB, SIT_ATUAL_IMP_CNC_ACAB)" +
                "VALUES ('" + dgvcnc_acab.Rows[i].Cells[0].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + "," +
                ent_real + "," + fec_real + ",'" +
                dgvcnc_acab.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                dgvcnc_acab.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_cnc_acab.InsertCommand.Connection = fbConnection1;
                this.datImp_cnc_acab.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }


            //seleciona os registros inseridos
            this.datImp_cnc_acab.SelectCommand.CommandText =
            "SELECT * FROM IMP_CNC_ACAB ORDER BY CODIGO_IMP_CNC_ACAB";
            this.fbConnection1.Open();
            this.datImp_cnc_acab.SelectCommand.Connection = fbConnection1;
            this.datImp_cnc_acab.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_erosao_edm()
        {
            //apaga registros anteriores
            this.datImp_erosao_edm.DeleteCommand.CommandText =
                "DELETE FROM IMP_EROSAO_EDM";
            this.fbConnection1.Open();
            this.datImp_erosao_edm.DeleteCommand.Connection = fbConnection1;
            this.datImp_erosao_edm.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgverosao_edm.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    //finalizados
                    if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "FINALIZADO" || dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        try
                        {
                            if (Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[2].Value) < Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[6].Value))
                                posicao_atual = 3;
                            //na data
                            else
                                posicao_atual = 5;
                        }
                        catch
                        {
                            dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                    }
                    //parada
                    if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgverosao_edm.Rows[i].Cells[7].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[2].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgverosao_edm.Rows[i].Cells[7].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }


                }
                catch { }
                if (dgverosao_edm.Rows[i].Cells[3].Value.ToString() == "")
                    dgverosao_edm.Rows[i].Cells[3].Value = "0";
                if (dgverosao_edm.Rows[i].Cells[4].Value.ToString() == "")
                    dgverosao_edm.Rows[i].Cells[4].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[1].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                try
                {
                    ent_real = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[5].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_real = "null"; }
                try
                {
                    fec_real = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[6].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_real = "null"; }

                this.datImp_erosao_edm.InsertCommand.CommandText =
                "INSERT INTO IMP_EROSAO_EDM (POSICAO_IMP_EROSAO_EDM, INICIO_IMP_EROSAO_EDM, " +
                "FIM_IMP_EROSAO_EDM, ENTRADA_IMP_EROSAO_EDM, FECHAMENTO_IMP_EROSAO_EDM, HORAS_TRAB_IMP_EROSAO_EDM, " +
                "HORAS_PREV_IMP_EROSAO_EDM, SIT_ATUAL_IMP_EROSAO_EDM)" +
                "VALUES ('" + dgverosao_edm.Rows[i].Cells[0].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + "," +
                ent_real + "," + fec_real + ",'" +
                dgverosao_edm.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                dgverosao_edm.Rows[i].Cells[3].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_erosao_edm.InsertCommand.Connection = fbConnection1;
                this.datImp_erosao_edm.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }


            //seleciona os registros inseridos
            this.datImp_erosao_edm.SelectCommand.CommandText =
            "SELECT * FROM IMP_EROSAO_EDM ORDER BY CODIGO_IMP_EROSAO_EDM";
            this.fbConnection1.Open();
            this.datImp_erosao_edm.SelectCommand.Connection = fbConnection1;
            this.datImp_erosao_edm.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }


        
        

        

       

        

        

        

        
        /*
        private void dgvMontagem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvMontagem.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }
        */
        private void dgvFresa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.datCrono_ferramental.SelectCommand.CommandText =
            "SELECT * FROM CRONO_FERRAMENTAL ORDER BY COD_CRONO";
            this.fbConnection1.Open();
            this.datCrono_ferramental.SelectCommand.Connection = fbConnection1;
            this.datCrono_ferramental.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


            dsCronograma_ferramental operacoes = new dsCronograma_ferramental();
            fbConnection1.Open();

            datCrono_ferramental.Fill(operacoes.CRONO_FERRAMENTAL);
            

            fbConnection1.Close(); 

            crCronograma_ferramental nova = new crCronograma_ferramental();
            nova.SetDataSource(operacoes);


            form_imprimir imprimir = new form_imprimir(nova);
            imprimir.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            funcao = "%";
            ok();
            gerar_grafico();
            primeira = true;
            //projeto
            funcao = radioButton1.Text;
            ok();
            //try
            //{
                gerar_grafico();
            //}
           // catch { }
            //Cavidade do Lado Fixo
            funcao = radioButton2.Text;
            ok();
            //try
           // {
                gerar_grafico();
           // }
           // catch { }
            //Cavidade do Lado Movel
            funcao = radioButton3.Text;
            ok();
           // try
           // {
                gerar_grafico();
           // }
           // catch { }
            //Postiços Gavetas
            funcao = radioButton4.Text;
            ok();
           // try
           // {
                gerar_grafico();
           // }
           // catch { }
            //Acessórios
            funcao = radioButton5.Text;
            ok();
           // try
           // {
                gerar_grafico();
          //  }
          //  catch { }
            //Porta Molde
            funcao = radioButton6.Text;
            ok();
          //  try
           // {
                gerar_grafico();
           // }
           // catch { }
            
            primeira = false;
            gerar_htm();

            System.Diagnostics.Process.Start(@"c:\\evolucao\\cronograma_ferramental.htm");


        }

        private void  gerar_htm()
        {
            FileInfo d = new FileInfo("c:\\evolucao\\cronograma_ferramental.htm");
            d.Delete();
            FileInfo t = new FileInfo("c:\\evolucao\\cronograma_ferramental.txt");
            try
            {
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("<html xmlns='http://www.w3.org/1999/xhtml'>");
                    texto.WriteLine("<head>");
                    texto.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1' />");
                    texto.WriteLine("<title>Cronograma de Desenvolvimento do Ferramental</title>");
                    texto.WriteLine("<link rel='stylesheet' href='../Contents/Style.css' type='text/css' />");
                    texto.WriteLine("<script language='JavaScript' src='FusionCharts.js'></script>");
                    texto.WriteLine("</head>");
                    texto.WriteLine("<body>");
                    texto.WriteLine("<table width='97%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>");
                    texto.WriteLine("<tr bordercolor='#000000'>");
                    texto.WriteLine("<td width='25%' align='center' valign='top' class='text'><font color='#996600' size='+1' face='Verdana, Arial, Helvetica, sans-serif'><img src='logo.jpg' width='179' height='74'></font><font face='Verdana, Arial, Helvetica, sans-serif'>&nbsp;</font></td>");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'><div align='left'><p align='center'><font color='#996600' size='+2' face='Verdana, Arial, Helvetica, sans-serif'>CRONOGRAMA DE DESENVOLVIMENTO </font></p><p align='center'><font color='#996600' size='+2' face='Verdana, Arial, Helvetica, sans-serif'>DO FERRAMENTAL</font></p></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#000000'> </tr>");
                    texto.WriteLine("<tr bordercolor='#000000'>");
                    texto.WriteLine("<td rowspan='2' align='center' valign='top' class='text'> <div align='left'><font size='+3' face='Verdana, Arial, Helvetica, sans-serif'><strong>OS: " + tb_molde.Text + "</strong></font></div></td>");
                    texto.WriteLine("<td width='29%' align='center' valign='top' class='text'><div align='left'><font face='Arial, Helvetica, sans-serif'><strong>CLIENTE: </strong>" + tb_cliente.Text + "</font></div></td>");
                    texto.WriteLine("<td width='21%' align='center' valign='top' class='text'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'><strong>Entrega: </strong> " + tb_data.Text + " </font></td>");
                    texto.WriteLine("<td width='25%' align='center' valign='top' class='text'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'><strong>Projetista:</strong> " + tb_projetista.Text + " </font></td>");
                    texto.WriteLine(" </tr>");
                    texto.WriteLine("<tr bordercolor='#000000'> ");
                    texto.WriteLine("<td colspan='2' align='center' valign='top' class='text'><div align='left'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'><strong>Nome do Produto:</strong> " + tb_nome.Text  + " </font></div></td>");
                    //texto.WriteLine("<td width='19%' align='center' valign='top' class='text'><div align='left'></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("<table width='97%' border='0' align='center'>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'></font>&nbsp;</td></tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'>Projeto</font></td></tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'>");
                    texto.WriteLine("<td colspan='4' align='center' nowrap class='text'> <div id='chartdiv1' align='center'>");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('Projeto.swf', 'ChartId1', '750', '200');");
                    texto.WriteLine("chart.setDataURL('Projeto.xml');");
                    texto.WriteLine("chart.render('chartdiv1');");
                    texto.WriteLine("</script> </td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'>Cavidade Lado Fixo</font></td></tr>");
                    texto.WriteLine("<tr bordercolor='#FF0000' bgcolor='#FFFFFF'>");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'> <div id='chartdiv2' align='center'> ");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('Cavidade_do_Lado_Fixo.swf', 'ChartId2', '750', '270');");
                    texto.WriteLine("chart.setDataURL('Cavidade_do_Lado_Fixo.xml');");
                    texto.WriteLine("chart.render('chartdiv2');");
                    texto.WriteLine("</script> </td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'>Cavidade Lado M&oacute;vel</font></td></tr>");                    
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'> <div id='chartdiv3' align='center'> ");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('Cavidade_Lado_Movel.swf', 'ChartId3', '750', '270');");
                    texto.WriteLine("chart.setDataURL('Cavidade_Lado_Movel.xml');");
                    texto.WriteLine("chart.render('chartdiv3');");
                    texto.WriteLine("</script> </td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'></font></td></tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'></font></td></tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'> <td colspan='4' align='center' nowrap class='text'><div align='left'><img src='LEGENDA.jpg' width='315' height='29'></div></td> </tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'> <td colspan='4' align='center' nowrap class='text'><div align='right'><font size='1' face='Verdana, Arial, Helvetica, sans-serif'>Desenvolvido por Evolu&ccedil;&atilde;o Inform&aacute;tica</font> </div></td></tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("<table width='97%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000' dwcopytype='CopyTableRow'>");
                    texto.WriteLine("<tr bordercolor='#000000'>");
                    texto.WriteLine("<td width='28%' rowspan='2' align='center' valign='top' class='text'> <div align='left'><font size='+3' face='Verdana, Arial, Helvetica, sans-serif'><strong>OS: </strong>" + tb_molde.Text + "</font></div></td>");
                    texto.WriteLine("<td width='29%' align='center' valign='top' class='text'><div align='left'><font face='Arial, Helvetica, sans-serif'><strong>CLIENTE: </strong>" + tb_cliente.Text + "</font></div></td>");
                    texto.WriteLine("<td width='21%' align='center' valign='top' class='text'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'><strong>Entrega: </strong>" + tb_data.Text + " </font></td>");
                    texto.WriteLine("<td width='22%' align='center' valign='top' class='text'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'><strong>Projetista: </strong>" + tb_projetista.Text + " </font></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#000000'> <td colspan='2' align='center' valign='top' class='text'><div align='left'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'><strong>Nome do Produto: </strong>" + tb_nome.Text + "  </font></div></td></tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine(" <table width='97%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000' dwcopytype='CopyTableRow'>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'>&nbsp;</td></tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'>Posti&ccedil;os / Gavetas / Segmentos M&oacute;veis</font></td></tr>");                    
                    texto.WriteLine("  <tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'> <div id='chartdiv4' align='center'> ");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('Posticos_Gavetas_Segmentos_Moveis.swf', 'ChartId4', '750', '270');");
                    texto.WriteLine("chart.setDataURL('Posticos_Gavetas_Segmentos_Moveis.xml');");
                    texto.WriteLine("chart.render('chartdiv4');");
                    texto.WriteLine("</script> </td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'>Acess&oacute;rios</font></td></tr>");                    
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'> <div id='chartdiv5' align='center'> ");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('Acessorios.swf', 'ChartId5', '750', '270');");
                    texto.WriteLine("chart.setDataURL('Acessorios.xml');");
                    texto.WriteLine("chart.render('chartdiv5');");
                    texto.WriteLine("</script> </td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr valign='middle' bordercolor='#FF0000' bgcolor='#FFFFFF'><td colspan='4' align='center' nowrap class='text'><font color='#000000' size='+2' face='Arial, Helvetica, sans-serif'>Porta Molde</font></td></tr>");                    
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'><div id='chartdiv6' align='center'> ");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('Porta_Molde.swf', 'ChartId6', '750', '285');");
                    texto.WriteLine("chart.setDataURL('Porta_Molde.xml');");
                    texto.WriteLine("chart.render('chartdiv6');");
                    texto.WriteLine("</script></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'><div align='left'><font face='Verdana, Arial, Helvetica, sans-serif'>Observa&ccedil;&otilde;es: ");
                    texto.WriteLine("</font> </div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("<table> <tr> <td width='315'> <p><img src='LEGENDA.jpg' width='315' height='29'></p> <td width='629'><p align='right'><font size='1' face='Verdana, Arial, Helvetica, sans-serif'>Desenvolvido por Evolu&ccedil;&atilde;o Inform&aacute;tica</font> </p> </tr></table>");
                    texto.WriteLine("</body>");
                    texto.WriteLine("</html>");
                }
                t.CopyTo(Path.ChangeExtension(t.FullName, ".htm"), false);
            
            
            }
            catch{}


        }

        private void gerar_grafico()
        {
            
            
            verificar_datas();
            cria_xml();
        }
        
        private void verificar_datas()
        {
            
                primeiro_dia = achar_primeira_semana();
                ultimo_dia = achar_ultima_semana();

                ano_primeiro = achar_primeira_semana().Year;
                ano_ultimo = achar_ultima_semana().Year;
            
            primeira_semana = 1 + conferir_semana(primeiro_dia) / 7;
            ultima_semana = 1 + conferir_semana(ultimo_dia) / 7;
            //MessageBox.Show(ultima_semana.ToString());
            //MessageBox.Show(primeira_semana.ToString());
            n_semana = 1 + (ultima_semana - primeira_semana);
            //semana_ano = new int[50, 2];
            dsSemana_ano.Clear();
            this.datSemana_ano.SelectCommand.CommandText =
                    "SELECT *" +
                " FROM SEMANA_ANO WHERE ANO_SEMANA_ANO LIKE '" + primeiro_dia.Year.ToString() + "' ORDER BY SEMANA_SEMANA_ANO DESC";
            this.fbConnection1.Open();
            this.datSemana_ano.SelectCommand.Connection = fbConnection1;
            this.datSemana_ano.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            datSemana_ano.Fill(SEMANA_ANO);
            
            if (n_semana < 0)
            {


                n_semana = Convert.ToInt32(tb_sem.Text) - primeira_semana + ultima_semana;



            }
            if (tb_sem.Text == "")
                tb_sem.Text = "53";
            prim_var = primeira_semana;
            ano_var = ano_primeiro;
            for (int i = 0; i < n_semana; i++)
            {
                semana_ano[i, 0] = prim_var;
                semana_ano[i, 1] = ano_var;
                prim_var++;
                if (prim_var > Convert.ToInt32(tb_sem.Text))
                {
                    prim_var = 2;
                    ano_var = ano_var + 1;
                }

            }
            if (primeira == true)
            {
                primeiro_dia = primeiro_dia2;
                ultimo_dia = ultimo_dia2;

                ano_primeiro = ano_primeiro2; ;// = achar_primeira_semana().Year;
                ano_ultimo = ano_ultimo2;// = achar_ultima_semana().Year;

                primeira_semana = primeira_semana2; ;// = 1 + conferir_semana(primeiro_dia) / 7;
                ultima_semana = ultima_semana2;// = 1 + conferir_semana(ultimo_dia) / 7;
                
                n_semana = n_semana2; ;// = ultima_semana - primeira_semana;
                for (int i = 0; i < n_semana; i++)
                {
                    semana_ano[i,0] = semana_ano2[i,0];
                    semana_ano[i, 1] = semana_ano2[i, 1];
                    //MessageBox.Show(semana_ano[i, 0].ToString() + " " + semana_ano[i, 1].ToString());
                }
                
                prim_var = prim_var2;
                ano_var = ano_var2;
            }
            else
            {
                primeiro_dia2 = primeiro_dia;
                ultimo_dia2 = ultimo_dia;

                ano_primeiro2 = ano_primeiro; ;// = achar_primeira_semana().Year;
                ano_ultimo2 = ano_ultimo;// = achar_ultima_semana().Year;

                primeira_semana2 = primeira_semana; // = 1 + conferir_semana(primeiro_dia) / 7;
                ultima_semana2 = ultima_semana;// = 1 + conferir_semana(ultimo_dia) / 7;
                n_semana2 = n_semana; // = ultima_semana - primeira_semana;
                for (int i = 0; i < n_semana; i++)
                {
                    semana_ano2[i,0] = semana_ano[i,0];
                    semana_ano2[i, 1] = semana_ano[i, 1]; ;
                }
                //semana_ano2 = semana_ano;
                prim_var2 = prim_var;
                ano_var2 = ano_var;

            }
        }
    

            //Cria documento XML
    private void cria_xml()
    {
        XmlWriterSettings settings = new XmlWriterSettings();
        
        settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create("c:\\evolucao\\" + funcao + ".xml", settings))
            {
                /*
                DateTime primeiro_dia = new DateTime();
                DateTime ultimo_dia = new DateTime();
                primeiro_dia = achar_primeira_semana();
                ultimo_dia = achar_ultima_semana();

                */
                //Inicio do elemento
                
                writer.WriteStartElement("chart");
                writer.WriteAttributeString("dateFormat", "dd/mm/yyyy");
                writer.WriteAttributeString("hoverCapBorderColor", "ffffff");
                writer.WriteAttributeString("hoverCapBgColor", "ffffff");
                writer.WriteAttributeString("ganttWidthPercent", "60");
                writer.WriteAttributeString("ganttLineAlpha", "80");
                writer.WriteAttributeString("canvasBorderColor", "024455");
                writer.WriteAttributeString("canvasBorderThickness", "0");
                writer.WriteAttributeString("gridBorderColor", "4567aa");
                writer.WriteAttributeString("gridBorderAlpha", "20");
                writer.WriteAttributeString("width", "800");
                //Elemento dentro do elemento Chart
               // writer.WriteString();
                //MessageBox.Show(primeiro_dia.ToString());
                //MessageBox.Show(ultimo_dia.ToString());
                /*
                writer.WriteStartElement("categories");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteStartElement("category");
                writer.WriteAttributeString("start", primeiro_dia_semana(primeira_semana, ano_primeiro).ToShortDateString());
                writer.WriteAttributeString("end", ultimo_dia_semana(ultima_semana, ano_ultimo).ToShortDateString());
                writer.WriteAttributeString("align", "center");
                writer.WriteAttributeString("name", funcao.Replace("_"," "));
                writer.WriteAttributeString("fontColor", "008000"); 
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("fontSize", "15");
                writer.WriteEndElement();
                 */
                //writer.WriteEndElement();

                writer.WriteStartElement("categories");
                writer.WriteAttributeString("bgColor", "EEE9E9");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteStartElement("category");
                writer.WriteAttributeString("start", primeiro_dia_semana(primeira_semana, ano_primeiro).ToShortDateString());
                writer.WriteAttributeString("end", ultimo_dia_semana(ultima_semana, ano_ultimo).ToShortDateString());
                writer.WriteAttributeString("align", "center");
                writer.WriteAttributeString("name", "Semanas");
                writer.WriteAttributeString("font", "Verdana");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("fontSize", "16");
                writer.WriteEndElement(); //fecha category
                writer.WriteEndElement(); //fecha categories

                writer.WriteStartElement("categories");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("fontColor", "0000ff");
                writer.WriteAttributeString("fontSize", "10");


                for (int i = 0; i < n_semana; i++)
                {
                    writer.WriteStartElement("category");
                    writer.WriteAttributeString("start", primeiro_dia_semana(semana_ano[i,0], semana_ano[i,1]).ToShortDateString());
                    writer.WriteAttributeString("end", ultimo_dia_semana(semana_ano[i, 0], semana_ano[i, 1]).ToShortDateString());
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("name", semana_ano[i, 0].ToString());
                    writer.WriteAttributeString("isBold", "1");
                    
                    //writer.WriteAttributeString("width", tamanho.ToString());
                    writer.WriteEndElement(); //fecha category
                }
                writer.WriteEndElement(); //fecha categories

                writer.WriteStartElement("processes");
                writer.WriteAttributeString("headerText", "Processos");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("fontSize", "10");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("isAnimated", "1");
                writer.WriteAttributeString("bgColor", "EEE9E9");
                writer.WriteAttributeString("headerVAlign", "center");
                writer.WriteAttributeString("headerbgColor", "EEE9E9");
                writer.WriteAttributeString("headerFontColor", "000000");
                writer.WriteAttributeString("headerFontSize", "16");
                writer.WriteAttributeString("width", "110");
                writer.WriteAttributeString("align", "left");
                //Se for cavidades, postiços ou acessórios
                if (funcao == "Cavidade_do_Lado_Fixo" ||
                    funcao == "Cavidade_Lado_Movel" ||
                    funcao == "Acessorios" ||
                    funcao == "Posticos_Gavetas_Segmentos_Moveis")
                {

                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "Fresa");
                    writer.WriteAttributeString("id", "1");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "Torno");
                    writer.WriteAttributeString("id", "2");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "CNC (Desbaste)");
                    writer.WriteAttributeString("id", "3");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "Têmpera");
                    writer.WriteAttributeString("id", "4");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "Retífica");
                    writer.WriteAttributeString("id", "5");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "CNC (Acab.)");
                    writer.WriteAttributeString("id", "6");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "Erosão EWC");
                    writer.WriteAttributeString("id", "7");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "Erosão EDM");
                    writer.WriteAttributeString("id", "8");
                    writer.WriteEndElement();
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", "Polimento");
                    writer.WriteAttributeString("id", "9");
                    writer.WriteEndElement();
                    writer.WriteEndElement(); // fecha processes
                }
                else
                {
                    if (funcao == "Projeto")
                    {
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", "Pré-Projeto");
                        writer.WriteAttributeString("id", "1");
                        writer.WriteEndElement();
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", "Modelamento");
                        writer.WriteAttributeString("id", "2");
                        writer.WriteEndElement();
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", "Compra Material");
                        writer.WriteAttributeString("id", "3");
                        writer.WriteEndElement();
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", "Det./Principal ");
                        writer.WriteAttributeString("id", "4");
                        writer.WriteEndElement();
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", "Projeto Completo");
                        writer.WriteAttributeString("id", "5");
                        writer.WriteEndElement();
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", "Revisão Projeto");
                        writer.WriteAttributeString("id", "6");
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    else
                    {
                        if (funcao == "Porta_Molde")
                        {

                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "Fresa");
                            writer.WriteAttributeString("id", "1");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "CNC");
                            writer.WriteAttributeString("id", "2");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "Ajuste e Mont.");
                            writer.WriteAttributeString("id", "3");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "1º Try Out");
                            writer.WriteAttributeString("id", "4");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "Rel.Dimensional");
                            writer.WriteAttributeString("id", "5");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "Corr.Cotas Reprov.");
                            writer.WriteAttributeString("id", "6");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "2º Try Out");
                            writer.WriteAttributeString("id", "7");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "3º Try Out");
                            writer.WriteAttributeString("id", "8");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "Rel.Dimensional");
                            writer.WriteAttributeString("id", "9");
                            writer.WriteEndElement();
                            writer.WriteStartElement("process");
                            writer.WriteAttributeString("Name", "Ent. Ferramental");
                            writer.WriteAttributeString("id", "10");
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        
                        }


                                        
                    

                    }

                }
                writer.WriteStartElement("dataTable");
                writer.WriteAttributeString("showProcessName", "1");
                writer.WriteAttributeString("nameAlign", "left");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("fontSize", "10");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("headerFontColor", "00000");
                writer.WriteAttributeString("headerFontSize", "9");
                writer.WriteAttributeString("vAlign", "center");
                writer.WriteAttributeString("align", "left");

                int n_ope_maioria = 12;
                string[] ent_prev = new string[n_ope_maioria];
                string[] ent_exec = new string[n_ope_maioria];
                string[] fim_prev = new string[n_ope_maioria];
                string[] fim_exec = new string[n_ope_maioria];
                string[] porc_exec = new string[n_ope_maioria];

                if (funcao == "Cavidade_do_Lado_Fixo" ||
                    funcao == "Cavidade_Lado_Movel" ||
                    funcao == "Acessorios" ||
                    funcao == "Posticos_Gavetas_Segmentos_Moveis" )
                {
                    
                    n_ope = 9;
                    ent_prev[0] = primeiro_dia_prev_fresa.ToShortDateString();
                    ent_prev[1] = primeiro_dia_prev_torno.ToShortDateString();
                    ent_prev[2] = primeiro_dia_prev_cnc_desb.ToShortDateString();
                    ent_prev[3] = primeiro_dia_prev_tempera.ToShortDateString();
                    ent_prev[4] = primeiro_dia_prev_retifica.ToShortDateString();
                    ent_prev[5] = primeiro_dia_prev_cnc_acab.ToShortDateString();
                    ent_prev[6] = primeiro_dia_prev_erosao_ewc.ToShortDateString();
                    ent_prev[7] = primeiro_dia_prev_erosao_edm.ToShortDateString();
                    ent_prev[8] = primeiro_dia_prev_polimento.ToShortDateString();


                    ent_exec[0] = primeiro_dia_exec_fresa.ToShortDateString();
                    ent_exec[1] = primeiro_dia_exec_torno.ToShortDateString();
                    ent_exec[2] = primeiro_dia_exec_cnc_desb.ToShortDateString();
                    ent_exec[3] = primeiro_dia_exec_tempera.ToShortDateString();
                    ent_exec[4] = primeiro_dia_exec_retifica.ToShortDateString();
                    ent_exec[5] = primeiro_dia_exec_cnc_acab.ToShortDateString();
                    ent_exec[6] = primeiro_dia_exec_erosao_ewc.ToShortDateString();
                    ent_exec[7] = primeiro_dia_exec_erosao_edm.ToShortDateString();
                    ent_exec[8] = primeiro_dia_exec_polimento.ToShortDateString();


                    fim_prev[0] = ultimo_dia_prev_fresa.ToShortDateString();
                    fim_prev[1] = ultimo_dia_prev_torno.ToShortDateString();
                    fim_prev[2] = ultimo_dia_prev_cnc_desb.ToShortDateString();
                    fim_prev[3] = ultimo_dia_prev_tempera.ToShortDateString();
                    fim_prev[4] = ultimo_dia_prev_retifica.ToShortDateString();
                    fim_prev[5] = ultimo_dia_prev_cnc_acab.ToShortDateString();
                    fim_prev[6] = ultimo_dia_prev_erosao_ewc.ToShortDateString();
                    fim_prev[7] = ultimo_dia_prev_erosao_edm.ToShortDateString();
                    fim_prev[8] = ultimo_dia_prev_polimento.ToShortDateString();


                    fim_exec[0] = ultimo_dia_exec_fresa.ToShortDateString();
                    fim_exec[1] = ultimo_dia_exec_torno.ToShortDateString();
                    fim_exec[2] = ultimo_dia_exec_cnc_desb.ToShortDateString();
                    fim_exec[3] = ultimo_dia_exec_tempera.ToShortDateString();
                    fim_exec[4] = ultimo_dia_exec_retifica.ToShortDateString();
                    fim_exec[5] = ultimo_dia_exec_cnc_acab.ToShortDateString();
                    fim_exec[6] = ultimo_dia_exec_erosao_ewc.ToShortDateString();
                    fim_exec[7] = ultimo_dia_exec_erosao_edm.ToShortDateString();
                    fim_exec[8] = ultimo_dia_exec_polimento.ToShortDateString();


                    porc_exec[0] = tb_porc_fresa.Text;
                    porc_exec[1] = tb_porc_torno.Text;
                    porc_exec[2] = tb_porc_cnc_des.Text;
                    porc_exec[3] = tb_porc_tempera.Text;
                    porc_exec[4] = tb_porc_retifica.Text;
                    porc_exec[5] = tb_porc_cnc_acab.Text;
                    porc_exec[6] = tb_porc_erosao_ewc.Text;
                    porc_exec[7] = tb_porc_erosao_edm.Text;
                    porc_exec[8] = tb_porc_polimento.Text;
                }
                else
                {

                    if (funcao == "Projeto")
                    {

                        n_ope = 6;
                        for (int i = 0; i < n_ope; i++)
                        {

                            try
                            {
                                ent_prev[i] = Convert.ToDateTime(dgvProjeto.Rows[i].Cells[1].Value.ToString()).ToShortDateString();
                            }
                            catch
                            {
                                ent_prev[i] = "31/12/" + DateTime.Now.Year.ToString();
                            }
                            try
                            {
                                ent_exec[i] = Convert.ToDateTime(dgvProjeto.Rows[i].Cells[5].Value.ToString()).ToShortDateString();
                            }
                            catch
                            {
                                ent_exec[i] = "31/12/" + DateTime.Now.Year.ToString();
                                sem_entrada = true;
                            }

                            try
                            {
                                fim_prev[i] = Convert.ToDateTime(dgvProjeto.Rows[i].Cells[2].Value.ToString()).ToShortDateString();
                            }
                            catch
                            {
                                fim_prev[i] = "01/01/" + DateTime.Now.Year.ToString();
                            }

                            try
                            {
                                fim_exec[i] = Convert.ToDateTime(dgvProjeto.Rows[i].Cells[6].Value.ToString()).ToShortDateString();
                            }
                            catch
                            {
                                if (sem_entrada == true)
                                {
                                    fim_exec[i] = "01/01/" + DateTime.Now.Year.ToString();
                                }
                                else
                                {
                                    fim_exec[i] = DateTime.Now.ToShortDateString();
                                }
                            }
                            sem_entrada = false;
                        }
                        if (dgvProjeto.RowCount > 0)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                if (dgvProjeto.Rows[i].Cells[6].Value.ToString() != "")
                                    porc_exec[i] = "100";
                                else
                                    porc_exec[i] = "0";
                            }
                        }


                    }

                    else
                    {

                        if (funcao == "Porta_Molde")
                        {
                            n_ope = 11;
                            ent_prev[0] = primeiro_dia_prev_fresa.ToShortDateString();
                            ent_prev[1] = primeiro_dia_prev_cnc_acab.ToShortDateString();
                    
                            ent_exec[0] = primeiro_dia_exec_fresa.ToShortDateString();
                            ent_exec[1] = primeiro_dia_exec_cnc_acab.ToShortDateString();
                            
                            fim_prev[0] = ultimo_dia_prev_fresa.ToShortDateString();
                            fim_prev[1] = ultimo_dia_prev_cnc_acab.ToShortDateString();
                            
                            fim_exec[0] = ultimo_dia_exec_fresa.ToShortDateString();
                            fim_exec[1] = ultimo_dia_exec_cnc_acab.ToShortDateString();
                            
                            porc_exec[0] = tb_porc_fresa.Text;
                            porc_exec[1] = tb_porc_cnc_acab.Text;
                            
                    
                            //n_ope = ;
                            for (int i = 2; i < n_ope; i++)
                            {
                                if (i == 3)
                                {
                                }
                                else
                                {
                                    try
                                    {
                                        ent_prev[i] = Convert.ToDateTime(dgvporta_molde.Rows[i - 2].Cells[1].Value.ToString()).ToShortDateString();
                                    }
                                    catch
                                    {
                                        ent_prev[i] = "31/12/" + DateTime.Now.Year.ToString();
                                    }
                                    try
                                    {
                                        ent_exec[i] = Convert.ToDateTime(dgvporta_molde.Rows[i - 2].Cells[5].Value.ToString()).ToShortDateString();
                                    }
                                    catch
                                    {
                                        ent_exec[i] = "31/12/" + DateTime.Now.Year.ToString();
                                        sem_entrada = true;
                                    }

                                    try
                                    {
                                        fim_prev[i] = Convert.ToDateTime(dgvporta_molde.Rows[i - 2].Cells[2].Value.ToString()).ToShortDateString();
                                    }
                                    catch
                                    {
                                        fim_prev[i] = "01/01/" + DateTime.Now.Year.ToString();
                                    }

                                    try
                                    {
                                        fim_exec[i] = Convert.ToDateTime(dgvporta_molde.Rows[i - 2].Cells[6].Value.ToString()).ToShortDateString();
                                    }
                                    catch
                                    {
                                        if (sem_entrada == true)
                                        {
                                            fim_exec[i] = "01/01/" + DateTime.Now.Year.ToString();
                                        }
                                        else
                                        {
                                            fim_exec[i] = DateTime.Now.ToShortDateString();
                                        }
                                    }
                                    sem_entrada = false;
                                }
                            }
                            if (dgvporta_molde.RowCount > 0)
                            {
                                for (int i = 2; i < dgvporta_molde.RowCount; i++)
                                {
                                   
                                        if (dgvporta_molde.Rows[i].Cells[6].Value.ToString() != "")
                                            porc_exec[i] = "100";
                                        else
                                            porc_exec[i] = "0";
                                    
                                }
                            }


                        }
                    

                    }


                }

                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "I.Prev."); 
                writer.WriteAttributeString("isBold", "1");

                if (funcao != "%")
                {
                    for (int i = 0; i < n_ope; i++)
                    {
                        if (funcao == "Porta_Molde" && i == 3)
                        {

                        }
                        else
                        {
                            string entrada = ent_prev[i].Remove(5, 5);
                            string fim = fim_prev[i].Remove(5, 5);
                            string color = "000000";
                            if (entrada == "31/12" &&
                                fim == "01/01")
                                color = "ffffff";


                            writer.WriteStartElement("text");
                            writer.WriteAttributeString("label", entrada);
                            writer.WriteAttributeString("FontColor", color);
                            writer.WriteAttributeString("fontSize", "8");
                            writer.WriteAttributeString("vAlign", "center");
                            writer.WriteAttributeString("align", "center");
                            writer.WriteEndElement();
                        }
                    }
                    writer.WriteEndElement();
                    writer.WriteStartElement("dataColumn");
                    writer.WriteAttributeString("width", "36");
                    writer.WriteAttributeString("headerfontcolor", "000000");
                    writer.WriteAttributeString("headerBgColor", "EEE9E9");
                    writer.WriteAttributeString("bgColor", "ffffff");
                    writer.WriteAttributeString("headerColor", "ffffff");
                    writer.WriteAttributeString("headerText", "I.Real");
                    writer.WriteAttributeString("isBold", "1");




                    for (int i = 0; i < n_ope; i++)
                    {
                        if (funcao == "Porta_Molde" && i == 3)
                        {

                        }
                        else
                        {
                            string entrada = ent_exec[i].Remove(5, 5);
                            string fim = fim_exec[i].Remove(5, 5);
                            string color = "0000ff";
                            if (entrada == "31/12" &&
                                fim == "01/01")
                                color = "ffffff";
                            if (entrada == "31/12" &&
                                fim == DateTime.Now.ToShortDateString().Remove(5, 5))
                                color = "ffffff";

                            writer.WriteStartElement("text");
                            writer.WriteAttributeString("label", entrada);
                            writer.WriteAttributeString("FontColor", color);
                            writer.WriteAttributeString("fontSize", "8");
                            writer.WriteAttributeString("vAlign", "center");
                            writer.WriteAttributeString("align", "center");
                            writer.WriteEndElement();
                        }
                    }
                    writer.WriteEndElement();
                    writer.WriteStartElement("dataColumn");
                    writer.WriteAttributeString("width", "36");
                    writer.WriteAttributeString("headerfontcolor", "000000");
                    writer.WriteAttributeString("headerBgColor", "EEE9E9");
                    writer.WriteAttributeString("bgColor", "ffffff");
                    writer.WriteAttributeString("headerColor", "ffffff");
                    writer.WriteAttributeString("headerText", "F.Prev");
                    writer.WriteAttributeString("isBold", "1");

                    for (int i = 0; i < n_ope; i++)
                    {
                        if (funcao == "Porta_Molde" && i == 3)
                        {

                        }
                        else
                        {
                            string entrada = ent_prev[i].Remove(5, 5);
                            string fim = fim_prev[i].Remove(5, 5);
                            string color = "000000";
                            if (entrada == "31/12" &&
                                fim == "01/01")
                                color = "ffffff";


                            writer.WriteStartElement("text");
                            writer.WriteAttributeString("label", fim);
                            writer.WriteAttributeString("FontColor", color);
                            writer.WriteAttributeString("fontSize", "8");
                            writer.WriteAttributeString("vAlign", "center");
                            writer.WriteAttributeString("align", "center");
                            writer.WriteEndElement();
                        }

                    }
                    writer.WriteEndElement();
                    writer.WriteStartElement("dataColumn");
                    writer.WriteAttributeString("width", "36");
                    writer.WriteAttributeString("headerfontcolor", "000000");
                    writer.WriteAttributeString("headerBgColor", "EEE9E9");
                    writer.WriteAttributeString("bgColor", "ffffff");
                    writer.WriteAttributeString("headerColor", "ffffff");
                    writer.WriteAttributeString("headerText", "F.Real");
                    writer.WriteAttributeString("isBold", "1");


                    for (int i = 0; i < n_ope; i++)
                    {
                        if (funcao == "Porta_Molde" && i == 3)
                        {

                        }
                        else
                        {
                            string entrada = ent_exec[i].Remove(5, 5);
                            string fim = fim_exec[i].Remove(5, 5);
                            string color = "0000ff";
                            if (entrada == "31/12" &&
                                fim == "01/01")
                                color = "ffffff";
                            if (entrada == "31/12" &&
                                fim == DateTime.Now.ToShortDateString().Remove(5, 5))
                                color = "ffffff";
                            if (porc_exec[i] != "100")
                                color = "ffffff";

                            writer.WriteStartElement("text");
                            writer.WriteAttributeString("label", fim);
                            writer.WriteAttributeString("FontColor", color);
                            writer.WriteAttributeString("fontSize", "8");
                            writer.WriteAttributeString("vAlign", "center");
                            writer.WriteAttributeString("align", "center");
                            writer.WriteEndElement();
                        }
                    }
                    writer.WriteEndElement();



                    writer.WriteStartElement("dataColumn");
                    writer.WriteAttributeString("width", "32");
                    writer.WriteAttributeString("headerfontcolor", "000000");
                    writer.WriteAttributeString("headerBgColor", "EEE9E9");
                    writer.WriteAttributeString("bgColor", "ffffff");
                    writer.WriteAttributeString("headerColor", "ffffff");
                    writer.WriteAttributeString("headerText", "%");
                    writer.WriteAttributeString("isBold", "1");

                    for (int i = 0; i < n_ope; i++)
                    {
                        if (funcao == "Porta_Molde" && i == 3)
                        {

                        }
                        else
                        {
                            writer.WriteStartElement("text");
                            writer.WriteAttributeString("label", porc_exec[i]);
                            //writer.WriteAttributeString("FontColor", color);
                            writer.WriteAttributeString("fontSize", "10");
                            writer.WriteAttributeString("vAlign", "center");
                            writer.WriteAttributeString("align", "center");
                            writer.WriteEndElement();
                        }
                    }




                    writer.WriteEndElement();

                    writer.WriteEndElement();

                    writer.WriteStartElement("tasks");
                    //writer.WriteAttributeString("width", "0");


                    for (int i = 0; i < n_ope; i++)
                    {
                        if (funcao == "Porta_Molde" && i == 3)
                        {

                        }
                        else
                        {
                            int id = i + 1;
                            if (funcao == "Porta_Molde" && i > 3)
                                id--;
                            string top_padding_1 = "2";
                            string top_padding_2 = "11";
                            /*
                            if (funcao == "Porta_Molde")
                            {
                                top_padding_1 = "1";
                                top_padding_2 = "11";
                            }
                             * */
                            string entrada = ent_prev[i].Remove(5, 5);
                            string fim = fim_prev[i].Remove(5, 5);
                            string entrada_exec = ent_exec[i].Remove(5, 5);
                            string fim_exec_2 = fim_exec[i].Remove(5, 5);
                            if (entrada == "31/12" &&
                                (fim == "01/01" || fim == DateTime.Now.ToShortDateString().Remove(5, 5)))
                            { }
                            else
                            {
                                writer.WriteStartElement("task");
                                writer.WriteAttributeString("name", "Previsto");
                                writer.WriteAttributeString("processId", id.ToString());
                                writer.WriteAttributeString("start", ent_prev[i].ToString());
                                writer.WriteAttributeString("end", fim_prev[i].ToString());
                                writer.WriteAttributeString("id", id.ToString() + "-1");
                                writer.WriteAttributeString("color", "000080");
                                writer.WriteAttributeString("height", "7");
                                writer.WriteAttributeString("topPadding", top_padding_1);
                                writer.WriteAttributeString("animation", "0");
                                writer.WriteEndElement();


                                string color;
                                if (porc_exec[i] == "100")
                                    color = "ffff00";
                                else
                                    color = "00ff00";
                                if (entrada_exec == "31/12" &&
                                    (fim_exec_2 == "01/01" || fim_exec_2 == DateTime.Now.ToShortDateString().Remove(5, 5)))
                                { }
                                else
                                {
                                    writer.WriteStartElement("task");
                                    writer.WriteAttributeString("name", "Executado");
                                    writer.WriteAttributeString("processId", id.ToString());
                                    writer.WriteAttributeString("start", ent_exec[i].ToString());
                                    writer.WriteAttributeString("end", fim_exec[i].ToString());
                                    writer.WriteAttributeString("id", id.ToString());
                                    writer.WriteAttributeString("color", color);
                                    writer.WriteAttributeString("height", "7");
                                    writer.WriteAttributeString("topPadding", top_padding_2);
                                    writer.WriteAttributeString("alpha", "100");
                                    writer.WriteEndElement();
                                }
                            }
                        }
                    }
                    writer.WriteEndElement();




                    //Fecha elemento Cliente

                    writer.WriteEndElement();



                    writer.Flush();
                }

            }

    


        }

        private DateTime achar_primeira_semana()
        {

            DateTime primeira = new DateTime();
                     
            primeiro_dia_prev_fresa = qual_data("Fresa", "primeira_prev");
            primeiro_dia_exec_fresa = qual_data("Fresa", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeiro_dia_prev_fresa, primeiro_dia_exec_fresa);
            primeiro_dia_prev_torno = qual_data("Torno", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_torno);
            primeiro_dia_exec_torno = qual_data("Torno", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_torno);
            primeiro_dia_prev_cnc_desb = qual_data("CNC (Desbaste)", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_cnc_desb);
            primeiro_dia_exec_cnc_desb = qual_data("CNC (Desbaste)", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_cnc_desb);
            primeiro_dia_prev_tempera = qual_data("Têmpera", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_tempera);
            primeiro_dia_exec_tempera = qual_data("Têmpera", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_tempera);
            primeiro_dia_prev_retifica = qual_data("Retífica", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_retifica);
            primeiro_dia_exec_retifica = qual_data("Retífica", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_retifica);
            primeiro_dia_prev_cnc_acab = qual_data("Cnc (Acab.)", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_cnc_acab);
            primeiro_dia_exec_cnc_acab = qual_data("Cnc (Acab.)", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_cnc_acab);
            primeiro_dia_prev_erosao_ewc = qual_data("Erosão EWC", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_erosao_ewc);
            primeiro_dia_exec_erosao_ewc = qual_data("Erosão EWC", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_erosao_ewc);
            primeiro_dia_prev_erosao_edm = qual_data("Erosão EDM", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_erosao_edm);
            primeiro_dia_exec_erosao_edm = qual_data("Erosão EDM", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_erosao_edm);
            primeiro_dia_prev_polimento = qual_data("Polimento", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_polimento);
            primeiro_dia_exec_polimento = qual_data("Polimento", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_polimento);
            primeiro_dia_prev_projeto = qual_data("Projeto", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_projeto);
            primeiro_dia_exec_projeto = qual_data("Projeto", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_projeto);
            primeiro_dia_prev_porta_molde = qual_data("Porta_Molde", "primeira_prev");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_prev_porta_molde);
            primeiro_dia_exec_porta_molde = qual_data("Porta_Molde", "primeira_real");
            primeira = achar_primeiro_entre_dois(primeira, primeiro_dia_exec_porta_molde);
            return primeira;
            

        }

        private DateTime achar_ultima_semana()
        {
            DateTime ultima = new DateTime();

            ultimo_dia_prev_fresa = qual_data("Fresa", "ultima_prev");
            ultimo_dia_exec_fresa = qual_data("Fresa", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultimo_dia_prev_fresa, ultimo_dia_exec_fresa);
            ultimo_dia_prev_torno = qual_data("Torno", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_torno);
            ultimo_dia_exec_torno = qual_data("Torno", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_torno);
            ultimo_dia_prev_cnc_desb = qual_data("CNC (Desbaste)", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_cnc_desb);
            ultimo_dia_exec_cnc_desb = qual_data("CNC (Desbaste)", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_cnc_desb);
            ultimo_dia_prev_tempera = qual_data("Têmpera", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_tempera);
            ultimo_dia_exec_tempera = qual_data("Têmpera", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_tempera);
            ultimo_dia_prev_retifica = qual_data("Retífica", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_retifica);
            ultimo_dia_exec_retifica = qual_data("Retífica", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_retifica);
            ultimo_dia_prev_cnc_acab = qual_data("Cnc (Acab.)", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_cnc_acab);
            ultimo_dia_exec_cnc_acab = qual_data("Cnc (Acab.)", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_cnc_acab);
            ultimo_dia_prev_erosao_ewc = qual_data("Erosão EWC", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_erosao_ewc);
            ultimo_dia_exec_erosao_ewc = qual_data("Erosão EWC", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_erosao_ewc);
            ultimo_dia_prev_erosao_edm = qual_data("Erosão EDM", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_erosao_edm);
            ultimo_dia_exec_erosao_edm = qual_data("Erosão EDM", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_erosao_edm);
            ultimo_dia_prev_polimento = qual_data("Polimento", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_polimento);
            ultimo_dia_exec_polimento = qual_data("Polimento", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_polimento);
            ultimo_dia_prev_projeto = qual_data("Projeto", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_projeto);
            ultimo_dia_exec_projeto = qual_data("Projeto", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_projeto);
            ultimo_dia_prev_porta_molde = qual_data("Porta_Molde", "ultima_prev");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_prev_porta_molde);
            ultimo_dia_exec_porta_molde = qual_data("Porta_Molde", "ultima_real");
            ultima = achar_ultimo_entre_dois(ultima, ultimo_dia_exec_porta_molde);
            return ultima;
        }

        private DateTime achar_ultimo_entre_dois(DateTime um, DateTime dois)
        {
            DateTime ultimo = new DateTime();
            if (um > dois)
                ultimo = um;
            else
                ultimo = dois;
            return ultimo;
        }

        private DateTime achar_primeiro_entre_dois(DateTime um, DateTime dois)
        {
            DateTime primeiro = new DateTime();
            if (um < dois)
                primeiro = um;
            else
                primeiro = dois;
            return primeiro;
        }

        private DateTime qual_data(string operacao, string qual)
        {
            
            DateTime primeira_data_prev = new DateTime(DateTime.Now.Year,12,31);
            DateTime ultima_data_prev = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime primeira_data_real = new DateTime(DateTime.Now.Year, 12, 31);
            DateTime ultima_data_real = new DateTime(DateTime.Now.Year, 1, 1);

            if (operacao == "Projeto" && dgvProjeto.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvProjeto.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvProjeto.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvProjeto.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvProjeto.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvProjeto.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {


                        try
                        {

                            if (primeira_data_prev > Convert.ToDateTime(dgvProjeto.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvProjeto.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvProjeto.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvProjeto.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "primeira_real")
                    {
                        try
                        {
                            
                            if (primeira_data_real > Convert.ToDateTime(dgvProjeto.Rows[j].Cells[5].Value))
                                primeira_data_real = Convert.ToDateTime(dgvProjeto.Rows[j].Cells[5].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "ultima_real")
                    {
                        try
                        {
                            if (ultima_data_real < Convert.ToDateTime(dgvProjeto.Rows[j].Cells[6].Value))
                                ultima_data_real = Convert.ToDateTime(dgvProjeto.Rows[j].Cells[6].Value);
                        }
                        catch
                        {
                            ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                        }

                    }

                }

            }

            if (operacao == "Porta_Molde" && dgvporta_molde.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvporta_molde.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvporta_molde.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvporta_molde.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvporta_molde.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvporta_molde.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {


                        try
                        {

                            if (primeira_data_prev > Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "primeira_real")
                    {
                        try
                        {
                            if (primeira_data_real > Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[5].Value))
                                primeira_data_real = Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[5].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "ultima_real")
                    {
                        try
                        {
                            if (ultima_data_real < Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[6].Value))
                                ultima_data_real = Convert.ToDateTime(dgvporta_molde.Rows[j].Cells[6].Value);
                        }
                        catch
                        {
                            ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                        }

                    }

                }

            }



            //verificar datas da fresa
            if (operacao == "Fresa" && dgvfresa.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvfresa.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvfresa.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvfresa.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvfresa.Rows[0].Cells[6].Value);
                }
                catch{}
                for (int j = 0; j < dgvfresa.RowCount; j++)
                {
                    if(qual == "primeira_prev")
                    {


                        try
                        {
                            
                            if (primeira_data_prev > Convert.ToDateTime(dgvfresa.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvfresa.Rows[j].Cells[1].Value);
                        }
                        catch 
                        {
                            
                        }
                        
                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvfresa.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvfresa.Rows[j].Cells[2].Value);
                        }
                        catch
                        {
                            
                        }
                        
                    }
                    if (dgvfresa.Rows[j].Cells[1].Value.ToString() != "")
                    {
                        if (qual == "primeira_real")
                        {
                            try
                            {

                                if (primeira_data_real > Convert.ToDateTime(dgvfresa.Rows[j].Cells[5].Value))
                                    primeira_data_real = Convert.ToDateTime(dgvfresa.Rows[j].Cells[5].Value);
                            }
                            catch
                            {

                            }

                        }
                        if (qual == "ultima_real")
                        {
                            try
                            {
                                if (ultima_data_real < Convert.ToDateTime(dgvfresa.Rows[j].Cells[6].Value))
                                    ultima_data_real = Convert.ToDateTime(dgvfresa.Rows[j].Cells[6].Value);
                            }
                            catch
                            {
                                ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                            }

                        }
                    }

                }
               
            }

            if (operacao == "Torno" && dgvtorno.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvtorno.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvtorno.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvtorno.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvtorno.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvtorno.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgvtorno.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvtorno.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvtorno.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvtorno.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (dgvtorno.Rows[j].Cells[1].Value.ToString() != "")
                    {
                        if (qual == "primeira_real")
                        {
                            try
                            {
                                if (primeira_data_real > Convert.ToDateTime(dgvtorno.Rows[j].Cells[5].Value))
                                    primeira_data_real = Convert.ToDateTime(dgvtorno.Rows[j].Cells[5].Value);
                            }
                            catch
                            {

                            }

                        }
                        if (qual == "ultima_real")
                        {
                            try
                            {
                                if (ultima_data_real < Convert.ToDateTime(dgvtorno.Rows[j].Cells[6].Value))
                                    ultima_data_real = Convert.ToDateTime(dgvtorno.Rows[j].Cells[6].Value);
                            }
                            catch
                            {
                                ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                            }

                        }
                    }

                }
                
            }

            if (operacao == "CNC (Desbaste)" && dgvcnc_des.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvcnc_des.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvcnc_des.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvcnc_des.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvcnc_des.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvcnc_des.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (dgvcnc_des.Rows[j].Cells[1].Value.ToString() != "")
                    {
                        if (qual == "primeira_real")
                        {
                            try
                            {
                                if (primeira_data_real > Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[5].Value))
                                    primeira_data_real = Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[5].Value);
                            }
                            catch
                            {

                            }

                        }
                        if (qual == "ultima_real")
                        {
                            try
                            {
                                if (ultima_data_real < Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[6].Value))
                                    ultima_data_real = Convert.ToDateTime(dgvcnc_des.Rows[j].Cells[6].Value);
                            }
                            catch
                            {
                                ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                            }

                        }
                    }

                }
                
            }

            if (operacao == "Têmpera" && dgvtempera.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvtempera.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvtempera.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvtempera.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvtempera.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvtempera.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgvtempera.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvtempera.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvtempera.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvtempera.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "primeira_real")
                    {
                        try
                        {
                            if (primeira_data_real > Convert.ToDateTime(dgvtempera.Rows[j].Cells[5].Value))
                                primeira_data_real = Convert.ToDateTime(dgvtempera.Rows[j].Cells[5].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "ultima_real")
                    {
                        try
                        {
                            if (ultima_data_real < Convert.ToDateTime(dgvtempera.Rows[j].Cells[6].Value))
                                ultima_data_real = Convert.ToDateTime(dgvtempera.Rows[j].Cells[6].Value);
                        }
                        catch
                        {
                            ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                        }

                    }

                }
            }

            if (operacao == "Retífica" && dgvretifica.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvretifica.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvretifica.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvretifica.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvretifica.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvretifica.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgvretifica.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvretifica.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvretifica.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvretifica.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (dgvretifica.Rows[j].Cells[1].Value.ToString() != "")
                    {
                        if (qual == "primeira_real")
                        {
                            try
                            {
                                if (primeira_data_real > Convert.ToDateTime(dgvretifica.Rows[j].Cells[5].Value))
                                    primeira_data_real = Convert.ToDateTime(dgvretifica.Rows[j].Cells[5].Value);
                            }
                            catch
                            {

                            }

                        }
                        if (qual == "ultima_real")
                        {
                            try
                            {
                                if (ultima_data_real < Convert.ToDateTime(dgvretifica.Rows[j].Cells[6].Value))
                                    ultima_data_real = Convert.ToDateTime(dgvretifica.Rows[j].Cells[6].Value);
                            }
                            catch
                            {
                                ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                            }

                        }
                    }

                }
                
            }

            if (operacao == "Cnc (Acab.)" && dgvcnc_acab.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvcnc_acab.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvcnc_acab.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvcnc_acab.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvcnc_acab.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvcnc_acab.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (dgvcnc_acab.Rows[j].Cells[1].Value.ToString() != "")
                    {
                        if (qual == "primeira_real")
                        {
                            try
                            {
                                if (primeira_data_real > Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[5].Value))
                                    primeira_data_real = Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[5].Value);
                            }
                            catch
                            {

                            }

                        }
                        if (qual == "ultima_real")
                        {
                            try
                            {
                                if (ultima_data_real < Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[6].Value))
                                    ultima_data_real = Convert.ToDateTime(dgvcnc_acab.Rows[j].Cells[6].Value);
                            }
                            catch
                            {
                                ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                            }

                        }
                    }

                }

            }

            if (operacao == "Erosão EWC" && dgverosao_ewc.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgverosao_ewc.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgverosao_ewc.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgverosao_ewc.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgverosao_ewc.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgverosao_ewc.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (dgverosao_ewc.Rows[j].Cells[1].Value.ToString() != "")
                    {
                        if (qual == "primeira_real")
                        {
                            try
                            {
                                if (primeira_data_real > Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[5].Value))
                                    primeira_data_real = Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[5].Value);
                            }
                            catch
                            {

                            }

                        }
                        if (qual == "ultima_real")
                        {
                            try
                            {
                                if (ultima_data_real < Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[6].Value))
                                    ultima_data_real = Convert.ToDateTime(dgverosao_ewc.Rows[j].Cells[6].Value);
                            }
                            catch
                            {
                                ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                            }

                        }
                    }

                }

            }

            if (operacao == "Erosão EDM" && dgverosao_edm.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgverosao_edm.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgverosao_edm.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgverosao_edm.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgverosao_edm.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgverosao_edm.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (dgverosao_edm.Rows[j].Cells[1].Value.ToString() != "")
                    {
                        if (qual == "primeira_real")
                        {
                            try
                            {
                                if (primeira_data_real > Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[5].Value))
                                    primeira_data_real = Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[5].Value);
                            }
                            catch
                            {

                            }

                        }
                        if (qual == "ultima_real")
                        {
                            try
                            {
                                if (ultima_data_real < Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[6].Value))
                                    ultima_data_real = Convert.ToDateTime(dgverosao_edm.Rows[j].Cells[6].Value);
                            }
                            catch
                            {
                                ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                            }

                        }
                    }

                }

            }

            if (operacao == "Polimento" && dgvpolimento.RowCount > 0)
            {
                try
                {
                    primeira_data_prev = Convert.ToDateTime(dgvpolimento.Rows[0].Cells[1].Value);
                    ultima_data_prev = Convert.ToDateTime(dgvpolimento.Rows[0].Cells[2].Value);
                    primeira_data_real = Convert.ToDateTime(dgvpolimento.Rows[0].Cells[5].Value);
                    ultima_data_real = Convert.ToDateTime(dgvpolimento.Rows[0].Cells[6].Value);
                }
                catch { }
                for (int j = 0; j < dgvpolimento.RowCount; j++)
                {
                    if (qual == "primeira_prev")
                    {
                        try
                        {
                            if (primeira_data_prev > Convert.ToDateTime(dgvpolimento.Rows[j].Cells[1].Value))
                                primeira_data_prev = Convert.ToDateTime(dgvpolimento.Rows[j].Cells[1].Value);
                        }
                        catch
                        {

                        }

                    }

                    if (qual == "ultima_prev")
                    {
                        try
                        {
                            if (ultima_data_prev < Convert.ToDateTime(dgvpolimento.Rows[j].Cells[2].Value))
                                ultima_data_prev = Convert.ToDateTime(dgvpolimento.Rows[j].Cells[2].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "primeira_real")
                    {
                        try
                        {
                            if (primeira_data_real > Convert.ToDateTime(dgvpolimento.Rows[j].Cells[5].Value))
                                primeira_data_real = Convert.ToDateTime(dgvpolimento.Rows[j].Cells[5].Value);
                        }
                        catch
                        {

                        }

                    }
                    if (qual == "ultima_real")
                    {
                        try
                        {
                            if (ultima_data_real < Convert.ToDateTime(dgvpolimento.Rows[j].Cells[6].Value))
                                ultima_data_real = Convert.ToDateTime(dgvpolimento.Rows[j].Cells[6].Value);
                        }
                        catch
                        {
                            ultima_data_real = DateTime.Now;  // se tiver valores em branco, pegar data atual
                        }

                    }

                }

            }

            

            if (qual == "primeira_prev")
            {
                return primeira_data_prev;
            }

            if (qual == "ultima_prev")
            {
                return ultima_data_prev;
            }
            if (qual == "primeira_real")
            {
                return primeira_data_real;
            }
            if (qual == "ultima_real")
            {
                return ultima_data_real;
            }
            return DateTime.Now;
            
            
                

        }

        private int conferir_semana(DateTime data_inicial)
        {
            DateTime primeiro_dia = new DateTime(data_inicial.Year, 1, 1);
            while (primeiro_dia.DayOfWeek != DayOfWeek.Monday)
                primeiro_dia = primeiro_dia.AddDays(-1);
            while (data_inicial.DayOfWeek != DayOfWeek.Monday)
                data_inicial = data_inicial.AddDays(-1);
            TimeSpan numero_dias = data_inicial.Subtract(primeiro_dia);
            //MessageBox.Show("numero de dias "+ numero_dias.TotalDays.ToString());
            int numero_semana = Convert.ToInt32(numero_dias.Days.ToString());
            return numero_semana;
        }

        private DateTime primeiro_dia_semana(int semana, int ano)
        {
            DateTime primeiro_dia = new DateTime(ano, 1, 1);
            int dia_var = (semana - 1)* 7;
            primeiro_dia = primeiro_dia.AddDays(dia_var);
            return conferir_primeiro_dia(primeiro_dia);
        }

        private DateTime ultimo_dia_semana(int semana, int ano)
        {
            DateTime primeiro_dia = new DateTime(ano, 1, 1);
            int dia_var = (semana - 1) * 7;
            primeiro_dia = primeiro_dia.AddDays(dia_var);
            return conferir_ultimo_dia(primeiro_dia);
        }

        private DateTime conferir_primeiro_dia(DateTime data_inicial)
        {
            while (data_inicial.DayOfWeek != DayOfWeek.Sunday)
                data_inicial = data_inicial.AddDays(-1);
             //MessageBox.Show("numero de dias "+ numero_dias.TotalDays.ToString());
            return data_inicial;
        }

        private DateTime conferir_ultimo_dia(DateTime data_inicial)
        {
            while (data_inicial.DayOfWeek != DayOfWeek.Saturday)
                data_inicial = data_inicial.AddDays(1);
            //MessageBox.Show("numero de dias "+ numero_dias.TotalDays.ToString());
            return data_inicial;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            funcao = radioButton1.Text;
            ok();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            funcao = radioButton2.Text;
            ok();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            funcao = radioButton4.Text;
            ok();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            funcao = radioButton3.Text;
            ok();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            funcao = radioButton5.Text;
            ok();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            funcao = radioButton6.Text;
            ok();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dgvProjeto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvProjeto.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvporta_molde_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvporta_molde.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                FileInfo d = new FileInfo("c:\\evolucao\\seg.txt");
                if (d.Exists == true)
                {
                    calcular_des_pm_elet();
                    form_despesas_molde despesas = new form_despesas_molde();
                    despesas.os_corrente = tb_molde.Text;
                    despesas.horas_trabalhadas = total_horas_trab;
                    despesas.Show();
                }
                else
                {
                    MessageBox.Show("Você não tem acesso a esse setor");
                }

            //}
            //catch 
            //{
             //   MessageBox.Show("Você não tem acesso a esse setor");
            //}
        }

        private void calcular_des_pm_elet()
        {
            
            total_tudo = total_exec_Cnc_des + total_exec_Eletrodo;
            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                if (dgvcnc_acab.Rows[i].Cells[9].Value.ToString() == "Porta_Molde")
                {
                    if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() != "")
                        try
                        {
                            total_pm = total_pm + Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Erro na soma do porta molde");
                        }
                
                }
            }
            total_tudo = total_tudo + total_pm;
            if (tb_exec_cnc_acab.Text != "")
                total_acab = Convert.ToDouble(tb_exec_cnc_acab.Text) - total_pm;

            this.datDesenhos.UpdateCommand.CommandText =
                    "UPDATE DESENHOS SET HORAS_EXEC_DES_PC_ELET_MOLDE = '" + total_tudo.ToString("n2").Replace(",",".") + "' WHERE N_OS_PECA = '" + tb_molde.Text + "'";
            this.fbConnection1.Open();
            this.datDesenhos.UpdateCommand.Connection = fbConnection1;
            this.datDesenhos.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 

            this.datDesenhos.UpdateCommand.CommandText =
                    "UPDATE DESENHOS SET HORAS_EXEC_CNC_ACAB_MOLDE = '" + total_acab.ToString("n2").Replace(",", ".") + "' WHERE N_OS_PECA = '" + tb_molde.Text + "'";
            this.fbConnection1.Open();
            this.datDesenhos.UpdateCommand.Connection = fbConnection1;
            this.datDesenhos.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            total_pm = 0;
            total_acab = 0;
            total_tudo = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {

       
            gerar_arquivo_texto();
           
            //form_crono_excel excel = new form_crono_excel();
            //excel.Show();
            //popular_grid();
           // 
        }
        /*
        private void popular_grid()
        {
            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\crono_excel.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [crono_excel$]", theConnection);
            DataSet theDS = new DataSet();
            System.Data.DataTable dtu = new System.Data.DataTable();
            theDataAdapter.Fill(dtu);
            this.dgvCrono.DataSource = dtu.DefaultView;
        }
        */

        private void gerar_arquivo_texto()
        {
            FileInfo d = new FileInfo("c:\\evolucao\\crono_excel.csv");
            d.Delete();
            FileInfo t = new FileInfo("c:\\evolucao\\crono_excel.txt");
            
                try
                {
                    using (StreamWriter texto = t.CreateText())
                    {
                        for (int i = 0; i < dgvPosicoes.RowCount; i++)
                        {
                            popula_fresa(link_fresa.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_torno(link_torno.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_cnc_des(link_cnc_desb.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_Tempera(link_tempera.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_Retifica(link_retifica.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_cnc_aca(link_cnc_acab.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_erosao_ewc(link_erosao_ewc.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_erosao_edm(link_erosao_edm.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_polimento(link_polimento.Text, dgvPosicoes.Rows[i].Cells[1].Value.ToString(), tb_molde.Text);
                            popula_projeto("%", "PROJETO", tb_molde.Text);
                            popula_porta_molde("%", "PORTA_MOLDE", tb_molde.Text);

                            //string real_fresa, real_torno, real_cnc_des, real_tempera, real_retifica, real_cnc_acab, real_erosao_edm, 
                            //  real_erosao_ewc, real_polimento;
                            
                            fresa = ";;;";
                            fresa_real = ";;;";
                            for (int j = 0; j < dgvfresa.RowCount; j++)
                            {
                                fresa = dgvfresa.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgvfresa.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgvfresa.Rows[j].Cells[3].Value.ToString() + ";";
                                fresa_real = dgvfresa.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgvfresa.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgvfresa.Rows[j].Cells[4].Value.ToString() + ";"; 

                            }
                            torno = ";;;";
                            torno_real = ";;;";
                            for (int j = 0; j < dgvtorno.RowCount; j++)
                            {
                                torno = dgvtorno.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgvtorno.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgvtorno.Rows[j].Cells[3].Value.ToString() + ";";
                                torno_real = dgvtorno.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgvtorno.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgvtorno.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            cnc_des = ";;;";
                            cnc_des_real = ";;;";
                            for (int j = 0; j < dgvcnc_des.RowCount; j++)
                            {
                                cnc_des = dgvcnc_des.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgvcnc_des.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgvcnc_des.Rows[j].Cells[3].Value.ToString() + ";";
                                cnc_des_real = dgvcnc_des.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgvcnc_des.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgvcnc_des.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            tempera = ";;;";
                            tempera_real = ";;;";
                            for (int j = 0; j < dgvtempera.RowCount; j++)
                            {
                                tempera = dgvtempera.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgvtempera.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgvtempera.Rows[j].Cells[3].Value.ToString() + ";";
                                tempera_real = dgvtempera.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgvtempera.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgvtempera.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            retifica = ";;;";
                            retifica_real = ";;;";
                            for (int j = 0; j < dgvretifica.RowCount; j++)
                            {
                                retifica = dgvretifica.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgvretifica.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgvretifica.Rows[j].Cells[3].Value.ToString() + ";";
                                retifica_real = dgvretifica.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgvretifica.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgvretifica.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            cnc_acab = ";;;";
                            cnc_acab_real = ";;;";
                            for (int j = 0; j < dgvcnc_acab.RowCount; j++)
                            {
                                cnc_acab = dgvcnc_acab.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgvcnc_acab.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgvcnc_acab.Rows[j].Cells[3].Value.ToString() + ";";
                                cnc_acab_real = dgvcnc_acab.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgvcnc_acab.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgvcnc_acab.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            erosao_edm = ";;;";
                            erosao_edm_real = ";;;";
                            for (int j = 0; j < dgverosao_edm.RowCount; j++)
                            {
                                erosao_edm = dgverosao_edm.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgverosao_edm.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgverosao_edm.Rows[j].Cells[3].Value.ToString() + ";";
                                erosao_edm_real = dgverosao_edm.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgverosao_edm.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgverosao_edm.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            erosao_ewc = ";;;";
                            erosao_ewc_real = ";;;";
                            for (int j = 0; j < dgverosao_ewc.RowCount; j++)
                            {
                                erosao_ewc = dgverosao_ewc.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgverosao_ewc.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgverosao_ewc.Rows[j].Cells[3].Value.ToString() + ";";
                                erosao_ewc_real = dgverosao_ewc.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgverosao_ewc.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgverosao_ewc.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            polimento = ";;;";
                            polimento_real = ";;;";
                            for (int j = 0; j < dgvpolimento.RowCount; j++)
                            {
                                polimento = dgvpolimento.Rows[j].Cells[1].Value.ToString() + ";" +
                                    dgvpolimento.Rows[j].Cells[2].Value.ToString() + ";" +
                                    dgvpolimento.Rows[j].Cells[3].Value.ToString() + ";";
                                polimento_real = dgvpolimento.Rows[j].Cells[5].Value.ToString() + ";" +
                                    dgvpolimento.Rows[j].Cells[6].Value.ToString() + ";" +
                                    dgvpolimento.Rows[j].Cells[4].Value.ToString() + ";";
                            }
                            texto.WriteLine(dgvPosicoes.Rows[i].Cells[1].Value.ToString() + ";" + fresa +  torno + 
                                cnc_des + tempera + retifica + cnc_acab + erosao_ewc + erosao_edm + 
                                polimento);
                            texto.WriteLine(dgvPosicoes.Rows[i].Cells[1].Value.ToString() + ";" + fresa_real + torno_real + 
                                cnc_des_real + tempera_real + retifica_real + cnc_acab_real + erosao_ewc_real + erosao_edm_real + 
                                polimento_real);

                           

                        }
                    }
                    
                }
                catch{}



                
                
               

            //t.Delete(
            t.CopyTo(Path.ChangeExtension(t.FullName, ".csv"), false);
            
        }

   

        private void dgvPosicoes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            popula_fresa(link_fresa.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_torno(link_torno.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_cnc_des(link_cnc_desb.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_Tempera(link_tempera.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_Retifica(link_retifica.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_cnc_aca(link_cnc_acab.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_erosao_ewc(link_erosao_ewc.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_erosao_edm(link_erosao_edm.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_polimento(link_polimento.Text, dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString(), tb_molde.Text);
            popula_projeto("%", "PROJETO", tb_molde.Text);
            popula_porta_molde("%", "PORTA_MOLDE", tb_molde.Text);
        }

        private void dgvfresa_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvfresa.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvtorno_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvtorno.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvcnc_des_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvcnc_des.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvtempera_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvtempera.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvretifica_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvretifica.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvcnc_acab_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvcnc_acab.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgverosao_ewc_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgverosao_ewc.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgverosao_edm_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgverosao_edm.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvpolimento_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvpolimento.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvporta_molde_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvporta_molde.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgvProjeto_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgvProjeto.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void dgveletrodo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            abre_rota.rota_atual = dgveletrodo.Rows[e.RowIndex].Cells[8].Value;
            abre_rota.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       
        private void label_a_fresa_MouseClick_1(object sender, MouseEventArgs e)
        {
            dgvfresa.Width = 90;
            dgvtorno.Visible = true;
        }

        private void label_p_fresa_MouseClick_1(object sender, MouseEventArgs e)
        {
            dgvfresa.Width = 180;
            dgvtorno.Visible = false;
        }

        private void label_a_cnc_desb_Click_1(object sender, EventArgs e)
        {
            dgvcnc_des.Width = 90;
            dgvtempera.Visible = true;
        }

        private void label_p_cnc_desb_Click_1(object sender, EventArgs e)
        {
            dgvcnc_des.Width = 180;
            dgvtempera.Visible = false;
        }

        private void label_a_tempera_Click_1(object sender, EventArgs e)
        {
            dgvtempera.Width = 90;
            dgvretifica.Visible = true;
        }

        

        private void label_a_retifica_Click_1(object sender, EventArgs e)
        {
            dgvretifica.Width = 90;
            dgvcnc_acab.Visible = true;
        }

        private void label_p_retifica_Click_2(object sender, EventArgs e)
        {
            dgvretifica.Width = 180;
            dgvcnc_acab.Visible = false;
        }

        private void label_p_tempera_Click(object sender, EventArgs e)
        {
            dgvtempera.Width = 180;
            dgvretifica.Visible = false;
        }

        private void label_a_cnc_acab_Click_1(object sender, EventArgs e)
        {
            dgvcnc_acab.Width = 90;
            dgverosao_ewc.Visible = true;
        }

        private void label_p_cnc_acab_Click_1(object sender, EventArgs e)
        {
            dgvcnc_acab.Width = 180;
            dgverosao_ewc.Visible = false;
        }

        private void label_a_erosao_ewc_Click_1(object sender, EventArgs e)
        {
            dgverosao_ewc.Width = 90;
            dgverosao_edm.Visible = true;
        }

        private void label_p_erosao_ewc_Click_1(object sender, EventArgs e)
        {
            dgverosao_ewc.Width = 180;
            dgverosao_edm.Visible = false;
        }

        private void label_a_erosao_edm_Click_1(object sender, EventArgs e)
        {
            dgverosao_edm.Width = 90;
            dgvpolimento.Visible = true;
        }

        private void label_p_erosao_edm_Click_1(object sender, EventArgs e)
        {
            dgverosao_edm.Width = 180;
            dgvpolimento.Visible = false;
        }

        private void label_a_eletrodo_Click(object sender, EventArgs e)
        {
            dgveletrodo.Width = 90;
            dgvporta_molde.Visible = true;
        }

        private void label_p_eletrodo_Click(object sender, EventArgs e)
        {
            dgveletrodo.Width = 180;
            dgvporta_molde.Visible = false;
            
        }

        private void label_p_torno_Click_1(object sender, EventArgs e)
        {
            dgvtorno.Width = 180;
            dgvcnc_des.Visible = false;
        }

        private void label_a_torno_Click_1(object sender, EventArgs e)
        {
            dgvtorno.Width = 90;
            dgvcnc_des.Visible = true;
        }

        
        private void abrirDesenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@cod_rota_desenho);
        }

       
        private void dgvfresa_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgvfresa.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void dgvtorno_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgvtorno.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void dgvcnc_des_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgvcnc_des.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void dgvtempera_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgvtempera.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void dgvretifica_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgvretifica.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void dgvcnc_acab_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgvcnc_acab.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void dgverosao_ewc_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgverosao_ewc.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void dgverosao_edm_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + tb_molde.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_molde.Text + "-" + dgverosao_edm.Rows[e.RowIndex].Cells[0].Value.ToString() + ".dwg";
        }

        private void tb_molde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                abrir();
            }
        }

        
        
    }
}