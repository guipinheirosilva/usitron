using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_forma_pgto : Form
    {
        public string cod_pgto;
        public string forma_pgto_ja_escolhida;
        public string cod_forma_pgto_ja_escolhida;
        public string forma_pgto_escolhida;
        public bool busca_forma_escolhida;
        public string n_parcelas, prazo_1, prazo_2, prazo_3, prazo_4, prazo_5, prazo_6, prazo_7, prazo_8, prazo_9, prazo_10, prazo_11, prazo_12;
        public string cod_forma_pgto_escolhida;

        public form_forma_pgto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsForma_pgto, "FORMA_PGTO"].EndCurrentEdit();
            if (dsForma_pgto.HasChanges())
            {
                //MessageBox.Show("CHEGOU AQUI");
                fbConnection1.Open();
                datForma_pgto.UpdateCommand = cbForma_pgto.GetUpdateCommand();
                datForma_pgto.InsertCommand = cbForma_pgto.GetInsertCommand();
                datForma_pgto.DeleteCommand = cbForma_pgto.GetDeleteCommand();
                datForma_pgto.Update(dsForma_pgto, "FORMA_PGTO");
                dsForma_pgto.AcceptChanges();
                datForma_pgto.Fill(FORMA_PGTO);
                fbConnection1.Close(); 
            }
        }

        private void form_forma_pgto_Load(object sender, EventArgs e)
        {
            try
            {
                datForma_pgto.Fill(FORMA_PGTO);
                if (forma_pgto_ja_escolhida != "" || cod_forma_pgto_ja_escolhida != "")
                {
                    for (int i = 0; i < dgvForma_pgto.RowCount; i++)
                    {
                        try
                        {
                            if (forma_pgto_ja_escolhida == dgvForma_pgto.Rows[i].Cells["col_descricao"].Value.ToString())
                            {

                                forma_pgto_escolhida = dgvForma_pgto.Rows[i].Cells["col_descricao"].Value.ToString();
                                n_parcelas = dgvForma_pgto.Rows[i].Cells["col_n_parcelas"].Value.ToString();
                                prazo_1 = dgvForma_pgto.Rows[i].Cells["col_prazo_1"].Value.ToString();
                                prazo_2 = dgvForma_pgto.Rows[i].Cells["col_prazo_2"].Value.ToString();
                                prazo_3 = dgvForma_pgto.Rows[i].Cells["col_prazo_3"].Value.ToString();
                                prazo_4 = dgvForma_pgto.Rows[i].Cells["col_prazo_4"].Value.ToString();
                                prazo_5 = dgvForma_pgto.Rows[i].Cells["col_prazo_5"].Value.ToString();
                                prazo_6 = dgvForma_pgto.Rows[i].Cells["col_prazo_6"].Value.ToString();
                                prazo_7 = dgvForma_pgto.Rows[i].Cells["col_prazo_7"].Value.ToString();
                                prazo_8 = dgvForma_pgto.Rows[i].Cells["col_prazo_8"].Value.ToString();
                                prazo_9 = dgvForma_pgto.Rows[i].Cells["col_prazo_9"].Value.ToString();
                                prazo_10 = dgvForma_pgto.Rows[i].Cells["col_prazo_10"].Value.ToString();
                                prazo_11 = dgvForma_pgto.Rows[i].Cells["col_prazo_11"].Value.ToString();
                                prazo_12 = dgvForma_pgto.Rows[i].Cells["col_prazo_12"].Value.ToString();
                                this.Close();
                            }
                            if (cod_forma_pgto_ja_escolhida == dgvForma_pgto.Rows[i].Cells["col_cod"].Value.ToString())
                            {
                                forma_pgto_escolhida = dgvForma_pgto.Rows[i].Cells["col_descricao"].Value.ToString();
                                n_parcelas = dgvForma_pgto.Rows[i].Cells["col_n_parcelas"].Value.ToString();
                                prazo_1 = dgvForma_pgto.Rows[i].Cells["col_prazo_1"].Value.ToString();
                                prazo_2 = dgvForma_pgto.Rows[i].Cells["col_prazo_2"].Value.ToString();
                                prazo_3 = dgvForma_pgto.Rows[i].Cells["col_prazo_3"].Value.ToString();
                                prazo_4 = dgvForma_pgto.Rows[i].Cells["col_prazo_4"].Value.ToString();
                                prazo_5 = dgvForma_pgto.Rows[i].Cells["col_prazo_5"].Value.ToString();
                                prazo_6 = dgvForma_pgto.Rows[i].Cells["col_prazo_6"].Value.ToString();
                                prazo_7 = dgvForma_pgto.Rows[i].Cells["col_prazo_7"].Value.ToString();
                                prazo_8 = dgvForma_pgto.Rows[i].Cells["col_prazo_8"].Value.ToString();
                                prazo_9 = dgvForma_pgto.Rows[i].Cells["col_prazo_9"].Value.ToString();
                                prazo_10 = dgvForma_pgto.Rows[i].Cells["col_prazo_10"].Value.ToString();
                                prazo_11 = dgvForma_pgto.Rows[i].Cells["col_prazo_11"].Value.ToString();
                                prazo_12 = dgvForma_pgto.Rows[i].Cells["col_prazo_12"].Value.ToString();
                                this.Close();
                            }
                        }
                        catch { }
                    }
                }

            }
            catch { }
        }

        private void dgvForma_pgto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvForma_pgto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca_forma_escolhida == true)
            {
                forma_pgto_escolhida = dgvForma_pgto.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                n_parcelas = dgvForma_pgto.Rows[e.RowIndex].Cells["col_n_parcelas"].Value.ToString();
                prazo_1 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_1"].Value.ToString();
                prazo_2 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_2"].Value.ToString();
                prazo_3 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_3"].Value.ToString();
                prazo_4 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_4"].Value.ToString();
                prazo_5 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_5"].Value.ToString();
                prazo_6 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_6"].Value.ToString();
                prazo_7 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_7"].Value.ToString();
                prazo_8 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_8"].Value.ToString();
                prazo_9 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_9"].Value.ToString();
                prazo_10 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_10"].Value.ToString();
                prazo_11 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_11"].Value.ToString();
                prazo_12 = dgvForma_pgto.Rows[e.RowIndex].Cells["col_prazo_12"].Value.ToString();
                cod_pgto = dgvForma_pgto.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                cod_forma_pgto_escolhida = dgvForma_pgto.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                this.Close();
            }
        }

        private void dgvForma_pgto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                dgvForma_pgto_CellDoubleClick(sender, e);
                return;
            }

            if (dgvForma_pgto.Columns[e.ColumnIndex].Name == "but_carteira")
            {
                form_carteiras cart = new form_carteiras();
                try
                {
                    cart.ShowDialog();
                }
                finally
                {
                    dgvForma_pgto.Rows[e.RowIndex].Cells["col_carteira"].Value = cart.nome_escolhido;
                }
            }
            if (dgvForma_pgto.Columns[e.ColumnIndex].Name == "but_cc")
            {
                form_cc cc = new form_cc();
                try
                {
                    cc.ShowDialog();
                }
                finally
                {
                    dgvForma_pgto.Rows[e.RowIndex].Cells["col_cc"].Value = cc.descricao_escolhido;
                    dgvForma_pgto.Rows[e.RowIndex].Cells["col_cod_cc"].Value = cc.cod_escolhido;
                }
            }
        }
    }
}