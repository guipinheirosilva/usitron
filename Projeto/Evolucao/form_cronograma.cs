using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_cronograma : Form
    {
        public form_cronograma()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            dsDesenhos.Clear();
            this.datDesenhos.SelectCommand.CommandText =
                "SELECT * FROM DESENHOS WHERE COD_PECA LIKE '" + tb_molde.Text + " - %" + "' AND NOME_PECA != '' ORDER BY NOME_PECA";
            this.fbConnection1.Open();
            this.datDesenhos.SelectCommand.Connection = fbConnection1;
            this.datDesenhos.SelectCommand.ExecuteNonQuery();
            datDesenhos.Fill(DESENHOS);
            //dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cod_peca Like '" + cod_peca_desenhos.Text + " -" + "*'";
            this.fbConnection1.Close(); 
        }

        private void dgvPosicoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dsRotas_campo.Clear();
            string desenho = dgvPosicoes.Rows[e.RowIndex].Cells["col_cod_peca"].Value.ToString();
            this.datRotas_campo.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "' ORDER BY COD_ROTA_CAMPO";
            this.fbConnection1.Open();
            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
            datRotas_campo.Fill(ROTAS_CAMPO);
            //dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cod_peca Like '" + cod_peca_desenhos.Text + " -" + "*'";
            this.fbConnection1.Close(); 
        }

        private void procurar_operacao(string operacao)
        {
            string desenho = tb_molde.Text;
            dsRotas_campo.Clear();
            this.datRotas_campo.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE DESENHO_CAMPO LIKE '" + desenho + "%' AND OPERACAO_CAMPO = '" + operacao + "' ORDER BY COD_ROTA_CAMPO";
            this.fbConnection1.Open();
            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
            datRotas_campo.Fill(ROTAS_CAMPO);
            //dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cod_peca Like '" + cod_peca_desenhos.Text + " -" + "*'";
            this.fbConnection1.Close(); 
        
        }

        private void link_fresa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_fresa.Text);
        }

        private void link_torno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_torno.Text);
        }

        private void link_cnc_desb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_cnc_desb.Text);
        }

        private void link_tempera_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_tempera.Text);
        }

        private void link_retifica_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_retifica.Text);
        }

        private void link_cnc_acab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_cnc_acab.Text);
        }

        private void link_erosao_ewc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_erosao_ewc.Text);
        }

        private void link_erosao_edm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_erosao_edm.Text);
        }

        private void link_erosao_polimento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_polimento.Text);
        }

        private void link_montagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procurar_operacao(link_montagem.Text);
        }

        
    }
}