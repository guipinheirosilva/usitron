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
    public partial class form_ncm : Form
    {
        public string ncm_escolhida;
        public form_ncm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void atualizar()
        {
            this.BindingContext[dsNCM, "NCM"].EndCurrentEdit();
            if (dsNCM.HasChanges())
            {
                fbConnection1.Open();

                datNCM.UpdateCommand = cbNCM.GetUpdateCommand();
                datNCM.InsertCommand = cbNCM.GetInsertCommand();
                datNCM.DeleteCommand = cbNCM.GetDeleteCommand();
                datNCM.Update(dsNCM, "NCM");
                dsNCM.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void dgvNCM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ncm_escolhida = dgvNCM.Rows[e.RowIndex].Cells["col_ncm"].Value.ToString();
                this.Close();
            }
            catch { }
        }

        private void form_ncm_Load(object sender, EventArgs e)
        {
            datNCM.Fill(NCM);
        }

    }
}
