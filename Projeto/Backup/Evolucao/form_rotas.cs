using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_rotas : Form
    {
        bool se_inicio_reinicio;
        double horas_inicio_reinicio;


        string se_onde;
        string se_horas;
        string se_qtde;
        bool se;
        int semana_atual;
        bool retrabalho;
        string funcao_retrabalho;
        string rota_retrabalho;
        string operacao_retrabalho;
        string os_sistema_retrabalho;
        string os_peca;
        string os_retrabalho;
        string posicao_retrabalho;
        double previsao_correta;
        int primeira_semana;
        int ultima_semana;
        int n_semanas;

        string ent_prev;
        string sai_prev;
        double previsao;
        bool erro;
        bool primeiro;
        double transforma;
        int n_paradas;
        double horas_parciais;
        private string separa_dias;
        private string separa_horas;
        private string separa_minutos;
        private double minutos_decimais;
        int rota_atual_2;
        bool operacao_ja_somada;
        private string total_horas_str;
        private int horas_dias;
        private int k;
        DateTime abertura_data;
        DateTime abertura_data_confere;
        DateTime abertura_data_anterior_confere;
        DateTime fechamento_data_confere;
        DateTime fechamento_data_posterior_confere;
        DateTime reinicio_parada_data_anterior_confere;
        DateTime reinicio_parada_data_confere;
        DateTime abertura_parada_data_posterior_confere;
        DateTime abertura_parada_data_confere;
        DateTime date_now_confere;
        public int[] cod_rota_consultados = new int[50000];
        public int[] cod_parada_consultados = new int[50000];
        //outras variaveis
        bool em_andamento;
        DateTime fechamento_data;
        int opcoes;
        bool breca;
        int i;
        int j;
        int m;
        int n;
        double total_horas_operador;
        double total_horas_operador_parcial;
        string data_inicial_atualizada;
        string data_final_atualizada;
        string di;
        string df;
        DateTime abertura;
        DateTime fechamento;
        TimeSpan resultado;
        double horas_parciais_x;
        bool imprimir_agora;
        string parada_outro_dia;
        string inicio_dia_anterior;
        string reinicio_dia_anterior;
        public string operador_escolhido;
        string operacao_atual;
        bool parar_consulta;
        string horas_totais_por_operador;
        string horas_operador_ponto;
        double total_horas_prev;
        double total_horas_ret;
        double total_horas_trab;
        //variaveis realinhamento de os conjuntas
        int n_os_conj;

        int os_conj_atual = 1;
        bool existem_rotas_conj;
        int rota_atual_os; string maquina_atual; int operador_atual;
        int rota_comp; string maquina_comp; int operador_comp;
        DateTime momento_atual; DateTime data_comparativa;
        DateTime momento_ant; DateTime momento_post;

        string maq;
        public object rota_atual;
        bool apaga;

        //variaveis de inserção
        string data_nova;
        string hora_nova;
        string operador_novo;
        string maquina_nova;
        string itens_conj_novo;

        public form_rotas()
        {
            InitializeComponent();
        }

        private void datRotas_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {

        }

        

        private void form_rotas_Load(object sender, EventArgs e)
        {

            int qualquer_rota = Convert.ToInt16(rota_atual);
            //pois o indice começa com zero
            this.datRotas.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + qualquer_rota.ToString() + "'";
            this.fbConnection1.Open();
            this.datRotas.SelectCommand.Connection = fbConnection1;
            this.datRotas.SelectCommand.ExecuteNonQuery();
            datRotas.Fill(ROTAS_CAMPO);
            this.fbConnection1.Close();
            //qualquer_rota--; datRotas.Fill(ROTAS_CAMPO);
            this.datParadas.SelectCommand.CommandText =
                "SELECT * FROM PARADAS WHERE N_ROTAS_CAMPO = '" + qualquer_rota.ToString() + "' ORDER BY COD_PARADA";
            this.fbConnection1.Open();
            this.datParadas.SelectCommand.Connection = fbConnection1;
            this.datParadas.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datParadas.Fill(PARADAS);
            int semana_atual = 1 + conferir_semana(DateTime.Now)/7;
            
            if (semana_atual > 53)
            {
                semana_atual = 2;
                //ano = ano + 1;
            }
            //VERIFICAR ISSO NOS ANOS A PARTIR DE 2010

            if (semana_atual == 1)
            {
                semana_atual = 53;
                //ano = ano - 1;
            }
             
           // MessageBox.Show(semana_atual.ToString());
            this.datHoras_semana.SelectCommand.CommandText =
               "SELECT * FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + qualquer_rota.ToString() + "'" + 
               "AND N_SEMANA = '" + semana_atual.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
            this.fbConnection1.Open();
            this.datHoras_semana.SelectCommand.Connection = fbConnection1;
            this.datHoras_semana.SelectCommand.ExecuteNonQuery();
            datHoras_semana.Fill(HORAS_SEMANA);
            this.fbConnection1.Close();

            //this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = qualquer_rota;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsParadas.Tables["PARADAS"];
            datForn.Fill(FORNECEDORES);
            acertar_cores();
        }
        private void acertar_cores()
        {
            try
            {
                if (tb_situacao.Text == "FINALIZADO")
                {
                    if (Convert.ToDateTime(tb_fechamento_data.Text) > Convert.ToDateTime(tb_fecha_prev.Text))
                        gb_estado.BackColor = Color.Aqua;
                    else
                        gb_estado.BackColor = Color.Lime;
                }
                if (tb_situacao.Text == "PARADA")
                {
                    if (Convert.ToDateTime(tb_fecha_prev.Text) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        gb_estado.BackColor = Color.Red;
                    else
                        gb_estado.BackColor = Color.Orange;

                }
                if (tb_situacao.Text == "EM ANDAMENTO")
                {
                    if (Convert.ToDateTime(tb_fecha_prev.Text) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        gb_estado.BackColor = Color.Red;
                    else
                        gb_estado.BackColor = Color.Green;
                }
                if (tb_situacao.Text == "")
                {
                    if (Convert.ToDateTime(tb_fecha_prev.Text) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        gb_estado.BackColor = Color.Red;
                    else
                        gb_estado.BackColor = Color.Yellow;
                }
            }
            catch {
                if (tb_situacao.Text == "FINALIZADO")
                {
                    gb_estado.BackColor = Color.Lime;
                }
                if (tb_situacao.Text == "PARADA")
                {
                    gb_estado.BackColor = Color.Orange;

                }
                if (tb_situacao.Text == "EM ANDAMENTO")
                {
                    gb_estado.BackColor = Color.Green;
                }
                if (tb_situacao.Text == "")
                {
                    gb_estado.BackColor = Color.Yellow;
                }
            }
            
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = 1000000000;
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            if (tb_retrabalho_rota.Text == tb_codigo_rota.Text)
            {
                if (tb_horas_trab.Text == "")
                    tb_horas_trab.Text = "0";
            }
            if (tb_prev.Text == "")
                tb_prev.Text = "0";
            if (tb_horas_manuais.Text == "")
                tb_horas_manuais.Text = "0";
            
            if (tb_codigo_rota.Text != tb_retrabalho_rota.Text)
                acertar_rota_mae(tb_retrabalho_rota.Text);
            /*
            this.datRotas.UpdateCommand.CommandText =
                            "UPDATE ROTAS_CAMPO SET ULTIMO_OPERADOR = '" + operador_novo + "' WHERE COD_ROTA_CAMPO = '" + tb_codigo_rota.Text + "'";
            this.fbConnection1.Open();
            this.datRotas.UpdateCommand.Connection = fbConnection1;
            this.datRotas.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
             * */
            recalcular_horas();
            Atualizar();
            acertar_cores();

            //recalcular_horas();
            //Atualizar();
            //acertar_cores();
        }

        private void acertar_rota_mae(string rota)
        {
            if (tb_situacao.Text == "FINALIZADO")
            {
                this.datRotas.UpdateCommand.CommandText =
                        "UPDATE ROTAS_CAMPO SET POSICAO_ATUAL = 'FINALIZADO' WHERE RETRABALHO_ROTA = '" + rota + "'";
                this.fbConnection1.Open();
                this.datRotas.UpdateCommand.Connection = fbConnection1;
                this.datRotas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
        }
        //verificar relação entre horas manuais e serviço externo e semanas
        //além de verificar se está fazendo a soma quando faz isso manualmente
        private void atualizar_pos_sem()
        {
            this.datHoras_semana.UpdateCommand.CommandText =
                    "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = '" + tb_situacao.Text + "' WHERE ROTA_HORAS_SEMANA = '" + tb_codigo_rota.Text + "'";
            this.fbConnection1.Open();
            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void Atualizar()
        {
            this.BindingContext[dsRotas, "ROTAS_CAMPO"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsRotas.HasChanges())
            {
                //MessageBox.Show("chegou aqui");
                datRotas.UpdateCommand = cbRotas.GetUpdateCommand();
                datRotas.InsertCommand = cbRotas.GetInsertCommand();
                datRotas.DeleteCommand = cbRotas.GetDeleteCommand();
                datRotas.Update(dsRotas, "ROTAS_CAMPO");
                dsRotas.AcceptChanges();
            }
            if (apaga == true)
            {
                //MessageBox.Show("chegou aqui");
                datRotas.UpdateCommand = cbRotas.GetUpdateCommand();
                datRotas.InsertCommand = cbRotas.GetInsertCommand();
                datRotas.DeleteCommand = cbRotas.GetDeleteCommand();
                datRotas.Update(dsRotas, "ROTAS_CAMPO");
                dsRotas.AcceptChanges();
            }

            this.BindingContext[dsParadas, "PARADAS"].EndCurrentEdit();
            if (dsParadas.HasChanges())
            {
                //MessageBox.Show("chegou");
                datParadas.UpdateCommand = cbParadas.GetUpdateCommand();
                datParadas.InsertCommand = cbParadas.GetInsertCommand();
                datParadas.DeleteCommand = cbParadas.GetDeleteCommand();
                datParadas.Update(dsParadas, "PARADAS");
                dsParadas.AcceptChanges();
            }
            fbConnection1.Close();
            atualizar_pos_sem();
        }

        private void tb_codigo_rota_TextChanged(object sender, EventArgs e)
        {
            dsParadas.Tables["PARADAS"].DefaultView.RowFilter = "N_rotas_campo Like'" + tb_codigo_rota.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_entrada_data.Text = "";
            tb_entrada_hora.Text = "";
            apaga = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_fechamento_data.Text = "";
            tb_fechamento_hora.Text = "";
            //tb_finalizado.Text = "";
            apaga = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cb_horas_manuais.Checked == true)
                MessageBox.Show("Não é possível fazer essa operação");
            else
            {
                //hora e data vazios
                if (tb_nova_data.Text == "" && tb_nova_hora.Text == "")
                {
                    
                    //operador vazio
                    if (tb_novo_operador.Text == "")
                    {
                        data_nova = DateTime.Now.ToShortDateString();
                        hora_nova = DateTime.Now.ToShortTimeString();
                        operador_novo = "00001";
                        maquina_nova = ver_maquina(tb_operacao.Text);

                    }
                    else
                    {
                        data_nova = DateTime.Now.ToShortDateString();
                        hora_nova = DateTime.Now.ToShortTimeString();
                        operador_novo = tb_novo_operador.Text;
                        maquina_nova = ver_maquina(tb_operacao.Text);
                    }
                    if (tb_novo_itens_conj.Text == "")
                        itens_conj_novo = "1";
                    else
                        itens_conj_novo = tb_novo_itens_conj.Text;
                }
                else
                {
                    if (tb_nova_hora.Text == "")
                        tb_nova_hora.Text = "8:00";
                    data_nova = tb_nova_data.Text;
                    hora_nova = tb_nova_hora.Text;
                    if (tb_novo_operador.Text == "")
                        tb_novo_operador.Text = "00001";
                    operador_novo = tb_novo_operador.Text;
                    if (tb_nova_maquina.Text == "")
                        tb_nova_maquina.Text = ver_maquina(tb_operacao.Text);
                    maquina_nova = tb_nova_maquina.Text;
                    if (tb_novo_itens_conj.Text == "")
                        itens_conj_novo = "1";
                    else
                        itens_conj_novo = tb_novo_itens_conj.Text;

                }
                inserir_fechamento();
            }
        }
        public void inserir_fechamento()
        {
            if (tb_fechamento_data.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Já existe um registro, gostaria de continuar?",
                "Confirma?", MessageBoxButtons.YesNo))
                {
                    tb_fechamento_data.Text = data_nova;
                    tb_fechamento_hora.Text = hora_nova;
                    tb_operador_final.Text = operador_novo;
                    tb_maquina_final.Text = maquina_nova;
                    tb_itens_fecha.Text = itens_conj_novo;
                    //tb_itens_ini.Text = itens_conj_novo;
                    //MessageBox.Show(data_nova + " " + hora_nova + " " + operador_novo +
                    //  " " + maquina_nova + " " + itens_conj_novo);
                }
            }
            else
            {
                tb_fechamento_data.Text = data_nova;
                tb_fechamento_hora.Text = hora_nova;
                tb_operador_final.Text = operador_novo;
                tb_maquina_final.Text = maquina_nova;
                tb_itens_fecha.Text = itens_conj_novo;
                tb_situacao.Text = "FINALIZADO";
            }
            update_retrabalho();
            tb_nova_data.Text = "";
            tb_nova_hora.Text = "";
            tb_nova_maquina.Text = "";
            tb_novo_itens_conj.Text = "";
            tb_novo_operador.Text = "";
            acertar_cores();
            //tb_situacao.Text = "FINALIZADO";
            //tb_obs.Text = tb_obs.Text + "Finalizado Manualmente";

        }

        private void update_retrabalho()
        {
            this.datRotas.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET POSICAO_ATUAL = 'FINALIZADO'  " +
                    " WHERE COD_ROTA_CAMPO = '" + tb_retrabalho_rota.Text + "'";
            this.fbConnection1.Open();
            this.datRotas.UpdateCommand.Connection = fbConnection1;
            this.datRotas.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cb_servico_externo.Checked = true;
            tb_situacao.Text = "FINALIZADO";
            tb_fechamento_data.Text = DateTime.Now.ToShortDateString();
            Atualizar();
            tb_obs.Text = tb_obs.Text + " ** Serviço externo manual";
            acertar_cores();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           form_horas_manuais horas = new form_horas_manuais();
           try
           {
               horas.rota_atual = tb_codigo_rota.Text;
               horas.operador_atual = "00001";
               horas.operacao = tb_operacao.Text;
               horas.horas_prev = tb_prev.Text;
               horas.os = tb_peca.Text;
               horas.pos = tb_n_pdf.Text;
               horas.situacao = tb_situacao.Text;
               horas.ent_prev = tb_ent_prev.Text;
               horas.fim_prev = tb_fecha_prev.Text;
               horas.Show();
           }
           finally
           {

               string qualquer_rota = tb_codigo_rota.Text;
               dsRotas.Clear();
               dsParadas.Clear();
               //pois o indice começa com zero
               this.datRotas.SelectCommand.CommandText =
                   "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + qualquer_rota + "'";
               this.fbConnection1.Open();
               this.datRotas.SelectCommand.Connection = fbConnection1;
               this.datRotas.SelectCommand.ExecuteNonQuery();
               datRotas.Fill(ROTAS_CAMPO);
               this.fbConnection1.Close();
               //qualquer_rota--; datRotas.Fill(ROTAS_CAMPO);
               datParadas.Fill(PARADAS);
               //this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = qualquer_rota;
               dataGridView1.AutoGenerateColumns = false;
               dataGridView1.DataSource = dsParadas.Tables["PARADAS"];
               datForn.Fill(FORNECEDORES);
               acertar_cores();
               recalcular_horas();


           }
        }

        private void btParada_finalizado_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.RowCount.ToString());
            if (dataGridView1.Rows[dataGridView1.RowCount-2].Cells["col_parada_final"].Value.ToString() == "Sim")
                MessageBox.Show("Não é possível fazer esta operação pois existe um Reinício");
            else
            {
                string operador = Convert.ToString(dataGridView1.Rows[dataGridView1.RowCount-2].Cells["col_operador"].Value);
                string maquina = Convert.ToString(dataGridView1.Rows[dataGridView1.RowCount-2].Cells["col_maquina"].Value);
                string data_fecha = Convert.ToString(dataGridView1.Rows[dataGridView1.RowCount-2].Cells["col_data"].Value);
                string hora_fecha = Convert.ToString(dataGridView1.Rows[dataGridView1.RowCount-2].Cells["col_hora"].Value);
                tb_operador_final.Text = operador;
                tb_maquina_final.Text = maquina;
                tb_fechamento_data.Text = data_fecha;
                tb_fechamento_hora.Text = hora_fecha;
                tb_situacao.Text = "FINALIZADO";
                //tb_obs.Text = tb_obs.Text + " ** Inversão manual parada -> fechamento";
                int linha = dataGridView1.RowCount -2;
                dataGridView1.Rows.Remove(dataGridView1.Rows[linha]);
                dataGridView1.Refresh();
                acertar_cores();
            }
            

        }

        private void btFinalizado_parada_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.RowCount.ToString());
            if (tb_fechamento_data.Text == "")
                MessageBox.Show("Não é possível fazer esta operação pois não existe um fechamento");
            else
            {
                form_nova_parada nova = new form_nova_parada();
                try
                {
                    nova.operador = tb_operador_final.Text;
                    nova.maquina = tb_maquina_final.Text;
                    nova.data = tb_fechamento_data.Text;
                    nova.hora = tb_fechamento_hora.Text;
                    nova.rota = tb_codigo_rota.Text;
                    nova.Show();
                }
                finally
                {
                    tb_operador_final.Text = "";
                    tb_maquina_final.Text = "";
                    //tb_fechamento_data.
                    //tb_fechamento_hora.Text = null;
                    tb_situacao.Text = "PARADA";
                    Atualizar();
                    this.datRotas.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET DATA_FECHAMENTO = null WHERE COD_ROTA_CAMPO = '" + tb_codigo_rota.Text + "'";
                    this.fbConnection1.Open();
                    this.datRotas.UpdateCommand.Connection = fbConnection1;
                    this.datRotas.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datRotas.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET HORA_FECHAMENTO = null WHERE COD_ROTA_CAMPO = '" + tb_codigo_rota.Text + "'";
                    this.fbConnection1.Open();
                    this.datRotas.UpdateCommand.Connection = fbConnection1;
                    this.datRotas.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();


                    int qualquer_rota = Convert.ToInt16(rota_atual);
                    //pois o indice começa com zero
                    dsRotas.Clear();
                    dsParadas.Clear();
                    this.datRotas.SelectCommand.CommandText =
                        "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + qualquer_rota.ToString() + "'";
                    this.fbConnection1.Open();
                    this.datRotas.SelectCommand.Connection = fbConnection1;
                    this.datRotas.SelectCommand.ExecuteNonQuery();
                    datRotas.Fill(ROTAS_CAMPO);
                    this.fbConnection1.Close();
                    //qualquer_rota--; datRotas.Fill(ROTAS_CAMPO);
                    datParadas.Fill(PARADAS);
                    //this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = qualquer_rota;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dsParadas.Tables["PARADAS"];
                    datForn.Fill(FORNECEDORES);
                    acertar_cores();
                    
                }

                acertar_cores();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cbRetrabalho.Checked == true)
            {
                retrabalho = true;
                tb_situacao.Text = "RETRABALHO";
                funcao_retrabalho = tb_funcao.Text;
                rota_retrabalho = tb_codigo_rota.Text;
                operacao_retrabalho = tb_operacao.Text;
                os_sistema_retrabalho = tb_codop.Text;
                os_peca = tb_peca.Text;
                os_retrabalho = tb_retrabalho_rota.Text;
                posicao_retrabalho = tb_n_pdf.Text;
                Atualizar();
                //MessageBox.Show("cheguei no 1 atualizar");
                this.datRotas.InsertCommand.CommandText =
                "INSERT INTO ROTAS_CAMPO (OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, RETRABALHO_ROTA, HORAS_MAQUINA_RODANDO, FUNCAO_ROTA)" +
                "VALUES ('" + operacao_retrabalho + "','" + os_peca + "','" + posicao_retrabalho + "','" + os_sistema_retrabalho + "','" + rota_retrabalho + "', '0', '" + funcao_retrabalho + "')";
                this.fbConnection1.Open();
                this.datRotas.InsertCommand.Connection = fbConnection1;
                this.datRotas.InsertCommand.ExecuteNonQuery();
                //datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();

                dsRotas.Clear();
                this.datRotas.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE RETRABALHO_ROTA = '" + rota_retrabalho + "' AND DATA_ENTRADA IS NULL";
                this.fbConnection1.Open();
                this.datRotas.SelectCommand.Connection = fbConnection1;
                this.datRotas.SelectCommand.ExecuteNonQuery();
                datRotas.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();

                this.datRotas.UpdateCommand.CommandText =
                        "UPDATE ROTAS_CAMPO SET ULTIMO_OPERADOR = '" + operador_atual.ToString() + "' WHERE COD_ROTA_CAMPO = '" + tb_codigo_rota.Text + "'";
                this.fbConnection1.Open();
                this.datRotas.UpdateCommand.Connection = fbConnection1;
                this.datRotas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();


                //this.BindingContext[dsRotas_campo, "ROTAS_CAMPO"].Position = 1000000;
                //this.BindingContext[dsRotas_campo, "ROTAS_CAMPO"].AddNew();
                //tb_rota_atual.Text = rota_retrabalho;
                /*
                this.datRotas_campo.SelectCommand.CommandText =
                "SELECT GEN_ID(GEN_ROTAS_CAMPO_ID, 1) FROM ROTAS_CAMPO";// ORDER BY COD_ROTA_CAMPO DESC";
                this.fbConnection1.Open();
                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                //datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();
               

                tb_operacao.Text = operacao_retrabalho;
                tb_codop.Text = os_sistema_retrabalho;
                tb_retrabalho.Text = rota_retrabalho;
                tb_n_pdf.Text = posicao_retrabalho;
                tb_peca.Text = os_peca;
                
                */

                //Atualizar();
                cbRetrabalho.Checked = false;
            }
            //hora e data vazios

            if (tb_nova_data.Text == "" && tb_nova_hora.Text == "")
            {
                
                //operador vazio
                if (tb_novo_operador.Text == "")
                {
                    data_nova = DateTime.Now.ToShortDateString();
                    hora_nova = DateTime.Now.ToShortTimeString();
                    operador_novo = "00001";
                    maquina_nova = ver_maquina(tb_operacao.Text);
                    
                }
                else
                {
                    data_nova = DateTime.Now.ToShortDateString();
                    hora_nova = DateTime.Now.ToShortTimeString();
                    operador_novo = tb_novo_operador.Text;
                    maquina_nova = ver_maquina(tb_operacao.Text);
                }
                if(tb_novo_itens_conj.Text == "")
                       itens_conj_novo = "1";
                    else
                        itens_conj_novo = tb_novo_itens_conj.Text;
                    
                //MessageBox.Show("chegou no se");
            }
            else
            {
                if (tb_nova_hora.Text == "")
                    tb_nova_hora.Text = "8:00";
                data_nova = tb_nova_data.Text;
                hora_nova = tb_nova_hora.Text;
                if (tb_novo_operador.Text == "")
                    tb_novo_operador.Text = "00001";
                operador_novo = tb_novo_operador.Text;
                if (tb_nova_maquina.Text == "")
                    tb_nova_maquina.Text = ver_maquina(tb_operacao.Text);
                maquina_nova = tb_nova_maquina.Text;
                if(tb_novo_itens_conj.Text == "")
                       itens_conj_novo = "1";
                    else
                        itens_conj_novo = tb_novo_itens_conj.Text;
            
            }
            if (cb_servico_externo.Checked == true)
            {
                //MessageBox.Show("chegou no se");
                if (tb_se.Text == "")
                    tb_se.Text = "0";
                se = true;
                se_horas = tb_se.Text;
                se_onde = tb_forn.Text;
                se_qtde = tb_qtde.Text;
            }
            if (cb_horas_manuais.Checked == true)
            {
                MessageBox.Show("Não é possível dar uma entrada manual no início");
            }
            




            else
            {
                inserir_inicio();
            }
        }
        private void inserir_inicio()
        {

            if (tb_entrada_data.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Já existe, um registro, gostaria de continuar?",
                "Confirma?", MessageBoxButtons.YesNo))
                {
                    tb_entrada_data.Text = data_nova;
                    tb_entrada_hora.Text = hora_nova;
                    tb_operador.Text = operador_novo;
                    tb_maquina_ini.Text = maquina_nova;
                    tb_itens_ini.Text = itens_conj_novo;
                    //serviço externo
                    if (se == true)
                    {
                        cb_se_inicio.Checked = true;
                        tb_horas_se_inicio.Text = se_horas;
                        tb_onde_se_inicio.Text = se_onde;
                        tb_qtde_inicio.Text = se_qtde;

                    }
                    //MessageBox.Show(data_nova + " " + hora_nova + " " + operador_novo +
                      //  " " + maquina_nova + " " + itens_conj_novo);
                }
            }
            else
            {
                tb_entrada_data.Text = data_nova;
                tb_entrada_hora.Text = hora_nova;
                tb_operador.Text = operador_novo;
                tb_maquina_ini.Text = maquina_nova;
                tb_itens_ini.Text = itens_conj_novo;
                tb_situacao.Text = "EM ANDAMENTO";
                if (se == true)
                {
                    cb_se_inicio.Checked = true;
                    tb_horas_se_inicio.Text = se_horas;
                    tb_onde_se_inicio.Text = se_onde;
                    tb_qtde_inicio.Text = se_qtde;
                }
            }
            tb_nova_data.Text = "";
            tb_nova_hora.Text = "";
            tb_nova_maquina.Text = "";
            tb_novo_itens_conj.Text = "";
            tb_novo_operador.Text = "";
            tb_se.Text = "";
            tb_qtde.Text = "";
            tb_forn.Text = "";
            cb_servico_externo.Checked = false;
            if (cb_horas_manuais.Checked == true)
            {
                if (radioParar.Checked == false && radioFinalizar.Checked == false)
                {
                    MessageBox.Show("Nesse caso coloque uma opção: Finalizar ou Parar");
                }
                else
                {
                    DateTime nova_data = Convert.ToDateTime(tb_entrada_data.Text + " " + tb_entrada_hora.Text);
                    DateTime data_post = nova_data.AddHours(Convert.ToDouble(tb_horas_manuais.Text));

                    data_nova = data_post.ToShortDateString();
                    hora_nova = data_post.ToShortTimeString();
                    maquina_nova = tb_maquina_ini.Text;
                    itens_conj_novo = tb_itens_ini.Text;
                    operador_novo = tb_operador.Text;
                    if (radioFinalizar.Checked == true)
                        inserir_fechamento();
                    if (radioParar.Checked == true)
                        inserir_parada();
                }

            }
            se = false;
            acertar_cores();
            //tb_obs.Text = tb_obs.Text + "Inicializado Manualmente";


        }

        private string ver_maquina(string operacao)
        {
            
            if(operacao == "Fresa")
                maq = "F9";
            if(operacao == "Torno")
                maq = "T9";
            if(operacao == "Retífica")
                maq = "R9";
            if(operacao == "CNC (Desbaste)" || operacao == "CNC (Acab.)")
                maq = "C9";
            if(operacao == "Erosão (EWC)")
                maq = "EWC9";
            if(operacao == "Erosão (EDM)")
                maq = "E9";
            return maq;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cb_horas_manuais.Checked == true)
                MessageBox.Show("Não é possível fazer essa operação");
            else
            {
                //hora e data vazios
                if (tb_nova_data.Text == "" || tb_nova_hora.Text == "")
                {
                    //operador vazio
                    if (tb_novo_operador.Text == "")
                    {
                        data_nova = DateTime.Now.ToShortDateString();
                        hora_nova = DateTime.Now.ToShortTimeString();
                        operador_novo = "00001";
                        maquina_nova = ver_maquina(tb_operacao.Text);

                    }
                    else
                    {
                        data_nova = DateTime.Now.ToShortDateString();
                        hora_nova = DateTime.Now.ToShortTimeString();
                        operador_novo = tb_novo_operador.Text;
                        maquina_nova = ver_maquina(tb_operacao.Text);
                    }
                    if (tb_novo_itens_conj.Text == "")
                        itens_conj_novo = "1";
                    else
                        itens_conj_novo = tb_novo_itens_conj.Text;
                }
                else
                {
                    data_nova = tb_nova_data.Text;
                    hora_nova = tb_nova_hora.Text;
                    if (tb_novo_operador.Text == "")
                        tb_novo_operador.Text = "00001";
                    operador_novo = tb_novo_operador.Text;
                    if (tb_nova_maquina.Text == "")
                        tb_nova_maquina.Text = ver_maquina(tb_operacao.Text);
                    maquina_nova = tb_nova_maquina.Text;
                    if (tb_novo_itens_conj.Text == "")
                        itens_conj_novo = "1";
                    else
                        itens_conj_novo = tb_novo_itens_conj.Text;

                }
                inserir_parada();
            }
        }
        public void inserir_parada()
        {
            if (dataGridView1.RowCount > 1)
            {
                //MessageBox.Show(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data"].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data_reinicio"].Value.ToString());
                if (dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data"].Value.ToString() != "" &&
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data_reinicio"].Value.ToString() == "")
                {
                    if (DialogResult.Yes == MessageBox.Show("Já existe uma parada, gostaria de continuar?",
                    "Confirma?", MessageBoxButtons.YesNo))
                    {
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data"].Value = data_nova;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_hora"].Value = hora_nova;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_operador"].Value = operador_novo;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_maquina"].Value = maquina_nova;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_itens_parada"].Value = itens_conj_novo;
                        //tb_itens_ini.Text = itens_conj_novo;
                        //MessageBox.Show(data_nova + " " + hora_nova + " " + operador_novo +
                        //  " " + maquina_nova + " " + itens_conj_novo);
                    }
                }
                else
                {
                    form_nova_parada nova = new form_nova_parada();
                    try
                    {
                        nova.operador = operador_novo;
                        nova.maquina = maquina_nova;
                        nova.data = data_nova;
                        nova.hora = hora_nova;
                        nova.rota = tb_codigo_rota.Text;
                        nova.Show();
                    }
                    finally
                    {
                        tb_situacao.Text = "PARADA";
                        Atualizar();
                        /*
                        this.datRotas.UpdateCommand.CommandText =
                        "UPDATE ROTAS_CAMPO SET DATA_FECHAMENTO = null WHERE COD_ROTA_CAMPO = '" + tb_codigo_rota.Text + "'";
                        this.fbConnection1.Open();
                        this.datRotas.UpdateCommand.Connection = fbConnection1;
                        this.datRotas.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        */

                        //int qualquer_rota = Convert.ToInt16(rota_atual);
                        //pois o indice começa com zero
                        //dsRotas.Clear();
                        dsParadas.Clear();
                        /*
                        this.datRotas.SelectCommand.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + qualquer_rota.ToString() + "'";
                        this.fbConnection1.Open();
                        this.datRotas.SelectCommand.Connection = fbConnection1;
                        this.datRotas.SelectCommand.ExecuteNonQuery();
                        datRotas.Fill(ROTAS_CAMPO);
                        this.fbConnection1.Close();
                         */
                        //qualquer_rota--; datRotas.Fill(ROTAS_CAMPO);
                        datParadas.Fill(PARADAS);
                        //this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = qualquer_rota;
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dsParadas.Tables["PARADAS"];
                        datForn.Fill(FORNECEDORES);
                        acertar_cores();

                    }
                }
            }
            else
            {
                    form_nova_parada nova = new form_nova_parada();
                    try
                    {
                        nova.operador = operador_novo;
                        nova.maquina = maquina_nova;
                        nova.data = data_nova;
                        nova.hora = hora_nova;
                        nova.rota = tb_codigo_rota.Text;
                        nova.Show();
                    }
                    finally
                    {
                        tb_situacao.Text = "PARADA";
                        Atualizar();
                        /*
                        this.datRotas.UpdateCommand.CommandText =
                        "UPDATE ROTAS_CAMPO SET DATA_FECHAMENTO = null WHERE COD_ROTA_CAMPO = '" + tb_codigo_rota.Text + "'";
                        this.fbConnection1.Open();
                        this.datRotas.UpdateCommand.Connection = fbConnection1;
                        this.datRotas.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        */

                        //int qualquer_rota = Convert.ToInt16(rota_atual);
                        //pois o indice começa com zero
                        //dsRotas.Clear();
                        dsParadas.Clear();
                        /*
                        this.datRotas.SelectCommand.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + qualquer_rota.ToString() + "'";
                        this.fbConnection1.Open();
                        this.datRotas.SelectCommand.Connection = fbConnection1;
                        this.datRotas.SelectCommand.ExecuteNonQuery();
                        datRotas.Fill(ROTAS_CAMPO);
                        this.fbConnection1.Close();
                         */
                        //qualquer_rota--; datRotas.Fill(ROTAS_CAMPO);
                        datParadas.Fill(PARADAS);
                        //this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = qualquer_rota;
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dsParadas.Tables["PARADAS"];
                        datForn.Fill(FORNECEDORES);
                        acertar_cores();
                    }
            }
                
            tb_nova_data.Text = "";
            tb_nova_hora.Text = "";
            tb_nova_maquina.Text = "";
            tb_novo_itens_conj.Text = "";
            tb_novo_operador.Text = "";
            
                 
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //hora e data vazios
            if (tb_nova_data.Text == "" || tb_nova_hora.Text == "")
            {
                //operador vazio
                if (tb_novo_operador.Text == "")
                {
                    data_nova = DateTime.Now.ToShortDateString();
                    hora_nova = DateTime.Now.ToShortTimeString();
                    operador_novo = "00001";
                    maquina_nova = ver_maquina(tb_operacao.Text);

                }
                else
                {
                    data_nova = DateTime.Now.ToShortDateString();
                    hora_nova = DateTime.Now.ToShortTimeString();
                    operador_novo = tb_novo_operador.Text;
                    maquina_nova = ver_maquina(tb_operacao.Text);
                }
                if (tb_novo_itens_conj.Text == "")
                    itens_conj_novo = "1";
                else
                    itens_conj_novo = tb_novo_itens_conj.Text;
            }
            else
            {
                data_nova = tb_nova_data.Text;
                hora_nova = tb_nova_hora.Text;
                if (tb_novo_operador.Text == "")
                    tb_novo_operador.Text = "00001";
                operador_novo = tb_novo_operador.Text;
                if (tb_nova_maquina.Text == "")
                    tb_nova_maquina.Text = ver_maquina(tb_operacao.Text);
                maquina_nova = tb_nova_maquina.Text;
                if (tb_novo_itens_conj.Text == "")
                    itens_conj_novo = "1";
                else
                    itens_conj_novo = tb_novo_itens_conj.Text;

            }
            if (cb_horas_manuais.Checked == true)
            {
                try
                {
                    if (dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_parada_final"].Value.ToString() == "Sim")
                        MessageBox.Show("Não é possível fazer esta operação pois existe um Reinício");
                    else
                    {
                        //string operador = Convert.ToString(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_operador"].Value);
                        string maquina = Convert.ToString(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_maquina"].Value);
                        string data_fecha = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data"].Value).ToShortDateString();
                        string hora_fecha = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_hora"].Value).ToShortTimeString();
                        string itens_conj = Convert.ToString(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_itens_parada"].Value);
                        if (itens_conj == "")
                            itens_conj = "1";
                        operador_novo = "00001";
                        maquina_nova = maquina;
                        data_nova = data_fecha;
                        hora_nova = hora_fecha;
                        itens_conj_novo = itens_conj;
                        //tb_situacao.Text = "FINALIZADO";
                        //tb_obs.Text = tb_obs.Text + " ** Inversão manual parada -> fechamento";

                    }
                }
                catch
                {
                    MessageBox.Show("É necessário ter uma parada válida para fazer essa operação");
                }

            }
            if (cb_servico_externo.Checked == true)
            {
                if (tb_se.Text == "")
                    tb_se.Text = "0";
                se = true;
                se_horas = tb_se.Text;
                se_onde = tb_forn.Text;
                se_qtde = tb_qtde.Text;
            }
            inserir_reinicio();
        }
            public void inserir_reinicio()
            {
            if (dataGridView1.RowCount >= 1)
            {
                
                if (dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data"].Value.ToString() != "" &&
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data_reinicio"].Value.ToString() != "")
                {
                    if (DialogResult.Yes == MessageBox.Show("Já existe um reinício, gostaria de continuar?",
                    "Confirma?", MessageBoxButtons.YesNo))
                    {
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_data_reinicio"].Value = data_nova;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_hora_reinicio"].Value = hora_nova;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_operador_reinicio"].Value = operador_novo;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_maquina_reinicio"].Value = maquina_nova;
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_itens_reinicio"].Value = itens_conj_novo;
                        if (se == true)
                        {
                            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_se"].Value = "1";
                            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_horas_se"].Value = se_horas;
                            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_onde_se"].Value = se_onde;
                        }
                        //tb_itens_ini.Text = itens_conj_novo;
                        //MessageBox.Show(data_nova + " " + hora_nova + " " + operador_novo +
                        //  " " + maquina_nova + " " + itens_conj_novo);
                    }

                }
                else
                {
                    update_parada(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells["col_cod_parada"].Value.ToString(), 
                        data_nova, hora_nova, operador_novo, maquina_nova, itens_conj_novo);
                        tb_situacao.Text = "EM ANDAMENTO";
                        Atualizar();
                        dsParadas.Clear();
                        datParadas.Fill(PARADAS);
                        //this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = qualquer_rota;
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dsParadas.Tables["PARADAS"];
                        datForn.Fill(FORNECEDORES);
                        
                }

                if (cb_horas_manuais.Checked == true)
                {
                    if (radioParar.Checked == false && radioFinalizar.Checked == false)
                    {
                        MessageBox.Show("Nesse caso coloque uma opção: Finalizar ou Parar");
                    }
                    else
                    {
                        DateTime nova_data = Convert.ToDateTime(data_nova + " " + hora_nova);
                        DateTime data_post = nova_data.AddHours(Convert.ToDouble(tb_horas_manuais.Text));

                        data_nova = data_post.ToShortDateString();
                        hora_nova = data_post.ToShortTimeString();
                        maquina_nova = tb_maquina_ini.Text;
                        itens_conj_novo = tb_itens_ini.Text;
                        operador_novo = tb_operador.Text;
                        if (radioFinalizar.Checked == true)
                            inserir_fechamento();
                        if (radioParar.Checked == true)
                            inserir_parada();
                    }

                }

                tb_nova_data.Text = "";
                tb_nova_hora.Text = "";
                tb_nova_maquina.Text = "";
                tb_novo_itens_conj.Text = "";
                tb_novo_operador.Text = "";
                tb_se.Text = "";
                tb_qtde.Text = "";
                tb_forn.Text = "";
                cb_servico_externo.Checked = false;
                se = false;
                acertar_cores();

            }
            else
            {
                    MessageBox.Show("Impossível criar um reinício pois não existem paradas");
            }
            
        
        }
        private void update_parada(string cod, string data, string hora, string operador, string maquina, string itens_conj_novo)
        {
            if (se_horas == "")
                se_horas = "0";
            
            this.datParadas.UpdateCommand.CommandText =
                    "UPDATE PARADAS SET DATA_TERMINO = '" + data.Replace("/",".") + "', HORA_TERMINO = '" + 
                    hora + "', OPERADOR_FINALIZADOR_PARADA = '"  + operador + "', " + 
                    "MAQUINA_REINICIO = '" + maquina + "', ITENS_CONJUNTOS_REINICIO = '" +
                    itens_conj_novo + "'  WHERE COD_PARADA = '" + cod + "'";
            this.fbConnection1.Open();
            this.datParadas.UpdateCommand.Connection = fbConnection1;
            this.datParadas.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            if (se == true)
            {
                this.datParadas.UpdateCommand.CommandText =
                    "UPDATE PARADAS SET ONDE_SERVICO_EXTERNO_REINICIO = '" + se_onde + "', HORAS_SERVICO_EXTERNO_REINICIO = '" +
                    se_horas.Replace(",", ".") + "', SERVICO_EXTERNO_REINICIO = '1' WHERE COD_PARADA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datParadas.UpdateCommand.Connection = fbConnection1;
                this.datParadas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();


            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            recalcular_horas();
        }

        private void recalcular_horas()
        {
            //if (cb_servico_externo.Checked != true)
            //{

                if (tb_previsao_semana.Text == "")
                    tb_previsao_semana.Text = "0";
                primeira_semana = 0;
                ultima_semana = 0;
                n_semanas = 0;
               
                    erro = false;
                    
                    primeiro = true;
                    if (tb_entrada_data.Text != "")
                    {//pega o primeiro apontamento
                        abertura_data = Convert.ToDateTime(tb_entrada_data.Text);
                        abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(tb_entrada_hora.Text).ToShortTimeString());
                        em_andamento = true;
                        if (cb_se_inicio.Checked == true)
                        {
                            se_inicio_reinicio = true;
                            try
                            {
                                horas_inicio_reinicio = Convert.ToDouble(tb_horas_se_inicio.Text);
                            }
                            catch { horas_inicio_reinicio = 0; }
                        }
                        for (j = 0; j < (dataGridView1.RowCount - 1); j++)
                        {//percorre as paradas
                            
                            fechamento_data = Convert.ToDateTime(dataGridView1.Rows[j].Cells["col_data"].Value.ToString());
                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dataGridView1.Rows[j].Cells["col_hora"].Value.ToString()).ToShortTimeString());
                            //pega o resultado
                            resultado = fechamento.Subtract(abertura);
                            if (dataGridView1.Rows[j].Cells["col_itens_parada"].Value.ToString() == "")
                                dataGridView1.Rows[j].Cells["col_itens_parada"].Value = "1";
                            transforma = (transforma_dia_horas(resultado.ToString()));
                            int semana_ano = 1 + conferir_semana(fechamento) / 7;
                             
                            //calculo da previsão
                            try
                            {
                                primeira_semana = 1 + conferir_semana(Convert.ToDateTime(tb_ent_prev.Text)) / 7;
                                ultima_semana = 1 + conferir_semana(Convert.ToDateTime(tb_fecha_prev.Text)) / 7;
                                n_semanas = (ultima_semana - primeira_semana) + 1;
                                if (n_semanas < 0)
                                    n_semanas = (53 - primeira_semana) + ultima_semana;
                                if (semana_ano >= primeira_semana && semana_ano <= ultima_semana)
                                {
                                    previsao = Convert.ToDouble(tb_prev.Text) / n_semanas;
                                }
                                else
                                {
                                    previsao = 0;
                                }
                            }
                            catch {
                                //MessageBox.Show("Erro na previsão ou isto é um retrabalho");
                                previsao = 0; }
                            int ano = fechamento.Year;
                            //EM 2028 TEREMOS 54 SEMANAS
                            if (semana_ano > 53 && ano != 2028)
                            {
                                semana_ano = 2;
                                ano = ano + 1;
                                if (ano == 2012 || ano == 2017 || ano == 2023 || ano == 2034 || ano == 2040 || ano == 2045 || ano == 2051)
                                    semana_ano = 1;
                            }
                            if (semana_ano > 54 && ano == 2028)
                            {
                                semana_ano = 2;
                                ano = ano + 1;
                                
                            }
                            //VERIFICAR ISSO NOS ANOS A PARTIR DE 2010

                            if (semana_ano == 1)
                            {
                                if (ano != 2012 || ano != 2017 || ano != 2023 || ano != 2034 || ano != 2040 || ano != 2045 || ano != 2051)
                                {
                                    semana_ano = 53;
                                    ano = ano - 1;
                                }
                            }
                            //MessageBox.Show("1 " + transforma.ToString());
                            try
                            {

                                semana_atual = 1 + conferir_semana(fechamento) / 7;
                            }
                            catch { }
                            dsHoras_semana.Clear();
                            this.datHoras_semana.SelectCommand.CommandText =
                               "SELECT * FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + tb_codigo_rota.Text + "'" +
                               "AND N_SEMANA = '" + semana_atual.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                            this.fbConnection1.Open();
                            this.datHoras_semana.SelectCommand.Connection = fbConnection1;
                            this.datHoras_semana.SelectCommand.ExecuteNonQuery();
                            datHoras_semana.Fill(HORAS_SEMANA);
                            this.fbConnection1.Close();
                            if (tb_previsao_semana.Text == "")
                                tb_previsao_semana.Text = "0";
                            try
                            {
                                previsao = Convert.ToDouble(tb_previsao_semana.Text);
                            }
                            catch
                            {
                                previsao = 0;
                            }
                            double horas_trabalhadas = transforma / Convert.ToInt32(dataGridView1.Rows[j].Cells["col_itens_parada"].Value.ToString());
                            if (se_inicio_reinicio == true)
                                horas_trabalhadas = horas_inicio_reinicio;
                            inserir_nas_semanas(ano, semana_ano, horas_trabalhadas.ToString("n2"),
                                tb_codigo_rota.Text, previsao.ToString("n2").Replace(",","."));
                            previsao = 0;
                            if (transforma >= 24)
                                //se transforma > 24, isto é.. houve alguma erro no apontamento
                                erro = true;
                            total_horas_operador = total_horas_operador + horas_trabalhadas;
                            em_andamento = false;
                            if (dataGridView1.Rows[j].Cells["col_data_reinicio"].Value.ToString() != "" && em_andamento == false)
                            {//se tiver um reinicio
                                abertura_data = Convert.ToDateTime(dataGridView1.Rows[j].Cells["col_data_reinicio"].Value.ToString());
                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dataGridView1.Rows[j].Cells["col_hora_reinicio"].Value.ToString()).ToShortTimeString());
                                em_andamento = true;
                                if (dataGridView1.Rows[j].Cells["col_se"].Value.ToString() == "1")
                                {
                                    se_inicio_reinicio = true;
                                    try
                                    {
                                        horas_inicio_reinicio = Convert.ToDouble(dataGridView1.Rows[j].Cells["col_horas_se"].Value.ToString());
                                    }
                                    catch { horas_inicio_reinicio = 0; }
                                }
                                else
                                    se_inicio_reinicio = false;
                            }

                        }


                        if (em_andamento == true)
                        {
                            if (tb_fechamento_data.Text == "")
                            {
                                fechamento = DateTime.Now;
                                em_andamento = false;
                            }
                            else
                            {
                                //vou calcular o ultimo reinicio e a hora de fechamento
                                fechamento_data = Convert.ToDateTime(tb_fechamento_data.Text);
                                try
                                {
                                    fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(tb_fechamento_hora.Text).ToShortTimeString());
                                }
                                catch { }
                                em_andamento = false;
                            }
                            if (tb_itens_fecha.Text == "")
                                tb_itens_fecha.Text = "1";
                            resultado = fechamento.Subtract(abertura);
                            transforma = (transforma_dia_horas(resultado.ToString()));
                            int semana_ano = 1 + conferir_semana(fechamento) / 7;
                            int ano = fechamento.Year;
                            
                            
                               
                             
                                try
                                {

                                    primeira_semana = 1 + conferir_semana(Convert.ToDateTime(tb_ent_prev.Text)) / 7;
                                    ultima_semana = 1 + conferir_semana(Convert.ToDateTime(tb_fecha_prev.Text)) / 7;
                                    n_semanas = (ultima_semana - primeira_semana) + 1;
                                    if (n_semanas < 0)
                                        n_semanas = (53 - primeira_semana) + ultima_semana;
                                    //tenho que colocar essa condições para ele pegar a previsão quando 
                                    if (semana_ano >= primeira_semana && (semana_ano <= ultima_semana))// || ((semana_ano < 53 && semana_ano > 48) && (ultima_semana > 1 ultima_semana < 5))  )
                                    {
                                        previsao = Convert.ToDouble(tb_prev.Text) / n_semanas;



                                    }
                                    else
                                    {
                                        //se foi feito antes
                                        if (semana_ano < primeira_semana)
                                        {
                                            previsao = Convert.ToDouble(tb_prev.Text);
                                        }
                                    }
                                }


                                catch {
                                    //MessageBox.Show("Erro na previsão");
                                    previsao = 0; }
                            //MessageBox.Show("2 " + transforma.ToString());
                            if (semana_ano > 53)
                            {
                                semana_ano = 2;
                                ano = ano + 1;
                            }
                            //VERIFICAR ISSO NOS ANOS A PARTIR DE 2010

                            if (semana_ano == 1)
                            {
                                semana_ano = 53;
                                ano = ano - 1;
                            }
                            try
                            {
                                
                                semana_atual = 1 + conferir_semana(Convert.ToDateTime(tb_fechamento_data.Text)) / 7;
                            }
                            catch {
                                semana_atual = 1 + conferir_semana(fechamento) / 7;
                            }
                            dsHoras_semana.Clear();
                            this.datHoras_semana.SelectCommand.CommandText =
                               "SELECT * FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + tb_codigo_rota.Text + "'" +
                               "AND N_SEMANA = '" + semana_atual.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                            this.fbConnection1.Open();
                            this.datHoras_semana.SelectCommand.Connection = fbConnection1;
                            this.datHoras_semana.SelectCommand.ExecuteNonQuery();
                            datHoras_semana.Fill(HORAS_SEMANA);
                            this.fbConnection1.Close();

                            //previsao = conferir_previsao(primeira_semana, ultima_semana, semana_ano, previsao);
                            try
                            {
                                previsao = Convert.ToDouble(tb_previsao_semana.Text);
                            }
                            catch
                            {
                                previsao = 0;
                            }
                            double horas_trabalhadas = transforma / Convert.ToInt32(tb_itens_fecha.Text);
                            if (se_inicio_reinicio == true)
                                horas_trabalhadas = horas_inicio_reinicio;
                            inserir_nas_semanas(ano, semana_ano,
                                horas_trabalhadas.ToString("n2"),
                                tb_codigo_rota.Text, previsao.ToString("n2").Replace(",","."));
                            previsao = 0;
                            /*
                            if (dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() == "11544")
                            {
                                MessageBox.Show(transforma.ToString());
                            }
                            */
                            if (transforma >= 24)
                                erro = true;
                            total_horas_operador = total_horas_operador + horas_trabalhadas;
                            se_inicio_reinicio = false;
                        }
                        
                        

                    }
                    try
                    {
                        //somar as horas máquina rodando
                        //total_horas_operador = total_horas_operador + Convert.ToDouble(tb_horas_manuais_reais.Text);
                    }
                    catch
                    {

                    }
                    //}
                    em_andamento = false;
               /// }
               /// catch
              ///  {

                    //MessageBox.Show("Erro na linha " + i.ToString());
             ///       fbConnection1.Close();
             ///   }

                tb_horas_trab.Text = total_horas_operador.ToString("n2");
                total_horas_operador = 0;
                if (tb_situacao.Text == "FINALIZADO")
                    apagar_das_semanas();
            //}
            /*
            else
            {
                primeiro = true;
                if (tb_situacao.Text == "FINALIZADO")
                {
                    fechamento_data = Convert.ToDateTime(tb_fechamento_data.Text);
                    try
                    {
                        fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + tb_fechamento_hora.Text);
                    }
                    catch { }
                    em_andamento = false;

                    if (tb_itens_fecha.Text == "")
                        tb_itens_fecha.Text = "1";
                    //resultado = 
                    transforma = Convert.ToDouble(tb_horas_trab.Text);
                    int semana_ano = 1 + conferir_semana(fechamento) / 7;
                    int ano = fechamento.Year;
                     
                    
                    try
                    {
                        primeira_semana = 1 + conferir_semana(Convert.ToDateTime(tb_ent_prev.Text)) / 7;
                        ultima_semana = 1 + conferir_semana(Convert.ToDateTime(tb_fecha_prev.Text)) / 7;
                    }
                    catch
                    {
                        
                        primeira_semana = 1 + conferir_semana(Convert.ToDateTime(tb_entrada_data.Text)) / 7;
                        ultima_semana = 1 + conferir_semana(Convert.ToDateTime(tb_fechamento_data.Text)) / 7;
                    }
                    int n_semanas = (ultima_semana - primeira_semana) + 1;
                    if (n_semanas < 0)
                        n_semanas = (53 - primeira_semana) + ultima_semana;
                    if (semana_ano > 53)
                    {
                        semana_ano = 2;
                        ano = ano + 1;
                    }
                    //VERIFICAR ISSO NOS ANOS A PARTIR DE 2010

                    if (semana_ano == 1)
                    {
                        semana_ano = 53;
                        ano = ano - 1;
                    }
                    dsHoras_semana.Clear();
                    
                    try
                    {

                        semana_atual = 1 + conferir_semana(Convert.ToDateTime(tb_fechamento_data.Text)) / 7;
                    }
                    catch { }
                    
                    this.datHoras_semana.SelectCommand.CommandText =
                       "SELECT * FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + tb_codigo_rota.Text + "'" +
                       "AND N_SEMANA = '" + semana_atual.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                    this.fbConnection1.Open();
                    this.datHoras_semana.SelectCommand.Connection = fbConnection1;
                    this.datHoras_semana.SelectCommand.ExecuteNonQuery();
                    datHoras_semana.Fill(HORAS_SEMANA);
                    this.fbConnection1.Close();
                    if (tb_previsao_semana.Text == "")
                        tb_previsao_semana.Text = "0";
                    previsao = Convert.ToDouble(tb_previsao_semana.Text);
                    //previsao = conferir_previsao(primeira_semana, ultima_semana, semana_ano, previsao);
                    semana_atual = 0;
                    //MessageBox.Show(previsao.ToString());
                    inserir_nas_semanas(ano, semana_ano,
                        Convert.ToString((transforma / Convert.ToInt32(tb_itens_fecha.Text))),
                        tb_codigo_rota.Text, previsao.ToString("n2").Replace(",","."));

                    apagar_das_semanas();
                    previsao = 0;
                }
                else
                {


                }
            }
        */

            
        }

        private double conferir_previsao(int semana_inicial, int semana_final, int semana_finalizacao, double horas_por_semana)
        {
            
            if(tb_previsao_semana.Text == "")
                tb_previsao_semana.Text = "0";

            int semanas_restantes = semana_final - semana_finalizacao;
            
                if (semana_final > semana_finalizacao)
                {
                    previsao_correta = Convert.ToDouble(tb_previsao_semana.Text) + (semanas_restantes * horas_por_semana);

                }
                else
                {
                    previsao_correta = Convert.ToDouble(tb_previsao_semana.Text);
                }
            
            
            return previsao_correta;
        }
         
        private void apagar_das_semanas()
          
        {
            if (tb_situacao.Text == "FINALIZADO")
            {
                this.datHoras_semana.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE ROTA_HORAS_SEMANA = '" + tb_codigo_rota.Text + "' AND (HORAS_REAIS_OPERACAO IS NULL OR HORAS_REAIS_OPERACAO = 0) AND DATA_EXCLUSAO_SEMANA IS NULL AND OPERACAO_SEMANA != 'Têmpera'";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datHoras_semana.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'ROTA 1' WHERE ROTA_HORAS_SEMANA = '" + tb_codigo_rota.Text + "' AND (HORAS_REAIS_OPERACAO IS NULL OR HORAS_REAIS_OPERACAO = 0) AND DATA_EXCLUSAO_SEMANA IS NULL AND OPERACAO_SEMANA != 'Têmpera'";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                /*
                this.datHoras_semana.DeleteCommand.CommandText =
                        "DELETE FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + tb_codigo_rota.Text + "' AND HORAS_REAIS_OPERACAO IS NULL OR HORAS_REAIS_OPERACAO = 0";
                this.fbConnection1.Open();
                this.datHoras_semana.DeleteCommand.Connection = fbConnection1;
                this.datHoras_semana.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                 * */

            }

        }

        private void inserir_nas_semanas(int ano, int semana, string horas, string rotas, string previsao)
        {
            
            //if (cb_servico_externo.Checked == true)
              //  horas = tb_se.Text;
            if (horas == "")
                horas = "0.0";
            //MessageBox.Show(semana.ToString() + " " + ano.ToString() + " " + horas.ToString());
            if (primeiro == true)
            {
                this.datHoras_semana.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = 0" +
                        " WHERE ROTA_HORAS_SEMANA = '" + rotas +
                        "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                //MessageBox.Show("zerado");
                primeiro = false;
            }

            //MessageBox.Show("update");
            
            this.datHoras_semana.UpdateCommand.CommandText =
                       "UPDATE HORAS_SEMANA SET HORAS_OPERACAO_SEMANA = '" + previsao.Replace(",",".")  +
                       "' WHERE ROTA_HORAS_SEMANA = '" + rotas +
                       "' AND N_SEMANA = '" + semana.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
            this.fbConnection1.Open();
            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
            //this.datSemanas.UpdateCommand.ExecuteNonQuery();
            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datHoras_semana.UpdateCommand.CommandText =
                       "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = (HORAS_REAIS_OPERACAO + " + horas.Replace(",", ".") +
                       ") WHERE ROTA_HORAS_SEMANA = '" + rotas +
                       "' AND N_SEMANA = '" + semana.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
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
                    ent_prev = Convert.ToDateTime(tb_ent_prev.Text).ToShortDateString().Replace("/", ".");
                }
                catch { }
                try
                {
                    sai_prev = Convert.ToDateTime(tb_fecha_prev.Text).ToShortDateString().Replace("/", ".");
                }

                catch { }
                if (ent_prev == null || sai_prev == null)
                {
                    if (tb_prev.Text == "")
                        tb_prev.Text = "0";
                    this.datHoras_semana.InsertCommand.CommandText =
                        "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA," +
                        "HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, SITUACAO_ROTA_SEMANA, HORAS_REAIS_OPERACAO)" +
                        "VALUES ('" + semana + "','" + ano + "','" +
                        tb_operacao.Text + "','" +
                        tb_codigo_rota.Text + "','" +
                        previsao + "','" +
                        tb_peca.Text + "','" +
                        tb_n_pdf.Text + "','" +
                        tb_situacao.Text + "','" +
                        horas.Replace(",", ".") + "')";
                    this.fbConnection1.Open();
                    this.datHoras_semana.InsertCommand.Connection = fbConnection1;
                    this.datHoras_semana.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }

                else
                {
                    if (tb_funcao.Text != "Projeto")
                    {
                        if (tb_prev.Text == "")
                            tb_prev.Text = "0";
                        this.datHoras_semana.InsertCommand.CommandText =
                            "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA," +
                            "HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, SITUACAO_ROTA_SEMANA, DATA_INICIO_SEMANA, " +
                            "DATA_FIM_SEMANA, HORAS_REAIS_OPERACAO)" +
                            "VALUES ('" + semana + "','" + ano + "','" +
                            tb_operacao.Text + "','" +
                            tb_codigo_rota.Text + "','" +
                            previsao + "','" +
                            tb_peca.Text + "','" +
                            tb_n_pdf.Text + "','" +
                            tb_situacao.Text + "','" +
                            ent_prev + "','" +
                            sai_prev + "','" +
                            horas.Replace(",", ".") + "')";
                        this.fbConnection1.Open();
                        this.datHoras_semana.InsertCommand.Connection = fbConnection1;
                        this.datHoras_semana.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                }


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
                if (total_horas_operador_parcial > 24)
                    total_horas_operador_parcial = 0;
                return total_horas_operador_parcial;
                zera_variaveis();
            }
            else
            {
                horas_dias = (var_dias * 24) + var_horas;
                total_horas_str = horas_dias.ToString() + "," + "00";
                total_horas_operador_parcial = Convert.ToDouble(total_horas_str);
                return total_horas_operador_parcial;
                if (total_horas_operador_parcial > 24)
                    total_horas_operador_parcial = 0;
                zera_variaveis();
            }

        }
        
        private void zera_variaveis()
        {
            separa_dias = "";
            separa_horas = "";
            separa_minutos = "";
            minutos_decimais = 0;
            total_horas_str = "";
            horas_dias = 0;
            k = 0;
            
            total_horas_operador_parcial = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            form_localiza_forn localiza_forn = new form_localiza_forn(true);
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {
                localiza_forn.Dispose();
                tb_forn.Text = localiza_forn.razao_forn_escolhido;
               

            }
        }

        private void tb_operacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (tb_fechamento_data.Text == "")
                MessageBox.Show("Não é possível fazer esta operação pois não existe um fechamento");
            else
            {
                    tb_operador_final.Text = "";
                    tb_maquina_final.Text = "";
                    //tb_fechamento_data.
                    tb_fechamento_hora.Text = "";
                    tb_situacao.Text = "EM ANDAMENTO";
                    Atualizar();
                    this.datRotas.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET DATA_FECHAMENTO = null WHERE COD_ROTA_CAMPO = '" + tb_codigo_rota.Text + "'";
                    this.fbConnection1.Open();
                    this.datRotas.UpdateCommand.Connection = fbConnection1;
                    this.datRotas.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();


                    int qualquer_rota = Convert.ToInt16(tb_codigo_rota.Text);
                    //pois o indice começa com zero
                    dsRotas.Clear();
                    dsParadas.Clear();
                    this.datRotas.SelectCommand.CommandText =
                        "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + qualquer_rota.ToString() + "'";
                    this.fbConnection1.Open();
                    this.datRotas.SelectCommand.Connection = fbConnection1;
                    this.datRotas.SelectCommand.ExecuteNonQuery();
                    datRotas.Fill(ROTAS_CAMPO);
                    this.fbConnection1.Close();
                    //qualquer_rota--; datRotas.Fill(ROTAS_CAMPO);
                    datParadas.Fill(PARADAS);
                    //this.BindingContext[dsRotas, "ROTAS_CAMPO"].Position = qualquer_rota;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dsParadas.Tables["PARADAS"];
                    datForn.Fill(FORNECEDORES);
                    acertar_cores();

                
            }
        
        }


    }
}