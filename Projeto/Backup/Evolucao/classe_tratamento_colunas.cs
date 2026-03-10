using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Evolucao
{
    class classe_tratamento_colunas
    {
        public DataRow linha_original;
        public DataRow retorno;

        public DataRow tratar_linha()
        {

            DataRow linha_tratada = retorno;
            
            for (int i = 0; i < linha_original.Table.Columns.Count; i++)
            {
                try
                {
                    linha_tratada = linha_original;
                    if (linha_original[i].ToString() == "" || linha_original[i] == DBNull.Value)
                    {
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.Double")
                        {
                            linha_tratada[i] = Convert.ToDouble(0);
                        }
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.DateTime")
                        {
                            linha_tratada[i] = Convert.ToDateTime(linha_original[i].ToString()).ToShortDateString();
                        }
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.String")
                        {
                            linha_tratada[i] = "null";
                        }
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.Int32")
                        {
                            linha_tratada[i] = 0;
                        }
                    }
                    else
                    {

                        linha_tratada[i] = linha_original[i].ToString();
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.Double")
                        {
                            linha_tratada[i] = linha_original[i].ToString();
                        }
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.DateTime")
                        {
                            linha_tratada[i] = Convert.ToDateTime(linha_original[i].ToString()).ToShortDateString();
                        }
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.String")
                        {
                            linha_tratada[i] = "'" + linha_original[i].ToString() + "'";
                        }
                        if (linha_original.Table.Columns[i].DataType.FullName == "System.Int32")
                        {
                            linha_tratada[i] = linha_original[i].ToString();
                        }


                    }
                }
                catch { }
            }
            return linha_tratada;

        }

    }
}
