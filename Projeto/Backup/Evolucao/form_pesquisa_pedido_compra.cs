using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_pedido_compra : Form
    {
        
        public bool nf_entrada;
        public string cod;
        public form_pesquisa_pedido_compra()
        {
            InitializeComponent();
        }

        private void form_pesquisa_pedido_compra_Load(object sender, EventArgs e)
        {
            dgvPedido_compra.AutoGenerateColumns = false;
            dgvPedido_compra.DataSource = dsPedido_compra.Tables["PEDIDO_COMPRA"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsPedido_compra.Clear();
            this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA ORDER BY COD_PED DESC";
            this.fbConnection1.Open();
            this.datPedido_compra.SelectCommand.Connection = fbConnection1;
            this.datPedido_compra.SelectCommand.ExecuteNonQuery();
            datPedido_compra.Fill(PEDIDO_COMPRA);
            this.fbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsPedido_compra.Clear();
            this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE NOME_AUTORIZANTE_PED IS NOT NULL AND EFETUADO_PED IS NULL ORDER BY COD_PED DESC";
            this.fbConnection1.Open();
            this.datPedido_compra.SelectCommand.Connection = fbConnection1;
            this.datPedido_compra.SelectCommand.ExecuteNonQuery();
            datPedido_compra.Fill(PEDIDO_COMPRA);
            this.fbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dsPedido_compra.Clear();
            this.datPedido_compra.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDO_COMPRA WHERE NOME_AUTORIZANTE_PED IS NULL ORDER BY COD_PED DESC";
            this.fbConnection1.Open();
            this.datPedido_compra.SelectCommand.Connection = fbConnection1;
            this.datPedido_compra.SelectCommand.ExecuteNonQuery();
            datPedido_compra.Fill(PEDIDO_COMPRA);
            this.fbConnection1.Close();
        }

        private void dgvPedido_compra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nf_entrada == false)
            {
                string _cod_ped = "";
                comando_select.CommandText = "SELECT * FROM PEDIDO_COMPRA WHERE COD_PED = '" + dgvPedido_compra.Rows[e.RowIndex].Cells["col_cod"].Value.ToString() + "'";
                DataSet ped = new DataSet();
                fbConnection1.Open();
                datPedido_compra.SelectCommand = comando_select;
                datPedido_compra.Fill(ped);
                fbConnection1.Close();
                foreach (DataRow dr in ped.Tables[0].Rows)
                {
                    _cod_ped = dr["COD_PED"].ToString();
                }
                form_pedido_compra pedido = new form_pedido_compra();
                try
                {
                    pedido.abrir_pedido = true;
                    pedido.n_pedido = _cod_ped;
                    pedido.ShowDialog();
                }
                finally
                {
                    pedido.Dispose();
                }
            }
            else
            {
                cod = dgvPedido_compra.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                this.Close();
            }
        }

        private void tb_requisicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                try
                {
                    dsPedido_compra.Clear();
                    this.datPedido_compra.SelectCommand.CommandText =
                            "SELECT * FROM PEDIDO_COMPRA WHERE COD_PED = " + tb_pedido.Text + "";
                    this.fbConnection1.Open();
                    this.datPedido_compra.SelectCommand.Connection = fbConnection1;
                    this.datPedido_compra.SelectCommand.ExecuteNonQuery();
                    datPedido_compra.Fill(PEDIDO_COMPRA);
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPedido_compra.Tables["PEDIDO_COMPRA"].DefaultView.RowFilter = "NOME_FORN_PED Like '*" + tb_forn.Text + "*'";
            }
            catch { }
        }

        private void tb_autorizante_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsPedido_compra.Tables["PEDIDO_COMPRA"].DefaultView.RowFilter = "NOME_AUTORIZANTE_PED Like '*" + tb_autorizante.Text + "*'";
            }
            catch { }
        }

        private void dgvItens_ped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_ped.Columns[e.ColumnIndex].Name == "OK")
            {
                if (dgvItens_ped.Rows[e.RowIndex].Cells["col_nf_entrada"].Value.ToString() != "")
                {
                    MessageBox.Show("Esse produto já chegou");
                }
                else
                {
                    cod = dgvItens_ped.Rows[e.RowIndex].Cells["col_cod_item"].Value.ToString();
                    this.Close();
                }
                
            }
        }

        private void dgvPedido_compra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dsItens_ped.Clear();
                this.datItens_ped.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + dgvPedido_compra.Rows[e.RowIndex].Cells["col_cod"].Value.ToString() + "'";
                this.fbConnection1.Open();
                this.datItens_ped.SelectCommand.Connection = fbConnection1;
                this.datItens_ped.SelectCommand.ExecuteNonQuery();
                datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                this.fbConnection1.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        
    }
}