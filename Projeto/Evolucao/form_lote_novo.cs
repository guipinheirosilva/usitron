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
    public partial class form_lote_novo : Form
    {
        public string cod_item_nf_ent;
        public string cod_lote;
        public string cod_mp, descricao_mp, dimensoes, material, cnpj_cliente, nome_cliente, qtde, nota_fiscal, qtde_nf;
        public bool excluir;
        public string usuario_atual;
        public form_lote_novo()
        {
            InitializeComponent();
        }

        private void form_lote_novo_Load(object sender, EventArgs e)
        {
            if (cod_lote != "" && cod_lote != null)
            {
                try
                {
                    datLote_recebimento.SelectCommand.CommandText =
                        "SELECT * FROM LOTE_RECEBIMENTO WHERE COD_LR = '" + cod_lote + "'";
                    datLote_recebimento.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datLote_recebimento.SelectCommand.ExecuteNonQuery();
                    datLote_recebimento.Fill(LOTE_RECEBIMENTO);
                    fbConnection1.Close();

                    datPalete_lote.SelectCommand.CommandText =
                        "SELECT * FROM PALETE_LOTE WHERE LOTE_PALETE_LOTE = '" + cod_lote + "'";
                    datPalete_lote.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datPalete_lote.SelectCommand.ExecuteNonQuery();
                    datPalete_lote.Fill(PALETE_LOTE);
                    fbConnection1.Close();
                    selecionar_saidas(tb_cod_lote.Text);
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

            }
            else
            {
                try
                {
                    if (cod_mp != "" && cod_mp != null)
                        cod_mp = "'" + cod_mp + "'";
                    else
                        cod_mp = "null";

                    if (descricao_mp != "" && descricao_mp != null)
                        descricao_mp = "'" + descricao_mp + "'";
                    else
                        descricao_mp = "null";

                    if (dimensoes != "" && dimensoes != null)
                        dimensoes = "'" + dimensoes + "'";
                    else
                        dimensoes = "null";

                    if (material != "" && material != null)
                        material = "'" + material + "'";
                    else
                        material = "null";

                    if (cnpj_cliente != "" && cnpj_cliente != null)
                        cnpj_cliente = "'" + cnpj_cliente + "'";
                    else
                        cnpj_cliente = "null";

                    if (nome_cliente != "" && nome_cliente != null)
                        nome_cliente = "'" + nome_cliente + "'";
                    else
                        nome_cliente = "null";


                    if (qtde != "" && qtde != null)
                        qtde = "'" + qtde + "'";
                    else
                        qtde = "null";

                    if (nota_fiscal != "" && nota_fiscal != null)
                        nota_fiscal = "'" + nota_fiscal + "'";
                    else
                        nota_fiscal = "null";

                    datLote_recebimento.InsertCommand.CommandText =
                        "INSERT INTO LOTE_RECEBIMENTO (COD_PRODUTO_LR, DESCRICAO_LR, DIMENSOES_LR, MATERIAL_LR, " +
                    "CNPJ_CLIENTE_LR, CLIENTE_LR, QTDE_LR, NOTA_FISCAL_LR, DATA_LIBERACAO_LR, QTDE_NF_LR) VALUES " +
                    "(" + cod_mp + "," + descricao_mp + "," + dimensoes + "," + material + "," + cnpj_cliente + "," +
                    nome_cliente + "," + qtde + "," + nota_fiscal + ",'" + DateTime.Now.ToShortDateString().Replace("/", ".") + "'," + qtde_nf + ")";
                    datLote_recebimento.InsertCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datLote_recebimento.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    datLote_recebimento.SelectCommand.CommandText =
                        "SELECT first(1) * FROM LOTE_RECEBIMENTO order by cod_lr desc ";
                    datLote_recebimento.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                   // datLote_recebimento.SelectCommand.ExecuteNonQuery();
                    datLote_recebimento.Fill(LOTE_RECEBIMENTO);
                    fbConnection1.Close();

                    if (cod_lote != null)
                    {
                        datPalete_lote.SelectCommand.CommandText =
                            "SELECT * FROM PALETE_LOTE WHERE LOTE_PALETE_LOTE = '" + cod_lote + "'";
                        datPalete_lote.SelectCommand.Connection = fbConnection1;
                        fbConnection1.Open();
                        datPalete_lote.SelectCommand.ExecuteNonQuery();
                        datPalete_lote.Fill(PALETE_LOTE);
                        fbConnection1.Close();
                        
                    }

                    update_itens_nf_ent(tb_cod_lote.Text);
                    // tb_qtde.Focus();
                    selecionar_saidas(tb_cod_lote.Text);


                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void selecionar_saidas(string lote)
        {
            try
            {
                using (FbCommand selectSaida_lote = new FbCommand())
                {
                    selectSaida_lote.Connection = fbConnection1;
                    fbConnection1.Open();
                    selectSaida_lote.CommandText =
                        @"SELECT inf.NF_ITEM, inf.qtde_item 
          FROM itens_nota inf
          INNER JOIN nota_fiscal nf ON inf.cod_sistema_nf_item = nf.cod_sistema_nf
          INNER JOIN nfs_referenciadas nfr ON inf.cod_itens_nota = nfr.cod_itens_nota_saida_nfr
          INNER JOIN itens_nota_ent infe ON nfr.cod_itens_nota_ent_nfr = infe.cod_itens_nota_ent
          WHERE infe.LOTE_ITEM_ENT = @lote AND nf.status_nfe LIKE '%Autorizada%'";

                    selectSaida_lote.Parameters.AddWithValue("@lote", lote);

                    using (FbDataAdapter dataAdapter = new FbDataAdapter(selectSaida_lote))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dgvSaidas.DataSource = dataTable;
                    }

                    fbConnection1.Close();
                }

            }
            catch(Exception ex)
            {

            }
        }

        private void update_itens_nf_ent(string lote)
        {
            try
            {
                if (lote == "")
                    lote = "null";
                else
                    lote = "'" + lote + "'";

               
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE ITENS_NOTA_ENT SET LOTE_ITEM_ENT = " + lote + 
                    " WHERE COD_ITENS_NOTA_ENT = '" + cod_item_nf_ent + "'";
                FbDataAdapter datItens = new FbDataAdapter();
                datItens.UpdateCommand = update;
                datItens.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double qtd = 0;

            for (int i = 0; i < dgvPaletes.RowCount; i++)
            {
                qtd = qtd + Convert.ToDouble(dgvPaletes.Rows[i].Cells["col_qtde"].Value);
            }
            try
            {
                double _qtde = 0;
                try
                {
                    _qtde = Convert.ToDouble(tb_qtde.Text);
                }
                catch { }
                if (qtd > _qtde)
                    tb_qtde.Text = qtd.ToString();
            }
            catch { }
            Salvar();
        }

        private void Salvar()
        {
            try
            {
                this.BindingContext[dsLote_recebimento, "LOTE_RECEBIMENTO"].EndCurrentEdit();
                if (dsLote_recebimento.HasChanges())
                {
                    fbConnection1.Open();
                    datLote_recebimento.UpdateCommand = cbLote_recebimento.GetUpdateCommand();
                    datLote_recebimento.InsertCommand = cbLote_recebimento.GetInsertCommand();
                    datLote_recebimento.DeleteCommand = cbLote_recebimento.GetDeleteCommand();
                    datLote_recebimento.Update(dsLote_recebimento, "LOTE_RECEBIMENTO");
                    dsLote_recebimento.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            try
            {
                this.BindingContext[dsPalete_lote, "PALETE_LOTE"].EndCurrentEdit();
                if (dsPalete_lote.HasChanges())
                {
                    fbConnection1.Open();
                    datPalete_lote.UpdateCommand = cbPalete_lote.GetUpdateCommand();
                    datPalete_lote.InsertCommand = cbPalete_lote.GetInsertCommand();
                    datPalete_lote.DeleteCommand = cbPalete_lote.GetDeleteCommand();
                    
                    datPalete_lote.Update(dsPalete_lote, "PALETE_LOTE");
                    dsPalete_lote.AcceptChanges();
                    fbConnection1.Close();
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
            form_usuario usuario = new form_usuario();
            try
            {
                usuario.ShowDialog();
            }
            finally
            {

                if (usuario.confirmado == true)
                {
                    try
                    {
                        if (usuario._cod_usuario == "1")
                        {
                            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
                            {
                                try
                                {
                                    this.datLote_recebimento.DeleteCommand.CommandText =
                                    "DELETE FROM LOTE_RECEBIMENTO WHERE COD_LR = '" + tb_cod_lote.Text + "'";
                                    this.fbConnection1.Open();
                                    this.datLote_recebimento.DeleteCommand.Connection = fbConnection1;
                                    this.datLote_recebimento.DeleteCommand.ExecuteNonQuery();
                                    this.fbConnection1.Close();
                                    excluir = true;
                                    this.Close();
                                }
                                catch
                                {
                                    fbConnection1.Close();
                                }

                            }

                        }
                    }
                    catch { }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_usuario usuario = new form_usuario();

            try
            {
                usuario.ShowDialog();
            }
            finally
            {
                tb_conferente.Text = usuario._nome_usuario;

                txtStatus.Text = "APROVADO";
                if (tb_qtde.Text != "")
                    Salvar();
            }
        }

        private string buscarControle(string codEstoque)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_CONTROLE_ESTOQUE FROM ESTOQUE WHERE COD_ESTOQUE = '" + codEstoque + "'";
                FbDataAdapter datTable = new FbDataAdapter();
                DataSet dsTable = new DataSet();
                fbConnection1.Open();
                datTable.SelectCommand = select;
                datTable.Fill(dsTable);
                fbConnection1.Close();
                DataRow dr = dsTable.Tables[0].Rows[0];
                return dr[0].ToString();
            }
            catch
            {
                fbConnection1.Close();
                return "";
            }
        }
        private bool buscarLote(string codLote)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM LOTE_MP_CONTROLE WHERE LOTE_LMC = '" + codLote + "'";
                FbDataAdapter datTable = new FbDataAdapter();
                DataSet dsTable = new DataSet();
                fbConnection1.Open();
                datTable.SelectCommand = select;
                datTable.Fill(dsTable);
                fbConnection1.Close();
                foreach (DataRow dr in dsTable.Tables[0].Rows)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                fbConnection1.Close();
                return true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salvar();
            string codEstoque = tbcod_estoque.Text;
            string codLote = tb_cod_lote.Text;
            string codControle = buscarControle(codEstoque);
            if (codControle != "")
            {
                //form_controlar_mp cont = new form_controlar_mp();
                //try
                //{
                //    cont.codEstoque = codEstoque;
                //    cont.codLote = codLote;
                //    cont.codControle = codControle;
                //    if (buscarLote(codLote))
                //    {
                //        cont.novo = true;
                //    }
                //    else
                //    {
                //        cont.novo = false;
                //    }
                //    cont.usuario_atual = this.usuario_atual;
                //    cont.ShowDialog();
                //}
                //finally
                //{
                //    txtStatus.Text = cont.status;
                //    Salvar();
                //}
            }
            else
            {
                MessageBox.Show("Plano de Controle Não Encontrado");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                openFileDialog1.ShowDialog();
                string caminho;
                caminho = openFileDialog1.FileName;
                tb_caminho.Text = openFileDialog1.FileName.ToString();
            
        }

        private void dgvPaletes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                dgvPaletes.Rows[e.RowIndex - 1].Cells["col_lote"].Value = tb_cod_lote.Text;
            }
            catch { }
        }

        private void form_lote_novo_FormClosed(object sender, FormClosedEventArgs e)
        {
            cod_lote = tb_cod_lote.Text;
        }

        private void form_lote_novo_FormClosing(object sender, FormClosingEventArgs e)
        {
            cod_lote = tb_cod_lote.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dsLote_mp lote = new dsLote_mp();
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM EMPRESA";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                fbConnection1.Open();
                datSelect.Fill(lote.EMPRESA);
                fbConnection1.Close();

                string fornecedor = "", nf = "", pedido = "0", cod_est = "", item_est = "", descricao_est = "", data = "";
                
                buscar_dados(tb_cod_lote.Text, out fornecedor, out nf, out pedido, out cod_est, out item_est, out descricao_est, out data);
                
                double peso_total = 0;
                for(int i = 0;  i < dgvPaletes.RowCount - 1; i++)
                {
                    peso_total += Convert.ToDouble(dgvPaletes.Rows[i].Cells["col_qtde"].Value.ToString());
                }

                lote.Lote.AddLoteRow("", fornecedor, Convert.ToInt32(nf), Convert.ToInt32(pedido), Convert.ToDateTime(data), Convert.ToInt32(cod_est),
                    item_est, descricao_est, dgvPaletes.Rows.Count - 1, peso_total, Convert.ToInt32(tb_cod_lote.Text), txtStatus.Text, tb_conferente.Text, "");

                FbCommand select_paletes = new FbCommand();
                select_paletes.Connection = fbConnection1;
                select_paletes.CommandText =
                    "SELECT * FROM LOTE_MP_CONTROLE lmc " +
                    "WHERE LOTE_LMC = '" + tb_cod_lote.Text + "'";
                FbDataAdapter datSelect_paletes = new FbDataAdapter();
                datSelect_paletes.SelectCommand = select_paletes;
                DataTable dtSelect_paletes = new DataTable();
                datSelect_paletes.Fill(dtSelect_paletes);
                for (int i = 0; i < dgvPaletes.RowCount - 1; i++)
                {
                    string palete = dgvPaletes.Rows[i].Cells["col_palete"].Value.ToString(), largura_nominal = "", espessura_nominal = "",
                        rebarba = "", flexa = "", dureza = "", status = "APROVADO", peso = "0";
                    bool reprovado = false;
                    foreach(DataRow dr in dtSelect_paletes.Select("PALETE_LMC = '" + palete + "'"))
                    {
                        if (!reprovado)
                        {
                            if (dr["ESPECIFICACAO_LMC"].ToString().ToUpper().Contains("PESO"))
                            {
                                if (dr["STATUS_LMC"].ToString() == "APROVADO")
                                    peso = dr["MEDIDA_ENCONTRADA_LMC"].ToString();
                                else
                                {
                                    status = "REPROVADO";
                                    reprovado = true;
                                }
                            }
                            if (dr["ESPECIFICACAO_LMC"].ToString().ToUpper().Contains("LARGURA"))
                            {
                                if (dr["STATUS_LMC"].ToString() == "APROVADO")
                                    largura_nominal = dr["MEDIDA_ENCONTRADA_LMC"].ToString();
                                else
                                {
                                    status = "REPROVADO";
                                    reprovado = true;
                                }
                            }
                            if (dr["ESPECIFICACAO_LMC"].ToString().ToUpper().Contains("ESPESSURA"))
                            {
                                if (dr["STATUS_LMC"].ToString() == "APROVADO")
                                    espessura_nominal = dr["MEDIDA_ENCONTRADA_LMC"].ToString();
                                else
                                {
                                    status = "REPROVADO";
                                    reprovado = true;
                                }
                            }
                            if (dr["ESPECIFICACAO_LMC"].ToString().ToUpper().Contains("REBARBA"))
                            {
                                if (dr["STATUS_LMC"].ToString() == "APROVADO")
                                    rebarba = "Não";
                                else
                                {
                                    status = "REPROVADO";
                                    reprovado = true;
                                }
                            }
                            if (dr["ESPECIFICACAO_LMC"].ToString().ToUpper().Contains("FLEXA"))
                            {
                                if (dr["STATUS_LMC"].ToString() == "APROVADO")
                                    flexa = "Não";
                                else
                                {
                                    status = "REPROVADO";
                                    reprovado = true;
                                }
                            }
                            if (dr["ESPECIFICACAO_LMC"].ToString().ToUpper().Contains("DUREZA"))
                            {
                                if (dr["STATUS_LMC"].ToString() == "APROVADO")
                                    dureza = dr["MEDIDA_ENCONTRADA_LMC"].ToString();
                                else
                                {
                                    status = "REPROVADO";
                                    reprovado = true;
                                }
                            }
                        }
                    }
                    try
                    {
                        lote.Paletes.AddPaletesRow(palete, Convert.ToDouble(peso), Convert.ToDouble(largura_nominal), Convert.ToDouble(espessura_nominal),
                            rebarba, flexa, Convert.ToDouble(dureza), status);
                    }
                    catch { }
                }

                crControle_mp relatorio = new crControle_mp();
                relatorio.SetDataSource(lote);
                form_imprimir imp = new form_imprimir(relatorio);
                imp.Show();
                
            }
            catch(Exception a) 
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_dados(string lote, out string fornecedor, out string nf, out string pedido, 
            out string cod_est, out string item_est, out string descricao_est, out string data)
        {
            fornecedor = ""; nf = "0"; pedido = "0"; cod_est = "0"; item_est = ""; descricao_est = ""; data = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT est.COD_ESTOQUE, est.ITEM_ESTOQUE, est.DESCRICAO_ESTOQUE, nf.CLIENTE_FORN_NF_ENT FROM ESTOQUE est " +
                    " INNER JOIN ITENS_NOTA_ENT inf ON est.COD_ESTOQUE = inf.COD_ITEM_EST_ITEM_ENT " +
                    " INNER JOIN NOTA_FISCAL_ENT nf ON inf.COD_SISTEMA_NF_ITEM_ENT = nf.COD_SISTEMA_NF_ENT " +
                    " WHERE inf.LOTE_ITEM_ENT = '" + lote + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    fornecedor = dr["CLIENTE_FORN_NF_ENT"].ToString();
                    nf = tb_nf.Text;
                    pedido = "0";
                    cod_est = dr["COD_ESTOQUE"].ToString();
                    item_est = dr["ITEM_ESTOQUE"].ToString();
                    descricao_est = dr["DESCRICAO_ESTOQUE"].ToString();
                    data = tb_data.Text;
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "REPROVADO";
            Salvar();
        }

        private void datLote_recebimento_RowUpdated(object sender, FbRowUpdatedEventArgs e)
        {

        }

    }
}
