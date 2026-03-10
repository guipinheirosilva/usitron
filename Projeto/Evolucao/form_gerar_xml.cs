using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace Evolucao
{
    public partial class form_gerar_xml : Form
    {
        string dataGerado = "";
        string data, _cnpj_emitente;
        string empresa;
        int tipo;
        public form_gerar_xml(string data, string cnpj, int tipo)
        {
            InitializeComponent();
            this.data = data;
            if (tipo == 0)
            {
                this._cnpj_emitente = cnpj;
                if (_cnpj_emitente == "43500198000185")
                {
                    empresa = "Matriz";
                }
                else if (_cnpj_emitente == "43500198000347")
                {
                    empresa = "Filial";
                }
                else if (_cnpj_emitente == "06112790000183")
                {
                    empresa = "Livia";
                }
            }
            this.tipo = tipo;
            dataGerado = DateTime.Now.ToShortDateString().Replace("/", "");
            dataGerado = dataGerado + "\\";
            if (tipo == 0)
            {
                criarPastas(empresa);
            }
            else if (tipo == 1)
            {
                criarPastasEmpresa(cnpj);
            }
        }

        private void criarPastasEmpresa(string cnpj)
        {
            string caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\AUT\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\CANC\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\INUT\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\LOG\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
        }
        private void salvar_na_pasta(string cte, string caminho)
        {
            try
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(cte);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
        private void PrintAllErrs(DataSet dataSet)
        {
            DataRow[] rowsInError;

            foreach (DataTable table in dataSet.Tables)
            {
                // Test if the table has errors. If not, skip it. 
                if (table.HasErrors)
                {
                    // Get an array of all rows with errors.
                    rowsInError = table.GetErrors();
                    // Print the error of each column in each row. 
                    for (int i = 0; i < rowsInError.Length; i++)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.WriteLine(column.ColumnName + " " +
                                rowsInError[i].GetColumnError(column));
                        }
                        // Clear the row errors
                        rowsInError[i].ClearErrors();
                    }
                }
            }
        }
        public Boolean criar_arquivo_xml_aut(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\AUT\\" + Name);
                Arquivo.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Boolean criar_arquivo_xml_canc(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\CANC\\" + Name);
                Arquivo.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Boolean criar_arquivo_xml_inut(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\INUT\\" + Name);
                Arquivo.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Boolean criar_arquivo_xml_autEmpresa(String Name, string cnpj)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\AUT\\" + Name);
                Arquivo.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Boolean criar_arquivo_xml_cancEmpresa(String Name, string cnpj)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\CANC\\" + Name);
                Arquivo.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Boolean criar_arquivo_xml_inutEmpresa(String Name, string cnpj)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\INUT\\" + Name);
                Arquivo.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void gerarXml(bool gerar)
        {
            string primeiro = "", ultimo = "", cteCnpj = "", log = "";
            bool enviarEmail = true;
            FbCommand seleciona = new FbCommand();
            seleciona.CommandText =
                "SELECT FIRST (1) N_CTE FROM CTE " + data + " AND EMITENTE_CNPJ_CTE LIKE '" + _cnpj_emitente + "' ORDER BY N_CTE";
            seleciona.Connection = fbConnection1;
            fbConnection1.Open();
            FbDataAdapter datTabela = new FbDataAdapter();
            DataSet dsTabela = new DataSet();
            datTabela.SelectCommand = seleciona;
            datTabela.Fill(dsTabela);
            fbConnection1.Close(); 
            foreach (DataRow dr in dsTabela.Tables[0].Rows)
            {
                primeiro = dr[0].ToString();
            }
            seleciona.CommandText =
                "SELECT FIRST (1) N_CTE FROM CTE " + data + " AND EMITENTE_CNPJ_CTE LIKE '" + _cnpj_emitente + "' ORDER BY N_CTE DESC";
            seleciona.Connection = fbConnection1;
            fbConnection1.Open();
            datTabela = new FbDataAdapter();
            dsTabela = new DataSet();
            datTabela.SelectCommand = seleciona;
            datTabela.Fill(dsTabela);
            fbConnection1.Close(); 
            foreach (DataRow dr in dsTabela.Tables[0].Rows)
            {
                ultimo = dr[0].ToString();
            }
            int tamanho = (Convert.ToInt32(ultimo) - Convert.ToInt32(primeiro));
            progressBar1.Maximum = tamanho+1;
            for (int i = Convert.ToInt32(primeiro); i <= Convert.ToInt32(ultimo); i++)
            {
                cteCnpj = i.ToString() + _cnpj_emitente;
                string emitidoPor = "", cte = "", emitente = "", status = "", aut = "", canc = "", inut = "", xmlAut = "", xmlCanc = "", xmlInut = "", dataEmissao = "";
                string obs = "";
                double valor = 0;
                try
                {
                    cte = i.ToString();
                    emitente = _cnpj_emitente;
                    FbCommand comando = new FbCommand();
                    comando.Connection = fbConnection1;
                    comando.CommandText =
                        "SELECT N_CTE, EMITENTE_CNPJ_CTE, STATUS_CTE, CHAVE_ACESSO_CTE, VALOR_TOTAL_CTE, XML_AUTORIZADO, XML_CANCELADO, XML_INUTILIZADO, DATA_EMISSAO_CTE, EMITIDO_POR_CTE FROM CTE WHERE CTE_CNPJ = '" + cteCnpj + "'";
                    fbConnection1.Open();
                    FbDataReader reader = comando.ExecuteReader();
                    string texto = "";
                    while (reader.Read())
                    {

                        try
                        {
                            valor = reader.GetDouble(4);
                        }
                        catch { }
                        emitidoPor = reader.GetString(9);
                        status = reader.GetString(2);
                        dataEmissao = reader.GetDateTime(8).ToShortDateString();
                        //AUTORIZADO
                        texto = reader[5].ToString();
                        if (texto != "")
                        {
                            if (gerar)
                            {
                                string nome_arquivo;
                                if (reader.GetString(3) == "")
                                {
                                    nome_arquivo = "CTE" + reader.GetString(0) + ".xml";
                                }
                                else
                                {
                                    nome_arquivo = "CTE" + reader.GetString(3) + ".xml";
                                }
                                criar_arquivo_xml_aut(nome_arquivo);
                                string caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\AUT\\";
                                salvar_na_pasta(texto, caminho + nome_arquivo);
                            }
                            xmlAut = "s";
                        }
                        else
                        {
                            xmlAut = "n";
                        }
                        //CANCELADO
                        texto = "";
                        texto = reader[6].ToString();
                        if (texto != "")
                        {
                            if (gerar)
                            {
                                string nome_arquivo;
                                if (reader.GetString(3) == "")
                                {
                                    nome_arquivo = "CTE" + reader.GetString(0) + ".xml";
                                }
                                else
                                {
                                    nome_arquivo = "CTE" + reader.GetString(3) + ".xml";
                                }
                                criar_arquivo_xml_canc(nome_arquivo);
                                string caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\CANC\\";
                                salvar_na_pasta(texto, caminho + nome_arquivo);
                            }
                            xmlCanc = "s";
                        }
                        else
                        {
                            xmlCanc = "n";
                        }
                        //INUTILIZADO
                        texto = "";
                        texto = reader[7].ToString();
                        if (texto != "")
                        {
                            if (gerar)
                            {
                                string nome_arquivo;
                                if (reader.GetString(3) == "")
                                {
                                    nome_arquivo = "CTE" + reader.GetString(0) + ".xml";
                                }
                                else
                                {
                                    nome_arquivo = "CTE" + reader.GetString(3) + ".xml";
                                }
                                criar_arquivo_xml_inut(nome_arquivo);
                                string caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\INUT\\";
                                salvar_na_pasta(texto, caminho + nome_arquivo);
                            }
                            xmlInut = "s";
                        }
                        else
                        {
                            xmlInut = "n";
                        }
                        if (status.Contains("Autorizada"))
                        {
                            if (xmlAut == "n")
                            {
                                obs += "XML Autorizado não encontrado";
                            }
                            if (xmlCanc == "s")
                            {
                                obs += "Status divergente. CTE Cancelado, conferir SEFAZ";
                            }
                            if (xmlInut == "s")
                            {
                                obs += "Status divergente. CTE Inutilizado, conferir SEFAZ";
                            }
                        }
                        else if (status.Contains("Cancelada"))
                        {
                            if (xmlAut == "n")
                            {
                                obs += "XML Autorizado não encontrado";
                            }
                            if (xmlCanc == "n")
                            {
                                obs += "XML Cancelado não encontrado";
                            }
                            if (xmlInut == "s")
                            {
                                obs += "Status divergente. CTE Inutilizado, conferir SEFAZ";
                            }
                        }
                        else if (status.Contains("Inutilizada"))
                        {
                            if (xmlAut == "s")
                            {
                                obs = "Status divergente. CTE Autorizado, conferir SEFAZ";
                            }
                            if (xmlCanc == "s")
                            {
                                obs = "Status divergente. CTE Cancelado, conferir SEFAZ";
                            }
                            if (xmlInut == "n")
                            {
                                obs = "XML Inutilizado não encontrado";
                            }
                        }
                        else
                        {
                            if (xmlAut == "s")
                            {
                                obs = "Status divergente. CTE Autorizado, conferir SEFAZ";
                            }
                            if (xmlCanc == "s")
                            {
                                obs = "Status divergente. CTE Cancelado, conferir SEFAZ";
                            }
                            if (xmlInut == "n")
                            {
                                obs = "Inutilize o CTE";
                            }
                        }
                        if (obs != "")
                        {
                            enviarEmail = false;
                        }
                    }
                    log += cte + ";" + emitente + ";" + emitidoPor + ";" + status + ";" + valor.ToString() + ";" + xmlAut + ";" + xmlCanc + ";" + xmlInut + ";" + dataEmissao + ";" + obs + ";\r\n";
                    fbConnection1.Close(); 
                }
                catch
                {
                    PrintAllErrs(dsCte);
                    fbConnection1.Close(); 
                }
                progressBar1.Value++;
                progressBar1.Update();
                Application.DoEvents();
            }
            criarLog(log);
            MessageBox.Show("Concluído");
            this.Dispose();
        }

        private void criarLog(string log)
        {
            string data = DateTime.Now.ToShortDateString().Replace("/", "");
            string caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\LOG\\" + empresa + data + ".csv";
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\LOG\\" + empresa + data + ".csv");
                Arquivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            salvar_na_pasta(log, caminho);
        }
        private void criarLogEmpresa(string log, string cnpj)
        {
            string data = DateTime.Now.ToShortDateString().Replace("/", "");
            string caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\LOG\\" + cnpj + data + ".csv";
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(@"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\LOG\\" + cnpj + data + ".csv");
                Arquivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            salvar_na_pasta(log, caminho);
        }
        private void form_gerar_xml_Load(object sender, EventArgs e)
        {
            
        }
        private void criarPastas(string empresa)
        {
            string caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\AUT\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\CANC\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\INUT\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            caminho = @"c:\\evolucao\\XMLGERADOS\TODOS\" + dataGerado + empresa + "\\LOG\\";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
        }
        public void gerarPorCliente(string cnpj)
        {
            bool gerar = true;
            string log = "", nCte = "", cnpjEmitente = "", cteCnpj = "";
            FbCommand seleciona = new FbCommand();
            seleciona.CommandText =
                "SELECT N_CTE, EMITENTE_CNPJ_CTE FROM CTE WHERE TOMADOR_CNPJ_CTE = '" + cnpj + "'" + data;
            seleciona.Connection = fbConnection1;
            fbConnection1.Open();
            FbDataAdapter datTabela = new FbDataAdapter();
            DataSet dsTabela = new DataSet();
            datTabela.SelectCommand = seleciona;
            datTabela.Fill(dsTabela);
            fbConnection1.Close(); 
            foreach (DataRow dr in dsTabela.Tables[0].Rows)
            {
                //int tamanho = (Convert.ToInt32(ultimo) - Convert.ToInt32(primeiro));
                //progressBar1.Maximum = tamanho + 1;

                nCte = dr[0].ToString();
                cnpjEmitente = dr[1].ToString();
                cteCnpj = nCte + cnpjEmitente;
                string emitidoPor = "", cte = "", emitente = "", status = "", aut = "", canc = "", inut = "", xmlAut = "", xmlCanc = "", xmlInut = "", dataEmissao = "";
                string obs = "";
                double valor = 0;
                try
                {
                    FbCommand comando = new FbCommand();
                    comando.Connection = fbConnection1;
                    comando.CommandText =
                        "SELECT N_CTE, EMITENTE_CNPJ_CTE, STATUS_CTE, CHAVE_ACESSO_CTE, VALOR_TOTAL_CTE, XML_AUTORIZADO, XML_CANCELADO, XML_INUTILIZADO," +
                        "DATA_EMISSAO_CTE, EMITIDO_POR_CTE FROM CTE WHERE N_CTE = '" + nCte + "' AND EMITENTE_CNPJ_CTE = '" + cnpjEmitente + "'";
                    fbConnection1.Open();
                    FbDataReader reader = comando.ExecuteReader();
                    string texto = "";
                    while (reader.Read())
                    {

                        try
                        {
                            valor = reader.GetDouble(4);
                        }
                        catch { }
                        emitidoPor = reader.GetString(9);
                        status = reader.GetString(2);
                        dataEmissao = reader.GetDateTime(8).ToShortDateString();
                        //AUTORIZADO
                        texto = reader[5].ToString();
                        if (texto != "")
                        {
                            if (gerar)
                            {
                                string nome_arquivo;
                                if (reader.GetString(3) == "")
                                {
                                    nome_arquivo = "CTE" + reader.GetString(0) + ".xml";
                                }
                                else
                                {
                                    nome_arquivo = "CTE" + reader.GetString(3) + ".xml";
                                }
                                criar_arquivo_xml_autEmpresa(nome_arquivo, cnpj);
                                string caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\AUT\\";
                                salvar_na_pasta(texto, caminho + nome_arquivo);
                            }
                            xmlAut = "s";
                        }
                        else
                        {
                            xmlAut = "n";
                        }
                        //CANCELADO
                        texto = "";
                        texto = reader[6].ToString();
                        if (texto != "")
                        {
                            if (gerar)
                            {
                                string nome_arquivo;
                                if (reader.GetString(3) == "")
                                {
                                    nome_arquivo = "CTE" + reader.GetString(0) + ".xml";
                                }
                                else
                                {
                                    nome_arquivo = "CTE" + reader.GetString(3) + ".xml";
                                }
                                criar_arquivo_xml_cancEmpresa(nome_arquivo, cnpj);
                                string caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\CANC\\";
                                salvar_na_pasta(texto, caminho + nome_arquivo);
                            }
                            xmlCanc = "s";
                        }
                        else
                        {
                            xmlCanc = "n";
                        }
                        //INUTILIZADO
                        texto = "";
                        texto = reader[7].ToString();
                        if (texto != "")
                        {
                            if (gerar)
                            {
                                string nome_arquivo;
                                if (reader.GetString(3) == "")
                                {
                                    nome_arquivo = "CTE" + reader.GetString(0) + ".xml";
                                }
                                else
                                {
                                    nome_arquivo = "CTE" + reader.GetString(3) + ".xml";
                                }
                                criar_arquivo_xml_inutEmpresa(nome_arquivo, cnpj);
                                string caminho = @"c:\\evolucao\\XMLGERADOS\EMPRESAS\" + dataGerado + cnpj + "\\INUT\\";
                                salvar_na_pasta(texto, caminho + nome_arquivo);
                            }
                            xmlInut = "s";
                        }
                        else
                        {
                            xmlInut = "n";
                        }
                        if (status.Contains("Autorizada"))
                        {
                            if (xmlAut == "n")
                            {
                                obs += "XML Autorizado não encontrado";
                            }
                            if (xmlCanc == "s")
                            {
                                obs += "Status divergente. CTE Cancelado, conferir SEFAZ";
                            }
                            if (xmlInut == "s")
                            {
                                obs += "Status divergente. CTE Inutilizado, conferir SEFAZ";
                            }
                        }
                        else if (status.Contains("Cancelada"))
                        {
                            if (xmlAut == "n")
                            {
                                obs += "XML Autorizado não encontrado";
                            }
                            if (xmlCanc == "n")
                            {
                                obs += "XML Cancelado não encontrado";
                            }
                            if (xmlInut == "s")
                            {
                                obs += "Status divergente. CTE Inutilizado, conferir SEFAZ";
                            }
                        }
                        else if (status.Contains("Inutilizada"))
                        {
                            if (xmlAut == "s")
                            {
                                obs = "Status divergente. CTE Autorizado, conferir SEFAZ";
                            }
                            if (xmlCanc == "s")
                            {
                                obs = "Status divergente. CTE Cancelado, conferir SEFAZ";
                            }
                            if (xmlInut == "n")
                            {
                                obs = "XML Inutilizado não encontrado";
                            }
                        }
                        else
                        {
                            if (xmlAut == "s")
                            {
                                obs = "Status divergente. CTE Autorizado, conferir SEFAZ";
                            }
                            if (xmlCanc == "s")
                            {
                                obs = "Status divergente. CTE Cancelado, conferir SEFAZ";
                            }
                            if (xmlInut == "n")
                            {
                                obs = "Inutilize o CTE";
                            }
                        }
                        if (obs != "")
                        {
                            //enviarEmail = false;
                        }
                    }
                    log += nCte + ";" + cnpjEmitente + ";" + emitidoPor + ";" + status + ";" + valor.ToString() + ";" + xmlAut + ";" + xmlCanc + ";" + xmlInut + ";" + dataEmissao + ";" + obs + ";\r\n";
                    fbConnection1.Close(); 
                }
                catch
                {
                    PrintAllErrs(dsCte);
                    fbConnection1.Close(); 
                }
                progressBar1.Value++;
                progressBar1.Update();
                Application.DoEvents();
            }
            criarLogEmpresa(log,cnpj);
            MessageBox.Show("Concluído");
            this.Dispose();
        }
    }
}