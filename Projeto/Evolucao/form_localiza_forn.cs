using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_forn : Form
    {
        public string forn_escolhido;
        public string razao_forn_escolhido;
        public string cnpj_escolhido;
        public string estado_escolhido;
        public string cod_escolhido;
        public string cnpj_empresa;

        public form_localiza_forn(bool cadastro, string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
            if (!cadastro)
            {
                button1.Visible = false;
            }
        }

        private void form_localiza_forn_Load(object sender, EventArgs e)
        {
            datForn.Fill(FORNECEDORES);
            dgvForn.AutoGenerateColumns = false;
            dgvForn.DataSource = dsForn.Tables["FORNECEDORES"];
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsForn.Tables["FORNECEDORES"].DefaultView.RowFilter = "razao_social_forn Like '" + tb_localiza.Text + "*'";
            }
            catch { }
        }

        private void dgvForn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsForn.Tables["FORNECEDORES"].DefaultView.RowFilter = "nome_forn Like '" + textBox1.Text + "*'";
            }
            catch { }
        }

        private void tb_cnpj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsForn.Tables["FORNECEDORES"].DefaultView.RowFilter = "CNPJ_CPF_FORN Like '" + tb_cnpj.Text + "*'";
            }
            catch { }
        }

        private void dgvForn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            forn_escolhido = dgvForn.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            cnpj_escolhido = dgvForn.Rows[e.RowIndex].Cells["col_cnpj"].Value.ToString();
            razao_forn_escolhido = dgvForn.Rows[e.RowIndex].Cells["col_razao"].Value.ToString();
            estado_escolhido = dgvForn.Rows[e.RowIndex].Cells["col_estado"].Value.ToString();
            cod_escolhido = dgvForn.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forn_escolhido = dgvForn.Rows[dgvForn.CurrentRow.Index].Cells["col_cod"].Value.ToString();
            cnpj_escolhido = dgvForn.Rows[dgvForn.CurrentRow.Index].Cells["col_cnpj"].Value.ToString();
            razao_forn_escolhido = dgvForn.Rows[dgvForn.CurrentRow.Index].Cells["col_razao"].Value.ToString();
            estado_escolhido = dgvForn.Rows[dgvForn.CurrentRow.Index].Cells["col_estado"].Value.ToString();
            cod_escolhido = dgvForn.Rows[dgvForn.CurrentRow.Index].Cells["col_cod"].Value.ToString();

            form_fornecedores forn = new form_fornecedores(true, forn_escolhido, cnpj_empresa);

            try
            {
                forn.ShowDialog();
            }
            finally
            {
                datForn.Fill(FORNECEDORES);
            }
        }
    }
}