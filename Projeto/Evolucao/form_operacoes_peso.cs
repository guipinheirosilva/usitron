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
    public partial class form_operacoes_peso : Form
    {
        public form_operacoes_peso()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_localiza_operacao operacao = new form_localiza_operacao();
            try
            {
                //this.Close();
                operacao.ShowDialog();

            }
            finally
            {
                operacao.Dispose();
                inserir_operacoes(operacao.numero_de_itens, operacao.operacao_escolhida);
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
                    "INSERT INTO VALOR_OPERACAO_PESO (OPERACAO_VALOR_OPERACAO_PESO, " +
                    "HORA_VALOR_OPERACAO_PESO, SEQUENCIA_VALOR_OPERACAO_PESO, COD_PESO_OPERACAO_PESO, DESCRICAO_PESO_OPERACAO_PESO) " +
                    "VALUES ('" + nome[i, 0] + "', NULL, " + (i + 1) +"," + tb_cod_peso.Text +", '" + tb_peso.Text +"');";
                    datOperacoesPeso.InsertCommand = select;
                    datOperacoesPeso.InsertCommand.ExecuteNonQuery();
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

        private void selecionar_valores_operacao()
        {
            try
            {
                dsOperacoesPeso.Clear();
                datOperacoesPeso.SelectCommand.CommandText =
                    "SELECT * FROM VALOR_OPERACAO_PESO WHERE COD_PESO_OPERACAO_PESO = " + tb_cod_peso.Text;
                datOperacoesPeso.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datOperacoesPeso.SelectCommand.ExecuteNonQuery();
                datOperacoesPeso.Fill(VALOR_OPERACAO_PESO);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[dsOperacoesPeso, "VALOR_OPERACAO_PESO"].EndCurrentEdit();
                if (dsOperacoesPeso.HasChanges())
                {
                    fbConnection1.Open();

                    datOperacoesPeso.UpdateCommand = cbOperacoesPeso.GetUpdateCommand();
                    datOperacoesPeso.InsertCommand = cbOperacoesPeso.GetInsertCommand();
                    datOperacoesPeso.DeleteCommand = cbOperacoesPeso.GetDeleteCommand();
                    datOperacoesPeso.Update(dsOperacoesPeso, "VALOR_OPERACAO_PESO");
                    dsOperacoesPeso.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fbConnection1.Close();
            }

            try
            {
                this.BindingContext[dsMateriaPrimaPeso, "VALOR_MATERIA_PRIMA_PESO"].EndCurrentEdit();
                if (dsMateriaPrimaPeso.HasChanges())
                {
                    fbConnection1.Open();

                    datMateriaPrimaPeso.UpdateCommand = cbMateriaPrimaPeso.GetUpdateCommand();
                    datMateriaPrimaPeso.InsertCommand = cbMateriaPrimaPeso.GetInsertCommand();
                    datMateriaPrimaPeso.DeleteCommand = cbMateriaPrimaPeso.GetDeleteCommand();
                    datMateriaPrimaPeso.Update(dsMateriaPrimaPeso, "VALOR_MATERIA_PRIMA_PESO");
                    dsMateriaPrimaPeso.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fbConnection1.Close();
            }

            try
            {
                this.BindingContext[dsOutrosServicosPeso, "VALOR_OUTROS_SERVICOS_PESO"].EndCurrentEdit();
                if (dsOutrosServicosPeso.HasChanges())
                {
                    fbConnection1.Open();

                    datOutrosServicosPeso.UpdateCommand = cbOutrosServicosPeso.GetUpdateCommand();
                    datOutrosServicosPeso.InsertCommand = cbOutrosServicosPeso.GetInsertCommand();
                    datOutrosServicosPeso.DeleteCommand = cbOutrosServicosPeso.GetDeleteCommand();
                    datOutrosServicosPeso.Update(dsOutrosServicosPeso, "VALOR_OUTROS_SERVICOS_PESO");
                    dsOutrosServicosPeso.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fbConnection1.Close();
            }

            try
            {
                this.BindingContext[dsPesoMoldes, "PESO_MOLDES_PECAS"].EndCurrentEdit();
                if (dsPesoMoldes.HasChanges())
                {
                    fbConnection1.Open();

                    datPesoMoldes.UpdateCommand = cbPesoMoldes.GetUpdateCommand();
                    datPesoMoldes.InsertCommand = cbPesoMoldes.GetInsertCommand();
                    datPesoMoldes.DeleteCommand = cbPesoMoldes.GetDeleteCommand();
                    datPesoMoldes.Update(dsOutrosServicosPeso, "PESO_MOLDES_PECAS");
                    dsPesoMoldes.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fbConnection1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_pesos_molde f = new form_pesos_molde();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                tb_cod_peso.Text = f.cod_escolhido;
                tb_peso.Text = f.peso_escolhido;
                selecionar_valores_operacao();
                selecionar_valores_mp();
                selecionar_valores_outros_servicos();
                //selecionar_valores_moldes();
            }
        }

        private void selecionar_valores_moldes()
        {
            try
            {
                dsOperacoesPeso.Clear();
                datOperacoesPeso.SelectCommand.CommandText =
                    "SELECT * FROM PESO_MOLDES_PECAS WHERE COD_PESO_OPERACAO_PESO = " + tb_cod_peso.Text;
                datOperacoesPeso.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datOperacoesPeso.SelectCommand.ExecuteNonQuery();
                datOperacoesPeso.Fill(VALOR_OPERACAO_PESO);
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
            form_valor_materia_prima mat = new form_valor_materia_prima();
            try
            {
                mat.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < mat.numero_de_itens; i++)
                {
                    mat.Dispose();
                    inserir_materia_prima(mat._cod_escolhido[i], mat._descricao_escolhida[i], mat._valor_escolhido[i]);
                }
                selecionar_valores_mp();    
            }
        }

        private void selecionar_valores_mp()
        {
            try
            {
                dsMateriaPrimaPeso.Clear();
            this.datMateriaPrimaPeso.SelectCommand.CommandText =
            "SELECT * FROM VALOR_MATERIA_PRIMA_PESO WHERE COD_PESO_VALOR_MP_PESO = " + tb_cod_peso.Text;
            this.fbConnection1.Open();
            this.datMateriaPrimaPeso.SelectCommand.Connection = fbConnection1;
            this.datMateriaPrimaPeso.SelectCommand.ExecuteNonQuery();
            datMateriaPrimaPeso.Fill(VALOR_MATERIA_PRIMA_PESO);
            this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void selecionar_valores_outros_servicos()
        {
            try
            {
                dsOutrosServicosPeso.Clear();
                this.datOutrosServicosPeso.SelectCommand.CommandText =
                "SELECT * FROM VALOR_OUTROS_SERVICOS_PESO WHERE COD_PESO_OUTROS_SERV_PESO = " + tb_cod_peso.Text;
                this.fbConnection1.Open();
                this.datOutrosServicosPeso.SelectCommand.Connection = fbConnection1;
                this.datOutrosServicosPeso.SelectCommand.ExecuteNonQuery();
                datOutrosServicosPeso.Fill(VALOR_OUTROS_SERVICOS_PESO);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_materia_prima(string cod, string descricao, string valor)
        {
            try
            {
                double valorMP = 0;

                Double.TryParse(valor, out valorMP);

                this.datMateriaPrimaPeso.InsertCommand.CommandText =
                   "INSERT INTO VALOR_MATERIA_PRIMA_PESO (COD_MP_VALOR_MP_PESO, DESCRICAO_VALOR_MP_PESO, VALOR_VALOR_MP_PESO,COD_PESO_VALOR_MP_PESO,DESCRICAO_PESO_VALOR_MP_PESO) " +
                   "VALUES (" + cod + ",'" + descricao + "'," + valorMP.ToString().Replace(",", ".") + "," + tb_cod_peso.Text + ", '" + tb_peso.Text + "')";
                this.fbConnection1.Open();
                this.datMateriaPrimaPeso.InsertCommand.Connection = fbConnection1;
                this.datMateriaPrimaPeso.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_outros_serviços outrosServ = new form_outros_serviços();
            try
            {
                outrosServ.ShowDialog();
            }
            finally
            {
                for (int i = 0; i < outrosServ.numero_de_itens; i++)
                {
                    inserir_outros_servicos(outrosServ._cod_escolhido[i], outrosServ._descricao_escolhida[i],outrosServ._valor_escolhido[i]);
                }
                selecionar_valores_outros_servicos();
            }
        }

        private void inserir_outros_servicos(string cod, string descricao, string valor)
        {
            try
            {
                double valorOutrosServ = 0;
                double.TryParse(valor, out valorOutrosServ);
                this.datOutrosServicosPeso.InsertCommand.CommandText =
                    "INSERT INTO VALOR_OUTROS_SERVICOS_PESO (COD_OUTROS_OUTROS_SERV_PESO, DESCRICAO_OUTROS_SERV_PESO, VALOR_OUTROS_SERV_PESO,COD_PESO_OUTROS_SERV_PESO,DESCRICAO_PESO_OUTROS_SERV_PESO) VALUES (" +
                    cod + ", '" + descricao + "', " + valorOutrosServ.ToString().Replace(",", ".") + "," + tb_cod_peso.Text + ", '" + tb_peso.Text + "');";
                this.fbConnection1.Open();
                this.datOutrosServicosPeso.InsertCommand.Connection = fbConnection1;
                this.datOutrosServicosPeso.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }

        }

        private void form_operacoes_peso_Load(object sender, EventArgs e)
        {

        }
    }
}
