using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_consulta_ponto : Form
    {
        public string data_inicial;
        public string data_final;
        public bool um_dia;
        public string operador_atual;
        public bool consulta_conjunta;
        public string horas_totais_por_operador;
        public bool consulta_operador;


        
        DateTime abertura;
        DateTime abertura_data;
        DateTime fechamento;
        DateTime fechamento_data;
        TimeSpan resultado;
        double total_horas_operador;
        int i;
        int k;
        bool em_andamento;
        double horas_parciais;
        double total_horas_operador_parcial;
        private string total_horas_str;
        private int horas_dias;

        private string separa_dias;
        private string separa_horas;
        private string separa_minutos;
        //private string texto_total_horas;
        private double minutos_decimais;
        bool breca;
        double horas_parciais_x;
        string inicio_dia_anterior;
        public string total_operador_consulta;
        public form_consulta_ponto()
        {
            InitializeComponent();
        }

        private void form_consulta_ponto_Load(object sender, EventArgs e)
        {
            if (consulta_conjunta == true)
            {
                tb_operador.Text = operador_atual;
                dtInicial.Value = Convert.ToDateTime(data_inicial);
                dtFinal.Value = Convert.ToDateTime(data_final);
                if (um_dia == true)
                    cbUm_dia.Checked = true;
                else
                    cbUm_dia.Checked = false;
                puxa_do_banco();


            }
            dgvConsulta_ponto.AutoGenerateColumns = false;
            dgvConsulta_ponto.DataSource = dsApontamentos.Tables["APONTAMENTOS"];
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            puxa_do_banco();
        }

        private void puxa_do_banco()
        {
            if (tb_operador.Text != "")
            {
                if (cbUm_dia.Checked == true)
                {
                    this.datApontamentos.SelectCommand.CommandText =
                    "SELECT * FROM APONTAMENTOS WHERE (UPPER(OPERADOR_APONTAMENTO) LIKE UPPER('" + tb_operador.Text + "'))" +
                     " AND DATA_FECHAMENTO_APONTAMENTO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                     " ORDER BY COD_APONTAMENTO";
                }
                else
                {
                    this.datApontamentos.SelectCommand.CommandText =
                    "SELECT * FROM APONTAMENTOS WHERE (UPPER(OPERADOR_APONTAMENTO) LIKE UPPER('" + tb_operador.Text + "'))" +
                     " AND ((DATA_FECHAMENTO_APONTAMENTO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                     " AND DATA_FECHAMENTO_APONTAMENTO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))" +
                     " ORDER BY COD_APONTAMENTO";
                }

            }
            else
            {
                this.datApontamentos.SelectCommand.CommandText =
                "SELECT * FROM APONTAMENTOS WHERE DATA_FECHAMENTO_APONTAMENTO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                 " ORDER BY OPERADOR_APONTAMENTO";

            }
            this.fbConnection1.Open();
            this.datApontamentos.SelectCommand.Connection = fbConnection1;
            this.datApontamentos.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            datApontamentos.Fill(APONTAMENTOS);
            calcula_horas();
            horas_totais_por_operador = tbTotal_horas.Text;
            if (consulta_operador == true)
                this.Close();
        }

        private void calcula_horas()
        {
            for (i = 0; i < (dgvConsulta_ponto.RowCount - 1); i++)
            {
                //cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());
                //MessageBox.Show(total_horas_operador.ToString() + " é o total de horas da linha");
                //MessageBox.Show("Estou na linha " + i.ToString());
                if (dgvConsulta_ponto.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                {
                    abertura_data = Convert.ToDateTime(dgvConsulta_ponto.Rows[i].Cells["col_data_entrada"].Value.ToString());
                    abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvConsulta_ponto.Rows[i].Cells["col_hora_entrada"].Value.ToString());
                    em_andamento = true;
                }
                if (em_andamento == true)
                {
                    if (dgvConsulta_ponto.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "")
                    {
                        fechamento = DateTime.Now;
                    }
                    else
                    {
                        fechamento_data = Convert.ToDateTime(dgvConsulta_ponto.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                        fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvConsulta_ponto.Rows[i].Cells["col_hora_fechamento"].Value.ToString());
                    }
                    resultado = fechamento.Subtract(abertura);
                    total_horas_operador = total_horas_operador + (transforma_dia_horas(resultado.ToString()));
                }
                if (dgvConsulta_ponto.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                {
                    horas_parciais = total_horas_operador - horas_parciais_x;
                    //MessageBox.Show("total de horas até agora é " + total_horas_operador.ToString());
                    dgvConsulta_ponto.Rows[i].Cells["col_saldo_horas"].Value = horas_parciais.ToString();
                    horas_parciais_x = total_horas_operador;
                    /*MessageBox.Show(hor);
                    horas_parciais = total_horas_operador - horas_parciais;
                    dgvConsulta.Rows[i].Cells["col_saldo_horas"].Value = horas_parciais.ToString(); */
                }
                em_andamento = false;
                if (dgvConsulta_ponto.Rows[i].Cells["col_saldo_horas"].Value.ToString() == "")
                    dgvConsulta_ponto.Rows[i].Cells["col_saldo_horas"].Value = "0,0";
            }
            tbTotal_horas.Text = total_horas_operador.ToString();
            total_operador_consulta = total_horas_operador.ToString();
            

        }

        private double transforma_dia_horas(string x)
        {
            k = 0;
            breca = false;
            separa_dias = "";
            separa_horas = "";
            separa_minutos = "";

            while (breca == false)
            {

                if (x[k].ToString() == ":")
                {
                    separa_dias = "0";
                    k = -1;
                    breca = true;
                }
                if (breca == true)
                    break;
                separa_dias = separa_dias + x[k];

                k++;
                if (x[k].ToString() == ".")
                    breca = true;
            }
            k++;
            while (x[k].ToString() != ":")
            {
                separa_horas = separa_horas + x[k];
                k++;
            }
            k++;
            while (x[k].ToString() != ":")
            {
                separa_minutos = separa_minutos + x[k];
                k++;
            }
            int var_dias = Convert.ToInt32(separa_dias);
            int var_horas = Convert.ToInt32(separa_horas);
            double var_minutos = Convert.ToDouble(separa_minutos);
            if (var_minutos != 0)
            {
                minutos_decimais = var_minutos / 60;
                string aumenta_casas = minutos_decimais.ToString() + "0";
                minutos_decimais = Convert.ToDouble(aumenta_casas);
                horas_dias = (var_dias * 24) + var_horas;
                total_horas_str = horas_dias.ToString() + "," + aumenta_casas[2] + aumenta_casas[3];
                total_horas_operador_parcial = Convert.ToDouble(total_horas_str);
                return total_horas_operador_parcial;
                zera_variaveis();
                
            }
            else
            {
                horas_dias = (var_dias * 24) + var_horas;
                total_horas_str = horas_dias.ToString() + "," + "00";
                total_horas_operador_parcial = Convert.ToDouble(total_horas_str);
                return total_horas_operador_parcial;
                zera_variaveis();
                
            }
        }

        private void zera_variaveis()
        {
            separa_dias = "";
            separa_horas = "";
            separa_minutos = "";
            //texto_total_horas = "" ;
            minutos_decimais = 0;
            //private double total_horas;
            total_horas_str = "";
            horas_dias = 0;
            k = 0;

            total_horas_operador_parcial = 0;
        }


        private void Refazer_Click(object sender, EventArgs e)
        {
            tb_operador.Text = "";
            dsApontamentos.Clear();
            horas_parciais = 0;
            horas_parciais_x = 0;
            total_horas_operador = 0;
            tbTotal_horas.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_ponto ponto = new form_ponto();
            ponto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsApontamentos, "APONTAMENTOS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsApontamentos.HasChanges())
            {

                //MessageBox.Show("CHEGOU NO ATUALIZAR das ops");
                datApontamentos.UpdateCommand = cbApontamentos.GetUpdateCommand();
                datApontamentos.InsertCommand = cbApontamentos.GetInsertCommand();
                datApontamentos.DeleteCommand = cbApontamentos.GetDeleteCommand();
                datApontamentos.Update(dsApontamentos, "APONTAMENTOS");
                dsApontamentos.AcceptChanges();

            }
            fbConnection1.Close(); 
        }
    }
}