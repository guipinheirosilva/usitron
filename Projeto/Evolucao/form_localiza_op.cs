using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_op : Form
    {
        public string os_escolhida;
        public form_localiza_op()
        {
            InitializeComponent();
        }

        private void form_localiza_op_Load(object sender, EventArgs e)
        {
            datDesenhos.Fill(DESENHOS);
            dgvDesenhos.AutoGenerateColumns = false;
            dgvDesenhos.DataSource = dsDesenhos.Tables["DESENHOS"];
        }

        private void tb_localiza_peca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "n_os_peca Like '" + tb_localiza_peca.Text + "*'";
            }
            catch { }
        }

        private void dgvDesenhos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDesenhos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            try
            {
                os_escolhida = dgvDesenhos.Rows[e.RowIndex].Cells["col_os"].Value.ToString();
                this.Close();
            }
            catch { }
             * */
        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cliente Like '*" + tb_cliente.Text + "*'";
            }
            catch { }
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "nome_peca Like '*" + tb_nome.Text + "*'";
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selecionar;
                selecionar = "SELECT * FROM DESENHOS WHERE DATA_ENTREGA_PECA >= '" +
                Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                " AND DATA_ENTREGA_PECA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                if (cb_criacao.Checked)
                {
                    selecionar = "SELECT * FROM DESENHOS WHERE DATA_ABERTURA_PECA >= '" +
                Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "'" +
                " AND DATA_ABERTURA_PECA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                }
                dsDesenhos.Clear();
                datDesenhos.SelectCommand.CommandText = selecionar;
                datDesenhos.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datDesenhos.SelectCommand.ExecuteNonQuery();
                datDesenhos.Fill(DESENHOS);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] os_a_criar = new string[500];
                int numero_de_os = 0;
                for (int i = 0; i < dgvDesenhos.SelectedRows.Count; i++)
                {
                    os_a_criar[i] = dgvDesenhos.SelectedRows[i].Cells["col_os"].Value.ToString();
                    numero_de_os = i + 1;
                }
                classe_cronograma cronograma = new classe_cronograma();
                cronograma.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                cronograma.os = true;
                cronograma.por_os = true;
                cronograma.numero_de_os = numero_de_os;
                cronograma.todas_os_a_criar = os_a_criar;
                cronograma.criar_xml_os_geral(@"c:\\evolucao\\cronogramas\todas_os.xml");
                cronograma.criar_html_os_geral(@"c:\\evolucao\\cronogramas\cronograma_todas_os.html");
                cronograma.abrir_html(@"c:\\evolucao\\cronogramas\cronograma_todas_os.html");
            }
            catch { }
        }

        private void dgvDesenhos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                os_escolhida = dgvDesenhos.Rows[e.RowIndex].Cells["col_os"].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}