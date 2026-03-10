using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_maquinas : Form
    {
        public string maquina_escolhida;
        public string codMaquinaEscolhida;

        public form_maquinas()
        {
            InitializeComponent();
        }

        
        private void Atualizar()
        {
            this.BindingContext[dsMaquinas, "MAQUINAS"].EndCurrentEdit();

            if (dsMaquinas.HasChanges())
            {
                fbConnection1.Open();
                datMaquinas.UpdateCommand = cbMaquinas.GetUpdateCommand();
                datMaquinas.InsertCommand = cbMaquinas.GetInsertCommand();
                datMaquinas.DeleteCommand = cbMaquinas.GetDeleteCommand();
                datMaquinas.Update(dsMaquinas, "MAQUINAS");
                dsMaquinas.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void form_maquinas_Load(object sender, EventArgs e)
        {
            datMaquinas.SelectCommand.CommandText = "select * from maquinas order by cod_maquina";
            datMaquinas.SelectCommand.Connection = fbConnection1;
            fbConnection1.Open();
            datMaquinas.Fill(MAQUINAS);
            fbConnection1.Close();
            datSetores.SelectCommand.CommandText = "select * from setores";
            datSetores.SelectCommand.Connection = fbConnection1;
            fbConnection1.Open();
            datSetores.Fill(SETORES);
            fbConnection1.Close();
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void dgvMaquinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maquina_escolhida = dgvMaquinas.Rows[e.RowIndex].Cells["col_abreviacao"].Value.ToString();
            codMaquinaEscolhida = dgvMaquinas.Rows[e.RowIndex].Cells["codMaquina"].Value.ToString();
            this.Close();
        }

    /*    private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // form_maquinas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "form_maquinas";
            this.Load += new System.EventHandler(this.form_maquinas_Load_1);
            this.ResumeLayout(false);

        }

     */
        private void form_maquinas_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}