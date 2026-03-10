using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_usuario : Form
    {
        public string _cod_usuario = "", _senha = "", _nome_usuario = "", _nivel_acesso_usuario = "", _descricao_nivel_acesso_usuario = "";
        public bool confirmado = false;
        public form_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificar();    
        }

        private void verificar()
        {
            comando_select.CommandText = "SELECT * " +
                "FROM USUARIOS WHERE COD_USUARIO = '" + tb_usuario.Text + "'";
            DataSet usuario = new DataSet();
            fbConnection1.Open();
            datUsuarios.SelectCommand = comando_select;
            datUsuarios.Fill(usuario);
            
            foreach (DataRow dr in usuario.Tables[0].Rows)
            {
                _nome_usuario = dr["NOME_USUARIO"].ToString();
                _senha = dr["SENHA_USUARIO"].ToString();
                _cod_usuario = dr["COD_USUARIO"].ToString();
                _nivel_acesso_usuario = dr["NIVEL_ACESSO_USUARIO"].ToString();
                _descricao_nivel_acesso_usuario = dr["DESCRICAO_NIVEL_ACESSO_USUARIO"].ToString();

            }

            fbConnection1.Close();
            if (_cod_usuario != "")
            {
                if (_senha == tb_senha.Text)
                {
                    confirmado = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Senha incorreta");
            }
            else
            {
                MessageBox.Show("Usuário Inexistente");
            }


        }

        private void tb_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                verificar();
            }
        }
    }
}