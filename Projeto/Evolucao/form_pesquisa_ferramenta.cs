using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_ferramenta : Form
    {
        public string ferramenta_escolhida;
        public string item_escolhido;
        public form_pesquisa_ferramenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisa_ferramenta(tb_ferramenta.Text, tb_item.Text);
        }

        private void pesquisa_ferramenta(string ferramenta, string item)
        {
            dsOp.Clear();
            dsItens_orcamento.Clear();
            dsRotas_campo.Clear();

            if (item != "" && item != null)
            {
                try
                {
                    dgvItens_orcamento.AutoGenerateColumns = false;
                    dgvItens_orcamento.DataSource = dsItens_orcamento.Tables["ITENS_ORCAMENTO"];
                    this.datItens_orcamento.SelectCommand.CommandText =
                           "SELECT * FROM ITENS_ORCAMENTO WHERE NOME_ITEM_ORC = '" + ferramenta + "-" + item + "'";
                    this.fbConnection1.Open();
                    this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                    this.datItens_orcamento.SelectCommand.ExecuteNonQuery();
                    datItens_orcamento.Fill(ITENS_ORCAMENTO);
                    this.fbConnection1.Close();
                }
                catch { fbConnection1.Close(); }
                try
                {
                    dgvPosicoes.AutoGenerateColumns = false;
                    dgvPosicoes.DataSource = dsOp.Tables["OP"];
                    this.datOp.SelectCommand.CommandText =
                    "SELECT * FROM OP WHERE FERRAMENTA_OP LIKE '%" + ferramenta + "%' AND COND_PGTO = '" + item + "'";
                    this.fbConnection1.Open();
                    this.datOp.SelectCommand.Connection = fbConnection1;
                    this.datOp.SelectCommand.ExecuteNonQuery();
                    datOp.Fill(OP);
                    this.fbConnection1.Close();
                }
                catch { fbConnection1.Close(); }
            }
            else
            {
                try
                {
                    dgvItens_orcamento.AutoGenerateColumns = false;
                    dgvItens_orcamento.DataSource = dsItens_orcamento.Tables["ITENS_ORCAMENTO"];
                    this.datItens_orcamento.SelectCommand.CommandText =
                           "SELECT * FROM ITENS_ORCAMENTO WHERE NOME_ITEM_ORC = '" + ferramenta + "'";
                    this.fbConnection1.Open();
                    this.datItens_orcamento.SelectCommand.Connection = fbConnection1;
                    this.datItens_orcamento.SelectCommand.ExecuteNonQuery();
                    datItens_orcamento.Fill(ITENS_ORCAMENTO);
                    this.fbConnection1.Close();
                }
                catch { fbConnection1.Close(); }

                try
                {
                    dgvPosicoes.AutoGenerateColumns = false;
                    dgvPosicoes.DataSource = dsOp.Tables["OP"];
                    this.datOp.SelectCommand.CommandText =
                    "SELECT * FROM OP WHERE COND_PGTO like '%" + ferramenta + "%'";
                    this.fbConnection1.Open();
                    this.datOp.SelectCommand.Connection = fbConnection1;
                    this.datOp.SelectCommand.ExecuteNonQuery();
                    datOp.Fill(OP);
                    this.fbConnection1.Close();
                }
                catch { fbConnection1.Close(); }
            }

        }

      
        private void seleciona_pos(string _cod_os)
        {
            try
            {
                dsRotas_campo.Clear();
                dgvRotas_campo.AutoGenerateColumns = false;
                dgvRotas_campo.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
                this.datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + _cod_os + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
               // "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + _cod_os + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
                this.fbConnection1.Open();
                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();
                double horas_prev = 0;
                double horas_trab = 0;
                for (int i = 0; i < dgvRotas_campo.RowCount; i++)
                {
                    try
                    {
                        horas_prev = horas_prev + Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value);
                    }
                    catch { }
                    try
                    {
                        horas_trab = horas_trab + Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value);
                    }
                    catch { }
                }
                tb_horas_previstas.Text = horas_prev.ToString("n2");
                tb_horas_trabalhadas.Text = horas_trab.ToString("n2");
            }
            catch { fbConnection1.Close(); }

        }

        private void dgvPosicoes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvRotas_campo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            try
            {
                abre_rota.rota_atual = dgvRotas_campo.Rows[e.RowIndex].Cells["col_cod"].Value;
                abre_rota.ShowDialog();
            }
            finally
            {
                abre_rota.Dispose();
                datRotas_campo.Fill(ROTAS_CAMPO);
            }
        }

        private void form_pesquisa_ferramenta_Load(object sender, EventArgs e)
        {
            if (ferramenta_escolhida != null)
            {
                tb_ferramenta.Text = ferramenta_escolhida;
                tb_item.Text = item_escolhido;
                pesquisa_ferramenta(ferramenta_escolhida, item_escolhido);
            }

        }

        private void dgvItens_orcamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* form_orcamentos orc = new form_orcamentos();
            try
            {
                orc.cod_a_abrir = dgvItens_orcamento.Rows[e.RowIndex].Cells["col_orc"].Value.ToString();
                orc.ShowDialog();
            }
            finally
            {
                orc.Dispose();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form_pesquisa_peca peca = new form_pesquisa_peca();
            try
            {
                peca._os = true;
                peca.ShowDialog();
            }
            finally
            {
                tb_ferramenta.Text = peca.cod_desenho;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Limpa seleção do Datagrid View
            dgvPosicoes.ClearSelection();
            pesquisa_ferramenta(tb_ferramenta.Text, tb_item.Text);
        }

        private void dgvPosicoes_SelectionChanged(object sender, EventArgs e)
        {
            //seleciona_pos(dgvPosicoes.SelectedCells[0].Value.ToString());
        }

        private void dgvPosicoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleciona_pos(dgvPosicoes.Rows[e.RowIndex].Cells["col_cod_os"].Value.ToString());
        }

        private void dgvPosicoes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seleciona_pos(dgvPosicoes.Rows[e.RowIndex].Cells["col_cod_os"].Value.ToString());
        }
    }
}
