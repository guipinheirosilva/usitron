using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_verifica_rota_sem_semana : Form
    {
        public form_verifica_rota_sem_semana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvRotas.RowCount - 1; i++)
            {
                
                    this.datHoras_semana.UpdateCommand.CommandText =
                       "UPDATE HORAS_SEMANA SET OK_ROTA = 1 " +
                       " WHERE ROTA_HORAS_SEMANA = '" + dgvRotas.Rows[i].Cells["col_cod_rota"].Value.ToString() +
                       "' AND HORAS_OPERACAO_SEMANA != 0";
                    this.fbConnection1.Open();
                    this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                    //this.datSemanas.UpdateCommand.ExecuteNonQuery();
                    int registros = datHoras_semana.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    if (registros > 0)
                        dgvRotas.Rows[i].Cells["col_inserido_semana"].Value = "1";


                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsRotas_campo, "ROTAS_CAMPO"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsRotas_campo.HasChanges())
            {
                //MessageBox.Show("chegou aqui");
                datRotas_campo.UpdateCommand = cbRotas.GetUpdateCommand();
                datRotas_campo.InsertCommand = cbRotas.GetInsertCommand();
                datRotas_campo.DeleteCommand = cbRotas.GetDeleteCommand();
                datRotas_campo.Update(dsRotas_campo, "ROTAS_CAMPO");
                dsRotas_campo.AcceptChanges();
            }
            fbConnection1.Close(); 
        }

        private void form_verifica_rota_sem_semana_Load(object sender, EventArgs e)
        {
            datRotas_campo.Fill(ROTAS_CAMPO);
            datHoras_semana.Fill(HORAS_SEMANA);
        }
    }
}