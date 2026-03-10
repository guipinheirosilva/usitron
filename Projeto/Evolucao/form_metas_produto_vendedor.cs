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
    public partial class form_metas_produto_vendedor : Form
    {
        public string vendedor;
        public string cod_vendedor;
        public bool busca;
        public string cod;
        public string descricao;
        public form_metas_produto_vendedor()
        {
            InitializeComponent();
        }

        private void form_grupo_produto_Load(object sender, EventArgs e)
        {

            selecionar();
        }

        private void selecionar()
        {
            try
            {
                datGrupos.SelectCommand.CommandText = "SELECT * FROM METAS_PRODUTO_VENDEDOR WHERE COD_VENDEDOR_MPV = '" + cod_vendedor + "'";
                fbConnection1.Open();
                datGrupos.Fill(METAS_PRODUTO_VENDEDOR);
                fbConnection1.Close(); 
                dgvGrupos.AutoGenerateColumns = false;
                dgvGrupos.DataSource = dsGrupos.Tables["METAS_PRODUTO_VENDEDOR"];
                labelVendedor.Text = vendedor;
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
                dsGrupos.Tables["METAS_PRODUTO_VENDEDOR"].DefaultView.RowFilter = "FAMILIA_mpv LIKE '*" + tb_descricao.Text + "*'";
            }
            catch
            {

                dsGrupos.Tables["METAS_PRODUTO_VENDEDOR"].DefaultView.RowFilter = "COD_MPV IS NOT NULL";
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
                this.BindingContext[dsGrupos, "METAS_PRODUTO_VENDEDOR"].EndCurrentEdit();
                if (dsGrupos.HasChanges())
                {
                    fbConnection1.Open();
                    datGrupos.UpdateCommand = cbGrupos.GetUpdateCommand();
                    datGrupos.InsertCommand = cbGrupos.GetInsertCommand();
                    datGrupos.DeleteCommand = cbGrupos.GetDeleteCommand();
                    datGrupos.Update(dsGrupos, "METAS_PRODUTO_VENDEDOR");
                    dsGrupos.AcceptChanges();
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
                dsGrupos.Tables["METAS_PRODUTO_VENDEDOR"].DefaultView.RowFilter = "COD_VENDEDOR_MPV = '" + tb_descricao.Text + "'";
            }
            catch {

                dsGrupos.Tables["METAS_PRODUTO_VENDEDOR"].DefaultView.RowFilter = "COD_MPV IS NOT NULL";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_familias_produto fam = new form_familias_produto();
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
        }

        private bool verificar_se_ja_existe(string _cod_vendedor, string familia)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM METAS_PRODUTO_VENDEDOR WHERE COD_VENDEDOR_MPV = '" + cod_vendedor + "' AND FAMILIA_MPV = '" + familia + "'";
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