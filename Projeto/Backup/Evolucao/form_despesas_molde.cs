using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Xml;

namespace Evolucao
{
    public partial class form_despesas_molde : Form
    {
        double valor_balanco;
        double valor_atual_receita;
        double valor_atual;
        double valor_projeto;
        double total_geral;
        public string os_corrente;
        public double horas_trabalhadas;

        double valor_fresa;
        double valor_torno;
        double valor_des_pm_elet;
        double valor_tempera;
        double valor_retifica;
        double valor_acab;
        double valor_erosao_edm;
        double valor_erosao_ewc;

        string valor;
        string forn;
        string obs;
        double valor_real;
        bool erro;
        public form_despesas_molde()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Os registros anteriores serão excluídos permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                
                    this.datDespesas_molde.DeleteCommand.CommandText =
                    "DELETE FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + os_corrente + "' AND DESPESA_MANUAL IS NULL";
                    this.fbConnection1.Open();
                    this.datDespesas_molde.DeleteCommand.Connection = fbConnection1;
                    this.datDespesas_molde.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    Importar_despesa("K://" + os_corrente + ".txt");
                    //Importar_despesa("C://evolucao//ostxt//" + os_corrente + ".txt");
                    inserir_valor_banco(somar_valores());
                    valor_balanco = valor_atual_receita - total_geral;
                    tb_balanco.Text = valor_balanco.ToString("n2");
                    if (valor_balanco < 0)
                        tb_balanco.ForeColor = Color.Red;
                    else
                        tb_balanco.ForeColor = Color.Green;

                    dsDespesas_molde.Clear();
                    this.datDespesas_molde.SelectCommand.CommandText =
                                "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + tb_molde.Text + "'";
                    this.fbConnection1.Open();
                    this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
                    this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datDespesas_molde.Fill(DESPESAS_MOLDE);
                
            }
        }
            
        public void Importar_despesa(string NomeArquivo)

        {

            bool retorno = false;

            string linha = string.Empty;

            string[] campos = null;

            StreamReader sr = null;

            //try

           // {

            if (File.Exists(NomeArquivo))

            {

            sr = new StreamReader(NomeArquivo);

            while ((linha = sr.ReadLine()) != null)

            {

                inserir_despesa(linha);


            }

            }

            

            //}

          //  catch (Exception)

          //  {

            

         //   }


        }

        public void inserir_despesa(string linha)
        {

            try
            {
                valor = "";
                //pegando o valor
                for (int i = 40; i < 51; i++)
                {
                    //MessageBox.Show(valor);
                    valor = valor + linha[i];
                    
                }
                //pegando o fornecedor
                for (int i = 80; i < 106; i++)
                {
                    forn = forn + linha[i];
                }
                //pegando as obs
                for (int i = 106; i < linha.Length; i++)
                {
                    obs = obs + linha[i];
                }
                //MessageBox.Show(valor + " " + forn + " " + obs);
            }
            catch
            {
                erro = true;
            }
            //verificando se é uma linha válida
            
            try
            {
                valor_real = Convert.ToDouble(valor);

            }
            catch
            {
                erro = true;
            }
            if(erro == false && valor_real < 0)
            {
                string valor_positivo = valor_real.ToString().Replace("-", "");
               // MessageBox.Show(valor_positivo + " " + forn + " " + obs);
               
                

                        this.datDespesas_molde.InsertCommand.CommandText =
                            "INSERT INTO DESPESAS_MOLDE (VALOR_DESPESA, FORNECEDOR_DESPESA, OBS_DESPESA, OS_DESPESA)" +
                                "VALUES ('" + valor_positivo.Replace(",", ".") + "','" + forn + "','" + obs + "','" + os_corrente + "')";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.InsertCommand.Connection = fbConnection1;
                        this.datDespesas_molde.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        dsDespesas_molde.Clear();
                        this.datDespesas_molde.SelectCommand.CommandText =
                        "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + os_corrente + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
                        this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        datDespesas_molde.Fill(DESPESAS_MOLDE);

                    
                

            }
            valor = "";
            forn = "";
            obs = "";
            valor_real = 0;
            erro = false;
        }

        private void form_despesas_molde_Load(object sender, EventArgs e)
        {
            
            tb_molde.Text = os_corrente;
            tb_horas_trab.Text = horas_trabalhadas.ToString("n2");
            double valor_trab = (horas_trabalhadas * 50);
            tb_hora.Text = "50,00";
            tb_valor_trab.Text = valor_trab.ToString("n2");
            this.datDespesas_molde.SelectCommand.CommandText =
                        "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + os_corrente + "'";
            this.fbConnection1.Open();
            this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
            this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datDespesas_molde.Fill(DESPESAS_MOLDE);

             this.datReceitas_molde.SelectCommand.CommandText =
                        "SELECT * FROM RECEITAS_MOLDE WHERE OS_RECEITA = '" + os_corrente + "'";
            this.fbConnection1.Open();
            this.datReceitas_molde.SelectCommand.Connection = fbConnection1;
            this.datReceitas_molde.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datReceitas_molde.Fill(RECEITAS_MOLDE);

            this.datDesenhos.SelectCommand.CommandText =
                       "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + os_corrente + "'";
            this.fbConnection1.Open();
            this.datDesenhos.SelectCommand.Connection = fbConnection1;
            this.datDesenhos.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datDesenhos.Fill(DESENHOS);

            this.datValor_operacao.SelectCommand.CommandText =
                       "SELECT * FROM VALOR_OPERACAO";
            this.fbConnection1.Open();
            this.datValor_operacao.SelectCommand.Connection = fbConnection1;
            this.datValor_operacao.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datValor_operacao.Fill(VALOR_OPERACAO);

            somar_valores();
            somar_valores_receitas();
            valor_balanco = valor_atual_receita - total_geral;
            tb_balanco.Text = valor_balanco.ToString("n2");
            if (valor_balanco < 0)
                tb_balanco.ForeColor = Color.Red;
            else
                tb_balanco.ForeColor = Color.Green;
            
   
        }

       
        private double somar_valores()
        {
            valor_atual = 0;
            total_geral = 0;
            valor_projeto = 0;
            for (int i = 0; i < dgvPgtos.RowCount; i++)
            {
                
                valor_atual = valor_atual + Convert.ToDouble(dgvPgtos.Rows[i].Cells["col_valor"].Value);

            }
            for (int i = 0; i < dgvPgtos.RowCount; i++)
            {
                try
                {
                    

                    if (dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[1].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[2].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[3].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[4].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[5].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[6].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[7].ToString() == "projeto"
                        ||
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[1].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[2].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[3].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[4].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[5].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[6].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[7].ToString() == "Projeto"
                        ||
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[1].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[2].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[3].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[4].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[5].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[6].ToString() +
                        dgvPgtos.Rows[i].Cells["col_obs"].Value.ToString()[7].ToString() == "PROJETO"
                        )
                    {
                        valor_projeto = valor_projeto + Convert.ToDouble(dgvPgtos.Rows[i].Cells["col_valor"].Value);

                    }
                }
                catch { }
            }
            valor_atual = valor_atual - valor_projeto;
            tb_total.Text = valor_atual.ToString("n2");
            tb_projeto.Text = valor_projeto.ToString("n2");
            total_geral = valor_atual + valor_projeto + Convert.ToDouble(tb_valor_trab.Text);
            tb_total_geral.Text = total_geral.ToString("n2");
            return valor_atual;

        }

        private double somar_valores_receitas()
        {
            valor_atual_receita = 0;
            for (int i = 0; i < dgvReceitas.RowCount; i++)
            {

                valor_atual_receita = valor_atual_receita + Convert.ToDouble(dgvReceitas.Rows[i].Cells["col_valor_receitas"].Value);

            }
            tb_total_receitas.Text = valor_atual_receita.ToString("n2");
            
            return valor_atual_receita;

        }

        private void inserir_valor_banco(double valor_atual)
        {
            this.datDesenhos.UpdateCommand.CommandText =
                    "UPDATE DESENHOS SET DESPESAS_MOLDE_DES = '" + valor_atual.ToString().Replace(",", ".") + "' WHERE N_OS_PECA = '" + os_corrente + "'";
            this.fbConnection1.Open();
            this.datDesenhos.UpdateCommand.Connection = fbConnection1;
            this.datDesenhos.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Os registros anteriores serão excluídos permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
               // try
               // {
                    this.datReceitas_molde.DeleteCommand.CommandText =
                    "DELETE FROM RECEITAS_MOLDE WHERE OS_RECEITA = '" + os_corrente + "'";
                    this.fbConnection1.Open();
                    this.datReceitas_molde.DeleteCommand.Connection = fbConnection1;
                    this.datReceitas_molde.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    Importar_receita("k:\\" + os_corrente + ".txt");
                    //System.Diagnostics.Process.Start(@"k://2080.Txt");

                  //  Importar_receita("C://evolucao//" + os_corrente + ".txt");
                    inserir_valor_banco_receita(somar_valores_receitas());
                    valor_balanco = valor_atual_receita - total_geral;
                    tb_balanco.Text = valor_balanco.ToString("n2");
                    if (valor_balanco < 0)
                        tb_balanco.ForeColor = Color.Red;
                    else
                        tb_balanco.ForeColor = Color.Green;
                //}
              //  catch {
              //      MessageBox.Show("erro");
              //  }
            }

        }

        private void inserir_valor_banco_receita(double valor_atual)
        {
            this.datDesenhos.UpdateCommand.CommandText =
                    "UPDATE DESENHOS SET RECEITAS_MOLDE_DES = '" + valor_atual.ToString().Replace(",", ".") + "' WHERE N_OS_PECA = '" + os_corrente + "'";
            this.fbConnection1.Open();
            this.datDesenhos.UpdateCommand.Connection = fbConnection1;
            this.datDesenhos.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

        }
        public void Importar_receita(string NomeArquivo)
        {

            bool retorno = false;

            string linha = string.Empty;

            string[] campos = null;

            StreamReader sr = null;

            //try

            // {

            if (File.Exists(NomeArquivo))
            {

                sr = new StreamReader(NomeArquivo);

                while ((linha = sr.ReadLine()) != null)
                {

                    inserir_receita(linha);


                }

            }
            else
            {
                MessageBox.Show("Arquivo Inexistente");
            }



            //}

            //  catch (Exception)

            //  {



            //   }


        }

        public void inserir_receita(string linha)
        {

            try
            {
                valor = "";
                //pegando o valor
                for (int i = 22; i < 33; i++)
                {
                    //MessageBox.Show(valor);
                    valor = valor + linha[i];

                }
                //pegando o fornecedor
                
                //MessageBox.Show(valor + " " + forn + " " + obs);
            }
            catch
            {
                erro = true;
            }
            //verificando se é uma linha válida

            try
            {
                valor_real = Convert.ToDouble(valor);

            }
            catch
            {
                erro = true;
            }
            if (erro == false && valor_real > 0)
            {
                string valor_positivo = valor_real.ToString().Replace("-", "");
                // MessageBox.Show(valor_positivo + " " + forn + " " + obs);

                

                        this.datReceitas_molde.InsertCommand.CommandText =
                            "INSERT INTO RECEITAS_MOLDE (VALOR_RECEITA, OS_RECEITA)" +
                                "VALUES ('" + valor_positivo.Replace(",", ".") + "','" + os_corrente + "')";
                        this.fbConnection1.Open();
                        this.datReceitas_molde.InsertCommand.Connection = fbConnection1;
                        this.datReceitas_molde.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        dsReceitas_molde.Clear();
                        this.datReceitas_molde.SelectCommand.CommandText =
                        "SELECT * FROM RECEITAS_MOLDE WHERE OS_RECEITA = '" + os_corrente + "'";
                        this.fbConnection1.Open();
                        this.datReceitas_molde.SelectCommand.Connection = fbConnection1;
                        this.datReceitas_molde.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        datReceitas_molde.Fill(RECEITAS_MOLDE);

                    

            }
            valor = "";
            forn = "";
            obs = "";
            valor_real = 0;
            erro = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rb_media.Checked = true;
            double valor_hora, valor_trab;
            valor_hora = Convert.ToDouble(tb_hora.Text);
            valor_trab = valor_hora * horas_trabalhadas;
            tb_valor_trab.Text = valor_trab.ToString("n2");
            somar_valores();
            somar_valores_receitas();
            valor_balanco = valor_atual_receita - total_geral;
            tb_balanco.Text = valor_balanco.ToString("n2");
            if (valor_balanco < 0)
                tb_balanco.ForeColor = Color.Red;
            else
                tb_balanco.ForeColor = Color.Green;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rb_por_operacao.Checked = true;
            try
            {
                valor_fresa = Convert.ToDouble(tb_horas_fresa.Text) *
                    Convert.ToDouble(tb_valor_hora_fresa.Text);
            }
            catch { valor_fresa = 0; }

            try
            {
                valor_torno = Convert.ToDouble(tb_horas_torno.Text) *
                    Convert.ToDouble(tb_valor_hora_torno.Text);
            }
            catch { valor_torno = 0; }

            try
            {
                valor_des_pm_elet = Convert.ToDouble(tb_des_pm_elet.Text) *
                    Convert.ToDouble(tb_valor_hora_des_pm_elet.Text);
            }
            catch { valor_des_pm_elet = 0; }

            try
            {
                valor_tempera = Convert.ToDouble(tb_tempera.Text) *
                    Convert.ToDouble(tb_valor_hora_tempera.Text);
            }
            catch { valor_tempera = 0; }

            try
            {
                valor_retifica = Convert.ToDouble(tb_retifica.Text) *
                    Convert.ToDouble(tb_valor_hora_retifica.Text);
            }
            catch { valor_retifica = 0; }

            try
            {
                valor_acab = Convert.ToDouble(tb_acab.Text) *
                    Convert.ToDouble(tb_valor_hora_acab.Text);
            }
            catch { valor_acab = 0; }

            try
            {
                valor_erosao_edm = Convert.ToDouble(tb_erosao_edm.Text) *
                    Convert.ToDouble(tb_valor_hora_erosao_edm.Text);
            }
            catch { valor_erosao_edm = 0; }

            try
            {
                valor_erosao_ewc = Convert.ToDouble(tb_erosao_ewc.Text) *
                    Convert.ToDouble(tb_valor_hora_erosao_ewc.Text);
            }
            catch { valor_erosao_ewc = 0; }

            tb_total_fresa.Text = valor_fresa.ToString("n2");
            tb_total_torno.Text = valor_torno.ToString("n2");
            tb_total_des_pm_elet.Text = valor_des_pm_elet.ToString("n2");
            tb_total_tempera.Text = valor_tempera.ToString("n2");
            tb_total_retifica.Text = valor_retifica.ToString("n2");
            tb_total_acab.Text = valor_acab.ToString("n2");
            tb_total_erosao_edm.Text = valor_erosao_edm.ToString("n2");
            tb_total_erosao_ewc.Text = valor_erosao_ewc.ToString("n2");

            double valor_hora, valor_trab;
            valor_trab = valor_fresa + valor_torno + valor_des_pm_elet + valor_tempera +
                valor_retifica + valor_acab + valor_erosao_edm + valor_erosao_ewc;
            tb_valor_trab.Text = valor_trab.ToString("n2");
            somar_valores();
            somar_valores_receitas();
            valor_balanco = valor_atual_receita - total_geral;
            tb_balanco.Text = valor_balanco.ToString("n2");
            if (valor_balanco < 0)
                tb_balanco.ForeColor = Color.Red;
            else
                tb_balanco.ForeColor = Color.Green;


        }

        private void tb_relatorio_financeiro_Click(object sender, EventArgs e)
        {
            cria_xml();
            gerar_htm();
            System.Diagnostics.Process.Start(@"c:\evolucao_dokinos\\financeiro_molde.htm");

        }

        private void gerar_htm()
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\financeiro_molde.htm");
            if(d.Exists == true)
                d.Delete();
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\financeiro_molde.txt");
            try
            {
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("<html xmlns='http://www.w3.org/1999/xhtml'>");
                    texto.WriteLine("<head>");
                    texto.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1' />");
                    texto.WriteLine("<title>Financeiro do Molde</title>");
                    texto.WriteLine("<link rel='stylesheet' href='../Contents/Style.css' type='text/css' />");
                    texto.WriteLine("<script language='JavaScript' src='FusionCharts.js'></script>");
                    texto.WriteLine("</head>");
                    texto.WriteLine("<body>");
                    texto.WriteLine("<table width='98%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>");
                    texto.WriteLine("<tr bordercolor='#000000'>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><img src='logo.jpg' width='234' height='99'></td>");
                    texto.WriteLine("<td colspan='2' align='center' valign='top' class='text'><font color='#996600' size='+3' face='Verdana, Arial, Helvetica, sans-serif'>FINANCEIRO DO MOLDE</font></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#000000'>");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'> <div align='left'><font face='Verdana, Arial, Helvetica, sans-serif'><strong>CLIENTE: " + tb_cliente.Text + "</strong></font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#000000'>");
                    texto.WriteLine("<td rowspan='2' align='center' valign='top' class='text'> <div align='left'><font size='+3' face='Verdana, Arial, Helvetica, sans-serif'><strong>OS: " + tb_molde.Text + "</strong></font></div></td>");
                    texto.WriteLine("<td colspan='2' align='center' valign='top' class='text'><div align='left'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'>Nome do Produto: " + tb_nome.Text + " </font></div></td>");
                    texto.WriteLine(" </tr>");
                    texto.WriteLine("<tr bordercolor='#000000'> ");
                    texto.WriteLine("<td align='center' valign='top' class='text'><div align='left'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'>Data de Entrega:" + tb_data.Text + "</font></div></td>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><div align='left'><font size='2' face='Verdana, Arial, Helvetica, sans-serif'>Projetista:" + tb_projetista.Text + "</font></div></td>");
                    texto.WriteLine(" </tr>");
                    texto.WriteLine("<tr bordercolor='#FF0000' bgcolor='#FFFFFF'> ");
                    texto.WriteLine("<td colspan='3' align='center' valign='top' class='text'> <div id='chartdiv1' align='center'> ");
                    texto.WriteLine("</div>");
                    texto.WriteLine("<script type='text/javascript'>");
                    texto.WriteLine("var chart = new FusionCharts('financeiro_molde.swf', 'ChartId1', '600', '350');");
                    texto.WriteLine("chart.setDataURL('financeiro_molde.xml');");
                    texto.WriteLine("chart.render('chartdiv1');");
                    texto.WriteLine("</script> </td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("<br>");
                    texto.WriteLine("<br>");
                    texto.WriteLine("<br>");

                    texto.WriteLine("<table width='100%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' valign='top' class='text'><div align='right'><font size='+1' face='Arial, Helvetica, sans-serif'>VALOR PROJETO</font></div></td>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><div align='right'><font size='+1' face='Arial, Helvetica, sans-serif'>R$ " + tb_projeto.Text + "</font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' valign='top' class='text'><div align='right'><font size='+1' face='Arial, Helvetica, sans-serif'>VALOR COMPRAS</font></div></td>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><div align='right'><font size='+1' face='Arial, Helvetica, sans-serif'>R$ " + tb_total.Text + "</font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' valign='top' class='text'><div align='right'><font size='+1' face='Arial, Helvetica, sans-serif'>VALOR TRABALHADO</font></div></td>");
                    texto.WriteLine("<td align='center' valign='top' class='text'> <div align='right'><font size='+1' face='Arial, Helvetica, sans-serif'>R$ " + tb_valor_trab.Text + "</font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr valign='bottom' bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' class='text'> <div align='right'><font size='+3' face='Arial, Helvetica, sans-serif'>TOTAL DE DESPESAS</font></div></td>");
                    texto.WriteLine("<td align='center' class='text'> <div align='right'><font size='+3' face='Arial, Helvetica, sans-serif'>R$ " + tb_total_geral.Text + "</font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' valign='top' class='text'><div align='right'><font face='Arial, Helvetica, sans-serif'><font face='Arial, Helvetica, sans-serif'><font size='+7'><font size='+4'><font size='+3'></font></font></font></font></font></div></td>");
                    texto.WriteLine("<td align='center' valign='top' bordercolor='#FFFFFF' class='text'>");
                    texto.WriteLine("<div align='right'><font face='Arial, Helvetica, sans-serif'><font size='+7'><font size='+4'><font size='+3'></font></font></font></font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' valign='top' class='text'><div align='right'><font size='+3' face='Arial, Helvetica, sans-serif'>VALOR COBRADO SEM IMPOSTOS </font></div></td>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><div align='right'><font size='+3' face='Arial, Helvetica, sans-serif'>R$ " + tb_total_receitas.Text + "</font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' valign='top' class='text'><div align='right'><font size='+3' face='Arial, Helvetica, sans-serif'></font></div></td>");
                    texto.WriteLine("<td align='center' valign='top' class='text'><div align='right'><font size='+3' face='Arial, Helvetica, sans-serif'></font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='5' align='center' valign='top' class='text'> <p align='right'><font size='+5' face='Arial, Helvetica, sans-serif'>BALAN&Ccedil;O</font></p>");
                    texto.WriteLine("<div id='chartdiv6' align='right'></div></td>");
                    texto.WriteLine("<td width='51%' align='center' valign='top' class='text'><div align='right'><font size='+5' face='Arial, Helvetica, sans-serif'>R$ " + tb_balanco.Text + "</font></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</table>");


                    
                    texto.WriteLine("<br>");
                    texto.WriteLine("<table width='100%' border='0' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>");
                    texto.WriteLine("<tr bordercolor='#0000FF'> ");
                    texto.WriteLine("<td colspan='6' align='center' valign='top' class='text'> ");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Unitron Ferramentaria de Precis&atilde;o Ltda - EPP</font></p>");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Avenida Vereador Jos&eacute; Leitao Xavier, 181/1 - S&atilde;o Louren&ccedil;o - Bragan&ccedil;a Paulista - SP</font></p>");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Tel: (11) 4034-1567 Site: www.unitron.ind.br email: contato@unitron.ind.br</font></p>");
                    texto.WriteLine("<p align='right'><font size='-3' face='Verdana, Arial, Helvetica, sans-serif'>Desenvolvido por Evolu&ccedil;&atilde;o Inform&aacute;tica</font></p>");
                    texto.WriteLine("<div id='chartdiv6' align='center'></div></td>");
                    texto.WriteLine("</tr>");
                    texto.WriteLine("</table>");
                    texto.WriteLine("</body>");
                    texto.WriteLine("</html>");
                }
                t.CopyTo(Path.ChangeExtension(t.FullName, ".htm"), false);


            }
            catch { }


        }


        private void cria_xml()
        {
            
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create("C:\\evolucao_dokinos\\financeiro_molde.xml", settings))
            {

                writer.WriteStartElement("graph");
                writer.WriteAttributeString("yAxisName", "Valores");
                writer.WriteAttributeString("caption", "Gráfico Financeiro");
                writer.WriteAttributeString("decimalPrecision", "0");
                writer.WriteAttributeString("rotateNames", "1");
                writer.WriteAttributeString("numDivLines", "3");
                writer.WriteAttributeString("numberPrefix", "R$ ");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteAttributeString("formatNumberScale", "0");


                writer.WriteStartElement("categories");
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "Receitas");
                writer.WriteEndElement();
                writer.WriteStartElement("category");
                writer.WriteAttributeString("name", "Despesas");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("dataset");
                writer.WriteAttributeString("seriesName", "Valor Molde");
                writer.WriteAttributeString("color", "008000");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", valor_atual_receita.ToString("n2").Replace(".","").Replace(",","."));
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "0.0");
                writer.WriteEndElement();
                writer.WriteEndElement();


                double valor_trab = total_geral - valor_atual;
                double valor_compras_projeto = valor_atual + valor_projeto;
                writer.WriteStartElement("dataset");
                writer.WriteAttributeString("seriesName", "Despesas Compras/Projeto");
                writer.WriteAttributeString("color", "ffff00");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "0.0");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", valor_compras_projeto.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("dataset");
                writer.WriteAttributeString("seriesName", "Valor Trabalhado");
                writer.WriteAttributeString("color", "ffa500");
                writer.WriteAttributeString("showValues", "0");
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", "0.0");
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", valor_trab.ToString("n2").Replace(".", "").Replace(",", "."));
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

                
        }

        private void bt_nova_despesa_Click(object sender, EventArgs e)
        {
            form_nova_despesa nova = new form_nova_despesa();

            try
            {
                nova.os_corrente = tb_molde.Text;
                nova.ShowDialog();
            }
            finally
            {
                if (nova.modificado == true)
                {
                    dsDespesas_molde.Clear();
                    this.datDespesas_molde.SelectCommand.CommandText =
                                "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + tb_molde.Text + "'";
                    this.fbConnection1.Open();
                    this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
                    this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datDespesas_molde.Fill(DESPESAS_MOLDE);


                    somar_valores();
                    somar_valores_receitas();
                    valor_balanco = valor_atual_receita - total_geral;
                    tb_balanco.Text = valor_balanco.ToString("n2");
                    if (valor_balanco < 0)
                        tb_balanco.ForeColor = Color.Red;
                    else
                        tb_balanco.ForeColor = Color.Green;
            

                }
                nova.Dispose();
            }
        }
        







    }
}