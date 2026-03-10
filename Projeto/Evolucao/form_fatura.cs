using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_fatura : Form
    {
        public string nf;
        public form_fatura()
        {
            InitializeComponent();
        }

        private void form_fatura_Load(object sender, EventArgs e)
        {
            this.datFatura_nf.SelectCommand.CommandText =
                    "SELECT * FROM FATURA_NF WHERE NF_FATURA = '" + nf + "'";
            this.fbConnection1.Open();
            this.datFatura_nf.SelectCommand.Connection = fbConnection1;
            this.datFatura_nf.SelectCommand.ExecuteNonQuery();
            datFatura_nf.Fill(FATURA_NF);
            this.fbConnection1.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
            this.Close();

        }

        private void Atualizar()
        {
            this.BindingContext[dsFatura_nf, "FATURA_NF"].EndCurrentEdit();
            if (dsFatura_nf.HasChanges())
            {
                //MessageBox.Show("CHEGOU AQUI");
                fbConnection1.Open();
                datFatura_nf.UpdateCommand = cbFatura_nf.GetUpdateCommand();
                datFatura_nf.InsertCommand = cbFatura_nf.GetInsertCommand();
                datFatura_nf.DeleteCommand = cbFatura_nf.GetDeleteCommand();
                datFatura_nf.Update(dsFatura_nf, "FATURA_NF");
                dsFatura_nf.AcceptChanges();
                //datFatura_nf.Fill(FATURA_NF);
                fbConnection1.Close(); 
            }
        }
    }
}