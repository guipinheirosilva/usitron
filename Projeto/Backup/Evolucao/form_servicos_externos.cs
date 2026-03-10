using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Evolucao
{
    public partial class form_servicos_externos : Form
    {
        int novox;
        public form_servicos_externos()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            try
            {
                this.datForn.InsertCommand.CommandText =
                    "INSERT INTO FORNECEDORES(NOME_FORN) VALUES('novo')";
                this.fbConnection1.Open();
                this.datForn.InsertCommand.Connection = fbConnection1;
                this.datForn.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                dsForn.Clear();
                this.datForn.SelectCommand.CommandText =
                "SELECT * FROM FORNECEDORES WHERE NOME_FORN = 'novo' ORDER BY COD_FORN DESC";
                this.fbConnection1.Open();
                this.datForn.SelectCommand.Connection = fbConnection1;
                this.datForn.SelectCommand.ExecuteNonQuery();
                datForn.Fill(FORNECEDORES);
                this.fbConnection1.Close();
                
            }
            catch
            {
                MessageBox.Show("Erro validando...");
                this.datForn.InsertCommand.CommandText =
                    "INSERT INTO FORNECEDORES(NOME_FORN) VALUES('novo" + novox++ + "')";
                this.datForn.InsertCommand.Connection = fbConnection1;
                this.datForn.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datForn.Fill(FORNECEDORES);
                this.BindingContext[dsForn, "FORNECEDORES"].Position = 100000000;
                
            }
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    this.datForn.DeleteCommand.CommandText =
                    "DELETE FROM FORNECEDORES WHERE COD_FORN = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datForn.DeleteCommand.Connection = fbConnection1;
                    this.datForn.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsForn.Clear();
                    datForn.Fill(FORNECEDORES);
                    //Atualizar();
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        
        {
            this.BindingContext[dsForn, "FORNECEDORES"].EndCurrentEdit();
            if (dsForn.HasChanges())
            {
                fbConnection1.Open();
                datForn.UpdateCommand = fbCommandBuilder1.GetUpdateCommand(); // o problema está cin esse comando pra passar o dscliente para a tabela clientes
                datForn.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                datForn.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                datForn.Update(dsForn, "FORNECEDORES");
                dsForn.AcceptChanges();
                datForn.Fill(FORNECEDORES);
                fbConnection1.Close();
            }

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            form_localiza_forn localiza_forn = new form_localiza_forn(true);
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {
                localiza_forn.Dispose();
                dsForn.Clear();
                this.datForn.SelectCommand.CommandText =
                "SELECT * FROM FORNECEDORES WHERE COD_FORN = '" + localiza_forn.forn_escolhido + "'";
                this.fbConnection1.Open();
                this.datForn.SelectCommand.Connection = fbConnection1;
                this.datForn.SelectCommand.ExecuteNonQuery();
                datForn.Fill(FORNECEDORES);
                this.fbConnection1.Close();

                this.datRotas_campo.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE FORNECEDOR_SERVICO_EXTERNO = '" + tb_nome_forn.Text + "'";
                this.fbConnection1.Open();
                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();

            }
        }

        private void form_fornecedores_Load(object sender, EventArgs e)
        {

        }
        
    }
}