using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tipo_ocorrencia : Form
    {
        public string ocorrencia_escolhida;
        public form_tipo_ocorrencia()
        {
            InitializeComponent();
        }

        private void form_tipo_ocorrencia_Load(object sender, EventArgs e)
        {
            datOcorrencias.Fill(TIPOS_OCORRENCIAS);
        }

        private void dgvOcorrencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ocorrencia_escolhida = dgvOcorrencias.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizar();
        }
        private void atualizar()
        {
            this.BindingContext[dsOcorrencias, "TIPOS_OCORRENCIAS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsOcorrencias.HasChanges())
            {
                datOcorrencias.UpdateCommand = cbOcorrencias.GetUpdateCommand();
                datOcorrencias.InsertCommand = cbOcorrencias.GetInsertCommand();
                datOcorrencias.DeleteCommand = cbOcorrencias.GetDeleteCommand();
                datOcorrencias.Update(dsOcorrencias, "TIPOS_OCORRENCIAS");
                dsOcorrencias.AcceptChanges();

            }
            fbConnection1.Close();
        }
    }
}