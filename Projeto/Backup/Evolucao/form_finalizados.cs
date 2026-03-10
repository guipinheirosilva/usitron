using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_finalizados : Form
    {
        int numero_semanas;
        int semana_ano;
        int ult_semana_ano;
        public form_finalizados()
        {
            InitializeComponent();
        }

        private void form_finalizados_Load(object sender, EventArgs e)
        {
            datRotas_campo.Fill(ROTAS_CAMPO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            //try
            //{

                for (int i = 0; i < dgvRotas_campo.RowCount; i++)
                {
                    try
                    {
                        if (dgvRotas_campo.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "FINALIZADO")
                        {
                            this.datHoras_semana.UpdateCommand.CommandText =
                            "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = 'FINALIZADO'  " +
                            " WHERE ROTA_HORAS_SEMANA = '" + dgvRotas_campo.Rows[i].Cells[0].Value.ToString() + "'";
                            this.fbConnection1.Open();
                            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();
                        }
                        if (dgvRotas_campo.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                        {
                            this.datHoras_semana.UpdateCommand.CommandText =
                            "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = 'EM ANDAMENTO'  " +
                            " WHERE ROTA_HORAS_SEMANA = '" + dgvRotas_campo.Rows[i].Cells[0].Value.ToString() + "'";
                            this.fbConnection1.Open();
                            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();
                        }
                        if (dgvRotas_campo.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "PARADA")
                        {
                            this.datHoras_semana.UpdateCommand.CommandText =
                            "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = 'PARADA'  " +
                            " WHERE ROTA_HORAS_SEMANA = '" + dgvRotas_campo.Rows[i].Cells[0].Value.ToString() + "'";
                            this.fbConnection1.Open();
                            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();
                        }

                    }
                    catch 
                    {
                        //MessageBox.Show("Erro na rota ");
                    }
                }
           // }
           // catch { }
            this.Cursor = Cursors.Default;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvRotas_campo.RowCount.ToString());
            this.Cursor = Cursors.WaitCursor;
            int i;
            for (i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                    int numero_dias;
                    try
                    {
                        numero_dias = contar_dias(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_entrada"].Value),
                            Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_fecha"].Value));
                    }
                    catch
                    {
                        numero_dias = 0;
                    }
                    //MessageBox.Show("numero de dias " + numero_dias.ToString());
                    int ano_atual;
                    try
                    {
                         ano_atual = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_entrada"].Value).Year;
                    }
                    catch
                    {
                        ano_atual = DateTime.Now.Year;
                    }
                    
                /*
                    if (numero_dias % 7 == 0)
                        numero_semanas = numero_dias / 7;
                    else
                        numero_semanas = (numero_dias / 7) + 1;
                 */
                    try
                    {
                        semana_ano = 1 + conferir_semana(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_entrada"].Value)) / 7;
                        ult_semana_ano = 1 + conferir_semana(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_fecha"].Value)) / 7;
                        numero_semanas = (ult_semana_ano - semana_ano) + 1; 
                    }
                    catch
                    {
                        numero_semanas = 0;
                    }
                    //numero_semanas = (ult_semana_ano - semana_ano) + 1;
                    //MessageBox.Show("numero de semanas " + numero_semanas.ToString());
                    double horas_semana;
                    try
                    {
                        horas_semana = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value) / numero_semanas;
                    }
                    catch
                    {
                        horas_semana = 0;
                    }
                    //MessageBox.Show("horas por semana " + horas_semana.ToString());
                    //int semana_ano;
                    
                    //MessageBox.Show("semana no ano " + semana_ano.ToString());
                    string operacao_semana;
                    try
                    {
                        operacao_semana = dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString();
                    }
                    catch
                    {
                        operacao_semana = "erro";
                    }
                    int rota_semana;
                    try
                    {
                        rota_semana = Convert.ToInt32(dgvRotas_campo.Rows[i].Cells["col_cod"].Value);
                    }
                    catch
                    {
                        rota_semana = 0;
                    }
                    string os;
                    try
                    {
                        os = dgvRotas_campo.Rows[i].Cells["col_os"].Value.ToString();
                    }
                    catch
                    {
                        os = "erro";
                    }
                    string pos;
                    try
                    {
                        pos = dgvRotas_campo.Rows[i].Cells["col_pos"].Value.ToString();
                    }
                    catch
                    {
                        pos = "erro";
                    }
                    string data_ini;
                    try
                    {
                        data_ini = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_entrada"].Value.ToString()).ToShortDateString();
                    }
                    catch
                    {
                        data_ini = "01.01.2008";
                    }
                    string data_fim;
                    try
                    {
                        data_fim = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_fecha"].Value.ToString()).ToShortDateString();
                    }
                    catch
                    {
                        data_fim = "01.01.2008";
                    }    

                    verificar_horas_das_semanas();
                    inserir_nas_semanas(semana_ano, horas_semana, operacao_semana, rota_semana, numero_semanas, ano_atual, os, pos, data_ini, data_fim); //falta fazer o inserir no banco, junto com o atualizar
                    semana_ano = 0;
                    rota_semana = 0;
                    horas_semana = 0;
                    numero_semanas = 0;
                    ano_atual = 0;
                

                
            }
            //MessageBox.Show(i.ToString());
            //MessageBox.Show(dgvRotas_campo.Rows[i--].Cells["col_cod"].Value.ToString());
            this.Cursor = Cursors.Default;
                
                
            
        }


        
        // falta fazer uma melhor formatação do datagrid
        // falta avançar as semanas

        private DateTime primeiro_dia_semana(int semana_ano)
        {
            DateTime data_inicio = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime data = data_inicio.AddDays(7 * (semana_ano - 1));
            while (data.DayOfWeek != DayOfWeek.Monday)
                data = data.AddDays(-1);

            return data;


        }

        private void inserir_nas_semanas(int semana, double horas, string operacao, int rota, int numero_sem, int ano_semana, string os_semana, string posicao_semana, string data_prev_ini, string data_prev_fim)
        {
            int ano = ano_semana;
            int semana_atual = semana;
            for (int j = 0; j < numero_sem; j++)
            {
                semana_atual = semana_atual + j;
                if (semana_atual == 52 + j && j != 0)
                {
                    semana_atual = j; //verificar essa instrução
                    ano = ano_semana + 1;
                }
                //MessageBox.Show("semana " + semana_atual.ToString());
                //falta testar
                try
                {
                    this.datHoras_semana.InsertCommand.CommandText =
                    "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA, HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, DATA_INICIO_SEMANA, DATA_FIM_SEMANA)" +
                    "VALUES ('" + semana_atual.ToString() + "','" + ano.ToString() + "','" + operacao + "','" + rota.ToString() + "','" + horas.ToString().Replace(",", ".") + "','" + os_semana + "','" + posicao_semana + "','" + data_prev_ini.Replace("/", ".") + "','" + data_prev_fim.Replace("/", ".") + "')";
                    this.fbConnection1.Open();
                    this.datHoras_semana.InsertCommand.Connection = fbConnection1;
                    this.datHoras_semana.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    semana_atual = semana;
                }
                    
                catch
                {
                    MessageBox.Show("erro na rota");
                   
                    this.datHoras_semana.InsertCommand.CommandText =
                     "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA, HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, DATA_INICIO_SEMANA, DATA_FIM_SEMANA)" +
                    "VALUES ('" + semana_atual.ToString() + "','" + ano.ToString() + "','" + operacao + "','" + rota.ToString() + "','" + horas.ToString().Replace(",", ".") + "','" + os_semana + "','" + posicao_semana + "','" + data_prev_ini.Replace("/", ".") + "','" + data_prev_fim.Replace("/", ".") + "')";
                    this.fbConnection1.Open();
                    this.datHoras_semana.InsertCommand.Connection = fbConnection1;
                    this.datHoras_semana.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    semana_atual = semana;
                     
                }
                    
                
               
                
            }
        }

        private void verificar_horas_das_semanas()
        {
            //fazer o tratamento para dar o aviso caso a semana estiver estourada
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
        private int contar_dias(DateTime ultimo, DateTime primeiro)
        {
            TimeSpan numero_dias = primeiro.Subtract(ultimo);
            return Convert.ToInt32(numero_dias.Days.ToString());
        }

        private void dgvRotas_campo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}