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
    public partial class form_camara_quente_bico : Form
    {
        public form_camara_quente_bico()
        {
            InitializeComponent();
        }

        private void form_camara_quente_bico_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCamara_quente.AutoGenerateColumns = false;
                dgvCamara_quente.DataSource = dsCamaraQuente.Tables["CAMERA_QUENTE"];
                datCameraQuente.Fill(CAMERA_QUENTE);
                datBicoQuente.Fill(BICO_QUENTE);
            }
            catch
            {
                MessageBox.Show("Erro ao localizar as infomrções. Contate o suporte!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsCamaraQuente, "CAMERA_QUENTE"].EndCurrentEdit();
            if (dsCamaraQuente.HasChanges())
            {
                fbConnection1.Open();

                datCameraQuente.UpdateCommand = cbCamaraQuente.GetUpdateCommand();
                datCameraQuente.InsertCommand = cbCamaraQuente.GetInsertCommand();
                datCameraQuente.DeleteCommand = cbCamaraQuente.GetDeleteCommand();
                datCameraQuente.Update(dsCamaraQuente, "CAMERA_QUENTE");
                dsCamaraQuente.AcceptChanges();
                fbConnection1.Close();
            }

            this.BindingContext[dsBicoQuente, "BICO_QUENTE"].EndCurrentEdit();
            if (dsBicoQuente.HasChanges())
            {
                fbConnection1.Open();

                datBicoQuente.UpdateCommand = cbBicoQuente.GetUpdateCommand();
                datBicoQuente.InsertCommand = cbBicoQuente.GetInsertCommand();
                datBicoQuente.DeleteCommand = cbBicoQuente.GetDeleteCommand();
                datBicoQuente.Update(dsBicoQuente, "BICO_QUENTE");
                dsBicoQuente.AcceptChanges();
                fbConnection1.Close();
            }
        }
    }
}
