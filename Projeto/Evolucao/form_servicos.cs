using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_servicos : Form
    {
        double porc_amarelo;
        double porc_verde;
        double porc_vermelho;
        int verde;
        int amarelo;
        int vermelho;
        double horas_orcadas;
        double horas_executadas;
        double diferenca;
        double eficiencia;
        int semana;
        
        public form_servicos()
        {
            InitializeComponent();
        }

        private void form_servicos_Load(object sender, EventArgs e)
        {
            datRotas_campo.Fill(ROTAS_CAMPO);
            datTipos_operacoes.Fill(TIPOS_OPERACOES);
        }

       
        private DateTime primeiro_dia_semana(int semana_ano)
        {
            DateTime data_inicio = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime data = data_inicio.AddDays(7 * (semana_ano - 1));
            while (data.DayOfWeek != DayOfWeek.Monday) 
                data = data.AddDays(-1);

            return data;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            porc_amarelo = 0;
            porc_verde = 0;
            porc_vermelho = 0;
            verde = 0;
            amarelo = 0;
            vermelho = 0;
            dsRotas_campo.Clear();
            horas_executadas = 0;
            horas_orcadas = 0;
            semana = Convert.ToInt32(tb_semana.Text);
            pesquisar_semana(primeiro_dia_semana(semana), cbOperacoes.Text);
            somar_horas();
            verificar_atrasos();
            
        }

        private void verificar_atrasos()
        {
            amarelo = dgvRotas_campo.RowCount;
            dgvRotas_campo.DefaultCellStyle.ForeColor = Color.Gold;
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                try
                {
                    if (dgvRotas_campo.Rows[i].Cells["col_dt_ent"].Value.ToString() != "")
                        //primeiro_dia_semana(Convert.ToInt32(tb_semana.Text)).AddDays(5) > Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_dt_final"].Value))
                    {
                        if (dgvRotas_campo.Rows[i].Cells["col_dt_final"].Value.ToString() != "")
                        {
                            dgvRotas_campo.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                            verde++;
                            amarelo--;
                        }
                        else
                            if (DateTime.Now > Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_entrega"].Value))
                            {
                                dgvRotas_campo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                                vermelho++;
                                amarelo--;
                            }

                        
                    }
                    else
                    {

                        if (DateTime.Now > Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["col_data_entrega"].Value))
                        {
                            dgvRotas_campo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            vermelho++;
                            amarelo--;
                        }
                            
                       
                    }
                }
                catch {
                    //dgvRotas_campo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            lb_total.Text = dgvRotas_campo.RowCount.ToString();
            lb_amarelo.Text = amarelo.ToString();
            lb_verde.Text = verde.ToString();
            lb_vermelho.Text = vermelho.ToString();
            
            porc_amarelo = (Convert.ToDouble(amarelo)/Convert.ToDouble(dgvRotas_campo.RowCount)) * 100;
            //MessageBox.Show(dgvRotas_campo.RowCount.ToString());
            //MessageBox.Show(porc_verde.ToString());
            //MessageBox.Show(dgvRotas_campo.RowCount.ToString());
            porc_vermelho = (Convert.ToDouble(vermelho) / Convert.ToDouble(dgvRotas_campo.RowCount)) * 100;
            porc_verde = (Convert.ToDouble(verde) / Convert.ToDouble(dgvRotas_campo.RowCount)) * 100;
            lb_porc_amarelo.Text = porc_amarelo.ToString();
            lb_porc_verde.Text = porc_verde.ToString();
            lb_porc_vermelho.Text = porc_vermelho.ToString();

        }
        private void somar_horas()
        {
            
            for (int i = 0; i < dgvRotas_campo.RowCount ; i++)
            {
                try
                {
                    if (dgvRotas_campo.Rows[i].Cells["col_horas_executadas"].Value.ToString() != "0")
                    {
                        horas_orcadas = horas_orcadas + Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_orcadas"].Value);
                    }
                }
                catch { }
            }
            for (int j = 0; j < dgvRotas_campo.RowCount ; j++)
            {

                try
                {
                    horas_executadas = horas_executadas + Convert.ToDouble(dgvRotas_campo.Rows[j].Cells["col_horas_executadas"].Value);
                }
                catch { }
            }
            lb_horas_orcadas.Text = horas_orcadas.ToString();
            lb_horas_executadas.Text = horas_executadas.ToString();
            diferenca = horas_orcadas - horas_executadas;
            lb_diferenca.Text = diferenca.ToString();
            eficiencia = (horas_orcadas / horas_executadas) * 100;
            lb_eficiência.Text = eficiencia.ToString();

        }

        private void pesquisar_semana(DateTime primeiro_dia, string operacao)
        {
            DateTime ultimo_dia = primeiro_dia.AddDays(5);
            DateTime semana_anterior = primeiro_dia.AddDays(-7);
            this.datRotas_campo.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE ((OPERACAO_CAMPO = '" + operacao + "'" +
             " AND DATA_ENTRADA_PREV >= '" + Convert.ToDateTime(primeiro_dia).Month + "/" + Convert.ToDateTime(primeiro_dia).Day + "/" + Convert.ToDateTime(primeiro_dia).Year + "'" +
             " AND DATA_ENTRADA_PREV <= '" + Convert.ToDateTime(primeiro_dia).Month + "/" + Convert.ToDateTime(primeiro_dia).Day + "/" + Convert.ToDateTime(primeiro_dia).Year + "') OR" +
             " (OPERACAO_CAMPO = '" + operacao + "'" +
            " AND DATA_FECHAMENTO_PREV <= '" + Convert.ToDateTime(primeiro_dia).Month + "/" + Convert.ToDateTime(primeiro_dia).Day + "/" + Convert.ToDateTime(primeiro_dia).Year + "'" +
             " AND DATA_FECHAMENTO_PREV >= '" + Convert.ToDateTime(semana_anterior).Month + "/" + Convert.ToDateTime(semana_anterior).Day + "/" + Convert.ToDateTime(semana_anterior).Year + "'" +
            "AND POSICAO_ATUAL != 'FINALIZADO')) ORDER BY DESENHO_CAMPO";
            this.fbConnection1.Open();
            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            datRotas_campo.Fill(ROTAS_CAMPO);
           // MessageBox.Show(Convert.ToDateTime(primeiro_dia).Month.ToString() + "/" + Convert.ToDateTime(primeiro_dia).Day.ToString() + "/" + Convert.ToDateTime(primeiro_dia).Year.ToString());



        }

        private void tb_anterior_Click(object sender, EventArgs e)
        {
            int anterior = Convert.ToInt32(tb_semana.Text);
            anterior--;
            tb_semana.Text = anterior.ToString();


        }

        private void tb_proximo_Click(object sender, EventArgs e)
        {
            try
            {
                int proximo = Convert.ToInt32(tb_semana.Text);
                proximo++;
                tb_semana.Text = proximo.ToString();
            }
            catch
            {
                tb_semana.Text = "1";
            }
        }

        

        private void dgvRotas_campo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            try
            {
                abre_rota.rota_atual = dgvRotas_campo.Rows[e.RowIndex].Cells[0].Value;
                abre_rota.ShowDialog();
            }
            finally
            {
                abre_rota.Dispose();
                datRotas_campo.Fill(ROTAS_CAMPO);
            }
        }

        private void dgvRotas_campo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //dgvRotas_campo.CurrentCell.Style.ForeColor = Color.Red;
        }

       

        
    }
}