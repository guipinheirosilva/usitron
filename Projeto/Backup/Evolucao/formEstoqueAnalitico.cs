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
    public partial class formEstoqueAnalitico : Form
    {
        FbConnection conex = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0");
		FbCommand select = new FbCommand();
        
        public formEstoqueAnalitico()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btBuscarItemEstoque_Click(object sender, EventArgs e)
        {
            form_busca_item_estoque_mp buscarItemEstoque = new form_busca_item_estoque_mp();

            try
            {
                buscarItemEstoque.ShowDialog();
            }
            finally
            {
                buscarItemEstoque.Dispose();

                tbCodItemEstoque.Text = buscarItemEstoque.cod_escolhido;
                tbDescricaoItemEstoque.Text = buscarItemEstoque.descricao_escolhido;
            }

            btImprimir.Focus();
        }

        private void formEstoqueAnalitico_Load(object sender, EventArgs e)
        {
            cbPeriodo.Focus();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            if (cbPeriodo.Checked == false && cbItemEstoque.Checked == false)
            {
                impEstoqueAnalitico(1);
            }
            else if(cbPeriodo.Checked == true && cbItemEstoque.Checked == false)
            {
                impEstoqueAnalitico(2);
            }
            else if (cbPeriodo.Checked == false && cbItemEstoque.Checked == true)
            {
                impEstoqueAnalitico(3);
            }
            else if (cbPeriodo.Checked == true && cbItemEstoque.Checked == true)
            {
                impEstoqueAnalitico(4);
            }
        }

        private void impEstoqueAnalitico(int op)
        {
            FbDataAdapter datEstoque = new FbDataAdapter();
            FbDataAdapter datEntradas = new FbDataAdapter();
            FbDataAdapter datSaidas = new FbDataAdapter();
            dsConsulta dsImp = new dsConsulta();
            crEstoqueAnalitico crEstoqueAnalitico = new crEstoqueAnalitico();
            form_imprimir formImp = new form_imprimir(crEstoqueAnalitico);

            string consultaEstoque = "SELECT * FROM estoque WHERE 1=1 ";
            string consultaEntradas = "SELECT * FROM itens_nota_ent WHERE 1=1 ";
            string consultaSaidas = "SELECT * FROM estoque_saida WHERE 1=1 ";

            string cond1, cond2, cond3, cond4;
            string ordem;
            
            switch(op){
                case 1:
                    {
                        try
                        {
                            //Selecionando os itens de estoque
                            ordem = "ORDER BY cod_estoque";
                            
                            select.CommandText = consultaEstoque + ordem;
                            datEstoque.SelectCommand = select;
                            datEstoque.SelectCommand.Connection = conex;
                            datEstoque.SelectCommand.Connection.Open();
                            datEstoque.SelectCommand.ExecuteNonQuery();
                            datEstoque.Fill(dsImp.ESTOQUE);
                            datEstoque.SelectCommand.Connection.Close();

                            //Selecionando as entradas de cada item de estoque
                            foreach(DataRow itemEstoque in dsImp.ESTOQUE){
                                try
                                {
                                    cond1 = "AND cod_item_est_item_ent = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    ordem = "ORDER BY data_insercao_item_ent_nota";

                                    select.CommandText = consultaEntradas + cond1 + ordem;
                                    datEntradas.SelectCommand = select;
                                    datEntradas.SelectCommand.Connection = conex;
                                    datEntradas.SelectCommand.Connection.Open();
                                    datEntradas.SelectCommand.ExecuteNonQuery();
                                    datEntradas.Fill(dsImp.ENTRADAS);
                                    datEntradas.SelectCommand.Connection.Close();

                                }
                                catch(Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datEntradas.SelectCommand.Connection.Close();
                                }
                            }

                            //Selecionando as saídas de cada item de estoque
                            foreach (DataRow itemEstoque in dsImp.ESTOQUE)
                            {
                                try
                                {
                                    cond1 = "AND cod_item_estoque_saida = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    ordem = "ORDER BY data_estoque_saida";

                                    select.CommandText = consultaSaidas + cond1 + ordem;
                                    datSaidas.SelectCommand = select;
                                    datSaidas.SelectCommand.Connection = conex;
                                    datSaidas.SelectCommand.Connection.Open();
                                    datSaidas.SelectCommand.ExecuteNonQuery();
                                    datSaidas.Fill(dsImp.SAIDAS);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                            }
                        }
                        catch(Exception a)
                        {
                            MessageBox.Show(a.Message);
                            datEstoque.SelectCommand.Connection.Close();
                        }

                        //Exibindo o relatório
                        crEstoqueAnalitico.SetDataSource(dsImp);
                        formImp.Show();                        

                        break;
                    }
                case 2:
                    {
                        try
                        {
                            //Selecionando os itens de estoque
                            ordem = "ORDER BY cod_estoque";

                            select.CommandText = consultaEstoque + ordem;
                            datEstoque.SelectCommand = select;
                            datEstoque.SelectCommand.Connection = conex;
                            datEstoque.SelectCommand.Connection.Open();
                            datEstoque.SelectCommand.ExecuteNonQuery();
                            datEstoque.Fill(dsImp.ESTOQUE);
                            datEstoque.SelectCommand.Connection.Close();

                            //Selecionando as entradas de cada item de estoque
                            foreach (DataRow itemEstoque in dsImp.ESTOQUE)
                            {
                                try
                                {
                                    cond1 = "AND cod_item_est_item_ent = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    cond2 = "AND data_insercao_item_ent_nota >= '" + dtDataInicial.Text.Replace("/",".") + "' ";
                                    cond3 = "AND data_insercao_item_ent_nota <= '" + dtDataFinal.Text.Replace("/",".") + "' ";
                                    ordem = "ORDER BY data_insercao_item_ent_nota";

                                    select.CommandText = consultaEntradas + cond1 + cond2 + cond3 + ordem;
                                    datEntradas.SelectCommand = select;
                                    datEntradas.SelectCommand.Connection = conex;
                                    datEntradas.SelectCommand.Connection.Open();
                                    datEntradas.SelectCommand.ExecuteNonQuery();
                                    datEntradas.Fill(dsImp.ENTRADAS);
                                    datEntradas.SelectCommand.Connection.Close();

                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datEntradas.SelectCommand.Connection.Close();
                                }
                            }

                            //Selecionando as saídas de cada item de estoque
                            foreach (DataRow itemEstoque in dsImp.ESTOQUE)
                            {
                                try
                                {
                                    cond1 = "AND cod_item_estoque_saida = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    cond2 = "AND data_estoque_saida >= '" + dtDataInicial.Text.Replace("/",".") + "' ";
                                    cond3 = "AND data_estoque_saida <= '" + dtDataFinal.Text.Replace("/", ".") + "' ";
                                    ordem = "ORDER BY data_estoque_saida";

                                    select.CommandText = consultaSaidas + cond1 + cond2 + cond3 + ordem;
                                    datSaidas.SelectCommand = select;
                                    datSaidas.SelectCommand.Connection = conex;
                                    datSaidas.SelectCommand.Connection.Open();
                                    datSaidas.SelectCommand.ExecuteNonQuery();
                                    datSaidas.Fill(dsImp.SAIDAS);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                            datEstoque.SelectCommand.Connection.Close();
                        }

                        //Exibindo o relatório
                        crEstoqueAnalitico.SetDataSource(dsImp);
                        formImp.Show();
                        
                        break;
                    }
                case 3:
                    {
                        try
                        {
                            //Selecionando os itens de estoque
                            cond1 = "AND cod_estoque = " + Convert.ToInt32(tbCodItemEstoque.Text);

                            select.CommandText = consultaEstoque + cond1;
                            datEstoque.SelectCommand = select;
                            datEstoque.SelectCommand.Connection = conex;
                            datEstoque.SelectCommand.Connection.Open();
                            datEstoque.SelectCommand.ExecuteNonQuery();
                            datEstoque.Fill(dsImp.ESTOQUE);
                            datEstoque.SelectCommand.Connection.Close();

                            //Selecionando as entradas de cada item de estoque
                            foreach (DataRow itemEstoque in dsImp.ESTOQUE)
                            {
                                try
                                {
                                    cond1 = "AND cod_item_est_item_ent = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    ordem = "ORDER BY data_insercao_item_ent_nota";

                                    select.CommandText = consultaEntradas + cond1 + ordem;
                                    datEntradas.SelectCommand = select;
                                    datEntradas.SelectCommand.Connection = conex;
                                    datEntradas.SelectCommand.Connection.Open();
                                    datEntradas.SelectCommand.ExecuteNonQuery();
                                    datEntradas.Fill(dsImp.ENTRADAS);
                                    datEntradas.SelectCommand.Connection.Close();

                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datEntradas.SelectCommand.Connection.Close();
                                }
                            }

                            //Selecionando as saídas de cada item de estoque
                            foreach (DataRow itemEstoque in dsImp.ESTOQUE)
                            {
                                try
                                {
                                    cond1 = "AND cod_item_estoque_saida = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    ordem = "ORDER BY data_estoque_saida";

                                    select.CommandText = consultaSaidas + cond1 + ordem;
                                    datSaidas.SelectCommand = select;
                                    datSaidas.SelectCommand.Connection = conex;
                                    datSaidas.SelectCommand.Connection.Open();
                                    datSaidas.SelectCommand.ExecuteNonQuery();
                                    datSaidas.Fill(dsImp.SAIDAS);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                            datEstoque.SelectCommand.Connection.Close();
                        }

                        //Exibindo o relatório
                        crEstoqueAnalitico.SetDataSource(dsImp);
                        formImp.Show();

                        break;
                    }
                case 4:
                    {
                        try
                        {
                            //Selecionando os itens de estoque
                            cond1 = "AND cod_estoque = " + Convert.ToInt32(tbCodItemEstoque.Text);

                            select.CommandText = consultaEstoque + cond1;
                            datEstoque.SelectCommand = select;
                            datEstoque.SelectCommand.Connection = conex;
                            datEstoque.SelectCommand.Connection.Open();
                            datEstoque.SelectCommand.ExecuteNonQuery();
                            datEstoque.Fill(dsImp.ESTOQUE);
                            datEstoque.SelectCommand.Connection.Close();

                            //Selecionando as entradas de cada item de estoque
                            foreach (DataRow itemEstoque in dsImp.ESTOQUE)
                            {
                                try
                                {
                                    cond2 = "AND cod_item_est_item_ent = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    cond3 = "AND data_insercao_item_ent_nota >= '" + dtDataInicial.Text.Replace("/", ".") + "' ";
                                    cond4 = "AND data_insercao_item_ent_nota <= '" + dtDataFinal.Text.Replace("/", ".") + "' ";
                                    ordem = "ORDER BY data_insercao_item_ent_nota";

                                    select.CommandText = consultaEntradas + cond2 + cond3 + cond4 + ordem;
                                    datEntradas.SelectCommand = select;
                                    datEntradas.SelectCommand.Connection = conex;
                                    datEntradas.SelectCommand.Connection.Open();
                                    datEntradas.SelectCommand.ExecuteNonQuery();
                                    datEntradas.Fill(dsImp.ENTRADAS);
                                    datEntradas.SelectCommand.Connection.Close();

                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datEntradas.SelectCommand.Connection.Close();
                                }
                            }

                            //Selecionando as saídas de cada item de estoque
                            foreach (DataRow itemEstoque in dsImp.ESTOQUE)
                            {
                                try
                                {
                                    cond2 = "AND cod_item_estoque_saida = " + itemEstoque["COD_ESTOQUE"] + " ";
                                    cond3 = "AND data_estoque_saida >= '" + dtDataInicial.Text.Replace("/", ".") + "' ";
                                    cond4 = "AND data_estoque_saida <= '" + dtDataFinal.Text.Replace("/", ".") + "' ";
                                    ordem = "ORDER BY data_estoque_saida";

                                    select.CommandText = consultaSaidas + cond2 + cond3 + cond4 + ordem;
                                    datSaidas.SelectCommand = select;
                                    datSaidas.SelectCommand.Connection = conex;
                                    datSaidas.SelectCommand.Connection.Open();
                                    datSaidas.SelectCommand.ExecuteNonQuery();
                                    datSaidas.Fill(dsImp.SAIDAS);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message);
                                    datSaidas.SelectCommand.Connection.Close();
                                }
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                            datEstoque.SelectCommand.Connection.Close();
                        }

                        //Exibindo o relatório
                        crEstoqueAnalitico.SetDataSource(dsImp);
                        formImp.Show();

                        break;
                    }
            }
        }

        private void tbCodItemEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                localizar(Convert.ToInt32(tbCodItemEstoque.Text));
            }
        }

        private void localizar(int codItemEstoque)
        {
            FbDataAdapter datItemEstoque = new FbDataAdapter();
            DataTable tbEstoque = new DataTable();

            try
            {
                select.CommandText =
                    "SELECT cod_estoque, item_estoque " +
                    "FROM estoque " +
                    "WHERE cod_estoque = " + codItemEstoque;
                datItemEstoque.SelectCommand = select;
                datItemEstoque.SelectCommand.Connection = conex;
                datItemEstoque.SelectCommand.Connection.Open();
                datItemEstoque.SelectCommand.ExecuteNonQuery();
                datItemEstoque.Fill(tbEstoque);
                datItemEstoque.SelectCommand.Connection.Close();

                tbDescricaoItemEstoque.Text = tbEstoque.Rows[0]["ITEM_ESTOQUE"].ToString();
                btImprimir.Focus();

            }
            catch(Exception a)
            {
                datItemEstoque.SelectCommand.Connection.Close();
                MessageBox.Show(a.Message);
            }
        }
    }
}