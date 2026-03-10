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
    public partial class form_lote_envio_nfe : Form
    {
        public string cod_lote;
        public string numero_recibo;
        public form_lote_envio_nfe()
        {
            InitializeComponent();
        }

        private void dgvLec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionar_ctes(dgvLec.Rows[e.RowIndex].Cells["col_cod"].Value.ToString());
        }

        private void selecionar_ctes(string cod_lote)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM NOTA_FISCAL WHERE LOTE_ENVIO_NF = '" + cod_lote + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(NOTA_FISCAL);
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
                    "SELECT * FROM LOTE_ENVIO_NFE ORDER BY COD_LOTE_ENVIO_NFE DESC";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(LOTE_ENVIO_NFE);
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
                if (!verificar_se_existe_autorizada(dgvLec.Rows[e.RowIndex].Cells["col_cod"].Value.ToString()))
                {
                    cod_lote = dgvLec.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                    numero_recibo = dgvLec.Rows[e.RowIndex].Cells["col_rec"].Value.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existem notas autorizadas nesse lote. Impossivel Consultar Novamente.");
                }

            }
        }

        private bool verificar_se_existe_autorizada(string lote)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT STATUS_NFE FROM NOTA_FISCAL WHERE LOTE_ENVIO_NF = '" + lote + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (dr[0].ToString().Contains("Autoriza"))
                        return true;
                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return false;
            }
        }
    }
}