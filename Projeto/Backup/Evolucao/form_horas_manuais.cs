using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_horas_manuais : Form
    {
        //variaveis para inserção semana
       public string operacao;
       public string horas_prev;               
       public string os;
       public string pos;
       public string situacao;
       public string ent_prev;
       public string fim_prev;
           
        bool erro;
        bool primeiro;
        public string rota_atual;
        public string operador_atual;
        String novo_num;
        
        public form_horas_manuais()
        {
            InitializeComponent();
        }

        private void bt_horas_Click(object sender, EventArgs e)
        {
            
           // try
           // {
                if(erro == false)
                {
                this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET HORAS_MAQUINA_RODANDO = (HORAS_MAQUINA_RODANDO + " + tb_horas.Text.Replace(",", ".") + ") WHERE COD_ROTA_CAMPO = '" + tb_rota.Text + "'";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                }
                int semana = 1 + conferir_semana(Convert.ToDateTime(tb_data.Text))/7;
                Atualizar();
                primeiro = true;
                inserir_nas_semanas(Convert.ToDateTime(tb_data.Text).Year, semana,
                    tb_horas.Text.Replace(",","."), tb_rota.Text);
                this.Close();
            //}
            

            
            //catch
           // {
           //     this.fbConnection1.Close();
           //     MessageBox.Show("Preencha todos os campos por favor");
           // }
            
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

        private void inserir_nas_semanas(int ano, int semana, string horas, string rotas)
        {
            //MessageBox.Show(semana.ToString());
            if (primeiro == true)
            {
                this.datHoras_semana.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = 0" +
                        " WHERE ROTA_HORAS_SEMANA = '" + rotas +
                        "'";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                //MessageBox.Show("zerado");
                primeiro = false;
            }

            //MessageBox.Show("update");
            this.datHoras_semana.UpdateCommand.CommandText =
                       "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = (HORAS_REAIS_OPERACAO + " + horas.Replace(",", ".") +
                       ") WHERE ROTA_HORAS_SEMANA = '" + rotas +
                       "' AND N_SEMANA = '" + semana.ToString() + "'";
            this.fbConnection1.Open();
            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
            //this.datSemanas.UpdateCommand.ExecuteNonQuery();
            int registros = datHoras_semana.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show(registros.ToString());

            if (registros == 0)
            {
                //MessageBox.Show("novo registro");
                try
                {
                    this.datHoras_semana.InsertCommand.CommandText =
                        "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA," +
                        "HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, SITUACAO_ROTA_SEMANA, DATA_INICIO_SEMANA, " +
                        "DATA_FIM_SEMANA)" +
                        "VALUES ('" + semana + "','" + ano + "','" +
                        operacao + "','" +
                        tb_rota.Text + "','" +
                        horas_prev + "','" +
                        os + "','" +
                        pos + "','" +
                        situacao+ "','" +
                        Convert.ToDateTime(ent_prev).ToShortDateString().Replace("/", ".") + "','" +
                        Convert.ToDateTime(fim_prev).ToShortDateString().Replace("/", ".") + "')";
                        
                    this.fbConnection1.Open();
                    this.datHoras_semana.InsertCommand.Connection = fbConnection1;
                    this.datHoras_semana.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch { }

            }
        }


        private void Atualizar()
        {
            //inserção na tabela de paradas
            this.BindingContext[dsMaquina_rodando, "MAQUINA_RODANDO"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsMaquina_rodando.HasChanges())
            {
                datMaquina_rodando.UpdateCommand = cbMaquina_rodando.GetUpdateCommand();
                datMaquina_rodando.InsertCommand = cbMaquina_rodando.GetInsertCommand();
                datMaquina_rodando.DeleteCommand = cbMaquina_rodando.GetDeleteCommand();
                datMaquina_rodando.Update(dsMaquina_rodando, "MAQUINA_RODANDO");
                dsMaquina_rodando.AcceptChanges();
            }
            fbConnection1.Close();

            
            this.datMaquina_rodando.UpdateCommand.CommandText =
            "UPDATE MAQUINA_RODANDO SET OS_MAQUINA_RODANDO = '" + tb_os.Text + "' WHERE ROTA_MAQUINA_RODANDO = '" + tb_rota.Text + "'";
            this.fbConnection1.Open();
            this.datMaquina_rodando.UpdateCommand.Connection = fbConnection1;
            this.datMaquina_rodando.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datMaquina_rodando.UpdateCommand.CommandText =
            "UPDATE MAQUINA_RODANDO SET HORAS_TRABALHADAS_MAQUINA = HORAS_TRABALHADAS_MAQUINA + " + tb_horas.Text.Replace(",",".") + " WHERE COD_MAQUINA_RODANDO = '" + tb_cod.Text + "'";
            this.fbConnection1.Open();
            this.datMaquina_rodando.UpdateCommand.Connection = fbConnection1;
            this.datMaquina_rodando.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

        }

        private void form_horas_manuais_Load(object sender, EventArgs e)
        {
            datMaquina_rodando.Fill(MAQUINA_RODANDO);
            this.BindingContext[dsMaquina_rodando, "MAQUINA_RODANDO"].AddNew();

            tb_rota.Text = rota_atual;
            tb_operador.Text = operador_atual;
            this.datRotas_campo.SelectCommand.CommandText =
            "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO LIKE '" + tb_rota.Text + "%'";
            this.fbConnection1.Open();
            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datRotas_campo.Fill(ROTAS_CAMPO);
            tb_maquina_nova.Focus();
        }
    }
}