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
        public string forma_pgto_escolhida;
        public bool busca_forma_escolhida;
        public string n_parcelas, prazo_1, prazo_2, prazo_3, prazo_4, prazo_5, prazo_6;
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
            datForma_pgto.Fill(FORMA_PGTO);
        }

        private void dgvForma_pgto_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                this.Close();
            }
        }
    }
}