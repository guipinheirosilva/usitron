using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_tabela_preco : Form
    {
        public string _cod, _descricao;
        public form_localiza_tabela_preco()
        {
            InitializeComponent();
        }

        private void dgvTabela_preco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _cod = dgvTabela_preco.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            _descricao = dgvTabela_preco.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
            this.Close();
        }

        private void form_localiza_tabela_preco_Load(object sender, EventArgs e)
        {
            datTabela_preco.Fill(TABELA_PRECO);
        }
    }
}