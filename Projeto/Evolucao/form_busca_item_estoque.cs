using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_busca_item_estoque : Form
    {
        public string cod_escolhido;
        public string item_escolhido;
        public string descricao_escolhido;
        public string cnpj_empresa;
        public form_busca_item_estoque(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void tb_cod_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "COD_ESTOQUE Like '*" + tb_cod.Text + "*'";
        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "ITEM_ESTOQUE Like '*" + tb_item.Text + "*'";
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "DESCRICAO_ESTOQUE Like '*" + tb_descricao.Text + "*'";
        }

        private void tb_grupo_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "GRUPO_ESTOQUE Like '*" + tb_grupo.Text + "*'";
        }

        private void tb_material_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "MATERIAL_ESTOQUE Like '*" + tb_material.Text + "*'";
        }

        private void tb_dimensao_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "DIMENSAO_ESTOQUE Like '*" + tb_dimensao.Text + "*'";
        }

        private void tb_espessura_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "ESPESSURA_ESTOQUE Like '*" + tb_espessura.Text + "*'";
        }

        private void tb_cod_fabricante_TextChanged(object sender, EventArgs e)
        {
            dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "COD_BARRAS_ITEM_FABRICANTE Like '*" + tb_cod_fabricante.Text + "*'";
        }

        private void form_busca_item_estoque_Load(object sender, EventArgs e)
        {
            try
            {
                datEstoque.Fill(ESTOQUE);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dsEstoque.Tables["ESTOQUE"];
                tb_cod.Focus();
            }
            catch
            {
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cod_escolhido = "";
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cod_escolhido = dataGridView1.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            item_escolhido = dataGridView1.Rows[e.RowIndex].Cells["col_item"].Value.ToString();
            descricao_escolhido = dataGridView1.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_estoque est = new form_estoque(cnpj_empresa);
            try
            {
                est.ShowDialog();
            }
            finally
            {
                dsEstoque.Clear();
                datEstoque.Fill(ESTOQUE);
            }

        }
    }
}