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
    public partial class form_grupos_operacoes : Form
    {
        public string grupo;
        public string cod_vendedor;
        public bool busca;
        public string cod;
        public string descricao;
        public form_grupos_operacoes()
        {
            InitializeComponent();
        }

        private void form_grupos_operacoes_Load(object sender, EventArgs e)
        {

            selecionar();
        }

        private void selecionar()
        {
            try
            {
                
                datGrupos_operacoes_prazo.SelectCommand.CommandText = "SELECT * FROM GRUPOS_OPERACOES_PRAZO WHERE GRUPO_GOP = '" + grupo + "'";
                fbConnection1.Open();
                datGrupos_operacoes_prazo.Fill(GRUPOS_OPERACOES_PRAZO);
                fbConnection1.Close(); 
                dgvGrupos.AutoGenerateColumns = false;
                dgvGrupos.DataSource = dsGrupos_operacoes_prazo.Tables["GRUPOS_OPERACOES_PRAZO"];
                labelGrupo.Text = grupo;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsGrupos_operacoes_prazo.Tables["OPERACAO_GOP"].DefaultView.RowFilter = "OPERACAO_GOP = '" + tb_descricao.Text + "'";
            }
            catch
            {

                dsGrupos_operacoes_prazo.Tables["OPERACAO_GOP"].DefaultView.RowFilter = "COD_GOP IS NOT NULL";
            }
        }

        private void dgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busca == true)
            {
                cod = dgvGrupos.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                descricao = dgvGrupos.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            try
            {
                this.BindingContext[dsGrupos_operacoes_prazo, "GRUPOS_OPERACOES_PRAZO"].EndCurrentEdit();
                if (dsGrupos_operacoes_prazo.HasChanges())
                {
                    fbConnection1.Open();
                    datGrupos_operacoes_prazo.UpdateCommand = cbGrupos_operacoes_prazo.GetUpdateCommand();
                    datGrupos_operacoes_prazo.InsertCommand = cbGrupos_operacoes_prazo.GetInsertCommand();
                    datGrupos_operacoes_prazo.DeleteCommand = cbGrupos_operacoes_prazo.GetDeleteCommand();
                    datGrupos_operacoes_prazo.Update(dsGrupos_operacoes_prazo, "GRUPOS_OPERACOES_PRAZO");
                    dsGrupos_operacoes_prazo.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch
            {
                fbConnection1.Close(); 
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                dsGrupos_operacoes_prazo.Tables["OPERACAO_GOP"].DefaultView.RowFilter = "OPERACAO_GOP = '" + tb_descricao.Text + "'";
            }
            catch {

                dsGrupos_operacoes_prazo.Tables["OPERACAO_GOP"].DefaultView.RowFilter = "COD_GOP IS NOT NULL";
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
        private void inserir_operacoes(int numero_de_itens, string[,] operacao_escolhida)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //DateTime comeco = DateTime.Now;
                for (int i = 0; i < numero_de_itens; i++)
                {
                    string operacao_atual = operacao_escolhida[i, 0];
                    int qtde = 0;
                    try
                    {
                        if (!verificar_se_ja_existe(labelGrupo.Text, operacao_atual))
                        {
                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            insert.CommandText = "INSERT INTO GRUPOS_OPERACOES_PRAZO (GRUPO_GOP, OPERACAO_GOP) VALUES ('" + labelGrupo.Text + "','" + operacao_atual + "')";
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        else
                        {
                            MessageBox.Show("A operação " + operacao_atual + " já está cadastrada para esse grupo.");
                        }


                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }






                }
                selecionar();

                this.Cursor = Cursors.Default;
            }
            catch
            {

                fbConnection1.Close();
                MessageBox.Show("Erro na inserção de operação");
            }







            /*
            form_tipos_operacoes fam = new form_tipos_operacoes();
            try
            {
                fam.ShowDialog();

            }
            finally
            {
                for (int i = 0; i < fam.n_selecionados; i++)
                {
                    try
                    {
                        if (!verificar_se_ja_existe(cod_vendedor, fam.familias[1, i]))
                        {
                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            insert.CommandText = "INSERT INTO METAS_PRODUTO_VENDEDOR (COD_VENDEDOR_MPV, FAMILIA_MPV) VALUES ('" + cod_vendedor + "','" + fam.familias[1, i] + "')";
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("A Família " + fam.familias[1, i] + " já está cadastrada para esse vendedor.");
                        }


                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show(a.ToString());
                    }
                }
                selecionar();

            }
             * */
        }

        private bool verificar_se_ja_existe(string grupo, string operacao)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM GRUPOS_OPERACOES_PRAZO WHERE GRUPO_GOP = '" + grupo + "' AND OPERACAO_GOP = '" + operacao + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close(); 
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return true;
                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return false;
            }
        }
    }
}