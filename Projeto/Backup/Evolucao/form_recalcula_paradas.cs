using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_recalcula_paradas : Form
    {
        public int k;
        string data_inicio_abrev;
        string data_termino_abrev;

        private string separa_dias;
        private string separa_horas;
        private string separa_minutos;
        //private string texto_total_horas;
        private double minutos_decimais;
        private double total_horas;
        private string total_horas_str;
        private int horas_dias;
        private int i;
        private bool breca;
        private TimeSpan resultado;
        public form_recalcula_paradas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (k = 0; k < 100000; k++)
                {
                    /*
                    for (int j = 0; j < 5; j++)
                    {
                        try
                        {
                            //MessageBox.Show("Está na linha" + i.ToString());
                            //MessageBox.Show("Está na coluna" + j.ToString());
                            //MessageBox.Show(copiar_dados[j, i].ToString());
                            //PAREI AQUI!!! TEM QUE PARAR QUANDO LINHA = N. ROTAS + 1
                            //MessageBox.Show(copiar_dados[i, j].ToString());
                            copiar_dados[i, j] = dgvParadas.Rows[i].Cells[j].Value.ToString();
                            //MessageBox.Show(copiar_dados[i, j].ToString());
                        }
                        catch (FormatException)
                        {
                            //break;
                        }
                    }
                     
                    k++;
                    if (dgvParadas.Rows[k].Cells[0].Value.ToString() == "");
                    {
                        //MessageBox.Show("passou no if");
                        break;
                    }
                    k--;*/
                    //MessageBox.Show("a parada é " + dgvParadas.Rows[k].Cells["tb_cod_parada"].Value.ToString());
                    subtrai_datas();
                }
            }
            catch
            {
                MessageBox.Show("Atualizado");
            }
            
        }

        private void form_recalcula_paradas_Load(object sender, EventArgs e)
        {
            datParadas.Fill(PARADAS);
            datRotas_campo.Fill(ROTAS_CAMPO);


        }
        private void subtrai_datas()
        {
            //MessageBox.Show(dgvParadas.Rows[i].Cells["tb_data_inicio"].Value.ToString());
            //MessageBox.Show(dgvParadas.Rows[i].Cells["tb_hora_inicio"].Value.ToString());
            //MessageBox.Show(dgvParadas.Rows[i].Cells["tb_data_inicio"].Value.ToString() + " " + dgvParadas.Rows[i].Cells["tb_hora_inicio"].Value.ToString());
            if (dgvParadas.Rows[k].Cells["tb_hora_termino"].Value.ToString() != "")
            {

                string data_inicio_completa = dgvParadas.Rows[k].Cells["tb_data_inicio"].Value.ToString();

                for (int j = 0; j < 10; j++)
                {
                    data_inicio_abrev = data_inicio_abrev + data_inicio_completa[j];
                }

                DateTime abertura = Convert.ToDateTime(data_inicio_abrev + " " + dgvParadas.Rows[k].Cells["tb_hora_inicio"].Value.ToString());
                data_inicio_abrev = "";
                data_inicio_completa = "";
                // MessageBox.Show(dgvParadas.Rows[i].Cells[6].Value.ToString());
                //MessageBox.Show(abertura.ToString());
                
                string data_termino_completa = dgvParadas.Rows[k].Cells["tb_data_termino"].Value.ToString();
                for (int j = 0; j < 10; j++)
                {
                    data_termino_abrev = data_termino_abrev + data_termino_completa[j];
                }
                DateTime fechamento = Convert.ToDateTime(data_termino_abrev + " " + dgvParadas.Rows[k].Cells["tb_hora_termino"].Value.ToString());
                data_termino_abrev = "";
                data_termino_completa = "";
                //MessageBox.Show(fechamento.ToString());
                resultado = fechamento.Subtract(abertura);
                //MessageBox.Show(resultado.ToString());
                transforma_dia_horas(resultado.ToString());
            }
            
            
        }
        private void transforma_dia_horas(string x)
        {
            i = 0;
            breca = false;
            while (breca == false)
            {

                if (x[i].ToString() == ":")
                {
                    separa_dias = "0";
                    i = -1;
                    breca = true;
                }
                if (breca == true)
                    break;
                
                separa_dias = separa_dias + x[i];
                //MessageBox.Show("Separa dias = " + separa_dias.ToString());
                i++;
                if (x[i].ToString() == ".")
                    breca = true;
            }
            i++;
            while (x[i].ToString() != ":")
            {
                separa_horas = separa_horas + x[i];
                i++;
            }
            i++;
            while (x[i].ToString() != ":")
            {
                separa_minutos = separa_minutos + x[i];
                i++;
            }
            int var_dias = Convert.ToInt16(separa_dias);
            int var_horas = Convert.ToInt16(separa_horas);
            double var_minutos = Convert.ToDouble(separa_minutos);
            if (var_minutos != 0)
            {
                minutos_decimais = var_minutos / 60;
                string aumenta_casas = minutos_decimais.ToString() + "0";
                //MessageBox.Show("aumenta casas = " + aumenta_casas);
                minutos_decimais = Convert.ToDouble(aumenta_casas);
                //minutos_decimais = minutos_decimais * 10;
                horas_dias = (var_dias * 24) + var_horas;
                //MessageBox.Show("Minutos decimais = " + minutos_decimais.ToString());
                //MessageBox.Show("horas dias é igual a "+ horas_dias.ToString());
                total_horas_str = horas_dias.ToString() + "." + aumenta_casas[2] + aumenta_casas[3];
                total_horas = Convert.ToDouble(total_horas_str);
                insere_horas_banco();
            }
            else
            {
                //minutos_decimais = 0.00;
                //MessageBox.Show(minutos_decimais.ToString());
                horas_dias = (var_dias * 24) + var_horas;
                //MessageBox.Show(horas_dias.ToString());
                total_horas_str = horas_dias.ToString() + "." + "00";
                total_horas = Convert.ToDouble(total_horas_str);
                insere_horas_banco();
                //MessageBox.Show("total de horas é "+ total_horas.ToString());
            }
        }

        private void insere_horas_banco()
        {
            //MessageBox.Show("o total de horas é" + total_horas_str);
            //MessageBox.Show("a parada é " + dgvParadas.Rows[k].Cells["tb_cod_parada"].Value.ToString());
            this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET HORAS_PARADAS = HORAS_PARADAS + " + total_horas_str +
                    " WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[k].Cells["tb_rota"].Value.ToString() + "'";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            //datRotas_campo.Fill(ROTAS_CAMPO);
            this.fbConnection1.Close();



            this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE PARADAS SET TOTAL_HORAS_PARADA = '" + total_horas_str +
                    "' WHERE COD_PARADA = '" + dgvParadas.Rows[k].Cells["tb_cod_parada"].Value.ToString() + "'";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            //datRotas_campo.Fill(ROTAS_CAMPO);
            this.fbConnection1.Close();
            datParadas.Fill(PARADAS);
            //MessageBox.Show("Atualizado");
            //Atualizar();
            
            //zera tudo
            separa_dias = "0";
            separa_horas = "0" ;
            separa_minutos = "0";
            //texto_total_horas = "0";
            minutos_decimais = 0;
            total_horas = 0;
            total_horas_str = "0";
            horas_dias = 0;
            i = 0; ;

        }

    }
}