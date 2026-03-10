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
            dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "n_os_peca Like '" + tb_localiza_peca.Text + "*'";
        }

        private void dgvDesenhos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDesenhos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            os_escolhida = dgvDesenhos.Rows[e.RowIndex].Cells["col_os"].Value.ToString();
            this.Close();
        }
    }
}