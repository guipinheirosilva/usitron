using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Evolucao
{
    class classe_particularidades
    {
        public string n_nf;
        public void executar_particularidades(string nf)
        {
            n_nf = nf;
            baixar_do_estoque();
        }

        private void baixar_do_estoque()
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            try
            {
                FbCommand comando = new FbCommand();
                
                comando.Connection = conexao;
                comando.CommandText =
                    "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + n_nf + "'";
                conexao.Open();
                FbDataAdapter itensDataAdapter = new FbDataAdapter();
                itensDataAdapter.SelectCommand = comando;
                DataSet itensDataSet = new DataSet();
                itensDataAdapter.Fill(itensDataSet);
                conexao.Close();
                foreach (DataRow dr in itensDataSet.Tables[0].Rows)
                {
                    try
                    {
                        FbCommand comando_produtos = new FbCommand();
                        comando_produtos.Connection = conexao;
                        conexao.Open();
                        comando_produtos.CommandText =
                            "UPDATE PRODUTOS SET ESTOQUE_ATUAL_PRODUTO = (ESTOQUE_ATUAL_PRODUTO - " +
                            dr["QTDE_ITEM"].ToString() + ") WHERE COD_PRODUTO = '" +
                            dr["COD_ITEM"].ToString() + "'";
                        FbDataAdapter datProdutos = new FbDataAdapter();
                        datProdutos.UpdateCommand = comando_produtos;
                        datProdutos.UpdateCommand.ExecuteNonQuery();
                        conexao.Close();
                    }
                    catch (Exception a)
                    {
                        conexao.Close();
                        form_erro erro = new form_erro();
                        erro.erro = a.ToString();
                        erro.ShowDialog();
                    }
                }
            }
            catch (Exception a)
            {
                conexao.Close();
                form_erro erro = new form_erro();
                erro.erro = a.ToString() ;
                erro.ShowDialog();
            }
        }
       
    }
}
