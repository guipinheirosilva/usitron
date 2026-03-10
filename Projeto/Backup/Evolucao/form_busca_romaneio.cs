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
    public partial class form_busca_romaneio : Form
    {
        public string cod_usuario;
        public form_busca_romaneio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarRomaneios();
            preencheTotais();
        }

        private void preencheTotais()
        {
            double totalPeso = 0, totalVolume = 0, totalCubagem = 0, totalCte = 0, totalCarga = 0, totalEntregue = 0;
            for (int i = 0; i < dgvRomaneios.RowCount; i++)
            {
                double peso, volume, cubagem, cte, carga, entregue;
                int idRomaneio;
                idRomaneio = Convert.ToInt32(dgvRomaneios.Rows[i].Cells[0].Value.ToString());
                peso = somaPeso(idRomaneio);
                volume = somaVolume(idRomaneio);
                cubagem = somaCubagem(idRomaneio);
                cte = somaCte(idRomaneio);
                carga = somaCarga(idRomaneio);
                entregue = somaEntregue(idRomaneio);
                dgvRomaneios.Rows[i].Cells["PESO_TOTAL"].Value = peso.ToString("n2");
                dgvRomaneios.Rows[i].Cells["VOLUME_TOTAL"].Value = volume.ToString("n2");
                dgvRomaneios.Rows[i].Cells["CUBAGEM_TOTAL"].Value = cubagem.ToString("n2");
                dgvRomaneios.Rows[i].Cells["VALOR_CTE_TOTAL"].Value = cte.ToString("n2");
                dgvRomaneios.Rows[i].Cells["VALOR_CARGA_TOTAL"].Value = carga.ToString("n2");
                dgvRomaneios.Rows[i].Cells["TOTAL_ENTREGUE"].Value = entregue.ToString("n2");
                totalPeso += peso;
                totalVolume += volume;
                totalCarga += carga;
                totalCte += cte;
                totalCubagem += cubagem;
                totalEntregue += entregue;
            }
            txtTotalCarga.Text = totalCarga.ToString("n2");
            txtTotalCubagem.Text = totalCubagem.ToString("n2");
            txtTotalEntregue.Text = totalEntregue.ToString("n2");
            txtTotalPeso.Text = totalPeso.ToString("n2");
            txtTotalVolume.Text = totalVolume.ToString("n2");
            txtValorCte.Text = totalCte.ToString("n2");
        }

        private double somaEntregue(int idRomaneio)
        {
            double soma = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT SUM(VALOR_CTE_IR) FROM ITENS_ROMANEIO WHERE COD_ROMANEIO_IR = '" + idRomaneio +
                    "' AND (DEVOLVIDO_IR IS NULL OR DEVOLVIDO_IR <> 1) GROUP BY COD_ROMANEIO_IR";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    soma = Convert.ToDouble(dr[0].ToString());
                }
            }
            catch { fbConnection1.Close(); }
            return soma;
        }

        private double somaCarga(int idRomaneio)
        {
            double soma = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT SUM(VALOR_CARGA_IR) FROM ITENS_ROMANEIO WHERE COD_ROMANEIO_IR = '" + idRomaneio +
                    "' GROUP BY COD_ROMANEIO_IR";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    soma = Convert.ToDouble(dr[0].ToString());
                }
            }
            catch { fbConnection1.Close(); }
            return soma;
        }

        private double somaCte(int idRomaneio)
        {
            double soma = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT SUM(VALOR_CTE_IR) FROM ITENS_ROMANEIO WHERE COD_ROMANEIO_IR = '" + idRomaneio +
                    "' GROUP BY COD_ROMANEIO_IR";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    soma = Convert.ToDouble(dr[0].ToString());
                }
            }
            catch { fbConnection1.Close(); }
            return soma;
        }

        private double somaCubagem(int idRomaneio)
        {
            double soma = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT SUM(CUBAGEM_IR) FROM ITENS_ROMANEIO WHERE COD_ROMANEIO_IR = '" + idRomaneio +
                    "' GROUP BY COD_ROMANEIO_IR";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    soma = Convert.ToDouble(dr[0].ToString());
                }
            }
            catch { fbConnection1.Close(); }
            return soma;
        }

        private double somaVolume(int idRomaneio)
        {
            double soma = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT SUM(VOLUMES_IR) FROM ITENS_ROMANEIO WHERE COD_ROMANEIO_IR = '" + idRomaneio +
                    "' GROUP BY COD_ROMANEIO_IR";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    soma = Convert.ToDouble(dr[0].ToString());
                }
            }
            catch { fbConnection1.Close(); }
            return soma;
        }

        private double somaPeso(int idRomaneio)
        {
            double soma = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT SUM(PESO_IR) FROM ITENS_ROMANEIO WHERE COD_ROMANEIO_IR = '" + idRomaneio +
                    "' GROUP BY COD_ROMANEIO_IR";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    soma = Convert.ToDouble(dr[0].ToString());
                }
            }
            catch { fbConnection1.Close(); }
            return soma;
        }
        private void buscarRomaneios()
        {
            try
            {
                string dataIni, dataFim;
                dataIni = dtInicio.Text;
                dataFim = dtFim.Text;
                dsRomaneio.Clear();
                datRomaneio.SelectCommand.CommandText =
                "SELECT * FROM ROMANEIO WHERE DATA_ROMANEIO >= '" + Convert.ToDateTime(dataIni).ToShortDateString().Replace("/", ".") + "' " +
                "AND DATA_ROMANEIO <= '" + Convert.ToDateTime(dataFim).ToShortDateString().Replace("/", ".") + "'" +
                " ORDER BY COD_ROMANEIO";
                datRomaneio.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datRomaneio.SelectCommand.ExecuteNonQuery();
                datRomaneio.Fill(ROMANEIO);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
    }
}