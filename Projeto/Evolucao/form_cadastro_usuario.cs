using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_cadastro_usuario : Form
    {
        public form_cadastro_usuario()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            try
            {
                dsUsuarios.Clear();
                this.datUsuarios.DeleteCommand.CommandText =
                "DELETE FROM USUARIOS WHERE NOME_USUARIO = 'novo'";
                this.fbConnection1.Open();
                this.datUsuarios.DeleteCommand.Connection = fbConnection1;
                this.datUsuarios.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datUsuarios.InsertCommand.CommandText =
                    "INSERT INTO USUARIOS(NOME_USUARIO, PCP_USUARIO, FATURAMENTO_USUARIO, ESTOQUE_USUARIO, COMPRAS_USUARIO, FINANCEIRO_USUARIO, ORCAMENTOS_USUARIO, QUALIDADE_USUARIO, TOTAL_USUARIO) " + 
                    "VALUES('novo',0,0,0,0,0,0,0,0)";
                this.fbConnection1.Open();
                this.datUsuarios.InsertCommand.Connection = fbConnection1;
                this.datUsuarios.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datUsuarios.SelectCommand.CommandText =
                "SELECT * FROM USUARIOS WHERE NOME_USUARIO = 'novo'";
                this.fbConnection1.Open();
                this.datUsuarios.SelectCommand.Connection = fbConnection1;
                this.datUsuarios.SelectCommand.ExecuteNonQuery();
                datUsuarios.Fill(USUARIOS);
                this.fbConnection1.Close();

            }
            catch
            {
                MessageBox.Show("Erro na Inserção");
                fbConnection1.Close();
            }

        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                this.datUsuarios.DeleteCommand.CommandText =
                "DELETE FROM USUARIOS WHERE COD_USUARIO = '" + tb_codigo.Text + "'";
                this.fbConnection1.Open();
                this.datUsuarios.DeleteCommand.Connection = fbConnection1;
                this.datUsuarios.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                dsUsuarios.Clear();
                
                
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
            MessageBox.Show("Salvo");
        }

        private void Atualizar()
        {
            this.BindingContext[dsUsuarios, "USUARIOS"].EndCurrentEdit();
            if (dsUsuarios.HasChanges())
            {
                fbConnection1.Open();
                datUsuarios.UpdateCommand = cbUsuarios.GetUpdateCommand(); 
                datUsuarios.InsertCommand = cbUsuarios.GetInsertCommand();
                datUsuarios.DeleteCommand = cbUsuarios.GetDeleteCommand();
                datUsuarios.Update(dsUsuarios, "USUARIOS");
                dsUsuarios.AcceptChanges();
                fbConnection1.Close();
                
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_usuario localiza_usuario = new form_localiza_usuario();
            try
            {
                localiza_usuario.ShowDialog();
            }
            finally
            {
                localiza_usuario.Dispose();
                dsUsuarios.Clear();
                this.datUsuarios.SelectCommand.CommandText =
                "SELECT * FROM USUARIOS WHERE COD_USUARIO = '" + localiza_usuario.usuario_escolhido + "'";
                this.fbConnection1.Open();
                this.datUsuarios.SelectCommand.Connection = fbConnection1;
                this.datUsuarios.SelectCommand.ExecuteNonQuery();
                datUsuarios.Fill(USUARIOS);
                this.fbConnection1.Close();

            }
        }
    }
}