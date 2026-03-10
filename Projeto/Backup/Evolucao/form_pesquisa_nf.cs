using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_nf : Form
    {
        public string nf_escolhida;
        public form_pesquisa_nf()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    
                        if (cb_faturamento.Checked == true)
                        {
                            dsNota_fiscal.Clear();
                            this.datNota_fiscal.SelectCommand.CommandText =
                                   "SELECT * FROM NOTA_FISCAL WHERE DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                                   "' AND DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'  AND (NATUREZA_OPERACAO_NF LIKE ('%VENDA%') OR NATUREZA_OPERACAO_NF LIKE ('INDUSTRIALIZA%') OR NATUREZA_OPERACAO_NF LIKE ('OUTRAS SAIDAS') OR NATUREZA_OPERACAO_NF LIKE ('PRESTACAO%')  ) AND STATUS_NFE = 'NFe Autorizada.' ORDER BY DATA_EMISSAO_NF DESC";
                            this.fbConnection1.Open();
                            this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                            this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                            datNota_fiscal.Fill(NOTA_FISCAL);
                            this.fbConnection1.Close();
                        }
                        else
                        {
                            dsNota_fiscal.Clear();
                            this.datNota_fiscal.SelectCommand.CommandText =
                                   /*"SELECT * FROM NOTA_FISCAL WHERE DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
                                   "' AND DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_EMISSAO_NF DESC";*/
                                    "SELECT n.*, pv.vendedor_ped_venda " + 
                                    "FROM NOTA_FISCAL n " + 
                                    "INNER JOIN pedidos_nf pnf " + 
                                    "ON pnf.nf_pedido_nf = n.n_nf " + 
                                    "INNER JOIN pedidos_venda pv " + 
                                    "ON pv.cod_ped_venda = pnf.n_pedido_nf " +
                                    "WHERE n.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND n.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " + 
                                    "ORDER BY n.DATA_EMISSAO_NF DESC;";
                            this.fbConnection1.Open();
                            this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                            this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                            datNota_fiscal.Fill(NOTA_FISCAL);
                            this.fbConnection1.Close();
                        }

                   
                }
                catch
                {
                    fbConnection1.Close();
                }
            
            somar_valores();
        }

        private void somar_valores()
        {
            double total = 0;
            double ipi = 0;
            for (int i = 0; i < dgvNota_fiscal.RowCount - 1; i++)
            {
                try
                {
                    total = total + Convert.ToDouble(dgvNota_fiscal.Rows[i].Cells["col_valor_total"].Value.ToString());
                    ipi = ipi + Convert.ToDouble(dgvNota_fiscal.Rows[i].Cells["col_ipi"].Value.ToString());
                }
                catch{}
            }
            tb_soma.Text = total.ToString("n2");
            double resultado = total - ipi;
            tb_soma_sem_ipi.Text = resultado.ToString("n2");


            
        }
        private void form_pesquisa_nf_Load(object sender, EventArgs e)
        {

            dgvNota_fiscal.AutoGenerateColumns = false;
            dgvNota_fiscal.DataSource = dsNota_fiscal.Tables["NOTA_FISCAL"];
            try
            {
                dsNota_fiscal.Clear();
                this.datNota_fiscal.SelectCommand.CommandText =
                    /*"SELECT * FROM NOTA_FISCAL ORDER BY DATA_EMISSAO_NF DESC";*/
                        "SELECT n.*, pv.vendedor_ped_venda " +
                        "FROM NOTA_FISCAL n " +
                        "INNER JOIN pedidos_nf pnf " +
                        "ON pnf.nf_pedido_nf = n.n_nf " +
                        "INNER JOIN pedidos_venda pv " +
                        "ON pv.cod_ped_venda = pnf.n_pedido_nf " +
                        "WHERE n.data_emissao_nf >= '01.01.2013' " +
                        "ORDER BY n.DATA_EMISSAO_NF DESC";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void dgvNota_fiscal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nf_escolhida = dgvNota_fiscal.Rows[e.RowIndex].Cells["col_n_nf"].Value.ToString();
            this.Close();
        }

        private void tb_n_nf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "N_NF = '" + tb_n_nf.Text + "'";
            }
            catch { }
        }

        private void tb_cliente_2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "CLIENTE_FORN_NF Like '*" + tb_cliente_2.Text + "*'";
                somar_valores();
            }
            catch { }
        }

        private void tb_obs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "NATUREZA_OPERACAO_NF Like '*" + textBox1.Text + "*'";
                somar_valores();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNota_fiscal.RowCount; i++)
            {
                if (dgvNota_fiscal.Rows[i].Cells["col_status"].Value.ToString() == "NFe Autorizada.")
                {
                    classe_particularidades part = new classe_particularidades();
                    part.executar_particularidades(dgvNota_fiscal.Rows[i].Cells["col_n_nf"].Value.ToString());
                }
            }
        }

        private void tb_cnpj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "CNPJ_FORN_NF Like '*" + tb_cnpj.Text + "*'";
                somar_valores();
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "VENDEDOR_PED_VENDA Like '*" + txtVendedor.Text + "*'";
                somar_valores();
            }
            catch 
            {
                dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "VENDEDOR_PED_VENDA is not null";
                somar_valores();
            }
        }

        private void dgvNota_fiscal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       


    }
}