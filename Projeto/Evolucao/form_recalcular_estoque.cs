using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_recalcular_estoque : Form
    {
        public form_recalcular_estoque()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime começo = DateTime.Now;
                int i = 0;
                progressBar1.Value = i;
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT COD_FORNECEDOR_PRODUTO FROM PRODUTOS where status_produto = 1";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataTable dtEstoque = new DataTable();
                datEstoque.Fill(dtEstoque);
                fbConnection1.Close();
                progressBar1.Maximum = dtEstoque.Rows.Count;
                foreach (DataRow dr in dtEstoque.Rows)
                {
                    i++;
                    progressBar1.Value = i;
                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        //estoque._calcular_estoque = true;
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dr[0].ToString());
                    }
                    catch { }
                }
                progressBar1.Value = 0;
                DateTime fim = DateTime.Now;
                TimeSpan intervalo = fim - começo;
                MessageBox.Show("Recalculado com sucesso! " + intervalo.ToString());
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }
    }
}
