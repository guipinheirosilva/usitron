using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tipos_operacoes_old : Form
    {
        public form_tipos_operacoes_old()
        {
            InitializeComponent();
        }

        private void form__Load(object sender, EventArgs e)
        {
            datTiposdeoperacoes.Fill(TIPOS_OPERACOES);
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeoperacoes, "TIPOS_OPERACOES"].AddNew();
            tipo_operacao.Focus();
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            this.BindingContext[dsTiposdeoperacoes, "TIPOS_OPERACOES"].EndCurrentEdit();
            
            if (dsTiposdeoperacoes.HasChanges())
            {
                fbConnection1.Open();
                datTiposdeoperacoes.UpdateCommand = fbCommandBuilder1.GetUpdateCommand();
                datTiposdeoperacoes.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                datTiposdeoperacoes.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                datTiposdeoperacoes.Update(dsTiposdeoperacoes, "TIPOS_OPERACOES");
                dsTiposdeoperacoes.AcceptChanges();
                fbConnection1.Close(); 
            }
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeoperacoes, "TIPOS_OPERACOES"].Position--;
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeoperacoes, "TIPOS_OPERACOES"].Position = 0;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeoperacoes, "TIPOS_OPERACOES"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsTiposdeoperacoes, "TIPOS_OPERACOES"].Position = 10000000;
        }
    }
}