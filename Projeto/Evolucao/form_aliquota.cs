using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_aliquota : Form
    {
        public form_aliquota()
        {
            InitializeComponent();
        }

        private void form_aliquota_Load(object sender, EventArgs e)
        {
            datAliquota.Fill(ALIQUOTA_SIMPLES);
        }

        private void form_aliquota_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BindingContext[dsAliquota, "ALIQUOTA_SIMPLES"].EndCurrentEdit();
            if (dsAliquota.HasChanges())
            {
                //MessageBox.Show("CHEGOU AQUI");
                fbConnection1.Open();
                datAliquota.UpdateCommand = cbAliquota.GetUpdateCommand();
                datAliquota.InsertCommand = cbAliquota.GetInsertCommand();
                datAliquota.DeleteCommand = cbAliquota.GetDeleteCommand();
                datAliquota.Update(dsAliquota, "ALIQUOTA_SIMPLES");
                dsAliquota.AcceptChanges();
                
                fbConnection1.Close(); 
            }
        }
    }
}