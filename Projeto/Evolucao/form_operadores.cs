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
    public partial class form_operadores : Form
    {
        public form_operadores()
        {
            InitializeComponent();
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOperadores, "OPERADORES"].Position++;
        }

        private void form_operadores_Load(object sender, EventArgs e)
        {
            
            datOperadores.Fill(OPERADORES);
            dsSalario_off.Clear();
             FileInfo d = new FileInfo("c:\\evolucao\\seg_rh.txt");
             if (d.Exists == true)
             {
                 this.datSalarios_off.SelectCommand.CommandText =
                         "SELECT * FROM SALARIO_OFF WHERE FUNCIONARIO_SAL_OFF = '" + textbox_cod.Text + "' order by cod_sal_off desc";
                 this.fbConnection1.Open();
                 this.datSalarios_off.SelectCommand.Connection = fbConnection1;
                 this.datSalarios_off.SelectCommand.ExecuteNonQuery();
                 this.fbConnection1.Close(); 
                 datSalarios_off.Fill(SALARIO_OFF);
             }
             else
             {
                 groupBoxRH.Visible = false;
                 //this.Size.Width = 404;
                 //this.Size.Height = 389;
             }
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOperadores, "OPERADORES"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOperadores, "OPERADORES"].Position--;
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOperadores, "OPERADORES"].AddNew();
            //Atualizar();
            textbox_cod.Focus();
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            this.BindingContext[dsOperadores, "OPERADORES"].EndCurrentEdit();
            if (dsOperadores.HasChanges())
            {
                //MessageBox.Show("chegou no atu _ op");
                fbConnection1.Open();
                datOperadores.UpdateCommand = fbCommandBuilder1.GetUpdateCommand(); // o problema está cin esse comando pra passar o dscliente para a tabela clientes
                datOperadores.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                datOperadores.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                datOperadores.Update(dsOperadores, "OPERADORES");
                dsOperadores.AcceptChanges();
                fbConnection1.Close(); 
            }
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_operador operador = new form_localiza_operador();
            try
            {
                operador.ShowDialog();
            }
            finally
            {
                try
                {
                    operador.Dispose();
                    dsOperadores.Clear();
                    this.datOperadores.SelectCommand.CommandText =
                    "SELECT * FROM OPERADORES WHERE COD_OPERADOR = '" + operador.operador_escolhido + "'";
                    this.fbConnection1.Open();
                    this.datOperadores.SelectCommand.Connection = fbConnection1;
                    this.datOperadores.SelectCommand.ExecuteNonQuery();
                    datOperadores.Fill(OPERADORES);
                    this.fbConnection1.Close(); 
                    dsSalario_off.Clear();
                    FileInfo d = new FileInfo("c:\\evolucao\\seg_rh.txt");
                    if (d.Exists == true)
                    {
                        this.datSalarios_off.SelectCommand.CommandText =
                                "SELECT * FROM SALARIO_OFF WHERE FUNCIONARIO_SAL_OFF = '" + textbox_cod.Text + "' order by cod_sal_off desc";
                        this.fbConnection1.Open();
                        this.datSalarios_off.SelectCommand.Connection = fbConnection1;
                        this.datSalarios_off.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        datSalarios_off.Fill(SALARIO_OFF);
                    }
                    else
                    {
                        groupBoxRH.Visible = false;
                    }
                }

                catch { }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_localiza_operador operador = new form_localiza_operador();
            try
            {
                operador.atualizar_arquivo = true;
                operador.ShowDialog();
            }
            finally
            {
                try
                {
                    operador.Dispose();
                    
                }

                catch { }


            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo criar um novo cadastro de salário?",
                "Confirma?", MessageBoxButtons.YesNo))
            {
                
                    this.datSalarios_off.InsertCommand.CommandText =
                           "INSERT INTO SALARIO_OFF (SALARIO_BASE_SAL_OFF, FUNCIONARIO_SAL_OFF)" +
                           "VALUES ('0.00', '" + textbox_cod.Text  + "')";
                    this.fbConnection1.Open();
                    this.datSalarios_off.InsertCommand.Connection = fbConnection1;
                    this.datSalarios_off.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 


                    this.datSalarios_off.SelectCommand.CommandText =
                    "SELECT * FROM SALARIO_OFF WHERE SALARIO_BASE_SAL_OFF = '0.00' AND FUNCIONARIO_SAL_OFF = '" + textbox_cod.Text + "' order by cod_sal_off desc";
                    this.fbConnection1.Open();
                    this.datSalarios_off.SelectCommand.Connection = fbConnection1;
                    this.datSalarios_off.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    datSalarios_off.Fill(SALARIO_OFF);

                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Atualizar_salario();
        }

        private void Atualizar_salario()
        {

            this.BindingContext[dsSalario_off, "SALARIO_OFF"].EndCurrentEdit();
            if (dsSalario_off.HasChanges())
            {
                fbConnection1.Open();
                datSalarios_off.UpdateCommand = cbSalario_off.GetUpdateCommand(); 
                datSalarios_off.InsertCommand = cbSalario_off.GetInsertCommand();
                datSalarios_off.DeleteCommand = cbSalario_off.GetDeleteCommand();
                datSalarios_off.Update(dsSalario_off, "SALARIO_OFF");
                dsSalario_off.AcceptChanges();
                fbConnection1.Close(); 
            }
        }

        private void tb_salario_base_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                decimal salario_hora = 0;
                if (tb_salario_base.Text != "")
                {
                    salario_hora = Convert.ToDecimal(tb_salario_base.Text)/220;
                    tb_salario_hora_base.Text = salario_hora.ToString();
                }
            }
        }

        private void tb_ref_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                decimal valor_salario = 0;
                if (tb_ref_salario.Text != "" && tb_salario_hora_base.Text != "")
                {
                    valor_salario = Convert.ToDecimal(tb_ref_salario.Text) * Convert.ToDecimal(tb_salario_hora_base.Text);
                    tb_valor_salario.Text = valor_salario.ToString();
                }
            }
        }

        private void tb_ref_dsr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                double variavel = 0;
                if (tb_ref_dsr.Text != "" && tb_salario_hora_base.Text != "")
                {
                    variavel = Convert.ToDouble(tb_ref_dsr.Text) * Convert.ToDouble(tb_salario_hora_base.Text);
                    tb_valor_dsr.Text = variavel.ToString();
                }
            }
        }

        private void selecionar_novamente()
        {
            string codigo = tb_cod_sal_off.Text;
            dsSalario_off.Clear();
            this.datSalarios_off.SelectCommand.CommandText =
                "SELECT * FROM SALARIO_OFF WHERE COD_SAL_OFF = '" + codigo + "'";
            this.fbConnection1.Open();
            this.datSalarios_off.SelectCommand.Connection = fbConnection1;
            this.datSalarios_off.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            datSalarios_off.Fill(SALARIO_OFF);

        }

        private void tb_ref_50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_ref_50.Text == "0")
                {
                    Atualizar_salario();
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET HORAS_EXTRA_50_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET EXTRA_50_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    selecionar_novamente();
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    double variavel = 0;
                    if (tb_ref_50.Text != "" && tb_salario_hora_base.Text != "")
                    {
                        variavel = (Convert.ToDouble(tb_salario_hora_base.Text) * 1.5) * Convert.ToDouble(tb_ref_50.Text);
                        tb_valor_50.Text = variavel.ToString();
                    }
                }
            }
        }

        private void tb_ref_60_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_ref_60.Text == "0")
                {
                    Atualizar_salario();
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET HORAS_EXTRA_60_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET EXTRA_60_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    selecionar_novamente();
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    double variavel = 0;
                    if (tb_ref_60.Text != "" && tb_salario_hora_base.Text != "")
                    {
                        variavel = Convert.ToDouble(tb_ref_60.Text) * Convert.ToDouble(tb_salario_hora_base.Text) * 1.6;
                        tb_valor_60.Text = variavel.ToString();
                    }
                }
            }
        }

        private void tb_ref_80_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_ref_80.Text == "0")
                {
                    Atualizar_salario();
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET HORAS_EXTRA_80_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET EXTRA_80_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    selecionar_novamente();
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    double variavel = 0;
                    if (tb_ref_80.Text != "" && tb_salario_hora_base.Text != "")
                    {
                        variavel = Convert.ToDouble(tb_ref_80.Text) * Convert.ToDouble(tb_salario_hora_base.Text) * 1.8;
                        tb_valor_80.Text = variavel.ToString();
                    }
                }
            }
        }

        private void tb_ref_100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_ref_100.Text == "0")
                {
                    Atualizar_salario();
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET HORAS_EXTRA_100_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET EXTRA_100_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    selecionar_novamente();
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    double variavel = 0;
                    if (tb_ref_100.Text != "" && tb_salario_hora_base.Text != "")
                    {
                        variavel = Convert.ToDouble(tb_ref_100.Text) * Convert.ToDouble(tb_salario_hora_base.Text) * 2;
                        tb_valor_100.Text = variavel.ToString();
                    }
                }
            }
        }

        private void tb_ref_noturno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_ref_noturno.Text == "0")
                {
                    Atualizar_salario();
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET HORAS_AD_NOTURNO_35_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET AD_NOTURNO_35_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    selecionar_novamente();
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    double variavel = 0;
                    double variavel_2 = 0.35;
                    if (tb_ref_noturno.Text != "" && tb_salario_hora_base.Text != "")
                    {
                        variavel = Convert.ToDouble(tb_ref_noturno.Text) * Convert.ToDouble(tb_salario_hora_base.Text) * variavel_2;
                        tb_valor_noturno.Text = variavel.ToString();
                    }
                }
            }
        }

        private void tb_ref_vale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_ref_vale.Text == "0")
                {
                    Atualizar_salario();
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET VALE_TRANSPORTE_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                   "UPDATE SALARIO_OFF SET QTDE_VALE_TRANSPORTE_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    selecionar_novamente();
                }
            }
        }

        private void tb_ref_outros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_ref_outros.Text == "0")
                {
                    Atualizar_salario();
                    this.datSalarios_off.UpdateCommand.CommandText =
                    "UPDATE SALARIO_OFF SET HORAS_OUTROS_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                   "UPDATE SALARIO_OFF SET OUTROS_VENC_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    this.datSalarios_off.UpdateCommand.CommandText =
                   "UPDATE SALARIO_OFF SET REF_EXCECAO_SAL_OFF = null WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                    this.fbConnection1.Open();
                    this.datSalarios_off.UpdateCommand.Connection = fbConnection1;
                    this.datSalarios_off.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    selecionar_novamente();
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    double variavel = 0;
                    if (tb_ref_excecao.Text != "" || tb_ref_excecao.Text == "0")
                    {
                        variavel = Convert.ToDouble(tb_ref_outros.Text) * Convert.ToDouble(tb_ref_excecao.Text);
                        tb_valor_outros.Text = variavel.ToString();
                    }
                    else
                    {

                        if (tb_ref_outros.Text != "" && tb_salario_hora_base.Text != "")
                        {
                            variavel = Convert.ToDouble(tb_ref_outros.Text) * Convert.ToDouble(tb_salario_hora_base.Text);
                            tb_valor_outros.Text = variavel.ToString();
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //calculando vencimentos
            double salario, dsr, extra_50, extra_60, extra_80, extra_100, ad_noturno, outros, vale_transporte;
            double extra_50_ref, extra_60_ref, extra_80_ref, extra_100_ref;
            try
            {
                salario = Convert.ToDouble(tb_valor_salario.Text);

            }
            catch
            {
                salario = 0;
            }
            try
            {
                dsr = Convert.ToDouble(tb_valor_dsr.Text);
            }
            catch
            {
                dsr = 0;
            }
            try
            {
                extra_50 = Convert.ToDouble(tb_valor_50.Text);
                extra_50_ref = Convert.ToDouble(tb_ref_50.Text);
            }
            catch
            {
                extra_50 = 0;
                extra_50_ref = 0;
            }
            try
            {
                extra_60 = Convert.ToDouble(tb_valor_60.Text);
                extra_60_ref = Convert.ToDouble(tb_ref_60.Text);
            }
            catch
            {
                extra_60 = 0;
                extra_60_ref = 0;
            }
            try
            {
                extra_80 = Convert.ToDouble(tb_valor_80.Text);
                extra_80_ref = Convert.ToDouble(tb_ref_80.Text);
            }
            catch
            {
                extra_80 = 0;
                extra_80_ref = 0;
            }
            try
            {
                extra_100 = Convert.ToDouble(tb_valor_100.Text);
                extra_100_ref = Convert.ToDouble(tb_ref_100.Text);
            }
            catch
            {
                extra_100 = 0;
                extra_100_ref = 0;
            }
            try
            {
                ad_noturno = Convert.ToDouble(tb_valor_noturno.Text);
            }
            catch
            {
                ad_noturno = 0;
            }
            try
            {
                vale_transporte = Convert.ToDouble(tb_valor_vale.Text);
            }
            catch
            {
                vale_transporte = 0;
            }
            try
            {
                outros = Convert.ToDouble(tb_valor_outros.Text);
            }
            catch
            {
                outros = 0;
            }
            double total_vencimentos = salario + dsr + extra_50 + extra_60 + extra_80 + extra_100 + ad_noturno + vale_transporte + outros;
            tb_total_venc.Text = total_vencimentos.ToString();
            double total_hora_extra = extra_60_ref + extra_50_ref + extra_80_ref + extra_100_ref;
            tb_total_horas_extras.Text = total_hora_extra.ToString("n2");
            //calculando descontos
            double adiantamento, vale_transporte_desc, refeicao, lanche, outros_desc;
            try
            {
                adiantamento = Convert.ToDouble(tb_adiantamento.Text);
            }
            catch
            {
                adiantamento = 0;
            }
            try
            {
                vale_transporte_desc = Convert.ToDouble(tb_vale_desc.Text);
            }
            catch
            {
                vale_transporte_desc = 0;
            }
            try
            {
                refeicao = Convert.ToDouble(tb_refeicao.Text);
            }
            catch
            {
                refeicao = 0;
            }
            try
            {
                lanche = Convert.ToDouble(tb_lanche.Text);
            }
            catch
            {
                lanche = 0;
            }
            try
            {
                outros_desc = Convert.ToDouble(tb_valor_outros_desc.Text);
            }
            catch
            {
                outros_desc = 0;
            }
            double total_descontos = adiantamento + vale_transporte_desc + refeicao + lanche + outros_desc;
            tb_total_descontos.Text = total_descontos.ToString();
            double total_liquido = total_vencimentos - total_descontos;
            tb_total_liquido.Text = total_liquido.ToString("n2");
            


        }

        private void tb_adiantamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                
            }
        }

        private void tb_vale_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void tb_refeicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void tb_lanche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void tb_valor_outros_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void tb_total_descontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void tb_total_liquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void tb_total_venc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            FileInfo d = new FileInfo("c:\\evolucao\\seg_rh.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        this.datOperadores.DeleteCommand.CommandText =
                            "DELETE FROM OPERADORES WHERE COD_OPERADOR = '" + textbox_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datOperadores.DeleteCommand.Connection = fbConnection1;
                        this.datOperadores.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datSalarios_off.DeleteCommand.CommandText =
                            "DELETE FROM SALARIO_OFF WHERE FUNCIONARIO_SAL_OFF = '" + textbox_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datSalarios_off.DeleteCommand.Connection = fbConnection1;
                        this.datSalarios_off.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        dsOperadores.Clear();
                        dsSalario_off.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Erro na exclusão");
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            form_periodo periodo = new form_periodo();
            try
            {
                periodo.ShowDialog();
            }
            finally 
            {
                tb_data_inicial.Text = Convert.ToDateTime(periodo.dia_inicial).ToShortDateString();
                tb_data_final.Text = Convert.ToDateTime(periodo.dia_final).ToShortDateString();
                periodo.Dispose();
            }
        }

        private void cbAdiantamento_CheckedChanged(object sender, EventArgs e)
        {
            double adiantamento = 0;
            double variavel = 0.4;
            try
            {
                adiantamento = Convert.ToDouble(tb_salario_base.Text) * variavel;
                
            }
            catch
            {
                adiantamento = 0;
            }
            tb_adiantamento.Text = adiantamento.ToString();
        }

        private void cbVale_transporte_CheckedChanged(object sender, EventArgs e)
        {
            double vale = 0;
            double variavel = 0.06;
            try
            {
                vale = Convert.ToDouble(tb_salario_base.Text) * variavel;
            }
            catch
            {
                vale = 0;
            }
            tb_vale_desc.Text = vale.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_periodo periodo = new form_periodo();
            try
            {
                periodo.ShowDialog();
            }
            finally
            {
                dsSalario_off.Clear();
                this.datSalarios_off.SelectCommand.CommandText =
                         "SELECT * FROM SALARIO_OFF WHERE FUNCIONARIO_SAL_OFF = '" + textbox_cod.Text + "' AND DATA_INICIAL_SAL_OFF = '" + Convert.ToDateTime(periodo.dia_inicial).ToShortDateString().Replace("/", ".") + "'" +
                         " AND DATA_FINAL_SAL_OFF = '" + Convert.ToDateTime(periodo.dia_final).ToShortDateString().Replace("/",".") + "' order by cod_sal_off desc";
                this.fbConnection1.Open();
                this.datSalarios_off.SelectCommand.Connection = fbConnection1;
                this.datSalarios_off.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
                datSalarios_off.Fill(SALARIO_OFF);
                periodo.Dispose();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo criar um novo cadastro de salário?",
                "Confirma?", MessageBoxButtons.YesNo))
            {
                
                this.datSalarios_off.InsertCommand.CommandText =
                       "INSERT INTO SALARIO_OFF(SALARIO_BASE_SAL_OFF, SALARIO_BASE_POR_HORA_SAL_OFF, FUNCIONARIO_SAL_OFF)" +
                    " SELECT SALARIO_BASE_SAL_OFF, SALARIO_BASE_POR_HORA_SAL_OFF, FUNCIONARIO_SAL_OFF FROM SALARIO_OFF" +
                    " WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                this.fbConnection1.Open();
                this.datSalarios_off.InsertCommand.Connection = fbConnection1;
                this.datSalarios_off.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 

                dsSalario_off.Clear();
                this.datSalarios_off.SelectCommand.CommandText =
                "SELECT * FROM SALARIO_OFF WHERE FUNCIONARIO_SAL_OFF = '" + textbox_cod.Text + "' order by cod_sal_off desc";
                this.fbConnection1.Open();
                this.datSalarios_off.SelectCommand.Connection = fbConnection1;
                this.datSalarios_off.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
                datSalarios_off.Fill(SALARIO_OFF);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.datSalarios_off.SelectCommand.CommandText =
                "SELECT * FROM SALARIO_OFF WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                this.fbConnection1.Open();
                this.datSalarios_off.SelectCommand.Connection = fbConnection1;
                this.datSalarios_off.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
                
                this.datPeriodos.SelectCommand.CommandText =
                 "SELECT * FROM PERIODOS WHERE DATA_INICIAL_PERIODO = '" + Convert.ToDateTime(tb_data_inicial.Text).ToShortDateString().Replace("/", ".") + "'" +
                         " AND DATA_FINAL_PERIODO = '" + Convert.ToDateTime(tb_data_final.Text).ToShortDateString().Replace("/", ".") + "'";
                this.fbConnection1.Open();
                this.datPeriodos.SelectCommand.Connection = fbConnection1;
                this.datPeriodos.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 

                this.datOperadores.SelectCommand.CommandText =
                    "SELECT * FROM OPERADORES WHERE COD_OPERADOR = '" + textbox_cod.Text + "'";
                this.fbConnection1.Open();
                this.datOperadores.SelectCommand.Connection = fbConnection1;
                this.datOperadores.SelectCommand.ExecuteNonQuery();
                datOperadores.Fill(OPERADORES);
                this.fbConnection1.Close(); 
                
                dsConsulta imprime = new dsConsulta();
                fbConnection1.Open();
                datSalarios_off.Fill(imprime.SALARIO_OFF);
                datPeriodos.Fill(imprime.PERIODOS);
                datOperadores.Fill(imprime.OPERADORES);
                fbConnection1.Close(); 
                EvolucaocrSalario_off salario_off = new EvolucaocrSalario_off();
                salario_off.SetDataSource(imprime);
                salario_off.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                salario_off.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(salario_off);
                imprimir.Show();

            }
            catch
            {
                fbConnection1.Close(); 
                MessageBox.Show("Erro na impressão");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FileInfo d = new FileInfo(@"c:\\evolucao\\seg_rh.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        this.datSalarios_off.DeleteCommand.CommandText =
                            "DELETE FROM SALARIO_OFF WHERE COD_SAL_OFF = '" + tb_cod_sal_off.Text + "'";
                        this.fbConnection1.Open();
                        this.datSalarios_off.DeleteCommand.Connection = fbConnection1;
                        this.datSalarios_off.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        //dsOperadores.Clear();
                        dsSalario_off.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Erro na exclusão");
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }

        }

        private void textbox_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                string operador = textbox_cod.Text;
                dsOperadores.Clear();
                this.datOperadores.SelectCommand.CommandText =
                "SELECT * FROM OPERADORES WHERE COD_OPERADOR = '" + operador + "'";
                this.fbConnection1.Open();
                this.datOperadores.SelectCommand.Connection = fbConnection1;
                this.datOperadores.SelectCommand.ExecuteNonQuery();
                datOperadores.Fill(OPERADORES);
                this.fbConnection1.Close(); 
                dsSalario_off.Clear();
                FileInfo d = new FileInfo("c:\\evolucao\\seg_rh.txt");
                if (d.Exists == true)
                {
                    this.datSalarios_off.SelectCommand.CommandText =
                            "SELECT * FROM SALARIO_OFF WHERE FUNCIONARIO_SAL_OFF = '" + textbox_cod.Text + "' order by cod_sal_off desc";
                    this.fbConnection1.Open();
                    this.datSalarios_off.SelectCommand.Connection = fbConnection1;
                    this.datSalarios_off.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    datSalarios_off.Fill(SALARIO_OFF);
                }
                else
                {
                    groupBoxRH.Visible = false;
                }
            }

           
        
        }
        

     

        

        

        
    }
}