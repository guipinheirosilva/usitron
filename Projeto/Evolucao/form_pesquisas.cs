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
    public partial class form_pesquisas : Form
    {
        public string cod, descricao;
        public form_pesquisas()
        {
            InitializeComponent();
        }

        private void form_pesquisas_Load(object sender, EventArgs e)
        {
            datPesquisas.Fill(PESQUISAS);
        }

        private void dgvPesquisas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cod = dgvPesquisas.Rows[e.RowIndex].Cells[0].Value.ToString();
            descricao = dgvPesquisas.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsPesquisas, "PESQUISAS"].EndCurrentEdit();
            if (dsPesquisas.HasChanges())
            {
                fbConnection1.Open();
                datPesquisas.UpdateCommand = cbPesquisas.GetUpdateCommand();
                datPesquisas.InsertCommand = cbPesquisas.GetInsertCommand();
                datPesquisas.DeleteCommand = cbPesquisas.GetDeleteCommand();
                datPesquisas.Update(dsPesquisas, "PESQUISAS");
                dsPesquisas.AcceptChanges();
                fbConnection1.Close();
            }
        }
    }
}
