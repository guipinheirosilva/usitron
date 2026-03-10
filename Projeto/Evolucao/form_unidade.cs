using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_unidade : Form
    {
        public bool busca;
        public string cod, abreviacao, descricao;
        public form_unidade()
        {
            InitializeComponent();
        }

        private void form_unidade_Load(object sender, EventArgs e)
        {
            datUnidades.Fill(UNIDADES);
            dgvUnidades.AutoGenerateColumns = false;
            dgvUnidades.DataSource = dsUnidades.Tables["UNIDADES"];
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            dsUnidades.Tables["UNIDADES"].DefaultView.RowFilter = "ABREVIACAO_UNIDADE = '" + tb_descricao.Text + "'";
        }

        private void dgvUnidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                cod = dgvUnidades.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                abreviacao = dgvUnidades.Rows[e.RowIndex].Cells["col_abreviacao"].Value.ToString();
                descricao = dgvUnidades.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            try
            {
                this.BindingContext[dsUnidades, "UNIDADES"].EndCurrentEdit();
                if (dsUnidades.HasChanges())
                {
                    fbConnection1.Open();
                    datUnidades.UpdateCommand = cbUnidades.GetUpdateCommand();
                    datUnidades.InsertCommand = cbUnidades.GetInsertCommand();
                    datUnidades.DeleteCommand = cbUnidades.GetDeleteCommand();
                    datUnidades.Update(dsUnidades, "UNIDADES");
                    dsUnidades.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

    }
}