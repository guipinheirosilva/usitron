using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_grupo_produto : Form
    {
        public bool busca;
        public string cod;
        public string descricao;
        public form_grupo_produto()
        {
            InitializeComponent();
        }

        private void form_grupo_produto_Load(object sender, EventArgs e)
        {
            datGrupos.Fill(GRUPOS);
            dgvGrupos.AutoGenerateColumns = false;
            dgvGrupos.DataSource = dsGrupos.Tables["GRUPOS"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dsGrupos.Tables["GRUPOS"].DefaultView.RowFilter = "descricao_grupo = '" + tb_descricao.Text + "'";
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
                this.BindingContext[dsGrupos, "GRUPOS"].EndCurrentEdit();
                if (dsGrupos.HasChanges())
                {
                    fbConnection1.Open();
                    datGrupos.UpdateCommand = cbGrupos.GetUpdateCommand();
                    datGrupos.InsertCommand = cbGrupos.GetInsertCommand();
                    datGrupos.DeleteCommand = cbGrupos.GetDeleteCommand();
                    datGrupos.Update(dsGrupos, "GRUPOS");
                    dsGrupos.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch
            {
                fbConnection1.Close(); 
            }

        }

        private void dgvGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrupos.Columns[e.ColumnIndex].Name == "col_operacoes")
            {
                form_grupos_operacoes metas = new form_grupos_operacoes();
                try
                {
                    metas.grupo = dgvGrupos.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                    //metas.cod_vendedor = dgvGrupos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    metas.Show();
                }
                finally
                {

                }
            }
        }
    }
}