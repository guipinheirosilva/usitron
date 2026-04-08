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
    public partial class form_inspecao_componentes : Form
    {
        public form_inspecao_componentes()
        {
            InitializeComponent();
        }
        public string op;
        public DataTable dtComponentes;
        public bool ok_tudo;
        private void form_inspecao_componentes_Load(object sender, EventArgs e)
        {
            dgvComponentes.DataSource = dtComponentes;
            labelOP.Text = op;
            ok_tudo = false;
        }

        private void tb_cod_componente_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* select1.CommandText = @"SELECT p.COD_PRODUTO as COD_INTERNO, p.COD_FORNECEDOR_PRODUTO as COD, p.DESCRICAO_PRODUTO as Descricao,  
                            (pk.QTDE_PK * " + Convert.ToDouble(dr[1].ToString()).ToString().Replace(".","").Replace(",",".") + @") as Qtde_Necessaria, 
                            op.ESTOQUE_ATUAL_ESTOQUE as Estoque_Atual, '' as Qtde_Lancada FROM PRODUTOS_KIT pk 
                            INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto WHERE pk.COD_KIT_PK = " + dr[0].ToString() + "";*/
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                for (int i = 0; i < dgvComponentes.RowCount; i++)
                {
                    if (tb_cod_componente.Text == dgvComponentes.Rows[i].Cells["COD_INTERNO"].Value.ToString())
                    {
                        double qtde_necessaria = 0, qtde_estoque = 0, qtde_lancada = 0;
                        try
                        {
                            qtde_necessaria = Convert.ToDouble(dgvComponentes.Rows[i].Cells["Qtde_Necessaria"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            qtde_estoque = Convert.ToDouble(dgvComponentes.Rows[i].Cells["Estoque_Atual"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            qtde_lancada = Convert.ToDouble(dgvComponentes.Rows[i].Cells["Qtde_Lancada"].Value.ToString());
                        }
                        catch { }
                        if (qtde_necessaria > qtde_estoque)
                        {
                            MessageBox.Show("Não existe estoque necessário para esse conjunto");
                        }
                        else
                        {
                            if (qtde_lancada == qtde_necessaria)
                            {
                                MessageBox.Show("Você já lançou o número suficiente para essa OP");
                            }
                            else
                            {
                                qtde_lancada = qtde_lancada + 1;
                                dgvComponentes.Rows[i].Cells["Qtde_Lancada"].Value = qtde_lancada.ToString("n0");

                            }
                        }
                        tb_cod_componente.Text = "";
                        tb_cod_componente.Focus();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;
            for (int i = 0; i < dgvComponentes.RowCount; i++)
            {
                double qtde_necessaria = 0, qtde_estoque = 0, qtde_lancada = 0;
                try
                {
                    qtde_necessaria = Convert.ToDouble(dgvComponentes.Rows[i].Cells["Qtde_Necessaria"].Value.ToString());
                }
                catch { }
                try
                {
                    qtde_estoque = Convert.ToDouble(dgvComponentes.Rows[i].Cells["Estoque_Atual"].Value.ToString());
                }
                catch { }
                try
                {
                    qtde_lancada = Convert.ToDouble(dgvComponentes.Rows[i].Cells["Qtde_Lancada"].Value.ToString());
                }
                catch { }
                if (qtde_lancada != qtde_necessaria)
                {
                    ok = false;
                }
            }
            if (ok)
            {
                for (int i = 0; i < dgvComponentes.RowCount; i++)
                {
                    try
                    {
                        double qtde_necessaria = 0, qtde_estoque = 0, qtde_lancada = 0;
                        try
                        {
                            qtde_lancada = Convert.ToDouble(dgvComponentes.Rows[i].Cells["Qtde_Lancada"].Value.ToString());
                        }
                        catch { }

                        FbCommand insert = new FbCommand();
                        insert.CommandText =
                            "INSERT INTO ITENS_NOTA_ENT (QTDE_ITEM_ENT, OP_ITEM_ENT, COD_ITEM_ENT, BAIXADO_ITEM_ENT, COD_SISTEMA_NF_ITEM_ENT, QTDE_LOTE_ITEM_ENT) " +
                            "VALUES ('-" + qtde_lancada.ToString().Replace(".", "").Replace(",", ".") + "','" + op + "','" +
                            dgvComponentes.Rows[i].Cells["COD"].Value.ToString() + "','1', '0','-" + qtde_lancada.ToString().Replace(".", "").Replace(",", ".") + "')";
                        insert.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        try
                        {
                            try
                            {
                                classeEstoque estoque = new classeEstoque();
                                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                estoque.calcular_estoque(dgvComponentes.Rows[i].Cells["COD"].Value.ToString());
                            }
                            catch { }
                        }
                        catch { }
                    }
                    catch(Exception ex)
                    {
                        ok = false;
                        fbConnection1.Close();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Componente não retirado do estoque.Verifique");
                    }
                }
                ok_tudo = ok;
                this.Close();
            }
            else
            {
                MessageBox.Show("Não é possível confirmar pois a quantidade necessária não bate com a quantidade lançada.");
                    
            }
        }
    }
}
