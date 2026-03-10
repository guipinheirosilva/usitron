using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_nfs_referenciadas : Form
    {
        
        public string cod_sistema_nfent;
        public string n_nf_referenciada;
        public string chave_referenciada;
        public string cod_itens_nota_ent;
        
        public string cod_sistema_n_nf_saida;
        public string cod_itens_nota_saida;
        
        
        public form_nfs_referenciadas()
        {
            InitializeComponent();
        }

        private void form_nfs_referenciadas_Load(object sender, EventArgs e)
        {
            localizar();
            if (chave_referenciada != "" && chave_referenciada != null)
            {
                inserir();
                localizar();

            }
        }

        private void localizar()
        {
            try
            {
                dsNfs_referenciadas.Clear();
                datNfs_referenciadas.SelectCommand.CommandText =
                    "SELECT * FROM NFS_REFERENCIADAS WHERE COD_SISTEMA_NF_SAIDA_NFR = '" + cod_sistema_n_nf_saida + "'";
                datNfs_referenciadas.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datNfs_referenciadas.Fill(NFS_REFERENCIADAS);
                fbConnection1.Close();
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }

        }

        public void inserir()
        {
            try
            {

                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand insert = new FbCommand("INSERT INTO NFS_REFERENCIADAS " +
  "(COD_SISTEMA_NFENT_NFR, N_NF_NF_ENT_NFR, CHAVE_NFENT_NFR, COD_ITENS_NOTA_SAIDA_NFR, COD_ITENS_NOTA_ENT_NFR, COD_SISTEMA_NF_SAIDA_NFR) " +
  "VALUES(?, ?, ?, ?, ?, ?)", fbConnection1, trans);
                insert.Parameters.AddWithValue("COD_SISTEMA_NFENT_NFR", cod_sistema_nfent);
                insert.Parameters.AddWithValue("N_NF_NF_ENT_NFR", n_nf_referenciada);
                insert.Parameters.AddWithValue("CHAVE_NFENT_NFR", chave_referenciada);
                insert.Parameters.AddWithValue("COD_ITENS_NOTA_SAIDA_NFR", cod_itens_nota_saida);
                insert.Parameters.AddWithValue("COD_ITENS_NOTA_ENT_NFR", cod_itens_nota_ent);
                insert.Parameters.AddWithValue("COD_SISTEMA_NF_SAIDA_NFR", cod_sistema_n_nf_saida);
                fbConnection1.Open();
                datNfs_referenciadas.InsertCommand = insert;
                datNfs_referenciadas.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chave_referenciada = tb_chave.Text;
            n_nf_referenciada = Convert.ToInt32(chave_referenciada.Substring(25, 9)).ToString();
            inserir();
            localizar();

        }
    }
}
