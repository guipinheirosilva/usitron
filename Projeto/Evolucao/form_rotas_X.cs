using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Evolucao
{
    public partial class form_rotas_X : Form
    {
        public string rota;
        public form_rotas_X()
        {
            InitializeComponent();
        }

        private void form_rotas_X_Load(object sender, EventArgs e)
        {
            selecionar();

        }

        private void selecionar()
        {
            try
            {
                datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + rota + "'";
                datRotas_campo.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                fbConnection1.Close();

                DataRow dr = ROTAS_CAMPO.Rows[0];
                try
                {
                    tb_hora_inicio.Text = Convert.ToDateTime(dr["HORA_ENTRADA"].ToString()).ToShortTimeString();
                }
                catch
                {
                }
                try
                {
                    tb_hora_fim.Text = Convert.ToDateTime(dr["HORA_FECHAMENTO"].ToString()).ToShortTimeString();
                }
                catch
                {
                }

                    

                datApontamentos.SelectCommand.CommandText =
                    "SELECT * FROM APONTAMENTOS WHERE ROTA_AP = '" + rota + "' ORDER BY COD_AP";
                datApontamentos.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datApontamentos.SelectCommand.ExecuteNonQuery();
                datApontamentos.Fill(APONTAMENTOS);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"c:/evolucao/terminal_x.exe");
            }
            finally
            {
                selecionar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recalcular_horas();
            dsApontamentos.Clear();
            dsRotas_campo.Clear();

            try
            {
                datRotas_campo.SelectCommand.CommandText =
                   "SELECT * FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + rota + "'";
                datRotas_campo.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                fbConnection1.Close();

                datApontamentos.SelectCommand.CommandText =
                    "SELECT * FROM APONTAMENTOS WHERE ROTA_AP = '" + rota + "' ORDER BY COD_AP";
                datApontamentos.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datApontamentos.SelectCommand.ExecuteNonQuery();
                datApontamentos.Fill(APONTAMENTOS);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void recalcular_horas()
        {
            
                try
                {
                    classeApontamentos apontamento = new classeApontamentos();
                    apontamento.fbConnection1.ConnectionString =
                        @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                    apontamento.calcular_horas(rotalabel.Text);
                }
                catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Salvar();
            recalcular_horas();
            selecionar();
            
        }

        private void Salvar()
        {
            try
            {
                this.BindingContext[dsRotas_campo, "ROTAS_CAMPO"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsRotas_campo.HasChanges())
                {
                    datRotas_campo.UpdateCommand = cbRotas_campo.GetUpdateCommand();
                    datRotas_campo.InsertCommand = cbRotas_campo.GetInsertCommand();
                    datRotas_campo.DeleteCommand = cbRotas_campo.GetDeleteCommand();
                    datRotas_campo.Update(dsRotas_campo, "ROTAS_CAMPO");
                    dsRotas_campo.AcceptChanges();

                }
                fbConnection1.Close();
                this.BindingContext[dsApontamentos, "APONTAMENTOS"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsApontamentos.HasChanges())
                {
                    datApontamentos.UpdateCommand = cbApontamentos.GetUpdateCommand();
                    datApontamentos.InsertCommand = cbApontamentos.GetInsertCommand();
                    datApontamentos.DeleteCommand = cbApontamentos.GetDeleteCommand();
                    datApontamentos.Update(dsApontamentos, "APONTAMENTOS");
                    dsApontamentos.AcceptChanges();
                }
                fbConnection1.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        
    }
}