using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_peca : Form
    {
        public string descricao, cod_desenho;
        public bool _os;
        public form_pesquisa_peca()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPecas.Tables["PECAS"].DefaultView.RowFilter = "DESCRICAO_PECA LIKE '*" + textBox1.Text + "*'";
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPecas.Tables["PECAS"].DefaultView.RowFilter = "COD_DESENHO_PECA LIKE '*" + tb_cod_desenho.Text + "*'";
            }
            catch { }
        }

        private void dgvPecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            descricao = dgvPecas.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
            cod_desenho = dgvPecas.Rows[e.RowIndex].Cells["col_cod_desenho"].Value.ToString();
            this.Close();
        }

        private void form_pesquisa_peca_Load(object sender, EventArgs e)
        {
            datPecas.Fill(PECAS);
            dgvPecas.AutoGenerateColumns = false;
            dgvPecas.DataSource = dsPecas.Tables["PECAS"];
            tb_cod_desenho.Focus();
        }

        private void bt_modificar_selecao_Click(object sender, EventArgs e)
        {
            if (dgvPecas.SelectedRows.Count == 1)
            {
                form_peca peca = new form_peca();
                try
                {
                    peca.cod_escolhido = dgvPecas.SelectedRows[0].Cells["col_cod"].Value.ToString();
                    peca.ShowDialog();
                }
                finally
                {
                    datPecas.Fill(PECAS);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma peça");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_peca peca = new form_peca();
            try
            {
                peca.ShowDialog();
            }
            finally
            {
                datPecas.Fill(PECAS);
            }

        }

        private void dgvPecas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (_os)
                {
                    form_peca peca = new form_peca();
                    try
                    {
                        peca.cod_escolhido = dgvPecas.Rows[dgvPecas.SelectedCells[0].RowIndex-1].Cells["col_cod"].Value.ToString();
                        peca.ShowDialog();
                    }
                    finally
                    {
                        descricao = dgvPecas.Rows[dgvPecas.SelectedCells[0].RowIndex-1].Cells["col_descricao"].Value.ToString();
                        cod_desenho = dgvPecas.Rows[dgvPecas.SelectedCells[0].RowIndex-1].Cells["col_cod_desenho"].Value.ToString();
                        this.Close();
                    }
                }
                else
                {
                    descricao = dgvPecas.Rows[dgvPecas.SelectedCells[0].RowIndex -1].Cells["col_descricao"].Value.ToString();
                    cod_desenho = dgvPecas.Rows[dgvPecas.SelectedCells[0].RowIndex-1].Cells["col_cod_desenho"].Value.ToString();
                    this.Close();
                }
            }
        }

        private void tb_cod_alternativo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPecas.Tables["PECAS"].DefaultView.RowFilter = "COD_ALTERNATIVO1_PECA LIKE '*" + tb_cod_alternativo.Text + "*'";
            }
            catch { }
        }
    }
}