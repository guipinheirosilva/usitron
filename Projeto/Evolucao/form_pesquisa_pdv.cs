using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_pdv : Form
    {
        public form_pesquisa_pdv()
        {
            InitializeComponent();
        }

        public string pedido;

        private void form_pesquisa_pdv_Load(object sender, EventArgs e)
        {
            selecionar_pedidos();
        }

        private void selecionar_pedidos()
        {

            try
            {

                string data = "";
                string first = " first(100) ";
                if (dtFinal.Text != dtInicial.Text)
                {
                    first = "";
                    data = " AND DATA_EMISSAO_NFCE >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                         "DATA_EMISSAO_NFCE <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' ";
                }
                dsNfce.Clear();
                string pedido_fechado = "";
                if (cbFechados.Checked)
                    pedido_fechado = " AND (PEDIDO_FECHADO_NFCE = 1)";
                datNfce.SelectCommand.CommandText = "SELECT  " + first + " * FROM NFCE WHERE 0=0 " + pedido_fechado + data + " ORDER BY COD_NFCE DESC";
                datNfce.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datNfce.Fill(NFCE);
                fbConnection1.Close();

                dgvNfce.AutoGenerateColumns = false;
                dgvNfce.DataSource = dsNfce.Tables["NFCE"];
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void dgvNfce_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pedido = dgvNfce.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNfce.Tables[0].DefaultView.RowFilter = "PEDIDO_NFCE = '" + textBox1.Text + "'";
            }
            catch { }
        }

        private void tb_nfce_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNfce.Tables[0].DefaultView.RowFilter = "NUMERO_NFCE = '" + tb_nfce.Text + "'";
            }
            catch { }
        }

        private void tb_cpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsNfce.Tables[0].DefaultView.RowFilter = "CPF_CNPJ_CLIENTE_NFCE = '" + tb_cpf.Text + "'";
            }
            catch { }
        }

        private void tb_mesa_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecionar_pedidos();
        }

       
    }
}
