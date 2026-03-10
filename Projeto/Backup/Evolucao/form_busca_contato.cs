using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_busca_contato : Form
    {
        public string cod_cli_forn, cli_forn;
        public string[,] valores = new string[100,3];
        public int qtde;
        public bool requisicao;
        public form_busca_contato()
        {
            InitializeComponent();
        }

        private void form_busca_contato_Load(object sender, EventArgs e)
        {
            try
            {
                dsContatos.Clear();
                this.datContatos.SelectCommand.CommandText =
                        "SELECT * FROM CONTATOS WHERE COD_CLIENTE_FORN_CONTATO = '" + cod_cli_forn + "' AND CLIENTE_FORN_CONTATO = '" + cli_forn + "'";
                this.fbConnection1.Open();
                this.datContatos.SelectCommand.Connection = fbConnection1;
                this.datContatos.SelectCommand.ExecuteNonQuery();
                datContatos.Fill(CONTATOS);
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvContatos.SelectedRows.Count; i++)
            {
               valores[i,0] = dgvContatos.SelectedRows[i].Cells["col_email"].Value.ToString();
               valores[i, 1] = dgvContatos.SelectedRows[i].Cells["col_nome"].Value.ToString();
               valores[i, 2] = dgvContatos.SelectedRows[i].Cells["col_tel"].Value.ToString();
            }
            qtde = dgvContatos.SelectedRows.Count;
            this.Close();
        }
    }
}