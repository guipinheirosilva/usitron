using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_maquinas_old : Form
    {
        public form_maquinas_old()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsMaquinas, "MAQUINAS"].AddNew();
            tb_maquina.Focus();
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
            datMaquinas.Fill(MAQUINAS);
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsMaquinas, "MAQUINAS"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsMaquinas, "MAQUINAS"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsMaquinas, "MAQUINAS"].Position = 100000;
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsMaquinas, "MAQUINAS"].Position = 0;
        }

    }
}