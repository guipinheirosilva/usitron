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
    public partial class form_grupo_planos : Form
    {
        public form_grupo_planos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsGrupo_planos, "GRUPO_PLANOS"].EndCurrentEdit();
            if (dsGrupo_planos.HasChanges())
            {
                fbConnection1.Open();
                datGrupo_planos.UpdateCommand = cbGrupo_planos.GetUpdateCommand();
                datGrupo_planos.InsertCommand = cbGrupo_planos.GetInsertCommand();
                datGrupo_planos.DeleteCommand = cbGrupo_planos.GetDeleteCommand();
                datGrupo_planos.Update(dsGrupo_planos, "GRUPO_PLANOS");
                dsGrupo_planos.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void form_grupo_planos_Load(object sender, EventArgs e)
        {
            datGrupo_planos.Fill(GRUPO_PLANOS);
        }
    }
}
