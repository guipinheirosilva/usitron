using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_saidas_estoque : Form
    {
        double qtde_estoque;
        double qtde_saida;
        public form_saidas_estoque()
        {
            InitializeComponent();
        }

        private void bt_localizar_item_Click(object sender, EventArgs e)
        {
            form_busca_item_estoque localiza_item = new form_busca_item_estoque();
            try
            {
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_escolhido == "")
                { }
                else
                {
                    try
                    {
                        dsEstoque.Clear();
                        this.datEstoque.SelectCommand.CommandText =
                        "SELECT * FROM ESTOQUE WHERE COD_ESTOQUE = '" + localiza_item.cod_escolhido + "'";
                        this.fbConnection1.Open();
                        this.datEstoque.SelectCommand.Connection = fbConnection1;
                        this.datEstoque.SelectCommand.ExecuteNonQuery();
                        datEstoque.Fill(ESTOQUE);
                        this.fbConnection1.Close();
                    }
                    catch { }

                }
            }

        }

        private void bt_adicionar_item_Click(object sender, EventArgs e)
        {
            if (tb_qtde_saida.Text == "" || tb_cracha.Text == "")
            {
                MessageBox.Show("Coloque os campos obrigatórios por favor (Quantidade e Cracha)");
            }
            else
            {
                bool erro = false; 
                
                try
                {
                    qtde_estoque = Convert.ToDouble(tb_qtde_item.Text);
                    qtde_saida = Convert.ToDouble(tb_qtde_saida.Text);
                }
                catch {
                    erro = true;
                }
                if (erro == true)
                {
                    MessageBox.Show("Não é possível dar essa saída");
                }
                else
                {
                    
                    if (qtde_saida <= qtde_estoque)
                    {
                        inserir_saida();
                        localizar_itens();
                        atualizar_estoque();
                    }
                    else
                    {
                        MessageBox.Show("Não existe estoque suficiente");
                    }
                }
                dsEstoque.Clear();
                tb_qtde_saida.Text = "";
                tb_data.Text = "";
                tb_cracha.Text = "";
                tb_op.Text = "";
                qtde_estoque = 0;
                qtde_saida = 0;
            }
        }

        private void inserir_saida()
        {
            try
            {
                this.datSaida_estoque.InsertCommand.CommandText =
                "INSERT INTO ESTOQUE_SAIDA (COD_ITEM_ESTOQUE_SAIDA, ITEM_ESTOQUE_SAIDA, QTDE_ESTOQUE_SAIDA, " +
                "CRACHA_ESTOQUE_SAIDA, OP_ESTOQUE_SAIDA, DATA_ESTOQUE_SAIDA) VALUES " +
                "('" + tb_cod_item.Text + "','" + tb_item_item.Text + "','" + tb_qtde_saida.Text.Replace(",",".") + "','" + tb_cracha.Text + "'," +
                "'" + tb_op.Text + "','" + tb_data.Text.Replace("/",".") + "')";
                this.fbConnection1.Open();
                this.datSaida_estoque.InsertCommand.Connection = fbConnection1;
                this.datSaida_estoque.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro na inserção");
            }
        }

        private void localizar_itens()
        {
            dsSaida_estoque.Clear();
            this.datSaida_estoque.SelectCommand.CommandText =
            "SELECT * FROM ESTOQUE_SAIDA ORDER BY COD_ESTOQUE_SAIDA DESC";
            this.fbConnection1.Open();
            this.datSaida_estoque.SelectCommand.Connection = fbConnection1;
            this.datSaida_estoque.SelectCommand.ExecuteNonQuery();
            datSaida_estoque.Fill(ESTOQUE_SAIDA);
            this.fbConnection1.Close();
        }

        private void atualizar_estoque()
        {
            this.datEstoque.UpdateCommand.CommandText =
            "UPDATE ESTOQUE SET ESTOQUE_ATUAL_ESTOQUE = ESTOQUE_ATUAL_ESTOQUE - " + tb_qtde_saida.Text + " WHERE COD_ESTOQUE = '" + tb_cod_item.Text + "'";
            this.fbConnection1.Open();
            this.datEstoque.UpdateCommand.Connection = fbConnection1;
            this.datEstoque.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }
    }
}