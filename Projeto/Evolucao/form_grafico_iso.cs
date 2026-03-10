using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Evolucao
{
    public partial class form_grafico_iso : Form
    {
        //VARIAVEIS GRAFICO ISO
        double hp_jan, hp_fev, hp_mar, hp_abr, hp_mai, hp_jun, hp_jul, hp_ago, hp_set, hp_out, hp_nov, hp_dez;
        double hr_jan, hr_fev, hr_mar, hr_abr, hr_mai, hr_jun, hr_jul, hr_ago, hr_set, hr_out, hr_nov, hr_dez;
        double porc_jan, porc_fev, porc_mar, porc_abr, porc_mai, porc_jun, porc_jul, porc_ago, porc_set, porc_out, porc_nov, porc_dez;

        public form_grafico_iso()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_mes.Text == "*")
            {
                calcular_valores();
            }
            else
            {
                puxar_do_banco();
                fazer_a_conta();
            }
        }
        public void calcular_valores()
        {
            tb_mes.Text = "1";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_jan = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_jan = 0;
            }
            try
            {
                hr_jan = Convert.ToDouble(tb_total_trab.Text);
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
           

            //calculando fevereiro
            tb_mes.Text = "2";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_fev = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_fev = 0;
            }
            try
            {
                hr_fev = Convert.ToDouble(tb_total_trab.Text);
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

            
            //calculando março
            tb_mes.Text = "3";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_mar = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_mar = 0;
            }
            try
            {
                hr_mar = Convert.ToDouble(tb_total_trab.Text);
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
        
            //calculando abril
            tb_mes.Text = "4";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_abr = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_abr = 0;
            }
            try
            {
                hr_abr = Convert.ToDouble(tb_total_trab.Text);
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
           

            //calculando maio
            tb_mes.Text = "5";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_mai = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_mai = 0;
            }
            try
            {
                hr_mai = Convert.ToDouble(tb_total_trab.Text);
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
            

            //calculando junho
            tb_mes.Text = "6";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_jun = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_jun = 0;
            }
            try
            {
                hr_jun = Convert.ToDouble(tb_total_trab.Text);
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
            

            //calculando julho
            tb_mes.Text = "7";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_jul = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_jul = 0;
            }
            try
            {
                hr_jul = Convert.ToDouble(tb_total_trab.Text);
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
        
            //calculando agosto
            tb_mes.Text = "8";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_ago = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_ago = 0;
            }
            try
            {
                hr_ago = Convert.ToDouble(tb_total_trab.Text);
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
           

            //calculando setembro
            tb_mes.Text = "9";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_set = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_set = 0;
            }
            try
            {
                hr_set = Convert.ToDouble(tb_total_trab.Text);
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
            
            //calculando outubro
            tb_mes.Text = "10";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_out = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_out = 0;
            }
            try
            {
                hr_out = Convert.ToDouble(tb_total_trab.Text);
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
            
            //calculando novembro
            tb_mes.Text = "11";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_nov = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_nov = 0;
            }
            try
            {
                hr_nov = Convert.ToDouble(tb_total_trab.Text);
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
           

            //calculando dezembro

            tb_mes.Text = "12";
            puxar_do_banco();
            fazer_a_conta();
            try
            {
                hp_dez = Convert.ToDouble(tb_total_prev.Text);
            }
            catch
            {
                hp_dez = 0;
            }
            try
            {
                hr_dez = Convert.ToDouble(tb_total_trab.Text);
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
           
        }
        
        

        private void puxar_do_banco()
        {
            DateTime data_inicial = new DateTime();
            DateTime data_final = new DateTime();
            data_inicial = Convert.ToDateTime("01/" + tb_mes.Text + "/" + tb_ano.Text);
            data_final = data_inicial.AddMonths(1).AddDays(-1);
            dsDesenhos.Clear();
            this.datDesenhos.SelectCommand.CommandText =
                "SELECT * FROM DESENHOS WHERE " +
                "(DATA_ENTREGA_PECA > '" + data_inicial.ToShortDateString().Replace("/", ".") + "' AND " +
                "DATA_ENTREGA_PECA < '" + data_final.ToShortDateString().Replace("/", ".") + "') AND " + 
                "DATA_ENTREGA_PECA < '" + DateTime.Now.ToShortDateString().Replace("/",".") + "'";
            this.fbConnection1.Open();
            this.datDesenhos.SelectCommand.Connection = fbConnection1;
            this.datDesenhos.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            datDesenhos.Fill(DESENHOS);

        }

        private void fazer_a_conta()
        {
            double total_prev = 0;
            double total_trab = 0;
            for (int i = 0; i < dgvDesenhos.RowCount - 1; i++)
            {
                for (int j = 17; j < 29; j++)
                {
                    try
                    {
                        total_prev = total_prev + Convert.ToDouble(dgvDesenhos.Rows[i].Cells[j].Value);
                    }
                    catch { }
                }
            }

            for (int i = 0; i < dgvDesenhos.RowCount - 1; i++)
            {
                for (int j = 29; j < 42; j++)
                {
                    try
                    {
                        total_trab = total_trab + Convert.ToDouble(dgvDesenhos.Rows[i].Cells[j].Value);
                    }
                    catch { }
                }
            }

            tb_total_prev.Text = total_prev.ToString("n2");
            tb_total_trab.Text = total_trab.ToString("n2");


        }

        private void bt_grafico_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            calcular_valores();
            gerar_xml();
            gerar_html();
            System.Diagnostics.Process.Start(@"c:\\evolucao\\grafico_horas.htm");
            this.Cursor = Cursors.Default;
        }

        private void gerar_xml()
        {
            XmlWriterSettings settings = new XmlWriterSettings();

            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create("c:\\evolucao\\" + "hp_x_hr.xml", settings))
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
                writer.WriteAttributeString("value", hp_jan.ToString("n2").Replace(".", "").Replace(",", "."));
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
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("set");
                writer.WriteAttributeString("value", tb_meta_iso.Text);
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
            FileInfo d = new FileInfo("c:\\evolucao\\grafico_horas.htm");
            if (d.Exists == true)
                d.Delete();
            FileInfo t = new FileInfo("c:\\evolucao\\grafico_horas.txt");
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
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Itatron Ferramentas Precisas Ltda</font></p>");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Av. Eusebio Savaio, 482 - Sta Amelia - Bragan&ccedil;a Paulista - SP</font></p>");
                    texto.WriteLine("<p><font color='#999900' face='Verdana, Arial, Helvetica, sans-serif'>Tel: (11) 4034-0784</font></p>");
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