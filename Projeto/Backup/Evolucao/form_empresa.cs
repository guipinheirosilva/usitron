using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_empresa : Form
    {
        public form_empresa()
        {
            InitializeComponent();
        }

        private void bt_abrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string caminho;
            caminho = openFileDialog1.FileName;
            logo.ImageLocation = caminho;
        }

        private void form_empresa_Load(object sender, EventArgs e)
        {
            datEmpresa.Fill(EMPRESA);
            
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[dsEmpresa, "EMPRESA"].EndCurrentEdit();
                if (dsEmpresa.HasChanges())
                {
                    //MessageBox.Show("CHEGOU AQUI");
                    fbConnection1.Open();
                    datEmpresa.UpdateCommand = cbEmpresa.GetUpdateCommand();
                    datEmpresa.InsertCommand = cbEmpresa.GetInsertCommand();
                    datEmpresa.DeleteCommand = cbEmpresa.GetDeleteCommand();
                    datEmpresa.Update(dsEmpresa, "EMPRESA");
                    dsEmpresa.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datEmpresa.DeleteCommand.CommandText =
                    "DELETE FROM EMPRESA";
                fbConnection1.Open();
                datEmpresa.DeleteCommand.Connection = fbConnection1;
                datEmpresa.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();

                datEmpresa.InsertCommand.CommandText =
                    "INSERT INTO EMPRESA (COD_EMPRESA) VALUES ('1')";
                fbConnection1.Open();
                datEmpresa.InsertCommand.Connection = fbConnection1;
                datEmpresa.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();

                datEmpresa.Fill(EMPRESA);
            }
            catch
            {

            }
        }

        
    }
}