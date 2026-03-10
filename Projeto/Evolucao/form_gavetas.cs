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
    public partial class form_gavetas : Form
    {
        public form_gavetas()
        {
            InitializeComponent();
        }

        private void form_gavetas_Load(object sender, EventArgs e)
        {
            try
            {
                dgvGavetas.AutoGenerateColumns = false;
                dgvGavetas.DataSource = dsGavetas.Tables["GAVETAS"];
                datGavetas.Fill(GAVETAS);
            }
            catch
            {
                MessageBox.Show("Erro ao localizar as infomrções. Contate o suporte!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsGavetas, "GAVETAS"].EndCurrentEdit();
            if (dsGavetas.HasChanges())
            {
                fbConnection1.Open();

                datGavetas.UpdateCommand = cbGavetas.GetUpdateCommand();
                datGavetas.InsertCommand = cbGavetas.GetInsertCommand();
                datGavetas.DeleteCommand = cbGavetas.GetDeleteCommand();
                datGavetas.Update(dsGavetas, "GAVETAS");
                dsGavetas.AcceptChanges();
                fbConnection1.Close();
            }
        }
    }
}
