using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_versao : Form
    {
        public bool versao_incorreta;
        public bool verificar;
        public form_versao()
        {
            InitializeComponent();
        }

        private void form_versao_Load(object sender, EventArgs e)
        {
            datVersao.Fill(VERSAO);
            if (verificar == true)
            {
                string atual = tb_versao_atual.Text;
                if (atual[1].ToString() == ".")
                    MessageBox.Show("Por favor, vá em Configurações Regionais e "
                + "mude o Símbolo Regional para ','");
                else
                {
                    if (Convert.ToDouble(tb_versao_atual.Text) != Convert.ToDouble(tb_versao_sistema.Text))
                    {
                        MessageBox.Show("É necessária a atualização do Sistema");
                        versao_incorreta = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bem vindo ao Sistema de Apontamento");
                        this.Close();
                    }
                }
                
            }
        }

        private void tb_versao_sistema_TextChanged(object sender, EventArgs e)
        {

        }
    }
}