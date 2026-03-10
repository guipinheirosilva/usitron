using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using CTe_Util;

namespace Evolucao
{
    public partial class form_cte_carta_correcao_tag : Form
    {
        public string n_cte;
        public string cod_cte;
        DataSet dsCte = new DataSet();
        CTe_Util.Util util = new CTe_Util.Util();
        public string xml_retorno;

        public form_cte_carta_correcao_tag()
        {
            InitializeComponent();
        }

        private void form_cte_carta_correcao_tag_Load(object sender, EventArgs e)
        {
            string xml_cte = buscar_xml_autorizada();
            salvar_na_pasta(xml_cte, @"c:\\evolucao\\temp.xml");
            
            dsCte.ReadXml(@"c:\\evolucao\\temp.xml");
           
            for(int i = 0; i < dsCte.Tables.Count; i++)
                cbGrupos.Items.Add(dsCte.Tables[i].TableName);

            selecionar_tags();
            tb_cod_cte.Text = cod_cte;
            
        }

        private void selecionar_tags()
        {
            try
            {
                dsCarta_correcao_tags.Clear();
                datCarta_correcao_tags.SelectCommand.CommandText =
                    "SELECT * FROM CARTA_CORRECAO_TAGS WHERE COD_CTE_CCT = '" + cod_cte + "'";
                datCarta_correcao_tags.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datCarta_correcao_tags.Fill(CARTA_CORRECAO_TAGS);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void salvar_na_pasta(string cte, string caminho)
        {
            try
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(cte);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
        private string buscar_xml_autorizada()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT XML_AUTORIZADO FROM CTE WHERE COD_CTE = '" + cod_cte + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "";
            }
        }

        private void cbGrupos_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dsCte.Tables[cbGrupos.Text].Columns.Count; i++)
                cbCampo.Items.Add(dsCte.Tables[cbGrupos.Text].Columns[i].ColumnName);
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCampo.Text == "" || cbGrupos.Text == "" || tb_texto_correcao.Text == "")
                {
                    MessageBox.Show("Campo, Grupo e Texto Correção são obrigatórios");
                }
                else
                {
                    string n_item = "null";
                    if (tb_n_item.Text != "")
                        n_item = "'" + tb_n_item.Text + "'";

                    datCarta_correcao_tags.InsertCommand.CommandText =
                        "INSERT INTO CARTA_CORRECAO_TAGS (COD_CTE_CCT, GRUPO_CCT, CAMPO_CCT, VALOR_CCT, N_ITEM_CCT) " +
                        "VALUES ('" + cod_cte + "','" + cbGrupos.Text + "','" + cbCampo.Text + "','" + tb_texto_correcao.Text + "'," + n_item + ")";
                    datCarta_correcao_tags.InsertCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datCarta_correcao_tags.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    selecionar_tags();

                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
            finalizar();
        }

        private void finalizar()
        {
            string xml = "";
            for (int i = 0; i < dgvCarta_correcao_tags.RowCount; i++)
            {
                xml = xml + util.geraInfCorrecao(dgvCarta_correcao_tags.Rows[i].Cells["col_grupo"].Value.ToString(),
                    dgvCarta_correcao_tags.Rows[i].Cells["col_campo"].Value.ToString(),
                    dgvCarta_correcao_tags.Rows[i].Cells["col_texto"].Value.ToString(),
                    dgvCarta_correcao_tags.Rows[i].Cells["col_n_item"].Value.ToString());

            }
            xml_retorno = xml;
            this.Close();

        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsCarta_correcao_tags, "CARTA_CORRECAO_TAGS"].EndCurrentEdit();
                if (dsCarta_correcao_tags.HasChanges())
                {
                    fbConnection1.Open();
                    datCarta_correcao_tags.UpdateCommand = cbCarta_correcao_tags.GetUpdateCommand();
                    datCarta_correcao_tags.InsertCommand = cbCarta_correcao_tags.GetInsertCommand();
                    datCarta_correcao_tags.DeleteCommand = cbCarta_correcao_tags.GetDeleteCommand();
                    datCarta_correcao_tags.Update(dsCarta_correcao_tags, "CARTA_CORRECAO_TAGS");
                    dsCarta_correcao_tags.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }


    }
}