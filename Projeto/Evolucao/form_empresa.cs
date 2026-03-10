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
                    "DELETE FROM EMPRESA WHERE RAZAO_SOCIAL_EMPRESA = 'NOVO'";
                fbConnection1.Open();
                datEmpresa.DeleteCommand.Connection = fbConnection1;
                datEmpresa.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close(); 

                datEmpresa.InsertCommand.CommandText =
                    "INSERT INTO EMPRESA (RAZAO_SOCIAL_EMPRESA) VALUES ('NOVO')";
                fbConnection1.Open();
                datEmpresa.InsertCommand.Connection = fbConnection1;
                datEmpresa.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close(); 

                dsEmpresa.Clear();
                datEmpresa.SelectCommand.CommandText =
                    "SELECT * FROM EMPRESA ORDER BY COD_EMPRESA DESC";
                fbConnection1.Open();
                datEmpresa.SelectCommand.Connection = fbConnection1;
                datEmpresa.SelectCommand.ExecuteNonQuery();
                datEmpresa.Fill(EMPRESA);
                fbConnection1.Close(); 
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsEmpresa, "EMPRESA"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsEmpresa, "EMPRESA"].Position++;
        }

        
    }
}