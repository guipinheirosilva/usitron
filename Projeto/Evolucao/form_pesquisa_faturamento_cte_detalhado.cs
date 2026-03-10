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
    public partial class form_pesquisa_faturamento_cte_detalhado : Form
    {
        public form_pesquisa_faturamento_cte_detalhado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //buscando composição de preços envolvidas
                string data = "";
                string cnpj_tomador = "";
                string status = "";
                string nf = "", nf2 = "";
                if (cbData.Checked)
                    data = " AND cte.DATA_EMISSAO_CTE >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        " cte.DATA_EMISSAO_CTE <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                if (cbTomador.Checked)
                    cnpj_tomador = " AND cte.TOMADOR_CNPJ_CTE = '" + tb_tomador_cnpj.Text + "' ";
                if (cbStatus.Checked)
                    status = " AND cte.STATUS_CTE = '" + comboStatus.Text + "' ";


                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT DISTINCT(cfc.DESCRICAO_CFC) FROM CTE_FRETE_COMPOSICAO cfc " +
                    "INNER JOIN CTE cte ON cfc.COD_CTE_CFC = cte.COD_CTE WHERE 0 = 0 " + data + cnpj_tomador + status + " ORDER BY cfc.DESCRICAO_CFC";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                fbConnection1.Open();
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close(); 
                string somatorios = "";
                int i = 0;
                foreach (DataRow dr in dtSelect.Rows)
                {
                   // if (i == 0)
                    //{
                   //     somatorios = " (SELECT SUM(VALOR_CFC) FROM CTE_FRETE_COMPOSICAO WHERE COD_CTE_CFC = cte.COD_CTE AND DESCRICAO_CFC = '" +
                   //         dr[0].ToString() + "') ALIAS '" + dr[0].ToString() + "' ";
                   // }
                   //else
                   // {
                        somatorios = somatorios + ", (SELECT SUM(VALOR_CFC) FROM CTE_FRETE_COMPOSICAO WHERE COD_CTE_CFC = cte.COD_CTE AND DESCRICAO_CFC = '" +
                            dr[0].ToString().Replace("|", "") + "') AS \"" + dr[0].ToString().Replace("|", "") + "\"";
                   // }
                    i++;
                }

                select.CommandText =
                    "SELECT COD_CTE, N_CTE AS N, DATA_EMISSAO_CTE AS Data, DESTINATARIO_NOME_CTE AS Destinatario, VALOR_MERCADO_CTE AS Valor_Mercado,  " +
                    "QTDE_VOLUMES_CTE as Qtde, PESO_CTE AS Peso " + somatorios + ", VALOR_TOTAL_CTE AS Valor_Total FROM CTE  " +
                    "WHERE 0 = 0 " + data + cnpj_tomador + status + " ORDER BY cte.N_CTE";
                datSelect.SelectCommand = select;
                fbConnection1.Open();
                DataTable dtSelect_cte = new DataTable();
                datSelect.Fill(dtSelect_cte);
                fbConnection1.Close(); 
                DataRow linha = dtSelect_cte.NewRow();
                //dtSelect_cte.Rows.Add(linha);
                dtSelect_cte.Rows.Add(linha);
                dgvDados.DataSource = dtSelect_cte;
                //for (int j = 0; j < dgvDados.ColumnCount; j++)
                  //  dgvDados.Rows[dgvDados.RowCount].Cells[j].Value = "";

                acertar_data_grid_view(dtSelect);
                dgvDados.Columns[0].Visible = false;


            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void acertar_data_grid_view(DataTable dtSelect)
        {
            for (int j = 4; j < dgvDados.ColumnCount; j++)
            {
                try
                {
                    double soma = 0;
                    for (int i = 0; i < dgvDados.RowCount - 1; i++)
                    {
                        try
                        {
                            soma = soma + Convert.ToDouble(dgvDados.Rows[i].Cells[j].Value.ToString());
                        }
                        catch { }
                    }

                    dgvDados.Rows[dgvDados.RowCount - 1].Cells[j].Value = soma.ToString();
                }
                catch { }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(true, "");
            try
            {
                cli.ShowDialog();
            }
            finally
            {
                tb_tomador_nome.Text = cli.cliente_escolhido;
                tb_tomador_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dsPesquisa_cte imprimir = new dsPesquisa_cte();

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string cnpjEmpresa = "", nCte = "", empresaEmissora = "";
            try
            {
                string codCte = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT N_CTE, EMITENTE_CNPJ_CTE, EMITENTE_NOME_CTE FROM CTE WHERE COD_CTE = '" + codCte + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    nCte = dr[0].ToString();
                    cnpjEmpresa = dr[1].ToString();
                    empresaEmissora = dr[2].ToString();
                }

                form_cte cte = new form_cte();
                cte.n_cte = nCte;
                cte.cnpj_empresa_emissora = cnpjEmpresa;
                cte.empresa_emissora = empresaEmissora;
                cte.desabilita = true;
                cte.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
                fbConnection1.Close(); 
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string codCte = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
                try
                {
                    dsCte_notas_fiscais.Clear();
                    datCte_notas_fiscais.SelectCommand.CommandText =
                    "SELECT * FROM CTE_NOTAS_FISCAIS WHERE COD_CTE_CNF = '" + codCte + "'";
                    datCte_notas_fiscais.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datCte_notas_fiscais.SelectCommand.ExecuteNonQuery();
                    datCte_notas_fiscais.Fill(CTE_NOTAS_FISCAIS);
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
}