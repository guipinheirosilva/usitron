using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_corte_estoque : Form
    {
        public DataTable retorno = new DataTable();

        public DataTable dtItens = new DataTable();
        DataTable dtItens_completos = new DataTable();
        public form_corte_estoque()
        {
            InitializeComponent();
        }

        private void form_corte_estoque_Load(object sender, EventArgs e)
        {
            colunas_itens_completos();

            DataColumn coluna_marcado = new DataColumn();
            dtItens.Columns.Add(coluna_marcado);

            foreach (DataRow dr in dtItens.Rows)
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                        "SELECT '" + dr[2].ToString() + "' as QTDE_DISPONIVEL_ESTOQUE, '" + dr[1].ToString() + "' AS QTDE_FISICO, '" + dr[3].ToString() + "' AS QTDE_RESERVA_FECHADA, " +
                        "QTDE_ITEM_VENDA, COD_PROD_ITEM_VENDA, DESCRICAO_PROD_ITEM_VENDA, VALOR_UNIT_PROD_ITEM_VENDA, VALOR_TOTAL_PROD_ITEM_VENDA, COD_ITEM_VENDA " +
                        " FROM ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + dr[0].ToString() + "'";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtItem = new DataTable();
                    datSelect.Fill(dtItem);
                    fbConnection1.Close(); 
                    foreach (DataRow dr1 in dtItem.Rows)
                    {
                        //DataRow dr2 = dr1;
                        try
                        {
                            dtItens_completos.Rows.Add(dr1[0].ToString(), dr1[1].ToString(), dr1[2].ToString(), dr1[3].ToString(),
                                dr1[4].ToString(), dr1[5].ToString(), dr1[6].ToString(), dr1[7].ToString(), dr1[8].ToString());
                        }
                        catch { }
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close(); 
                }
            }

            dgvItens.DataSource = dtItens_completos;
        }

        private void colunas_itens_completos()
        {
          
            DataColumn coluna2 = new DataColumn(); coluna2.ColumnName = "Qtde Estoque Disponivel"; 
            dtItens_completos.Columns.Add(coluna2);
            DataColumn coluna9 = new DataColumn(); coluna9.ColumnName = "Qtde Estoque Físico";
            dtItens_completos.Columns.Add(coluna9);
            DataColumn coluna10 = new DataColumn(); coluna10.ColumnName = "Qtde Estoque Reserva Fechada";
            dtItens_completos.Columns.Add(coluna10);
            DataColumn coluna3 = new DataColumn(); coluna3.ColumnName = "Qtde Pedido";
            dtItens_completos.Columns.Add(coluna3);
            DataColumn coluna4 = new DataColumn(); coluna4.ColumnName = "Cód. Produto";
            dtItens_completos.Columns.Add(coluna4);
            DataColumn coluna5 = new DataColumn(); coluna5.ColumnName = "Descrição ";
            dtItens_completos.Columns.Add(coluna5);
            DataColumn coluna6 = new DataColumn(); coluna6.ColumnName = "Valor Unit";
            dtItens_completos.Columns.Add(coluna6);
            DataColumn coluna7 = new DataColumn(); coluna7.ColumnName = "Valor Total";
            dtItens_completos.Columns.Add(coluna7);
            DataColumn coluna8 = new DataColumn(); coluna8.ColumnName = "CodInterno";
            dtItens_completos.Columns.Add(coluna8);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataColumn coluna2 = new DataColumn(); coluna2.ColumnName = "Cod"; retorno.Columns.Add(coluna2);
            }
            catch { }
            for (int i = 0; i < dgvItens.SelectedRows.Count; i++)
            {
                try
                {
                    retorno.Rows.Add(dgvItens.SelectedRows[i].Cells["CodInterno"].Value.ToString());
                }
                catch { }
            }
            this.Close();
        }
    }
}
