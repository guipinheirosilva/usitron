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
    public partial class form_material : Form
    {
        public string material_escolhido = "";
        public form_material()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsMaterial, "MATERIAL"].EndCurrentEdit();
            if (dsMaterial.HasChanges())
            {
                fbConnection1.Open();
                datMaterial.UpdateCommand = cbMaterial.GetUpdateCommand();
                datMaterial.InsertCommand = cbMaterial.GetInsertCommand();
                datMaterial.DeleteCommand = cbMaterial.GetDeleteCommand();
                datMaterial.Update(dsMaterial, "MATERIAL");
                dsMaterial.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void dgvCarteiras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            material_escolhido = dgvCarteiras.Rows[e.RowIndex].Cells["col_nome"].Value.ToString();
            this.Close();
        }

        private void form_material_Load(object sender, EventArgs e)
        {
            datMaterial.Fill(MATERIAL);
        }
    }
}
