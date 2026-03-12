using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_cronograma_detalhado_x : Form
    {
        public string os_a_abrir;
        public form_cronograma_detalhado_x()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir(tb_os.Text);
        }
        
        private void abrir(string os)
        {
            dgvRotas_campo.DataSource = null;
            dgvRotas_campo.Columns.Clear();
            try
            {
                string[] operacoes = new string[100];
                int n_operacoes = 0;
                string funcao = "";
                if(tb_funcao.Text != "")
                {
                    funcao = " AND rotas.FUNCAO_ROTA = '" + tb_funcao.Text + "' ";
                }


                //VERIFICANDO QUAIS OPERAÇÕES EXISTEM
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DISTINCT OPERACAO_CAMPO FROM ROTAS_CAMPO rotas WHERE DESENHO_CAMPO = '" + tb_os.Text + "'" + funcao;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                string tipo = "";
                bool primeiro = true;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    //operacoes[n_operacoes] = dr[0].ToString();
                    //n_operacoes++;
                    if (primeiro)
                    {
                        tipo = "AND (TIPO = '" + dr[0].ToString() + "' ";
                        primeiro = false;
                    }
                    else
                    {
                        tipo = tipo + " OR TIPO = '" + dr[0].ToString() + "' ";
                    }
                }
                if (tipo != "")
                    tipo = tipo + ")";

                //selecionar tipos de operações em ordem
                FbCommand select_tipo = new FbCommand();
                select_tipo.Connection = fbConnection1;
                fbConnection1.Open();
                select_tipo.CommandText =
                    "SELECT TIPO FROM TIPOS_OPERACOES WHERE COD_TIPO IS NOT NULL " + tipo + " ORDER BY ORDEM_OPERACAO_TIPO";
                FbDataAdapter datTipos = new FbDataAdapter();
                datTipos.SelectCommand = select_tipo;
                DataSet dsTipos = new DataSet();
                datTipos.Fill(dsTipos);
                fbConnection1.Close();
                foreach (DataRow dr_tipo in dsTipos.Tables[0].Rows)
                {
                    operacoes[n_operacoes] = dr_tipo[0].ToString();
                    n_operacoes++;
                }



                //string[,] linhas_colunas = new string[n_operacoes, 5000];
                //dgvRotas_campo.DataSource = linhas_colunas;
                bool ja_criou_linhas = false;
                bool ja_criou_linhas_totais = false;
                int coluna_inicial = 0;
                int coluna_inicial_totais = 0;

                dgvRotas_campo.GridColor = Color.Gray;
                for (int i = 0; i < n_operacoes; i++)
                {
                    //CRIANDO COLUNAS DAS ROTAS
                    for (int j = 0; j < 11; j++) //11 é o número de colunas
                    {
                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        
                        DataGridViewColumn column = new DataGridViewColumn();
                        column.CellTemplate = cell;
                        column.DefaultCellStyle.BackColor = Color.Gray;
                        

                        using (Font font = new Font(
        dgvRotas_campo.DefaultCellStyle.Font.FontFamily, 6, FontStyle.Regular))
                        {
                            column.DefaultCellStyle.Font = font;
                        }
                        //Font fonte = new Font(dgvRotas_campo.DefaultCellStyle.Font, 6, FontStyle.Regular);// .DefaultCellStyle.Font, FontStyle.Italic);
                        dgvRotas_campo.Columns.Add(column);
                        
                    }
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 11].Width = 45;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 11].HeaderText = "Operação";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 11].Visible = false;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 10].Width = 60;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 10].HeaderText = "Pos.";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 9].Width = 30;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 9].HeaderText = "EP.";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 9].DefaultCellStyle.Format = "d";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 8].Width = 30;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 8].HeaderText = "FP";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 8].DefaultCellStyle.Format = "d";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 7].Visible = false;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 7].Width = 30;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 7].HeaderText = "ER";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 7].DefaultCellStyle.Format = "d";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 6].Visible = false;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 6].Width = 30;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 6].HeaderText = "FR";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 6].DefaultCellStyle.Format = "d";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 5].Visible = false;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 5].Width = 20;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 5].HeaderText = "HP";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 5].DefaultCellStyle.Format = "n1";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 4].Visible = false;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 4].Width = 20;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 4].HeaderText = "HR";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 4].DefaultCellStyle.Format = "n1";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 3].Visible = false;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 3].Width = 30;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 3].HeaderText = "Pos.At.";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 3].DefaultCellStyle.Format = "n1";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 2].Visible = false;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 2].Width = 30;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 2].HeaderText = "Rota";
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 1].Width = 5;
                    dgvRotas_campo.Columns[dgvRotas_campo.ColumnCount - 1].DefaultCellStyle.BackColor = Color.Black; //coluna de separação

                    if (!ja_criou_linhas)
                    {
                        for (int k = 0; k < 1000; k++)
                        {
                            DataGridViewCell cell = new DataGridViewTextBoxCell();
                            DataGridViewRow row = new DataGridViewRow();
                            dgvRotas_campo.Rows.Add(row);
                        }
                        ja_criou_linhas = true;
                    }

                    //CRIANDO COLUNAS DOS TOTAIS
                    for (int j = 0; j < 2 ; j++) //2 é o número de colunas
                    {
                        DataGridViewCell cell = new DataGridViewTextBoxCell();

                        DataGridViewColumn column = new DataGridViewColumn();
                        column.CellTemplate = cell;
                        column.DefaultCellStyle.BackColor = Color.Gray;


                        using (Font font = new Font(
        dgvRotas_campo.DefaultCellStyle.Font.FontFamily, 6, FontStyle.Regular))
                        {
                            column.DefaultCellStyle.Font = font;
                        }
                        //Font fonte = new Font(dgvRotas_campo.DefaultCellStyle.Font, 6, FontStyle.Regular);// .DefaultCellStyle.Font, FontStyle.Italic);
                        dgvTotais.Columns.Add(column);
                    }

                    dgvTotais.Columns[dgvTotais.ColumnCount - 2].Width = 120;
                    //dgvTotais.Columns[dgvTotais.ColumnCount - 2].HeaderText = "Pos.At.";
                    dgvTotais.Columns[dgvTotais.ColumnCount - 2].DefaultCellStyle.Format = "n1";
                    dgvTotais.Columns[dgvTotais.ColumnCount - 1].Width = 5;
                    dgvTotais.Columns[dgvTotais.ColumnCount - 1].DefaultCellStyle.BackColor = Color.Black;

                    if (!ja_criou_linhas_totais) //CRIANDO LINHAS TOTAIS
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            DataGridViewCell cell = new DataGridViewTextBoxCell();
                            DataGridViewRow row = new DataGridViewRow();
                            dgvTotais.Rows.Add(row);
                        }
                        ja_criou_linhas_totais = true;
                    }



                    FbCommand select_operacao = new FbCommand();
                    select_operacao.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_operacao.CommandText =
                        "SELECT rotas.OPERACAO_CAMPO, op.DESENHO_OP_ATUAL || '-' || op.N_PDF, rotas.DATA_ENTRADA_PREV, rotas.DATA_FECHAMENTO_PREV, rotas.DATA_ENTRADA, " + 
                        "rotas.DATA_FECHAMENTO, rotas.PREVISAO_PRODUCAO, rotas.SALDO_HORAS, rotas.POSICAO_ATUAL, rotas.COD_ROTA_CAMPO " + 
                        "FROM ROTAS_CAMPO rotas INNER JOIN OP op ON rotas.OP_ROTA = op.COD_OP WHERE rotas.OPERACAO_CAMPO = '" + operacoes[i] + "' " +
                        " AND rotas.DESENHO_CAMPO like '" + tb_os.Text + "'" + funcao + " ORDER BY op.COND_PGTO";
                    FbDataAdapter datOperacoes = new FbDataAdapter();
                    datOperacoes.SelectCommand = select_operacao;
                    DataTable dsOperacoes = new DataTable();
                    datOperacoes.Fill(dsOperacoes);
                    fbConnection1.Close();
                    int l = 0; //COMEÇA PELA LINHA 0
                    //dgvRotas_campo.DataSource = dsOperacoes;
                    double _soma_porc = 0;
                    double _horas_previstas = 0;
                    double _horas_realizadas = 0;
                    foreach (DataRow dr in dsOperacoes.Rows)
                    {
                        //CALCULANDO HORAS PREVISTAS, REALIZADAS E PORCENTAGEM
                        
                        double _porc_item = 0;
                        try
                        {
                            if (dr[8].ToString().ToUpper().Contains("FINALIZADO"))
                                _porc_item = 100;
                            else
                                _porc_item = Convert.ToDouble(dr[7].ToString()) / Convert.ToDouble(dr[6].ToString()) * 100;
                            if (_porc_item > 100)
                                _porc_item = 95;
                        }
                        catch { }
                        _soma_porc = _soma_porc + _porc_item;

                        try
                        {
                            _horas_previstas = _horas_previstas + Convert.ToDouble(dr[6].ToString());
                        }
                        catch { }

                        try
                        {
                            _horas_realizadas = _horas_realizadas + Convert.ToDouble(dr[7].ToString());
                        }
                        catch { }


                        Color cor = Color.Yellow;
                        if (dr[8].ToString().ToUpper().Contains("ANDAMENTO"))
                            cor = Color.Green;
                        if (dr[8].ToString().ToUpper().Contains("FINALIZADO"))
                            cor = Color.GreenYellow;
                        if (dr[8].ToString() == "")
                        {
                            cor = Color.Yellow;
                            try
                            {
                                if (Convert.ToDateTime(dr[3].ToString()) < DateTime.Now)
                                    cor = Color.Red;
                            }
                            catch { }
                        }
                        if (dr[8].ToString().ToUpper().Contains("PARADA"))
                        {
                            cor = Color.Orange;
                            try
                            {
                                if (Convert.ToDateTime(dr[3].ToString()) < DateTime.Now)
                                    cor = Color.Red;
                            }
                            catch { }
                        }


                        using (Font font_1 = new Font(
        dgvRotas_campo.DefaultCellStyle.Font.FontFamily, 6, FontStyle.Bold))
                        {
                            dgvRotas_campo.Rows[l].Cells[coluna_inicial + 0].Style.Font = font_1;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 0].Style.Font = font_1;
                        }
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 0].Value = dr[0].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 0].Style.BackColor = Color.Aquamarine;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 1].Value = dr[1].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 1].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 2].Value = dr[2].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 2].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 3].Value = dr[3].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 3].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 4].Value = dr[4].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 4].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 5].Value = dr[5].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 5].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 6].Value = dr[6].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 6].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 7].Value = dr[7].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 7].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 8].Value = dr[8].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 8].Style.BackColor = cor;
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 9].Value = dr[9].ToString();
                        dgvRotas_campo.Rows[l].Cells[coluna_inicial + 9].Style.BackColor = cor;
                        
                        l++;


                    }
                    coluna_inicial = coluna_inicial + 11; //PQ SÃO 11 COLUNAS NO SELECT
                    double _porc = 0;
                    try { _porc = _soma_porc / l; }
                    catch { }
                    dgvTotais.Rows[0].Cells[coluna_inicial_totais].Value = operacoes[i];
                    dgvTotais.Rows[0].Cells[coluna_inicial_totais].Style.BackColor = Color.Aquamarine;
                    dgvTotais.Rows[1].Cells[coluna_inicial_totais].Value = "% Exec: " + _porc.ToString("n2");
                    dgvTotais.Rows[1].Cells[coluna_inicial_totais].Style.BackColor = Color.MediumSlateBlue;
                    dgvTotais.Rows[2].Cells[coluna_inicial_totais].Value = "Horas Previstas: " + _horas_previstas.ToString("n2");
                    dgvTotais.Rows[2].Cells[coluna_inicial_totais].Style.BackColor = Color.LightSteelBlue;
                    dgvTotais.Rows[3].Cells[coluna_inicial_totais].Value = "Horas Realizadas: " + _horas_realizadas.ToString("n2");
                    dgvTotais.Rows[3].Cells[coluna_inicial_totais].Style.BackColor = Color.MediumSlateBlue;


                    coluna_inicial_totais = coluna_inicial_totais + 2;
                }
                
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void form_cronograma_detalhado_x_Load(object sender, EventArgs e)
        {
            if (os_a_abrir != "" && os_a_abrir != null)
            {
                tb_os.Text = os_a_abrir;
                abrir(tb_os.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_conjunto_peca conj = new form_conjunto_peca();
            try
            {
                conj.ShowDialog();
            }
            finally
            {
                tb_funcao.Text = conj.nome_escolhido;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                classe_cronograma cronograma = new classe_cronograma();
                cronograma.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                cronograma.os = true;
                cronograma.por_funcao = true;
                cronograma.todas_os_a_criar[0] = tb_os.Text;
                cronograma.numero_de_os = 1;
                cronograma.criar_xml_os_geral(@"c:\\evolucao\\cronogramas\funcao_os.xml");
                //cronograma.criar_xml_os_funcao_operacao(@"c:\\evolucao\\cronogramas\funcao_os.xml");
                cronograma.criar_html_os_funcao_operacao(@"c:\\evolucao\\cronogramas\cronograma_funcao_os.html");
                cronograma.abrir_html(@"c:\\evolucao\\cronogramas\cronograma_funcao_os.html");
            }
            catch { }

        }

        private void dgvRotas_campo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int coluna_atual = e.ColumnIndex + 1;
            try
            {
               
                while (coluna_atual % 11 != 0)
                    coluna_atual++;

                coluna_atual = coluna_atual - 2;
                string _rota = "";
                _rota = dgvRotas_campo.Rows[e.RowIndex].Cells[coluna_atual].Value.ToString();

                form_rotas_X rota = new form_rotas_X();
                try
                {
                    rota.rota = _rota;
                    rota.ShowDialog();
                }
                finally { }

            }
            catch { }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                classe_cronograma cronograma = new classe_cronograma();
                cronograma.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                cronograma.os = true;
                //cronograma.por_funcao = true;
                cronograma.por_posicao = true;
                cronograma.todas_os_a_criar[0] = tb_os.Text;
                cronograma.numero_de_os = 1;
                cronograma.criar_xml_os_geral(@"c:\\evolucao\\cronogramas\funcao_os.xml");
                //cronograma.criar_xml_os_funcao_operacao(@"c:\\evolucao\\cronogramas\funcao_os.xml");
                cronograma.criar_html_os_funcao_operacao(@"c:\\evolucao\\cronogramas\cronograma_funcao_os.html");
                cronograma.abrir_html(@"c:\\evolucao\\cronogramas\cronograma_funcao_os.html");
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        
    }
}