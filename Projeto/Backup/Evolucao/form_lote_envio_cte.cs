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
    public partial class form_lote_envio_cte : Form
    {
        public string cod_lote;
        public string numero_recibo;
        public form_lote_envio_cte()
        {
            InitializeComponent();
        }

        private void dgvLec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionar_ctes(dgvLec.Rows[e.RowIndex].Cells["col_cod_lote_envio"].Value.ToString());
        }

        private void selecionar_ctes(string cod_lote)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM CTE WHERE NUMERO_LOTE_ENVIO_CTE = '" + cod_lote + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(CTE);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        private void form_lote_envio_cte_Load(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM LOTE_ENVIO_CTE ORDER BY COD_LOTE_ENVIO_CTE DESC";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(LOTE_ENVIO_CTE);
                fbConnection1.Close();

                //Definindo a formatação do campo hora no dgvLec
                dgvLec.Columns[4].DefaultCellStyle.Format = "HH:mm";
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        private void dgvLec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLec.Columns[e.ColumnIndex].Name == "col_confirmar")
            {
                cod_lote = dgvLec.Rows[e.RowIndex].Cells["col_cod_lote_envio"].Value.ToString();
                numero_recibo = dgvLec.Rows[e.RowIndex].Cells["col_recibo"].Value.ToString();
                this.Close();

            }
        }
    }
}