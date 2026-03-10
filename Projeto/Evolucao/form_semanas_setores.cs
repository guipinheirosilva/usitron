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
    public partial class form_semanas_setores : Form
    {
        string fresa, torno, cnc_des, tempera, retifica, cnc_acab, erosao_edm, erosao_ewc, polimento;
        string fresa_real, torno_real, cnc_des_real, tempera_real, retifica_real, cnc_acab_real, erosao_edm_real, erosao_ewc_real, polimento_real;
        double total_horas_prev;
        double total_horas_trab;

        string cod_rota_desenho;

        //acerta horas des/pm/elet

        //string cod_rota_desenho;
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
        int n_semanas;// = ultima_semana - primeira_semana;
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
        int n_semanas2;// = ultima_semana - primeira_semana;
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
        double total_horas_cnc_des;
        double total_horas_tempera;
        double total_horas_retifica;
        double total_horas_cnc_acab;
        double total_horas_erosao_ewc;
        double total_horas_erosao_edm;
        double total_horas_Polimento;
        double total_horas_Eletrodo;
        double total_horas_Projeto;
        double total_horas_Porta_molde;
        double total_exec_fresa;
        double total_exec_torno;
        int posicao_atual;
        double total_exec_cnc_des;
        double total_exec_tempera;
        double total_exec_retifica;
        double total_exec_cnc_acab;
        double total_exec_erosao_ewc;
        double total_exec_erosao_edm;
        double total_exec_Polimento;
        double total_exec_Projeto;
        double total_exec_Porta_molde;
        double total_exec_Eletrodo;
        //DataSet posicoes = new DataSet();
        
        public form_semanas_setores()
        {
            InitializeComponent();
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
            total_horas_trab = total_exec_cnc_acab + total_exec_cnc_des + total_exec_erosao_edm +
                total_exec_erosao_ewc + total_exec_fresa + total_exec_Eletrodo + total_exec_Polimento +
                total_exec_Porta_molde + total_exec_Projeto + total_exec_retifica + total_exec_tempera + total_exec_torno;
            total_horas_prev = total_horas_cnc_acab + total_horas_cnc_des + total_horas_erosao_edm +
                total_horas_erosao_ewc + total_horas_fresa + total_horas_Eletrodo + total_horas_Polimento +
                total_horas_Porta_molde + total_horas_Projeto + total_horas_retifica + total_horas_tempera + total_horas_torno;
            tb_total_prev.Text = total_horas_prev.ToString("n2");
            tb_total_trab.Text = total_horas_trab.ToString("n2");

        }

        private void ok()
        {
            popula_fresa(link_fresa.Text, "%", Convert.ToInt16(tb_semana.Text));
            popula_torno(link_torno.Text, "%", Convert.ToInt16(tb_semana.Text));
            popula_cnc_des(link_cnc_desb.Text, "%", Convert.ToInt16(tb_semana.Text));
            popula_tempera(link_tempera.Text, "%",  Convert.ToInt16(tb_semana.Text));
            popula_retifica(link_retifica.Text, "%", Convert.ToInt16(tb_semana.Text));
            popula_cnc_acab(link_cnc_acab.Text, "%", Convert.ToInt16(tb_semana.Text));
            popula_erosao_ewc(link_erosao_ewc.Text, "%", Convert.ToInt16(tb_semana.Text));
            popula_erosao_edm(link_erosao_edm.Text, "%", Convert.ToInt16(tb_semana.Text));
           // popula_polimento(link_polimento.Text, "%", Convert.ToInt16(tb_semana.Text));
//            popula_porta_molde("%", "PORTA_MOLDE", Convert.ToInt16(tb_semana.Text));

        }
        
        private string contar_dias(DateTime ultimo, DateTime primeiro)
        {
            TimeSpan numero_dias = ultimo.Subtract(primeiro);
            return numero_dias.Days.ToString();
        }
        private void popula_fresa(string operacao, string pos, int semana_atual)
        {
            total_horas_fresa = 0;
            total_exec_fresa = 0;
            //VERIFICAR PROBLEMAS NOS SALDO DE HORAS

            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgvfresa.DataSource = posicoes;
            dgvfresa.DataMember = posicoes.Tables[0].TableName;
            dgvfresa.Columns[0].Width = 38;
            dgvfresa.Columns[0].HeaderText = "OS";
            dgvfresa.Columns[1].Width = 20;
            dgvfresa.Columns[1].HeaderText = "Pos";
            dgvfresa.Columns[2].Width = 38;
            dgvfresa.Columns[2].HeaderText = "Ini";
            dgvfresa.Columns[3].Width = 38;
            dgvfresa.Columns[3].HeaderText = "Fim";
            dgvfresa.Columns[4].Width = 30;
            dgvfresa.Columns[4].HeaderText = "Horas";
            dgvfresa.Columns[5].Width = 30;
            dgvfresa.Columns[5].HeaderText = "HR";
            dgvfresa.Columns[6].Width = 30;
            dgvfresa.Columns[6].HeaderText = "Situação";
            dgvfresa.Columns[7].Width = 20;
            dgvfresa.Columns[7].HeaderText = "Cod";
            dgvfresa.Columns[8].Width = 20;
            dgvfresa.Columns[8].HeaderText = "Rota";
            dgvfresa.Columns[9].Width = 20;
            dgvfresa.Columns[9].HeaderText = "Oper";
            
            
            this.fbConnection1.Close(); 
            
            for (int i = 0; i < dgvfresa.RowCount; i++)
            {
                try
                {

                    if (dgvfresa.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_fresa = total_horas_fresa + Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value);
                    }
                    if (dgvfresa.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_fresa = total_exec_fresa + Convert.ToDouble(dgvfresa.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgvfresa.RowCount; i++)
            {
                try
                {


                    if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgvfresa.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgvfresa.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgvfresa.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_fresa.Text = total_horas_fresa.ToString("n2");
            tb_exec_fresa.Text = total_exec_fresa.ToString("n2");

            double porc_fresa_parcial;
            for (int i = 0; i < dgvfresa.RowCount; i++)
            {
                
                try
                {
                    if (dgvfresa.Rows[i].Cells[4].Value.ToString() != "" && tb_previsao_fresa.Text != "" && dgvfresa.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        porc_fresa_parcial = (Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_fresa.Text));
                        if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dgvfresa.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            porc_fresa = porc_fresa + porc_fresa_parcial * 100;
                        }
                        else
                        {
                            if (dgvfresa.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvfresa.Rows[i].Cells[5].Value.ToString()) >
                                    Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value.ToString()))
                                {
                                    porc_fresa = porc_fresa + ((porc_fresa_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_fresa = porc_fresa + (((Convert.ToDouble(dgvfresa.Rows[i].Cells[5].Value.ToString()) /
                                                    Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value.ToString())) *
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
        private void popula_torno(string operacao, string pos, int semana_atual)
        {
            
            total_horas_torno = 0;
            total_exec_torno = 0;
            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgvtorno.DataSource = posicoes;
            dgvtorno.DataMember = posicoes.Tables[0].TableName;
            dgvtorno.Columns[0].Width = 38;
            dgvtorno.Columns[0].HeaderText = "OS";
            dgvtorno.Columns[1].Width = 20;
            dgvtorno.Columns[1].HeaderText = "Pos";
            dgvtorno.Columns[2].Width = 38;
            dgvtorno.Columns[2].HeaderText = "Ini";
            dgvtorno.Columns[3].Width = 38;
            dgvtorno.Columns[3].HeaderText = "Fim";
            dgvtorno.Columns[4].Width = 30;
            dgvtorno.Columns[4].HeaderText = "Horas";
            dgvtorno.Columns[5].Width = 30;
            dgvtorno.Columns[5].HeaderText = "HR";
            dgvtorno.Columns[6].Width = 30;
            dgvtorno.Columns[6].HeaderText = "Situação";
            dgvtorno.Columns[7].Width = 20;
            dgvtorno.Columns[7].HeaderText = "Cod";
            dgvtorno.Columns[8].Width = 20;
            dgvtorno.Columns[8].HeaderText = "Rota";
            dgvtorno.Columns[9].Width = 20;
            dgvtorno.Columns[9].HeaderText = "Oper";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvtorno.RowCount; i++)
            {
                try
                {

                    if (dgvtorno.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_torno = total_horas_torno + Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value);
                    }
                    if (dgvtorno.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_torno = total_exec_torno + Convert.ToDouble(dgvtorno.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgvtorno.RowCount; i++)
            {
                try
                {


                    if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgvtorno.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgvtorno.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgvtorno.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_torno.Text = total_horas_torno.ToString("n2");
            tb_exec_torno.Text = total_exec_torno.ToString("n2");

            double porc_torno_parcial;
            for (int i = 0; i < dgvtorno.RowCount; i++)
            {
                //MessageBox.Show(porc_torno.ToString());
                try
                {
                    if (dgvtorno.Rows[i].Cells[4].Value.ToString() != "" && tb_previsao_torno.Text != "" && dgvtorno.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        porc_torno_parcial = (Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_torno.Text));
                        //MessageBox.Show(porc_torno_parcial.ToString());
                        if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dgvtorno.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            porc_torno = porc_torno + porc_torno_parcial * 100;
                        }
                        else
                        {
                            if (dgvtorno.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvtorno.Rows[i].Cells[5].Value.ToString()) >
                                    Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value.ToString()))
                                {
                                    porc_torno = porc_torno + ((porc_torno_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_torno = porc_torno + (((Convert.ToDouble(dgvtorno.Rows[i].Cells[5].Value.ToString()) /
                                                    Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value.ToString())) *
                                                    porc_torno_parcial) * 100);
                                }
                                
                            }
                        }
                    }
                }
                catch { }
            }
            
            

            tb_porc_torno.Text = porc_torno.ToString("n0");
            porc_torno = 0;

        
        }
        private void popula_cnc_des(string operacao, string pos, int semana_atual)
        {
            total_exec_cnc_des = 0;
            total_horas_cnc_des = 0;
            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgvcnc_des.DataSource = posicoes;
            dgvcnc_des.DataMember = posicoes.Tables[0].TableName;
            dgvcnc_des.Columns[0].Width = 38;
            dgvcnc_des.Columns[0].HeaderText = "OS";
            dgvcnc_des.Columns[1].Width = 20;
            dgvcnc_des.Columns[1].HeaderText = "Pos";
            dgvcnc_des.Columns[2].Width = 38;
            dgvcnc_des.Columns[2].HeaderText = "Ini";
            dgvcnc_des.Columns[3].Width = 38;
            dgvcnc_des.Columns[3].HeaderText = "Fim";
            dgvcnc_des.Columns[4].Width = 30;
            dgvcnc_des.Columns[4].HeaderText = "Horas";
            dgvcnc_des.Columns[5].Width = 30;
            dgvcnc_des.Columns[5].HeaderText = "HR";
            dgvcnc_des.Columns[6].Width = 30;
            dgvcnc_des.Columns[6].HeaderText = "Situação";
            dgvcnc_des.Columns[7].Width = 20;
            dgvcnc_des.Columns[7].HeaderText = "Cod";
            dgvcnc_des.Columns[8].Width = 20;
            dgvcnc_des.Columns[8].HeaderText = "Rota";
            dgvcnc_des.Columns[9].Width = 20;
            dgvcnc_des.Columns[9].HeaderText = "Oper";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvcnc_des.RowCount; i++)
            {
                try
                {

                    if (dgvcnc_des.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_cnc_des = total_horas_cnc_des + Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value);
                    }
                    if (dgvcnc_des.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_cnc_des = total_exec_cnc_des + Convert.ToDouble(dgvcnc_des.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgvcnc_des.RowCount; i++)
            {
                try
                {


                    if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgvcnc_des.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_cnc_des.Text = total_horas_cnc_des.ToString("n2");
            tb_exec_cnc_des.Text = total_exec_cnc_des.ToString("n2");

            double porc_cnc_des_parcial;
            for (int i = 0; i < dgvcnc_des.RowCount; i++)
            {
                //MessageBox.Show(porc_cnc_des.ToString());
                try
                {
                    if (dgvcnc_des.Rows[i].Cells[4].Value.ToString() != "" && tb_previsao_cnc_des.Text != "" && dgvcnc_des.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        porc_cnc_des_parcial = (Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_cnc_des.Text));
                        //MessageBox.Show(porc_cnc_des_parcial.ToString());
                        if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            porc_cnc_des = porc_cnc_des + porc_cnc_des_parcial * 100;
                        }
                        else
                        {
                            if (dgvcnc_des.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvcnc_des.Rows[i].Cells[5].Value.ToString()) >
                                    Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value.ToString()))
                                {
                                    porc_cnc_des = porc_cnc_des + ((porc_cnc_des_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_cnc_des = porc_cnc_des + (((Convert.ToDouble(dgvcnc_des.Rows[i].Cells[5].Value.ToString()) /
                                                    Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value.ToString())) *
                                                    porc_cnc_des_parcial) * 100);
                                }

                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_cnc_des.Text = porc_cnc_des.ToString("n0");
            porc_cnc_des = 0;
        }
        private void popula_tempera(string operacao, string pos, int semana_atual)
        {
            total_exec_tempera = 0;
            total_horas_tempera = 0;
            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgvtempera.DataSource = posicoes;
            dgvtempera.DataMember = posicoes.Tables[0].TableName;
            dgvtempera.Columns[0].Width = 38;
            dgvtempera.Columns[0].HeaderText = "OS";
            dgvtempera.Columns[1].Width = 20;
            dgvtempera.Columns[1].HeaderText = "Pos";
            dgvtempera.Columns[2].Width = 38;
            dgvtempera.Columns[2].HeaderText = "Ini";
            dgvtempera.Columns[3].Width = 38;
            dgvtempera.Columns[3].HeaderText = "Fim";
            dgvtempera.Columns[4].Width = 30;
            dgvtempera.Columns[4].HeaderText = "Horas";
            dgvtempera.Columns[5].Width = 30;
            dgvtempera.Columns[5].HeaderText = "HR";
            dgvtempera.Columns[6].Width = 30;
            dgvtempera.Columns[6].HeaderText = "Situação";
            dgvtempera.Columns[7].Width = 20;
            dgvtempera.Columns[7].HeaderText = "Cod";
            dgvtempera.Columns[8].Width = 20;
            dgvtempera.Columns[8].HeaderText = "Rota";
            dgvtempera.Columns[9].Width = 20;
            dgvtempera.Columns[9].HeaderText = "Oper";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvtempera.RowCount; i++)
            {
                try
                {

                    if (dgvtempera.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_tempera = total_horas_tempera + Convert.ToDouble(dgvtempera.Rows[i].Cells[4].Value);
                    }
                    if (dgvtempera.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_tempera = total_exec_tempera + Convert.ToDouble(dgvtempera.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgvtempera.RowCount; i++)
            {
                try
                {


                    if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgvtempera.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgvtempera.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgvtempera.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_tempera.Text = total_horas_tempera.ToString("n2");
            tb_exec_tempera.Text = total_exec_tempera.ToString("n2");

           
            for (int i = 0; i < dgvtempera.RowCount; i++)
            {
                if (dgvtempera.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                    dgvtempera.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
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
        private void popula_retifica(string operacao, string pos, int semana_atual)
        {
            total_exec_retifica = 0;
            total_horas_retifica = 0;
            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgvretifica.DataSource = posicoes;
            dgvretifica.DataMember = posicoes.Tables[0].TableName;
            dgvretifica.Columns[0].Width = 38;
            dgvretifica.Columns[0].HeaderText = "OS";
            dgvretifica.Columns[1].Width = 20;
            dgvretifica.Columns[1].HeaderText = "Pos";
            dgvretifica.Columns[2].Width = 38;
            dgvretifica.Columns[2].HeaderText = "Ini";
            dgvretifica.Columns[3].Width = 38;
            dgvretifica.Columns[3].HeaderText = "Fim";
            dgvretifica.Columns[4].Width = 30;
            dgvretifica.Columns[4].HeaderText = "Horas";
            dgvretifica.Columns[5].Width = 30;
            dgvretifica.Columns[5].HeaderText = "HR";
            dgvretifica.Columns[6].Width = 30;
            dgvretifica.Columns[6].HeaderText = "Situação";
            dgvretifica.Columns[7].Width = 20;
            dgvretifica.Columns[7].HeaderText = "Cod";
            dgvretifica.Columns[8].Width = 20;
            dgvretifica.Columns[8].HeaderText = "Rota";
            dgvretifica.Columns[9].Width = 20;
            dgvretifica.Columns[9].HeaderText = "Oper";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvretifica.RowCount; i++)
            {
                try
                {

                    if (dgvretifica.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_retifica = total_horas_retifica + Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value);
                    }
                    if (dgvretifica.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_retifica = total_exec_retifica + Convert.ToDouble(dgvretifica.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgvretifica.RowCount; i++)
            {
                try
                {


                    if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgvretifica.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgvretifica.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgvretifica.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_retifica.Text = total_horas_retifica.ToString("n2");
            tb_exec_retifica.Text = total_exec_retifica.ToString("n2");

            double porc_retifica_parcial;
            for (int i = 0; i < dgvretifica.RowCount; i++)
            {
                //MessageBox.Show(porc_retifica.ToString());
                try
                {
                    if (dgvretifica.Rows[i].Cells[4].Value.ToString() != "" && tb_previsao_retifica.Text != "" && dgvretifica.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        porc_retifica_parcial = (Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_retifica.Text));
                        //MessageBox.Show(porc_retifica_parcial.ToString());
                        if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dgvretifica.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            porc_retifica = porc_retifica + porc_retifica_parcial * 100;
                        }
                        else
                        {
                            if (dgvretifica.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvretifica.Rows[i].Cells[5].Value.ToString()) >
                                    Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value.ToString()))
                                {
                                    porc_retifica = porc_retifica + ((porc_retifica_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_retifica = porc_retifica + (((Convert.ToDouble(dgvretifica.Rows[i].Cells[5].Value.ToString()) /
                                                    Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value.ToString())) *
                                                    porc_retifica_parcial) * 100);
                                }

                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_retifica.Text = porc_retifica.ToString("n0");
            porc_retifica = 0;
        }
        private void popula_cnc_acab(string operacao, string pos, int semana_atual)
        {
            total_exec_cnc_acab = 0;
            total_horas_cnc_acab = 0;
            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgvcnc_acab.DataSource = posicoes;
            dgvcnc_acab.DataMember = posicoes.Tables[0].TableName;
            dgvcnc_acab.Columns[0].Width = 38;
            dgvcnc_acab.Columns[0].HeaderText = "OS";
            dgvcnc_acab.Columns[1].Width = 20;
            dgvcnc_acab.Columns[1].HeaderText = "Pos";
            dgvcnc_acab.Columns[2].Width = 38;
            dgvcnc_acab.Columns[2].HeaderText = "Ini";
            dgvcnc_acab.Columns[3].Width = 38;
            dgvcnc_acab.Columns[3].HeaderText = "Fim";
            dgvcnc_acab.Columns[4].Width = 30;
            dgvcnc_acab.Columns[4].HeaderText = "Horas";
            dgvcnc_acab.Columns[5].Width = 30;
            dgvcnc_acab.Columns[5].HeaderText = "HR";
            dgvcnc_acab.Columns[6].Width = 30;
            dgvcnc_acab.Columns[6].HeaderText = "Situação";
            dgvcnc_acab.Columns[7].Width = 20;
            dgvcnc_acab.Columns[7].HeaderText = "Cod";
            dgvcnc_acab.Columns[8].Width = 20;
            dgvcnc_acab.Columns[8].HeaderText = "Rota";
            dgvcnc_acab.Columns[9].Width = 20;
            dgvcnc_acab.Columns[9].HeaderText = "Oper";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                try
                {

                    if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_cnc_acab = total_horas_cnc_acab + Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value);
                    }
                    if (dgvcnc_acab.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_cnc_acab = total_exec_cnc_acab + Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                try
                {


                    if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgvcnc_acab.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_cnc_acab.Text = total_horas_cnc_acab.ToString("n2");
            tb_exec_cnc_acab.Text = total_exec_cnc_acab.ToString("n2");

            double porc_cnc_acab_parcial;
            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                //MessageBox.Show(porc_cnc_acab.ToString());
                try
                {
                    if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() != "" && tb_previsao_cnc_acab.Text != "" && dgvcnc_acab.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        porc_cnc_acab_parcial = (Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_cnc_acab.Text));
                        //MessageBox.Show(porc_cnc_acab_parcial.ToString());
                        if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            porc_cnc_acab = porc_cnc_acab + porc_cnc_acab_parcial * 100;
                        }
                        else
                        {
                            if (dgvcnc_acab.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[5].Value.ToString()) >
                                    Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value.ToString()))
                                {
                                    porc_cnc_acab = porc_cnc_acab + ((porc_cnc_acab_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_cnc_acab = porc_cnc_acab + (((Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[5].Value.ToString()) /
                                                    Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value.ToString())) *
                                                    porc_cnc_acab_parcial) * 100);
                                }

                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_cnc_acab.Text = porc_cnc_acab.ToString("n0");
            porc_cnc_acab = 0;
        }
        private void popula_erosao_ewc(string operacao, string pos, int semana_atual)
        {
            total_exec_erosao_ewc = 0;
            total_horas_erosao_ewc = 0;
            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgverosao_ewc.DataSource = posicoes;
            dgverosao_ewc.DataMember = posicoes.Tables[0].TableName;
            dgverosao_ewc.Columns[0].Width = 38;
            dgverosao_ewc.Columns[0].HeaderText = "OS";
            dgverosao_ewc.Columns[1].Width = 20;
            dgverosao_ewc.Columns[1].HeaderText = "Pos";
            dgverosao_ewc.Columns[2].Width = 38;
            dgverosao_ewc.Columns[2].HeaderText = "Ini";
            dgverosao_ewc.Columns[3].Width = 38;
            dgverosao_ewc.Columns[3].HeaderText = "Fim";
            dgverosao_ewc.Columns[4].Width = 30;
            dgverosao_ewc.Columns[4].HeaderText = "Horas";
            dgverosao_ewc.Columns[5].Width = 30;
            dgverosao_ewc.Columns[5].HeaderText = "HR";
            dgverosao_ewc.Columns[6].Width = 30;
            dgverosao_ewc.Columns[6].HeaderText = "Situação";
            dgverosao_ewc.Columns[7].Width = 20;
            dgverosao_ewc.Columns[7].HeaderText = "Cod";
            dgverosao_ewc.Columns[8].Width = 20;
            dgverosao_ewc.Columns[8].HeaderText = "Rota";
            dgverosao_ewc.Columns[9].Width = 20;
            dgverosao_ewc.Columns[9].HeaderText = "Oper";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgverosao_ewc.RowCount; i++)
            {
                try
                {

                    if (dgverosao_ewc.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_erosao_ewc = total_horas_erosao_ewc + Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value);
                    }
                    if (dgverosao_ewc.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_erosao_ewc = total_exec_erosao_ewc + Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgverosao_ewc.RowCount; i++)
            {
                try
                {


                    if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgverosao_ewc.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_erosao_ewc.Text = total_horas_erosao_ewc.ToString("n2");
            tb_exec_erosao_ewc.Text = total_exec_erosao_ewc.ToString("n2");

            double porc_erosao_ewc_parcial;
            for (int i = 0; i < dgverosao_ewc.RowCount; i++)
            {
                //MessageBox.Show(porc_erosao_ewc.ToString());
                try
                {
                    if (dgverosao_ewc.Rows[i].Cells[4].Value.ToString() != "" && tb_previsao_erosao_ewc.Text != "" && dgverosao_ewc.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        porc_erosao_ewc_parcial = (Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_erosao_ewc.Text));
                        //MessageBox.Show(porc_erosao_ewc_parcial.ToString());
                        if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            porc_erosao_ewc = porc_erosao_ewc + porc_erosao_ewc_parcial * 100;
                        }
                        else
                        {
                            if (dgverosao_ewc.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[5].Value.ToString()) >
                                    Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value.ToString()))
                                {
                                    porc_erosao_ewc = porc_erosao_ewc + ((porc_erosao_ewc_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_erosao_ewc = porc_erosao_ewc + (((Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[5].Value.ToString()) /
                                                    Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value.ToString())) *
                                                    porc_erosao_ewc_parcial) * 100);
                                }

                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_erosao_ewc.Text = porc_erosao_ewc.ToString("n0");
            porc_erosao_ewc = 0;
        }
        private void popula_erosao_edm(string operacao, string pos, int semana_atual)
        {
            total_exec_erosao_edm = 0;
            total_horas_erosao_edm = 0;
            comando_select.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
               "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
               "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
               "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
               "AND (OPERACAO_SEMANA = '" + operacao + "') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = comando_select;
            datSemanas.Fill(posicoes);
            dgverosao_edm.DataSource = posicoes;
            dgverosao_edm.DataMember = posicoes.Tables[0].TableName;
            dgverosao_edm.Columns[0].Width = 38;
            dgverosao_edm.Columns[0].HeaderText = "OS";
            dgverosao_edm.Columns[1].Width = 20;
            dgverosao_edm.Columns[1].HeaderText = "Pos";
            dgverosao_edm.Columns[2].Width = 38;
            dgverosao_edm.Columns[2].HeaderText = "Ini";
            dgverosao_edm.Columns[3].Width = 38;
            dgverosao_edm.Columns[3].HeaderText = "Fim";
            dgverosao_edm.Columns[4].Width = 30;
            dgverosao_edm.Columns[4].HeaderText = "Horas";
            dgverosao_edm.Columns[5].Width = 30;
            dgverosao_edm.Columns[5].HeaderText = "HR";
            dgverosao_edm.Columns[6].Width = 30;
            dgverosao_edm.Columns[6].HeaderText = "Situação";
            dgverosao_edm.Columns[7].Width = 20;
            dgverosao_edm.Columns[7].HeaderText = "Cod";
            dgverosao_edm.Columns[8].Width = 20;
            dgverosao_edm.Columns[8].HeaderText = "Rota";
            dgverosao_edm.Columns[9].Width = 20;
            dgverosao_edm.Columns[9].HeaderText = "Oper";


            this.fbConnection1.Close(); 

            for (int i = 0; i < dgverosao_edm.RowCount; i++)
            {
                try
                {

                    if (dgverosao_edm.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_erosao_edm = total_horas_erosao_edm + Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value);
                    }
                    if (dgverosao_edm.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_exec_erosao_edm = total_exec_erosao_edm + Convert.ToDouble(dgverosao_edm.Rows[i].Cells[5].Value);
                    }
                    //finalizados
                }
                catch { }
            }
            for (int i = 0; i < dgverosao_edm.RowCount; i++)
            {
                try
                {


                    if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                        dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                {
                                    dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "")
                                {
                                    dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        dgverosao_edm.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            tb_previsao_erosao_edm.Text = total_horas_erosao_edm.ToString("n2");
            tb_exec_erosao_edm.Text = total_exec_erosao_edm.ToString("n2");

            double porc_erosao_edm_parcial;
            for (int i = 0; i < dgverosao_edm.RowCount; i++)
            {
                //MessageBox.Show(porc_erosao_edm.ToString());
                try
                {
                    if (dgverosao_edm.Rows[i].Cells[4].Value.ToString() != "" && tb_previsao_erosao_edm.Text != "" && dgverosao_edm.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        porc_erosao_edm_parcial = (Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value.ToString()) /
                            Convert.ToDouble(tb_previsao_erosao_edm.Text));
                        //MessageBox.Show(porc_erosao_edm_parcial.ToString());
                        if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            porc_erosao_edm = porc_erosao_edm + porc_erosao_edm_parcial * 100;
                        }
                        else
                        {
                            if (dgverosao_edm.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                if (Convert.ToDouble(dgverosao_edm.Rows[i].Cells[5].Value.ToString()) >
                                    Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value.ToString()))
                                {
                                    porc_erosao_edm = porc_erosao_edm + ((porc_erosao_edm_parcial * 90 / 100) * 100);
                                }
                                else
                                {
                                    porc_erosao_edm = porc_erosao_edm + (((Convert.ToDouble(dgverosao_edm.Rows[i].Cells[5].Value.ToString()) /
                                                    Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value.ToString())) *
                                                    porc_erosao_edm_parcial) * 100);
                                }

                            }
                        }
                    }
                }
                catch { }
            }

            tb_porc_erosao_edm.Text = porc_erosao_edm.ToString("n0");
            porc_erosao_edm = 0;
        }
        /*
        private void popula_polimento(string operacao, string pos, int semana_atual)
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
         */
        private void form_cronograma_detalhado_Load(object sender, EventArgs e)
        {
            datSemana_ano.Fill(SEMANA_ANO);
            tb_semana.Focus();
            acha_semana();
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
        private void acha_semana()
        {
            int semana = 1 + conferir_semana(DateTime.Now) / 7;
            //MessageBox.Show(semana.ToString());
            int j = 0;


            while (Convert.ToInt32(label_ano.Text) != DateTime.Now.Year)
            {
                //MessageBox.Show(j.ToString() + " ANO");
                this.BindingContext[dsSemana_ano, "SEMANA_ANO"].Position = j;
                j++;
            }

            while (tb_semana.Text != semana.ToString())
            {

                // MessageBox.Show(j.ToString());
                this.BindingContext[dsSemana_ano, "SEMANA_ANO"].Position = j;
                j++;
            }



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

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            this.datImp_os.UpdateCommand.CommandText =
                    "UPDATE IMP_OS SET N_IMP_OS = '" + tb_semana.Text + "'";
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
            
            crOperacoes_todos nova = new crOperacoes_todos();
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

                    if (dgvfresa.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_fresa = total_horas_fresa + Convert.ToDouble(dgvfresa.Rows[i].Cells[4].Value);
                    }

                    //finalizados
                    if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" || dgvfresa.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        posicao_atual = 5;
                        
                    }
                    //parada
                    if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvfresa.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvfresa.Rows[i].Cells[3].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvfresa.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }

                }
                catch { }
                if (dgvfresa.Rows[i].Cells[4].Value.ToString() == "")
                    dgvfresa.Rows[i].Cells[4].Value = "0";
                if (dgvfresa.Rows[i].Cells[5].Value.ToString() == "")
                    dgvfresa.Rows[i].Cells[5].Value = "0";
                //insere os novos dados
                try
                {
                     ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvfresa.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvfresa.Rows[i].Cells[3].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                
                this.datImp_fresa.InsertCommand.CommandText =
                "INSERT INTO IMP_FRESA (OS_IMP_FRESA, POSICAO_IMP_FRESA, INICIO_IMP_FRESA, " +
                "FIM_IMP_FRESA, HORAS_TRAB_IMP_FRESA, " +
                "HORAS_PREV_IMP_FRESA, SIT_ATUAL_IMP_FRESA)" +
                "VALUES ('" + dgvfresa.Rows[i].Cells[0].Value.ToString() + "'," +
                "'" + dgvfresa.Rows[i].Cells[1].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + ",'" +
                dgvfresa.Rows[i].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                dgvfresa.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
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
                "DELETE FROM IMP_torno";
            this.fbConnection1.Open();
            this.datImp_torno.DeleteCommand.Connection = fbConnection1;
            this.datImp_torno.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvtorno.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    if (dgvtorno.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_torno = total_horas_torno + Convert.ToDouble(dgvtorno.Rows[i].Cells[4].Value);
                    }

                    //finalizados
                    if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" || dgvtorno.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        posicao_atual = 5;

                    }
                    //parada
                    if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvtorno.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvtorno.Rows[i].Cells[3].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvtorno.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }

                }
                catch { }
                if (dgvtorno.Rows[i].Cells[4].Value.ToString() == "")
                    dgvtorno.Rows[i].Cells[4].Value = "0";
                if (dgvtorno.Rows[i].Cells[5].Value.ToString() == "")
                    dgvtorno.Rows[i].Cells[5].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvtorno.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvtorno.Rows[i].Cells[3].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }

                this.datImp_torno.InsertCommand.CommandText =
                "INSERT INTO IMP_torno (OS_IMP_torno, POSICAO_IMP_torno, INICIO_IMP_torno, " +
                "FIM_IMP_torno, HORAS_TRAB_IMP_torno, " +
                "HORAS_PREV_IMP_torno, SIT_ATUAL_IMP_torno)" +
                "VALUES ('" + dgvtorno.Rows[i].Cells[0].Value.ToString() + "'," +
                "'" + dgvtorno.Rows[i].Cells[1].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + ",'" +
                dgvtorno.Rows[i].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                dgvtorno.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_torno.InsertCommand.Connection = fbConnection1;
                this.datImp_torno.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 



            }


            //seleciona os registros inseridos
            this.datImp_torno.SelectCommand.CommandText =
            "SELECT * FROM IMP_torno ORDER BY CODIGO_IMP_torno";
            this.fbConnection1.Open();
            this.datImp_torno.SelectCommand.Connection = fbConnection1;
            this.datImp_torno.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_cnc_desb()
        {
            //apaga registros anteriores
            this.datImp_cnc_desb.DeleteCommand.CommandText =
                "DELETE FROM IMP_cnc_desbaste";
            this.fbConnection1.Open();
            this.datImp_cnc_desb.DeleteCommand.Connection = fbConnection1;
            this.datImp_cnc_desb.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvcnc_des.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    if (dgvcnc_des.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_cnc_des = total_horas_cnc_des + Convert.ToDouble(dgvcnc_des.Rows[i].Cells[4].Value);
                    }

                    //finalizados
                    if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" || dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        posicao_atual = 5;

                    }
                    //parada
                    if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvcnc_des.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[3].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvcnc_des.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }

                }
                catch { }
                if (dgvcnc_des.Rows[i].Cells[4].Value.ToString() == "")
                    dgvcnc_des.Rows[i].Cells[4].Value = "0";
                if (dgvcnc_des.Rows[i].Cells[5].Value.ToString() == "")
                    dgvcnc_des.Rows[i].Cells[5].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_des.Rows[i].Cells[3].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }
                
                this.datImp_cnc_desb.InsertCommand.CommandText =
                "INSERT INTO IMP_cnc_desbaste (OS_IMP_CNC_DESBASTE, POSICAO_IMP_cnc_desbaste, INICIO_IMP_cnc_desbaste, " +
                "FIM_IMP_cnc_desbaste, HORAS_TRAB_IMP_cnc_desbaste, " +
                "HORAS_PREV_IMP_cnc_desbaste, SIT_ATUAL_IMP_cnc_desbaste)" +
                "VALUES ('" + dgvcnc_des.Rows[i].Cells[0].Value.ToString() + "'," +
                "'" + dgvcnc_des.Rows[i].Cells[1].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + ",'" +
                   dgvcnc_des.Rows[i].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                dgvcnc_des.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_cnc_desb.InsertCommand.Connection = fbConnection1;
                this.datImp_cnc_desb.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 



            }


            //seleciona os registros inseridos
            this.datImp_cnc_desb.SelectCommand.CommandText =
            "SELECT * FROM IMP_cnc_desbaste ORDER BY CODIGO_IMP_cnc_desbaste";
            this.fbConnection1.Open();
            this.datImp_cnc_desb.SelectCommand.Connection = fbConnection1;
            this.datImp_cnc_desb.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_retifica()
        {
            //apaga registros anteriores
            this.datImp_retifica.DeleteCommand.CommandText =
                "DELETE FROM IMP_retifica";
            this.fbConnection1.Open();
            this.datImp_retifica.DeleteCommand.Connection = fbConnection1;
            this.datImp_retifica.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvretifica.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    if (dgvretifica.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_retifica = total_horas_retifica + Convert.ToDouble(dgvretifica.Rows[i].Cells[4].Value);
                    }

                    //finalizados
                    if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" || dgvretifica.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        posicao_atual = 5;

                    }
                    //parada
                    if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvretifica.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvretifica.Rows[i].Cells[3].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvretifica.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }

                }
                catch { }
                if (dgvretifica.Rows[i].Cells[4].Value.ToString() == "")
                    dgvretifica.Rows[i].Cells[4].Value = "0";
                if (dgvretifica.Rows[i].Cells[5].Value.ToString() == "")
                    dgvretifica.Rows[i].Cells[5].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvretifica.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvretifica.Rows[i].Cells[3].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }

                this.datImp_retifica.InsertCommand.CommandText =
                "INSERT INTO IMP_retifica (OS_IMP_retifica, POSICAO_IMP_retifica, INICIO_IMP_retifica, " +
                "FIM_IMP_retifica, HORAS_TRAB_IMP_retifica, " +
                "HORAS_PREV_IMP_retifica, SIT_ATUAL_IMP_retifica)" +
                "VALUES ('" + dgvretifica.Rows[i].Cells[0].Value.ToString() + "'," +
                "'" + dgvretifica.Rows[i].Cells[1].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + ",'" +
                dgvretifica.Rows[i].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                dgvretifica.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_retifica.InsertCommand.Connection = fbConnection1;
                this.datImp_retifica.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 



            }


            //seleciona os registros inseridos
            this.datImp_retifica.SelectCommand.CommandText =
            "SELECT * FROM IMP_retifica ORDER BY CODIGO_IMP_retifica";
            this.fbConnection1.Open();
            this.datImp_retifica.SelectCommand.Connection = fbConnection1;
            this.datImp_retifica.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_cnc_acab()
        {
            //apaga registros anteriores
            this.datImp_cnc_acab.DeleteCommand.CommandText =
                "DELETE FROM IMP_cnc_acab";
            this.fbConnection1.Open();
            this.datImp_cnc_acab.DeleteCommand.Connection = fbConnection1;
            this.datImp_cnc_acab.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvcnc_acab.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_cnc_acab = total_horas_cnc_acab + Convert.ToDouble(dgvcnc_acab.Rows[i].Cells[4].Value);
                    }

                    //finalizados
                    if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" || dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        posicao_atual = 5;

                    }
                    //parada
                    if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgvcnc_acab.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[3].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgvcnc_acab.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }

                }
                catch { }
                if (dgvcnc_acab.Rows[i].Cells[4].Value.ToString() == "")
                    dgvcnc_acab.Rows[i].Cells[4].Value = "0";
                if (dgvcnc_acab.Rows[i].Cells[5].Value.ToString() == "")
                    dgvcnc_acab.Rows[i].Cells[5].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgvcnc_acab.Rows[i].Cells[3].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }

                this.datImp_cnc_acab.InsertCommand.CommandText =
                "INSERT INTO IMP_cnc_acab (OS_IMP_cnc_acab, POSICAO_IMP_cnc_acab, INICIO_IMP_cnc_acab, " +
                "FIM_IMP_cnc_acab, HORAS_TRAB_IMP_cnc_acab, " +
                "HORAS_PREV_IMP_cnc_acab, SIT_ATUAL_IMP_cnc_acab)" +
                "VALUES ('" + dgvcnc_acab.Rows[i].Cells[0].Value.ToString() + "'," +
                "'" + dgvcnc_acab.Rows[i].Cells[1].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + ",'" +
                dgvcnc_acab.Rows[i].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                dgvcnc_acab.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_cnc_acab.InsertCommand.Connection = fbConnection1;
                this.datImp_cnc_acab.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 



            }


            //seleciona os registros inseridos
            this.datImp_cnc_acab.SelectCommand.CommandText =
            "SELECT * FROM IMP_cnc_acab ORDER BY CODIGO_IMP_cnc_acab";
            this.fbConnection1.Open();
            this.datImp_cnc_acab.SelectCommand.Connection = fbConnection1;
            this.datImp_cnc_acab.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }

        private void insere_erosao_ewc()
        {
            //apaga registros anteriores
            this.datImp_erosao_ewc.DeleteCommand.CommandText =
                "DELETE FROM IMP_erosao_ewc";
            this.fbConnection1.Open();
            this.datImp_erosao_ewc.DeleteCommand.Connection = fbConnection1;
            this.datImp_erosao_ewc.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgverosao_ewc.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    if (dgverosao_ewc.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_erosao_ewc = total_horas_erosao_ewc + Convert.ToDouble(dgverosao_ewc.Rows[i].Cells[4].Value);
                    }

                    //finalizados
                    if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" || dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        posicao_atual = 5;

                    }
                    //parada
                    if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgverosao_ewc.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[3].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgverosao_ewc.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }

                }
                catch { }
                if (dgverosao_ewc.Rows[i].Cells[4].Value.ToString() == "")
                    dgverosao_ewc.Rows[i].Cells[4].Value = "0";
                if (dgverosao_ewc.Rows[i].Cells[5].Value.ToString() == "")
                    dgverosao_ewc.Rows[i].Cells[5].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_ewc.Rows[i].Cells[3].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }

                this.datImp_erosao_ewc.InsertCommand.CommandText =
                "INSERT INTO IMP_erosao_ewc (OS_IMP_erosao_ewc, POSICAO_IMP_erosao_ewc, INICIO_IMP_erosao_ewc, " +
                "FIM_IMP_erosao_ewc, HORAS_TRAB_IMP_erosao_ewc, " +
                "HORAS_PREV_IMP_erosao_ewc, SIT_ATUAL_IMP_erosao_ewc)" +
                "VALUES ('" + dgverosao_ewc.Rows[i].Cells[0].Value.ToString() + "'," +
                "'" + dgverosao_ewc.Rows[i].Cells[1].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + ",'" +
                dgverosao_ewc.Rows[i].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                dgverosao_ewc.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_erosao_ewc.InsertCommand.Connection = fbConnection1;
                this.datImp_erosao_ewc.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 



            }


            //seleciona os registros inseridos
            this.datImp_erosao_ewc.SelectCommand.CommandText =
            "SELECT * FROM IMP_erosao_ewc ORDER BY CODIGO_IMP_erosao_ewc";
            this.fbConnection1.Open();
            this.datImp_erosao_ewc.SelectCommand.Connection = fbConnection1;
            this.datImp_erosao_ewc.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


        }


        private void insere_erosao_edm()
        {
            //apaga registros anteriores
            this.datImp_erosao_edm.DeleteCommand.CommandText =
                "DELETE FROM IMP_erosao_edm";
            this.fbConnection1.Open();
            this.datImp_erosao_edm.DeleteCommand.Connection = fbConnection1;
            this.datImp_erosao_edm.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgverosao_edm.RowCount; i++)
            {
                //escolhe a posicao atual
                try
                {

                    if (dgverosao_edm.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        total_horas_erosao_edm = total_horas_erosao_edm + Convert.ToDouble(dgverosao_edm.Rows[i].Cells[4].Value);
                    }

                    //finalizados
                    if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" || dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                    {
                        //com atraso
                        posicao_atual = 5;

                    }
                    //parada
                    if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "PARADA")
                    {
                        posicao_atual = 2;
                    }
                    //aguardando
                    if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        posicao_atual = 0;
                    }
                    //Em andamento
                    if (dgverosao_edm.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                    {
                        posicao_atual = 1;
                    }
                    //atrasados
                    if (Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[3].Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()) && dgverosao_edm.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                    {
                        posicao_atual = 4;
                    }

                }
                catch { }
                if (dgverosao_edm.Rows[i].Cells[4].Value.ToString() == "")
                    dgverosao_edm.Rows[i].Cells[4].Value = "0";
                if (dgverosao_edm.Rows[i].Cells[5].Value.ToString() == "")
                    dgverosao_edm.Rows[i].Cells[5].Value = "0";
                //insere os novos dados
                try
                {
                    ent_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[2].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { ent_prev = "null"; }
                try
                {
                    fec_prev = "'" + Convert.ToString(Convert.ToDateTime(dgverosao_edm.Rows[i].Cells[3].Value).ToShortDateString().Replace("/", ".")) + "'";
                }
                catch { fec_prev = "null"; }

                this.datImp_erosao_edm.InsertCommand.CommandText =
                "INSERT INTO IMP_erosao_edm (OS_IMP_erosao_edm, POSICAO_IMP_erosao_edm, INICIO_IMP_erosao_edm, " +
                "FIM_IMP_erosao_edm, HORAS_TRAB_IMP_erosao_edm, " +
                "HORAS_PREV_IMP_erosao_edm, SIT_ATUAL_IMP_erosao_edm)" +
                "VALUES ('" + dgverosao_edm.Rows[i].Cells[0].Value.ToString() + "'," +
                "'" + dgverosao_edm.Rows[i].Cells[1].Value.ToString() + "'," +
                ent_prev + "," + fec_prev + ",'" +
                dgverosao_edm.Rows[i].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                dgverosao_edm.Rows[i].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                posicao_atual + "')";
                this.fbConnection1.Open();
                this.datImp_erosao_edm.InsertCommand.Connection = fbConnection1;
                this.datImp_erosao_edm.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 



            }


            //seleciona os registros inseridos
            this.datImp_erosao_edm.SelectCommand.CommandText =
            "SELECT * FROM IMP_erosao_edm ORDER BY CODIGO_IMP_erosao_edm";
            this.fbConnection1.Open();
            this.datImp_erosao_edm.SelectCommand.Connection = fbConnection1;
            this.datImp_erosao_edm.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 


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

        
 

       
       

        private void tb_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsSemana_ano, "SEMANA_ANO"].Position++;
        }

        private void tb_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsSemana_ano, "SEMANA_ANO"].Position--;
        }

        private void tb_Ok_Click(object sender, EventArgs e)
        {
            funcao = "%";
            ok();
            somar_horas();
            // popular_grid();
            Atualizar();
        }

        private string detectar_cliente(string os)
        {
            
            comando_select.CommandText = "SELECT CLIENTE FROM DESENHOS WHERE N_OS_PECA = '" + os + "'";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datDesenhos.SelectCommand = comando_select;
            datDesenhos.Fill(posicoes);
            string cliente = "";
            foreach (DataRow dr in posicoes.Tables[0].Rows)
            {
                cliente = dr["CLIENTE"].ToString();
            }
   
            this.fbConnection1.Close(); 
            return cliente;
            

        }

        private void dgvfresa_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgvfresa.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgvfresa.Rows[e.RowIndex].Cells[0].Value.ToString()) +")//projeto//OS " + dgvfresa.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgvfresa.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        private void abrirDesenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@cod_rota_desenho);
        }

        private void dgvtorno_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgvtorno.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgvtorno.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dgvtorno.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgvtorno.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        private void dgvcnc_des_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgvcnc_des.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgvcnc_des.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dgvcnc_des.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgvcnc_des.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        private void dgvtempera_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgvtempera.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgvtempera.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dgvtempera.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgvtempera.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        private void dgvretifica_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgvretifica.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgvretifica.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dgvretifica.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgvretifica.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        private void dgvcnc_acab_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgvcnc_acab.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgvcnc_acab.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dgvcnc_acab.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgvcnc_acab.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        private void dgverosao_ewc_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgverosao_ewc.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgverosao_ewc.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dgverosao_ewc.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgverosao_ewc.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        private void dgverosao_edm_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dgverosao_edm.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dgverosao_edm.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dgverosao_edm.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dgverosao_edm.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

        
    }
}