using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public class classeMonitoramentoOrcamento
    {
        FbConnection fbConnection1 = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0");
        public List<double> ValorOrcado = new List<double>();
        public List<double> ValorFechado = new List<double>();
        public List<double> Meta = new List<double>();
        public List<double> QtdeOrcado = new List<double>();
        public List<double> QtdeFechado = new List<double>();

        public void BuscarValores(int ano)
        {
            try
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    FbCommand cmd = new FbCommand();
                    FbDataAdapter datCmd = new FbDataAdapter();
                    DataTable dtCmd = new DataTable();
                    cmd.CommandText = "select sum(o.total_geral_orcamento), " +
                    "sum(o.total_fechado_orcamento) from orcamentos o " +
                    "where o.data_orcamento >= '01." + mes + "." + ano + "' " +
                    "and o.data_orcamento < '01." + (mes + 1) + "." + ano + "'";
                    cmd.Connection = fbConnection1;
                    datCmd.SelectCommand = cmd;
                    fbConnection1.Open();
                    datCmd.Fill(dtCmd);
                    foreach (DataRow dr in dtCmd.Rows)
                    {
                        double orcado = 0;
                        Double.TryParse(dr[0].ToString(), out orcado);
                        ValorOrcado.Add(orcado);

                        double fechado = 0;
                        Double.TryParse(dr[1].ToString(), out fechado);
                        ValorFechado.Add(fechado);

                    }
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void BuscarQtdeOrcadas(int ano)
        {
            try
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    FbCommand cmd = new FbCommand();
                    FbDataAdapter datCmd = new FbDataAdapter();
                    DataTable dtCmd = new DataTable();
                    cmd.CommandText = "select COUNT(*) from orcamentos o " +
                    "where o.data_orcamento >= '01." + mes + "." + ano + "' " +
                    "and o.data_orcamento < '01." + (mes + 1) + "." + ano + "'";
                    cmd.Connection = fbConnection1;
                    datCmd.SelectCommand = cmd;
                    fbConnection1.Open();
                    datCmd.Fill(dtCmd);
                    foreach (DataRow dr in dtCmd.Rows)
                    {
                        double qtde = 0;
                        Double.TryParse(dr[0].ToString(), out qtde);
                        QtdeOrcado.Add(qtde);
                    }
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void BuscarQtdeFechados(int ano)
        {
            try
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    FbCommand cmd = new FbCommand();
                    FbDataAdapter datCmd = new FbDataAdapter();
                    DataTable dtCmd = new DataTable();
                    cmd.CommandText = "select COUNT(*) from orcamentos o " +
                    "where (o.status_orcamento like 'Aprovado Total' or o.status_orcamento like 'Aprovado Parcial') " +
                    "and o.data_orcamento >= '01." + mes + "." + ano + "' " +
                    "and o.data_orcamento < '01." + (mes + 1) + "." + ano + "'";
                    cmd.Connection = fbConnection1;
                    datCmd.SelectCommand = cmd;
                    fbConnection1.Open();
                    datCmd.Fill(dtCmd);
                    foreach (DataRow dr in dtCmd.Rows)
                    {
                        double qtde = 0;
                        Double.TryParse(dr[0].ToString(), out qtde);
                        QtdeFechado.Add(qtde);
                    }
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void BuscarPorcFechados(int ano)
        {
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    double orcados = 0, fechados = 0, porcFechados = 0;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
