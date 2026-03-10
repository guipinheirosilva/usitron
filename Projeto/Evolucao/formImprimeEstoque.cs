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
    public partial class formImprimeEstoque : Form
    {
        public formImprimeEstoque()
        {
            InitializeComponent();
        }


        private void rbtnImpressaoDetalhada_Click(object sender, EventArgs e)
        {
            if(rbtnImpressaoDetalhada.Checked)
            {
                dataInicio.Enabled = true;
                dataFim.Enabled = true;
            }
        }

        private void rbtnImpressaoSimples_Click(object sender, EventArgs e)
        {
            if(rbtnImpressaoSimples.Checked)
            {
                dataInicio.Enabled = false;
                dataFim.Enabled = false;
            }
        }

        private void formImprimeEstoque_Load(object sender, EventArgs e)
        {
            rbtnImpressaoSimples.Checked = true;
            
            //Carregando os dados de fornecedores no comboBox------------------------------//
            datFornecedores.Fill(FORNECEDORES);                     //Preenchendo DataTable
            cbxFornecedores.DataSource = FORNECEDORES;              //Preenchendo ComboBox
            cbxFornecedores.DisplayMember = "razao_social_forn";    //Definindo Legenda
            cbxFornecedores.ValueMember = "cnpj_cpf_forn";          //Definindo Valor

            cbxFornecedores.SelectedIndex = -1;                     //Selecionando nada
            //------------------------------------------------------------------------------//

            //Carregando os dados de grupos no comboBox------------------------------//
            datGrupos.Fill(GRUPOS);                                 //Preenchendo DataTable
            cbxGrupos.DataSource = GRUPOS;                          //Preenchendo ComboBox
            cbxGrupos.DisplayMember = "descricao_grupo";            //Definindo Legenda
            cbxGrupos.ValueMember = "cod_grupo";                    //Definindo Valor

            cbxGrupos.SelectedIndex = -1;                           //Selecionando nada
            //------------------------------------------------------------------------------//

            //Carregando os dados de sub-grupos no comboBox------------------------------//
            datSubGrupos.Fill(SUB_GRUPOS);                          //Preenchendo DataTable
            cbxSubGrupos.DataSource = SUB_GRUPOS;                   //Preenchendo ComboBox
            cbxSubGrupos.DisplayMember = "descricao_sub_grupo";     //Definindo Legenda
            cbxSubGrupos.ValueMember = "cod_sub_grupos";            //Definindo Valor

            cbxSubGrupos.SelectedIndex = -1;                        //Selecionando nada
            //------------------------------------------------------------------------------//
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dsEstoque estoque = new dsEstoque();
            FbCommand selectEntradas, selectSaidas;
            FbDataAdapter datEntradas, datSaidas;

            string fornecedor = "", grupo = "", subGrupo = "", ordem = "order by p.DESCRICAO_PRODUTO ";

            if(cbxFornecedores.SelectedIndex > -1)
            {
                fornecedor = "and p.cnpj_fornecedor_produto like '" + cbxFornecedores.SelectedValue.ToString() + "' ";
               // ordem = "order by p.cod_fornecedor_produto";
            }

            if (cbxGrupos.SelectedIndex > -1)
            {
                grupo = "and p.cod_grupo_produto = " + cbxGrupos.SelectedValue.ToString() + " ";
               // ordem = "order by p.cod_fornecedor_produto";
            }

            if (cbxSubGrupos.SelectedIndex > -1)
            {
                subGrupo = "and p.cod_sub_grupo_produto = " + cbxSubGrupos.SelectedValue.ToString() + " ";
               // ordem = "order by p.cod_fornecedor_produto";
            }

            try
            {
                if (rbtnImpressaoSimples.Checked)
                {
                    estoque.Clear();
                    datProdutos.SelectCommand.CommandText =
                        "select p.* " +
                        "from produtos p " +
                        "where p.STATUS_PRODUTO = '1' " +
                        fornecedor + grupo + subGrupo +
                        ordem;
                    datProdutos.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datProdutos.SelectCommand.ExecuteNonQuery();
                    datProdutos.Fill(estoque.PRODUTOS);
                    fbConnection1.Close(); 

                    crEstoqueSintetico_produtos estoqueSimples = new crEstoqueSintetico_produtos();
                    estoqueSimples.SetDataSource(estoque);

                    form_imprimir imprimir = new form_imprimir(estoqueSimples);
                    imprimir.Show();
                }
                else
                {
                    selectEntradas = new FbCommand();
                    selectSaidas = new FbCommand();
                    datEntradas = new FbDataAdapter();
                    datSaidas = new FbDataAdapter();
                    
                    estoque.Clear();
                    datProdutos.SelectCommand.CommandText =
                        "select p.* " +
                        "from produtos p " +
                        "where p.STATUS_PRODUTO = '1' " +
                        fornecedor + grupo + subGrupo +
                        ordem;
                    datProdutos.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datProdutos.SelectCommand.ExecuteNonQuery();
                    datProdutos.Fill(estoque.PRODUTOS);
                    fbConnection1.Close(); 

                    foreach(DataRow dr in estoque.PRODUTOS.Rows)
                    {
                        try
                        {
                            selectEntradas.CommandText =
                                "select nfe.data_emissao_nf_ent, nfe.n_nf_ent, ine.qtde_item_ent, ine.cod_ean_item_ent " +
                                "from itens_nota_ent ine " +
                                "inner join nota_fiscal_ent nfe " +
                                "on nfe.n_nf_ent = ine.nf_item_ent " +
                                "where ine.baixado_item_ent = 1 " +
                                "and ine.cod_ean_item_ent like '" + dr["cod_barras_caixa_produto"].ToString() + "' " +
                                "order by nfe.data_emissao_nf_ent";          
                            datEntradas.SelectCommand = selectEntradas;
                            datEntradas.SelectCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datEntradas.SelectCommand.ExecuteNonQuery();
                            datEntradas.Fill(estoque.ENTRADAS);
                            fbConnection1.Close(); 
                        }
                        catch(Exception a)
                        {
                            fbConnection1.Close(); 
                            MessageBox.Show("Houve um erro ao selecionar as entradas do item " + dr["descricao_produto"].ToString() + "!\nErro: " + a.Message);
                        }

                        try
                        {
                            selectSaidas.CommandText =
                                "select nf.data_emissao_nf, nf.n_nf, item.qtde_item, item.cod_ean_item " +
                                "from itens_nota item " +
                                "inner join nota_fiscal nf " +
                                "on nf.n_nf = item.nf_item " +
                                "where nf.status_nfe like 'NFe Autorizada.' " +
                                "and item.cod_ean_item like '7897077808133' " +
                                "and nf.data_emissao_nf > '13.02.2014' " +
                                "order by nf.data_emissao_nf";              
                            datSaidas.SelectCommand = selectSaidas;
                            datSaidas.SelectCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datSaidas.SelectCommand.ExecuteNonQuery();
                            datSaidas.Fill(estoque.SAIDAS);
                            fbConnection1.Close(); 
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close(); 
                            MessageBox.Show("Houve um erro ao selecionar as saidas do item " + dr["descricao_produto"].ToString() + "!\nErro: " + a.Message);
                        }
                    }

                }
            }
            catch(Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show("Houve um erro ao selecionar os produtos!\nErro: " + a.Message);
            }
        }

    }
}
