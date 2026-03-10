using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Evolucao
{
   

    class classe_cronograma
    {
        public bool os, total_em_andamento;
        public bool por_posicao, por_funcao, por_os;
        public string os_a_criar;
        public string[] todas_os_a_criar = new string[500];
        public int numero_de_os;
        public int contador;
        public FbConnection fbConnection1 = new FbConnection();

        public static Image BytesToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image img = Image.FromStream(ms);
                return img;
            }
        }

        public static void SaveJpeg(string path, Image img, int quality)
        {
            EncoderParameter qualityParam
            = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

            ImageCodecInfo jpegCodec
            = GetEncoderInfo(@"image/jpeg");

            EncoderParameters encoderParams
            = new EncoderParameters(1);

            encoderParams.Param[0] = qualityParam;

            System.IO.MemoryStream mss = new System.IO.MemoryStream();

            System.IO.FileStream fs
            = new System.IO.FileStream(path, System.IO.FileMode.Create
            , System.IO.FileAccess.ReadWrite);

            img.Save(mss, jpegCodec, encoderParams);
            byte[] matriz = mss.ToArray();
            fs.Write(matriz, 0, matriz.Length);

            mss.Close();
            fs.Close();
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        public void criar_html_os_funcao_operacao(string local)
        {
            string _os = "", _cliente = "", _responsavel = "", _prazo = "", _nome = "", _projeto = "", _revisao = "", _produto = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + todas_os_a_criar[0] + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                byte[] foto = new byte[0];

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        _cliente = dr["CLIENTE"].ToString();
                        _prazo = dr["DATA_ENTREGA_PECA"].ToString();
                        _nome = dr["NOME_PECA"].ToString();
                        _responsavel = dr["RESPONSAVEL_PECA"].ToString();
                        _projeto = dr["PROJETISTA_PECA"].ToString();
                        _revisao = dr["REVISAO"].ToString();
                        _produto = dr["PRODUTO_PECA"].ToString();
                    }
                    catch { }

                    //foto = (byte[])dr["DESENHO_PECA"];
                }

                //Image foto_salva = BytesToImage(foto);

                //SaveJpeg(@"c:\\evolucao\\cronogramas\peca.jpg", foto_salva, 100);
                //foto_salva.Save(@"c:\\evolucao\\cronogramas\peca.jpg");

                if (_prazo != "")
                    _prazo = Convert.ToDateTime(_prazo).ToShortDateString();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }

            //CALCULANDO TAMANHO EM PIXELS DO FLASH
            //PARA CADA 8 LINHAS O TAMANHO É 165
            double n_linhas = Convert.ToDouble(contador);
            n_linhas = n_linhas / 8;
            n_linhas = n_linhas * 165;

            FileInfo d = new FileInfo(@local);
            d.Delete();
            FileInfo t = new FileInfo(@local);
            try
            {
                using (StreamWriter texto = t.CreateText())
                {
                    texto.Write(@"<html xmlns='http://www.w3.org/1999/xhtml'>
<head>
<meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1' />
<title>Cronograma de Desenvolvimento do Ferramental</title>
<link rel='stylesheet' href='../Contents/Style.css' type='text/css' />
<script language='JavaScript' src='FusionCharts.js'></script>
</head>
<body>
<table style='font-family: Arial; border-right: #000000 1pt outset; border-top: #000000 1pt outset; border-left: #000000 1pt outset; border-bottom: #000000 1pt outset;' width='100%' border='1' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='7' rowspan='3' valign='top' width='16.6%'>
            <span style='font-size: 7pt'><span style='color: #996600; font-family: Verdana'>
    <img src='logo.jpg' style='width: 115px; height: 59px'></span></span></td>
        <td align='center' class='text' colspan='3' style='height: 14px; font-size: 12pt;' valign='top' width='50%'>
            <span style='font-family: Arial'><strong>CRONOGRAMA DESENVOLVIMENTO DO FERRAMENTAL</strong></span></td>
        <td align='center' class='text' colspan='1' rowspan='6' valign='top' width='16.6%' style='font-size: 12pt'>
            <img src='peca.jpg' style='width: 98px; height: 108px' /></td>
        <td align='center' class='text' colspan='1' style='height: 14px; font-size: 12pt;' valign='top' width='16.6%'>
            <span style='font-size: 7pt'><strong>
            PRODUTO:</strong></span>&nbsp;</td>
    </tr>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='2' rowspan='1' valign='top' width='33.2%' style='text-align: left; height: 25px;'>
            <strong>
            CLIENTE:</strong> <span style='color: #3300ff'>" + _cliente + @"</span></td>
        <td align='center' class='text' colspan='1' rowspan='5' valign='middle' style='text-align: center'  width='16.6%'>
            <strong>Prazo oficial:
                <br />" + _prazo + @"</strong></td>
        <td align='center' class='text' colspan='1' rowspan='1' valign='top' style='height: 25px'>
            <span style='font-size: 7pt'>" + _projeto + @"</span></td>
    </tr>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='2' rowspan='1' valign='top' width='33.2%' style='text-align: left'>
            <strong><span style='font-size: 10pt'>" + _nome + @"</span></strong></td>
        <td align='center' class='text' colspan='1' rowspan='1' valign='top'>
            <span style='font-size: 7pt'><strong>RESPONS&#193VEL:</strong></span></td>
    </tr>
    <tr bordercolor='#000000' style='font-size: 12pt'>
        <td align='center' class='text' colspan='7' rowspan='3' valign='top' style='height: 26px'>
            <div align='left' style='text-align: center'>
                <strong>OS: " + todas_os_a_criar[0] + @"</strong></div>
        </td>
        <td align='center' class='text' colspan='1' rowspan='3' valign='top' style='height: 26px; text-align: left;'>
            <span style='font-size: 10pt'><strong>REVIS&#195O: </strong>" + _revisao + @"</span></td>
        <td align='center' class='text' colspan='1' rowspan='3' valign='top' width='16.6%' style='height: 26px'>
            <span style='color: #3300ff'>
            </span></td>
        <td align='center' class='text' colspan='1' rowspan='3' valign='top' style='height: 26px'>
            <span style='font-size: 7pt'>" + _produto + @"</span></td>
    </tr>
    <tr bordercolor='#000000'>
    </tr>
<tr bordercolor='#000000'>
</tr>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='12' rowspan='1' style='height: 26px' valign='top'>
        <div id='chartdiv2' align='center'> 
</div>
<script type='text/javascript'>
var chart = new FusionCharts('funcao_os.swf', 'ChartId2', '1000', '" + n_linhas.ToString().Replace(".","").Replace(",",".") + @"');
chart.setDataURL('funcao_os.xml');
chart.render('chartdiv2');
</script> 
        </td>
    </tr>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='10' rowspan='1' style='height: 26px' valign='top'>
                    <img src='legenda.jpg' /></td>
        <td align='center' class='text' colspan='2' rowspan='1' style='font-size: 12pt' valign='top'>
            <span style='font-size: 7pt; font-family: Verdana'>Desenvolvido
        por Evolu&#231&#227o Inform&#225tica <br> Telefone: 55 11 2277-3061</span>
        </td>
    </tr>
<tr bordercolor='#000000'> </tr>
</table>
    <br />
    <br />
    <br />
    &nbsp;<div style='text-align: center'>
        &nbsp;</div>
    <br />
    <span style='font-size: 7pt; font-family: Verdana'></span>
</body>
</html>"
);

                }
                t.CopyTo(Path.ChangeExtension(t.FullName, ".htm"), false);
            }
            catch { }



           
        }

        public void criar_xml_os_funcao_operacao(string local)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(local, settings))
            {
                writer.WriteStartElement("chart");
                writer.WriteAttributeString("dateFormat", "dd/mm/yyyy");
                writer.WriteAttributeString("hoverCapBorderColor", "ffffff");
                writer.WriteAttributeString("hoverCapBgColor", "ffffff");
                writer.WriteAttributeString("ganttWidthPercent", "60");
                writer.WriteAttributeString("ganttLineAlpha", "80");
                writer.WriteAttributeString("canvasBorderColor", "024455");
                writer.WriteAttributeString("canvasBorderThickness", "0");
                writer.WriteAttributeString("gridBorderColor", "4567aa");
                writer.WriteAttributeString("gridBorderAlpha", "20");
                writer.WriteAttributeString("width", "850");

                DateTime _primeiro_dia_os = primeiro_dia_os();
                DateTime _ultimo_dia_os = ultimo_dia_os();

                DateTime[] primeiro_dia_semana = new DateTime[200];
                DateTime[] ultimo_dia_semana = new DateTime[200];
                int[] semana_numero = new int[200];
                int n_semanas = 0;
                buscar_semanas(_primeiro_dia_os, _ultimo_dia_os, out primeiro_dia_semana,
                    out ultimo_dia_semana, out semana_numero, out n_semanas);

                writer.WriteStartElement("categories");
                writer.WriteAttributeString("bgColor", "EEE9E9");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteStartElement("category");
                writer.WriteAttributeString("start", primeiro_dia_semana[0].ToShortDateString());
                writer.WriteAttributeString("end", ultimo_dia_semana[n_semanas - 1].ToShortDateString());
                writer.WriteAttributeString("align", "center");
                writer.WriteAttributeString("name", "Semanas");
                writer.WriteAttributeString("font", "Verdana");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("fontSize", "16");
                writer.WriteEndElement(); //fecha category
                writer.WriteEndElement(); //fecha categories

                writer.WriteStartElement("categories");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("fontColor", "0000ff");
                writer.WriteAttributeString("fontSize", "10");

                

                for (int i = 0; i < n_semanas; i++)
                {
                    writer.WriteStartElement("category");
                    writer.WriteAttributeString("start", primeiro_dia_semana[i].ToShortDateString());
                    writer.WriteAttributeString("end",ultimo_dia_semana[i].ToShortDateString());
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("name", semana_numero[i].ToString());
                    writer.WriteAttributeString("isBold", "1");

                    //writer.WriteAttributeString("width", tamanho.ToString());
                    writer.WriteEndElement(); //fecha category
                }
                writer.WriteEndElement(); //fecha categories

                writer.WriteStartElement("processes");
                writer.WriteAttributeString("headerText", "Processos");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("fontSize", "10");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("isAnimated", "1");
                writer.WriteAttributeString("bgColor", "EEE9E9");
                writer.WriteAttributeString("headerVAlign", "center");
                writer.WriteAttributeString("headerbgColor", "EEE9E9");
                writer.WriteAttributeString("headerFontColor", "000000");
                writer.WriteAttributeString("headerFontSize", "16");
                writer.WriteAttributeString("width", "210");
                writer.WriteAttributeString("align", "left");
                //selecionando as funções
                DataSet dsInformacoes = new DataSet();
                buscar_informacoes(out dsInformacoes);
                contador = 1;
                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    writer.WriteStartElement("process");
                    writer.WriteAttributeString("Name", dsInformacoes.Tables[i].TableName);
                    writer.WriteAttributeString("id", contador.ToString());
                    writer.WriteAttributeString("bgColor", "FFDAB9");
                    writer.WriteEndElement();
                    contador++;
                    foreach(DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", dr[0].ToString());
                        writer.WriteAttributeString("id", contador.ToString());
                        writer.WriteAttributeString("bgColor", "87CEFA");
                        writer.WriteEndElement();
                        contador++;
                    }
                }
                writer.WriteEndElement(); // fecha processes

                //datas previstas e reais
                writer.WriteStartElement("dataTable");
                writer.WriteAttributeString("showProcessName", "1");
                writer.WriteAttributeString("nameAlign", "left");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("fontSize", "10");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("headerFontColor", "00000");
                writer.WriteAttributeString("headerFontSize", "9");
                writer.WriteAttributeString("vAlign", "center");
                writer.WriteAttributeString("align", "left");

                //INICIO PREV
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "I.Prev.");
                writer.WriteAttributeString("isBold", "1");

                
                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    writer.WriteStartElement("text");
                    writer.WriteAttributeString("label", "");
                    writer.WriteAttributeString("FontColor", "000000");
                    writer.WriteAttributeString("fontSize", "8");
                    writer.WriteAttributeString("vAlign", "center");
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("bgColor", "FFDAB9");
                    writer.WriteEndElement();
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[1].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //INICIO REAL
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "I.Real.");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    writer.WriteStartElement("text");
                    writer.WriteAttributeString("label", "");
                    writer.WriteAttributeString("FontColor", "000000");
                    writer.WriteAttributeString("fontSize", "8");
                    writer.WriteAttributeString("vAlign", "center");
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("bgColor", "FFDAB9");
                    writer.WriteEndElement();
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[3].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //FIM PREVISTO
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "F.Prev.");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    writer.WriteStartElement("text");
                    writer.WriteAttributeString("label", "");
                    writer.WriteAttributeString("FontColor", "000000");
                    writer.WriteAttributeString("fontSize", "8");
                    writer.WriteAttributeString("vAlign", "center");
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("bgColor", "FFDAB9");
                    writer.WriteEndElement();
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[2].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //FIM REAL
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "F.Real.");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    writer.WriteStartElement("text");
                    writer.WriteAttributeString("label", "");
                    writer.WriteAttributeString("FontColor", "000000");
                    writer.WriteAttributeString("fontSize", "8");
                    writer.WriteAttributeString("vAlign", "center");
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("bgColor", "FFDAB9");
                    writer.WriteEndElement();
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        string fontcolor = "000000";
                        if (dr[4].ToString() == DateTime.Now.ToShortDateString())
                            fontcolor = "ffffff";
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[4].ToString());
                        writer.WriteAttributeString("FontColor", fontcolor);
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //Porc
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "32");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "%");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    writer.WriteStartElement("text");
                    writer.WriteAttributeString("label", "");
                    writer.WriteAttributeString("FontColor", "000000");
                    writer.WriteAttributeString("fontSize", "8");
                    writer.WriteAttributeString("vAlign", "center");
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("bgColor", "FFDAB9");
                    writer.WriteEndElement();
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[5].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndElement();


                //inicio das barras
                writer.WriteStartElement("tasks");

                contador = 1;
                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    writer.WriteStartElement("task");
                    writer.WriteAttributeString("name", "Previsto");
                    writer.WriteAttributeString("processId", contador.ToString());
                    writer.WriteAttributeString("start","");
                    writer.WriteAttributeString("end", "");
                    writer.WriteAttributeString("id", contador.ToString() + "-1");
                    writer.WriteAttributeString("color", "");
                    writer.WriteAttributeString("height", "7");
                    writer.WriteAttributeString("topPadding", "2");
                    writer.WriteAttributeString("animation", "0");
                    writer.WriteAttributeString("alpha", "0");
                    writer.WriteEndElement();

                    writer.WriteStartElement("task");
                    writer.WriteAttributeString("name", "Executado");
                    writer.WriteAttributeString("processId", contador.ToString());
                    writer.WriteAttributeString("start", "");
                    writer.WriteAttributeString("end","");
                    writer.WriteAttributeString("id", contador.ToString());
                    writer.WriteAttributeString("color", "");
                    writer.WriteAttributeString("height", "7");
                    writer.WriteAttributeString("topPadding", "11");
                    writer.WriteAttributeString("alpha", "0");
                    writer.WriteEndElement();
                    contador++;
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("task");
                        writer.WriteAttributeString("name", "Previsto");
                        writer.WriteAttributeString("processId", contador.ToString());
                        writer.WriteAttributeString("start", dr[1].ToString());
                        writer.WriteAttributeString("end", dr[2].ToString());
                        writer.WriteAttributeString("id", contador.ToString() + "-1");
                        writer.WriteAttributeString("color", "FFFF00");
                        writer.WriteAttributeString("height", "7");
                        writer.WriteAttributeString("topPadding", "2");
                        writer.WriteAttributeString("animation", "0");
                        writer.WriteEndElement();

                        string alpha = "0";
                        if (dr[3].ToString() != "")
                            alpha = "100";
                        string color = "32CD32";
                        if (dr[4].ToString() == DateTime.Now.ToShortDateString())
                            color = "0000FF";
                        writer.WriteStartElement("task");
                        writer.WriteAttributeString("name", "Executado");
                        writer.WriteAttributeString("processId", contador.ToString());
                        writer.WriteAttributeString("start", dr[3].ToString());
                        writer.WriteAttributeString("end", dr[4].ToString());
                        writer.WriteAttributeString("id", contador.ToString());
                        writer.WriteAttributeString("color", color);
                        writer.WriteAttributeString("height", "7");
                        writer.WriteAttributeString("topPadding", "11");
                        writer.WriteAttributeString("alpha", alpha);
                        writer.WriteEndElement();
                        contador++;
                    }
                }
                writer.WriteEndElement();
                //Fecha elemento Cliente
                writer.WriteEndElement();
                writer.Flush();
            }
        }

        private void buscar_informacoes_todas_os(out DataSet dsInformacoes)
        {
            DataSet ds = new DataSet();
            dsInformacoes = ds;
            try
            {
                //SELECIONANDO AS OS ENVOLVIDAS
                string todas_os = ""; 
                for (int i = 0; i < numero_de_os; i++)
                {
                    if(i == 0)
                        todas_os = " WHERE N_OS_PECA = '" + todas_os_a_criar[i] + "'";
                    else
                        todas_os = todas_os + " OR N_OS_PECA = '" + todas_os_a_criar[i] + "'";
                }

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT N_OS_PECA, NOME_PECA FROM DESENHOS " + todas_os ;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    DataTable datRotas = new DataTable();
                    datRotas.Columns.Add("NOME_OPERACAO");
                    datRotas.Columns.Add("DATA_ENTRADA_PREV");
                    datRotas.Columns.Add("DATA_FECHAMENTO_PREV");
                    datRotas.Columns.Add("DATA_ENTRADA");
                    datRotas.Columns.Add("DATA_FECHAMENTO");
                    datRotas.Columns.Add("PORC_EXECUTADA");
                    int i = 0;
                    datRotas.TableName = dr[0].ToString();
                    //datRotas.Rows.Add("*" + dr_tipo_conjuntos[0].ToString() + "*");
                    
                        string DATA_ENTRADA_PREV; string DATA_FECHAMENTO_PREV; string DATA_ENTRADA;
                        string DATA_FECHAMENTO; string porc_executada;
                        buscar_informacoes_os_inteira(dr[0].ToString(),
                            out DATA_ENTRADA_PREV, out DATA_FECHAMENTO_PREV, out DATA_ENTRADA, out DATA_FECHAMENTO,
                            out porc_executada);
                        datRotas.Rows.Add(dr[1].ToString(), DATA_ENTRADA_PREV, DATA_FECHAMENTO_PREV, DATA_ENTRADA, DATA_FECHAMENTO, porc_executada);


                    
                    dsInformacoes.Tables.Add(datRotas);
                    //criando 1 Datatable para cada Função(Conjunto)
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void buscar_informacoes(out DataSet dsInformacoes)
        {
            DataSet ds = new DataSet();
            dsInformacoes = ds;
            try
            {
                //SEELCIONANDO OS TIPOS DE FUNCAO DA OP
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DISTINCT FUNCAO_OP FROM OP WHERE DESENHO_OP_ATUAL = '" + todas_os_a_criar[0] + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                string tipo_funcao = "";
                bool primeiro = true;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    //operacoes[n_operacoes] = dr[0].ToString();
                    //n_operacoes++;
                    if (primeiro)
                    {
                        tipo_funcao = "AND (NOME_CONJUNTO = '" + dr[0].ToString() + "' ";
                        primeiro = false;
                    }
                    else
                    {
                        tipo_funcao = tipo_funcao + " OR NOME_CONJUNTO = '" + dr[0].ToString() + "' ";
                    }
                }
                if (tipo_funcao != "")
                    tipo_funcao = tipo_funcao + ")";

                //COLOCANDO EM ORDEM AS FUNCOES CONFORME CADASTRO
                FbCommand select_conjunto = new FbCommand();
                select_conjunto.Connection = fbConnection1;
                fbConnection1.Open();
                select_conjunto.CommandText =
                    "SELECT NOME_CONJUNTO FROM CONJUNTO_PECA WHERE COD_CONJUNTO IS NOT NULL " + tipo_funcao + " ORDER BY ORDEM_CONJUNTO";
                FbDataAdapter datTipos_conjuntos = new FbDataAdapter();
                datTipos_conjuntos.SelectCommand = select_conjunto;
                DataSet dsTipos_conjuntos = new DataSet();
                datTipos_conjuntos.Fill(dsTipos_conjuntos);
                fbConnection1.Close();
                foreach (DataRow dr_tipo_conjuntos in dsTipos_conjuntos.Tables[0].Rows)
                {
                    //selecionando operações e organizando conforme campo de ordem
                    FbCommand select_operacoes = new FbCommand();
                    select_operacoes.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_operacoes.CommandText =
                        "SELECT DISTINCT OPERACAO_CAMPO FROM ROTAS_CAMPO WHERE FUNCAO_ROTA = '" +
                        dr_tipo_conjuntos[0].ToString() + "' AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%')";
                    FbDataAdapter datTabela_operacoes = new FbDataAdapter();
                    datTabela_operacoes.SelectCommand = select_operacoes;
                    DataSet dsTabela_operacoes = new DataSet();
                    datTabela_operacoes.Fill(dsTabela_operacoes);
                    fbConnection1.Close();
                    string tipo_operacao = "";
                    bool primeiro_operacao = true;
                    foreach (DataRow dr_operacoes in dsTabela_operacoes.Tables[0].Rows)
                    {
                        //operacoes[n_operacoes] = dr[0].ToString();
                        //n_operacoes++;
                        if (primeiro_operacao)
                        {
                            tipo_operacao = "AND (TIPO = '" + dr_operacoes[0].ToString() + "' ";
                            primeiro_operacao = false;
                        }
                        else
                        {
                            tipo_operacao = tipo_operacao + " OR TIPO = '" + dr_operacoes[0].ToString() + "' ";
                        }
                    }
                    if (tipo_operacao != "")
                        tipo_operacao = tipo_operacao + ")";

                    //COLOCANDO EM ORDEM AS OPERACOES CONFORME CADASTRO
                    FbCommand select_tipo = new FbCommand();
                    select_tipo.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_tipo.CommandText =
                        "SELECT TIPO FROM TIPOS_OPERACOES WHERE COD_TIPO IS NOT NULL " + tipo_operacao + " ORDER BY ORDEM_OPERACAO_TIPO";
                    FbDataAdapter datTipos = new FbDataAdapter();
                    datTipos.SelectCommand = select_tipo;
                    DataSet dsTipos = new DataSet();
                    datTipos.Fill(dsTipos);
                    fbConnection1.Close();
                    DataTable datRotas = new DataTable();
                    datRotas.Columns.Add("NOME_OPERACAO");
                    datRotas.Columns.Add("DATA_ENTRADA_PREV");
                    datRotas.Columns.Add("DATA_FECHAMENTO_PREV");
                    datRotas.Columns.Add("DATA_ENTRADA");
                    datRotas.Columns.Add("DATA_FECHAMENTO");
                    datRotas.Columns.Add("PORC_EXECUTADA");
                    int i = 0;
                    datRotas.TableName = dr_tipo_conjuntos[0].ToString();
                    //datRotas.Rows.Add("*" + dr_tipo_conjuntos[0].ToString() + "*");
                    foreach (DataRow dr_tipo in dsTipos.Tables[0].Rows)
                    {
                         string DATA_ENTRADA_PREV;  string DATA_FECHAMENTO_PREV;  string DATA_ENTRADA;
                         string DATA_FECHAMENTO; string porc_executada;
                        buscar_informacoes_operacao(dr_tipo_conjuntos[0].ToString(), dr_tipo[0].ToString(),
                            out DATA_ENTRADA_PREV, out DATA_FECHAMENTO_PREV, out DATA_ENTRADA, out DATA_FECHAMENTO, 
                            out porc_executada);
                        datRotas.Rows.Add(dr_tipo[0].ToString(), DATA_ENTRADA_PREV, DATA_FECHAMENTO_PREV, DATA_ENTRADA, DATA_FECHAMENTO, porc_executada);
                        
                        
                    }
                    dsInformacoes.Tables.Add(datRotas);       
                    //criando 1 Datatable para cada Função(Conjunto)
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        private void buscar_informacoes_os_inteira(string os,
            out string DATA_ENTRADA_PREV, out string DATA_FECHAMENTO_PREV, out string DATA_ENTRADA,
            out string DATA_FECHAMENTO, out string porc_executada)
        {
            DATA_ENTRADA_PREV = buscar_DATA_ENTRADA_PREV_OS(os);
            DATA_FECHAMENTO_PREV = buscar_DATA_FECHAMENTO_PREV_OS(os);
            DATA_ENTRADA = buscar_DATA_ENTRADA_OS(os);
            DATA_FECHAMENTO = buscar_DATA_FECHAMENTO_OS(os);

            porc_executada = buscar_porcentagem_OS(os);
        }

        private void buscar_informacoes_operacao(string tipo_conjunto, string operacao, 
            out string DATA_ENTRADA_PREV, out string DATA_FECHAMENTO_PREV, out string DATA_ENTRADA, 
            out string DATA_FECHAMENTO, out string porc_executada)
        {
            DATA_ENTRADA_PREV = buscar_DATA_ENTRADA_PREV(tipo_conjunto, operacao);
            DATA_FECHAMENTO_PREV = buscar_DATA_FECHAMENTO_PREV(tipo_conjunto, operacao);
            DATA_ENTRADA = buscar_DATA_ENTRADA(tipo_conjunto, operacao);
            DATA_FECHAMENTO = buscar_DATA_FECHAMENTO(tipo_conjunto, operacao);

            porc_executada = buscar_porcentagem(tipo_conjunto, operacao);
        }

        private string buscar_porcentagem_OS(string os)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT POSICAO_ATUAL, PREVISAO_PRODUCAO, SALDO_HORAS " +
                    "FROM ROTAS_CAMPO WHERE DESENHO_CAMPO = '" + os + "' AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%')";

                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                double _soma_porc = 0;
                int i = 0;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    i++;
                    double _porc_item = 0;
                    try
                    {
                        if (dr[0].ToString() == "FINALIZADO" || dr[0].ToString().Contains("NÃO NECESSÁRIA"))
                            _porc_item = 100;
                        else
                            _porc_item = Convert.ToDouble(dr[2].ToString()) / Convert.ToDouble(dr[1].ToString()) * 100;
                        if (_porc_item > 100)
                            _porc_item = 95;
                    }
                    catch { }
                    _soma_porc = _soma_porc + _porc_item;

                }
                double _porc = _soma_porc / i;


                return _porc.ToString("n0"); //PQ TEM COISA EM ANDAMENTO
            }

            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }


        private string buscar_porcentagem(string tipo_conjunto, string operacao)
        {
            try
            {
                string where = "FUNCAO_ROTA = '";
                string _operacao = " AND OPERACAO_CAMPO = '" + operacao + "'";
                if (por_posicao)
                {
                    where = " OP_ROTA = '";
                    operacao = " AND COD_ROTA_CAMPO = '" + operacao + "'";
                }

                /*
                string where = "FUNCAO_ROTA = '";
                if (por_posicao)
                    where = " OP_ROTA = '";
                */
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT POSICAO_ATUAL, PREVISAO_PRODUCAO, SALDO_HORAS " +
                    "FROM ROTAS_CAMPO WHERE " + where + tipo_conjunto +
                    "' " + _operacao + " AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') ";

                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                double _soma_porc = 0;
                int i = 0;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    i++;
                    double _porc_item = 0;
                    try
                    {
                        if (dr[0].ToString() == "FINALIZADO")
                            _porc_item = 100;
                        else
                            _porc_item = Convert.ToDouble(dr[2].ToString()) / Convert.ToDouble(dr[1].ToString()) * 100;
                        if (_porc_item > 100)
                            _porc_item = 95;
                    }
                    catch { }
                    _soma_porc = _soma_porc + _porc_item;
                    
                }
                double _porc = _soma_porc / i;


                return _porc.ToString("n0"); //PQ TEM COISA EM ANDAMENTO
            }

            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }
        private string buscar_DATA_FECHAMENTO_OS(string os)
        {
            try
            {

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FECHAMENTO FROM ROTAS_CAMPO WHERE DESENHO_CAMPO = '" + os + "' " +
                    "AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') AND DATA_FECHAMENTO IS NULL ";

                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return DateTime.Now.ToShortDateString();
                    }
                    catch { }

                }

                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FECHAMENTO FROM ROTAS_CAMPO WHERE DESENHO_CAMPO = '" + os_a_criar + "' " +
                    " AND DATA_FECHAMENTO IS NOT NULL " +
                    "ORDER BY DATA_FECHAMENTO DESC";
                datTabela.SelectCommand = select;
                DataSet dsTabela2 = new DataSet();
                datTabela.Fill(dsTabela2);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela2.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }

                }
                return DateTime.Now.ToShortDateString(); //PQ TEM COISA EM ANDAMENTO
            }

            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }


        private string buscar_DATA_FECHAMENTO(string tipo_conjunto, string operacao)
        {
            try
            {
                string where = "FUNCAO_ROTA = '";
                string _operacao = " AND OPERACAO_CAMPO = '" + operacao + "'";
                if (por_posicao)
                {
                    where = " OP_ROTA = '";
                    _operacao = " AND COD_ROTA_CAMPO = '" + operacao + "'";
                }

                /*
                string where = "FUNCAO_ROTA = '";
                if (por_posicao)
                    where = " OP_ROTA = '";
                */
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FECHAMENTO FROM ROTAS_CAMPO WHERE " + where + tipo_conjunto +
                    "' " + _operacao + " AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' " +
                    " AND DATA_FECHAMENTO IS NULL AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%')";
                    
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return DateTime.Now.ToShortDateString();
                    }
                    catch { }

                }

                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FECHAMENTO FROM ROTAS_CAMPO WHERE " + where + tipo_conjunto +
                    "' " + _operacao +  " AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' " +
                    " AND DATA_FECHAMENTO IS NOT NULL " +
                    "ORDER BY DATA_FECHAMENTO DESC";
                datTabela.SelectCommand = select;
                DataSet dsTabela2 = new DataSet();
                datTabela.Fill(dsTabela2);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela2.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }

                }
                return DateTime.Now.ToShortDateString(); //PQ TEM COISA EM ANDAMENTO
            }

            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }

        private string buscar_DATA_ENTRADA_OS(string os)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_ENTRADA FROM ROTAS_CAMPO WHERE DATA_ENTRADA IS NOT NULL AND DESENHO_CAMPO = '" + os + "' " +
                    "AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') ORDER BY DATA_ENTRADA";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }

                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }


        private string buscar_DATA_ENTRADA(string tipo_conjunto, string operacao)
        {
            try
            {
                string where = "FUNCAO_ROTA = '";
                string _operacao = " AND OPERACAO_CAMPO = '" + operacao + "'";
                if (por_posicao)
                {
                    where = " OP_ROTA = '";
                    _operacao = " AND COD_ROTA_CAMPO = '" + operacao + "'";
                }

                /*
                string where = "FUNCAO_ROTA = '";
                if (por_posicao)
                    where = " OP_ROTA = '";
                */
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_ENTRADA FROM ROTAS_CAMPO WHERE DATA_ENTRADA IS NOT NULL AND " + where + tipo_conjunto +
                    "' " + _operacao + " AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' " +
                    "AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') ORDER BY DATA_ENTRADA";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }

                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }
        private string buscar_DATA_FECHAMENTO_PREV_OS(string os)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FECHAMENTO_PREV FROM ROTAS_CAMPO WHERE DATA_FECHAMENTO_PREV IS NOT NULL AND DESENHO_CAMPO = '" + os + "' " +
                    "AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') ORDER BY DATA_FECHAMENTO_PREV DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }

                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }


        private string buscar_DATA_FECHAMENTO_PREV(string tipo_conjunto, string operacao)
        {
            try
            {
                string where = "FUNCAO_ROTA = '";
                string _operacao = " AND OPERACAO_CAMPO = '" + operacao + "'";
                if (por_posicao)
                {
                    where = " OP_ROTA = '";
                    _operacao = " AND COD_ROTA_CAMPO = '" + operacao + "'";
                }

                /*
                string where = "FUNCAO_ROTA = '";
                if (por_posicao)
                    where = " OP_ROTA = '";
                */
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FECHAMENTO_PREV FROM ROTAS_CAMPO WHERE DATA_FECHAMENTO_PREV IS NOT NULL AND " + where + tipo_conjunto +
                    "' " + _operacao +  " AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' " +
                    "AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') ORDER BY DATA_FECHAMENTO_PREV DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }

                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }
        private string buscar_DATA_ENTRADA_PREV_OS(string os)
        {
            try
            {

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_ENTRADA_PREV FROM ROTAS_CAMPO WHERE DATA_ENTRADA_PREV IS NOT NULL AND DESENHO_CAMPO = '" + os + "' " +
                    "AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') ORDER BY DATA_ENTRADA_PREV";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }

                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }


        private string buscar_DATA_ENTRADA_PREV(string tipo_conjunto, string operacao)
        {
            try
            {
                string where = "FUNCAO_ROTA = '";
                string _operacao = " AND OPERACAO_CAMPO = '" + operacao + "'";
                if (por_posicao)
                {
                    where = " OP_ROTA = '";
                    _operacao = " AND COD_ROTA_CAMPO = '" + operacao + "'";
                }

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_ENTRADA_PREV FROM ROTAS_CAMPO WHERE DATA_ENTRADA_PREV IS NOT NULL AND " + where + tipo_conjunto + 
                    "' " + _operacao + " AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' " +
                    "AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%') ORDER BY DATA_ENTRADA_PREV";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDateTime(dr[0].ToString()).ToShortDateString();
                    }
                    catch { }
                    
                }
                return ""; 
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return "";
            }
        }

        private void buscar_semanas(DateTime primeiro_dia_os, DateTime ultimo_dia_os, 
            out DateTime[] primeiro_dia_semana, out DateTime[] ultimo_dia_semana, 
            out int[] semana_numero, out int n_semanas)
        {
            DateTime domingo_corrente = buscar_domingo(primeiro_dia_os);
            DateTime sabado_corrente = buscar_domingo(primeiro_dia_os).AddDays(6);
            DateTime[] inicializar = new DateTime[200];
            DateTime[] inicializar2 = new DateTime[200];
            int[] _inicializar = new int[200];
            primeiro_dia_semana = inicializar; ultimo_dia_semana = inicializar2; semana_numero = _inicializar; 
            n_semanas = 0;
            for (int j = 0; j < 200; j++)
            {
                primeiro_dia_semana[j] = Convert.ToDateTime("01/01/2001");
                ultimo_dia_semana[j] = Convert.ToDateTime("01/01/2001");
                semana_numero[j] = 0;
            }
            for (int i = 0; domingo_corrente < ultimo_dia_os; i++)
            {
                //buscando primeira semana ano
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM DIA_SEMANA_ANO WHERE ANO_DSA = '" + domingo_corrente.Year.ToString() + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();
                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        DateTime primeiro_dia_ano = Convert.ToDateTime(dr["PRIMEIRO_DIA_ANO_DSA"].ToString());
                        int primeira_semana_ano = Convert.ToInt32(dr["PRIMEIRA_SEMANA_ANO_DSA"].ToString());
                        primeiro_dia_semana[i] = domingo_corrente;
                        ultimo_dia_semana[i] = sabado_corrente;
                        semana_numero[i] = buscar_semana_numero(primeiro_dia_ano, domingo_corrente, primeira_semana_ano);
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    form_erro erro = new form_erro();
                    erro.erro = a.ToString();
                    erro.ShowDialog();
                }
                n_semanas = i + 1;
                domingo_corrente = domingo_corrente.AddDays(7);
                sabado_corrente = sabado_corrente.AddDays(7);
            }
            
        }

        private int buscar_semana_numero(DateTime primeiro_dia_ano, DateTime domingo_corrente, int primeira_semana_ano)
        {
            int diferenca_em_semanas = 0;
            try
            {
                TimeSpan diferenca = domingo_corrente - primeiro_dia_ano;
                diferenca_em_semanas = diferenca.Days / 7;
                return diferenca_em_semanas + primeira_semana_ano;
            }
            catch
            {
                return 0;
            }
                
        }

        private DateTime buscar_domingo(DateTime primeiro_dia_os)
        {
            DateTime domingo = primeiro_dia_os;
            while (domingo.DayOfWeek != DayOfWeek.Sunday)
            {
                domingo = domingo.AddDays(-1);
            }
            return domingo;
        }

        

        private DateTime ultimo_dia_os()
        {
            DateTime retorno = Convert.ToDateTime("01/01/2001");
            DateTime maior_data_entrada = DateTime.Now;
            DateTime maior_data_entrada_prev = DateTime.Now;
            try
            {
                for (int i = 0; i < numero_de_os; i++)
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT DATA_FECHAMENTO_PREV, DATA_FECHAMENTO FROM ROTAS_CAMPO WHERE DATA_FECHAMENTO_PREV IS NOT NULL AND " +
                        "DESENHO_CAMPO = '" + todas_os_a_criar[i] + "' ORDER BY DATA_FECHAMENTO_PREV DESC";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();

                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        try
                        {
                            if (maior_data_entrada < Convert.ToDateTime(dr[1].ToString()))
                                maior_data_entrada = Convert.ToDateTime(dr[1].ToString());
                        }
                        catch { }
                        try
                        {
                            if (maior_data_entrada_prev < Convert.ToDateTime(dr[0].ToString()))
                                maior_data_entrada_prev = Convert.ToDateTime(dr[0].ToString());
                        }
                        catch { }

                    }
                }
                if (maior_data_entrada_prev < maior_data_entrada)
                    return maior_data_entrada;
                else
                    return maior_data_entrada_prev;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return retorno;
            }
        }

        private DateTime primeiro_dia_os()
        {
            DateTime retorno = Convert.ToDateTime("01/01/2001");
            DateTime menor_data_entrada = Convert.ToDateTime("01/01/2100");
            DateTime menor_data_entrada_prev = Convert.ToDateTime("01/01/2100");
            try
            {
                for (int i = 0; i < numero_de_os; i++)
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT DATA_ENTRADA_PREV, DATA_ENTRADA FROM ROTAS_CAMPO WHERE DATA_ENTRADA_PREV IS NOT NULL AND " +
                        "DESENHO_CAMPO = '" + todas_os_a_criar[i] + "' ORDER BY DATA_ENTRADA_PREV";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();

                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        try
                        {
                            if (menor_data_entrada > Convert.ToDateTime(dr[1].ToString()))
                                menor_data_entrada = Convert.ToDateTime(dr[1].ToString());
                        }
                        catch { }
                        try
                        {
                            if (menor_data_entrada_prev > Convert.ToDateTime(dr[0].ToString()))
                                menor_data_entrada_prev = Convert.ToDateTime(dr[0].ToString());
                        }
                        catch { }

                    }
                }
                if (menor_data_entrada_prev > menor_data_entrada)
                    return menor_data_entrada;
                else
                    return menor_data_entrada_prev;
            }
            catch (Exception a)
            {

                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
                return retorno;
            }
        }



        internal void abrir_html(string local)
        {
            System.Diagnostics.Process.Start(@local);
        }

        internal void criar_xml_os_geral(string local)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(local, settings))
            {
                writer.WriteStartElement("chart");
                writer.WriteAttributeString("dateFormat", "dd/mm/yyyy");
                writer.WriteAttributeString("hoverCapBorderColor", "ffffff");
                writer.WriteAttributeString("hoverCapBgColor", "ffffff");
                writer.WriteAttributeString("ganttWidthPercent", "60");
                writer.WriteAttributeString("ganttLineAlpha", "80");
                writer.WriteAttributeString("canvasBorderColor", "024455");
                writer.WriteAttributeString("canvasBorderThickness", "0");
                writer.WriteAttributeString("gridBorderColor", "4567aa");
                writer.WriteAttributeString("gridBorderAlpha", "20");
                writer.WriteAttributeString("width", "850");
                
                
                DateTime _primeiro_dia_os = primeiro_dia_os();
                DateTime _ultimo_dia_os = ultimo_dia_os();

                DateTime[] primeiro_dia_semana = new DateTime[200];
                DateTime[] ultimo_dia_semana = new DateTime[200];
                int[] semana_numero = new int[200];
                int n_semanas = 0;
                buscar_semanas(_primeiro_dia_os, _ultimo_dia_os, out primeiro_dia_semana,
                    out ultimo_dia_semana, out semana_numero, out n_semanas);

                writer.WriteStartElement("categories");
                writer.WriteAttributeString("bgColor", "EEE9E9");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteStartElement("category");
                writer.WriteAttributeString("start", primeiro_dia_semana[0].ToShortDateString());
                writer.WriteAttributeString("end", ultimo_dia_semana[n_semanas - 1].ToShortDateString());
                writer.WriteAttributeString("align", "center");
                writer.WriteAttributeString("name", "Semanas");
                writer.WriteAttributeString("font", "Verdana");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("fontSize", "16");
                writer.WriteEndElement(); //fecha category
                writer.WriteEndElement(); //fecha categories

                writer.WriteStartElement("categories");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("fontColor", "0000ff");
                writer.WriteAttributeString("fontSize", "10");



                for (int i = 0; i < n_semanas; i++)
                {
                    writer.WriteStartElement("category");
                    writer.WriteAttributeString("start", primeiro_dia_semana[i].ToShortDateString());
                    writer.WriteAttributeString("end", ultimo_dia_semana[i].ToShortDateString());
                    writer.WriteAttributeString("align", "center");
                    writer.WriteAttributeString("name", semana_numero[i].ToString());
                    writer.WriteAttributeString("isBold", "1");

                    //writer.WriteAttributeString("width", tamanho.ToString());
                    writer.WriteEndElement(); //fecha category
                }
                writer.WriteEndElement(); //fecha categories

                writer.WriteStartElement("processes");
                writer.WriteAttributeString("headerText", "Processos");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("fontSize", "10");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("isAnimated", "1");
                writer.WriteAttributeString("bgColor", "EEE9E9");
                writer.WriteAttributeString("headerVAlign", "center");
                writer.WriteAttributeString("headerbgColor", "EEE9E9");
                writer.WriteAttributeString("headerFontColor", "000000");
                writer.WriteAttributeString("headerFontSize", "16");
                writer.WriteAttributeString("width", "210");
                writer.WriteAttributeString("align", "left");
                //selecionando as funções
                DataSet dsInformacoes = new DataSet();
                if (por_funcao)
                    buscar_informacoes(out dsInformacoes);
                if (por_os)
                    buscar_informacoes_todas_os(out dsInformacoes);
                if (por_posicao)
                    buscar_informacoes_por_posicao(out dsInformacoes);

                contador = 1;
                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    if (!por_os)
                    {
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", dsInformacoes.Tables[i].TableName);
                        writer.WriteAttributeString("id", contador.ToString());
                        writer.WriteAttributeString("bgColor", "FFDAB9");
                        writer.WriteEndElement();
                        contador++;
                    }
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("process");
                        writer.WriteAttributeString("Name", dr[0].ToString());
                        writer.WriteAttributeString("id", contador.ToString());
                        writer.WriteAttributeString("bgColor", "87CEFA");
                        writer.WriteEndElement();
                        contador++;
                    }
                }
                writer.WriteEndElement(); // fecha processes

                //datas previstas e reais
                writer.WriteStartElement("dataTable");
                writer.WriteAttributeString("showProcessName", "1");
                writer.WriteAttributeString("nameAlign", "left");
                writer.WriteAttributeString("fontColor", "000000");
                writer.WriteAttributeString("fontSize", "10");
                writer.WriteAttributeString("isBold", "1");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("headerFontColor", "00000");
                writer.WriteAttributeString("headerFontSize", "9");
                writer.WriteAttributeString("vAlign", "center");
                writer.WriteAttributeString("align", "left");

                //INICIO PREV
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "I.Prev.");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    if (!por_os)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", "");
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteAttributeString("bgColor", "FFDAB9");
                        writer.WriteEndElement();
                    }
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[1].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //INICIO REAL
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "I.Real.");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    if (!por_os)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", "");
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteAttributeString("bgColor", "FFDAB9");
                        writer.WriteEndElement();
                    }
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {

                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[3].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //FIM PREVISTO
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "F.Prev.");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    if (!por_os)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", "");
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteAttributeString("bgColor", "FFDAB9");
                        writer.WriteEndElement();
                    }
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[2].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //FIM REAL
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "36");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "F.Real.");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    if (!por_os)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", "");
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteAttributeString("bgColor", "FFDAB9");
                        writer.WriteEndElement();
                    }
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        string fontcolor = "000000";
                        if (dr[4].ToString() == DateTime.Now.ToShortDateString())
                            fontcolor = "ffffff";
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[4].ToString());
                        writer.WriteAttributeString("FontColor", fontcolor);
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                //Porc
                writer.WriteStartElement("dataColumn");
                writer.WriteAttributeString("width", "32");
                writer.WriteAttributeString("headerfontcolor", "000000");
                writer.WriteAttributeString("headerBgColor", "EEE9E9");
                writer.WriteAttributeString("bgColor", "ffffff");
                writer.WriteAttributeString("headerColor", "ffffff");
                writer.WriteAttributeString("headerText", "%");
                writer.WriteAttributeString("isBold", "1");


                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    if (!por_os)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", "");
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteAttributeString("bgColor", "FFDAB9");
                        writer.WriteEndElement();
                    }
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("text");
                        writer.WriteAttributeString("label", dr[5].ToString());
                        writer.WriteAttributeString("FontColor", "000000");
                        writer.WriteAttributeString("fontSize", "8");
                        writer.WriteAttributeString("vAlign", "center");
                        writer.WriteAttributeString("align", "center");
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndElement();


                //inicio das barras
                writer.WriteStartElement("tasks");

                contador = 1;
                for (int i = 0; i < dsInformacoes.Tables.Count; i++)
                {
                    if (!por_os)
                    {
                        writer.WriteStartElement("task");
                        writer.WriteAttributeString("name", "Previsto");
                        writer.WriteAttributeString("processId", contador.ToString());
                        writer.WriteAttributeString("start", "");
                        writer.WriteAttributeString("end", "");
                        writer.WriteAttributeString("id", contador.ToString() + "-1");
                        writer.WriteAttributeString("color", "");
                        writer.WriteAttributeString("height", "7");
                        writer.WriteAttributeString("topPadding", "2");
                        writer.WriteAttributeString("animation", "0");
                        writer.WriteAttributeString("alpha", "0");
                        writer.WriteEndElement();

                        writer.WriteStartElement("task");
                        writer.WriteAttributeString("name", "Executado");
                        writer.WriteAttributeString("processId", contador.ToString());
                        writer.WriteAttributeString("start", "");
                        writer.WriteAttributeString("end", "");
                        writer.WriteAttributeString("id", contador.ToString());
                        writer.WriteAttributeString("color", "");
                        writer.WriteAttributeString("height", "7");
                        writer.WriteAttributeString("topPadding", "11");
                        writer.WriteAttributeString("alpha", "0");
                        writer.WriteEndElement();
                        contador++;
                    }
                    
                    foreach (DataRow dr in dsInformacoes.Tables[i].Rows)
                    {
                        writer.WriteStartElement("task");
                        writer.WriteAttributeString("name", "Previsto");
                        writer.WriteAttributeString("processId", contador.ToString());
                        writer.WriteAttributeString("start", dr[1].ToString());
                        writer.WriteAttributeString("end", dr[2].ToString());
                        writer.WriteAttributeString("id", contador.ToString() + "-1");
                        writer.WriteAttributeString("color", "FFFF00");
                        writer.WriteAttributeString("height", "7");
                        writer.WriteAttributeString("topPadding", "2");
                        writer.WriteAttributeString("animation", "0");
                        writer.WriteEndElement();

                        string alpha = "0";
                        if (dr[3].ToString() != "")
                            alpha = "100";
                        string color = "32CD32";
                        if (dr[4].ToString() == DateTime.Now.ToShortDateString())
                            color = "0000FF";
                        writer.WriteStartElement("task");
                        writer.WriteAttributeString("name", "Executado");
                        writer.WriteAttributeString("processId", contador.ToString());
                        writer.WriteAttributeString("start", dr[3].ToString());
                        writer.WriteAttributeString("end", dr[4].ToString());
                        writer.WriteAttributeString("id", contador.ToString());
                        writer.WriteAttributeString("color", color);
                        writer.WriteAttributeString("height", "7");
                        writer.WriteAttributeString("topPadding", "11");
                        writer.WriteAttributeString("alpha", alpha);
                        writer.WriteEndElement();
                        contador++;
                    }
                }
                writer.WriteEndElement();
                //Fecha elemento Cliente
                writer.WriteEndElement();
                writer.Flush();
            }
        }

        private void buscar_informacoes_por_posicao(out DataSet dsInformacoes)
        {
            DataSet ds = new DataSet();
            dsInformacoes = ds;
            try
            {
                //SELECIONANDO OS TIPOS DE FUNCAO DA OP
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DISTINCT(COND_PGTO), N_PDF, DESCRICAO_FERRAMENTA_OP, CODIGO_OP, COD_OP, FERRAMENTA_OP FROM OP WHERE DESENHO_OP_ATUAL = '" + todas_os_a_criar[0] + "' ORDER BY COND_PGTO";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                string tipo_funcao = "";
                bool primeiro = true;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        //selecionando operações e organizando conforme campo de ordem
                        FbCommand select_operacoes = new FbCommand();
                        select_operacoes.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_operacoes.CommandText =
                            "SELECT OPERACAO_CAMPO, COD_ROTA_CAMPO FROM ROTAS_CAMPO WHERE OP_ROTA = '" +
                            dr[4].ToString() + "' AND DESENHO_CAMPO = '" + todas_os_a_criar[0] + "' AND UPPER(OPERACAO_CAMPO) NOT LIKE ('%SOLDA%')" +
                            " ORDER BY POSICAO_FILA_CAMPO, COD_ROTA_CAMPO ";
                        FbDataAdapter datTabela_operacoes = new FbDataAdapter();
                        datTabela_operacoes.SelectCommand = select_operacoes;
                        DataSet dsTabela_operacoes = new DataSet();
                        datTabela_operacoes.Fill(dsTabela_operacoes);
                        fbConnection1.Close();

                        DataTable datRotas = new DataTable();
                        datRotas.Columns.Add("NOME_OPERACAO");
                        datRotas.Columns.Add("DATA_ENTRADA_PREV");
                        datRotas.Columns.Add("DATA_FECHAMENTO_PREV");
                        datRotas.Columns.Add("DATA_ENTRADA");
                        datRotas.Columns.Add("DATA_FECHAMENTO");
                        datRotas.Columns.Add("PORC_EXECUTADA");
                        int i = 0;
                        datRotas.TableName = dr[0].ToString().Replace(" ", "") + " - " + dr[5].ToString() + " - " + dr[3].ToString().Replace(" ", "") + " (" + dr[4].ToString().Replace(" ", "") + ")";

                        //string tipo_operacao = "";
                        //bool primeiro_operacao = true;
                        foreach (DataRow dr_operacoes in dsTabela_operacoes.Tables[0].Rows)
                        {
                            string DATA_ENTRADA_PREV; string DATA_FECHAMENTO_PREV; string DATA_ENTRADA;
                            string DATA_FECHAMENTO; string porc_executada;
                            
                            buscar_informacoes_operacao(dr[4].ToString(), dr_operacoes[1].ToString(),
                                out DATA_ENTRADA_PREV, out DATA_FECHAMENTO_PREV, out DATA_ENTRADA, out DATA_FECHAMENTO,
                                out porc_executada);
                            datRotas.Rows.Add(dr_operacoes[0].ToString(), DATA_ENTRADA_PREV, DATA_FECHAMENTO_PREV, DATA_ENTRADA, DATA_FECHAMENTO, porc_executada);

                            //operacoes[n_operacoes] = dr[0].ToString();
                            //n_operacoes++;
                            /* 20/10/2014 ORGANIZANDO CONFORME A A POSIÇÃO
                            if (primeiro_operacao)
                            {
                                tipo_operacao = "AND (TIPO = '" + dr_operacoes[0].ToString() + "' ";
                                primeiro_operacao = false;
                            }
                            else
                            {
                                tipo_operacao = tipo_operacao + " OR TIPO = '" + dr_operacoes[0].ToString() + "' ";
                            }
                            20/10/2014 ORGANIZANDO CONFORME A A POSIÇÃO */
                        }

                        //if (tipo_operacao != "")
                        //    tipo_operacao = tipo_operacao + ")";

                        //COLOCANDO EM ORDEM AS OPERACOES CONFORME CADASTRO
                        /* 20/10/2014 ORGANIZANDO CONFORME A A POSIÇÃO
                        FbCommand select_tipo = new FbCommand();
                        select_tipo.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_tipo.CommandText =
                            "SELECT TIPO FROM TIPOS_OPERACOES WHERE COD_TIPO IS NOT NULL " + tipo_operacao + " ORDER BY ORDEM_OPERACAO_TIPO";
                        FbDataAdapter datTipos = new FbDataAdapter();
                        datTipos.SelectCommand = select_tipo;
                        DataSet dsTipos = new DataSet();
                        datTipos.Fill(dsTipos);
                        fbConnection1.Close();
                        DataTable datRotas = new DataTable();
                        datRotas.Columns.Add("NOME_OPERACAO");
                        datRotas.Columns.Add("DATA_ENTRADA_PREV");
                        datRotas.Columns.Add("DATA_FECHAMENTO_PREV");
                        datRotas.Columns.Add("DATA_ENTRADA");
                        datRotas.Columns.Add("DATA_FECHAMENTO");
                        datRotas.Columns.Add("PORC_EXECUTADA");
                        int i = 0;
                        datRotas.TableName = dr[0].ToString().Replace(" ", "") + " - " + dr[5].ToString() + " - " + dr[3].ToString().Replace(" ", "") + " (" + dr[4].ToString().Replace(" ", "") + ")";
                        //datRotas.Rows.Add("*" + dr_tipo_conjuntos[0].ToString() + "*");
                        foreach (DataRow dr_tipo in dsTipos.Tables[0].Rows)
                        {
                            string DATA_ENTRADA_PREV; string DATA_FECHAMENTO_PREV; string DATA_ENTRADA;
                            string DATA_FECHAMENTO; string porc_executada;
                            buscar_informacoes_operacao(dr[4].ToString(), dr_tipo[0].ToString(),
                                out DATA_ENTRADA_PREV, out DATA_FECHAMENTO_PREV, out DATA_ENTRADA, out DATA_FECHAMENTO,
                                out porc_executada);
                            datRotas.Rows.Add(dr_tipo[0].ToString(), DATA_ENTRADA_PREV, DATA_FECHAMENTO_PREV, DATA_ENTRADA, DATA_FECHAMENTO, porc_executada);


                        }
                        20/10/2014 ORGANIZANDO CONFORME A A POSIÇÃO */
                        dsInformacoes.Tables.Add(datRotas);
                        //criando 1 Datatable para cada Função(Conjunto)
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        form_erro erro = new form_erro();
                        erro.erro = a.ToString();
                        erro.ShowDialog();
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        internal void criar_html_os_geral(string local)
        {
            string _os = "", _cliente = "", _responsavel = "", _prazo = "", _nome = "", _projeto = "", _revisao = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + todas_os_a_criar[0] + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                byte[] foto = new byte[0];

                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    _cliente = dr["CLIENTE"].ToString();
                    _prazo = dr["DATA_ENTREGA_PECA"].ToString();
                    _nome = dr["NOME_PECA"].ToString();
                    _responsavel = dr["RESPONSAVEL_PECA"].ToString();
                    _projeto = dr["PROJETISTA_PECA"].ToString();
                    _revisao = dr["REVISAO"].ToString();

                    //foto = (byte[])dr["DESENHO_PECA"];
                }

                //Image foto_salva = BytesToImage(foto);

                //SaveJpeg(@"c:\\evolucao\\cronogramas\peca.jpg", foto_salva, 100);
                //foto_salva.Save(@"c:\\evolucao\\cronogramas\peca.jpg");

                if (_prazo != "")
                    _prazo = Convert.ToDateTime(_prazo).ToShortDateString();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }

            //CALCULANDO TAMANHO EM PIXELS DO FLASH
            //PARA CADA 8 LINHAS O TAMANHO É 270
            double n_linhas = Convert.ToDouble(contador);
            n_linhas = n_linhas / 8;
            n_linhas = n_linhas * 270;

            FileInfo d = new FileInfo(@local);
            d.Delete();
            FileInfo t = new FileInfo(@local);
            try
            {
                using (StreamWriter texto = t.CreateText())
                {
                    texto.Write(@"<html xmlns='http://www.w3.org/1999/xhtml'>
<head>
<meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1' />
<title>Cronograma de Desenvolvimento do Ferramental</title>
<link rel='stylesheet' href='../Contents/Style.css' type='text/css' />
<script language='JavaScript' src='FusionCharts.js'></script>
</head>
<body>
<table style='font-family: Arial; border-right: #000000 1pt outset; border-top: #000000 1pt outset; border-left: #000000 1pt outset; border-bottom: #000000 1pt outset;' width='100%' border='1' align='center' cellpadding='3' cellspacing='0' bordercolor='#000000'>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='7' rowspan='6' valign='top' width='16.6%'>
            <span style='font-size: 7pt'><span style='color: #996600; font-family: Verdana'>
    <img src='logo.jpg' style='width: 115px; height: 59px'></span></span></td>
        <td align='center' class='text' colspan='3' style='font-size: 12pt;' valign='top' width='50%' rowspan='6'>
            <span style='font-family: Arial'><strong>ANDAMENTO DAS FERRAMENTAS</strong></span></td>
        <td align='center' class='text' colspan='2' rowspan='6' valign='top' style='font-size: 12pt'>
            <span style='font-size: 7pt'></span></td>
    </tr>
    <tr bordercolor='#000000'>
    </tr>
    <tr bordercolor='#000000'>
    </tr>
    <tr bordercolor='#000000' style='font-size: 12pt'>
    </tr>
    <tr bordercolor='#000000'>
    </tr>
<tr bordercolor='#000000'>
</tr>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='12' rowspan='1' style='height: 26px' valign='top'>
        <div id='chartdiv2' align='center'> 
</div>
<script type='text/javascript'>
var chart = new FusionCharts('todas_os.swf', 'ChartId2', '1000', '337.5');
chart.setDataURL('todas_os.xml');
chart.render('chartdiv2');
</script> 
        </td>
    </tr>
    <tr bordercolor='#000000'>
        <td align='center' class='text' colspan='10' rowspan='1' style='height: 26px' valign='top'>
                    <img src='legenda.jpg' /></td>
        <td align='center' class='text' colspan='2' rowspan='1' style='font-size: 12pt' valign='top'>
            <span style='font-size: 7pt; font-family: Verdana'>Desenvolvido
        por Evolu&#231&#227o Inform&#225tica <br> Telefone: 55 11 2277-3061</span>
        </td>
    </tr>
<tr bordercolor='#000000'> </tr>
</table>
    <br />
    <br />
    <br />
    &nbsp;<div style='text-align: center'>
        &nbsp;</div>
    <br />
    <span style='font-size: 7pt; font-family: Verdana'></span>
</body>
</html>"
);

                }
                t.CopyTo(Path.ChangeExtension(t.FullName, ".htm"), false);
            }
            catch { }
        }
    }
}
