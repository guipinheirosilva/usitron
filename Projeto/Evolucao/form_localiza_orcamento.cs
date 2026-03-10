using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace Evolucao
{
    public partial class form_localiza_orcamento : Form
    {
        public string cod_escolhido;
        public bool selecao_ped;
        public int numero_orcamento;
        public string[] orcamentos_selecionados = new string[500];
        classeMonitoramentoOrcamento monitoramento = new classeMonitoramentoOrcamento();
        public form_localiza_orcamento()
        {
            InitializeComponent();
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOrcamentos.Tables["ORCAMENTOS"].DefaultView.RowFilter = "COD_ORCAMENTO = '" + tb_localiza.Text + "'";
            }
            catch { }
        }

        private void form_localiza_orcamento_Load(object sender, EventArgs e)
        {
            tbAno.Value = DateTime.Now.Year;
            datOrcamentos.Fill(ORCAMENTOS);
            dgvOrcamentos.AutoGenerateColumns = false;
            dgvOrcamentos.DataSource = dsOrcamentos.Tables["ORCAMENTOS"];
            gerar_grafico();
        }

        private void dgvOrcamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cod_escolhido = dgvOrcamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOrcamentos.Tables["ORCAMENTOS"].DefaultView.RowFilter = "CLIENTE_ORCAMENTO LIKE '*" + tb_cliente.Text + "*'";
            }
            catch { }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em implementação");
        }

        private void btnAprovarParcial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em implementação");
        }

        private void btnNaoAprovar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em implementação");
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                ORCAMENTOS.Clear();
                FbCommand cmd = new FbCommand();
                cmd.CommandText = "select * from orcamentos orc " +
                "where orc.data_orcamento >= '" + dtInicial.Value.ToShortDateString().Replace("/", ".") + "' " +
                "and orc.data_orcamento <= '" + dtFinal.Value.ToShortDateString().Replace("/", ".") + "'";
                datOrcamentos.SelectCommand = cmd;
                cmd.Connection = fbConnection1;
                fbConnection1.Open();
                datOrcamentos.Fill(ORCAMENTOS);
                fbConnection1.Close();
                dgvOrcamentos.AutoGenerateColumns = false;
                dgvOrcamentos.DataSource = dsOrcamentos.Tables["ORCAMENTOS"];
                gerar_grafico();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gerar_grafico()
        {
            try
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                var ano = Convert.ToInt32(tbAno.Value);
                monitoramento.BuscarValores(ano);

                double valorMeta = 200000;
                double janOrcado = monitoramento.ValorOrcado[0];
                double fevOrcado = monitoramento.ValorOrcado[1];
                double marOrcado = monitoramento.ValorOrcado[2];
                double abrOrcado = monitoramento.ValorOrcado[3];
                double maiOrcado = monitoramento.ValorOrcado[4];
                double junOrcado = monitoramento.ValorOrcado[5];
                double julOrcado = monitoramento.ValorOrcado[6];
                double agoOrcado = monitoramento.ValorOrcado[7];
                double setOrcado = monitoramento.ValorOrcado[8];
                double outOrcado = monitoramento.ValorOrcado[9];
                double novOrcado = monitoramento.ValorOrcado[10];
                double dezOrcado = monitoramento.ValorOrcado[11];

                double janFechado = monitoramento.ValorFechado[0];
                double fevFechado = monitoramento.ValorFechado[1];
                double marFechado = monitoramento.ValorFechado[2];
                double abrFechado = monitoramento.ValorFechado[3];
                double maiFechado = monitoramento.ValorFechado[4];
                double junFechado = monitoramento.ValorFechado[5];
                double julFechado = monitoramento.ValorFechado[6];
                double agoFechado = monitoramento.ValorFechado[7];
                double setFechado = monitoramento.ValorFechado[8];
                double outFechado = monitoramento.ValorFechado[9];
                double novFechado = monitoramento.ValorFechado[10];
                double dezFechado = monitoramento.ValorFechado[11];

                //try { _jan = Convert.ToDouble(dgvApe.Rows[3].Cells[0].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _fev = Convert.ToDouble(dgvApe.Rows[3].Cells[1].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _mar = Convert.ToDouble(dgvApe.Rows[3].Cells[2].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _abr = Convert.ToDouble(dgvApe.Rows[3].Cells[3].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _mai = Convert.ToDouble(dgvApe.Rows[3].Cells[4].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _jun = Convert.ToDouble(dgvApe.Rows[3].Cells[5].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _jul = Convert.ToDouble(dgvApe.Rows[3].Cells[6].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _ago = Convert.ToDouble(dgvApe.Rows[3].Cells[7].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _set = Convert.ToDouble(dgvApe.Rows[3].Cells[8].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _out = Convert.ToDouble(dgvApe.Rows[3].Cells[9].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _nov = Convert.ToDouble(dgvApe.Rows[3].Cells[10].Value.ToString().Replace("%", "")); }
                //catch { }
                //try { _dez = Convert.ToDouble(dgvApe.Rows[3].Cells[11].Value.ToString().Replace("%", "")); }
                //catch { }


                chart1.Series["Orcado"].Points.AddXY("Jan", janOrcado);
                chart1.Series["Orcado"].Points.AddXY("Fev", fevOrcado);
                chart1.Series["Orcado"].Points.AddXY("Mar", marOrcado);
                chart1.Series["Orcado"].Points.AddXY("Abr", abrOrcado);
                chart1.Series["Orcado"].Points.AddXY("Mai", maiOrcado);
                chart1.Series["Orcado"].Points.AddXY("Jun", junOrcado);
                chart1.Series["Orcado"].Points.AddXY("Jul", julOrcado);
                chart1.Series["Orcado"].Points.AddXY("Ago", agoOrcado);
                chart1.Series["Orcado"].Points.AddXY("Set", setOrcado);
                chart1.Series["Orcado"].Points.AddXY("Out", outOrcado);
                chart1.Series["Orcado"].Points.AddXY("Nov", novOrcado);
                chart1.Series["Orcado"].Points.AddXY("Dez", dezOrcado);

                chart1.Series["Fechado"].Points.AddXY("Jan", janFechado);
                chart1.Series["Fechado"].Points.AddXY("Fev", fevFechado);
                chart1.Series["Fechado"].Points.AddXY("Mar", marFechado);
                chart1.Series["Fechado"].Points.AddXY("Abr", abrFechado);
                chart1.Series["Fechado"].Points.AddXY("Mai", maiFechado);
                chart1.Series["Fechado"].Points.AddXY("Jun", junFechado);
                chart1.Series["Fechado"].Points.AddXY("Jul", julFechado);
                chart1.Series["Fechado"].Points.AddXY("Ago", agoFechado);
                chart1.Series["Fechado"].Points.AddXY("Set", setFechado);
                chart1.Series["Fechado"].Points.AddXY("Out", outFechado);
                chart1.Series["Fechado"].Points.AddXY("Nov", novFechado);
                chart1.Series["Fechado"].Points.AddXY("Dez", dezFechado);

                chart1.ChartAreas[0].AxisY.Maximum =
                buscarMaiorOrcamento(monitoramento.ValorOrcado, monitoramento.ValorFechado, valorMeta);
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.IntervalOffset = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                StripLine meta = new StripLine();
                meta.Interval = 0;
                meta.IntervalOffset = valorMeta;
                meta.Text = "Meta R$" + valorMeta;
                meta.BorderColor = Color.Red;
                meta.BorderWidth = 3;
                chart1.ChartAreas[0].AxisY.StripLines.Add(meta);

                if (!Directory.Exists("c:\\evolucao\\Temp"))
                {
                    Directory.CreateDirectory("c:\\evolucao\\Temp");
                }

                File.Delete("c:\\evolucao\\Temp\\temp.png");
                try
                {
                    chart1.SaveImage("c:\\evolucao\\Temp\\temp.png", ChartImageFormat.Png);
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private double buscarMaiorOrcamento(List<double> valorOrcado, List<double> valorFechado, double meta)
        {
            try
            {
                int margin = 100;
                List<double> valores = new List<double>();
                valores.Add(valorOrcado.Max());
                valores.Add(valorFechado.Max());
                valores.Add(meta);
                return valores.Max() + margin;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ano = Convert.ToInt32(tbAno.Value);

            dsMonitoramentoOrc ds = new dsMonitoramentoOrc();
            monitoramento.BuscarQtdeOrcadas(ano);
            monitoramento.BuscarQtdeFechados(ano);


            ds.ORCADOS.AddORCADOSRow(monitoramento.QtdeOrcado[0], monitoramento.QtdeOrcado[1], monitoramento.QtdeOrcado[2], monitoramento.QtdeOrcado[3], monitoramento.QtdeOrcado[4], monitoramento.QtdeOrcado[5], monitoramento.QtdeOrcado[6], monitoramento.QtdeOrcado[7], monitoramento.QtdeOrcado[8], monitoramento.QtdeOrcado[9], monitoramento.QtdeOrcado[10], monitoramento.QtdeOrcado[11],
            monitoramento.ValorOrcado[0], monitoramento.ValorOrcado[1], monitoramento.ValorOrcado[2], monitoramento.ValorOrcado[3], monitoramento.ValorOrcado[4], monitoramento.ValorOrcado[5], monitoramento.ValorOrcado[6], monitoramento.ValorOrcado[7], monitoramento.ValorOrcado[8], monitoramento.ValorOrcado[9], monitoramento.ValorOrcado[10], monitoramento.ValorOrcado[11]);
            ds.FECHADOS.AddFECHADOSRow(monitoramento.QtdeFechado[0], monitoramento.QtdeFechado[1], monitoramento.QtdeFechado[2], monitoramento.QtdeFechado[3], monitoramento.QtdeFechado[4], monitoramento.QtdeFechado[5], monitoramento.QtdeFechado[6], monitoramento.QtdeFechado[7], monitoramento.QtdeFechado[8], monitoramento.QtdeFechado[9], monitoramento.QtdeFechado[10], monitoramento.QtdeFechado[11],
            monitoramento.ValorFechado[0], monitoramento.ValorFechado[1], monitoramento.ValorFechado[2], monitoramento.ValorFechado[3], monitoramento.ValorFechado[4], monitoramento.ValorFechado[5], monitoramento.ValorFechado[6], monitoramento.ValorFechado[7], monitoramento.ValorFechado[8], monitoramento.ValorFechado[9], monitoramento.ValorFechado[10], monitoramento.ValorFechado[11], 1,1,1,1,1,1,1,1,1,1,1,1);
            ds.META.AddMETARow(0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);
            crMonitoramentoOrcamento cr = new crMonitoramentoOrcamento();
            cr.SetDataSource(ds);
            form_imprimir imp = new form_imprimir(cr);
            imp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dsOrcamentos.Tables["ORCAMENTOS"].DefaultView.RowFilter = "VENDAS_ORCAMENTO = 1";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dsOrcamentos.Tables["ORCAMENTOS"].DefaultView.RowFilter = "BENEFICIAMENTO_ORCAMENTO = 1";
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //dsOrcamentos.Clear();
                //datOrcamentos.Fill(ORCAMENTOS);
                //dgvOrcamentos.AutoGenerateColumns = false;
                //dgvOrcamentos.DataSource = dsOrcamentos.Tables["ORCAMENTOS"];
                tb_localiza.Text = "";
                tb_cliente.Text = "";
                dsOrcamentos.Tables["ORCAMENTOS"].DefaultView.RowFilter = "";
            }
            catch { }
        }
    }
}