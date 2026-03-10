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
    public partial class form_pesquisa_comissao : Form
    {
        public string cod_ped_escolhido;
        public string[] pedidos_selecionados = new string[500];
        public bool consulta; public bool selecao_nf;
        public int numero_pedidos;
        bool erro = false;
        public form_pesquisa_comissao()
        {
            InitializeComponent();
        }




        private void somar_totais()
        {
            double total = 0;
            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                try
                {
                    total = total + Convert.ToDouble(dgvPedidos.Rows[i].Cells["col_valor_total"].Value);
                }
                catch
                { }
            }
            tb_valor_total.Text = total.ToString("n2");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto();
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void cb_vendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vendedor.Checked == false)
            {
                tb_cod_vendedor.Text = "";
                tb_nome_vendedor.Text = "";
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                tb_nome_cliente.Text = localiza_cliente.cliente_escolhido;


            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void tb_nome_vendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            try
            {
                dsPedidos_venda.Clear();

                string grupo = cbxGrupo.SelectedItem.ToString();

                string vendedor = "", cliente = "", fornecedor = "";

                if (cb_vendedor.Checked == true)
                {
                    vendedor = " AND COD_VENDEDOR_PED_VENDA = '" + tb_cod_vendedor.Text + "' ";
                }
                if (cb_cliente.Checked == true)
                {
                    cliente = " AND CLIENTE_PED_VENDA = '" + tb_nome_cliente.Text + "' ";
                }
                if(cb_fornecedor.Checked == true)
                {
                    fornecedor = " AND NOME_FORNECEDOR_PRODUTO = '" + tb_nome_fornecedor.Text + "' ";
                }

                FbCommand select = new FbCommand();
                select.CommandText = "select ped_venda.vendedor_ped_venda,('" + grupo + "')grupo, sum(itens.preco_total_item)total" +
                                     " from produtos prod " +
                                     "inner join itens_nota itens on prod.cod_barras_produto = itens.cod_ean_item " +
                                     "inner join cfo cfop on itens.cfop_item = cfop.n_cfo " +
                                     "inner join nota_fiscal nf on itens.nf_item = nf.n_nf " +
                                     "inner join pedidos_nf ped on nf.n_nf = ped.nf_pedido_nf " +
                                     "inner join pedidos_venda ped_venda on ped.n_pedido_nf = ped_venda.cod_ped_venda " +
                                     "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                                     "and data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                                     "and prod.descricao_grupo_produto = '" + grupo + "' " + cliente + vendedor + fornecedor + 
                                     "and NF.status_nfe LIKE '%Autorizada%'" +
                                     "and cfop.tributada_cfo='1'" +
                                     "and itens.cfop_item <> '5910'" +
                                     "and itens.cfop_item <> '6910'" +
                                     "group by ped_venda.cod_vendedor_ped_venda, ped_venda.vendedor_ped_venda, prod.descricao_grupo_produto ";
                    
                    
                    
                                     /*"select ped_venda.vendedor_ped_venda,('"+grupo+"')grupo, sum(itens.preco_total_item)total"+
                                     " from produtos prod " +
                                     "inner join itens_nota itens on prod.cod_barras_produto = itens.cod_ean_item " +
                                     "inner join nota_fiscal nf on itens.nf_item = nf.n_nf " +
                                     "inner join pedidos_nf ped on nf.n_nf = ped.nf_pedido_nf " +
                                     "inner join pedidos_venda ped_venda on ped.n_pedido_nf = ped_venda.cod_ped_venda " +
                                     "where nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' " +
                                     "and data_emissao_nf <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' " +
                                     "and prod.descricao_grupo_produto = '" + grupo + "' " + cliente + vendedor +
                                     "AND NF.status_nfe LIKE '%Autorizada%'" +
                                     "group by ped_venda.cod_vendedor_ped_venda, ped_venda.vendedor_ped_venda, prod.descricao_grupo_produto ";*/


                
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                dgvPedidos.DataSource = dtSelect;
                fbConnection1.Close();
                acertar_dgv();
                somar_total();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Erro, selecione um grupo");
            }
        }

        private void acertar_dgv()
        {
            try
            {
                dgvPedidos.Columns[0].Width = 250; 
                dgvPedidos.Columns[0].HeaderText = "Nome Vendedor";

                dgvPedidos.Columns[1].Width = 180; 
                dgvPedidos.Columns[1].HeaderText = "Grupo";

                dgvPedidos.Columns[2].Width = 125;
                dgvPedidos.Columns[2].HeaderText = "Total";
                dgvPedidos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPedidos.Columns[2].DefaultCellStyle.Format = "n2";

                dgvPedidos.Sort(dgvPedidos.Columns[0], ListSortDirection.Descending);

            }
            catch { }

        }

        private void somar_total()
        {
            double total = 0;
            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                try
                {
                    total = total + Convert.ToDouble(dgvPedidos.Rows[i].Cells[2].Value);
                }
                catch
                { }
            }
            tb_valor_total.Text = total.ToString("n2");
        }

        private void fbConnection1_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {

        }

        private void tb_cod_vendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_pesquisa_comissao_Load(object sender, EventArgs e)
        {
            carregaCombo();
        }
        private void carregaCombo()
        {
            try
            {
                cbxGrupo.Items.Clear();
                FbCommand selectPlano = new FbCommand();
                selectPlano.CommandText =
                    "SELECT DISTINCT(DESCRICAO_GRUPO_PRODUTO) FROM PRODUTOS WHERE DESCRICAO_GRUPO_PRODUTO IS NOT NULL";
                selectPlano.Connection = fbConnection1;
                FbDataAdapter datTabela = new FbDataAdapter();
                DataSet dsTabela = new DataSet();
                fbConnection1.Open();
                datTabela.SelectCommand = selectPlano;
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    cbxGrupo.Items.Add(dr[0].ToString());
                }

                    //cbxGrupo.SelectedIndex = 0;
            
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void tb_vendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void cb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cliente.Checked == false)
            {
                tb_nome_cliente.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_fornecedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dsImprimir_op pv = new dsImprimir_op();
            foreach (DataGridViewRow row in dgvPedidos.Rows)
            {
                pv.Tables["DT_COMISSAO"].Rows.Add(row);

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pv.Tables["DT_COMISSAO"].Rows[row.Index][cell.ColumnIndex] = cell.Value;
                }
            }
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM EMPRESA WHERE CNPJ_EMPRESA = '09229374000158'";
                FbDataAdapter datTable = new FbDataAdapter();
                datTable.SelectCommand = select;
                fbConnection1.Open();
                datTable.Fill(pv.EMPRESA);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
            crComissao cr = new crComissao();
            cr.SetDataSource(pv);

            form_imprimir imprimir = new form_imprimir(cr);
            imprimir.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tb_nome_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            form_fornecedores forn = new form_fornecedores(true,"");

            try
            {
                forn.ShowDialog();
            }
            finally
            {
                forn.Dispose();
                //tb_nome_fornecedor.Text = forn.form_fornecedores;
            }
        }

        private void tb_valor_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            form_localiza_forn fornecedores = new form_localiza_forn(false);

            try
            {
                fornecedores.ShowDialog();
            }
            finally
            {
                fornecedores.Dispose();
                tb_nome_fornecedor.Text = fornecedores.forn_escolhido;
            }
        }

    }
}
            
        
        
