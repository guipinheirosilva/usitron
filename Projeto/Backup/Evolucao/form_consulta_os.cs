using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml;
namespace Evolucao
{
    public partial class form_consulta_os : Form
    {
        //VARIAVEIS GRAFICO ISO
        double hp_jan, hp_fev, hp_mar, hp_abr, hp_mai, hp_jun, hp_jul, hp_ago, hp_set, hp_out, hp_nov, hp_dez;
        double hr_jan, hr_fev, hr_mar, hr_abr, hr_mai, hr_jun, hr_jul, hr_ago, hr_set, hr_out, hr_nov, hr_dez;
        double porc_jan, porc_fev, porc_mar, porc_abr, porc_mai, porc_jun, porc_jul, porc_ago, porc_set, porc_out, porc_nov, porc_dez;


        bool ja_calculou;
        int rota_das_paradas;
        double total_horas_maq;
        bool consulta_operador;
        bool consulta_maquina;
        string ent_prev;
        string sai_prev;
        //variaveis do transforma dias hora
        bool erro;
        bool primeiro;
        double transforma;
        int n_paradas;
        double horas_parciais;
        private string separa_dias;
        private string separa_horas;
        private string separa_minutos;
        private double minutos_decimais;
        int rota_atual;
        bool operacao_ja_somada;
        private string total_horas_str;
        private int horas_dias;
        private int k;
        DateTime abertura_data;
        DateTime abertura_hora;
        DateTime abertura_data_confere;
        DateTime abertura_hora_confere;
        DateTime abertura_data_anterior_confere;
        DateTime abertura_hora_anterior_confere;
        DateTime fechamento_data_confere;
        DateTime fechamento_hora_confere;
        DateTime fechamento_data_posterior_confere;
        DateTime fechamento_hora_posterior_confere;
        DateTime reinicio_parada_data_anterior_confere;
        DateTime reinicio_parada_hora_anterior_confere;
        DateTime reinicio_parada_data_confere;
        DateTime reinicio_parada_hora_confere;
        DateTime abertura_parada_data_posterior_confere;
        DateTime abertura_parada_hora_posterior_confere;
        DateTime abertura_parada_data_confere;
        DateTime abertura_parada_hora_confere;
        DateTime date_now_confere;
        public int [] cod_rota_consultados = new int [50000];
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
        public form_consulta_os()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioTotalhoras_CheckedChanged(object sender, EventArgs e)
        {
            opcoes = 1;
        }

        private void radioOperacoes_finalizadas_CheckedChanged(object sender, EventArgs e)
        {
            opcoes = 2;
        }

        private void radioOperacoes_previstas_CheckedChanged(object sender, EventArgs e)
        {
            opcoes = 3;
        }

        private void radioOperacoes_atrasadas_CheckedChanged(object sender, EventArgs e)
        {
            opcoes = 4;
        }

        private void form_consulta_os_Load(object sender, EventArgs e)
        {
            //dgvConsulta.AutoGenerateColumns = false;
            dgvConsulta.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
            dgvParadas.AutoGenerateColumns = false;
            dgvParadas.DataSource = dsParadas.Tables["PARADAS"];

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (tb_operador.Text == "*")
            {
                form_localiza_operador operador1 = new form_localiza_operador();
                try
                {
                    operador1.atualizar_arquivo = true;
                    operador1.ShowDialog();
                }
                finally
                {
                    try
                    {
                        operador1.Dispose();

                    }

                    catch { }


                }
                this.datConsulta_oper.DeleteCommand.CommandText =
                "DELETE FROM CONSULTA_OPER WHERE COD_CONSULTA_OPER IS NOT NULL";
                this.fbConnection1.Open();
                this.datConsulta_oper.DeleteCommand.Connection = fbConnection1;
                this.datConsulta_oper.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                while (parar_consulta == false)
                {
                    string caminho = "c:/evolucao/operadores2.txt";
                    StreamReader objReader = new StreamReader(caminho);
                    string sLine = "";
                    ArrayList arrText = new ArrayList();

                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();
                        if (sLine != null)
                            arrText.Add(sLine);
                    }
                    objReader.Close();

                    foreach (string sOutput in arrText)
                    {
                        int i = 0;
                        string operador = "";
                        string nome_operador = "";
                        for (i = 0; i < 2; i++)
                        {
                            operador = operador + sOutput[i];

                        }
                        i = 3;
                        try
                        {
                            while (sOutput[i].ToString() != "\t")
                            {
                                nome_operador = nome_operador + sOutput[i];
                                i++;
                            }
                        }
                        catch
                        {

                        }
                        tb_operador.Text = operador;
                        this.Cursor = Cursors.WaitCursor;
                        consulta_opcoes();
                        //consulta_ponto();
                        string subs_virgula_sist = tb_total_operador.Text.Replace("," , ".");
                        string subs_virgula_ponto = "";// horas_operador_ponto.Replace(",", ".");

                        this.datConsulta_oper.InsertCommand.CommandText =
                        "INSERT INTO CONSULTA_OPER (OPERADOR_CONSULTA_OPER, HORAS_SIST_OPER, NOME_OPERADOR_OPER)" +
                        "VALUES ('" + operador + "','" + subs_virgula_sist + "','" + nome_operador + "')";
                        this.fbConnection1.Open();
                        this.datConsulta_oper.InsertCommand.Connection = fbConnection1;
                        this.datConsulta_oper.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        this.Cursor = Cursors.Default;
                        

                    }
                    parar_consulta = true;


                }
                imprimir_relat_func();
            }
            else
            {
                consulta_opcoes();
            }
            Atualizar();
            acertar_externos();
        }
        private void consulta_opcoes()
        {
            switch (opcoes)
            {
                case 1:
                    //Consulta por Máquina
                    if (tb_peca.Text == "" && tb_maquina.Text != "" && cb_operacao.Text == "")
                    {
                        consulta_maquina = true;
                        if (cbUm_dia.Checked == true)
                        {

                            this.datRotas_campo.SelectCommand.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE (UPPER(MAQUINA) LIKE UPPER('" + tb_maquina.Text + "'))" +
                             " AND ((DATA_ENTRADA = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " OR DATA_ENTRADA = '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                             " OR (DATA_FECHAMENTO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " OR DATA_FECHAMENTO = '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))" +
                             " ORDER BY COD_ROTA_CAMPO";

                            this.datMaquinas_rodando.SelectCommand.CommandText =
                            "SELECT * FROM MAQUINA_RODANDO WHERE UPPER(MAQUINA_ATUAL) LIKE UPPER('" + tb_maquina.Text + "')" +
                            " AND ((DATA_MAQUINA_TRABALHANDO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " OR DATA_MAQUINA_TRABALHANDO = '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))";
                            
                            this.datParadas.SelectCommand.CommandText =
                            "SELECT * FROM PARADAS WHERE (UPPER(MAQUINA_PARADA) LIKE UPPER('" + tb_maquina.Text + "'))" +
                             " AND (((DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " OR DATA_INICIO = '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                             " OR (DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " OR DATA_TERMINO = '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')) " +
                             " OR ((DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " OR DATA_INICIO = '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                             " OR (DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " OR DATA_TERMINO = '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))) " +
                             " ORDER BY COD_PARADA";

                            
                        }
                        else
                        {
                            if (dtFinal.Value != dtInicial.Value)
                            {
                                this.datRotas_campo.SelectCommand.CommandText =
                                "SELECT * FROM ROTAS_CAMPO WHERE (((UPPER(MAQUINA) LIKE UPPER('" + tb_maquina.Text + "')) OR (UPPER(MAQUINA_FECHAMENTO) LIKE UPPER('" + tb_maquina.Text + "')))" +
                             " AND ((DATA_ENTRADA >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND DATA_ENTRADA <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                             " OR (DATA_FECHAMENTO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND DATA_FECHAMENTO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')))" +
                             " ORDER BY COD_ROTA_CAMPO";

                                this.datMaquinas_rodando.SelectCommand.CommandText =
                                "SELECT * FROM MAQUINA_RODANDO WHERE UPPER(MAQUINA_ATUAL) LIKE UPPER('" + tb_maquina.Text + "')" +
                                " AND ((DATA_MAQUINA_TRABALHANDO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                " OR DATA_MAQUINA_TRABALHANDO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))";

                                //this.datParadas.SelectCommand.CommandText =
                                //"SELECT * FROM PARADAS ORDER BY COD_PARADA";
                                
                                this.datParadas.SelectCommand.CommandText =
                                "SELECT * FROM PARADAS WHERE " + //((UPPER(MAQUINA_PARADA) LIKE UPPER('" + tb_maquina.Text + "')) OR (UPPER(MAQUINA_REINICIO) LIKE UPPER('" + tb_maquina.Text + "')))" +
                                 //" AND ((
                                 " ((DATA_INICIO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                 " AND DATA_INICIO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                                 " OR (DATA_TERMINO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                 " AND DATA_TERMINO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))" +
                                 " ORDER BY COD_PARADA";
                                 
                            }
                            else
                            {
                                if (cbTodas_datas.Checked == true)
                                {
                                    this.datRotas_campo.SelectCommand.CommandText =
                                        "SELECT * FROM ROTAS_CAMPO WHERE UPPER(MAQUINA) LIKE UPPER('" + tb_maquina.Text + "') ORDER BY COD_ROTA_CAMPO";
                                    this.datMaquinas_rodando.SelectCommand.CommandText =
                                        "SELECT * FROM MAQUINA_RODANDO WHERE UPPER(MAQUINA_ATUAL) LIKE UPPER('" + tb_maquina.Text + "')";
                                    this.datParadas.SelectCommand.CommandText =
                                        "SELECT * FROM PARADAS WHERE (UPPER(MAQUINA_PARADA) LIKE UPPER('" + tb_operador.Text + "')) ORDER BY COD_PARADA";
                                     

                                }
                            }
                        }
                   }
                    //Consulta por operador
                    if (tb_peca.Text == "" && tb_operador.Text != "" && cb_operacao.Text == "")
                    {
                        consulta_operador = true;
                        if (cbUm_dia.Checked == true)
                        {
                            dsRotas_campo.Clear();
                            this.datRotas_campo.SelectCommand.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE (UPPER(OPERADOR_CAMPO) LIKE UPPER('" + tb_operador.Text + "') OR UPPER(OPERADOR_FINALIZADOR) LIKE UPPER('" + tb_operador.Text + "'))" +
                             " AND ((((DATA_ENTRADA = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" +
                             " AND HORA_ENTRADA > '05:00:00')" + 
                             " OR (DATA_ENTRADA = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" + 
                             " AND HORA_ENTRADA < '05:00:00'))" + 
                             " OR ((DATA_FECHAMENTO = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" +
                             " AND HORA_FECHAMENTO > '05:00:00')" + 
                             " OR (DATA_FECHAMENTO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" +
                             " AND HORA_FECHAMENTO < '05:00:00')))" + 
                             " OR(((DATA_ENTRADA = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" +
                             " AND HORA_ENTRADA > '5:00:00')" + 
                             " OR (DATA_ENTRADA = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" + 
                             " AND HORA_ENTRADA < '5:00:00'))" + 
                             " OR ((DATA_FECHAMENTO = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" +
                             " AND HORA_FECHAMENTO > '5:00:00')" + 
                             " OR (DATA_FECHAMENTO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" +
                             " AND HORA_FECHAMENTO < '5:00:00'))))" + 
                             " ORDER BY COD_ROTA_CAMPO";
                            dsParadas.Clear();
                            this.datParadas.SelectCommand.CommandText =
                            "SELECT * FROM PARADAS WHERE (UPPER(OPERADOR) LIKE UPPER('" + tb_operador.Text + "') OR UPPER(OPERADOR_FINALIZADOR_PARADA) LIKE UPPER('" + tb_operador.Text + "'))" +
                             " AND ((((DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" +//.Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND HORA_INICIO > '05:00:00')" + 
                             " OR (DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" +  //.Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" + 
                             " AND HORA_INICIO < '05:00:00'))" + 
                             " OR ((DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" + //.Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND HORA_TERMINO > '05:00:00')" + 
                             " OR (DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "' " +//.Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')) " + 
                             " AND HORA_TERMINO < '05:00:00')))" + 
                             
                             " OR(((DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" +//.Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND HORA_INICIO > '5:00:00')" + 
                             " OR (DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" +  //.Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" + 
                             " AND HORA_INICIO < '5:00:00'))" + 
                             " OR ((DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).ToShortDateString().Replace("/", ".") + "'" + //.Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND HORA_TERMINO > '5:00:00')" + 
                             " OR (DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "' " +//.Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')) " + 
                             " AND HORA_TERMINO < '5:00:00'))))" + 
                            // " OR (((DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" +//.Month + "/" + Convert.ToDateTime(dtInicial.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             //" OR DATA_INICIO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "')" + //.Month + "/" + Convert.ToDateTime(dtFinal.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" + 
                            // " OR (DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'" + //.Month + "/" + Convert.ToDateTime(dtInicial.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                            // " OR DATA_TERMINO = '" + Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "'))) " +//.Month + "/" + Convert.ToDateTime(dtFinal.Value).AddDays(1).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))) " + 
                             " ORDER BY COD_PARADA";


                        }
                        else
                        {
                            if (dtFinal.Value != dtInicial.Value)
                            {
                                this.datRotas_campo.SelectCommand.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE (UPPER(OPERADOR_CAMPO) LIKE UPPER('" + tb_operador.Text + "') OR UPPER(OPERADOR_FINALIZADOR) LIKE UPPER('" + tb_operador.Text + "'))" +
                             " AND ((DATA_ENTRADA >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND DATA_ENTRADA <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                             " OR (DATA_FECHAMENTO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND DATA_FECHAMENTO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))" +
                             " ORDER BY COD_ROTA_CAMPO";

                                this.datParadas.SelectCommand.CommandText =
                                "SELECT * FROM PARADAS WHERE (UPPER(OPERADOR) LIKE UPPER('" + tb_operador.Text + "') OR UPPER(OPERADOR_FINALIZADOR_PARADA) LIKE UPPER('" + tb_operador.Text + "'))" +
                                 " AND ((DATA_INICIO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                 " AND DATA_INICIO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                                 " OR (DATA_TERMINO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                 " AND DATA_TERMINO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))" +
                                 " ORDER BY COD_PARADA";
                            }
                            else
                            {
                                if (cbTodas_datas.Checked == true)
                                {
                                    this.datRotas_campo.SelectCommand.CommandText =
                                        "SELECT * FROM ROTAS_CAMPO WHERE UPPER(OPERADOR_CAMPO) LIKE UPPER('" + tb_operador.Text + "') OR UPPER(OPERADOR_FINALIZADOR) LIKE UPPER('" + tb_operador.Text + "') ORDER BY COD_ROTA_CAMPO";

                                    this.datParadas.SelectCommand.CommandText =
                                        "SELECT * FROM PARADAS WHERE UPPER(OPERADOR) LIKE UPPER('" + tb_operador.Text + "') OR UPPER(OPERADOR_FINALIZADOR_PARADA) LIKE UPPER('" + tb_operador.Text + "') ORDER BY COD_PARADA";
                                }
                            }
                        }

                   }
                   

                    //por os e operação
                   if (tb_peca.Text != "" && cb_operacao.Text != "" && cbTodas_datas.Checked == true)
                   {
                       if (cb_operacao.Text == "Erosão")
                           operacao_atual = "E_";
                       if (cb_operacao.Text == "Erosão a fio")
                           operacao_atual = "EWC%";
                       if (cb_operacao.Text == "Fresa")
                           operacao_atual = "F%";
                       if (cb_operacao.Text == "Torno")
                           operacao_atual = "T%";
                       if (cb_operacao.Text == "CNC")
                           operacao_atual = "C%";
                       if (cb_operacao.Text == "Retífica")
                           operacao_atual = "R%";
                       this.datRotas_campo.SelectCommand.CommandText =
                       "SELECT * FROM ROTAS_CAMPO WHERE ((UPPER(DESENHO_CAMPO) LIKE UPPER ('" + tb_peca.Text + "%')) AND " +
                       " ((UPPER(MAQUINA) LIKE UPPER ('" + operacao_atual + "')) OR (UPPER(MAQUINA_FECHAMENTO) LIKE UPPER ('" + operacao_atual + "')))) ORDER BY COD_ROTA_CAMPO ";

                       this.datParadas.SelectCommand.CommandText =
                           "SELECT * FROM PARADAS WHERE ((UPPER(MAQUINA_PARADA) LIKE UPPER ('" + operacao_atual + "%')) OR (UPPER(MAQUINA_REINICIO) LIKE UPPER ('" + operacao_atual + "%'))) ORDER BY COD_PARADA ";

                       this.datMaquinas_rodando.SelectCommand.CommandText =
                           "SELECT * FROM MAQUINA_RODANDO";


                   }
                   

                   if (tb_peca.Text != "" && cb_operacao.Text != "" && cbTodas_datas.Checked == false)
                   {
                       if (cb_operacao.Text == "Erosão")
                           operacao_atual = "E_";
                       if (cb_operacao.Text == "Erosão a fio")
                           operacao_atual = "EWC%";
                       if (cb_operacao.Text == "Fresa")
                           operacao_atual = "F%";
                       if (cb_operacao.Text == "Torno")
                           operacao_atual = "T%";
                       if (cb_operacao.Text == "CNC")
                           operacao_atual = "C%";
                       if (cb_operacao.Text == "Retífica")
                           operacao_atual = "R%";
                       this.datRotas_campo.SelectCommand.CommandText =
                       "SELECT * FROM ROTAS_CAMPO WHERE ((UPPER(DESENHO_CAMPO) LIKE UPPER ('" + tb_peca.Text + "%')) AND " +
                       " ((UPPER(MAQUINA) LIKE UPPER ('" + operacao_atual + "')) OR (UPPER(MAQUINA_FECHAMENTO) LIKE UPPER ('" + operacao_atual + "'))))" + 
                       " AND ((DATA_ENTRADA >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND DATA_ENTRADA <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                             " OR (DATA_FECHAMENTO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                             " AND DATA_FECHAMENTO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))"+  
                       " ORDER BY COD_ROTA_CAMPO ";

                       this.datParadas.SelectCommand.CommandText =
                           "SELECT * FROM PARADAS WHERE ((UPPER(MAQUINA_PARADA) LIKE UPPER ('" + operacao_atual + "%')) OR (UPPER(MAQUINA_REINICIO) LIKE UPPER ('" + operacao_atual + "%'))) ORDER BY COD_PARADA ";

                       this.datMaquinas_rodando.SelectCommand.CommandText =
                           "SELECT * FROM MAQUINA_RODANDO";

                   }
                    //por os todas
                    if (cb_todas_os.Checked == true)
                    {
                        if (cb_operacao.Text != "" && cbTodas_datas.Checked == false)
                        {
                                if (cb_operacao.Text == "Erosão")
                                    operacao_atual = "E_";
                                if (cb_operacao.Text == "Erosão a fio")
                                    operacao_atual = "EWC%";
                                if (cb_operacao.Text == "Fresa")
                                    operacao_atual = "F%";
                                if (cb_operacao.Text == "Torno")
                                    operacao_atual = "T%";
                                if (cb_operacao.Text == "CNC")
                                    operacao_atual = "C%";
                                if (cb_operacao.Text == "Retífica")
                                    operacao_atual = "R%";
                                this.datRotas_campo.SelectCommand.CommandText =
                                "SELECT * FROM ROTAS_CAMPO WHERE (((UPPER(MAQUINA) LIKE UPPER ('" + operacao_atual + "')) OR (UPPER(MAQUINA_FECHAMENTO) LIKE UPPER ('" + operacao_atual + "')))" +
                                " AND ((DATA_ENTRADA >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                      " AND DATA_ENTRADA <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                                      " OR (DATA_FECHAMENTO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                      " AND DATA_FECHAMENTO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')))" +
                                " ORDER BY COD_ROTA_CAMPO ";

                                this.datParadas.SelectCommand.CommandText =
                                    "SELECT * FROM PARADAS WHERE ((UPPER(MAQUINA_PARADA) LIKE UPPER ('" + operacao_atual + "%')) OR (UPPER(MAQUINA_REINICIO) LIKE UPPER ('" + operacao_atual + "%'))) ORDER BY COD_PARADA ";

                                this.datMaquinas_rodando.SelectCommand.CommandText =
                                    "SELECT * FROM MAQUINA_RODANDO";
                                
                            
                        }
                        else
                        {
                            if (dtFinal.Value != dtInicial.Value)
                            {
                                

                                this.datRotas_campo.SelectCommand.CommandText =
                                "SELECT * FROM ROTAS_CAMPO WHERE (((DATA_ENTRADA >= '" + Convert.ToDateTime(dtInicial.Value).AddDays(-1).ToShortDateString().Replace("/", ".") + "'" +
                                      " AND DATA_ENTRADA <= '" + Convert.ToDateTime(dtFinal.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "')" +
                                      " OR (DATA_FECHAMENTO >= '" + Convert.ToDateTime(dtInicial.Value).AddDays(-1).ToShortDateString().Replace("/", ".") + "'" +
                                      " AND DATA_FECHAMENTO <= '" + Convert.ToDateTime(dtFinal.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "')))" +
                                " ORDER BY COD_ROTA_CAMPO ";
                                this.datParadas.SelectCommand.CommandText =
                                "SELECT * FROM PARADAS WHERE " +
                                 " ((DATA_INICIO >= '" + Convert.ToDateTime(dtInicial.Value).AddDays(-1).ToShortDateString().Replace("/", ".") + "'" +
                                 " AND DATA_INICIO <= '" + Convert.ToDateTime(dtFinal.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "')" +
                                 " OR (DATA_TERMINO >= '" + Convert.ToDateTime(dtInicial.Value).AddDays(-1).ToShortDateString().Replace("/", ".") + "'" +
                                 " AND DATA_TERMINO <= '" + Convert.ToDateTime(dtFinal.Value).AddDays(1).ToShortDateString().Replace("/", ".") + "')) " +
                                 " ORDER BY COD_PARADA";
                            }
                            else
                            {
                                DateTime trinta_dias = new DateTime();
                                trinta_dias = Convert.ToDateTime(DateTime.Now.AddDays(-30).ToShortDateString());
                                this.datRotas_campo.SelectCommand.CommandText =
                                "SELECT * FROM ROTAS_CAMPO WHERE DATA_ENTRADA >= '12.06.2008' ORDER BY COD_ROTA_CAMPO";
                                this.datParadas.SelectCommand.CommandText =
                                "SELECT * FROM PARADAS ORDER BY COD_PARADA";
                            }
                            
                            
                        }
                   }
                    //por os
                    if (tb_peca.Text != "" && tb_maquina.Text == "" && cb_operacao.Text == "")
                    {
                        
                        
                            if (tb_posicao.Text != "" && cbTodas_datas.Checked == true)
                            {
                                //MessageBox.Show("entrou antes");
                                this.datRotas_campo.SelectCommand.CommandText =
                                "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tbCod_op.Text + "' ORDER BY COD_ROTA_CAMPO";// AND MAQUINA = '" + tb_maquina.Text + "'";
                                this.datMaquinas_rodando.SelectCommand.CommandText =
                                "SELECT * FROM MAQUINA_RODANDO";
                                

                            }
                            else
                            {
                                if (tb_posicao.Text == "")
                                {
                                    if (cbTodas_datas.Checked == false)
                                    {
                                        this.datRotas_campo.SelectCommand.CommandText =
                                        "SELECT * FROM ROTAS_CAMPO WHERE (UPPER(DESENHO_CAMPO) LIKE UPPER ('" + tb_peca.Text + "%'))" +
                                        " AND ((DATA_ENTRADA >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                     " AND DATA_ENTRADA <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "')" +
                                     " OR (DATA_FECHAMENTO >= '" + Convert.ToDateTime(dtInicial.Value).Month + "/" + Convert.ToDateTime(dtInicial.Value).Day + "/" + Convert.ToDateTime(dtInicial.Value).Year + "'" +
                                     " AND DATA_FECHAMENTO <= '" + Convert.ToDateTime(dtFinal.Value).Month + "/" + Convert.ToDateTime(dtFinal.Value).Day + "/" + Convert.ToDateTime(dtFinal.Value).Year + "'))" +
                                        " ORDER BY COD_ROTA_CAMPO";
                                    }
                                    else
                                    {
                                        this.datRotas_campo.SelectCommand.CommandText =
                                        "SELECT * FROM ROTAS_CAMPO WHERE (UPPER(DESENHO_CAMPO) LIKE UPPER ('" + tb_peca.Text + "%'))" +
                                        " ORDER BY COD_ROTA_CAMPO";
                                    }
                                this.datMaquinas_rodando.SelectCommand.CommandText =
                                "SELECT * FROM MAQUINA_RODANDO";
                                }
                            }
                        
                            
                        
                    
                        this.datParadas.SelectCommand.CommandText =
                            "SELECT * FROM PARADAS ORDER BY COD_PARADA";
                    }

                    break;
            }
            this.fbConnection1.Open();
            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            
            this.fbConnection1.Open();
            this.datParadas.SelectCommand.Connection = fbConnection1;
            this.datParadas.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            
            this.fbConnection1.Open();
            this.datMaquinas_rodando.SelectCommand.Connection = fbConnection1;
            this.datMaquinas_rodando.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            if (imprimir_agora == false)
            {
                //try
               //   {
                    datRotas_campo.Fill(ROTAS_CAMPO);
                    datParadas.Fill(PARADAS);
                    datMaquinas_rodando.Fill(MAQUINA_RODANDO);
                    if (consulta_maquina == false && consulta_operador == false)
                    {
                        if (cb_todas_os.Checked == true)
                            calcula_horas();
                        else
                        {
                            for (i = 0; i < (dgvConsulta.RowCount - 1); i++)
                            {



                                if (dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() !=
                                    dgvConsulta.Rows[i].Cells["col_retrabalho"].Value.ToString())
                                {
                                    try
                                    {
                                        total_horas_ret = total_horas_ret + Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_saldo_horas"].Value);
                                    }
                                    catch { }
                                    ///    }
                                    ///    try
                                    ///    {
                                    ///    
                                }
                                //if (Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_saldo_horas"].Value) > 0)
                                // {
                                try
                                {
                                    total_horas_prev = total_horas_prev + Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value);
                                    total_horas_trab = total_horas_trab + Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_saldo_horas"].Value);
                                }
                                catch { }
                                // }
                                //MessageBox.Show(total_horas_trab.ToString("n2"));

                                ///   }
                                ///      catch { }





                                tb_horas_retrabalho.Text = total_horas_ret.ToString("n2");
                                tbTotal_horas.Text = total_horas_trab.ToString("n2");
                                tb_horas_previstas.Text = total_horas_prev.ToString("n2");

                            }
                        }
                        
                    }
                    
                    else
                    {
                        calcula_horas();
                    }
                    consulta_operador = false;
                    consulta_maquina = false;
                //}
               // catch
               // {
                  // MessageBox.Show("Erro na consulta, tente novamente");
                 //  fbConnection1.Close();
                //}
            }
        }
        private void calcula_horas()
        {            
            //por operador
            if (tb_operador.Text != "")
            {
                if (cbUm_dia.Checked == true)
                {
                    horas_parciais_x = 0;
                    total_horas_operador = 0;
                    //loop para percorrer as linhas das rotas                    
                    for (i = 0; i < dgvConsulta.RowCount - 1; i++)
                    {
                        bool dia_anterior = false;
                        em_andamento = false; //nova conta
                        //se hora entrada não for null
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {

                            abertura_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString() + " 05:00:00");
                            //abertura_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //para conferir a data de entrada
                            abertura_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()).ToShortTimeString()); //para conferir a hora de entrada

                            if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() != "")
                                fechamento_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString()).ToShortTimeString()); //para conferir a data de fechamento
                            //se operador inicial atende, e data está dentro das especificações
                            if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                abertura_data_confere >= abertura_data_anterior_confere)
                            {
                                abertura_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //coloca no abertura_data a data da célula
                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()).ToShortTimeString()); //junta a data e a hora
                                em_andamento = true; //abertura capturada
                            }
                            else
                            {
                                //se abertura foi feita no dia anterior
                                if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                (abertura_data_confere < abertura_data_anterior_confere))
                                {
                                    if (cbUm_dia.Checked == false)
                                    {
                                        inicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 05:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                        abertura = Convert.ToDateTime(inicio_dia_anterior);
                                        em_andamento = true;
                                        dia_anterior = true;
                                    }
                                }
                            }
                            for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                            {

                                reinicio_parada_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString() + " 05:00:00");
                                abertura_parada_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString()).ToShortTimeString());
                                abertura_parada_data_posterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString() + " 05:00:00");
                                if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                    reinicio_parada_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                if (em_andamento == true)
                                {

                                    //se em andamento e a parada tiver a rota do apontamento de rotas
                                    if (dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() && em_andamento == true)
                                    {
                                        //se for o operador correto e a data estiver nos parâmetros
                                        if (tb_operador.Text == dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() &&
                                            abertura_parada_data_confere >= reinicio_parada_data_anterior_confere &&
                                            abertura_parada_data_confere <= abertura_parada_data_posterior_confere)
                                        {
                                            fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString()).ToShortTimeString());
                                            em_andamento = false;
                                            n_paradas++;
                                        }
                                        else
                                        //se estiver passado o fechamento
                                        {

                                            //se o fechamento for um dia depois da ultima data
                                            if (abertura_parada_data_confere > abertura_parada_data_posterior_confere &&
                                                dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() == tb_operador.Text)
                                            {
                                                //MessageBox.Show("chegou aqui");
                                                if (dia_anterior == true)
                                                    parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 05:00:01"; //junta o ultimo dia + o ultimo segundo
                                                else
                                                    parada_outro_dia = abertura_parada_data_posterior_confere.ToString(); //junta o ultimo dia + o ultimo segundo
                                                //parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                fechamento = Convert.ToDateTime(parada_outro_dia);
                                                em_andamento = false;
                                                n_paradas++;
                                            }
                                        }
                                        //se não estiver em andamento isto é se tiver uma abertura e fechamento tb
                                        if (em_andamento == false)
                                        {
                                            if (dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString() == "")
                                                dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value = "1";
                                            resultado = fechamento.Subtract(abertura); //faça a conta
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                            ///tb_total_operador.Text = total_horas_operador.ToString();
                                        }
                                        //se tiver um reinicio e for o mesmo operador e for na data
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= reinicio_parada_data_anterior_confere &&
                                            reinicio_parada_data_confere <= abertura_parada_data_posterior_confere)
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                            abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                            em_andamento = true;
                                        }

                                        else
                                        {
                                            //se o reinicio foi dado no dia anterior
                                            if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                                dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere < reinicio_parada_data_anterior_confere)
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 05:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                em_andamento = true;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= reinicio_parada_data_anterior_confere &&
                                            reinicio_parada_data_confere <= abertura_parada_data_posterior_confere &&
                                            dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString())
                                    {
                                        dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                        abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                        abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                        em_andamento = true;
                                    }

                                    else
                                    {
                                        //se o reinicio foi dado no dia anterior
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere < reinicio_parada_data_anterior_confere)
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 05:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                            abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                            em_andamento = true;
                                        }
                                    }
                                }
                                //se estiver numa parada que não foi calculada ainda mas pode ter um reinicio
                                /*/
                                if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text && em_andamento == false &&
                                    dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                    dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() &&
                                        reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                {
                                    dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                    abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                    abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                    em_andamento = true;
                                }
                                 * /*/
                            }
                            //saiu das paradas 
                            if (em_andamento == true)
                            {
                                //se tiver em_andamento  // é aqui que tem que colocar as horas do cartão de ponto
                                if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "" &&
                                    dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                                {
                                    date_now_confere = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                    //se data de agora = inicial ou final
                                    if (date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) ||
                                        date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                    {
                                        fechamento = DateTime.Now;
                                        em_andamento = false;
                                    }
                                    else
                                    {
                                        parada_outro_dia = Convert.ToString(abertura_parada_data_posterior_confere);
                                        fechamento = Convert.ToDateTime(parada_outro_dia);
                                        em_andamento = false;
                                    }
                                }
                                else
                                {
                                    //vou calcular o ultimo reinicio e a hora de fechamento
                                    if (dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text &&
                                        fechamento_data_confere >= reinicio_parada_data_anterior_confere &&
                                        fechamento_data_confere <= abertura_parada_data_posterior_confere)
                                    {
                                        fechamento_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                                        fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString()).ToShortTimeString());
                                        em_andamento = false;
                                    }
                                    else
                                    {
                                        //se fechamento for no dia seguinte
                                        if (fechamento_data_confere > abertura_parada_data_posterior_confere)
                                        //&&
                                        //dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text)
                                        {
                                            parada_outro_dia = Convert.ToString(abertura_parada_data_posterior_confere);
                                            fechamento = Convert.ToDateTime(parada_outro_dia);
                                            em_andamento = false;
                                        }
                                    }
                                }
                                if (em_andamento == false)
                                {
                                    if (dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString() == "")
                                        dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value = "1";
                                    resultado = fechamento.Subtract(abertura);
                                    total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                        / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString()));
                                }
                            }
                        }
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {
                            horas_parciais = total_horas_operador - horas_parciais_x;
                            dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value = horas_parciais.ToString();
                            horas_parciais_x = total_horas_operador;
                        }
                        em_andamento = false;
                        cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());
                    }
                    Atualizar();
                    //saiu das rotas
                    //tb_total_operador.Text = total_horas_operador.ToString();

                    int n_linhas_atual = dgvConsulta.RowCount;
                    //MessageBox.Show(n_linhas_atual.ToString());
                    int pode_parar = 0;
                    int onde_posso_parar = 0;

                    for (int p = 0; p < dgvParadas.RowCount - 1; p++)
                    {
                        if (Convert.ToString(dgvParadas.Rows[p].Cells["coluna_data_ter"].Value) != "" &&
                            Convert.ToString(dgvParadas.Rows[p].Cells["col_operador_reinicio"].Value) == tb_operador.Text
                            & Convert.ToString(dgvParadas.Rows[p].Cells["col_parada_con"].Value) == "")
                        {
                            this.datRotas_campo.SelectCommand.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[p].Cells["col_rota_parada"].Value.ToString() + "'";
                            this.fbConnection1.Open();
                            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();
                            datRotas_campo.Fill(ROTAS_CAMPO);
                            //MessageBox.Show(dgvParadas.Rows[p].Cells["col_rota_parada"].Value.ToString());
                            onde_posso_parar++;
                        }
                    }

                    int n_linhas_depois = dgvConsulta.RowCount;
                    //MessageBox.Show(total_horas_operador.ToString());

                    //MessageBox.Show(n_linhas_depois.ToString());

                    //calculando as paradas que não tem rotas

                    for (i = n_linhas_atual - 1; i < dgvConsulta.RowCount - 1; i++)
                    {

                        bool dia_anterior = false;
                        em_andamento = false; //nova conta
                        //se hora entrada não for null
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {

                            abertura_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString() + " 05:00:00");
                            //abertura_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //para conferir a data de entrada
                            abertura_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()).ToShortTimeString()); //para conferir a hora de entrada

                            if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() != "")
                                fechamento_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString()).ToShortTimeString()); //para conferir a data de fechamento
                            //se operador inicial atende, e data está dentro das especificações
                            if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                abertura_data_confere >= abertura_data_anterior_confere)
                            {
                                abertura_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //coloca no abertura_data a data da célula
                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[j].Cells["col_hora_entrada"].Value.ToString()).ToShortTimeString()); //junta a data e a hora
                                em_andamento = true; //abertura capturada
                            }
                            else
                            {
                                //se abertura foi feita no dia anterior
                                if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                (abertura_data_confere < abertura_data_anterior_confere))
                                {
                                    if (cbUm_dia.Checked == false)
                                    {
                                        inicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 05:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                        abertura = Convert.ToDateTime(inicio_dia_anterior);
                                        em_andamento = true;
                                        dia_anterior = true;
                                    }
                                }
                            }
                            for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                            {

                                reinicio_parada_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString() + " 05:00:00");
                                abertura_parada_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString()).ToShortTimeString());
                                abertura_parada_data_posterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).AddDays(1).ToShortDateString() + " 05:00:00");
                                if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                    reinicio_parada_data_confere = Convert.ToDateTime(Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString()).ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                if (em_andamento == true)
                                {

                                    //se em andamento e a parada tiver a rota do apontamento de rotas
                                    if (dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() && em_andamento == true)
                                    {
                                        //se for o operador correto e a data estiver nos parâmetros
                                        if (tb_operador.Text == dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() &&
                                            abertura_parada_data_confere >= reinicio_parada_data_anterior_confere &&
                                            abertura_parada_data_confere <= abertura_parada_data_posterior_confere)
                                        {
                                            fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString()).ToShortTimeString());
                                            em_andamento = false;
                                            n_paradas++;
                                        }
                                        else
                                        //se estiver passado o fechamento
                                        {

                                            //se o fechamento for um dia depois da ultima data
                                            if (abertura_parada_data_confere > abertura_parada_data_posterior_confere &&
                                                dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() == tb_operador.Text)
                                            {
                                                //MessageBox.Show("chegou aqui");
                                                if (dia_anterior == true)
                                                    parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 05:00:01"; //junta o ultimo dia + o ultimo segundo
                                                else
                                                    parada_outro_dia = abertura_parada_data_posterior_confere.ToString(); //junta o ultimo dia + o ultimo segundo
                                                //parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                fechamento = Convert.ToDateTime(parada_outro_dia);
                                                em_andamento = false;
                                                n_paradas++;
                                            }
                                        }
                                        //se não estiver em andamento isto é se tiver uma abertura e fechamento tb
                                        if (em_andamento == false)
                                        {
                                            if (dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString() == "")
                                                dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value = "1";
                                            resultado = fechamento.Subtract(abertura); //faça a conta
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                            ///tb_total_operador.Text = total_horas_operador.ToString();
                                        }
                                        //se tiver um reinicio e for o mesmo operador e for na data
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= reinicio_parada_data_anterior_confere &&
                                            reinicio_parada_data_confere <= abertura_parada_data_posterior_confere)
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                            abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                            em_andamento = true;
                                        }

                                        else
                                        {
                                            //se o reinicio foi dado no dia anterior
                                            if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                                dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere < reinicio_parada_data_anterior_confere)
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 05:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                em_andamento = true;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= reinicio_parada_data_anterior_confere &&
                                            reinicio_parada_data_confere <= abertura_parada_data_posterior_confere &&
                                            dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString())
                                    {
                                        dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                        abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                        abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                        em_andamento = true;
                                    }

                                    else
                                    {
                                        //se o reinicio foi dado no dia anterior
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere < reinicio_parada_data_anterior_confere)
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 05:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                            abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                            em_andamento = true;
                                        }
                                    }
                                }
                                //se estiver numa parada que não foi calculada ainda mas pode ter um reinicio
                                /*/
                                if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text && em_andamento == false &&
                                    dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                    dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() &&
                                        reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                {
                                    dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                    abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                    abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                    em_andamento = true;
                                }
                                 * /*/
                            }
                            //saiu das paradas 
                            if (em_andamento == true)
                            {
                                //se tiver em_andamento  // é aqui que tem que colocar as horas do cartão de ponto
                                if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "" &&
                                    dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                                {
                                    date_now_confere = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                    //se data de agora = inicial ou final
                                    if (date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) ||
                                        date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                    {
                                        fechamento = DateTime.Now;
                                        em_andamento = false;
                                    }
                                    else
                                    {
                                        parada_outro_dia = Convert.ToString(abertura_parada_data_posterior_confere);
                                        fechamento = Convert.ToDateTime(parada_outro_dia);
                                        em_andamento = false;
                                    }
                                }
                                else
                                {
                                    //vou calcular o ultimo reinicio e a hora de fechamento
                                    if (dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text &&
                                        fechamento_data_confere >= reinicio_parada_data_anterior_confere &&
                                        fechamento_data_confere <= abertura_parada_data_posterior_confere)
                                    {
                                        fechamento_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                                        fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString()).ToShortTimeString());
                                        em_andamento = false;
                                    }
                                    else
                                    {
                                        //se fechamento for no dia seguinte
                                        if (fechamento_data_confere > abertura_parada_data_posterior_confere)
                                        //&&
                                        //dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text)
                                        {
                                            parada_outro_dia = Convert.ToString(abertura_parada_data_posterior_confere);
                                            fechamento = Convert.ToDateTime(parada_outro_dia);
                                            em_andamento = false;
                                        }
                                    }
                                }
                                if (em_andamento == false)
                                {
                                    if (dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString() == "")
                                        dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value = "1";
                                    resultado = fechamento.Subtract(abertura);
                                    total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                        / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString()));
                                }
                            }
                        }
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {
                            horas_parciais = total_horas_operador - horas_parciais_x;
                            dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value = horas_parciais.ToString();
                            horas_parciais_x = total_horas_operador;
                        }
                        em_andamento = false;
                        cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());
                    }

                    tb_total_operador.Text = total_horas_operador.ToString();

                
                }
                else
                {
                    horas_parciais_x = 0;
                    total_horas_operador = 0;
                    //loop para percorrer as linhas das rotas                    
                    for (i = 0; i < dgvConsulta.RowCount - 1; i++)
                    {
                        bool dia_anterior = false;
                        em_andamento = false; //nova conta
                        //se hora entrada não for null
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {

                            abertura_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                            abertura_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //para conferir a data de entrada
                            if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() != "")
                                fechamento_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString()); //para conferir a data de fechamento
                            //se operador inicial atende, e data está dentro das especificações
                            if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                abertura_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                abertura_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                            {
                                abertura_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //coloca no abertura_data a data da célula
                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()); //junta a data e a hora
                                em_andamento = true; //abertura capturada
                            }
                            else
                            {
                                //se abertura foi feita no dia anterior
                                if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                abertura_data_confere == abertura_data_anterior_confere)
                                {
                                    inicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                    abertura = Convert.ToDateTime(inicio_dia_anterior);
                                    em_andamento = true;
                                    dia_anterior = true;
                                }
                            }
                            for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                            {
                                reinicio_parada_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                                abertura_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                    reinicio_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                if (em_andamento == true)
                                {

                                    //se em andamento e a parada tiver a rota do apontamento de rotas
                                    if (dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() && em_andamento == true)
                                    {
                                        //se for o operador correto e a data estiver nos parâmetros
                                        if (tb_operador.Text == dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() &&
                                            abertura_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            abertura_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString());
                                            em_andamento = false;
                                            n_paradas++;
                                        }
                                        else
                                        //se estiver passado o fechamento
                                        {

                                            //se o fechamento for um dia depois da ultima data
                                            if (abertura_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)) &&
                                                dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() == tb_operador.Text)
                                            {
                                                //MessageBox.Show("chegou aqui");
                                                if (dia_anterior == true)
                                                    parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 00:00:01"; //junta o ultimo dia + o ultimo segundo
                                                else
                                                    parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                //parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                fechamento = Convert.ToDateTime(parada_outro_dia);
                                                em_andamento = false;
                                                n_paradas++;
                                            }
                                        }
                                        //se não estiver em andamento isto é se tiver uma abertura e fechamento tb
                                        if (em_andamento == false)
                                        {
                                            if (dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString() == "")
                                                dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value = "1";
                                            resultado = fechamento.Subtract(abertura); //faça a conta
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                            ///tb_total_operador.Text = total_horas_operador.ToString();
                                        }
                                        //se tiver um reinicio e for o mesmo operador e for na data
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                            abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                            em_andamento = true;
                                        }

                                        else
                                        {
                                            //se o reinicio foi dado no dia anterior
                                            if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                                dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                em_andamento = true;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) &&
                                            dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString())
                                    {
                                        dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                        abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                        abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                        em_andamento = true;
                                    }

                                    else
                                    {
                                        //se o reinicio foi dado no dia anterior
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                            abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                            em_andamento = true;
                                        }
                                    }
                                }
                                //se estiver numa parada que não foi calculada ainda mas pode ter um reinicio
                                /*/
                                if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text && em_andamento == false &&
                                    dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                    dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() &&
                                        reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                {
                                    dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                    abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                    abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                    em_andamento = true;
                                }
                                 * /*/
                            }
                            //saiu das paradas 
                            if (em_andamento == true)
                            {
                                //se tiver em_andamento  // é aqui que tem que colocar as horas do cartão de ponto
                                if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "" &&
                                    dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                                {
                                    date_now_confere = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                    //se data de agora = inicial ou final
                                    if (date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) ||
                                        date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        fechamento = DateTime.Now;
                                    else
                                    {
                                        parada_outro_dia = Convert.ToString(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) + " 23:59:59";
                                        fechamento = Convert.ToDateTime(parada_outro_dia);
                                    }
                                }
                                else
                                {
                                    //vou calcular o ultimo reinicio e a hora de fechamento
                                    if (dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text &&
                                        fechamento_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        fechamento_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                    {
                                        fechamento_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                                        fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString());
                                        em_andamento = false;
                                    }
                                    else
                                    {
                                        //se fechamento for no dia seguinte
                                        if (fechamento_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)) &&
                                            dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text)
                                        {
                                            parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59";
                                            fechamento = Convert.ToDateTime(parada_outro_dia);
                                            em_andamento = false;
                                        }
                                    }
                                }
                                if (em_andamento == false)
                                {
                                    if (dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString() == "")
                                        dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value = "1";
                                    resultado = fechamento.Subtract(abertura);
                                    total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                        / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString()));
                                }
                            }
                        }
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {
                            horas_parciais = total_horas_operador - horas_parciais_x;
                            dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value = horas_parciais.ToString();
                            horas_parciais_x = total_horas_operador;
                        }
                        em_andamento = false;
                        cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());
                    }
                    Atualizar();
                    //saiu das rotas
                    //tb_total_operador.Text = total_horas_operador.ToString();

                    int n_linhas_atual = dgvConsulta.RowCount;
                    //MessageBox.Show(n_linhas_atual.ToString());
                    int pode_parar = 0;
                    int onde_posso_parar = 0;

                    for (int p = 0; p < dgvParadas.RowCount - 1; p++)
                    {
                        if (Convert.ToString(dgvParadas.Rows[p].Cells["coluna_data_ter"].Value) != "" &&
                            Convert.ToString(dgvParadas.Rows[p].Cells["col_operador_reinicio"].Value) == tb_operador.Text
                            && Convert.ToString(dgvParadas.Rows[p].Cells["col_parada_con"].Value) == "")
                            this.datRotas_campo.SelectCommand.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[p].Cells["col_rota_parada"].Value.ToString() + "'";
                        this.fbConnection1.Open();
                        this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                        this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        datRotas_campo.Fill(ROTAS_CAMPO);
                        //MessageBox.Show(dgvParadas.Rows[p].Cells["col_rota_parada"].Value.ToString());
                        onde_posso_parar++;
                    }

                    int n_linhas_depois = dgvConsulta.RowCount;
                    //MessageBox.Show(total_horas_operador.ToString());

                    //MessageBox.Show(n_linhas_depois.ToString());

                    //calculando as paradas que não tem rotas

                    for (i = n_linhas_atual - 1; i < dgvConsulta.RowCount - 1; i++)
                    {
                        bool dia_anterior = false;
                        em_andamento = false; //nova conta
                        //se hora entrada não for null
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {

                            abertura_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                            abertura_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //para conferir a data de entrada
                            if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() != "")
                                fechamento_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString()); //para conferir a data de fechamento
                            //se operador inicial atende, e data está dentro das especificações
                            if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                abertura_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                abertura_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                            {
                                abertura_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //coloca no abertura_data a data da célula
                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()); //junta a data e a hora
                                em_andamento = true; //abertura capturada
                            }
                            else
                            {
                                //se abertura foi feita no dia anterior
                                if (dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString() == tb_operador.Text &&
                                abertura_data_confere == abertura_data_anterior_confere)
                                {
                                    if (cbUm_dia.Checked == false)
                                    {
                                        inicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                        abertura = Convert.ToDateTime(inicio_dia_anterior);
                                        em_andamento = true;
                                        dia_anterior = true;
                                    }

                                }
                            }

                            for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                            {
                                reinicio_parada_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                                abertura_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                    reinicio_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                if (em_andamento == true)
                                {

                                    //se em andamento e a parada tiver a rota do apontamento de rotas
                                    if (dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() && em_andamento == true)
                                    {
                                        //se for o operador correto e a data estiver nos parâmetros
                                        if (tb_operador.Text == dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() &&
                                            abertura_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            abertura_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString());
                                            em_andamento = false;
                                            n_paradas++;
                                        }
                                        else
                                        //se estiver passado o fechamento
                                        {

                                            //se o fechamento for um dia depois da ultima data
                                            if (abertura_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)) &&
                                                dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() == tb_operador.Text)
                                            {
                                                //MessageBox.Show("chegou aqui");
                                                if (dia_anterior == true)
                                                    parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 00:00:01"; //junta o ultimo dia + o ultimo segundo
                                                else
                                                    parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                fechamento = Convert.ToDateTime(parada_outro_dia);
                                                em_andamento = false;
                                                n_paradas++;
                                            }
                                        }
                                        //se não estiver em andamento isto é se tiver uma abertura e fechamento tb
                                        if (em_andamento == false)
                                        {
                                            if (dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString() == "")
                                                dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value = "1";
                                            resultado = fechamento.Subtract(abertura); //faça a conta
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                            ///tb_total_operador.Text = total_horas_operador.ToString();
                                        }
                                        //se tiver um reinicio e for o mesmo operador e for na data
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                            abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                            em_andamento = true;
                                            //break;
                                        }

                                        else
                                        {
                                            //se o reinicio foi dado no dia anterior
                                            if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                                dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                em_andamento = true;
                                                //break;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                        dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                        reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) &&
                                        dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString())
                                    {
                                        dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                        abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                        abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                        em_andamento = true;
                                        //break;
                                    }

                                    else
                                    {
                                        //se o reinicio foi dado no dia anterior
                                        if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                            abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                            em_andamento = true;
                                            //break;
                                        }
                                    }
                                }


                                //se estiver numa parada que não foi calculada ainda mas pode ter um reinicio
                                /*/
                                if (dgvParadas.Rows[j].Cells["col_operador_reinicio"].Value.ToString() == tb_operador.Text && em_andamento == false &&
                                    dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                    dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() &&
                                        reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                {
                                    dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                    abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                    abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                    em_andamento = true;
                                }
                                 * /*/
                            }
                            //saiu das paradas 
                            if (em_andamento == true)
                            {
                                //se tiver em_andamento  // é aqui que tem que colocar as horas do cartão de ponto
                                if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "" &&
                                    dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                                {
                                    date_now_confere = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                    //se data de agora = inicial ou final
                                    if (date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) ||
                                        date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        fechamento = DateTime.Now;
                                    else
                                    {
                                        parada_outro_dia = Convert.ToString(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) + " 23:59:59";
                                        fechamento = Convert.ToDateTime(parada_outro_dia);
                                    }
                                }
                                else
                                {
                                    //vou calcular o ultimo reinicio e a hora de fechamento
                                    if (dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text &&
                                        fechamento_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        fechamento_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                    {
                                        fechamento_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                                        fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString());
                                        em_andamento = false;
                                    }
                                    else
                                    {
                                        //se fechamento for no dia seguinte
                                        if (fechamento_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)) &&
                                            dgvConsulta.Rows[i].Cells["col_operador_fim"].Value.ToString() == tb_operador.Text)
                                        {
                                            parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59";
                                            fechamento = Convert.ToDateTime(parada_outro_dia);
                                            em_andamento = false;
                                        }
                                    }
                                }
                                if (em_andamento == false)
                                {
                                    if (dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString() == "")
                                        dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value = "1";
                                    resultado = fechamento.Subtract(abertura);
                                    total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                        / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString()));
                                }
                            }
                        }
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {
                            horas_parciais = total_horas_operador - horas_parciais_x;
                            dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value = horas_parciais.ToString();
                            horas_parciais_x = total_horas_operador;
                        }
                        em_andamento = false;
                        cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());

                    }

                    tb_total_operador.Text = total_horas_operador.ToString();

                }
            }

                    // se for por máquina TEM QUE ARRUMAR A ENTRADA DE DADOS COM MÁQUINA DE ENTRADA E SAIDA
            else
            {
                if (tb_maquina.Text != "")
                {
                    total_horas_operador = 0;
                    //loop para percorrer as linhas das rotas                    
                    for (i = 0; i < dgvConsulta.RowCount - 1; i++)
                    {

                        em_andamento = false; //nova conta
                        //se hora entrada não for null
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {
                            abertura_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                            abertura_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //para conferir a data de entrada
                            if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() != "")
                                fechamento_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString()); //para conferir a data de fechamento
                            //se operador inicial atende, e data está dentro das especificações
                            if (dgvConsulta.Rows[i].Cells["col_maquina"].Value.ToString().ToUpper() == tb_maquina.Text &&
                                abertura_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                abertura_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                            {
                                abertura_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //coloca no abertura_data a data da célula
                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()); //junta a data e a hora
                                em_andamento = true; //abertura capturada
                            }
                            else
                            {
                                //se abertura foi feita no dia anterior
                                if (dgvConsulta.Rows[i].Cells["col_maquina"].Value.ToString().ToUpper() == tb_maquina.Text &&
                                abertura_data_confere == abertura_data_anterior_confere)
                                {
                                    inicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                    abertura = Convert.ToDateTime(inicio_dia_anterior);
                                    em_andamento = true;
                                }
                            }
                            for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                            {
                                try
                                {
                                    reinicio_parada_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                                    abertura_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                    if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                        reinicio_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                    //se em andamento e a parada tiver a rota do apontamento de rotas
                                    if (dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() && em_andamento == true)
                                    {
                                        //se for o operador correto e a data estiver nos parâmetros
                                        if (tb_maquina.Text == dgvParadas.Rows[j].Cells["col_maquina_parada"].Value.ToString().ToUpper() &&
                                            abertura_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            abertura_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString());
                                            em_andamento = false;
                                            n_paradas++;
                                        }
                                        else
                                        //se estiver passado o fechamento
                                        {

                                            //se o fechamento for um dia depois da ultima data
                                            if (abertura_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)) &&
                                                dgvParadas.Rows[j].Cells["col_maquina_parada"].Value.ToString().ToUpper() == tb_maquina.Text)
                                            {
                                                parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                fechamento = Convert.ToDateTime(parada_outro_dia);
                                                em_andamento = false;
                                                n_paradas++;
                                            }
                                        }
                                        //se não estiver em andamento isto é se tiver uma abertura e fechamento tb
                                        if (em_andamento == false)
                                        {
                                            resultado = fechamento.Subtract(abertura); //faça a conta
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                            tb_total_operador.Text = total_horas_operador.ToString();
                                        }
                                        //se tiver um reinicio e for o mesmo operador e for na data
                                        if (dgvParadas.Rows[j].Cells["col_maquina_reinicio"].Value.ToString().ToUpper() == tb_maquina.Text &&
                                            dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                            reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                            abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                            em_andamento = true;
                                        }

                                        else
                                        {
                                            //se o reinicio foi dado no dia anterior
                                            if (dgvParadas.Rows[j].Cells["col_maquina_reinicio"].Value.ToString().ToUpper() == tb_maquina.Text &&
                                                dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                em_andamento = true;
                                            }
                                        }



                                    }
                                    //se estiver numa parada que não foi calculada ainda mas pode ter um reinicio
                                    if (dgvParadas.Rows[j].Cells["col_maquina_reinicio"].Value.ToString().ToUpper() == tb_maquina.Text && em_andamento == false &&
                                        dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                        dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() &&
                                            reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                    {
                                        dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                        abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                        abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                        em_andamento = true;
                                    }
                                }
                                catch { }
                            }
                            //saiu das paradas 
                            if (em_andamento == true)
                            {
                                //se tiver em_andamento  // é aqui que tem que colocar as horas do cartão de ponto
                                if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "" &&
                                    dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                                {
                                    date_now_confere = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                    //se data de agora = inicial ou final
                                    if (date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) ||
                                        date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        fechamento = DateTime.Now;
                                    else
                                    {
                                        parada_outro_dia = Convert.ToString(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) + " 23:59:59";
                                        fechamento = Convert.ToDateTime(parada_outro_dia);
                                    }
                                }
                                else
                                {
                                    //vou calcular o ultimo reinicio e a hora de fechamento
                                    if (dgvConsulta.Rows[i].Cells["col_maquina_fecha"].Value.ToString().ToUpper() == tb_maquina.Text &&
                                        fechamento_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        fechamento_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                    {
                                        fechamento_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                                        fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString());
                                        em_andamento = false;
                                    }
                                    else
                                    {
                                        //se fechamento for no dia seguinte
                                        if (fechamento_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)) &&
                                            dgvConsulta.Rows[i].Cells["col_maquina_fecha"].Value.ToString().ToUpper() == tb_maquina.Text)
                                        {
                                            parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59";
                                            fechamento = Convert.ToDateTime(parada_outro_dia);
                                            em_andamento = false;
                                        }
                                    }
                                }
                                if (em_andamento == false)
                                {
                                    resultado = fechamento.Subtract(abertura);
                                    total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                        / Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_os_conjuntas"].Value.ToString()));
                                }
                            }
                        }
                        if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                        {
                            horas_parciais = total_horas_operador - horas_parciais_x;
                            dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value = horas_parciais.ToString();
                            horas_parciais_x = total_horas_operador;
                        }
                        em_andamento = false;
                        cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());
                    }
                    //saiu das rotas
                    tb_total_operador.Text = total_horas_operador.ToString();
                    int pode_parar = 0;
                    int onde_posso_parar = 0;
                    for (int p = 0; p < dgvParadas.RowCount; p++)
                    {
                        if (Convert.ToString(dgvParadas.Rows[p].Cells["coluna_data_ter"].Value) != "" &&
                            Convert.ToString(dgvParadas.Rows[p].Cells["col_maquina_reinicio"].Value).ToUpper() == tb_maquina.Text
                            && Convert.ToString(dgvParadas.Rows[p].Cells["col_parada_con"].Value) == "")

                            onde_posso_parar++;
                    }
                    int pode_parar_2 = 0;
                    //calculando as paradas que não tem rotas
                    while (pode_parar < onde_posso_parar)
                    {
                        pode_parar_2++;
                        total_horas_operador = 0;
                        horas_parciais = 0;
                        horas_parciais_x = 0;
                        //MessageBox.Show("cheguei");
                        // pode_parar++;
                        if (pode_parar_2 == 500)
                        {
                            MessageBox.Show("Não existem mais paradas");
                            break;
                        }
                        else
                        {
                            for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                            {

                                if (Convert.ToString(dgvParadas.Rows[j].Cells["col_parada_con"].Value) == "")
                                {
                                    try
                                    {
                                        abertura_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                        if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                        {
                                            reinicio_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                        }

                                        if (em_andamento == true && rota_atual.ToString() == dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() &&
                                            abertura_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            abertura_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            cod_parada_consultados[j] = Convert.ToInt32(dgvParadas.Rows[j].Cells["col_cod_parada"].Value.ToString());
                                            fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString());
                                            //aqui eu mostro as rotas que tem paradas não computadas
                                            /*
                                            this.datRotas_campo.SelectCommand.CommandText =
                                            "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() + "'";
                                            this.fbConnection1.Open();
                                            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                                            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                                            this.fbConnection1.Close();
                                            datRotas_campo.Fill(ROTAS_CAMPO);
                                             */
                                            resultado = fechamento.Subtract(abertura);
                                            if (transforma_dia_horas(resultado.ToString()) < 0)
                                            {
                                                if (dgvParadas.Rows[j].Cells["col_maquina_reinicio"].Value.ToString().ToUpper() == tb_maquina.Text)
                                                {
                                                    cod_parada_consultados[j] = Convert.ToInt32(dgvParadas.Rows[j].Cells["col_cod_parada"].Value.ToString());
                                                    fechamento = DateTime.Now;
                                                    resultado = fechamento.Subtract(abertura);

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            MessageBox.Show(abertura.ToString());
                                            MessageBox.Show(fechamento.ToString());
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString()));//transforma_dia_horas(resultado.ToString());
                                            dgvConsulta.Rows[dgvConsulta.RowCount - 2].Cells["HORAS_OPERADOR"].Value = total_horas_operador.ToString();
                                            MessageBox.Show(total_horas_operador.ToString());
                                            /*
                                            if (Convert.ToString(dgvConsulta.Rows[dgvConsulta.RowCount - 2].Cells["col_hora_entrada"].Value) != "")
                                            {
                                                horas_parciais = total_horas_operador - horas_parciais_x;
                                                dgvConsulta.Rows[dgvConsulta.RowCount - 2].Cells["HORAS_OPERADOR"].Value = total_horas_operador.ToString();
                                                MessageBox.Show(total_horas_operador.ToString());
                                                horas_parciais_x = total_horas_operador;
                                            }
                                             * */
                                            em_andamento = false;
                                            pode_parar++;
                                        }
                                        if (abertura_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)) &&
                                                    dgvParadas.Rows[j].Cells["col_operador_in_par"].Value.ToString() == tb_operador.Text &&
                                                    em_andamento == true && rota_atual.ToString() == dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString())
                                        {
                                            parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                            fechamento = Convert.ToDateTime(parada_outro_dia);
                                            em_andamento = false;
                                            n_paradas++;
                                            //aqui eu mostro as rotas que tem paradas não computadas
                                            this.datRotas_campo.SelectCommand.CommandText =
                                            "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() + "'";
                                            this.fbConnection1.Open();
                                            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                                            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                                            this.fbConnection1.Close();
                                            datRotas_campo.Fill(ROTAS_CAMPO);

                                            resultado = fechamento.Subtract(abertura);
                                            MessageBox.Show("abertura é " + abertura.ToString() + " e o fecha é " + fechamento.ToString() + " DA LINHA " + j.ToString());
                                            if (transforma_dia_horas(resultado.ToString()) < 0)
                                            {
                                                if (dgvParadas.Rows[j].Cells["col_maquina_reinicio"].Value.ToString().ToUpper() == tb_maquina.Text)
                                                {
                                                    cod_parada_consultados[j] = Convert.ToInt32(dgvParadas.Rows[j].Cells["col_cod_parada"].Value.ToString());
                                                    fechamento = DateTime.Now;
                                                    MessageBox.Show("abertura é " + abertura.ToString() + " e o fecha é " + fechamento.ToString());
                                                    resultado = fechamento.Subtract(abertura);

                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString()));//transforma_dia_horas(resultado.ToString());
                                            em_andamento = false;
                                            pode_parar++;
                                            n_paradas++;

                                        }
                                        //se tiver um reinicio
                                        if (dgvParadas.Rows[j].Cells["col_maquina_reinicio"].Value.ToString().ToUpper() == tb_maquina.Text && em_andamento == false &&
                                            Convert.ToString(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value) != "" &&
                                            reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {

                                            // pode_parar++;
                                            abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                            abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString());
                                            em_andamento = true;
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            if (rota_atual.ToString() != dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString())
                                            {
                                                rota_atual = Convert.ToInt32(dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString());

                                                this.datRotas_campo.SelectCommand.CommandText =
                                                "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() + "'";
                                                this.fbConnection1.Open();
                                                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                                                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                                                this.fbConnection1.Close();
                                                datRotas_campo.Fill(ROTAS_CAMPO);

                                            }
                                        }
                                        else
                                        {
                                            if (dgvParadas.Rows[j].Cells["col_maquina_reinicio"].Value.ToString().ToUpper() == tb_maquina.Text &&
                                                    dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                    reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                            {

                                                //pode_parar++;
                                                reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                em_andamento = true;
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                if (rota_atual.ToString() != dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString())
                                                {
                                                    rota_atual = Convert.ToInt32(dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString());

                                                    this.datRotas_campo.SelectCommand.CommandText =
                                                    "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() + "'";
                                                    this.fbConnection1.Open();
                                                    this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                                                    this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                                                    this.fbConnection1.Close();
                                                    datRotas_campo.Fill(ROTAS_CAMPO);
                                                    //dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";

                                                }
                                            }

                                        }
                                        /*
                                        if (pode_parar == onde_posso_parar - 1)
                                        {
                                            pode_parar++;

                                        }
                                         * */
                                    }
                                    catch { }
                                }


                            }
                        }
                    }
                    /*
                    if (ja_calculou == false)
                    {
                        ja_calculou = true;
                        calcula_horas();
                    }
                     * */
                    ja_calculou = false;
                    //saiu do dgvconsulta
                    label_tempo_func.Text = "Tempo total por máquina";

                    for (int i = 0; i < dgvConsulta.RowCount; i++)
                    {
                        try
                        {
                            total_horas_maq = total_horas_maq + Convert.ToDouble(dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value);
                        }
                        catch { }
                    }
                    tb_total_operador.Text = total_horas_maq.ToString("n2");
                    total_horas_maq = 0;
                }
                else
                {
                    //CALCULANDO TODAS AS OS
                    if (cb_todas_os.Checked == true)
                    {
                        horas_parciais_x = 0;
                        total_horas_operador = 0;
                        //loop para percorrer as linhas das rotas                    
                        for (i = 0; i < dgvConsulta.RowCount - 1; i++)
                        {
                            double horas_se = 0;
                            bool se_inicio = false;
                            bool dia_anterior = false;
                            bool sem_fechamento = false;
                            bool passou_reto = false;
                            em_andamento = false; //nova conta
                            
                                
                            
                                //se hora entrada não for null
                                if (dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString() != "" &&
                                    dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                                {


                                    abertura_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                                    abertura_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //para conferir a data de entrada
                                    if (dgvConsulta.Rows[i].Cells["col_se"].Value.ToString() != "")
                                    {
                                        se_inicio = true;
                                        horas_se = Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_se"].Value.ToString());
                                        //PARA SABER SE É SERVIÇO EXTERNO
                                    }
                                    if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() != "" && dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString() != "")
                                        fechamento_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString()); //para conferir a data de fechamento
                                    else
                                        sem_fechamento = true;

                                    //se data está dentro das especificações
                                    if (abertura_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                        abertura_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                    {
                                        abertura_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //coloca no abertura_data a data da célula
                                        abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()).ToShortTimeString()); //junta a data e a hora
                                        em_andamento = true; //abertura capturada
                                    }
                                    else
                                    {
                                        //se abertura foi feita no dia anterior
                                        if (abertura_data_confere == abertura_data_anterior_confere)
                                        {
                                            inicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                            abertura = Convert.ToDateTime(inicio_dia_anterior);
                                            em_andamento = true;
                                            dia_anterior = true;
                                        }
                                    }
                                    for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                                    {
                                        reinicio_parada_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                                        abertura_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                        if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                            reinicio_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                        if (em_andamento == true)
                                        {

                                            //se em andamento e a parada tiver a rota do apontamento de rotas
                                            if (dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() && em_andamento == true)
                                            {
                                                //se for o operador correto e a data estiver nos parâmetros
                                                if (abertura_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                                    abertura_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                                {
                                                    fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                                    fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString()).ToShortTimeString());
                                                    em_andamento = false;
                                                    n_paradas++;
                                                }
                                                else
                                                //se estiver passado o fechamento
                                                {

                                                    //se o fechamento for um dia depois da ultima data
                                                    if (abertura_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)))
                                                    {
                                                        //MessageBox.Show("chegou aqui");
                                                        if (dia_anterior == true)
                                                            parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 00:00:01"; //junta o ultimo dia + o ultimo segundo
                                                        else
                                                            parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                        //parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                        fechamento = Convert.ToDateTime(parada_outro_dia);
                                                        em_andamento = false;
                                                        n_paradas++;
                                                    }
                                                }
                                                //se não estiver em andamento isto é se tiver uma abertura e fechamento tb
                                                if (em_andamento == false)
                                                {
                                                    if (dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString() == "")
                                                        dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value = "1";
                                                    resultado = fechamento.Subtract(abertura); //faça a conta
                                                    if (se_inicio == true)
                                                    {
                                                        total_horas_operador = total_horas_operador + (horas_se
                                                        / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                                        
                                                    }
                                                    else
                                                    {
                                                        total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                            / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                                    }
                                                    ///tb_total_operador.Text = total_horas_operador.ToString();
                                                }
                                                //se tiver um reinicio e for o mesmo operador e for na data
                                                if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                    reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                                    reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                                {
                                                    dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                    abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                                    abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                                    em_andamento = true;
                                                }

                                                else
                                                {
                                                    //se o reinicio foi dado no dia anterior
                                                    if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                        reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                                    {
                                                        dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                        reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                        abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                        em_andamento = true;
                                                    }
                                                }
                                                if (dgvParadas.Rows[j].Cells["col_se_parada"].Value.ToString() != "")
                                                {
                                                    se_inicio = true;
                                                    horas_se = Convert.ToDouble(dgvParadas.Rows[j].Cells["col_se_parada"].Value.ToString());
                                                    
                                                }
                                                else
                                                    se_inicio = false;
                                            }
                                        }
                                        else
                                        {
                                            if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                    reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                                    reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) &&
                                                    dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString())
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                                em_andamento = true;
                                            }

                                            else
                                            {
                                                //se o reinicio foi dado no dia anterior
                                                if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                    reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                                {
                                                    dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                    reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                    abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                    em_andamento = true;
                                                }
                                            }
                                        }

                                    }
                                    //saiu das paradas 
                                    if (em_andamento == true)
                                    {
                                        //se tiver em_andamento  // é aqui que tem que colocar as horas do cartão de ponto
                                        if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "" &&
                                            dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                                        {
                                            date_now_confere = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                            //se data de agora = inicial ou final
                                            if (date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) ||
                                                date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                                fechamento = DateTime.Now;
                                            else
                                            {
                                                parada_outro_dia = Convert.ToString(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) + " 23:59:59";
                                                fechamento = Convert.ToDateTime(parada_outro_dia);
                                            }
                                        }
                                        else
                                        {
                                            //vou calcular o ultimo reinicio e a hora de fechamento
                                            if (sem_fechamento == false &&
                                                fechamento_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                                fechamento_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                            {
                                                fechamento_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                                                fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString()).ToShortTimeString());
                                                em_andamento = false;
                                            }
                                            else
                                            {
                                                //se fechamento for no dia seguinte
                                                if (fechamento_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)))
                                                {
                                                    parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59";
                                                    fechamento = Convert.ToDateTime(parada_outro_dia);
                                                    em_andamento = false;
                                                }
                                                else
                                                {
                                                    if (sem_fechamento == true)
                                                        passou_reto = true; //teve uma abertura mas não teve um fechamento nas condições
                                                }
                                            }
                                        }
                                        if (em_andamento == false && passou_reto == false)
                                        {
                                            if (dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString() == "")
                                                dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value = "1";
                                            resultado = fechamento.Subtract(abertura);
                                            if (se_inicio == true)
                                            {
                                                total_horas_operador = total_horas_operador + (horas_se
                                                / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString())); //transforma o resulta em decimais

                                            }
                                            else
                                            {
                                                total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                    / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString()));
                                            }
                                        }
                                    }
                                }
                                if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "" && passou_reto == false)
                                {
                                    horas_parciais = total_horas_operador - horas_parciais_x;
                                    dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value = horas_parciais.ToString();
                                    horas_parciais_x = total_horas_operador;
                                }
                                em_andamento = false;
                                cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());
                            
                        }
                        Atualizar();
                        //saiu das rotas
                        //tb_total_operador.Text = total_horas_operador.ToString();

                        int n_linhas_atual = dgvConsulta.RowCount;
                        //MessageBox.Show(n_linhas_atual.ToString());
                        int pode_parar = 0;
                        int onde_posso_parar = 0;

                        for (int p = 0; p < dgvParadas.RowCount - 1; p++)
                        {
                            if (Convert.ToString(dgvParadas.Rows[p].Cells["coluna_data_ter"].Value) != "" &&
                                Convert.ToString(dgvParadas.Rows[p].Cells["col_parada_con"].Value) == "")
                                try
                                {
                                    this.datRotas_campo.SelectCommand.CommandText =
                                    "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + dgvParadas.Rows[p].Cells["col_rota_parada"].Value.ToString() + "'";
                                    this.fbConnection1.Open();
                                    this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                                    this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                                    this.fbConnection1.Close();
                                    datRotas_campo.Fill(ROTAS_CAMPO);

                                    //MessageBox.Show(dgvParadas.Rows[p].Cells["col_rota_parada"].Value.ToString());
                                    onde_posso_parar++;
                                }
                                catch { fbConnection1.Close(); }
                        }

                        int n_linhas_depois = dgvConsulta.RowCount;
                        //MessageBox.Show(total_horas_operador.ToString());

                        //MessageBox.Show(n_linhas_depois.ToString());

                        //calculando as paradas que não tem rotas

                        for (i = n_linhas_atual - 1; i < dgvConsulta.RowCount - 1; i++)
                        {
                            double horas_se = 0;
                            bool se_inicio = false;
                            bool dia_anterior = false;
                            bool sem_fechamento = false;
                            bool passou_reto = false;
                            em_andamento = false; //nova conta



                            //se hora entrada não for null
                            if (dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString() != "" &&
                                    dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "")
                            {


                                abertura_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                                abertura_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //para conferir a data de entrada
                                if (dgvConsulta.Rows[i].Cells["col_se"].Value.ToString() != "")
                                {
                                    se_inicio = true;
                                    horas_se = Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_se"].Value.ToString());
                                    //PARA SABER SE É SERVIÇO EXTERNO
                                }
                                if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() != "")
                                    fechamento_data_confere = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString()); //para conferir a data de fechamento
                                else
                                    sem_fechamento = true;
                                //se data está dentro das especificações
                                if (abertura_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                    abertura_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                {
                                    abertura_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString()); //coloca no abertura_data a data da célula
                                    abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString()).ToShortTimeString()); //junta a data e a hora
                                    em_andamento = true; //abertura capturada
                                }
                                else
                                {
                                    //se abertura foi feita no dia anterior
                                    if (abertura_data_confere == abertura_data_anterior_confere)
                                    {
                                        inicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                        abertura = Convert.ToDateTime(inicio_dia_anterior);
                                        em_andamento = true;
                                        dia_anterior = true;
                                    }
                                }
                                for (j = 0; j < (dgvParadas.RowCount - 1); j++)
                                {
                                    reinicio_parada_data_anterior_confere = Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1);
                                    abertura_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                    if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "")
                                        reinicio_parada_data_confere = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                    if (em_andamento == true)
                                    {

                                        //se em andamento e a parada tiver a rota do apontamento de rotas
                                        if (dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() && em_andamento == true)
                                        {
                                            //se for o operador correto e a data estiver nos parâmetros
                                            if (abertura_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                                abertura_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                            {
                                                fechamento_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data"].Value.ToString());
                                                fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora"].Value.ToString()).ToShortTimeString());
                                                em_andamento = false;
                                                n_paradas++;
                                            }
                                            else
                                            //se estiver passado o fechamento
                                            {

                                                //se o fechamento for um dia depois da ultima data
                                                if (abertura_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)))
                                                {
                                                    //MessageBox.Show("chegou aqui");
                                                    if (dia_anterior == true)
                                                        parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 00:00:01"; //junta o ultimo dia + o ultimo segundo
                                                    else
                                                        parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                    //parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59"; //junta o ultimo dia + o ultimo segundo
                                                    fechamento = Convert.ToDateTime(parada_outro_dia);
                                                    em_andamento = false;
                                                    n_paradas++;
                                                }
                                            }
                                            //se não estiver em andamento isto é se tiver uma abertura e fechamento tb
                                            if (em_andamento == false)
                                            {
                                                if (dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString() == "")
                                                    dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value = "1";
                                                resultado = fechamento.Subtract(abertura); //faça a conta
                                                if (se_inicio == true)
                                                {
                                                    total_horas_operador = total_horas_operador + (horas_se
                                                    / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais

                                                }
                                                else
                                                {
                                                    total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                        / Convert.ToInt32(dgvParadas.Rows[j].Cells["col_itens_conjuntos_parada"].Value.ToString())); //transforma o resulta em decimais
                                                }
                                                ///tb_total_operador.Text = total_horas_operador.ToString();
                                            }
                                            //se tiver um reinicio e for o mesmo operador e for na data
                                            if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                                reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                                abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                                em_andamento = true;
                                            }

                                            else
                                            {
                                                //se o reinicio foi dado no dia anterior
                                                if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                    reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                                {
                                                    dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                    reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                    abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                    em_andamento = true;
                                                }
                                            }
                                            if (dgvParadas.Rows[j].Cells["col_se_parada"].Value.ToString() != "")
                                            {
                                                se_inicio = true;
                                                horas_se = Convert.ToDouble(dgvParadas.Rows[j].Cells["col_se_parada"].Value.ToString());

                                            }
                                            else
                                                se_inicio = false;
                                        }
                                    }
                                    else
                                    {
                                        if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                                reinicio_parada_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) &&
                                                dgvParadas.Rows[j].Cells["col_rota_parada"].Value.ToString() == dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString())
                                        {
                                            dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                            abertura_data = Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString());
                                            abertura = Convert.ToDateTime(abertura_data.ToShortDateString() + " " + Convert.ToDateTime(dgvParadas.Rows[j].Cells["coluna_hora_ter"].Value.ToString()).ToShortTimeString());
                                            em_andamento = true;
                                        }

                                        else
                                        {
                                            //se o reinicio foi dado no dia anterior
                                            if (dgvParadas.Rows[j].Cells["coluna_data_ter"].Value.ToString() != "" &&
                                                reinicio_parada_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()).AddDays(-1)))
                                            {
                                                dgvParadas.Rows[j].Cells["col_parada_con"].Value = "Sim";
                                                reinicio_dia_anterior = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value)).ToShortDateString())) + " 00:00:01"; //junta a primeira daa da consulta com o primeiro segundo do dia
                                                abertura = Convert.ToDateTime(reinicio_dia_anterior);
                                                em_andamento = true;
                                            }
                                        }
                                    }

                                }
                                //saiu das paradas 
                                if (em_andamento == true)
                                {
                                    //se tiver em_andamento  // é aqui que tem que colocar as horas do cartão de ponto
                                    if (dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString() == "" &&
                                        dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "EM ANDAMENTO")
                                    {
                                        date_now_confere = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                        //se data de agora = inicial ou final
                                        if (date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) ||
                                            date_now_confere == Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                            fechamento = DateTime.Now;
                                        else
                                        {
                                            parada_outro_dia = Convert.ToString(Convert.ToDateTime(dtFinal.Value).ToShortDateString()) + " 23:59:59";
                                            fechamento = Convert.ToDateTime(parada_outro_dia);
                                        }
                                    }
                                    else
                                    {
                                        //vou calcular o ultimo reinicio e a hora de fechamento
                                        if (sem_fechamento == false &&
                                            fechamento_data_confere >= Convert.ToDateTime(Convert.ToDateTime(dtInicial.Value).ToShortDateString()) &&
                                            fechamento_data_confere <= Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()))
                                        {
                                            fechamento_data = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_fechamento"].Value.ToString());
                                            fechamento = Convert.ToDateTime(fechamento_data.ToShortDateString() + " " + Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_hora_fechamento"].Value.ToString()).ToShortTimeString());
                                            em_andamento = false;
                                        }
                                        else
                                        {
                                            //se fechamento for no dia seguinte
                                            if (fechamento_data_confere == (Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value).ToShortDateString()).AddDays(1)))
                                            {
                                                parada_outro_dia = Convert.ToString((Convert.ToDateTime(Convert.ToDateTime(dtFinal.Value)).ToShortDateString())) + " 23:59:59";
                                                fechamento = Convert.ToDateTime(parada_outro_dia);
                                                em_andamento = false;
                                            }
                                            else
                                            {
                                                if (sem_fechamento == true)
                                                    passou_reto = true; //teve uma abertura mas não teve um fechamento nas condições
                                            }
                                        }
                                    }
                                    if (em_andamento == false && passou_reto == false)
                                    {
                                        if (dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString() == "")
                                            dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value = "1";
                                        resultado = fechamento.Subtract(abertura);
                                        if (se_inicio == true)
                                        {
                                            total_horas_operador = total_horas_operador + (horas_se
                                            / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString())); //transforma o resulta em decimais

                                        }
                                        else
                                        {
                                            total_horas_operador = total_horas_operador + ((transforma_dia_horas(resultado.ToString()))
                                                / Convert.ToInt32(dgvConsulta.Rows[i].Cells["OS_CONJUNTAS_FECHAMENTO"].Value.ToString()));
                                        }
                                    }
                                }
                            }
                            if (dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString() != "" && passou_reto == false)
                            {
                                horas_parciais = total_horas_operador - horas_parciais_x;
                                dgvConsulta.Rows[i].Cells["HORAS_OPERADOR"].Value = horas_parciais.ToString();
                                horas_parciais_x = total_horas_operador;
                            }
                            em_andamento = false;
                            cod_rota_consultados[i] = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString());
                        }
                        for (i = 0; i < (dgvConsulta.RowCount - 1); i++)
                        {



                            if (dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() !=
                                dgvConsulta.Rows[i].Cells["col_retrabalho"].Value.ToString())
                            {
                                try
                                {
                                    total_horas_ret = total_horas_ret + Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_saldo_horas"].Value);
                                }
                                catch { }
                                ///    }
                                ///    try
                                ///    {
                                ///    
                            }
                            //if (Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_saldo_horas"].Value) > 0)
                            // {
                            try
                            {
                                total_horas_prev = total_horas_prev + Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value);
                                total_horas_trab = total_horas_trab + Convert.ToDouble(dgvConsulta.Rows[i].Cells["col_saldo_horas"].Value);
                            }
                            catch { }
                            // }
                            //MessageBox.Show(total_horas_trab.ToString("n2"));

                            ///   }
                            ///      catch { }





                            tb_horas_retrabalho.Text = total_horas_ret.ToString("n2");
                            //tbTotal_horas.Text = total_horas_trab.ToString("n2");
                            tb_horas_previstas.Text = total_horas_prev.ToString("n2");
                            tbTotal_horas.Text = total_horas_operador.ToString("n2");

                        }
                        tb_total_operador.Text = total_horas_operador.ToString();

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

        private void modifica_separador(string data_inicial, string data_final)
        {
            int p = 0;
            int q = 0;
            for (int m = 0; m < 10; m++)
            {
                if (data_inicial[m].ToString() == "/")
                {
                    di = di + ".";
                    p++;
                    if (p == 2)
                        break;
                }
                else
                    di = di + data_inicial[m].ToString();
            }
            for (int m = 0; q == 2; m++)
            {
                if (data_final[m].ToString() == "/")
                {
                    df = df + ".";
                    q++;
                }
                else
                    df = df + data_final[m];
            }
            data_final_atualizada = df;
            data_inicial_atualizada = di;
        }
        private void tb_posicao_Validated(object sender, EventArgs e)
        {

            this.datOp.SelectCommand.CommandText =
                    "SELECT * FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_peca.Text + "%' AND N_PDF = '" + tb_posicao.Text + "'";
            this.fbConnection1.Open();
            this.datOp.SelectCommand.Connection = fbConnection1;
            this.datOp.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datOp.Fill(OP);

        }

        private void tb_posicao_Validating(object sender, CancelEventArgs e)
        {

            this.datOp.SelectCommand.CommandText =
                    "SELECT * FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_peca.Text + "%' AND N_PDF = '" + tb_posicao.Text + "'";
            this.fbConnection1.Open();
            this.datOp.SelectCommand.Connection = fbConnection1;
            this.datOp.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datOp.Fill(OP);

        }

        private void tbCod_op_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvConsulta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            try
            {
                abre_rota.rota_atual = dgvConsulta.Rows[e.RowIndex].Cells[0].Value;
                abre_rota.ShowDialog();
            }
            finally
            {
                abre_rota.Dispose();
                datRotas_campo.Fill(ROTAS_CAMPO);
            }
        }

        private void inserir_nas_semanas(int i, int ano, int semana, string horas, string rotas)
        {
            
            if (primeiro == true)
            {
                this.datSemanas.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = 0" +
                        " WHERE ROTA_HORAS_SEMANA = '" + rotas +  
                        "'";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                //MessageBox.Show("zerado");
                primeiro = false;
            }
             
            //MessageBox.Show("update");
            this.datSemanas.UpdateCommand.CommandText =
                       "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = (HORAS_REAIS_OPERACAO + " + horas.Replace(",",".") + 
                       ") WHERE ROTA_HORAS_SEMANA = '" + rotas +
                       "' AND N_SEMANA = '" + semana.ToString() + "'";
            this.fbConnection1.Open();
            this.datSemanas.UpdateCommand.Connection = fbConnection1;
            //this.datSemanas.UpdateCommand.ExecuteNonQuery();
            int registros = datSemanas.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show(registros.ToString());
            
            if(registros == 0)
            {
                //MessageBox.Show("novo registro");
                //try
                //{
                
                try
                {
                    ent_prev = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_ent_prev"].Value).ToShortDateString().Replace("/", ".");
                }
                catch { }
                try
                {
                    sai_prev = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_fec_prev"].Value).ToShortDateString().Replace("/", ".");
                }
                    
                catch { }
                if (ent_prev == null || sai_prev == null)
                {
                    if (dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value.ToString() == "")
                        dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value = "0";
                    this.datSemanas.InsertCommand.CommandText =
                        "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA," +
                        "HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, SITUACAO_ROTA_SEMANA, HORAS_REAIS_OPERACAO)" +
                        "VALUES ('" + semana + "','" + ano + "','" +
                        dgvConsulta.Rows[i].Cells["col_operacao"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_os"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_posicao"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() + "','" +
                        horas.Replace(",", ".") + "')";
                    this.fbConnection1.Open();
                    this.datSemanas.InsertCommand.Connection = fbConnection1;
                    this.datSemanas.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }

                else
                {
                    if (dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value.ToString() == "")
                        dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value = "0";
                    this.datSemanas.InsertCommand.CommandText =
                        "INSERT INTO HORAS_SEMANA (N_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA," +
                        "HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA, SITUACAO_ROTA_SEMANA, DATA_INICIO_SEMANA, " +
                        "DATA_FIM_SEMANA, HORAS_REAIS_OPERACAO)" +
                        "VALUES ('" + semana + "','" + ano + "','" +
                        dgvConsulta.Rows[i].Cells["col_operacao"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_horas_previstas"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_os"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_posicao"].Value.ToString() + "','" +
                        dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() + "','" +
                        ent_prev + "','" +
                        sai_prev + "','" +
                        horas.Replace(",", ".") + "')";
                    this.fbConnection1.Open();
                    this.datSemanas.InsertCommand.Connection = fbConnection1;
                    this.datSemanas.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                //}
                //catch { }
                
            }
            

            
        }

        private void apagar_das_semanas(int i)
        {
            if (dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "FINALIZADO"
                || dgvConsulta.Rows[i].Cells["col_posicao_atual"].Value.ToString() == "RETRABALHO")
            {
                this.datSemanas.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE ROTA_HORAS_SEMANA = '" + dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() + "' AND (HORAS_REAIS_OPERACAO IS NULL) AND DATA_EXCLUSAO_SEMANA IS NULL";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datSemanas.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'CONSULTA 1' WHERE ROTA_HORAS_SEMANA = '" + dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() + "' AND (HORAS_REAIS_OPERACAO IS NULL) AND DATA_EXCLUSAO_SEMANA IS NULL";
                this.fbConnection1.Open();
                this.datSemanas.UpdateCommand.Connection = fbConnection1;
                this.datSemanas.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                /*
                this.datSemanas.DeleteCommand.CommandText =
                        "DELETE FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + dgvConsulta.Rows[i].Cells["col_cod_rota"].Value.ToString() + "' AND (HORAS_REAIS_OPERACAO IS NULL)";
                this.fbConnection1.Open();
                this.datSemanas.DeleteCommand.Connection = fbConnection1;
                this.datSemanas.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                */
            }

        }

        private void tbRefazer_Click(object sender, EventArgs e)
        {
            refazer();
        }

        private void refazer()
        {
            cb_todas_os.Checked = false;
            total_horas_trab = 0;
            tb_horas_retrabalho.Text = "";
            tb_horas_previstas.Text = "";
            total_horas_ret = 0;
            total_horas_prev = 0;
            cb_operacao.Text = "";
            label_tempo_func.Text = "Tempo total por funcionário";
            dsOp.Clear();
            dsParadas.Clear();
            dsRotas_campo.Clear();
            tb_maquina.Text = "";
            tb_operador.Text = "";
            cbTodas_datas.Checked = false;
            cbUm_dia.Checked = false;
            tb_peca.Text = "";
            tb_posicao.Text = "";
            tbCod_op.Text = "";
            horas_parciais = 0;
            horas_parciais_x = 0;
            opcoes = 0;
            radioTotalhoras.Checked = false;
            radioOperacoes_finalizadas.Checked = false;
            radioOperacoes_previstas.Checked = false;
            radioOperacoes_atrasadas.Checked = false;
            cbTodas_datas.Visible = true;
            dtFinal.Visible = true;
            labelDtFinal.Visible = true;

            n_paradas = 0;
            separa_dias = "";
            separa_horas = "";
            separa_minutos = "";
            minutos_decimais = 0;
            rota_atual = 0; ;
            operacao_ja_somada = false; ;
            total_horas_str = "";
            horas_dias = 0;
            k = 0;
            total_horas_operador = 0;
            total_horas_operador_parcial = 0;
            horas_parciais = 0;
            horas_parciais_x = 0;
            tb_total_operador.Text = "";
            tbTotal_horas.Text = "";
            for (int l = 0; l < 50000; l++)
            {
                cod_rota_consultados[l] = 0;
            }
            for (int l = 0; l < 50000; l++)
            {
                cod_parada_consultados[l] = 0;
            }

            //outras variaveis
            em_andamento = false;
            opcoes = 0;
            breca = false;
            i = 0;
            j = 0;
            m = 0;
            total_horas_operador = 0;
            total_horas_operador_parcial = 0;
            tb_total_operador.Text = "";
            horas_operador_ponto = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

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
            separa_minutos = "" ;
            minutos_decimais = 0;
            total_horas_str = "";
            horas_dias = 0;
            k = 0;
            
            total_horas_operador_parcial = 0;
        }

        private void calcula_operacao_nao_concluida()
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            this.BindingContext[dsParadas, "PARADAS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsParadas.HasChanges())
            {
                datParadas.UpdateCommand = cbParadas.GetUpdateCommand();
                datParadas.InsertCommand = cbParadas.GetInsertCommand();
                datParadas.DeleteCommand = cbParadas.GetDeleteCommand();
                datParadas.Update(dsParadas, "PARADAS");
                dsParadas.AcceptChanges();

            }
            this.BindingContext[dsRotas_campo, "ROTAS_CAMPO"].EndCurrentEdit();
            if (dsRotas_campo.HasChanges())
            {
                datRotas_campo.UpdateCommand = cbRotas_campo.GetUpdateCommand();
                datRotas_campo.InsertCommand = cbRotas_campo.GetInsertCommand();
                datRotas_campo.DeleteCommand = cbRotas_campo.GetDeleteCommand();
                datRotas_campo.Update(dsRotas_campo, "ROTAS_CAMPO");
                dsRotas_campo.AcceptChanges();

            }
            fbConnection1.Close();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimir_agora = true;
            Atualizar();
            this.datTabela_impressao.SelectCommand.CommandText =
            "SELECT * FROM TABELA_IMPRESSAO";
            this.fbConnection1.Open();
            this.datTabela_impressao.SelectCommand.Connection = fbConnection1;
            this.datTabela_impressao.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            if (tb_operador.Text != "" || tb_maquina.Text != "")
            {
                dsConsulta dsRelatorio = new dsConsulta();
                fbConnection1.Open();
                datTabela_impressao.Fill(dsRelatorio.TABELA_IMPRESSAO);
                datOperadores.Fill(dsRelatorio.OPERADORES);
                fbConnection1.Close();
                crPesquisa_operador relatorio = new crPesquisa_operador();
                relatorio.SetDataSource(dsRelatorio);
                form_imprimir imprimir = new form_imprimir(relatorio);
                imprimir.Show();
            }
            if(tb_peca.Text != "")
            {
                this.datOp.SelectCommand.CommandText =
                "SELECT * FROM OP WHERE UPPER(DESENHO_OP_ATUAL) LIKE UPPER('" + tb_peca.Text + "') AND UPPER(N_PDF) LIKE UPPER('" + tb_peca.Text + "')";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
               
                dsConsulta dsRelatorio = new dsConsulta();
                fbConnection1.Open();
                datTabela_impressao.Fill(dsRelatorio.TABELA_IMPRESSAO);
                datOp.Fill(dsRelatorio.OP);
                fbConnection1.Close();
                crPesquisa_os relatorio = new crPesquisa_os();
                relatorio.SetDataSource(dsRelatorio);
                form_imprimir imprimir = new form_imprimir(relatorio);
                imprimir.Show();
            }
        }

        private void imprimir_relat_func()
        {
            this.datConsulta_oper.SelectCommand.CommandText =
                "SELECT * FROM CONSULTA_OPER WHERE HORAS_SIST_OPER != 0 ORDER BY COD_CONSULTA_OPER";
            this.fbConnection1.Open();
            this.datConsulta_oper.SelectCommand.Connection = fbConnection1;
            this.datConsulta_oper.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            dsConsulta dsRelatorio = new dsConsulta();
            fbConnection1.Open();
            datConsulta_oper.Fill(dsRelatorio.CONSULTA_OPER);
            fbConnection1.Close();
            crPesquisa_todos_oper relatorio = new crPesquisa_todos_oper();
            relatorio.SetDataSource(dsRelatorio);
            form_imprimir imprimir = new form_imprimir(relatorio);
            imprimir.Show();
        }

        private void bt_Inserir_impressao_Click(object sender, EventArgs e)
        {
            
            if (tb_operador.Text != "")
            {
                
                for (n = 0; n < dgvConsulta.RowCount - 1; n++)
                {
                    String novo_num = dgvConsulta.Rows[n].Cells["horas_operador"].Value.ToString().Replace(",", ".");
                    try
                    {
                        this.datTabela_impressao.InsertCommand.CommandText =
                        "INSERT INTO TABELA_IMPRESSAO (CODIGO_ROTA_IMPRESSAO, OPERADOR_IMPRESSAO, OS_IMPRESSAO, POSICAO_IMPRESSAO, HORA_ENTRADA_IMPRESSAO, DATA_ENTRADA_IMPRESSAO, HORA_FECHAMENTO_IMPRESSAO, DATA_FECHAMENTO_IMPRESSAO, HORAS_OPERADOR_IMPRESSAO)" +
                        "VALUES ('" + dgvConsulta.Rows[n].Cells["col_cod_rota"].Value.ToString() + "','" + tb_operador.Text + "','" + dgvConsulta.Rows[n].Cells["col_os"].Value.ToString() + "','" + dgvConsulta.Rows[n].Cells["col_posicao"].Value.ToString() + "','" + dgvConsulta.Rows[n].Cells["col_hora_entrada"].Value.ToString() + "','" + dgvConsulta.Rows[n].Cells["col_data_entrada"].Value.ToString() + "','" + dgvConsulta.Rows[n].Cells["col_hora_fechamento"].Value.ToString() + "','" + dgvConsulta.Rows[n].Cells["col_data_fechamento"].Value.ToString() + "','" + novo_num + "')";
                        this.fbConnection1.Open();
                        this.datTabela_impressao.InsertCommand.Connection = fbConnection1;
                        this.datTabela_impressao.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch {
                        fbConnection1.Close();
                    }
                }
            }
            if (tb_peca.Text != "")
            {
                for (n = 0; n < dgvConsulta.RowCount - 1 ; n++)
                {
                    String novo_num = dgvConsulta.Rows[n].Cells["col_saldo_horas"].Value.ToString().Replace(",", ".");
                    this.datTabela_impressao.InsertCommand.CommandText =
                    "INSERT INTO TABELA_IMPRESSAO (CODIGO_ROTA_IMPRESSAO, OS_IMPRESSAO, POSICAO_IMPRESSAO, HORA_ENTRADA_IMPRESSAO, DATA_ENTRADA_IMPRESSAO, HORA_FECHAMENTO_IMPRESSAO, DATA_FECHAMENTO_IMPRESSAO, HORAS_OPERACAO_IMPRESSAO)" +
                    "VALUES ('" + dgvConsulta.Rows[n].Cells["col_cod_rota"].Value + "','" + dgvConsulta.Rows[n].Cells["col_os"].Value + "','" + dgvConsulta.Rows[n].Cells["col_posicao"].Value + "','" + dgvConsulta.Rows[n].Cells["col_hora_entrada"].Value + "','" + dgvConsulta.Rows[n].Cells["col_data_entrada"].Value + "','" + dgvConsulta.Rows[n].Cells["col_hora_fechamento"].Value + "','" + dgvConsulta.Rows[n].Cells["col_data_fechamento"].Value + "','" + novo_num + "')";
                    this.fbConnection1.Open();
                    this.datTabela_impressao.InsertCommand.Connection = fbConnection1;
                    this.datTabela_impressao.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
            }

        }

        private void bt_Apagar_impressoes_Click(object sender, EventArgs e)
        {
            this.datTabela_impressao.InsertCommand.CommandText =
                "DELETE FROM TABELA_IMPRESSAO";
            this.fbConnection1.Open();
            this.datTabela_impressao.InsertCommand.Connection = fbConnection1;
            this.datTabela_impressao.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void atualizarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_consulta_ponto ponto = new form_consulta_ponto();
            ponto.operador_atual = tb_operador.Text;
            ponto.data_inicial = dtInicial.Text;
            ponto.data_final = dtFinal.Text;
            if (cbUm_dia.Checked == true)
                ponto.um_dia = true;
            else
                ponto.um_dia = false;
            ponto.consulta_conjunta = true;
            ponto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_consulta_ponto ponto = new form_consulta_ponto();
            ponto.operador_atual = tb_operador.Text;
            ponto.data_inicial = dtInicial.Text;
            ponto.data_final = dtFinal.Text;
            if (cbUm_dia.Checked == true)
                ponto.um_dia = true;
            else
                ponto.um_dia = false;
            ponto.consulta_conjunta = true;
            ponto.consulta_operador = false;
            try
            {
                ponto.Show();
            }
            finally
            {
                horas_operador_ponto = ponto.total_operador_consulta;

            }
            
        }

        private void consulta_ponto()
        {
            form_consulta_ponto ponto = new form_consulta_ponto();
            ponto.operador_atual = tb_operador.Text;
            ponto.data_inicial = dtInicial.Text;
            ponto.data_final = dtFinal.Text;
            if (cbUm_dia.Checked == true)
                ponto.um_dia = true;
            else
                ponto.um_dia = false;
            ponto.consulta_conjunta = true;
            ponto.consulta_operador = true;
            try
            {
                ponto.Show();
            }
            finally
            {
                horas_operador_ponto = ponto.total_operador_consulta;
                ponto.Dispose();
                
            }
            
            
            

        }

        private void tb_operador_DoubleClick(object sender, EventArgs e)
        {
            form_localiza_operador localiza_operador = new form_localiza_operador();
            try
            {
                localiza_operador.ShowDialog();
            }
            finally
            {
                tb_operador.Text = localiza_operador.operador_escolhido;
                localiza_operador.Dispose();
                
            }
        }

        private void dgvParadas_Click(object sender, EventArgs e)
        {
            dgvParadas.Height = 150;
        }

        private void bt_os_conj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvConsulta.RowCount.ToString());
            for (int i = 0; i < dgvConsulta.RowCount - 1; i++)
            {
                if (Convert.ToString(dgvConsulta.Rows[i].Cells["col_consultados"].Value) != "1" && Convert.ToString(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value) != "")
                {
                    int[] rotas_conj = new int[30];
                    try
                    {
                        os_conj_atual = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_os_conjuntas"].Value);
                    }
                    catch { }
                    try
                    {
                        rota_atual_os = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_cod_rota"].Value);
                    }
                    catch { }
                    try
                    {
                        maquina_atual = dgvConsulta.Rows[i].Cells["col_maquina"].Value.ToString();
                    }
                    catch { }
                    try
                    {
                        operador_atual = Convert.ToInt32(dgvConsulta.Rows[i].Cells["col_operador_inicio"].Value.ToString());
                    }
                    catch { }
                    try
                    {
                        DateTime data_aux = Convert.ToDateTime(dgvConsulta.Rows[i].Cells["col_data_entrada"].Value.ToString());
                        momento_atual = Convert.ToDateTime(data_aux.ToShortDateString() +
                            " " + dgvConsulta.Rows[i].Cells["col_hora_entrada"].Value.ToString());
                        momento_ant = momento_atual.AddMinutes(-10);
                        momento_post = momento_atual.AddMinutes(10);
                    }
                    catch { }
                    //MessageBox.Show(momento_atual.ToString());
                    for (int j = i + 1; j < dgvConsulta.RowCount - 1; j++)
                    {
                        //MessageBox.Show(j.ToString());
                        
                        try
                        {
                            rota_comp = Convert.ToInt32(dgvConsulta.Rows[j].Cells["col_cod_rota"].Value.ToString());
                            //MessageBox.Show("rota pega é " + rota_comp.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("erro na linha (rota) " + j.ToString());
                        }
                            maquina_comp = dgvConsulta.Rows[j].Cells["col_maquina"].Value.ToString();
                        
                        
                        try
                        {
                            operador_comp = Convert.ToInt32(dgvConsulta.Rows[j].Cells["col_operador_inicio"].Value.ToString());
                        }
                        catch {
                            MessageBox.Show("erro na linha  (operador)" + j.ToString());
                        }
                        try
                        {
                            DateTime data_aux2 = Convert.ToDateTime(dgvConsulta.Rows[j].Cells["col_data_entrada"].Value.ToString());
                            data_comparativa = Convert.ToDateTime(data_aux2.ToShortDateString() +
                                " " + dgvConsulta.Rows[j].Cells["col_hora_entrada"].Value.ToString());
                        }
                        catch {
                            MessageBox.Show("erro na linha (data) " + j.ToString());
                        }
                        if (data_comparativa > momento_ant && data_comparativa < momento_post)
                        {
                            if (maquina_comp == maquina_atual && operador_atual == operador_comp)
                            {
                                dgvConsulta.Rows[j].Cells["col_consultados"].Value = "1";
                                existem_rotas_conj = true;
                                n_os_conj++;
                                rotas_conj[n_os_conj] = rota_comp;
                                //MessageBox.Show(rotas_conj[n_os_conj].ToString());
                            }

                        }
                    }

                    if (existem_rotas_conj == true)
                    {
                        rotas_conj[1] = rota_atual_os;
                        for (int k = 1; k <= n_os_conj; k++)
                        {
                            this.datRotas_campo.UpdateCommand.CommandText =
                            "UPDATE ROTAS_CAMPO SET OS_CONJUNTAS = " + n_os_conj.ToString() + " WHERE COD_ROTA_CAMPO = " + rotas_conj[k].ToString();
                            this.fbConnection1.Open();
                            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();

                            this.datRotas_campo.UpdateCommand.CommandText =
                            "UPDATE ROTAS_CAMPO SET OS_CONJUNTAS_FECHAMENTO = " + n_os_conj.ToString() + " WHERE COD_ROTA_CAMPO = " + rotas_conj[k].ToString();
                            this.fbConnection1.Open();
                            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();

                            this.datParadas.UpdateCommand.CommandText =
                            "UPDATE PARADAS SET ITENS_CONJUNTOS_PARADA = " + n_os_conj.ToString() + " WHERE N_ROTAS_CAMPO = '" + rotas_conj[k].ToString() + "'";
                            this.fbConnection1.Open();
                            this.datParadas.UpdateCommand.Connection = fbConnection1;
                            this.datParadas.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();

                            this.datParadas.UpdateCommand.CommandText =
                            "UPDATE PARADAS SET ITENS_CONJUNTOS_REINICIO = " + n_os_conj.ToString() + " WHERE N_ROTAS_CAMPO = '" + rotas_conj[k].ToString() + "'";
                            this.fbConnection1.Open();
                            this.datParadas.UpdateCommand.Connection = fbConnection1;
                            this.datParadas.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();
                       }

                    }
                    else
                    {
                    }
                    existem_rotas_conj = false;
                    n_os_conj = 1;
                    rotas_conj = null;

                }
            }
        }

        private void acertar_externos()
        {
            
            for(int p = 0; p < dgvConsulta.RowCount - 1; p++)
            {
                if (dgvConsulta.Rows[p].Cells["col_se"].Value.ToString() == "1")
                {
                    try
                    {
                        string saldo = dgvConsulta.Rows[p].Cells["col_saldo_horas"].Value.ToString().Replace(",", ".");
                        this.datSemanas.UpdateCommand.CommandText =
                                "UPDATE HORAS_SEMANA SET HORAS_REAIS_OPERACAO = " + saldo + " WHERE ROTA_HORAS_SEMANA = '" +
                                 dgvConsulta.Rows[p].Cells["col_cod_rota"].Value.ToString() + "'";
                        this.fbConnection1.Open();
                        this.datSemanas.UpdateCommand.Connection = fbConnection1;
                        this.datSemanas.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch 
                    {
                        fbConnection1.Close();
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //calcula_horas();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                excluir(dgvConsulta.SelectedRows[0].Cells[0].Value.ToString());
               
            }
            catch
            {
                MessageBox.Show("Selecione a linha inteira por favor");
                fbConnection1.Close();
            }
        }

        private void excluir(string cod)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                    "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        
                        
                        this.datRotas_campo.DeleteCommand.CommandText =
                        "DELETE FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datRotas_campo.DeleteCommand.Connection = fbConnection1;
                        this.datRotas_campo.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        
                        this.datSemanas.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE ROTA_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                        this.fbConnection1.Open();
                        this.datSemanas.UpdateCommand.Connection = fbConnection1;
                        this.datSemanas.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datSemanas.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'OP 2' WHERE ROTA_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                        this.fbConnection1.Open();
                        this.datSemanas.UpdateCommand.Connection = fbConnection1;
                        this.datSemanas.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        /*
                        this.datHoras_semana.DeleteCommand.CommandText =
                        "DELETE FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datHoras_semana.DeleteCommand.Connection = fbConnection1;
                        this.datHoras_semana.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                         * */
                        //comecar();
                        refazer();
                        consulta_opcoes();

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

        private void button4_Click(object sender, EventArgs e)
        {
            iso();
        }

        private void iso()
        {
            this.Cursor = Cursors.WaitCursor;
            calcular_valores();
            gerar_xml();
            gerar_html();
            System.Diagnostics.Process.Start(@"c:\evolucao_dokinos\\grafico_horas.htm");
            this.Cursor = Cursors.Default;
            
        }

        private void calcular_valores()
        {
            DateTime data_inicial = new DateTime();
            DateTime data_final = new DateTime();
            
            //calculando janeiro
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/01/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_jan = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_jan = 0;
            }
            try
            {
                hr_jan = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_jan = 0;
            }
            try
            {
                if (hp_jan == 0 || hr_jan == 0)
                    porc_jan = 0;
                else
                    porc_jan = (hr_jan / hp_jan) * 100;
            }
            catch
            {
                porc_jan = 0;
            }
            refazer();

            //calculando fevereiro
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/02/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_fev = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_fev = 0;
            }
            try
            {
                hr_fev = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_fev = 0;
            }
            try
            {
                if (hp_fev == 0 || hr_fev == 0)
                    porc_fev = 0;
                else
                    porc_fev = (hr_fev / hp_fev) * 100;
            }
            catch
            {
                porc_fev = 0;
            }
            
            refazer();

            //calculando março
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/03/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_mar = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_mar = 0;
            }
            try
            {
                hr_mar = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_mar = 0;
            }
            try
            {
                if (hp_mar == 0 || hr_mar == 0)
                    porc_mar = 0;
                else
                    porc_mar = (hr_mar / hp_mar) * 100;
            }
            catch
            {
                porc_mar = 0;
            }
            refazer();

            //calculando abril
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/04/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_abr = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_abr = 0;
            }
            try
            {
                hr_abr = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_abr = 0;
            }
            try
            {
                if (hp_abr == 0 || hr_abr == 0)
                    porc_abr = 0;
                else
                    porc_abr = (hr_abr / hp_abr) * 100;
            }
            catch
            {
                porc_abr = 0;
            }
            refazer();

            //calculando maio
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/05/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_mai = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_mai = 0;
            }
            try
            {
                hr_mai = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_mai = 0;
            }
            try
            {
                if (hp_mai == 0 || hr_mai == 0)
                    porc_mai = 0;
                else
                    porc_mai = (hr_mai / hp_mai) * 100;
            }
            catch
            {
                porc_mai = 0;
            }
            refazer();

            //calculando junho
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/06/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_jun = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_jun = 0;
            }
            try
            {
                hr_jun = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_jun = 0;
            }
            try
            {
                if (hp_jun == 0 || hr_jun == 0)
                    porc_jun = 0;
                else
                    porc_jun = (hr_jun / hp_jun) * 100;
            }
            catch
            {
                porc_jun = 0;
            }
            refazer();

            //calculando julho
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/07/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_jul = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_jul = 0;
            }
            try
            {
                hr_jul = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_jul = 0;
            }
            try
            {
                if (hp_jul == 0 || hr_jul == 0)
                    porc_jul = 0;
                else
                    porc_jul = (hr_jul / hp_jul) * 100;
            }
            catch
            {
                porc_jul = 0;
            }
            refazer();

            //calculando agosto
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/08/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_ago = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_ago = 0;
            }
            try
            {
                hr_ago = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_ago = 0;
            }
            try
            {
                if (hp_ago == 0 || hr_ago == 0)
                    porc_ago = 0;
                else
                    porc_ago = (hr_ago / hp_ago) * 100;
            }
            catch
            {
                porc_ago = 0;
            }
            refazer();

            //calculando setembro
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/08/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_set = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_set = 0;
            }
            try
            {
                hr_set = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_set = 0;
            }
            try
            {
                if (hp_set == 0 || hr_set == 0)
                    porc_set = 0;
                else
                    porc_set = (hr_set / hp_set) * 100;
            }
            catch
            {
                porc_set = 0;
            }
            refazer();
            //calculando outubro
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/09/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_out = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_out = 0;
            }
            try
            {
                hr_out = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_out = 0;
            }
            try
            {
                if (hp_out == 0 || hr_out == 0)
                    porc_out = 0;
                else
                    porc_out = (hr_out / hp_out) * 100;
            }
            catch
            {
                porc_out = 0;
            }
            refazer();

            //calculando novembro
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/10/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_nov = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_nov = 0;
            }
            try
            {
                hr_nov = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_nov = 0;
            }
            try
            {
                if (hp_nov == 0 || hr_nov == 0)
                    porc_nov = 0;
                else
                    porc_nov = (hr_nov / hp_nov) * 100;
            }
            catch
            {
                porc_nov = 0;
            }
            refazer();

            //calculando dezembro
            
            cb_todas_os.Checked = true;
            radioTotalhoras.Checked = true;
            data_inicial = Convert.ToDateTime("01/12/" + tb_ano_iso.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dtInicial.Text = data_inicial.ToShortDateString();
            dtFinal.Text = data_final.ToShortDateString();
            consulta_opcoes();
            try
            {
                hp_dez = Convert.ToDouble(tb_horas_previstas.Text);
            }
            catch
            {
                hp_dez = 0;
            }
            try
            {
                hr_dez = Convert.ToDouble(tbTotal_horas.Text);
            }
            catch
            {
                hr_dez = 0;
            }
            try
            {
                if (hp_dez == 0 || hr_dez == 0)
                    porc_dez = 0;
                else
                    porc_dez = (hr_dez / hp_dez) * 100;
            }
            catch
            {
                porc_dez = 0;
            }
            refazer();
        }

        private void gerar_xml()
        {
            XmlWriterSettings settings = new XmlWriterSettings();

            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(@"C:\\evolucao_dokinos\\" + "hp_x_hr.xml", settings))
            {
                //Inicio do elemento

                writer.WriteStartElement("graph");
                writer.WriteAttributeString("caption", "HP x HR");
                writer.WriteAttributeString("PYAxisName", "HORAS");
                writer.WriteAttributeString("SYAxisName", "%");
                writer.WriteAttributeString("showvalues", "0");
                writer.WriteAttributeString("numDivLines", "4");
                writer.WriteAttributeString("formatNumberScale", "0");
                writer.WriteAttributeString("decimalPrecision", "0");
                writer.WriteAttributeString("anchorSides", "10");
                writer.WriteAttributeString("anchorRadius", "3");
                writer.WriteAttributeString("anchorBorderColor", "009900");
                //Elemento dentro do elemento Chart
                writer.WriteStartElement("categories");
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "JAN");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "FEV");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "MAR");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "ABR");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "MAI");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "JUN");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "JUL");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "AGO");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "SET");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "OUT");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "NOV");
                writer.WriteEndElement(); //fecha category
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "DEZ");
                writer.WriteEndElement();
                writer.WriteEndElement(); //fecha categories

                writer.WriteStartElement("dataset");
                writer.WriteAttributeString("seriesName", "HORAS PREVISTAS");
                writer.WriteAttributeString("color", "FF3300");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_jan.ToString("n2").Replace(".","").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_fev.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_mar.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_abr.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_mai.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_jun.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_jul.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_ago.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_set.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_out.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_nov.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hp_dez.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("dataset");
                writer.WriteAttributeString("seriesName", "HORAS REALIZADAS");
                writer.WriteAttributeString("color", "00FF00");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_jan.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_fev.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_mar.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_abr.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_mai.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_jun.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_jul.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_ago.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_set.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_out.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_nov.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", hr_dez.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("dataset");
                writer.WriteAttributeString("seriesName", "META");
                writer.WriteAttributeString("color", "FF0000");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteAttributeString("parentYAxis", "S");
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "80");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("dataset");
                writer.WriteAttributeString("seriesName", "% HP x HR");
                writer.WriteAttributeString("color", "0000CC");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteAttributeString("parentYAxis", "S");
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_jan.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_fev.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_mar.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_abr.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_mai.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_jun.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_jul.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_ago.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_set.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_out.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_nov.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", porc_dez.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                
                writer.WriteEndElement();
            }


        }

        private void gerar_html()
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\grafico_horas.htm");
            if(d.Exists == true)
                d.Delete();
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\grafico_horas.txt");
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
                    texto.WriteLine("<table width='98%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>");
                    texto.WriteLine("<tr bordercolor='#000000'>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><img src='logo.jpg' width='234' height='99'></td>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><font color='#996600' size='+3' face='Verdana, Arial, Helvetica, sans-serif'>HORAS PREVISTAS X HORAS REALIZADAS</font></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("<br>");
                    texto.WriteLine("<table width='98%' border='2'>");
                    texto.WriteLine("<tr align='center'>");
                    texto.WriteLine("<td width='28%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>M&ecirc;s</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>JAN</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>FEV</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>MAR</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>ABR</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>MAI</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>JUN</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>JUL</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>AGO</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>SET</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>OUT</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>NOV</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#000000' face='Arial Black, Gadget, sans-serif'>DEZ</font></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr align='center'>");
                    texto.WriteLine("<td width='28%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>HORAS PREVISTAS</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_jan.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_fev.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_mar.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_abr.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_mai.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_jun.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_jul.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_ago.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_set.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_out.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_nov.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF3300' face='Arial Black, Gadget, sans-serif'>" + hp_dez.ToString("n2") + "</font></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr align='center'>");
                    texto.WriteLine("<td width='28%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>HORAS REALIZADAS</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_jan.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_fev.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_mar.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_abr.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_mai.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_jun.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_jul.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_ago.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_set.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_out.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_nov.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#00FF00' face='Arial Black, Gadget, sans-serif'>" + hr_dez.ToString("n2") + "</font></td>");
     
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr>");
                    texto.WriteLine("<td colspan='13'>&nbsp;</td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr align='center'>");
                    texto.WriteLine("<td width='28%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>% HP X HR</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_jan.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_fev.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_mar.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_abr.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_mai.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_jun.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_jul.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_ago.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_set.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_out.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_nov.ToString("n2") + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#0000CC' face='Arial Black, Gadget, sans-serif'>" + porc_dez.ToString("n2") + "</font></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr align='center'>");
                    texto.WriteLine("<td width='28%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>META</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("<td width='6%'><font color='#FF0000' face='Arial Black, Gadget, sans-serif'>" + tb_meta_iso.Text + "</font></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bgcolor='#FFFFFF'>");
                    texto.WriteLine("<td colspan='13' align='center' valign='top' class='text'> <div id='chartdiv1' align='center'>");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('hp_x_hr.swf', 'ChartId1', '1000', '450');");
                    texto.WriteLine("chart.setDataURL('hp_x_hr.xml');");
                    texto.WriteLine("chart.render('chartdiv1');");
                    texto.WriteLine("</script> </td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</font>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("<br><br><br>");
                    texto.WriteLine("<table width='100%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>");
                    texto.WriteLine("<tr bordercolor='#0000FF'>");
                    texto.WriteLine("<td colspan='6' align='center' valign='top' class='text'>");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Alfatech Ferramentaria de Precis&atilde;o</font></p>");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Avenida Jos&eacute; Gomes da Rocha Leal, 1178 - Centro - Bragan&ccedil;a Paulista - SP</font></p>");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Tel: (11) 4033-5005</font></p>");
                    texto.WriteLine("<p align='right'><font size='-3' face='Verdana, Arial, Helvetica, sans-serif'>Desenvolvido por Evolu&ccedil;&atilde;o Inform&aacute;tica</font></p>");
                    texto.WriteLine("<div id='chartdiv6' align='center'></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("</body>");
                    texto.WriteLine("</html>");
                }
            }
            catch { }
            t.CopyTo(Path.ChangeExtension(t.FullName, ".htm"), false);
        }

       
        
    }

        
}