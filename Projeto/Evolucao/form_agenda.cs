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
    public partial class form_agenda : Form
    {
        public form_agenda()
        {
            InitializeComponent();
        }

        private void tb_criterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                string criterio = tb_criterio.Text;
                if (cb_campo.Text == "DATA")
                {
                    criterio = Convert.ToDateTime(criterio).ToShortDateString().Replace("/", ".");
                    dsAgenda_os.Clear();

                    this.datAgenda_os.SelectCommand.CommandText =
                    "SELECT * FROM AGENDA_OS WHERE " + cb_campo.Text + "_AGENDA_OS = '" + criterio + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
                    this.fbConnection1.Open();
                    this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                    this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                    datAgenda_os.Fill(AGENDA_OS);
                    this.fbConnection1.Close(); 
                }
                else
                {
                    criterio = "%" + criterio + "%";
                    dsAgenda_os.Clear();

                    this.datAgenda_os.SelectCommand.CommandText =
                    "SELECT * FROM AGENDA_OS WHERE UPPER(" + cb_campo.Text + "_AGENDA_OS) LIKE UPPER('" + criterio + "') ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
                    this.fbConnection1.Open();
                    this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                    this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                    datAgenda_os.Fill(AGENDA_OS);
                    this.fbConnection1.Close(); 
                }
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                excluir_agenda(dgvAgenda.SelectedRows[0].Cells["col_cod_agenda"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecione a linha inteira por favor");
                fbConnection1.Close(); 
            }
        }

        private void excluir_agenda(string cod)
        {
            FileInfo d = new FileInfo("c:\\evolucao\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                    "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {


                        this.datAgenda_os.DeleteCommand.CommandText =
                        "DELETE FROM AGENDA_OS WHERE COD_AGENDA_OS = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datAgenda_os.DeleteCommand.Connection = fbConnection1;
                        this.datAgenda_os.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        dsAgenda_os.Clear();
                        this.fbConnection1.Open();
                        this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                        this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                        datAgenda_os.Fill(AGENDA_OS);
                        this.fbConnection1.Close(); 


                    }
                    catch
                    {
                        MessageBox.Show("Selecione a linha inteira por favor");
                        fbConnection1.Close(); 
                    }

                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Atualizar();
            dsAgenda_os.Clear();

            this.fbConnection1.Open();
            this.datAgenda_os.SelectCommand.Connection = fbConnection1;
            this.datAgenda_os.SelectCommand.ExecuteNonQuery();
            datAgenda_os.Fill(AGENDA_OS);
            this.fbConnection1.Close(); 

        }

        private void Atualizar()
        {
            this.BindingContext[dsAgenda_os, "AGENDA_OS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsAgenda_os.HasChanges())
            {
                datAgenda_os.UpdateCommand = cbAgenda_os.GetUpdateCommand();
                datAgenda_os.InsertCommand = cbAgenda_os.GetInsertCommand();
                datAgenda_os.DeleteCommand = cbAgenda_os.GetDeleteCommand();
                datAgenda_os.Update(dsAgenda_os, "AGENDA_OS");
                dsAgenda_os.AcceptChanges();

            }
            fbConnection1.Close(); 

        }

        private void form_agenda_Load(object sender, EventArgs e)
        {
            dsAgenda_os.Clear();

            this.datAgenda_os.SelectCommand.CommandText =
            "SELECT * FROM AGENDA_OS ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
            this.fbConnection1.Open();
            this.datAgenda_os.SelectCommand.Connection = fbConnection1;
            this.datAgenda_os.SelectCommand.ExecuteNonQuery();
            datAgenda_os.Fill(AGENDA_OS);
            this.fbConnection1.Close(); 
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            dsAgenda imprime = new dsAgenda();
            fbConnection1.Open();
            datAgenda_os.Fill(imprime.AGENDA_OS);
            fbConnection1.Close(); 
            crAgenda agenda_nova = new crAgenda();
            agenda_nova.SetDataSource(imprime);
            form_imprimir imprimir = new form_imprimir(agenda_nova);
            imprimir.Show();
        }
    }
}