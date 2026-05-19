using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Evolucao
{
    class classe_calcula_volume
    {
        FbConnection fbConnection1;

        public classe_calcula_volume()
        {
            fbConnection1 = new FbConnection(

            "User=SYSDBA;Password=masterkey;Database=/evolucao/evolucao.fdb;" +
            "DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;" +
            "Connection lifetime=0;Connection timeout=15;Pooling=True;" +
            "Packet Size=8192;Server Type=0"

            );
        }

        public bool calcula_volume_peso(int cod_nfe, out int qtde, out string produto_sem_unidade)
        {
            qtde = 0;
            produto_sem_unidade = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText = "select item.qtde_item , p.qtde_unidade_produto, p.descricao_produto, p.cod_produto from itens_nota item " +
                    " inner join produtos p  on item.cod_item = p.cod_fornecedor_produto where item.nf_item = " +
                    cod_nfe + "";
                fbConnection1.Open();
                FbDataAdapter datSelect2 = new FbDataAdapter();
                datSelect2.SelectCommand = select;
                DataTable dt2 = new DataTable();
                datSelect2.Fill(dt2);

                foreach (DataRow dr2 in dt2.Rows)
                {
                    try
                    {
                        int qtd_nota = 0;
                        int qtd_produto = 0;

                        qtd_nota = Convert.ToInt32(dr2[0].ToString());
                        if (dr2[1].ToString() == null || dr2[1].ToString() == "" || Convert.ToInt32(dr2[1].ToString()) == 0)
                        {
                            produto_sem_unidade = "Produto: " + dr2[2].ToString() + " Codigo: " + dr2[3].ToString();
                            fbConnection1.Close();
                            return false;
                        }
                        else
                        {
                            qtd_produto = Convert.ToInt32(dr2[1].ToString());

                            if (qtd_nota % qtd_produto != 0)
                            {
                                qtde += ((int)(qtd_nota / qtd_produto)) + 1;
                            }
                            else
                            {
                                qtde += (int)(qtd_nota / qtd_produto);
                            }
                        }
                    }
                    catch
                    {
                        fbConnection1.Close();
                        return false;
                    }
                }



                fbConnection1.Close();
                return true;

            }
            catch
            {
                fbConnection1.Close();
                return false;
            }



        }
    }
}
