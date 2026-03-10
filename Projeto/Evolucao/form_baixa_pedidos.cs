using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_baixa_pedidos : Form
    {
        public form_baixa_pedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + tb_cod_item.Text + "'";
                DataSet prod = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close(); 

                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    aliq_ipi = dr["ALIQUOTA_IPI_PRODUTO"].ToString();
                    aliq_icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                    perc_red_icms = dr["REDUCAO_FORA_PRODUTO"].ToString();
                }
            }
            catch
            {
                fbConnection1.Close(); 
            }
             * */
        }
    }
}