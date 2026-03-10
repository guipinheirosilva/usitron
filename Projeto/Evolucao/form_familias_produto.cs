using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_familias_produto : Form
    {
        public bool busca;
        public string cod;
        public string descricao;
        public string[,] familias = new string[2, 200];
        public int n_selecionados; 
        public form_familias_produto()
        {
            InitializeComponent();
        }

        private void form_grupo_produto_Load(object sender, EventArgs e)
        {
            datGrupos.Fill(FAMILIA_PRODUTO);
            dgvGrupos.AutoGenerateColumns = false;
            dgvGrupos.DataSource = dsGrupos.Tables["FAMILIA_PRODUTO"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dsGrupos.Tables["FAMILIA_PRODUTO"].DefaultView.RowFilter = "FAMILIA_FP LIKE '*" + tb_descricao.Text + "*'";
        }

        private void dgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                cod = dgvGrupos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                descricao = dgvGrupos.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
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
                this.BindingContext[dsGrupos, "FAMILIA_PRODUTO"].EndCurrentEdit();
                if (dsGrupos.HasChanges())
                {
                    fbConnection1.Open();
                    datGrupos.UpdateCommand = cbGrupos.GetUpdateCommand();
                    datGrupos.InsertCommand = cbGrupos.GetInsertCommand();
                    datGrupos.DeleteCommand = cbGrupos.GetDeleteCommand();
                    datGrupos.Update(dsGrupos, "FAMILIA_PRODUTO");
                    dsGrupos.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch
            {
                fbConnection1.Close(); 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n_selecionados = dgvGrupos.SelectedRows.Count;
            for (int i = 0; i < dgvGrupos.SelectedRows.Count; i++)
            {
                try
                {
                    familias[0, i] = dgvGrupos.SelectedRows[i].Cells[0].Value.ToString();
                    familias[1, i] = dgvGrupos.SelectedRows[i].Cells[1].Value.ToString();
                }
                catch { }
            }
            this.Close();
        }
    }
}