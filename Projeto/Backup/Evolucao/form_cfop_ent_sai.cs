using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_cfop_ent_sai : Form
    {
        public form_cfop_ent_sai()
        {
            InitializeComponent();
        }

        private void form_cfop_ent_sai_Load(object sender, EventArgs e)
        {
            datCfop_ent_sai.Fill(CFOP_ENT_SAI);

        }
        private void salvar()
        {
            try
            {
                this.BindingContext[dsCfop_ent_sai, "CFO_SAI_ENT"].EndCurrentEdit();
                if (dsCfop_ent_sai.HasChanges())
                {
                    fbConnection1.Open();
                    datCfop_ent_sai.UpdateCommand = cbCfop_ent_sai.GetUpdateCommand();
                    datCfop_ent_sai.InsertCommand = cbCfop_ent_sai.GetInsertCommand();
                    datCfop_ent_sai.DeleteCommand = cbCfop_ent_sai.GetDeleteCommand();
                    datCfop_ent_sai.Update(dsCfop_ent_sai, "CFO_SAI_ENT");
                    dsCfop_ent_sai.AcceptChanges();
                    fbConnection1.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("Erro 100");
                fbConnection1.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}