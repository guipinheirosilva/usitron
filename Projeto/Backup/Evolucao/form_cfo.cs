using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_cfo : Form
    {
        public form_cfo()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.datCfo.InsertCommand.CommandText =
                "INSERT INTO CFO (DESCRICAO_CFO)" +
                "VALUES ('nova')";
            this.fbConnection1.Open();
            this.datCfo.InsertCommand.Connection = fbConnection1;
            this.datCfo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            
            this.datCfo.SelectCommand.CommandText =
                "SELECT * FROM CFO WHERE DESCRICAO_CFO = 'nova'";
            this.fbConnection1.Open();
            this.datCfo.SelectCommand.Connection = fbConnection1;
            this.datCfo.SelectCommand.ExecuteNonQuery();
            datCfo.Fill(CFO);
            this.fbConnection1.Close();
            this.BindingContext[dsCfo, "CFO"].Position = 100000000;
        }

        private void form_cfo_Load(object sender, EventArgs e)
        {
            this.datCfo.SelectCommand.CommandText =
               "SELECT * FROM CFO";
            this.fbConnection1.Open();
            this.datCfo.SelectCommand.Connection = fbConnection1;
            this.datCfo.SelectCommand.ExecuteNonQuery();
            datCfo.Fill(CFO);
            this.fbConnection1.Close();
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsCfo, "CFO"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsCfo, "CFO"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsCfo, "CFO"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsCfo, "CFO"].Position = 100000;
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            this.datCfo.DeleteCommand.CommandText =
                "DELETE FROM CFO WHERE COD_SISTEMA_CFO = '" + tb_cod.Text + "'";
            this.fbConnection1.Open();
            this.datCfo.DeleteCommand.Connection = fbConnection1;
            this.datCfo.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            dsCfo.Clear();
            this.datCfo.SelectCommand.CommandText =
                "SELECT * FROM CFO";
            this.fbConnection1.Open();
            this.datCfo.SelectCommand.Connection = fbConnection1;
            this.datCfo.SelectCommand.ExecuteNonQuery();
            datCfo.Fill(CFO);
            this.fbConnection1.Close();
            
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsCfo, "CFO"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsCfo.HasChanges())
            {
                datCfo.UpdateCommand = cbCfo.GetUpdateCommand();
                datCfo.InsertCommand = cbCfo.GetInsertCommand();
                datCfo.DeleteCommand = cbCfo.GetDeleteCommand();
                datCfo.Update(dsCfo, "CFO");
                dsCfo.AcceptChanges();
            }
            fbConnection1.Close();
        }
    }
}