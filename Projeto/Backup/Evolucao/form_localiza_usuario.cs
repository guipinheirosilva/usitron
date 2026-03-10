using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_usuario : Form
    {
        public string usuario_escolhido;
        public form_localiza_usuario()
        {
            InitializeComponent();
        }

        private void form_localiza_operador_Load(object sender, EventArgs e)
        {
            datUsuarios.Fill(USUARIOS);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsUsuarios.Tables["USUARIOS"];
        }

        private void tb_localiza_operador_TextChanged(object sender, EventArgs e)
        {
            dsUsuarios.Tables["USUARIOS"].DefaultView.RowFilter = "nome_usuario Like '*" + tb_localiza_operador.Text + "*'";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            usuario_escolhido = dataGridView1.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }
    }
}