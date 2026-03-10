using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_produto : Form
    {
        public string cod_produto_escolhido, descricao_produto_escolhido, item_produto_escolhido, unidade_produto_escolhido,
            marca_escolhido, grupo_escolhido, origem_produto, ncm_produto, preco_unit_produto, 
            descricao_completa_produto_escolhido, cod_forn;
        public bool buscar;
        public form_localiza_produto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_produto = '" + tb_cod.Text + "'";
               // calcular_valor_estoque();
            }
            catch { }
        }

        private void tb_cod_grupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "cod_grupo_produto = '*" + tb_cod_grupo.Text + "*'";
               // calcular_valor_estoque();
            }
            catch { }
        }

        private void tb_grupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "DESCRICAO_GRUPO_PRODUTO LIKE '*" + tb_grupo.Text + "*'";
                //calcular_valor_estoque();
            }
            catch { }
        }

        private void tbcod_sub_grupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "COD_MARCA_PRODUTO LIKE '*" + tbcod_sub_grupo.Text + "*'";
               // calcular_valor_estoque();
            }
            catch { }
        }

        private void tb_sub_grupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "MARCA_PRODUTO LIKE '*" + tb_sub_grupo.Text + "*'";
                //calcular_valor_estoque();
            }
            catch { }
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "DESCRICAO_PRODUTO LIKE '*" + tb_descricao.Text + "*'";
                //calcular_valor_estoque();
            }
            catch { }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "DESCRICAO_ITEM_PRODUTO LIKE '" + tb_descricao_item.Text + "'";
                //calcular_valor_estoque();
            }
            catch { }
        }

        private void cb_status_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "STATUS_PRODUTO = '1'";
               // calcular_valor_estoque();
            }
            catch { }
        }

        private void form_localiza_produto_Load(object sender, EventArgs e)
        {

            datProdutos.Fill(PRODUTOS);
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = dsProdutos.Tables["PRODUTOS"];

            //calcular_valor_estoque();
        }

        private void calcular_valor_estoque_novo()
        {
            
            double valor = 0;
            double valor_custo = 0;
            for (int i = 0; i < dgvProdutos.RowCount; i++)
            {
                try
                {
                    double valor_parcial = (Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_estoque_atual"].Value.ToString()) *
                                Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_valor_venda"].Value.ToString()));
                    
                   
                    if (valor_parcial < 0)
                        valor_parcial = 0;
                    valor = valor + valor_parcial;
                }
                catch{}
                try
                {
                    double valor_parcial_custo = (Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_estoque_atual"].Value.ToString()) *
                                Convert.ToDouble(dgvProdutos.Rows[i].Cells["col_custo"].Value.ToString()));
                     if (valor_parcial_custo < 0)
                        valor_parcial_custo = 0;
                    valor_custo = valor_custo + valor_parcial_custo;
                    
                }
                catch {
                   // MessageBox.Show(dgvProdutos.Rows[i].Cells["col_estoque_medio"].Value.ToString() + " " + dgvProdutos.Rows[i].Cells["col_valor_venda"].Value.ToString());
                }
            }
            tb_valor_estoque.Text = valor.ToString("n2");
            tb_valor_compra.Text = valor_custo.ToString("n2");
             
        }
        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buscar == true)
            {
                cod_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                descricao_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
                item_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_item"].Value.ToString();
                descricao_completa_produto_escolhido = descricao_produto_escolhido + " - " + item_produto_escolhido;
                unidade_produto_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_uni"].Value.ToString();
                grupo_escolhido = dgvProdutos.Rows[e.RowIndex].Cells["col_grupo"].Value.ToString();
                preco_unit_produto = dgvProdutos.Rows[e.RowIndex].Cells["col_valor_venda"].Value.ToString();
                cod_forn = dgvProdutos.Rows[e.RowIndex].Cells["col_cod_forn"].Value.ToString();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            form_produto prod = new form_produto();
            try
            {
                bool erro = false;
                prod.modificar = true;
                try
                {
                    prod.cod_prod = dgvProdutos.SelectedRows[0].Cells["col_cod"].Value.ToString();
                    
                }
                catch {
                    MessageBox.Show("Selecione a linha inteira do produto a modificar");
                    erro = true;
                }
                if(erro == false)
                    prod.ShowDialog();
            }
            finally
            {
                dsProdutos.Clear();
                datProdutos.Fill(PRODUTOS);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_produto prod = new form_produto();
            try
            {
                prod.novo = true;
                prod.ShowDialog();

            }
            finally
            {
                dsProdutos.Clear();
                datProdutos.Fill(PRODUTOS);
            }
        }

        private void tb_cod_forn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsProdutos.Tables["PRODUTOS"].DefaultView.RowFilter = "COD_FORNECEDOR_PRODUTO LIKE '*" + tb_cod_forn.Text + "*'";
               // calcular_valor_estoque();
            }
            catch { }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcular_valor_estoque_novo();
        }
    }
}