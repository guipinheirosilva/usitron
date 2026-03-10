using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_valor_operacao_os : Form
    {

        public string _os; 
        public form_valor_operacao_os()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_localiza_operacao abre = new form_localiza_operacao();
            try
            {
                //this.Close();
                abre.ShowDialog();

            }
            finally
            {
                abre.Dispose();
                inserir_operacoes(abre.numero_de_itens, abre.operacao_escolhida);
            }

        }

        private void selecionar_valores_operacao()
        {
            try
            {
                dsVoo.Clear();
                datVoo.SelectCommand.CommandText =
                    "SELECT * FROM VALOR_OPERACAO_OS WHERE OS_VOO = '" + _os + "'";
                datVoo.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datVoo.SelectCommand.ExecuteNonQuery();
                datVoo.Fill(VALOR_OPERACAO_OS);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_operacoes(int numero, string[,] nome)
        {

            for (int i = 0; i < numero; i++)
            {
                try
                {

                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "INSERT INTO VALOR_OPERACAO_OS (OPERACAO_VOO, OS_VOO)" +
                        "VALUES ('" + nome[i, 0] + "','" + _os + "')";
                    datVoo.InsertCommand = select;
                    datVoo.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
            selecionar_valores_operacao();

        }

        private void form_valor_operacao_os_Load(object sender, EventArgs e)
        {
            selecionar_valores_operacao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            this.BindingContext[dsVoo, "VALOR_OPERACAO_OS"].EndCurrentEdit();
            if (dsVoo.HasChanges())
            {
                try
                {
                    //MessageBox.Show("CHEGOU AQUI");
                    fbConnection1.Open();
                    datVoo.UpdateCommand = cbVoo.GetUpdateCommand();
                    datVoo.InsertCommand = cbVoo.GetInsertCommand();
                    datVoo.DeleteCommand = cbVoo.GetDeleteCommand();
                    datVoo.Update(dsVoo, "VALOR_OPERACAO_OS");
                    dsVoo.AcceptChanges();
                    fbConnection1.Close();
                }
                catch
                {
                    MessageBox.Show("Erro, tente novamente");
                    fbConnection1.Close();
                }
            }
        }


    }
}
