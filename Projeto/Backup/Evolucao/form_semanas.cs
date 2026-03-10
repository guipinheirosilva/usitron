using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.ProviderBase;
using System.IO;

namespace Evolucao
{
   
    public partial class form_semanas : Form
    {
        string cod_rota_desenho;
        string inicio;
        string fim;
        int n_semana;
        bool mudou;
        string ano;
        string semana;
        string pos_atual;
        bool imprimir_ok;
        string operacao_atual;
        bool erro;
        public form_semanas()
        {
            InitializeComponent();
        }

        private void form_semanas_Load(object sender, EventArgs e)
        {
            datSemana_ano.Fill(SEMANA_ANO);
            tb_semana.Focus();
            acha_semana();
        }

        private void acha_semana()
        {
            int semana = 1 + conferir_semana(DateTime.Now)/7;
            //MessageBox.Show(semana.ToString());
            int j=0;
            
            
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
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 21;
            fbCommand1.CommandText = "SELECT * FROM HORAS_SEMANA WHERE N_SEMANA = '" + n.ToString() + "'";
            DataSet semana = new DataSet();
            fbConnection1.Open();

            datSemanas.SelectCommand = fbCommand1;
            datSemanas.Fill(semana);
            dataGridView1.DataSource = semana;
            dataGridView2.DataSource = semana;

            dataGridView1.DataMember = semana.Tables[0].TableName;
            dataGridView2.DataMember = semana.Tables[0].TableName;



        }
        */
        private void tb_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsSemana_ano, "SEMANA_ANO"].Position++;
            
        }

        private void tb_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsSemana_ano, "SEMANA_ANO"].Position--;
        }

        private void rbTorno_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Torno";
            selecionar_operacao(operacao_atual);
        }

        private void rbFresa_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Fresa";
            selecionar_operacao(operacao_atual);

        }

        private void rbRetifica_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Retífica";
            selecionar_operacao(operacao_atual);
        }

        private void rbCnc_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "CNC (Desbaste)";
            selecionar_operacao(operacao_atual);
        }

        private void rbTempera_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Têmpera";
            selecionar_operacao(operacao_atual);
        }

        private void rbCnc_acab_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "CNC (Acab.)";
            selecionar_operacao(operacao_atual);
        }

        private void rbErosao_ewc_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Erosão (EWC)";
            selecionar_operacao(operacao_atual);
        }

        private void rbPolimento_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Polimento";
            selecionar_operacao(operacao_atual);
        }

        private void rbErosao_edm_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Erosão (EDM)";
            selecionar_operacao(operacao_atual);
        }

        private void rbMontagem_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Montagem";
            selecionar_operacao(operacao_atual);
        }

        private void selecionar_operacao(string oper)
        {
            dsOperacoes.Clear();
            this.datOperacoes.SelectCommand.CommandText =
                "SELECT * FROM TIPOS_OPERACOES WHERE TIPO = '" + oper + "'";
            this.fbConnection1.Open();
            this.datOperacoes.SelectCommand.Connection = fbConnection1;
            this.datOperacoes.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datOperacoes.Fill(TIPOS_OPERACOES);
            

        }

        private void tb_Ok_Click(object sender, EventArgs e)
        {
            zerar_negativos();

            comecar();   
        }

        private void zerar_negativos()
        {
            this.datSemanas.UpdateCommand.CommandText =
                        "update horas_semana set horas_operacao_semana = 0 where horas_operacao_semana < 0";
            this.fbConnection1.Open();
            this.datSemanas.UpdateCommand.Connection = fbConnection1;
            this.datSemanas.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

        }

        private void comecar()
        {
            
            string operacao_atual = "'" + label_operacao.Text + "'";
            if (label_operacao.Text == "CNC (Desbaste)" || label_operacao.Text == "CNC (Acab.)")
                operacao_atual = "'CNC (Desbaste)' OR OPERACAO_SEMANA = 'CNC (Acab.)'";
            if (label_operacao.Text == "Montagem")
                operacao_atual = "'AJUSTE E MONTAGEM' OR OPERACAO_SEMANA = 'AJUSTE E MONTAGEM AD'";
            //semana_1(Convert.ToInt32(tb_semana.Text) - 4, label_operacao.Text);
            //semana_2(Convert.ToInt32(tb_semana.Text) - 3, label_operacao.Text);
            semana_3(Convert.ToInt32(tb_semana.Text) - 2, operacao_atual);
            label_semana_3.Text = Convert.ToString(Convert.ToInt32(tb_semana.Text) - 2);
            semana_4(Convert.ToInt32(tb_semana.Text) - 1, operacao_atual);
            label_semana_4.Text = Convert.ToString(Convert.ToInt32(tb_semana.Text) - 1);
            semana_5(Convert.ToInt32(tb_semana.Text), operacao_atual);
            n_semana = Convert.ToInt32(tb_semana.Text) + 1;
            int n_ano = Convert.ToInt32(label_ano.Text);
            
            if (n_semana > 53)
            {
                n_semana = 2;
                n_ano = n_ano + 1;
                mudou = true;
            }
            semana_6(n_semana, operacao_atual, n_ano);
            label_semana_6.Text = Convert.ToString(n_semana);
            n_semana++;
            if (n_semana > 53 && mudou == false)
            {
                n_semana = 2;
                n_ano = n_ano + 1;
                mudou = true;
            }
            semana_7(n_semana, operacao_atual, n_ano);
            label_semana_7.Text = Convert.ToString(n_semana);
            n_semana++;
            if (n_semana > 53 && mudou == true)
            {
                n_semana = 2;
                n_ano = n_ano + 1;
                mudou = true;
            }
            semana_8(n_semana, operacao_atual, n_ano);
            label_semana_8.Text = Convert.ToString(n_semana);
            n_semana++;
            if (n_semana > 53 && mudou == true)
            {
                n_semana = 2;
                n_ano = n_ano + 1;
                mudou = true;
            }
            semana_9(n_semana, operacao_atual, n_ano);
            label_semana_9.Text = Convert.ToString(n_semana);
            mudou = false;
            n_semana = 0;
           
        }
        
        private void semana_3(int semana_atual, string oper_atual)
        {
            
            fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, " +
                "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                "OPERACAO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                "AND (OPERACAO_SEMANA = " + oper_atual + ") AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet semana = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = fbCommand1;
            datSemanas.Fill(semana);
            dataGridView3.DataSource = semana;
            dataGridView3.DataMember = semana.Tables[0].TableName;
            dataGridView3.Columns[0].Width = 50;
            dataGridView3.Columns[0].HeaderText = "OS";
            dataGridView3.Columns[1].Width = 30;
            dataGridView3.Columns[1].HeaderText = "Pos";
            dataGridView3.Columns[2].Width = 50;
            dataGridView3.Columns[2].HeaderText = "Ini";
            dataGridView3.Columns[3].Width = 50;
            dataGridView3.Columns[3].HeaderText = "Fim";
            dataGridView3.Columns[4].Width = 30;
            dataGridView3.Columns[4].HeaderText = "Horas";
            dataGridView3.Columns[5].Width = 40;
            dataGridView3.Columns[5].HeaderText = "Situação";
            dataGridView3.Columns[6].Width = 20;
            dataGridView3.Columns[6].HeaderText = "Cod";
            dataGridView3.Columns[7].Width = 20;
            dataGridView3.Columns[7].HeaderText = "Rota";
            dataGridView3.Columns[8].Width = 20;
            dataGridView3.Columns[8].HeaderText = "Oper";
            fbConnection1.Close();
            double total_horas_semana3 = 0;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                try
                {
                    if (dataGridView3.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        total_horas_semana3 = total_horas_semana3 + Convert.ToDouble(dataGridView3.Rows[i].Cells[4].Value);
                    }
                    /*
                    if (dataGridView3.Rows[i].Cells[8].Value.ToString() != label_operacao.Text)
                    {
                        dataGridView3.Rows[i].Visible = false;
                    }*/
                }
                catch
                {
                    dataGridView3.Sort(dataGridView3.Columns[8], ListSortDirection.Ascending);
                }
            }
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                try
                {
                    
                    if (dataGridView3.Rows[i].Cells[5].Value.ToString() == "FINALIZADO" || 
                        dataGridView3.Rows[i].Cells[5].Value.ToString() == "RETRABALHO")
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dataGridView3.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dataGridView3.Rows[i].Cells[5].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dataGridView3.Rows[i].Cells[5].Value.ToString() == "")
                                {
                                    dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dataGridView3.Rows[i].Cells[5].Value.ToString() == "PARADA")
                                {
                                    dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                        }
                    }
                }
                catch { }
            }
            tb_total_3.Text = total_horas_semana3.ToString();
            try
            {
                if (Convert.ToDouble(tb_total_3.Text) > Convert.ToDouble(label_horas.Text))
                    tb_total_3.ForeColor = Color.Red;
                else
                    tb_total_3.ForeColor = Color.Green;
            }
            catch
            {
                tb_total_3.ForeColor = Color.Green;
            }
            /*
            try
            {
                if (dataGridView3.Rows[0].Cells[8].Value.ToString() != label_operacao.Text)
                {
                    semana.Clear();
                    //MessageBox.Show("Nenhuma operação");
                    fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                    "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                    "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                    "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                    "AND (OPERACAO_SEMANA = 'nenhuma') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
                    //DataSet semana = new DataSet();
                    fbConnection1.Open();
                    datSemanas.SelectCommand = fbCommand1;
                    datSemanas.Fill(semana);
                    dataGridView3.DataSource = semana;
                    dataGridView3.DataMember = semana.Tables[0].TableName;
                    fbConnection1.Close();
                }
            }
            catch { }
            */
        }
        private void semana_4(int semana_atual, string oper_atual)
        {
            fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, " +
                "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                "OPERACAO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                "AND (OPERACAO_SEMANA = " + oper_atual + ") AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet semana = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = fbCommand1;
            datSemanas.Fill(semana);
            dataGridView4.DataSource = semana;
            dataGridView4.DataMember = semana.Tables[0].TableName;
            dataGridView4.Columns[0].Width = 50;
            dataGridView4.Columns[0].HeaderText = "OS";
            dataGridView4.Columns[1].Width = 30;
            dataGridView4.Columns[1].HeaderText = "Pos";
            dataGridView4.Columns[2].Width = 50;
            dataGridView4.Columns[2].HeaderText = "Ini";
            dataGridView4.Columns[3].Width = 50;
            dataGridView4.Columns[3].HeaderText = "Fim";
            dataGridView4.Columns[4].Width = 30;
            dataGridView4.Columns[4].HeaderText = "Horas";
            dataGridView4.Columns[5].Width = 40;
            dataGridView4.Columns[5].HeaderText = "Situação";
            dataGridView4.Columns[6].Width = 20;
            dataGridView4.Columns[6].HeaderText = "Cod";
            dataGridView4.Columns[7].Width = 20;
            dataGridView4.Columns[7].HeaderText = "Rota";
            dataGridView4.Columns[8].Width = 20;
            dataGridView4.Columns[8].HeaderText = "Oper";
            fbConnection1.Close();
            double total_horas_semana4 = 0;
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                try
                {
                    if (dataGridView4.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        total_horas_semana4 = total_horas_semana4 + Convert.ToDouble(dataGridView4.Rows[i].Cells[4].Value);
                    }
                    /*
                    if (dataGridView4.Rows[i].Cells[8].Value.ToString() != label_operacao.Text)
                    {
                        dataGridView4.Rows[i].Visible = false;
                    }
                     * */
                }
                catch
                {
                    dataGridView4.Sort(dataGridView4.Columns[8], ListSortDirection.Ascending);
                }
            }
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                try
                {
                    
                    if (dataGridView4.Rows[i].Cells[5].Value.ToString() == "FINALIZADO" ||
                        dataGridView4.Rows[i].Cells[5].Value.ToString() == "RETRABALHO" )
                    {
                        dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dataGridView4.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dataGridView4.Rows[i].Cells[5].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dataGridView4.Rows[i].Cells[5].Value.ToString() == "")
                                {
                                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dataGridView4.Rows[i].Cells[5].Value.ToString() == "PARADA")
                                {
                                    dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                        }
                    }
                }
                catch { }
            }
            tb_total_4.Text = total_horas_semana4.ToString();
            try
            {
                if (Convert.ToDouble(tb_total_4.Text) > Convert.ToDouble(label_horas.Text))
                    tb_total_4.ForeColor = Color.Red;
                else
                    tb_total_4.ForeColor = Color.Green;
            }
            catch
            {
                tb_total_4.ForeColor = Color.Green;
            }
            /*
            try
            {
                if (dataGridView4.Rows[0].Cells[8].Value.ToString() != label_operacao.Text)
                {
                    semana.Clear();
                    //MessageBox.Show("Nenhuma operação");
                    fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                    "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                    "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                    "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                    "AND (OPERACAO_SEMANA = 'nenhuma') AND ANO_SEMANA = '" + label_ano.Text + "' ORDER BY OS_SEMANA";
                    //DataSet semana = new DataSet();
                    fbConnection1.Open();
                    datSemanas.SelectCommand = fbCommand1;
                    datSemanas.Fill(semana);
                    dataGridView4.DataSource = semana;
                    dataGridView4.DataMember = semana.Tables[0].TableName;
                    fbConnection1.Close();
                }
            }
            catch { }
             * */
            
        }

        private void semana_5(int semana_atual, string oper_atual)
        {
            
            fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                "AND (OPERACAO_SEMANA = " + oper_atual + ") AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
                DataSet semana = new DataSet();
                fbConnection1.Open();
                datSemanas.SelectCommand = fbCommand1;
                datSemanas.Fill(semana);
                dataGridView5.DataSource = semana;
                dataGridView5.DataMember = semana.Tables[0].TableName;
                dataGridView5.Columns[0].Width = 38;
                dataGridView5.Columns[0].HeaderText = "OS";
                dataGridView5.Columns[1].Width = 20;
                dataGridView5.Columns[1].HeaderText = "Pos";
                dataGridView5.Columns[2].Width = 38;
                dataGridView5.Columns[2].HeaderText = "Ini";
                dataGridView5.Columns[3].Width = 38;
                dataGridView5.Columns[3].HeaderText = "Fim";
                dataGridView5.Columns[4].Width = 30;
                dataGridView5.Columns[4].HeaderText = "Horas";
                dataGridView5.Columns[5].Width = 30;
                dataGridView5.Columns[5].HeaderText = "HR";
                dataGridView5.Columns[6].Width = 30;
                dataGridView5.Columns[6].HeaderText = "Situação";
                dataGridView5.Columns[7].Width = 20;
                dataGridView5.Columns[7].HeaderText = "Cod";
                dataGridView5.Columns[8].Width = 20;
                dataGridView5.Columns[8].HeaderText = "Rota";
                dataGridView5.Columns[9].Width = 20;
                dataGridView5.Columns[9].HeaderText = "Oper";
            /*    
            dataGridView5.Columns.Remove(dataGridView5.Columns[10]);
                DataGridViewCheckBoxColumn nova_coluna = new DataGridViewCheckBoxColumn();
                nova_coluna.Width = 20;
                nova_coluna.HeaderText = "Passado";
                dataGridView5.Columns.Insert(10, nova_coluna);
             * */
                dataGridView5.Columns[10].Width = 20;
                dataGridView5.Columns[10].HeaderText = "Passado?";
                //dataGridView3.
                fbConnection1.Close();
                double total_horas_semana5 = 0;
                double total_horas_reais = 0;
                double total_horas_orc_feitas = 0;
            //TIRAREI SEPARAÇÃO DE ACAB E DESB
            /*if(label_operacao.Text == "CNC (Desbaste)")
                dataGridView5.Sort(dataGridView5.Columns[9], ListSortDirection.Descending);
            if (label_operacao.Text == "CNC (Acab.)")
                dataGridView5.Sort(dataGridView5.Columns[9], ListSortDirection.Ascending);
            */
            

                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    if (dataGridView5.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        total_horas_semana5 = total_horas_semana5 + Convert.ToDouble(dataGridView5.Rows[i].Cells[4].Value);
                    }
                    if (dataGridView5.Rows[i].Cells[5].Value.ToString() != "0" && dataGridView5.Rows[i].Cells[5].Value.ToString() != "")
                    {
                        total_horas_reais = total_horas_reais + Convert.ToDouble(dataGridView5.Rows[i].Cells[5].Value);
                        total_horas_orc_feitas = total_horas_orc_feitas + Convert.ToDouble(dataGridView5.Rows[i].Cells[4].Value);
                    }
                    //TIREI SEPARAÇÃO DE DESB E ACAB
                    /*
                    try
                    {
                        if (dataGridView5.Rows[i].Cells[9].Value.ToString() != label_operacao.Text)
                        {
                            dataGridView5.Rows[i].Visible = false;
                        }
                    }

                    catch
                    {


                    }
*/

                }

                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    try
                    {


                        if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "FINALIZADO" ||
                            dataGridView5.Rows[i].Cells[6].Value.ToString() == "RETRABALHO")
                        {
                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            try
                            {
                                DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                                string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                                DateTime dia_atual_fim = Convert.ToDateTime(dataGridView5.Rows[i].Cells[3].Value.ToString());
                                string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                                if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                                {
                                    if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                    else
                                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                }
                                else
                                {
                                    if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                    {
                                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "")
                                    {
                                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                    }
                                    if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                    {
                                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                }
                            }
                            catch
                            {
                                if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                else
                                {
                                    if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "")
                                    {
                                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                    }
                                    else
                                    {
                                        if (dataGridView5.Rows[i].Cells[6].Value.ToString() == "PARADA")
                                        {
                                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                        }
                                        else
                                        {
                                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                }

                tb_total_5.Text = total_horas_semana5.ToString("n2");
                tb_orc.Text = total_horas_orc_feitas.ToString("n2");
                tb_reais.Text = total_horas_reais.ToString("n2");
                double saldo;
                try
                {
                    saldo = Convert.ToDouble(tb_total_5.Text) - Convert.ToDouble(tb_orc.Text);
                }
                catch
                {
                    saldo = Convert.ToDouble(tb_total_5.Text);
                }

                tb_saldo.Text = saldo.ToString("n2");
                try
                {
                    if (Convert.ToDouble(tb_total_5.Text) > Convert.ToDouble(label_horas.Text))
                        tb_total_5.ForeColor = Color.Red;
                    else
                        tb_total_5.ForeColor = Color.Green;
                }
                catch
                {
                    tb_total_5.ForeColor = Color.Green;
                }
                //MessageBox.Show(dataGridView5.RowCount.ToString());
            /*
                try
                {
                    
                    if (dataGridView5.Rows[0].Cells[9].Value.ToString() != label_operacao.Text)
                    {
                        semana.Clear();
                        //MessageBox.Show("Nenhuma operação");
                        fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                        "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                        "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                        "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                        "AND (OPERACAO_SEMANA = 'nenhuma') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
                        //DataSet semana = new DataSet();
                        fbConnection1.Open();
                        datSemanas.SelectCommand = fbCommand1;
                        datSemanas.Fill(semana);
                        dataGridView5.DataSource = semana;
                        dataGridView5.DataMember = semana.Tables[0].TableName;
                        fbConnection1.Close();
                    }
                }
                catch { }
            */
            


            
            
        }

        private void semana_6(int semana_atual, string oper_atual, int ano)
        {

            fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, " +
                "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                "OPERACAO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                "AND (OPERACAO_SEMANA = " + oper_atual + ") AND ANO_SEMANA = '" + ano.ToString() +"' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            
                DataSet semana = new DataSet();
                fbConnection1.Open();
                datSemanas.SelectCommand = fbCommand1;
                datSemanas.Fill(semana);
                dataGridView6.DataSource = semana;
                dataGridView6.DataMember = semana.Tables[0].TableName;
                dataGridView6.Columns[0].Width = 50;
                dataGridView6.Columns[0].HeaderText = "OS";
                dataGridView6.Columns[1].Width = 30;
                dataGridView6.Columns[1].HeaderText = "Pos";
                dataGridView6.Columns[2].Width = 50;
                dataGridView6.Columns[2].HeaderText = "Ini";
                dataGridView6.Columns[3].Width = 50;
                dataGridView6.Columns[3].HeaderText = "Fim";
                dataGridView6.Columns[4].Width = 30;
                dataGridView6.Columns[4].HeaderText = "Horas";
                dataGridView6.Columns[5].Width = 40;
                dataGridView6.Columns[5].HeaderText = "Situação";
                dataGridView6.Columns[6].Width = 20;
                dataGridView6.Columns[6].HeaderText = "Cod";
                dataGridView6.Columns[7].Width = 20;
                dataGridView6.Columns[7].HeaderText = "Rota";
                dataGridView6.Columns[8].Width = 20;
                dataGridView6.Columns[8].HeaderText = "Oper";
                fbConnection1.Close();
                double total_horas_semana6 = 0;
                for (int i = 0; i < dataGridView6.RowCount; i++)
                {
                    if (dataGridView6.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        total_horas_semana6 = total_horas_semana6 + Convert.ToDouble(dataGridView6.Rows[i].Cells[4].Value);
                    }
                    /*
                    try
                    {
                        
                        if (dataGridView6.Rows[i].Cells[8].Value.ToString() != label_operacao.Text)
                        {
                            dataGridView6.Rows[i].Visible = false;
                        }
                    }
                    catch
                    {
                        dataGridView6.Sort(dataGridView6.Columns[8], ListSortDirection.Ascending);
                    }*/
                }
                for (int i = 0; i < dataGridView6.RowCount; i++)
                {
                    try
                    {
                        
                        if (dataGridView6.Rows[i].Cells[5].Value.ToString() == "FINALIZADO" ||
                            dataGridView6.Rows[i].Cells[5].Value.ToString() == "RETRABALHO" )
                        {
                            dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            try
                            {
                                DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                                string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                                DateTime dia_atual_fim = Convert.ToDateTime(dataGridView6.Rows[i].Cells[3].Value.ToString());
                                string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                                if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                                {
                                    dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                }
                                else
                                {
                                    if (dataGridView6.Rows[i].Cells[5].Value.ToString() == "EM ANDAMENTO")
                                    {
                                        dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    if (dataGridView6.Rows[i].Cells[5].Value.ToString() == "")
                                    {
                                        dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                    }
                                    if (dataGridView6.Rows[i].Cells[5].Value.ToString() == "PARADA")
                                    {
                                        dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                    }
                                }
                            }
                            catch
                            {
                                dataGridView6.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                            }
                        }
                    }
                    catch { }
                }
                tb_total_6.Text = total_horas_semana6.ToString();
                try
                {
                    if (Convert.ToDouble(tb_total_6.Text) > Convert.ToDouble(label_horas.Text))
                        tb_total_6.ForeColor = Color.Red;
                    else
                        tb_total_6.ForeColor = Color.Green;
                }
                catch
                {
                    tb_total_6.ForeColor = Color.Green;
                }
            /*
                try
                {
                    if (dataGridView6.Rows[0].Cells[8].Value.ToString() != label_operacao.Text)
                    {
                        semana.Clear();
                        //MessageBox.Show("Nenhuma operação");
                        fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                        "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                        "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                        "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                        "AND (OPERACAO_SEMANA = 'nenhuma') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
                        //DataSet semana = new DataSet();
                        fbConnection1.Open();
                        datSemanas.SelectCommand = fbCommand1;
                        datSemanas.Fill(semana);
                        dataGridView6.DataSource = semana;
                        dataGridView6.DataMember = semana.Tables[0].TableName;
                        fbConnection1.Close();
                    }
                }
                catch { }
            */
                
            
        }

        private void semana_7(int semana_atual, string oper_atual, int ano)
        {
            fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, " +
                "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                "OPERACAO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                "AND (OPERACAO_SEMANA = " + oper_atual + ") AND ANO_SEMANA = '" + ano.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet semana = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = fbCommand1;
            datSemanas.Fill(semana);
            dataGridView7.DataSource = semana;
            dataGridView7.DataMember = semana.Tables[0].TableName;
            dataGridView7.Columns[0].Width = 50;
            dataGridView7.Columns[0].HeaderText = "OS";
            dataGridView7.Columns[1].Width = 30;
            dataGridView7.Columns[1].HeaderText = "Pos";
            dataGridView7.Columns[2].Width = 50;
            dataGridView7.Columns[2].HeaderText = "Ini";
            dataGridView7.Columns[3].Width = 50;
            dataGridView7.Columns[3].HeaderText = "Fim";
            dataGridView7.Columns[4].Width = 30;
            dataGridView7.Columns[4].HeaderText = "Horas";
            dataGridView7.Columns[5].Width = 40;
            dataGridView7.Columns[5].HeaderText = "Situação";
            dataGridView7.Columns[6].Width = 20;
            dataGridView7.Columns[6].HeaderText = "Cod";
            dataGridView7.Columns[7].Width = 20;
            dataGridView7.Columns[7].HeaderText = "Rota";
            dataGridView7.Columns[8].Width = 20;
            dataGridView7.Columns[8].HeaderText = "Oper";
            fbConnection1.Close();
            double total_horas_semana7 = 0;
            for (int i = 0; i < dataGridView7.RowCount; i++)
            {
                try
                {
                    if (dataGridView7.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        total_horas_semana7 = total_horas_semana7 + Convert.ToDouble(dataGridView7.Rows[i].Cells[4].Value);
                    }
                    /*
                    if (dataGridView7.Rows[i].Cells[8].Value.ToString() != label_operacao.Text)
                    {
                        dataGridView7.Rows[i].Visible = false;
                    }*/
                }
                catch
                {

                    dataGridView7.Sort(dataGridView7.Columns[8], ListSortDirection.Ascending);
                }
            }
            for (int i = 0; i < dataGridView7.RowCount; i++)
            {
                try
                {
                    
                    if (dataGridView7.Rows[i].Cells[5].Value.ToString() == "FINALIZADO" ||
                        dataGridView7.Rows[i].Cells[5].Value.ToString() == "RETRABALHO" )
                    {
                        dataGridView7.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dataGridView7.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                dataGridView7.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dataGridView7.Rows[i].Cells[5].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dataGridView7.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dataGridView7.Rows[i].Cells[5].Value.ToString() == "")
                                {
                                    dataGridView7.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dataGridView7.Rows[i].Cells[5].Value.ToString() == "PARADA")
                                {
                                    dataGridView7.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            dataGridView7.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                        }
                    }
                }
                catch { }
            }
            tb_total_7.Text = total_horas_semana7.ToString();
            try
            {
                if (Convert.ToDouble(tb_total_7.Text) > Convert.ToDouble(label_horas.Text))
                    tb_total_7.ForeColor = Color.Red;
                else
                    tb_total_7.ForeColor = Color.Green;
            }
            catch
            {
                tb_total_7.ForeColor = Color.Green;
            }
            /*
            try
            {
                if (dataGridView7.Rows[0].Cells[8].Value.ToString() != label_operacao.Text)
                {
                    semana.Clear();
                    //MessageBox.Show("Nenhuma operação");
                    fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                    "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                    "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                    "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                    "AND (OPERACAO_SEMANA = 'nenhuma') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
                    //DataSet semana = new DataSet();
                    fbConnection1.Open();
                    datSemanas.SelectCommand = fbCommand1;
                    datSemanas.Fill(semana);
                    dataGridView7.DataSource = semana;
                    dataGridView7.DataMember = semana.Tables[0].TableName;
                    fbConnection1.Close();
                }
            }
            catch { }
            */
        }

        private void semana_8(int semana_atual, string oper_atual, int ano)
        {
            fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, " +
                "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                "OPERACAO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                "AND (OPERACAO_SEMANA = " + oper_atual + ") AND ANO_SEMANA = '" + ano.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet semana = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = fbCommand1;
            datSemanas.Fill(semana);
            dataGridView8.DataSource = semana;
            dataGridView8.DataMember = semana.Tables[0].TableName;
            dataGridView8.Columns[0].Width = 50;
            dataGridView8.Columns[0].HeaderText = "OS";
            dataGridView8.Columns[1].Width = 30;
            dataGridView8.Columns[1].HeaderText = "Pos";
            dataGridView8.Columns[2].Width = 50;
            dataGridView8.Columns[2].HeaderText = "Ini";
            dataGridView8.Columns[3].Width = 50;
            dataGridView8.Columns[3].HeaderText = "Fim";
            dataGridView8.Columns[4].Width = 30;
            dataGridView8.Columns[4].HeaderText = "Horas";
            dataGridView8.Columns[5].Width = 40;
            dataGridView8.Columns[5].HeaderText = "Situação";
            dataGridView8.Columns[6].Width = 20;
            dataGridView8.Columns[6].HeaderText = "Cod";
            dataGridView8.Columns[7].Width = 20;
            dataGridView8.Columns[7].HeaderText = "Rota";
            dataGridView8.Columns[8].Width = 20;
            dataGridView8.Columns[8].HeaderText = "Oper";
            fbConnection1.Close();
            double total_horas_semana8 = 0;
            for (int i = 0; i < dataGridView8.RowCount; i++)
            {
                try
                {
                    if (dataGridView8.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        total_horas_semana8 = total_horas_semana8 + Convert.ToDouble(dataGridView8.Rows[i].Cells[4].Value);
                    }
                    /*
                    if (dataGridView8.Rows[i].Cells[8].Value.ToString() != label_operacao.Text)
                    {
                        dataGridView8.Rows[i].Visible = false;
                    }*/
                }
                catch
                {
                    dataGridView8.Sort(dataGridView8.Columns[8], ListSortDirection.Ascending);
                }
            }
            for (int i = 0; i < dataGridView8.RowCount; i++)
            {
                try
                {
                    
                    if (dataGridView8.Rows[i].Cells[5].Value.ToString() == "FINALIZADO" ||
                        dataGridView8.Rows[i].Cells[5].Value.ToString() == "RETRABALHO")
                    {
                        dataGridView8.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dataGridView8.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                dataGridView8.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dataGridView8.Rows[i].Cells[5].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dataGridView8.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dataGridView8.Rows[i].Cells[5].Value.ToString() == "")
                                {
                                    dataGridView8.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dataGridView8.Rows[i].Cells[5].Value.ToString() == "PARADA")
                                {
                                    dataGridView8.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            dataGridView8.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                        }
                    }
                }
                catch { }
            }
            tb_total_8.Text = total_horas_semana8.ToString();
            try
            {
                if (Convert.ToDouble(tb_total_8.Text) > Convert.ToDouble(label_horas.Text))
                    tb_total_8.ForeColor = Color.Red;
                else
                    tb_total_8.ForeColor = Color.Green;
            }
            catch
            {
                tb_total_8.ForeColor = Color.Green;
            }
            /*
            try
            {
                if (dataGridView8.Rows[0].Cells[8].Value.ToString() != label_operacao.Text)
                {
                    semana.Clear();
                    //MessageBox.Show("Nenhuma operação");
                    fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                    "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                    "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                    "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                    "AND (OPERACAO_SEMANA = 'nenhuma') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
                    //DataSet semana = new DataSet();
                    fbConnection1.Open();
                    datSemanas.SelectCommand = fbCommand1;
                    datSemanas.Fill(semana);
                    dataGridView8.DataSource = semana;
                    dataGridView8.DataMember = semana.Tables[0].TableName;
                    fbConnection1.Close();
                }
            }
            catch { }
            */
        }

        private void semana_9(int semana_atual, string oper_atual, int ano)
        {
            fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, " +
                "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                "OPERACAO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                "AND (OPERACAO_SEMANA = " + oper_atual + ") AND ANO_SEMANA = '" + ano.ToString() +"' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
            DataSet semana = new DataSet();
            fbConnection1.Open();
            datSemanas.SelectCommand = fbCommand1;
            datSemanas.Fill(semana);
            dataGridView9.DataSource = semana;
            dataGridView9.DataMember = semana.Tables[0].TableName;
            dataGridView9.Columns[0].Width = 50;
            dataGridView9.Columns[0].HeaderText = "OS";
            dataGridView9.Columns[1].Width = 30;
            dataGridView9.Columns[1].HeaderText = "Pos";
            dataGridView9.Columns[2].Width = 50;
            dataGridView9.Columns[2].HeaderText = "Ini";
            dataGridView9.Columns[3].Width = 50;
            dataGridView9.Columns[3].HeaderText = "Fim";
            dataGridView9.Columns[4].Width = 30;
            dataGridView9.Columns[4].HeaderText = "Horas";
            dataGridView9.Columns[5].Width = 40;
            dataGridView9.Columns[5].HeaderText = "Situação";
            dataGridView9.Columns[6].Width = 20;
            dataGridView9.Columns[6].HeaderText = "Cod";
            dataGridView9.Columns[7].Width = 20;
            dataGridView9.Columns[7].HeaderText = "Rota";
            dataGridView9.Columns[8].Width = 20;
            dataGridView9.Columns[8].HeaderText = "Oper";
            fbConnection1.Close();
            double total_horas_semana9 = 0;
            for (int i = 0; i < dataGridView9.RowCount; i++)
            {
                try
                {
                    if (dataGridView9.Rows[i].Cells[4].Value.ToString() != "0")
                    {
                        total_horas_semana9 = total_horas_semana9 + Convert.ToDouble(dataGridView9.Rows[i].Cells[4].Value);
                    }
                    /*
                    if (dataGridView9.Rows[i].Cells[8].Value.ToString() != label_operacao.Text)
                    {
                        dataGridView9.Rows[i].Visible = false;
                    }*/
                }
                catch
                {
                    dataGridView9.Sort(dataGridView9.Columns[8], ListSortDirection.Ascending);
                }
            }
            for (int i = 0; i < dataGridView9.RowCount; i++)
            {
                try
                {
                    
                    if (dataGridView9.Rows[i].Cells[5].Value.ToString() == "FINALIZADO" ||
                        dataGridView9.Rows[i].Cells[5].Value.ToString() == "RETRABALHO" )
                    {
                        dataGridView9.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        try
                        {
                            DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                            string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                            DateTime dia_atual_fim = Convert.ToDateTime(dataGridView9.Rows[i].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                dataGridView9.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if (dataGridView9.Rows[i].Cells[5].Value.ToString() == "EM ANDAMENTO")
                                {
                                    dataGridView9.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                }
                                if (dataGridView9.Rows[i].Cells[5].Value.ToString() == "")
                                {
                                    dataGridView9.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                if (dataGridView9.Rows[i].Cells[5].Value.ToString() == "PARADA")
                                {
                                    dataGridView9.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                                }
                            }
                        }
                        catch
                        {
                            dataGridView9.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                        }
                    }
                }
                catch { }
            }
            tb_total_9.Text = total_horas_semana9.ToString();
            try
            {
                if (Convert.ToDouble(tb_total_9.Text) > Convert.ToDouble(label_horas.Text))
                    tb_total_9.ForeColor = Color.Red;
                else
                    tb_total_9.ForeColor = Color.Green;
            }
            catch
            {
                tb_total_9.ForeColor = Color.Green;
            }
            /*
            try
            {
                if (dataGridView9.Rows[0].Cells[8].Value.ToString() != label_operacao.Text)
                {
                    semana.Clear();
                    //MessageBox.Show("Nenhuma operação");
                    fbCommand1.CommandText = "SELECT OS_SEMANA, POSICAO_OS_SEMANA, " +
                    "DATA_INICIO_SEMANA, DATA_FIM_SEMANA, HORAS_OPERACAO_SEMANA, HORAS_REAIS_OPERACAO, " +
                    "SITUACAO_ROTA_SEMANA, COD_HORAS_SEMANA, ROTA_HORAS_SEMANA," +
                    "OPERACAO_SEMANA, PASSADO_SEMANA FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana_atual.ToString() + "'" +
                    "AND (OPERACAO_SEMANA = 'nenhuma') AND ANO_SEMANA = '" + label_ano.Text + "' AND DATA_EXCLUSAO_SEMANA IS NULL ORDER BY OS_SEMANA";
                    //DataSet semana = new DataSet();
                    fbConnection1.Open();
                    datSemanas.SelectCommand = fbCommand1;
                    datSemanas.Fill(semana);
                    dataGridView9.DataSource = semana;
                    dataGridView9.DataMember = semana.Tables[0].TableName;
                    fbConnection1.Close();
                }
            }
            catch { }
            */
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "Fresa P.M.";
            selecionar_operacao(operacao_atual);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao_atual = "CNC HAAS";
            selecionar_operacao(operacao_atual);
        }

        private void bt_prox_Click(object sender, EventArgs e)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                try
                {
                    if (dataGridView5.SelectedRows[0].Cells[10].Value.ToString() != "1")
                    {
                        string cod = dataGridView5.SelectedRows[0].Cells[7].Value.ToString();
                        string horas_trab = (dataGridView5.SelectedRows[0].Cells[5].Value.ToString());
                        //MessageBox.Show(horas_trab);
                        string horas;
                        try
                        {
                            horas = Convert.ToString((Convert.ToDouble(dataGridView5.SelectedRows[0].Cells[4].Value.ToString()) -
                                        Convert.ToDouble(dataGridView5.SelectedRows[0].Cells[5].Value.ToString())));
                        }
                        catch
                        {
                            horas = dataGridView5.SelectedRows[0].Cells[4].Value.ToString();
                        }
                        string rota = dataGridView5.SelectedRows[0].Cells[8].Value.ToString();
                        /*
                        if (Convert.ToDouble(horas) < 0)
                            horas = "0";
                         * */
                        bool ja_existe = false;
                        //verifica se já existe na próxima semana
                        for (int j = 0; j < dataGridView6.RowCount; j++)
                        {
                            if (rota == dataGridView6.Rows[j].Cells[7].Value.ToString())
                            {
                                ja_existe = true;
                                string cod_novo = dataGridView6.Rows[j].Cells[6].Value.ToString();
                                soma_horas(cod_novo, horas);
                                apaga_original(cod, horas_trab);
                                //excluir(cod, hora_trab);
                            }
                            if (ja_existe == true)
                            {
                                break;
                            }
                        }

                        if (ja_existe == false)
                        {

                            if (tb_semana.Text == "53")
                            {
                                int ano_corrente = Convert.ToInt32(label_ano.Text);

                                if (ano_corrente == 2028)
                                {
                                    semana = "53";
                                    ano_corrente = ano_corrente;
                                }
                                else
                                {
                                    if (ano_corrente != 2012 || ano_corrente != 2017 || ano_corrente != 2023 || ano_corrente != 2034 || ano_corrente != 2040 || ano_corrente != 2045 || ano_corrente != 2051)
                                    {
                                        ano_corrente = ano_corrente + 1;
                                        semana = "1";
                                    }

                                    else
                                    {
                                        ano_corrente = ano_corrente + 1;
                                        semana = "0";

                                    }
                                }
                                ano = ano_corrente.ToString();

                            }
                            else
                            {
                                ano = label_ano.Text;
                                semana = tb_semana.Text;

                            }
                            string rota_2 = dataGridView5.SelectedRows[0].Cells[8].Value.ToString();
                            string os = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
                            string pos = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();
                            string situacao = dataGridView5.SelectedRows[0].Cells[6].Value.ToString();
                            string ent = dataGridView5.SelectedRows[0].Cells[2].Value.ToString();
                            string fim = dataGridView5.SelectedRows[0].Cells[3].Value.ToString();
                            // muda_semana(cod, horas);

                            muda_semana(cod, horas, Convert.ToInt32(semana) + 1, ano, label_operacao.Text,
                                    rota_2, os, pos, situacao, ent, fim, horas_trab);

                            //excluir(cod, hora_trab);


                        }
                    }


                    else
                    {
                        MessageBox.Show("Não é possível passar a OS: " + dataGridView5.SelectedRows[0].Cells[0].Value.ToString() +
                            " POS: " + dataGridView5.SelectedRows[0].Cells[1].Value.ToString() +
                            " pois ela já foi passada uma vez");

                    }
                    //excluir(dataGridView5.SelectedRows[0].Cells[7].Value.ToString());
                    comecar();
                }
                catch
                {
                    MessageBox.Show("Selecione a linha inteira por favor");
                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }
        }

        private void soma_horas(string novo, string horas)
        {
            this.datSemanas.UpdateCommand.CommandText =
                    "UPDATE HORAS_SEMANA SET HORAS_OPERACAO_SEMANA = (HORAS_OPERACAO_SEMANA + (" +  horas.Replace(",",".") + 
                    ")) WHERE COD_HORAS_SEMANA = '" + novo + "'";
            this.fbConnection1.Open();
            this.datSemanas.UpdateCommand.Connection = fbConnection1;
            this.datSemanas.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void apaga_original(string cod, string horas_trab)
        {
            double horas_trabalhadas;
            try { horas_trabalhadas = Convert.ToDouble(horas_trab); }
            catch { horas_trabalhadas = 0; }
            //só apaga se horas_trab = ""
            if (horas_trabalhadas == 0)
            {
                this.datSemanas.UpdateCommand.CommandText =
                "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE COD_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datSemanas.UpdateCommand.CommandText =
                "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'SEMANAS 1' WHERE COD_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                /*
                this.datSemanas.DeleteCommand.CommandText =
                "DELETE FROM HORAS_SEMANA WHERE COD_HORAS_SEMANA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datSemanas.DeleteCommand.Connection = fbConnection1;
                this.datSemanas.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                 * */
            }
            else
            {
                this.datSemanas.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET PASSADO_SEMANA = '1' " +
                        " WHERE COD_HORAS_SEMANA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
        }
        /*
        private void muda_semana(int semana, string ano, string operacao, string rota,
            string horas, string os, string pos, string situacao, string data_ent_prev,
            string data_fec_prev)*/
        private void muda_semana(string cod, string horas, int semana_ano, string ano, string operacao, string rota,
            string os, string pos, string situacao, string data_ent_prev,
            string data_fec_prev, string horas_trab)
        {
            
            
            //inserir em vez de atualizar
            double horas_trabalhadas;
            //MessageBox.Show(horas_trab);
            //horas_trabalhadas = Convert.ToInt32(horas_trab);
            //se já tiverem horas_trabalhadas, vai inserir
            try { horas_trabalhadas = Convert.ToDouble(horas_trab); }
            catch { horas_trabalhadas = 0; }
            if (horas_trabalhadas != 0)
            {
                this.datSemanas.InsertCommand.CommandText =
                            "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA," +
                            "HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, SITUACAO_ROTA_SEMANA, DATA_INICIO_SEMANA, " +
                            "DATA_FIM_SEMANA)" +
                            "VALUES ('" + semana_ano.ToString() + "','" + ano + "','" +
                            operacao + "','" +
                            rota + "','" +
                            horas.Replace(",", ".") + "','" +
                            os + "','" +
                            pos + "','" +
                            situacao + "','" +
                            Convert.ToDateTime(data_ent_prev).ToShortDateString().Replace("/", ".") + "','" +
                            Convert.ToDateTime(data_fec_prev).ToShortDateString().Replace("/", ".") + "')";
                this.fbConnection1.Open();
                this.datSemanas.InsertCommand.Connection = fbConnection1;
                this.datSemanas.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                //MessageBox.Show("chegou aqui");
                this.datSemanas.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET PASSADO_SEMANA = '1'" +
                        " WHERE COD_HORAS_SEMANA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

            }
                //se não tiverem horas trabalhadas, vai atualizar a semana
            else
            {

                this.datSemanas.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET N_SEMANA = " + semana_ano +
                        " WHERE COD_HORAS_SEMANA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datSemanas.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET ANO_SEMANA = " + ano +
                        " WHERE COD_HORAS_SEMANA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

               
                //MessageBox.Show("chegou abaixo");
            }
             
        }
    
        private void muda_semana_ant(string cod)
        {
            this.datSemanas.UpdateCommand.CommandText =
                    "UPDATE HORAS_SEMANA SET N_SEMANA = N_SEMANA - 1 " +
                    " WHERE COD_HORAS_SEMANA = '" + cod + "'";
            this.fbConnection1.Open();
            this.datSemanas.UpdateCommand.Connection = fbConnection1;
            this.datSemanas.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }


        private string contar_dias(DateTime ultimo, DateTime primeiro)
        {
            TimeSpan numero_dias = ultimo.Subtract(primeiro);
            return numero_dias.Days.ToString();
        }

        private void bt_ant_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = dataGridView5.SelectedRows[0].Cells[7].Value.ToString();
                string horas = dataGridView5.SelectedRows[0].Cells[4].Value.ToString();
                string rota = dataGridView5.SelectedRows[0].Cells[8].Value.ToString();
                bool ja_existe = false;
                for (int j = 0; j < dataGridView4.RowCount; j++)
                {
                    if (rota == dataGridView4.Rows[j].Cells[7].Value.ToString())
                    {
                        ja_existe = true;
                        string cod_novo = dataGridView4.Rows[j].Cells[6].Value.ToString();
                        soma_horas(cod_novo, horas);
                       // apaga_original(cod, );
                    }
                    if (ja_existe == true)
                    {
                        break;
                    }
                }
                if (ja_existe == false)
                {
                    muda_semana_ant(cod);
                }
                comecar();
            }
            catch
            {
                MessageBox.Show("Selecione a linha inteira por favor");
            }
        }

        private void tb_atrasados_Click(object sender, EventArgs e)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    try
                    {
                        if (dataGridView5.Rows[i].Cells[10].Value.ToString() != "1")
                        {
                            string horas_trab = dataGridView5.Rows[i].Cells[5].Value.ToString();
                            try
                            {
                                DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                                string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                                DateTime dia_atual_fim = Convert.ToDateTime(dataGridView5.Rows[i].Cells[3].Value.ToString());
                                string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                                if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano) && dataGridView5.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                                {

                                    string cod = dataGridView5.Rows[i].Cells[7].Value.ToString();
                                    string horas;

                                    try
                                    {
                                        horas = Convert.ToString((Convert.ToDouble(dataGridView5.Rows[i].Cells[4].Value.ToString()) -
                                                    Convert.ToDouble(dataGridView5.Rows[i].Cells[5].Value.ToString())));
                                    }
                                    catch
                                    {
                                        horas = dataGridView5.Rows[i].Cells[4].Value.ToString();
                                    }
                                    /*
                                    if (Convert.ToDouble(horas) < 0)
                                        horas = "0";
                                     * */
                                    //string horas = Convert.ToString((Convert.ToDouble(dataGridView5.Rows[i].Cells[4].Value.ToString()) -
                                    //   Convert.ToDouble(dataGridView5.Rows[i].Cells[5].Value.ToString())));
                                    string rota = dataGridView5.Rows[i].Cells[8].Value.ToString();
                                    bool ja_existe = false;
                                    //verifica se já existe na próxima semana
                                    for (int j = 0; j < dataGridView6.RowCount; j++)
                                    {
                                        if (rota == dataGridView6.Rows[j].Cells[7].Value.ToString())
                                        {
                                            ja_existe = true;
                                            string cod_novo = dataGridView6.Rows[j].Cells[6].Value.ToString();
                                            soma_horas(cod_novo, horas);
                                            apaga_original(cod, horas_trab);
                                            //excluir(cod, horas_trab);
                                        }
                                        if (ja_existe == true)
                                        {
                                            break;
                                        }
                                    }
                                    if (ja_existe == false)
                                    {
                                        if (tb_semana.Text == "53")
                                        {
                                            int ano_corrente = Convert.ToInt32(label_ano.Text);
                                            //NAO 2028 TEM 54 SEMANAS
                                            if (ano_corrente == 2028)
                                            {
                                                semana = "53";
                                                ano_corrente = ano_corrente;
                                            }
                                            else
                                            {
                                                if (ano_corrente != 2012 || ano_corrente != 2017 || ano_corrente != 2023 || ano_corrente != 2034 || ano_corrente != 2040 || ano_corrente != 2045 || ano_corrente != 2051)
                                                {
                                                    ano_corrente = ano_corrente + 1;
                                                    semana = "1";
                                                }

                                                else
                                                {
                                                    ano_corrente = ano_corrente + 1;
                                                    semana = "0";

                                                }
                                            }
                                            ano = ano_corrente.ToString();


                                        }
                                        else
                                        {
                                            ano = label_ano.Text;
                                            semana = tb_semana.Text;

                                        }
                                        string rota_2 = dataGridView5.Rows[i].Cells[8].Value.ToString();
                                        string os = dataGridView5.Rows[i].Cells[0].Value.ToString();
                                        string pos = dataGridView5.Rows[i].Cells[1].Value.ToString();
                                        string situacao = dataGridView5.Rows[i].Cells[6].Value.ToString();
                                        string ent = dataGridView5.Rows[i].Cells[2].Value.ToString();
                                        string fim = dataGridView5.Rows[i].Cells[3].Value.ToString();
                                        //muda_semana(cod, horas);
                                        muda_semana(cod, horas, Convert.ToInt32(semana) + 1, ano, label_operacao.Text,
                                    rota_2, os, pos, situacao, ent, fim, horas_trab);
                                        //apaga_original(cod, horas_trab);
                                        //excluir(cod, horas_trab);
                                        //muda_semana(cod, horas);


                                    }
                                }
                                else { }
                            }
                            catch
                            {
                                fbConnection1.Close();
                                //MessageBox.Show("erro na linha" + i.ToString());
                            }
                            horas_trab = "";
                        }

                        else
                        {
                            MessageBox.Show("Não é possível passar a OS: " + dataGridView5.Rows[i].Cells[0].Value.ToString() +
                                " POS: " + dataGridView5.Rows[i].Cells[1].Value.ToString() +
                                " pois ela já foi passada uma vez");

                        }
                    }
                    catch { }
                }
                comecar();
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }
            
            
            
        }

        private void dataGridView5_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            
                abre_rota.rota_atual = dataGridView5.Rows[e.RowIndex].Cells[8].Value;
                abre_rota.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
             if (d.Exists == true)
             {
                 for (int i = 0; i < dataGridView5.RowCount; i++)
                 {
                     try
                     {
                         if (dataGridView5.Rows[i].Cells[10].Value.ToString() != "1")
                         {

                             string horas_trab = (dataGridView5.Rows[i].Cells[5].Value.ToString());
                             DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                             string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);

                             DateTime dia_atual_fim = Convert.ToDateTime(dataGridView5.Rows[i].Cells[3].Value.ToString());
                             string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                             //if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano) && dataGridView5.Rows[i].Cells[6].Value.ToString() != "FINALIZADO")
                             if (dataGridView5.Rows[i].Cells[6].Value.ToString() != "FINALIZADO" &&
                                 dataGridView5.Rows[i].Cells[6].Value.ToString() != "RETRABALHO")
                             {
                                 //MessageBox.Show("chegou aqui");
                                 string cod = dataGridView5.Rows[i].Cells[7].Value.ToString();

                                 string horas;
                                 try
                                 {
                                     horas = Convert.ToString((Convert.ToDouble(dataGridView5.Rows[i].Cells[4].Value.ToString()) -
                                                 Convert.ToDouble(dataGridView5.Rows[i].Cells[5].Value.ToString())));
                                 }
                                 catch
                                 {
                                     horas = dataGridView5.Rows[i].Cells[4].Value.ToString();
                                 }
                                 /*
                                 if (Convert.ToDouble(horas) < 0)
                                     horas = "0";
                                 */
                                 //string horas = Convert.ToString((Convert.ToDouble(dataGridView5.Rows[i].Cells[4].Value.ToString()) -
                                 //      Convert.ToDouble(dataGridView5.Rows[i].Cells[5].Value.ToString())));
                                 string rota = dataGridView5.Rows[i].Cells[8].Value.ToString();
                                 bool ja_existe = false;
                                 //verifica se já existe na próxima semana
                                 for (int j = 0; j < dataGridView6.RowCount; j++)
                                 {
                                     if (rota == dataGridView6.Rows[j].Cells[7].Value.ToString())
                                     {
                                         ja_existe = true;
                                         string cod_novo = dataGridView6.Rows[j].Cells[6].Value.ToString();
                                         soma_horas(cod_novo, horas);
                                         apaga_original(cod, horas_trab);
                                         //excluir(cod, horas_trab);
                                     }
                                     if (ja_existe == true)
                                     {
                                         break;
                                     }
                                 }
                                 if (ja_existe == false)
                                 {
                                     
                                     if (tb_semana.Text == "53")
                                     {
                                         //COLOCA 1 PARA PODER SOMAR 1 + 1 E DAR 2 NA PRÓXIMA SEMANA
                                         int ano_corrente = Convert.ToInt32(label_ano.Text);
                                         
                                         if(ano_corrente == 2028)
                                         {
                                             semana = "53";
                                             ano_corrente = ano_corrente;
                                         }
                                         else
                                         {
                                             if (ano_corrente != 2012 || ano_corrente != 2017 || ano_corrente != 2023 || ano_corrente != 2034 || ano_corrente != 2040 || ano_corrente != 2045 || ano_corrente != 2051)
                                             {
                                                 ano_corrente = ano_corrente + 1;
                                                 semana = "1";
                                             }

                                             else
                                             {
                                                 ano_corrente = ano_corrente + 1;
                                                 semana = "0";

                                             }
                                         }
                                         ano = ano_corrente.ToString();

                                     

                                     }
                                     else
                                     {
                                         ano = label_ano.Text;
                                         semana = tb_semana.Text;

                                     }
                                     string rota_2 = dataGridView5.Rows[i].Cells[8].Value.ToString();
                                     string os = dataGridView5.Rows[i].Cells[0].Value.ToString();
                                     string pos = dataGridView5.Rows[i].Cells[1].Value.ToString();
                                     string situacao = dataGridView5.Rows[i].Cells[6].Value.ToString();
                                     string ent = dataGridView5.Rows[i].Cells[2].Value.ToString();
                                     string fim = dataGridView5.Rows[i].Cells[3].Value.ToString();
                                     //muda_semana(Convert.ToInt32(semana) + 1, ano, label_operacao.Text,
                                     //  rota_2, horas, os, pos, situacao, ent, fim);
                                     muda_semana(cod, horas, Convert.ToInt32(semana) + 1, ano, label_operacao.Text,
                                          rota_2, os, pos, situacao, ent, fim, horas_trab);
                                     //apaga_original(cod, horas_trab);
                                     // muda_semana(cod, horas);
                                     // excluir(cod, horas_trab);
                                 }

                             }

                             else { }
                             horas_trab = "";
                         }

                         else
                         {
                             MessageBox.Show("Não é possível passar a OS: " + dataGridView5.Rows[i].Cells[0].Value.ToString() +
                                 " POS: " + dataGridView5.Rows[i].Cells[1].Value.ToString() +
                                 " pois ela já foi passada uma vez");

                         }
                     }
                     catch { }
                 }
                 comecar();
             }
             else
             {
                 MessageBox.Show("Você não tem acesso a esse recurso");
             }
            
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            insere_semana5();
            insere_semana6();
            insere_semana7();
           // insere_semana8();
            this.datSemanas.SelectCommand.CommandText =
            "SELECT * FROM HORAS_SEMANA WHERE COD_HORAS_SEMANA = '" + dataGridView5.Rows[0].Cells[7].Value.ToString() + "'";// ORDER BY COD_SEM_05";
            this.fbConnection1.Open();
            this.datSemanas.SelectCommand.Connection = fbConnection1;
            this.datSemanas.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            dsSemanas semanas = new dsSemanas();
            fbConnection1.Open();
            datImp_semana5.Fill(semanas.IMP_SEMANA5);
            datImp_semana6.Fill(semanas.IMP_SEMANA6);
            datImp_semana7.Fill(semanas.IMP_SEMANA7);
            datImp_semana8.Fill(semanas.IMP_SEMANA8);
            datN_semana5.Fill(semanas.N_SEMANA5);
            datN_semana6.Fill(semanas.N_SEMANA6);
            datN_semana7.Fill(semanas.N_SEMANA7);
            datN_semana8.Fill(semanas.N_SEMANA8);
            datSemanas.Fill(semanas.HORAS_SEMANA);
            fbConnection1.Close();
            crSemanas relatorio = new crSemanas();
            relatorio.SetDataSource(semanas);
            form_imprimir imprimir = new form_imprimir(relatorio);
            imprimir.Show();
        }
        private void insere_semana5()
        {
            //apaga registros anteriores
            this.datImp_semana5.DeleteCommand.CommandText =
                "DELETE FROM IMP_SEMANA5";
            this.fbConnection1.Open();
            this.datImp_semana5.DeleteCommand.Connection = fbConnection1;
            this.datImp_semana5.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            for (int n = 0; n < dataGridView5.RowCount; n++)
            {
                //escolhe a posicao atual
                if (dataGridView5.Rows[n].Cells[6].Value.ToString() == "FINALIZADO")
                {
                    //MessageBox.Show("CHEGOU AQUI");
                    pos_atual = "1";
                }
                else
                {
                    //try
                    //{
                        DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                        string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                        try
                        {
                            DateTime dia_atual_fim = Convert.ToDateTime(dataGridView5.Rows[n].Cells[3].Value.ToString());
                            string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                            if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                            {
                                pos_atual = "4";
                            }
                            else
                            {
                                if (dataGridView5.Rows[n].Cells[6].Value.ToString() == "EM ANDAMENTO")
                                {
                                    pos_atual = "3";
                                }
                                if (dataGridView5.Rows[n].Cells[6].Value.ToString() == "")
                                {
                                    pos_atual = "0";
                                }
                                if (dataGridView5.Rows[n].Cells[6].Value.ToString() == "PARADA")
                                {
                                    pos_atual = "2";
                                }
                            }
                        }
                        catch
                        {
                            if (dataGridView5.Rows[n].Cells[6].Value.ToString() == "EM ANDAMENTO")
                            {
                                pos_atual = "3";
                            }
                            if (dataGridView5.Rows[n].Cells[6].Value.ToString() == "")
                            {
                                pos_atual = "0";
                            }
                            if (dataGridView5.Rows[n].Cells[6].Value.ToString() == "PARADA")
                            {
                                pos_atual = "2";
                            }
                        }
                }
                    if (dataGridView5.Rows[n].Cells[4].Value.ToString() == "")
                        dataGridView5.Rows[n].Cells[4].Value = "0";
                    if (dataGridView5.Rows[n].Cells[5].Value.ToString() == "")
                        dataGridView5.Rows[n].Cells[5].Value = "0";
                //insere os novos dados
                    inicio = "";
                    fim = "";
                    try
                    {
                        inicio = Convert.ToDateTime(dataGridView5.Rows[n].Cells[2].Value).ToShortDateString().Replace("/", ".");
                    }
                    catch { 
                        if(pos_atual == "0")
                            inicio = "01.01.2000";
                        if (pos_atual == "1")
                            inicio = "01.01.2001";
                        if (pos_atual == "3")
                            inicio = "01.01.2002";
                        if (pos_atual == "2")
                            inicio = "01.01.2003";
                        if (pos_atual == "4")
                            inicio = "01.01.2004"; 
                    
                    }
                    try
                    {
                        fim = Convert.ToDateTime(dataGridView5.Rows[n].Cells[3].Value).ToShortDateString().Replace("/", ".");
                    }
                    catch {
                        if (pos_atual == "0")
                            fim = "01.01.2000";
                        if (pos_atual == "1")
                            fim = "01.01.2001";
                        if (pos_atual == "3")
                            fim = "01.01.2002";
                        if (pos_atual == "2")
                            fim = "01.01.2003";
                        if (pos_atual == "4")
                            fim = "01.01.2004"; 
                    }
                    try
                    {
                        this.datImp_semana5.InsertCommand.CommandText =
                        "INSERT INTO IMP_SEMANA5 (OS_SEM_05, POS_SEM_05, DATA_INICIO_SEM_05, " +
                        "DATA_FIM_SEM_05, HORAS_PREV_SEM_05, HORAS_TRAB_SEM_05, POS_ATUAL_SEM_05)" +
                        "VALUES ('" + dataGridView5.Rows[n].Cells[0].Value.ToString() + "','" +
                        dataGridView5.Rows[n].Cells[1].Value.ToString() + "','" +
                        inicio + "','" +
                        fim + "','" +
                        dataGridView5.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                        dataGridView5.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                        pos_atual + "')";
                        this.fbConnection1.Open();
                        this.datImp_semana5.InsertCommand.Connection = fbConnection1;
                        this.datImp_semana5.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                        this.datImp_semana5.InsertCommand.CommandText =
                        "INSERT INTO IMP_SEMANA5 (OS_SEM_05, POS_SEM_05, HORAS_PREV_SEM_05, HORAS_TRAB_SEM_05, POS_ATUAL_SEM_05)" +
                        "VALUES ('" + dataGridView5.Rows[n].Cells[0].Value.ToString() + "','" +
                        dataGridView5.Rows[n].Cells[1].Value.ToString() + "','" +
                        dataGridView5.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                        dataGridView5.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                        pos_atual + "')";
                        this.fbConnection1.Open();
                        this.datImp_semana5.InsertCommand.Connection = fbConnection1;
                        this.datImp_semana5.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                    }
                }
            

            //seleciona os registros inseridos
            this.datImp_semana5.SelectCommand.CommandText =
            "SELECT * FROM IMP_SEMANA5";// ORDER BY COD_SEM_05";
            this.fbConnection1.Open();
            this.datImp_semana5.SelectCommand.Connection = fbConnection1;
            this.datImp_semana5.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //acerta a semana corrente
            this.datN_semana5.UpdateCommand.CommandText =
            "UPDATE N_SEMANA5 SET NUMERO_SEMANA5 = " + tb_semana.Text + "";
            this.fbConnection1.Open();
            this.datN_semana5.UpdateCommand.Connection = fbConnection1;
            this.datN_semana5.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datN_semana5.UpdateCommand.CommandText =
            "UPDATE N_SEMANA5 SET SALDO_HORAS_SEMANA5 = " + tb_saldo.Text.Replace(",",".") + "";
            this.fbConnection1.Open();
            this.datN_semana5.UpdateCommand.Connection = fbConnection1;
            this.datN_semana5.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datN_semana5.UpdateCommand.CommandText =
            "UPDATE N_SEMANA5 SET HORAS_ORCADAS_SEMANA5 = " + tb_orc.Text.Replace(",",".") + "";
            this.fbConnection1.Open();
            this.datN_semana5.UpdateCommand.Connection = fbConnection1;
            this.datN_semana5.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();


            //seleciona a semana corrente
            this.datN_semana5.SelectCommand.CommandText =
            "SELECT * FROM N_SEMANA5";
            this.fbConnection1.Open();
            this.datN_semana5.SelectCommand.Connection = fbConnection1;
            this.datN_semana5.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void insere_semana6()
        {
            this.datImp_semana6.DeleteCommand.CommandText =
                "DELETE FROM IMP_SEMANA6";
            this.fbConnection1.Open();
            this.datImp_semana6.DeleteCommand.Connection = fbConnection1;
            this.datImp_semana6.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            for (int n = 0; n < dataGridView6.RowCount; n++)
            {
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "FINALIZADO")
                {
                    pos_atual = "1";
                }
                else
                {
                    try
                    {
                        DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                        string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                        DateTime dia_atual_fim = Convert.ToDateTime(dataGridView6.Rows[n].Cells[3].Value.ToString());
                        string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                        if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                        {
                            pos_atual = "4";
                        }
                        else
                        {
                            if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "EM ANDAMENTO")
                            {
                                pos_atual = "3";
                            }
                            if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "")
                            {
                                pos_atual = "0";
                            }
                            if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "PARADA")
                            {
                                pos_atual = "2";
                            }
                        }
                    }
                    catch
                    {
                        
                    }
                }
                    /*
                    //MessageBox.Show(n.ToString());
                    if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "FINALIZADO")
                        pos_atual = "1";
                    if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "EM ANDAMENTO")
                        pos_atual = "2";
                    if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "PARADA")
                        pos_atual = "3";
                    if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "")
                        pos_atual = "4";*/
                    if (dataGridView6.Rows[n].Cells[4].Value.ToString() == "")
                        dataGridView6.Rows[n].Cells[4].Value = "0";
                    //if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "")
                    //  dataGridView6.Rows[n].Cells[5].Value = "0";
                    //MessageBox.Show(transforma_virgula(dgvConsulta.Rows[n].Cells["col_saldo_horas"].Value.ToString()));
                    inicio = "";
                    fim = "";
                    try
                    {
                        inicio = Convert.ToDateTime(dataGridView6.Rows[n].Cells[2].Value).ToShortDateString().Replace("/", ".");
                    }
                    catch {
                        if (pos_atual == "0")
                            inicio = "01.01.2000";
                        if (pos_atual == "1")
                            inicio = "01.01.2001";
                        if (pos_atual == "3")
                            inicio = "01.01.2002";
                        if (pos_atual == "2")
                            inicio = "01.01.2003";
                        if (pos_atual == "4")
                            inicio = "01.01.2004"; 
                    }
                    try
                    {
                        fim = Convert.ToDateTime(dataGridView6.Rows[n].Cells[3].Value).ToShortDateString().Replace("/", ".");
                    }
                    catch {
                        if (pos_atual == "0")
                            fim = "01.01.2000";
                        if (pos_atual == "1")
                            fim = "01.01.2001";
                        if (pos_atual == "3")
                            fim = "01.01.2002";
                        if (pos_atual == "2")
                            fim = "01.01.2003";
                        if (pos_atual == "4")
                            fim = "01.01.2004"; 
                    }
                    try
                    {
                        this.datImp_semana6.InsertCommand.CommandText =
                            "INSERT INTO IMP_SEMANA6 (OS_SEM_06, POS_SEM_06, DATA_INICIO_SEM_06, " +
                            "DATA_FIM_SEM_06, HORAS_PREV_SEM_06, " +
                            //"HORAS_TRAB_SEM_06,
                            "POS_ATUAL_SEM_06)" +
                            "VALUES ('" + dataGridView6.Rows[n].Cells[0].Value.ToString() + "','" +
                            dataGridView6.Rows[n].Cells[1].Value.ToString() + "','" +
                            inicio + "','" +
                            fim + "','" +
                            dataGridView6.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                            //dataGridView6.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                            pos_atual + "')";
                        this.fbConnection1.Open();
                        this.datImp_semana6.InsertCommand.Connection = fbConnection1;
                        this.datImp_semana6.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }

                    catch
                    {
                        fbConnection1.Close();
                        this.datImp_semana6.InsertCommand.CommandText =
                            "INSERT INTO IMP_SEMANA6 (OS_SEM_06, POS_SEM_06,  HORAS_PREV_SEM_06, " +
                            //"HORAS_TRAB_SEM_06,
                            "POS_ATUAL_SEM_06)" +
                            "VALUES ('" + dataGridView6.Rows[n].Cells[0].Value.ToString() + "','" +
                            dataGridView6.Rows[n].Cells[1].Value.ToString() + "','" +
                            dataGridView6.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                            //dataGridView6.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                            pos_atual + "')";
                        this.fbConnection1.Open();
                        this.datImp_semana6.InsertCommand.Connection = fbConnection1;
                        this.datImp_semana6.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                }
            


            this.datImp_semana6.SelectCommand.CommandText =
            "SELECT * FROM IMP_SEMANA6 ORDER BY COD_SEM_06";
            this.fbConnection1.Open();
            this.datImp_semana6.SelectCommand.Connection = fbConnection1;
            this.datImp_semana6.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            n_semana = Convert.ToInt32(tb_semana.Text) + 1;
            if (n_semana > 53)
            {
                n_semana = 2;
                mudou = true;
               
            }
            this.datN_semana6.UpdateCommand.CommandText =
            "UPDATE N_SEMANA6 SET NUMERO_SEMANA6 = " + n_semana.ToString() +"";
            this.fbConnection1.Open();
            this.datN_semana6.UpdateCommand.Connection = fbConnection1;
            this.datN_semana6.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datN_semana6.SelectCommand.CommandText =
            "SELECT * FROM N_SEMANA6";
            this.fbConnection1.Open();
            this.datN_semana6.SelectCommand.Connection = fbConnection1;
            this.datN_semana6.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
       }

        private void insere_semana7()
        {
            this.datImp_semana7.DeleteCommand.CommandText =
                "DELETE FROM IMP_SEMANA7";
            this.fbConnection1.Open();
            this.datImp_semana7.DeleteCommand.Connection = fbConnection1;
            this.datImp_semana7.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            for (int n = 0; n < dataGridView7.RowCount; n++)
            {
                if (dataGridView7.Rows[n].Cells[5].Value.ToString() == "FINALIZADO")
                {
                    pos_atual = "1";
                }
                else
                {
                    try
                    {
                        DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                        string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                        DateTime dia_atual_fim = Convert.ToDateTime(dataGridView7.Rows[n].Cells[3].Value.ToString());
                        string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                        if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                        {
                            pos_atual = "4";
                        }
                        else
                        {
                            if (dataGridView7.Rows[n].Cells[5].Value.ToString() == "EM ANDAMENTO")
                            {
                                pos_atual = "3";
                            }
                            if (dataGridView7.Rows[n].Cells[5].Value.ToString() == "")
                            {
                                pos_atual = "0";
                            }
                            if (dataGridView7.Rows[n].Cells[5].Value.ToString() == "PARADA")
                            {
                                pos_atual = "2";
                            }
                        }
                    }
                    catch
                    {

                    }
                }
                /*
                //MessageBox.Show(n.ToString());
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "FINALIZADO")
                    pos_atual = "1";
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "EM ANDAMENTO")
                    pos_atual = "2";
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "PARADA")
                    pos_atual = "3";
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "")
                    pos_atual = "4";*/
                if (dataGridView7.Rows[n].Cells[4].Value.ToString() == "")
                    dataGridView7.Rows[n].Cells[4].Value = "0";
                //if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "")
                //  dataGridView6.Rows[n].Cells[5].Value = "0";
                //MessageBox.Show(transforma_virgula(dgvConsulta.Rows[n].Cells["col_saldo_horas"].Value.ToString()));
                inicio = "";
                fim = "";
                try
                {
                    inicio = Convert.ToDateTime(dataGridView7.Rows[n].Cells[2].Value).ToShortDateString().Replace("/", ".");
                }
                catch {
                    if (pos_atual == "0")
                        inicio = "01.01.2000";
                    if (pos_atual == "1")
                        inicio = "01.01.2001";
                    if (pos_atual == "3")
                        inicio = "01.01.2002";
                    if (pos_atual == "2")
                        inicio = "01.01.2003";
                    if (pos_atual == "4")
                        inicio = "01.01.2004"; 
                }
                try
                {
                    fim = Convert.ToDateTime(dataGridView7.Rows[n].Cells[3].Value).ToShortDateString().Replace("/", ".");
                }
                catch
                {
                    if (pos_atual == "0")
                        fim = "01.01.2000";
                    if (pos_atual == "1")
                        fim = "01.01.2001";
                    if (pos_atual == "3")
                        fim = "01.01.2002";
                    if (pos_atual == "2")
                        fim = "01.01.2003";
                    if (pos_atual == "4")
                        fim = "01.01.2004";
                }
                try
                {
                    this.datImp_semana7.InsertCommand.CommandText =
                    "INSERT INTO IMP_SEMANA7 (OS_SEM_07, POS_SEM_07, DATA_INICIO_SEM_07, " +
                    "DATA_FIM_SEM_07, HORAS_PREV_SEM_07, " +
                        //"HORAS_TRAB_SEM_07,
                    "POS_ATUAL_SEM_07)" +
                    "VALUES ('" + dataGridView7.Rows[n].Cells[0].Value.ToString() + "','" +
                    dataGridView7.Rows[n].Cells[1].Value.ToString() + "','" +
                    inicio + "','" +
                    fim + "','" +
                    dataGridView7.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                        //dataGridView6.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                    pos_atual + "')";
                    this.fbConnection1.Open();
                    this.datImp_semana7.InsertCommand.Connection = fbConnection1;
                    this.datImp_semana7.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                    this.datImp_semana7.InsertCommand.CommandText =
                    "INSERT INTO IMP_SEMANA7 (OS_SEM_07, POS_SEM_07, HORAS_PREV_SEM_07, " +
                        //"HORAS_TRAB_SEM_07,
                    "POS_ATUAL_SEM_07)" +
                    "VALUES ('" + dataGridView7.Rows[n].Cells[0].Value.ToString() + "','" +
                    dataGridView7.Rows[n].Cells[1].Value.ToString() + "','" +
                    dataGridView7.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                        //dataGridView6.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                    pos_atual + "')";
                    this.fbConnection1.Open();
                    this.datImp_semana7.InsertCommand.Connection = fbConnection1;
                    this.datImp_semana7.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
            }



            this.datImp_semana7.SelectCommand.CommandText =
            "SELECT * FROM IMP_SEMANA7 ORDER BY COD_SEM_07";
            this.fbConnection1.Open();
            this.datImp_semana7.SelectCommand.Connection = fbConnection1;
            this.datImp_semana7.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            n_semana++;
            if (n_semana > 53 && mudou == false)
            {
                n_semana = 2;
                mudou = true;

            }
            this.datN_semana7.UpdateCommand.CommandText =
            "UPDATE N_SEMANA7 SET NUMERO_SEMANA7 = " + n_semana.ToString() + "";
            this.fbConnection1.Open();
            this.datN_semana7.UpdateCommand.Connection = fbConnection1;
            this.datN_semana7.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datN_semana7.SelectCommand.CommandText =
            "SELECT * FROM N_SEMANA7";
            this.fbConnection1.Open();
            this.datN_semana7.SelectCommand.Connection = fbConnection1;
            this.datN_semana7.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void insere_semana8()
        {
            this.datImp_semana8.DeleteCommand.CommandText =
                "DELETE FROM IMP_SEMANA8";
            this.fbConnection1.Open();
            this.datImp_semana8.DeleteCommand.Connection = fbConnection1;
            this.datImp_semana8.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            for (int n = 0; n < dataGridView8.RowCount; n++)
            {
                if (dataGridView8.Rows[n].Cells[5].Value.ToString() == "FINALIZADO")
                {
                    pos_atual = "1";
                }
                else
                {
                    try
                    {
                        DateTime primeiro_dia = new DateTime(DateTime.Now.Year, 1, 1);
                        string dia_ano = contar_dias(Convert.ToDateTime(DateTime.Now.ToShortDateString()), primeiro_dia);
                        DateTime dia_atual_fim = Convert.ToDateTime(dataGridView8.Rows[n].Cells[3].Value.ToString());
                        string dia_ano_fim = contar_dias(dia_atual_fim, primeiro_dia);
                        if (Convert.ToDouble(dia_ano_fim) < Convert.ToDouble(dia_ano))
                        {
                            pos_atual = "4";
                        }
                        else
                        {
                            if (dataGridView8.Rows[n].Cells[5].Value.ToString() == "EM ANDAMENTO")
                            {
                                pos_atual = "3";
                            }
                            if (dataGridView8.Rows[n].Cells[5].Value.ToString() == "")
                            {
                                pos_atual = "0";
                            }
                            if (dataGridView8.Rows[n].Cells[5].Value.ToString() == "PARADA")
                            {
                                pos_atual = "2";
                            }
                        }
                    }
                    catch
                    {

                    }
                }
                /*
                //MessageBox.Show(n.ToString());
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "FINALIZADO")
                    pos_atual = "1";
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "EM ANDAMENTO")
                    pos_atual = "2";
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "PARADA")
                    pos_atual = "3";
                if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "")
                    pos_atual = "4";*/
                if (dataGridView8.Rows[n].Cells[4].Value.ToString() == "")
                    dataGridView8.Rows[n].Cells[4].Value = "0";
                //if (dataGridView6.Rows[n].Cells[5].Value.ToString() == "")
                //  dataGridView6.Rows[n].Cells[5].Value = "0";
                //MessageBox.Show(transforma_virgula(dgvConsulta.Rows[n].Cells["col_saldo_horas"].Value.ToString()));
                string inicio;
                string fim;
                try
                {
                    inicio = Convert.ToDateTime(dataGridView8.Rows[n].Cells[2].Value).ToShortDateString().Replace("/", ".");
                }
                catch { inicio = ""; }
                try
                {
                    fim = Convert.ToDateTime(dataGridView8.Rows[n].Cells[3].Value).ToShortDateString().Replace("/", ".");
                }
                catch { fim = ""; }
                try
                {
                    this.datImp_semana8.InsertCommand.CommandText =
                    "INSERT INTO IMP_SEMANA8 (OS_SEM_08, POS_SEM_08, DATA_INICIO_SEM_08, " +
                    "DATA_FIM_SEM_08, HORAS_PREV_SEM_08, " +
                        //"HORAS_TRAB_SEM_08,
                    "POS_ATUAL_SEM_08)" +
                    "VALUES ('" + dataGridView8.Rows[n].Cells[0].Value.ToString() + "','" +
                    dataGridView8.Rows[n].Cells[1].Value.ToString() + "','" +
                    inicio + "','" +
                    fim + "','" +
                    dataGridView8.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                        //dataGridView6.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                    pos_atual + "')";
                    this.fbConnection1.Open();
                    this.datImp_semana8.InsertCommand.Connection = fbConnection1;
                    this.datImp_semana8.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    this.fbConnection1.Close();
                    this.datImp_semana8.InsertCommand.CommandText =
                    "INSERT INTO IMP_SEMANA8 (OS_SEM_08, POS_SEM_08, HORAS_PREV_SEM_08, " +
                        //"HORAS_TRAB_SEM_08,
                    "POS_ATUAL_SEM_08)" +
                    "VALUES ('" + dataGridView8.Rows[n].Cells[0].Value.ToString() + "','" +
                    dataGridView8.Rows[n].Cells[1].Value.ToString() + "','" +
                    dataGridView8.Rows[n].Cells[4].Value.ToString().Replace(",", ".") + "','" +
                        //dataGridView6.Rows[n].Cells[5].Value.ToString().Replace(",", ".") + "','" +
                    pos_atual + "')";
                    this.fbConnection1.Open();
                    this.datImp_semana8.InsertCommand.Connection = fbConnection1;
                    this.datImp_semana8.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                }
            }



            this.datImp_semana8.SelectCommand.CommandText =
            "SELECT * FROM IMP_SEMANA8 ORDER BY COD_SEM_08";
            this.fbConnection1.Open();
            this.datImp_semana8.SelectCommand.Connection = fbConnection1;
            this.datImp_semana8.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            n_semana++;
            if (n_semana > 53 && mudou == false)
            {
                n_semana = 2;
                mudou = true;

            }

            this.datN_semana8.UpdateCommand.CommandText =
            "UPDATE N_SEMANA8 SET NUMERO_SEMANA8 = " + n_semana.ToString() + "";
            this.fbConnection1.Open();
            this.datN_semana8.UpdateCommand.Connection = fbConnection1;
            this.datN_semana8.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datN_semana8.SelectCommand.CommandText =
            "SELECT * FROM N_SEMANA8";
            this.fbConnection1.Open();
            this.datN_semana8.SelectCommand.Connection = fbConnection1;
            this.datN_semana8.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }
        private void impressao_semana_5()
        {
            
        }

        private void impressao_semana_6()
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            excluir(dataGridView5.SelectedRows[0].Cells[7].Value.ToString(), "0");
        }
        private void excluir(string cod, string horas_trab)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                    "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        this.datSemanas.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE COD_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                        this.fbConnection1.Open();
                        this.datSemanas.UpdateCommand.Connection = fbConnection1;
                        this.datSemanas.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datSemanas.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'SEMANA 2' WHERE COD_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                        this.fbConnection1.Open();
                        this.datSemanas.UpdateCommand.Connection = fbConnection1;
                        this.datSemanas.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        /*
                        this.datSemanas.DeleteCommand.CommandText =
                        "DELETE FROM HORAS_SEMANA WHERE COD_HORAS_SEMANA = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datSemanas.DeleteCommand.Connection = fbConnection1;
                        this.datSemanas.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                         * */
                        comecar();

                    }
                    catch
                    {
                        MessageBox.Show("Selecione a linha inteira por favor");
                        fbConnection1.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }
        }

        private void tb_total_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_saldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirDesenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@cod_rota_desenho);
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

        private void dataGridView5_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            cod_rota_desenho = "x://" + dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString() + "-(" + detectar_cliente(dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString()) + ")//projeto//OS " + dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString() + "-" + dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString() + ".dwg";
        }

    }
}