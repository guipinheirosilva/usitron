using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tipos_parada : Form
    {
        public form_tipos_parada()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeparada, "TIPOS_PARADA"].AddNew();
            textbox_cod_parada.Focus();
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsTiposdeparada, "TIPOS_PARADA"].EndCurrentEdit();
            if (dsTiposdeparada.HasChanges())
            {
                fbConnection1.Open();
                datTiposdeparada.UpdateCommand = fbCommandBuilder1.GetUpdateCommand(); // o problema está cin esse comando pra passar o dscliente para a tabela clientes
                datTiposdeparada.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                datTiposdeparada.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                datTiposdeparada.Update(dsTiposdeparada, "TIPOS_PARADA");
                dsTiposdeparada.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void form_tipos_parada_Load(object sender, EventArgs e)
        {
            datTiposdeparada.Fill(TIPOS_PARADA);
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeparada, "TIPOS_PARADA"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeparada, "TIPOS_PARADA"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeparada, "TIPOS_PARADA"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeparada, "TIPOS_PARADA"].Position = 1000000000;
        }
    }
}