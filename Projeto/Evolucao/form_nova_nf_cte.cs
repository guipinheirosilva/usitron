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
    public partial class form_nova_nf_cte : Form
    {
        public string cod_cte;
        public form_nova_nf_cte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FbConnection fbConnection1 = new FbConnection();
                fbConnection1.ConnectionString =
                    @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO CTE_NOTAS_FISCAIS (N_NF_CNF, CHAVE_NF_CNF, COD_CTE_CNF, VALOR_NOTA_CNF, " + 
                    "PESO_NOTA_CNF, VOLUMES_NOTA_CNF) VALUES " + 
                    "('" + tb_n_nf.Text + "','" + tb_chave.Text + "','" + cod_cte + "','" + 
                    Convert.ToDouble(tb_valor_nf.Text).ToString().Replace(".","").Replace(",",".") + "','" +
                    Convert.ToDouble(tb_peso.Text).ToString().Replace(".", "").Replace(",", ".") + "','" +
                    Convert.ToInt32(tb_qtde_volumes.Text).ToString().Replace(".", "").Replace(",", ".") + "')";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.InsertCommand = insert;
                datTabela.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }
}