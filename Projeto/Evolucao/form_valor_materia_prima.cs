using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_valor_materia_prima : Form
    {
        public string descricao_escolhida;
        public string valor_escolhido;
        public string unidade_escolhida;

        public string[] _cod_escolhido = new string[100];
        public string[] _descricao_escolhida = new string[100];
        public string[] _valor_escolhido = new string[100];
        public string[] _unidade_escolhida = new string[100];
        public int numero_de_itens;

        public form_valor_materia_prima()
        {
            InitializeComponent();
        }

        private void form_valor_materia_prima_Load(object sender, EventArgs e)
        {
            dgvMateria_prima.AutoGenerateColumns = false;
            dgvMateria_prima.DataSource = dsMateria_prima.Tables["MATERIA_PRIMA"];
            datMateria_prima.Fill(MATERIA_PRIMA);
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            dsMateria_prima.Tables["MATERIA_PRIMA"].DefaultView.RowFilter = "DESCRICAO_MATERIA_PRIMA LIKE '*" + tb_descricao.Text +"*'";
        }

        private void dgvMateria_prima_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                descricao_escolhida = dgvMateria_prima.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                valor_escolhido = dgvMateria_prima.Rows[e.RowIndex].Cells["col_valor"].Value.ToString();
                unidade_escolhida = dgvMateria_prima.Rows[e.RowIndex].Cells["col_un"].Value.ToString();
                this.Close();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsMateria_prima, "MATERIA_PRIMA"].EndCurrentEdit();
            if (dsMateria_prima.HasChanges())
            {
                fbConnection1.Open();

                datMateria_prima.UpdateCommand = cbMateria_prima.GetUpdateCommand();
                datMateria_prima.InsertCommand = cbMateria_prima.GetInsertCommand();
                datMateria_prima.DeleteCommand = cbMateria_prima.GetDeleteCommand();
                datMateria_prima.Update(dsMateria_prima, "MATERIA_PRIMA");
                dsMateria_prima.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = dgvMateria_prima.SelectedRows.Count - 1; i >= 0; i--)
            {
                _cod_escolhido[i] = dgvMateria_prima.SelectedRows[j].Cells["col_cod"].Value.ToString();
                _descricao_escolhida[i] = dgvMateria_prima.SelectedRows[j].Cells["col_descricao"].Value.ToString();
                _valor_escolhido[i] = dgvMateria_prima.SelectedRows[j].Cells["col_valor"].Value.ToString();
                _unidade_escolhida[i] = dgvMateria_prima.SelectedRows[j].Cells["col_un"].Value.ToString();
                j++;
            }
            numero_de_itens = dgvMateria_prima.SelectedRows.Count;
            this.Close();
        }
    }
}