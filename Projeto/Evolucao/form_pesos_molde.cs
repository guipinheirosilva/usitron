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
    public partial class form_pesos_molde : Form
    {
        public string cod_escolhido = "", peso_escolhido = "";
        public form_pesos_molde()
        {
            InitializeComponent();
        }

        private void form_pesos_molde_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPeso.AutoGenerateColumns = false;
                dgvPeso.DataSource = dsPesos.Tables["PESO_MOLDES_PECAS"];
                datPeso.Fill(PESO_MOLDES_PECAS);
            }
            catch
            {
                MessageBox.Show("Erro ao localizar as infomrções. Contate o suporte!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsPesos, "PESO_MOLDES_PECAS"].EndCurrentEdit();
            if (dsPesos.HasChanges())
            {
                fbConnection1.Open();

                datPeso.UpdateCommand = cbPesos.GetUpdateCommand();
                datPeso.InsertCommand = cbPesos.GetInsertCommand();
                datPeso.DeleteCommand = cbPesos.GetDeleteCommand();
                datPeso.Update(dsPesos, "PESO_MOLDES_PECAS");
                dsPesos.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void dgvPeso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                cod_escolhido = dgvPeso.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                peso_escolhido = dgvPeso.Rows[e.RowIndex].Cells["col_peso"].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}
