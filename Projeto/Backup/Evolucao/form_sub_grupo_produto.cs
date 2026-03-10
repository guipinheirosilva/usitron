using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_sub_grupo_produto : Form
    {
        public bool busca;
        public string cod;
        public string descricao;
        public form_sub_grupo_produto()
        {
            InitializeComponent();
        }

        private void form_sub_grupo_produto_Load(object sender, EventArgs e)
        {
            datSub_grupos.Fill(SUB_GRUPOS);
            datGrupos.Fill(GRUPOS);
            dgvGrupos.AutoGenerateColumns = false;
            dgvGrupos.DataSource = dsSub_grupos.Tables["SUB_GRUPOS"];
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            dsSub_grupos.Tables["SUB_GRUPOS"].DefaultView.RowFilter = "descricao_sub_grupo = '" + tb_descricao.Text + "'";
        }

        private void dgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                cod = dgvGrupos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                descricao = dgvGrupos.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                this.Close();
            }
            else
            {
                form_grupo_produto grupo = new form_grupo_produto();
                try
                {
                    grupo.busca = true;
                    grupo.ShowDialog();

                }
                finally
                {
                    dgvGrupos.Rows[e.RowIndex].Cells["col_cod_grupo"].Value = grupo.cod;
                    dgvGrupos.Rows[e.RowIndex].Cells["col_descricao_grupo"].Value = grupo.descricao;
                }
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
                this.BindingContext[dsSub_grupos, "SUB_GRUPOS"].EndCurrentEdit();
                if (dsSub_grupos.HasChanges())
                {
                    fbConnection1.Open();
                    datSub_grupos.UpdateCommand = cbSub_grupos.GetUpdateCommand();
                    datSub_grupos.InsertCommand = cbSub_grupos.GetInsertCommand();
                    datSub_grupos.DeleteCommand = cbSub_grupos.GetDeleteCommand();
                    datSub_grupos.Update(dsSub_grupos, "SUB_GRUPOS");
                    dsSub_grupos.AcceptChanges();
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