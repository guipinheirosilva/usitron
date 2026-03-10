using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tipos_refugo : Form
    {
        public form_tipos_refugo()
        {
            InitializeComponent();
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposderefugo, "TIPOS_REFUGO"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposderefugo, "TIPOS_REFUGO"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposderefugo, "TIPOS_REFUGO"].Position++;
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposderefugo, "TIPOS_REFUGO"].AddNew();
            textbox_cod_refugo.Focus();
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            this.BindingContext[dsTiposderefugo, "TIPOS_REFUGO"].EndCurrentEdit();
            if (dsTiposderefugo.HasChanges())
            {
                fbConnection1.Open();
                datTipoderefugo.UpdateCommand = fbCommandBuilder1.GetUpdateCommand(); // o problema está cin esse comando pra passar o dscliente para a tabela clientes
                datTipoderefugo.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                datTipoderefugo.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                datTipoderefugo.Update(dsTiposderefugo, "TIPOS_REFUGO");
                dsTiposderefugo.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void form_tipos_refugo_Load(object sender, EventArgs e)
        {
            datTipoderefugo.Fill(TIPOS_REFUGO);
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposderefugo, "TIPOS_REFUGO"].Position = 10000000;
        }
    }
}