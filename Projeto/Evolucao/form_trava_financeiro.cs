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
    public partial class form_trava_financeiro : Form
    {
        public form_trava_financeiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_cod_cc.Text != "")
                {
                    FbCommand insert = new FbCommand();
                    insert.Connection = fbConnection1;
                    insert.CommandText =
                        @"INSERT INTO TRAVA_FINANCEIRO (DATA_TF, DATA_TRAVAMENTO_TF, HORA_TRAVAMENTO_TF, COD_CC_TF, DESCRICAO_CC_TF, VALOR_TF) 
                        VALUES ('" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + @"',CURRENT_DATE, CURRENT_TIME,
                        " + tb_cod_cc.Text + ",'" + tb_descricao_cc.Text + "','" + 
                          Convert.ToDouble(tbValor.Text).ToString().Replace(".","").Replace(",",".") + "')";
                    fbConnection1.Open();
                    FbDataAdapter datInsert = new FbDataAdapter();
                    datInsert.InsertCommand = insert;
                    datInsert.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    selecionar_itens();
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void selecionar_itens()
        {
            try
            {
                dsTrava_financeiro.Clear();
                datTrava_financeiro.SelectCommand.CommandText =
                    "SELECT * FROM TRAVA_FINANCEIRO ORDER BY COD_TF DESC";
                datTrava_financeiro.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datTrava_financeiro.Fill(TRAVA_FINANCEIRO);
                fbConnection1.Close();
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void form_trava_financeiro_Load(object sender, EventArgs e)
        {
            selecionar_itens();
            dgvFechamento.AutoGenerateColumns = false;
            dgvFechamento.DataSource = dsTrava_financeiro.Tables["TRAVA_FINANCEIRO"];// dsCte.Tables["CTE"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_cc cc = new form_cc();
            try
            {
                cc.ShowDialog();

            }
            finally
            {
                tb_descricao_cc.Text = cc.descricao_escolhido;
                tb_cod_cc.Text = cc.cod_escolhido;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
             
        private void Atualizar()
        {
            try
            {
                this.BindingContext[dsTrava_financeiro, "TRAVA_FINANCEIRO"].EndCurrentEdit();
                if (dsTrava_financeiro.HasChanges())
                {
                    fbConnection1.Open();
                    datTrava_financeiro.UpdateCommand = cbTrava_financeiro.GetUpdateCommand();
                    datTrava_financeiro.InsertCommand = cbTrava_financeiro.GetInsertCommand();
                    datTrava_financeiro.DeleteCommand = cbTrava_financeiro.GetDeleteCommand();
                    datTrava_financeiro.Update(dsTrava_financeiro, "TRAVA_FINANCEIRO");
                    dsTrava_financeiro.AcceptChanges();
                    fbConnection1.Close();
                }
                MessageBox.Show("Salvo!");
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
