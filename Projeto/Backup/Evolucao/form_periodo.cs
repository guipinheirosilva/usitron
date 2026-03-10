using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Evolucao
{
    public partial class form_periodo : Form
    {
        public string dia_inicial;
        public string dia_final;
        public form_periodo()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo criar um novo cadastro de salário?",
                "Confirma?", MessageBoxButtons.YesNo))
            {

                this.datPeriodos.InsertCommand.CommandText =
                       "INSERT INTO PERIODOS (DIAS_PERIODO)" +
                       "VALUES ('0')";
                this.fbConnection1.Open();
                this.datPeriodos.InsertCommand.Connection = fbConnection1;
                this.datPeriodos.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datPeriodos.SelectCommand.CommandText =
                "SELECT * FROM PERIODOS WHERE DIAS_PERIODO = '0' order by cod_periodo desc";
                this.fbConnection1.Open();
                this.datPeriodos.SelectCommand.Connection = fbConnection1;
                this.datPeriodos.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datPeriodos.Fill(PERIODOS);


            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsPeriodos, "PERIODOS"].EndCurrentEdit();
            if (dsPeriodos.HasChanges())
            {
                fbConnection1.Open();
                datPeriodos.UpdateCommand = cbPeriodos.GetUpdateCommand();
                datPeriodos.InsertCommand = cbPeriodos.GetInsertCommand();
                datPeriodos.DeleteCommand = cbPeriodos.GetDeleteCommand();
                datPeriodos.Update(dsPeriodos, "PERIODOS");
                dsPeriodos.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void form_periodo_Load(object sender, EventArgs e)
        {
            this.datPeriodos.SelectCommand.CommandText =
                "SELECT * FROM PERIODOS order by cod_periodo desc";
            this.fbConnection1.Open();
            this.datPeriodos.SelectCommand.Connection = fbConnection1;
            this.datPeriodos.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datPeriodos.Fill(PERIODOS);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dia_inicial = dtInicial.Text;
            dia_final = dtFinal.Text;
            this.Close();
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_rh.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        this.datPeriodos.DeleteCommand.CommandText =
                            "DELETE FROM PERIODOS WHERE COD_PERIODO = '" + textbox_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datPeriodos.DeleteCommand.Connection = fbConnection1;
                        this.datPeriodos.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        dsPeriodos.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Erro na exclusão");
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsPeriodos, "PERIODOS"].Position--;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsPeriodos, "PERIODOS"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsPeriodos, "PERIODOS"].Position = 0;
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsPeriodos, "PERIODOS"].Position = 10000000;
        }
    }
}