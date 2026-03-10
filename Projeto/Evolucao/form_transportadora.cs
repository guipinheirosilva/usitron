using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_transportadora : Form
    {
        public form_transportadora()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            try
            {
                this.datTransportadoras.InsertCommand.CommandText =
                    "INSERT INTO TRANSPORTADORAS (NOME_TRANSPORTADORA)" +
                    "VALUES ('nova') returning cod_transportadora";
                this.fbConnection1.Open();
                this.datTransportadoras.InsertCommand.Connection = fbConnection1;

                object cod = datTransportadoras.InsertCommand.ExecuteScalar();
                this.fbConnection1.Close();

                dsTransportadoras.Clear();
                this.datTransportadoras.SelectCommand.CommandText =
                    "SELECT * FROM TRANSPORTADORAS where cod_transportadora = '" + cod.ToString() + "'";
                this.fbConnection1.Open();
                this.datTransportadoras.SelectCommand.Connection = fbConnection1;
                //this.datTransportadoras.SelectCommand.ExecuteNonQuery();
                datTransportadoras.Fill(TRANSPORTADORAS);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            //this.BindingContext[dsTransportadoras, "TRANSPORTADORAS"].Position = 100000;
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTransportadoras, "TRANSPORTADORAS"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTransportadoras, "TRANSPORTADORAS"].Position--; ;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTransportadoras, "TRANSPORTADORAS"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTransportadoras, "TRANSPORTADORAS"].Position = 100000;
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                try
                {

                    this.datTransportadoras.DeleteCommand.CommandText =
                        "DELETE FROM TRANSPORTADORAS WHERE COD_TRANSPORTADORA = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datTransportadoras.DeleteCommand.Connection = fbConnection1;
                    this.datTransportadoras.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsTransportadoras.Clear();
                    this.datTransportadoras.SelectCommand.CommandText =
                        "SELECT * FROM TRANSPORTADORAS";
                    this.fbConnection1.Open();
                    this.datTransportadoras.SelectCommand.Connection = fbConnection1;
                    this.datTransportadoras.SelectCommand.ExecuteNonQuery();
                    datTransportadoras.Fill(TRANSPORTADORAS);
                    this.fbConnection1.Close();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsTransportadoras, "TRANSPORTADORAS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsTransportadoras.HasChanges())
            {
                datTransportadoras.UpdateCommand = cbTransportadoras.GetUpdateCommand();
                datTransportadoras.InsertCommand = cbTransportadoras.GetInsertCommand();
                datTransportadoras.DeleteCommand = cbTransportadoras.GetDeleteCommand();
                datTransportadoras.Update(dsTransportadoras, "TRANSPORTADORAS");
                dsTransportadoras.AcceptChanges();
            }
            fbConnection1.Close(); 
        }

        private void form_transportadora_Load(object sender, EventArgs e)
        {
            datTransportadoras.Fill(TRANSPORTADORAS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_localiza_transportadora t = new form_localiza_transportadora();
            try
            {
                t.ShowDialog();
            }
            finally
            {
                localizar_transportadora(t.cod_transportadora_escolhida);
            }
           
        }

        private void localizar_transportadora(string cod)
        {
            try
            {
                if (cod != "")
                {
                    dsTransportadoras.Clear();
                    this.datTransportadoras.SelectCommand.CommandText =
                      "SELECT * FROM TRANSPORTADORAS where cod_transportadora = '" + cod + "'";
                    this.fbConnection1.Open();
                    this.datTransportadoras.SelectCommand.Connection = fbConnection1;
                    this.datTransportadoras.SelectCommand.ExecuteNonQuery();
                    datTransportadoras.Fill(TRANSPORTADORAS);
                    this.fbConnection1.Close();
                }
            }
            catch (Exception a)
            {

                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

    }
}