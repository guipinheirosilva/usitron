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
    public partial class form_nova_despesa : Form
    {
        public string os_corrente;
        public bool modificado;
        public form_nova_despesa()
        {
            InitializeComponent();
        }

        private void form_nova_despesa_Load(object sender, EventArgs e)
        {
            tb_molde.Text = os_corrente;
            this.datDespesas_molde.SelectCommand.CommandText =
                        "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + os_corrente + "'";
            this.fbConnection1.Open();
            this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
            this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datDespesas_molde.Fill(DESPESAS_MOLDE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_valor.Text == "")
            {
                MessageBox.Show("Digite o valor por favor");
            }
            else
            {
                if (tb_forn.Text == "")
                {
                    MessageBox.Show("Digite o fornecedor por favor");
                }
                else
                {
                    if (tb_obs.Text == "")
                    {
                        MessageBox.Show("Digite as observações por favor");
                    }
                    else
                    {
                        this.datDespesas_molde.InsertCommand.CommandText =
                        "INSERT INTO DESPESAS_MOLDE (VALOR_DESPESA, FORNECEDOR_DESPESA, OBS_DESPESA, OS_DESPESA, DESPESA_MANUAL)" +
                        "VALUES ('" + tb_valor.Text.Replace(",", ".") + "','" + tb_forn.Text + "','" + tb_obs.Text + "','" + os_corrente + "', '1')";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.InsertCommand.Connection = fbConnection1;
                        this.datDespesas_molde.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        
                        dsDespesas_molde.Clear();
                        this.datDespesas_molde.SelectCommand.CommandText =
                        "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + os_corrente + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
                        this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        datDespesas_molde.Fill(DESPESAS_MOLDE);
                        modificado = true;

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                excluir(dgvPgtos.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecione a linha inteira por favor");
                fbConnection1.Close();
            }
        }

        private void excluir(string cod)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                    "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {


                        this.datDespesas_molde.DeleteCommand.CommandText =
                        "DELETE FROM DESPESAS_MOLDE WHERE COD_DESPESA = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.DeleteCommand.Connection = fbConnection1;
                        this.datDespesas_molde.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        dsDespesas_molde.Clear();
                        this.datDespesas_molde.SelectCommand.CommandText =
                        "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + os_corrente + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
                        this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        datDespesas_molde.Fill(DESPESAS_MOLDE);
                        modificado = true;


                    }
                    catch
                    {
                        MessageBox.Show("Selecione a linha inteira por favor");
                        fbConnection1.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                alterar(dgvPgtos.SelectedRows[0].Cells[0].Value.ToString(), dgvPgtos.SelectedRows[0].Cells[3].Value.ToString(),
                    dgvPgtos.SelectedRows[0].Cells[1].Value.ToString(), dgvPgtos.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecione a linha inteira por favor");
                fbConnection1.Close();
            }
        }

        private void alterar(string cod, string valor, string forn, string obs)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será alterado, tem certeza?",
                    "Confirma a alteração?", MessageBoxButtons.YesNo))
                {
                    try
                    {


                        this.datDespesas_molde.UpdateCommand.CommandText =
                        "UPDATE DESPESAS_MOLDE SET VALOR_DESPESA = '" + valor.Replace(",",".") +  "' WHERE COD_DESPESA = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.UpdateCommand.Connection = fbConnection1;
                        this.datDespesas_molde.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datDespesas_molde.UpdateCommand.CommandText =
                        "UPDATE DESPESAS_MOLDE SET FORNECEDOR_DESPESA = '" + forn + "' WHERE COD_DESPESA = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.UpdateCommand.Connection = fbConnection1;
                        this.datDespesas_molde.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datDespesas_molde.UpdateCommand.CommandText =
                        "UPDATE DESPESAS_MOLDE SET OBS_DESPESA = '" + obs + "' WHERE COD_DESPESA = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.UpdateCommand.Connection = fbConnection1;
                        this.datDespesas_molde.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        dsDespesas_molde.Clear();
                        this.datDespesas_molde.SelectCommand.CommandText =
                        "SELECT * FROM DESPESAS_MOLDE WHERE OS_DESPESA = '" + os_corrente + "'";
                        this.fbConnection1.Open();
                        this.datDespesas_molde.SelectCommand.Connection = fbConnection1;
                        this.datDespesas_molde.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        datDespesas_molde.Fill(DESPESAS_MOLDE);
                        modificado = true;


                    }
                    catch
                    {
                        MessageBox.Show("Selecione a linha inteira por favor");
                        fbConnection1.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }

        }
    }
}