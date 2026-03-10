using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_fornecedores : Form
    {
        int novox = 0;
        string area_atual;

        bool modif;
        string forn_escolhido;

        public form_fornecedores(bool modif, string forn_escolhido)
        {
            InitializeComponent();
            this.forn_escolhido = forn_escolhido;
            this.modif = modif;
        }

        private void form_fornecedores_Load(object sender, EventArgs e)
        {
            this.datForn.DeleteCommand.CommandText =
                        "DELETE FROM FORNECEDORES WHERE RAZAO_SOCIAL_FORN = 'novo'";
            this.fbConnection1.Open();
            this.datForn.DeleteCommand.Connection = fbConnection1;
            this.datForn.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datForn.Fill(FORNECEDORES);
            datArea.Fill(AREA_ATUACAO_FORN);
            
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            try
            {
                this.datForn.DeleteCommand.CommandText =
                "DELETE FROM FORNECEDORES WHERE RAZAO_SOCIAL_FORN = 'novo'";
                this.fbConnection1.Open();
                this.datForn.DeleteCommand.Connection = fbConnection1;
                this.datForn.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datForn.InsertCommand.CommandText =
                    "INSERT INTO FORNECEDORES(RAZAO_SOCIAL_FORN) VALUES('novo')";
                this.fbConnection1.Open();
                this.datForn.InsertCommand.Connection = fbConnection1;
                this.datForn.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                
                dsForn.Clear();
                try
                {
                    this.datForn.SelectCommand.CommandText =
                    "SELECT * FROM FORNECEDORES WHERE RAZAO_SOCIAL_FORN = 'novo'";
                    this.fbConnection1.Open();
                    this.datForn.SelectCommand.Connection = fbConnection1;
                    this.datForn.SelectCommand.ExecuteNonQuery();
                    datForn.Fill(FORNECEDORES);
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                }

                razao.Focus();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                this.datForn.DeleteCommand.CommandText =
                "DELETE FROM FORNECEDORES WHERE COD_FORN = '" + codigo.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            localizar();
        }

        private void localizar()
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
                try
                {
                    this.datForn.SelectCommand.CommandText =
                    "SELECT * FROM FORNECEDORES WHERE COD_FORN = '" + localiza_forn.forn_escolhido + "'";
                    this.fbConnection1.Open();
                    this.datForn.SelectCommand.Connection = fbConnection1;
                    this.datForn.SelectCommand.ExecuteNonQuery();
                    datForn.Fill(FORNECEDORES);
                    this.fbConnection1.Close();
                    selecionar_contatos();
                }
                catch
                {
                    fbConnection1.Close();
                }

            }

        }

        private void cbIso_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIso.Checked == false)
                tb_validade_iso.Text = "";
        }

        private void tb_area1_MouseClick(object sender, MouseEventArgs e)
        {
            localiza();
            tb_area1.Text = area_atual;
        }
        
        private void localiza()
        {
            form_localiza_area_forn localiza_area = new form_localiza_area_forn();
            try
            {
                localiza_area.ShowDialog();
            }
            finally
            {
                area_atual = localiza_area.descricao_escolhida;
                localiza_area.Dispose();
            

            }
            
        
        }

        private void tb_area3_MouseClick(object sender, MouseEventArgs e)
        {
            localiza();
            tb_area3.Text = area_atual;
        }

        private void tb_area2_MouseClick(object sender, MouseEventArgs e)
        {
            localiza();
            tb_area2.Text = area_atual;
        }

        private void tb_area4_MouseClick(object sender, MouseEventArgs e)
        {
            localiza();
            tb_area4.Text = area_atual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nome_contato.Text == "")
            {
                MessageBox.Show("Digite ao menos o nome, por favor");
            }
            else
            {
                string _nome = "", _email = "", _tel_1 = "", _tel_2 = "", _tipo = "";
                if (tb_nome_contato.Text == "")
                {
                    _nome = "null";
                }
                else
                {
                    _nome = "'" + tb_nome_contato.Text + "'";
                }
                if (tb_email.Text == "")
                {
                    _email = "null";
                }
                else
                {
                    _email = "'" + tb_email.Text + "'";
                }
                if (tb_telefone_1.Text == "")
                {
                    _tel_1 = "null";
                }
                else
                {
                    _tel_1 = "'" + tb_telefone_1.Text + "'";
                }
                if (tb_telefone_2.Text == "")
                {
                    _tel_2 = "null";
                }
                else
                {
                    _tel_2 = "'" + tb_telefone_2.Text + "'";
                }
                if (tb_tipo.Text == "")
                {
                    _tipo = "null";
                }
                else
                {
                    _tipo = "'" + tb_tipo.Text + "'";
                }



                try
                {
                    // colocar os campos corretamente para inserir o contato, depois acertar a busca do contato no envio do email
                    this.datContatos.InsertCommand.CommandText =
                           "INSERT INTO CONTATOS(NOME_CONTATO, EMAIL_CONTATO, TEL_1_CONTATO, TEL_2_CONTATO, CLIENTE_FORN_CONTATO, COD_CLIENTE_FORN_CONTATO, TIPO_CONTATO) VALUES(" + _nome + "," + _email + "," + _tel_1 + "," + _tel_2 + "," + "'FORN'" + "," + codigo.Text + "," + _tipo + ")";
                    this.fbConnection1.Open();
                    this.datContatos.InsertCommand.Connection = fbConnection1;
                    this.datContatos.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    selecionar_contatos();
                    tb_nome_contato.Text = "";
                    tb_telefone_1.Text = "";
                    tb_telefone_2.Text = "";
                    tb_tipo.Text = "";
                    tb_email.Text = "";
                }
                catch
                {
                    fbConnection1.Close();
                    MessageBox.Show("Erro na inserção do contato");
                }
            }

            
        }

        private void selecionar_contatos()
        {
            try
            {
                dsContatos.Clear();
                this.datContatos.SelectCommand.CommandText =
                        "SELECT * FROM CONTATOS WHERE COD_CLIENTE_FORN_CONTATO = '" + codigo.Text + "' AND CLIENTE_FORN_CONTATO = 'FORN'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            dsImprimir_op cli = new dsImprimir_op();
            fbConnection1.Open();
            //datTabela_impressao.Fill(dsRelatorio.TABELA_IMPRESSAO);
            datForn.Fill(cli.FORNECEDORES);
            datContatos.Fill(cli.CONTATOS);
            //datOperadores.Fill(dsRelatorio.OPERADORES);
            //datParadas.Fill(dsRelatorio.PARADAS);
            fbConnection1.Close();
            crForn op_nova = new crForn();
            op_nova.SetDataSource(cli);
            op_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            op_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            form_imprimir imprimir = new form_imprimir(op_nova);
            imprimir.Show();

        }

        

        
    }
}