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
    public partial class form_busca_item_estoque_mp : Form
    {
        public string usuario;
        public string cod_escolhido;
        public string item_escolhido;
        public string descricao_escolhido;
        public bool busca;
        string _cod, _grupo, _material, _classificacao, _acabamento, _espessura, _dimensao, _comprimento, _cliente, _tipo;
        int qtde_itens_filtrados;
        public string tipo_escolhido;
        public string unidade_escolhido;
        public form_busca_item_estoque_mp()
        {
            InitializeComponent();
        }

        private void filtrar()
        {
            try
            {
                dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "COD_ESTOQUE IS NOT NULL " + _grupo + _material + 
                    _classificacao + _acabamento + _espessura + _dimensao + _cliente + _tipo + _comprimento;
            }
            catch { }
        }

        private void buscar_qtde_itens_filtrados()
        {
            qtde_itens_filtrados = 0;
            if (cbTipo.Text != "")
                qtde_itens_filtrados++;
            if (tb_cliente.Text != "")
                qtde_itens_filtrados++;
            if (tb_grupo.Text != "")
                qtde_itens_filtrados++;
            if (tb_material.Text != "")
                qtde_itens_filtrados++;
            if (tb_classificacao.Text != "")
                qtde_itens_filtrados++;
            if (tb_acabamento.Text != "")
                qtde_itens_filtrados++;
            if (tb_espessura.Text != "")
                qtde_itens_filtrados++;
            if (tb_dimensao.Text != "")
                qtde_itens_filtrados++;
            if (tb_comprimento.Text != "")
                qtde_itens_filtrados++;

        }

        private void tb_cod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "COD_ESTOQUE = '" + tb_cod.Text + "'";
            }
            catch { }
        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsEstoque.Tables["ESTOQUE"].DefaultView.RowFilter = "ITEM_ESTOQUE Like '*" + tb_item.Text + "*'";
            }
            catch { }
        }

        private void tb_grupo_TextChanged(object sender, EventArgs e)
        {
            _grupo = "";
            if(tb_grupo.Text != "")
                _grupo = " AND GRUPO_ESTOQUE Like '*" + tb_grupo.Text + "*'";
            filtrar();
        }

        private void tb_material_TextChanged(object sender, EventArgs e)
        {
            _material = "";
            if(tb_material.Text != "")
                _material = " AND MATERIAL_ESTOQUE Like '*" + tb_material.Text + "*'";
            filtrar();
        }

        private void tb_dimensao_TextChanged(object sender, EventArgs e)
        {
            _dimensao = ""; 
            if(tb_dimensao.Text != "")
                _dimensao = " AND DIMENSAO_ESTOQUE Like '*" + tb_dimensao.Text + "*'";
            filtrar();
        }

        private void tb_espessura_TextChanged(object sender, EventArgs e)
        {
            _espessura = "";
            if(tb_espessura.Text != "")
                _espessura = " AND ESPESSURA_ESTOQUE Like '*" + tb_espessura.Text + "*'";
            filtrar();
        }

     

        private void form_busca_item_estoque_Load(object sender, EventArgs e)
        {
            try
            {
                datEstoque.Fill(ESTOQUE);

                cbTipo.SelectedIndex = -1;
                filtrar();
                dgvEstoque.AutoGenerateColumns = false;
                dgvEstoque.DataSource = dsEstoque.Tables["ESTOQUE"];

                if (tipo_escolhido != "" && tipo_escolhido != null)
                    cbTipo.Text = tipo_escolhido;
                tb_cod.Focus();
                colocar_cores();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void colocar_cores()
        {
            for (int i = 0; i < dgvEstoque.RowCount; i++)
            {
                double estoque_minimo = 0;
                double estoque_disponivel = 0;
                try
                {
                    estoque_minimo = Convert.ToDouble(dgvEstoque.Rows[i].Cells["col_minimo"].Value.ToString());
                    estoque_disponivel = Convert.ToDouble(dgvEstoque.Rows[i].Cells["col_disponivel"].Value.ToString());
                    if (estoque_disponivel < 0)
                        dgvEstoque.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    else
                    {
                        if (estoque_minimo >= estoque_disponivel)
                        {
                            dgvEstoque.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                    }
                }
                catch
                {

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cod_escolhido = "";
            this.Close();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            form_estoque est = new form_estoque();
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

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tipo = "";
            if (cbTipo.Text != "")
            {
                try
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE Like '%" + cbTipo.Text + "%'";
                }
                catch
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE != null";
                }
                filtrar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double total_geral = 0;
                for (int i = 0; i < dgvEstoque.RowCount; i++)
                {
                    double saidas = buscar_saidas_periodo(dgvEstoque.Rows[i].Cells["col_cod"].Value.ToString());
                    try
                    {
                        double peso_unit = Convert.ToDouble(dgvEstoque.Rows[i].Cells["col_peso_unit"].Value.ToString());
                        double total = peso_unit * saidas;
                        //double ultima_compra = buscar_ultima_compra(dgvEstoque.Rows[i].Cells["col_cod"].Value.ToString());
                       // dgvEstoque.Rows[i].Cells["col_valor_ultima_compra"].Value = ultima_compra.ToString("n2");
                        dgvEstoque.Rows[i].Cells["col_peso_total"].Value = total.ToString("n2");
                        dgvEstoque.Rows[i].Cells["col_qtde_saidas"].Value = saidas.ToString("n2");
                        total_geral = total_geral + total;
                    }
                    catch { }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private double buscar_ultima_compra(string cod_estoque)
        {
            FbDataAdapter datItens = new FbDataAdapter();
            FbCommand select = new FbCommand();
            try
            {
                
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT PRECO_UNIT_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + cod_estoque + "' order by COD_ITENS_NOTA_ENT desc";
                
                datItens.SelectCommand = select;
                DataSet dsItens = new DataSet();
                datItens.Fill(dsItens);
                fbConnection1.Close();
                foreach (DataRow dr in dsItens.Tables[0].Rows)
                {
                    try
                    {
                        return Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                return 0;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        private double buscar_saidas_periodo(string cod)
        {
            double retorno = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT QTDE_ESTOQUE_SAIDA FROM ESTOQUE_SAIDA WHERE COD_ITEM_ESTOQUE_SAIDA = '" + cod + "' AND (" +
                    "DATA_ESTOQUE_SAIDA >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                    "DATA_ESTOQUE_SAIDA <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "')";
                FbDataAdapter datSaidas = new FbDataAdapter();
                datSaidas.SelectCommand = select;
                DataSet dsSaidas = new DataSet();
                datSaidas.Fill(dsSaidas);
                fbConnection1.Close();
                foreach (DataRow dr in dsSaidas.Tables[0].Rows)
                {
                    try
                    {
                        retorno = retorno + Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        private void dgvEstoque_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca)
            {
                form_estoque est = new form_estoque();
                est.cod_a_abrir = cod_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                est.Show();
            }
            else
            {
                try
                {
                    cod_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                    item_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_item"].Value.ToString();
                    descricao_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                    unidade_escolhido = dgvEstoque.Rows[e.RowIndex].Cells["col_unidade"].Value.ToString();
                    this.Close();
                }
                catch { }
            }
        }

        private void tb_classificacao_TextChanged(object sender, EventArgs e)
        {
            _classificacao = "";
            if(tb_classificacao.Text != "")
                _classificacao = " AND CLASSIFICACAO_ESTOQUE Like '*" + tb_classificacao.Text + "*'";
            filtrar();
        }

        private void tb_comprimento_TextChanged(object sender, EventArgs e)
        {
            _comprimento = "";
            if(tb_comprimento.Text != "")
                _comprimento = " AND COMPRIMENTO_ESTOQUE Like '*" + tb_comprimento.Text + "*'";
            filtrar();
        }

        private void tb_acabamento_TextChanged(object sender, EventArgs e)
        {
            _acabamento = "";
            if(tb_acabamento.Text != "")
                _acabamento = " AND ACABAMENTO_ESTOQUE Like '*" + tb_acabamento.Text + "*'";
            filtrar();
        }

        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            _cliente = "";
            if (tb_cliente.Text != "")
                _cliente = " AND NOME_PROPRIETARIO_ESTOQUE like '*" + tb_cliente.Text + "*'";
            filtrar();
        }

        private void cbTipo_TextChanged(object sender, EventArgs e)
        {
            _tipo = "";
            if (cbTipo.Text != "")
            {
                try
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE Like '%" + cbTipo.Text + "%'";
                }
                catch
                {
                    _tipo = " AND TIPO_ITEM_ESTOQUE != null";
                }
                filtrar();
            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}