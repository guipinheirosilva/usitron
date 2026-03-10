using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_romaneio : Form
    {
        public string cod_usuario;
        string placaVeiculo;
        public form_romaneio()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            placaVeiculo = tb_placa_novo_romaneio.Text;
            inserir_novo_romaneio(tb_placa_novo_romaneio.Text);
            tb_chave_cte.Focus();
            selecionar_romaneios_dia(dtData_atual.Text);
        }

        private void inserir_novo_romaneio(string placa)
        {
            try
            {
                string roteiro = "1";// buscar_roteiro(placa);
                string motorista = "null";
                if(tb_nome_motorista.Text != "")
                    motorista = "'" + tb_nome_motorista.Text + "'";
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO ROMANEIO (DATA_ROMANEIO, PLACA_VEICULO_ROMANEIO, ROTEIRO_ROMANEIO, MOTORISTA_ROMANEIO) " +
                    "VALUES ('" + Convert.ToDateTime(dtData_atual.Text).ToShortDateString().Replace("/", ".")+ 
                    "','" + placa + "','" + roteiro + "'," + motorista + ")";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.InsertCommand = insert;
                datTabela.InsertCommand.ExecuteNonQuery();
                
                fbConnection1.Close();

                string n_romaneio_criado = buscar_ultima_insercao(); //datTabela.InsertCommand.Parameters[0].Value.ToString();
                tb_romaneio_selecionado.Text = n_romaneio_criado;
                //SELECIONANDO CTES DO ROTEIRO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT cte.N_CTE, cte.DESTINATARIO_NOME_CTE, cte.DESTINATARIO_CNPJ_CTE, " +
                    "cte.RECEBEDOR_NOME_CTE, cte.RECEBEDOR_CNPJ_CTE, cliente.ENDERECO, cliente.NUMERO_CLIENTE, " +
                    "cliente.COMPLEMENTO_CLIENTE, cliente.BAIRRO, cliente.CIDADE, cliente.ESTADO, " +
                    "cliente.CEP_CLIENTE, cte.PESO_CTE, cte.QTDE_VOLUMES_CTE, cte.CUBAGEM_CTE, cte.VALOR_TOTAL_CTE, " +
                    "cte.VALOR_MERCADO_CTE, cte.DATA_EMISSAO_CTE, cte.EMITENTE_CNPJ_CTE FROM CTE cte INNER JOIN CLIENTES cliente ON cte.RECEBEDOR_CNPJ_CTE = cliente.CNPJ " +
                    "WHERE cliente.COD_ROTEIRO_CLIENTE = '" + roteiro + "' AND " +
                    "cte.DATA_EMISSAO_CTE <= '" + Convert.ToDateTime(dtData_atual.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                    "(cte.ENTREGUE_CTE IS NULL OR cte.ENTREGUE_CTE = '0') ORDER BY cliente.CEP_CLIENTE";
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                int ordem_original = 1;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {

                    //TRATANDO VALORES
                    classe_tratamento_colunas col = new classe_tratamento_colunas();
                    col.linha_original = dr;
                    DataRow dr_new = col.tratar_linha();
                    try
                    {
                        FbCommand insert_itens = new FbCommand();
                        insert_itens.Connection = fbConnection1;
                        fbConnection1.Open();
                        insert_itens.CommandText =
                            "INSERT INTO ITENS_ROMANEIO (COD_CTE_COLETA_IR, COD_ROMANEIO_IR, " +
                            "DESTINATARIO_IR, CNPJ_DESTINATARIO_IR, RECEBEDOR_IR, CNPJ_RECEBEDOR_IR, " +
                            "ENDERECO_REC_IR, N_REC_IR, COMPLEMENTO_REC_IR, BAIRRO_REC_IR, CIDADE_REC_IR, " +
                            "ESTADO_REC_IR, CEP_REC_IR, PESO_IR, VOLUMES_IR, CUBAGEM_IR, VALOR_CTE_IR, VALOR_CARGA_IR, " +
                            "ORDEM_ENTREGA_IR, DATA_CTE_COLETA_IR, TIPO_IR, CNPJ_EMITENTE_IR)" +
                            "VALUES (" + dr_new[0].ToString() + "," + n_romaneio_criado + "," +
                            dr_new[1].ToString() + "," + dr_new[2].ToString() + "," +
                            dr_new[3].ToString() + "," + dr_new[4].ToString() + "," +
                            dr_new[5].ToString() + "," + dr_new[6].ToString() + "," +
                            dr_new[7].ToString() + "," + dr_new[8].ToString() + "," +
                            dr_new[9].ToString() + "," + dr_new[10].ToString() + "," +
                            dr_new[11].ToString() + "," + Convert.ToDouble(dr_new[12].ToString()).ToString().Replace(",", ".") + "," +
                            dr_new[13].ToString() + "," + Convert.ToDouble(dr_new[14].ToString()).ToString().Replace(",", ".") + "," +
                            Convert.ToDouble(dr_new[15].ToString()).ToString().Replace(",",".") + "," + 
                            Convert.ToDouble(dr_new[16].ToString()).ToString().Replace(",",".") + "," +
                            ordem_original.ToString() + ",'" +
                            Convert.ToDateTime(dr_new[17].ToString()).ToShortDateString().Replace("/",".") + "','CTE', '" + dr_new[18].ToString() + "')";
                        datTabela.InsertCommand = insert_itens;
                        datTabela.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        //VERIFICAR A QUESTÃO DA SANTA LIVIA
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            update.CommandText =
                                "UPDATE CTE SET COD_ROMANEIO_CTE = '" + n_romaneio_criado + "' WHERE N_CTE = " + dr_new[0].ToString() + " AND EMITENTE_CNPJ_CTE = '" +
                                "'" + dr_new[18].ToString() + "'";
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.ToString());
                        }
                        //INSERINDO PLACA
                        if (placa.Trim() != "")
                        {
                            try
                            {
                                FbCommand updateCte = new FbCommand();
                                updateCte.Connection = fbConnection1;
                                fbConnection1.Open();
                                updateCte.CommandText =
                                    "UPDATE CTE SET PLACA_CTE = '" + placa + "'" +
                                    " WHERE N_CTE = '" + dr_new[0].ToString() + "' AND EMITENTE_CNPJ_CTE = '" + dr_new[18].ToString() + "'";
                                FbDataAdapter datTabelaCte = new FbDataAdapter();
                                datTabelaCte.UpdateCommand = updateCte;
                                datTabelaCte.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao inserir Placa no CTE");
                                fbConnection1.Close();
                            }
                        }
                        ordem_original++;
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
                selecionar_itens_romaneio(tb_romaneio_selecionado.Text);

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_ultima_insercao()
        {
        try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT FIRST(1) COD_ROMANEIO FROM ROMANEIO ORDER BY COD_ROMANEIO DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
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

        private string buscar_roteiro(string placa)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selecionar_romaneios_dia(dtData_atual.Text);
            dsItens_romaneio.Clear();

        }

        private void selecionar_romaneios_dia(string data)
        {
            try
            {
                dsRomaneio.Clear();
                datRomaneio.SelectCommand.CommandText =
                "SELECT * FROM ROMANEIO WHERE DATA_ROMANEIO = '" + Convert.ToDateTime(data).ToShortDateString().Replace("/",".") + "'" + 
                " ORDER BY COD_ROMANEIO";
                datRomaneio.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datRomaneio.SelectCommand.ExecuteNonQuery();
                datRomaneio.Fill(ROMANEIO);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void dgvRomaneios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_romaneio_selecionado.Text = dgvRomaneios.Rows[e.RowIndex].Cells[0].Value.ToString();
            placaVeiculo = dgvRomaneios.Rows[e.RowIndex].Cells[1].Value.ToString();
            selecionar_itens_romaneio(dgvRomaneios.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void selecionar_itens_romaneio(string cod_romaneio)
        {
            try
            {
                //string data = "";
                //if (cod_romaneio == "%")
                //    data = " AND rm.DATA_ROMANEIO = '" + dtData_atual.Text.Replace("/",".") + "'";
                dsItens_romaneio.Clear();
                datItens_romaneio.SelectCommand.CommandText =
                "SELECT * FROM ITENS_ROMANEIO ir WHERE ir.COD_ROMANEIO_IR LIKE '" + 
                cod_romaneio + "' " + 
                " ORDER BY ORDEM_ENTREGA_IR";
                datItens_romaneio.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_romaneio.SelectCommand.ExecuteNonQuery();
                datItens_romaneio.Fill(ITENS_ROMANEIO);
                fbConnection1.Close();
                
                somar_itens();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void somar_itens()
        {
            double valor_carga = 0, valor_cte = 0, peso = 0, volumes = 0, cubagem = 0;
            double valor_entregue = 0;
            for (int i = 0; i < dgvItens_romaneio.RowCount; i++)
            {
                if (dgvItens_romaneio.Rows[i].Cells["col_ja_devolvido"].Value.ToString() == "1")
                    dgvItens_romaneio.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                try
                {
                    valor_carga = valor_carga + Convert.ToDouble(dgvItens_romaneio.Rows[i].Cells["col_valor_carga"].Value.ToString());
                }
                catch { }
                try
                {
                    peso = peso + Convert.ToDouble(dgvItens_romaneio.Rows[i].Cells["col_peso"].Value.ToString());
                }
                catch { }
                try
                {
                    volumes = volumes + Convert.ToInt32(dgvItens_romaneio.Rows[i].Cells["col_volumes"].Value.ToString());
                }
                catch { }
                try
                {
                    cubagem = cubagem + Convert.ToDouble(dgvItens_romaneio.Rows[i].Cells["col_cubagem"].Value.ToString());
                }
                catch { }
                try
                {
                    valor_cte = valor_cte + Convert.ToDouble(dgvItens_romaneio.Rows[i].Cells["col_valor_cte"].Value.ToString());
                }
                catch { }
                if (dgvItens_romaneio.Rows[i].Cells["col_devolvido"].Value.ToString() == "1")
                {
                }
                else
                {

                    try
                    {
                        valor_entregue = valor_entregue + Convert.ToDouble(dgvItens_romaneio.Rows[i].Cells["col_valor_cte"].Value.ToString());
                    }
                    catch { }
                }

            }
            tb_peso_total.Text = peso.ToString("n2");
            tb_valor_total_carga.Text = valor_carga.ToString("n2");
            tb_volumes_totais.Text = volumes.ToString("n2");
            tb_cubagem_total.Text = cubagem.ToString("n2");
            tb_valor_frete.Text = valor_cte.ToString("n2");
            tb_valor_entregue.Text = valor_entregue.ToString("n2");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            salvar_itens_romaneio();
        }

        private void salvar_itens_romaneio()
        {
            try
            {
                this.BindingContext[dsItens_romaneio, "ITENS_ROMANEIO"].EndCurrentEdit();
                if (dsItens_romaneio.HasChanges())
                {
                    foreach (DataRow dr in dsItens_romaneio.Tables[0].Rows)
                    {
                        try
                        {
                            if (Convert.ToInt32(dr[25].ToString()) == 1)
                            {
                                try
                                {
                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    update.CommandText =
                                        "UPDATE CTE SET PLACA_CTE = null" +
                                        " WHERE N_CTE = '" + dr[1].ToString() + "' AND EMITENTE_CNPJ_CTE = '" + dr[24].ToString() + "'";
                                    FbDataAdapter datTabela = new FbDataAdapter();
                                    datTabela.UpdateCommand = update;
                                    datTabela.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch
                                {
                                    fbConnection1.Close();
                                }
                            }
                        }
                        catch { }
                    }
                    datItens_romaneio.UpdateCommand = cbItens_romaneio.GetUpdateCommand();
                    datItens_romaneio.InsertCommand = cbItens_romaneio.GetInsertCommand();
                    datItens_romaneio.DeleteCommand = cbItens_romaneio.GetDeleteCommand();
                    datItens_romaneio.Update(dsItens_romaneio, "ITENS_ROMANEIO");
                    dsItens_romaneio.AcceptChanges();
                }
                fbConnection1.Close();
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            selecionar_itens_romaneio(tb_romaneio_selecionado.Text);
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            salvar_romaneios();
        }

        private void salvar_romaneios()
        {
            try
            {
                this.BindingContext[dsRomaneio, "ROMANEIO"].EndCurrentEdit();
                if (dsRomaneio.HasChanges())
                {
                    foreach (DataRow dr in dsRomaneio.Tables[0].Rows)
                    {
                        if (dr.RowState == DataRowState.Modified)
                        {
                            try
                            {
                                FbCommand select = new FbCommand();
                                select.Connection = fbConnection1;
                                fbConnection1.Open();
                                select.CommandText =
                                    "SELECT COD_CTE_COLETA_IR, CNPJ_EMITENTE_IR FROM ITENS_ROMANEIO " +
                                    "WHERE COD_ROMANEIO_IR = '" + dr[0].ToString() + "'";
                                FbDataAdapter datTabela = new FbDataAdapter();
                                datTabela.SelectCommand = select;
                                DataSet dsTabela = new DataSet();
                                datTabela.Fill(dsTabela);
                                fbConnection1.Close();
                                foreach (DataRow dr2 in dsTabela.Tables[0].Rows)
                                {
                                    try
                                    {
                                        FbCommand update = new FbCommand();
                                        update.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        update.CommandText =
                                            "UPDATE CTE SET PLACA_CTE = '" + dr["PLACA_VEICULO_ROMANEIO"].ToString() + "' " +
                                            "WHERE N_CTE = '" + dr2[0].ToString() + "' AND EMITENTE_CNPJ_CTE = '" + dr2[1].ToString() + "'";
                                        datTabela.UpdateCommand = update;
                                        datTabela.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();
                                    }
                                    catch (Exception a)
                                    {
                                        MessageBox.Show(a.Message);
                                        fbConnection1.Close();
                                    }
                                }

                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.Message);
                                fbConnection1.Close();
                            }
                        }
                    }
                    datRomaneio.UpdateCommand = cbRomaneio.GetUpdateCommand();
                    datRomaneio.InsertCommand = cbRomaneio.GetInsertCommand();
                    datRomaneio.DeleteCommand = cbRomaneio.GetDeleteCommand();
                    datRomaneio.Update(dsRomaneio, "ROMANEIO");
                    dsRomaneio.AcceptChanges();
                }
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
            if (DialogResult.Yes == MessageBox.Show("Os registros serão excluídos permanentemente, tem certeza?",
                                   "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < dgvItens_romaneio.SelectedRows.Count; i++)
                {

                    try
                    {
                        datItens_romaneio.DeleteCommand.CommandText =
                            "DELETE FROM ITENS_ROMANEIO WHERE COD_ITEM_ROMANEIO = '" + dgvItens_romaneio.SelectedRows[i].Cells["col_cod_item_romaneio"].Value.ToString() + "'";
                        datItens_romaneio.DeleteCommand.Connection = fbConnection1;
                        fbConnection1.Open();
                        datItens_romaneio.DeleteCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                        if (dgvItens_romaneio.SelectedRows[i].Cells["col_tipo"].Value.ToString() == "CTE")
                        {
                            //UPDATE NO CTE
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            update.CommandText =
                                "UPDATE CTE SET COD_ROMANEIO_CTE = null WHERE N_CTE = '" + dgvItens_romaneio.SelectedRows[i].Cells["col_cte_coleta"].Value.ToString() + 
                                "' AND EMITENTE_CNPJ_CTE = " +
                                "'" + dgvItens_romaneio.SelectedRows[i].Cells["col_cnpj_emitente"].Value.ToString() + "'";
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }


                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
                selecionar_itens_romaneio(tb_romaneio_selecionado.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Os registros serão excluídos permanentemente, tem certeza?",
                                   "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < dgvRomaneios.SelectedRows.Count; i++)
                {
                    try
                    {
                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText =
                            "SELECT COD_ITEM_ROMANEIO, TIPO_IR, COD_CTE_COLETA_IR, CNPJ_EMITENTE_IR FROM ITENS_ROMANEIO WHERE COD_ROMANEIO_IR = '" +
                            dgvRomaneios.SelectedRows[i].Cells["col_cod"].Value.ToString() + "' ";
                        FbDataAdapter datTabela = new FbDataAdapter();
                        datTabela.SelectCommand = select;
                        DataSet dsTabela = new DataSet();
                        datTabela.Fill(dsTabela);
                        fbConnection1.Close();
                        foreach (DataRow dr in dsTabela.Tables[0].Rows)
                        {
                            try
                            {
                                datItens_romaneio.DeleteCommand.CommandText =
                                    "DELETE FROM ITENS_ROMANEIO WHERE COD_ITEM_ROMANEIO = '" + dr[0].ToString() + "'";
                                datItens_romaneio.DeleteCommand.Connection = fbConnection1;
                                fbConnection1.Open();
                                datItens_romaneio.DeleteCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                                if (dr[1].ToString() == "CTE")
                                {
                                    //UPDATE NO CTE
                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    update.CommandText =
                                        "UPDATE CTE SET COD_ROMANEIO_CTE = null WHERE N_CTE = '" + dr[2].ToString() + "' AND EMITENTE_CNPJ_CTE = " +
                                "'" + dr[3].ToString() + "'";
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                            }
                            catch (Exception a)
                            {
                                fbConnection1.Close();
                                MessageBox.Show(a.ToString());
                            }
                        }

                        datRomaneio.DeleteCommand.CommandText =
                                    "DELETE FROM ROMANEIO WHERE COD_ROMANEIO = '" +
                                    dgvRomaneios.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                        datRomaneio.DeleteCommand.Connection = fbConnection1;
                        fbConnection1.Open();
                        datRomaneio.DeleteCommand.ExecuteNonQuery();
                        fbConnection1.Close();


                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
                selecionar_itens_romaneio(tb_romaneio_selecionado.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dsRomaneio_transporte imprimir = new dsRomaneio_transporte();
            fbConnection1.Open();
            datItens_romaneio.Fill(imprimir.ITENS_ROMANEIO);
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                //fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM ROMANEIO WHERE " +
                    "COD_ROMANEIO = '" + tb_romaneio_selecionado.Text + "' "; 
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(imprimir.ROMANEIO);
                //fbConnection1.Close();
                
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            fbConnection1.Close();
            crRomaneio_transporte novo_ped = new crRomaneio_transporte();
            novo_ped.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(novo_ped);
            imprime.Show();
        }

        private void form_romaneio_Load(object sender, EventArgs e)
        {

        }

        private void tb_chave_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {

                adicionar_cte(retirar_zeros(tb_chave_cte.Text.Substring(26, 8)), tb_chave_cte.Text.Substring(6, 14));
                tb_chave_cte.Text = "";
            }
        }

        private string retirar_zeros(string numero)
        {
            int posicao = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                try
                {
                    if (numero[i].ToString() != "0")
                    {
                        posicao = i;
                        break;
                    }
                }
                catch { }
            }
            return numero.Substring(posicao);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form_pesquisa_cte pesquisa = new form_pesquisa_cte();
            try
            {
                pesquisa.busca = true;
                pesquisa._cnpj_emitente = "%";
                pesquisa.empresa_emissora = "Todas";
                pesquisa.cod_usuario = cod_usuario;
                pesquisa.ShowDialog();
            }
            finally
            {
                if (pesquisa._n_cte != "")
                    adicionar_cte(pesquisa._n_cte, pesquisa._cnpj_emitente);
            }
        }

        private void adicionar_cte(string _n_cte, string _cnpj_emitente)
        {
            string retorno = "";
            if (!ja_foi_inserido_no_dia(_n_cte, _cnpj_emitente, out retorno))
            {
                try
                {
                    string _destinatario, _cnpj_destinatario, _recebedor, _cnpj_recebedor, _endereco_rec, _numero_recebedor,
                        _complemento_recebedor, _bairro_recebedor, _cidade_recebedor, _estado_recebedor, _cep_recebedor,
                        _peso, _volumes, _cubagem, _valor_cte, _valor_carga, ordem_coleta,
                        _data_cte, _tipo, _cnpj_remetente, _remetente;
                    string cod_cte = buscar_cod_cte(_n_cte, _cnpj_emitente, out _destinatario, out _cnpj_destinatario,
                        out _recebedor, out _cnpj_recebedor, out _endereco_rec, out _numero_recebedor,
                        out _complemento_recebedor, out _bairro_recebedor, out _cidade_recebedor, out _estado_recebedor,
                        out _cep_recebedor, out _peso, out _volumes, out _cubagem,
                        out _valor_cte, out _valor_carga, out _cnpj_remetente, out _remetente, out ordem_coleta, out _data_cte, out _tipo);
                    string ja_foi_devolvido = "null";
                    if (verificar_se_ja_foi_devolvido(_n_cte, _cnpj_emitente))
                        ja_foi_devolvido = "'1'";
                    FbCommand insert_itens = new FbCommand();
                    insert_itens.Connection = fbConnection1;
                    fbConnection1.Open();
                    int ordem = Convert.ToInt32(dgvItens_romaneio.RowCount.ToString()) + 1;
                    insert_itens.CommandText =
                        "INSERT INTO ITENS_ROMANEIO (COD_CTE_COLETA_IR, COD_ROMANEIO_IR, " +
                        "DESTINATARIO_IR, CNPJ_DESTINATARIO_IR, RECEBEDOR_IR, CNPJ_RECEBEDOR_IR, " +
                        "ENDERECO_REC_IR, N_REC_IR, COMPLEMENTO_REC_IR, BAIRRO_REC_IR, CIDADE_REC_IR, " +
                        "ESTADO_REC_IR, CEP_REC_IR, PESO_IR, VOLUMES_IR, CUBAGEM_IR, VALOR_CTE_IR, VALOR_CARGA_IR, " +
                        "ORDEM_ENTREGA_IR, DATA_CTE_COLETA_IR, TIPO_IR, CNPJ_EMITENTE_IR, JA_DEVOLVIDO_IR, CNPJ_REMETENTE_IR, REMETENTE_IR)" +
                        "VALUES ('" + _n_cte + "','" + tb_romaneio_selecionado.Text + "','" +
                        _destinatario + "','" + _cnpj_destinatario + "','" +
                        _recebedor + "','" + _cnpj_recebedor + "','" +
                        _endereco_rec + "','" + _numero_recebedor + "','" +
                        _complemento_recebedor + "','" + _bairro_recebedor + "','" +
                        _cidade_recebedor + "','" + _estado_recebedor + "','" +
                        _cep_recebedor + "','" + Convert.ToDouble(_peso).ToString().Replace(",", ".") + "','" +
                        _volumes + "','" + Convert.ToDouble(_cubagem).ToString().Replace(",", ".") + "','" +
                        Convert.ToDouble(_valor_cte).ToString().Replace(",", ".") + "','" +
                        Convert.ToDouble(_valor_carga).ToString().Replace(",", ".") + "','" +
                        ordem.ToString() + "','" +
                        Convert.ToDateTime(_data_cte).ToShortDateString().Replace("/", ".") + "','CTE','" +
                        _cnpj_emitente + "'," + ja_foi_devolvido + ", '" + _cnpj_remetente + "','" + _remetente + "')";

                    datItens_romaneio.InsertCommand = insert_itens;
                    datItens_romaneio.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                    selecionar_itens_romaneio(tb_romaneio_selecionado.Text);
                    if (placaVeiculo.Trim() != "")
                    {
                        try
                        {
                            FbCommand updateCte = new FbCommand();
                            updateCte.Connection = fbConnection1;
                            fbConnection1.Open();
                            updateCte.CommandText =
                                "UPDATE CTE SET PLACA_CTE = '" + placaVeiculo + "'" +
                                " WHERE N_CTE = '" + _n_cte + "' AND EMITENTE_CNPJ_CTE = '" + _cnpj_emitente + "'";
                            FbDataAdapter datTabelaCte = new FbDataAdapter();
                            datTabelaCte.UpdateCommand = updateCte;
                            datTabelaCte.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao inserir placa no CTE");
                            fbConnection1.Close();
                        }
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
            else
            {
                Console.Beep();
                MessageBox.Show(retorno);
            }
        }

        private bool ja_foi_inserido_no_dia(string _n_cte, string _cnpj_emitente, out string retorno)
        {
            retorno = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM ITENS_ROMANEIO WHERE " +
                    "CNPJ_EMITENTE_IR = '" + _cnpj_emitente + "' and COD_CTE_COLETA_IR = '" + _n_cte + "' " + 
                    "AND (DEVOLVIDO_IR IS NULL or DEVOLVIDO_IR = 0)";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    retorno = "Esse CTe foi inserido no Romaneio nº: " + dr["COD_ROMANEIO_IR"].ToString() + ". \r\n " + 
                        "Se esse CTe precisar ser redespachado por favor marque-o como devolvido.";
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

        private bool verificar_se_ja_foi_devolvido(string _n_cte, string _cnpj_emitente)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM ITENS_ROMANEIO WHERE " +
                    "CNPJ_EMITENTE_IR = '" + _cnpj_emitente + "' and COD_CTE_COLETA_IR = '" + _n_cte + "' " + 
                    "AND DEVOLVIDO_IR = '1'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
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

        private string buscar_cod_cte(string _n_cte, string _cnpj_emitente, out string _destinatario, 
            out string _cnpj_destinatario, out string _recebedor, out string _cnpj_recebedor, 
            out string _endereco_rec, out string _numero_recebedor, out string _complemento_recebedor, 
            out string _bairro_recebedor, out string _cidade_recebedor, out string _estado_recebedor, 
            out string _cep_recebedor, out string _peso, out string _volumes, 
            out string _cubagem, out string _valor_cte, out string _valor_carga,
            out string _cnpj_remetente, out string _remetente,
            out string ordem_coleta, out string _data_cte, out string _tipo)
        {
            _destinatario = ""; _cnpj_destinatario = ""; _recebedor = ""; _cnpj_recebedor = ""; 
            _endereco_rec = ""; _numero_recebedor = "";_cnpj_remetente = ""; _remetente = "";
            _complemento_recebedor = ""; _bairro_recebedor = ""; _cidade_recebedor = ""; 
            _estado_recebedor = ""; _cep_recebedor = "";
                _peso = "0"; _volumes = "0"; _cubagem = "0"; 
            _valor_cte = "0"; _valor_carga = "0"; ordem_coleta = "0";
                _data_cte = ""; _tipo = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CTE WHERE " +
                    "EMITENTE_CNPJ_CTE = '" + _cnpj_emitente + "' and N_CTE = '" + _n_cte + "' ";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    _destinatario = retirar_caracteres(dr["DESTINATARIO_NOME_CTE"].ToString());
                    _cnpj_destinatario = dr["DESTINATARIO_CNPJ_CTE"].ToString();
                    _recebedor = retirar_caracteres(dr["RECEBEDOR_NOME_CTE"].ToString());
                    _cnpj_recebedor = dr["RECEBEDOR_CNPJ_CTE"].ToString();
                    _remetente = retirar_caracteres(dr["REMETENTE_NOME_CTE"].ToString());
                    _cnpj_remetente = dr["REMETENTE_CNPJ_CTE"].ToString();
                    if (_cnpj_recebedor != "")
                    {
                        buscar_endereco(_cnpj_recebedor, out _endereco_rec, out _numero_recebedor,
                            out _complemento_recebedor, 
                            out _bairro_recebedor, out _cidade_recebedor, out _estado_recebedor,
                            out _cep_recebedor);
                    }
                    else
                    {
                        buscar_endereco(_cnpj_destinatario, out _endereco_rec, out _numero_recebedor,
                           out _complemento_recebedor, out _bairro_recebedor, out _cidade_recebedor, out _estado_recebedor,
                           out _cep_recebedor);
                    }
                    _peso = dr["PESO_CTE"].ToString();
                    _volumes = dr["QTDE_VOLUMES_CTE"].ToString();
                    _valor_carga = dr["VALOR_MERCADO_CTE"].ToString();
                    if(dr["CUBAGEM_CTE"].ToString() != "")
                        _cubagem = dr["CUBAGEM_CTE"].ToString();
                    _valor_cte = dr["VALOR_TOTAL_CTE"].ToString();
                    _data_cte = dr["DATA_EMISSAO_CTE"].ToString();
                    try
                    {
                        return dr["COD_CTE"].ToString();
                    }
                    catch
                    {
                        return "";
                    }
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

        private void buscar_endereco(string _cnpj_recebedor, 
            out string _endereco_rec, out string _numero_recebedor, out string _complemento_recebedor, 
            out string _bairro_recebedor, out string _cidade_recebedor, 
            out string _estado_recebedor, out string _cep_recebedor)
        {
            _endereco_rec = ""; _numero_recebedor = ""; _complemento_recebedor = "";
            _bairro_recebedor = "";
            _cidade_recebedor = ""; _estado_recebedor = ""; _cep_recebedor = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM CLIENTES WHERE " +
                    "CNPJ = '" + _cnpj_recebedor + "' ";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    _endereco_rec = retirar_caracteres(dr["ENDERECO"].ToString());
                    _numero_recebedor = dr["NUMERO_CLIENTE"].ToString();
                    _complemento_recebedor = dr["COMPLEMENTO_CLIENTE"].ToString();
                    _bairro_recebedor = retirar_caracteres(dr["BAIRRO"].ToString());
                    _cidade_recebedor = retirar_caracteres(dr["CIDADE"].ToString());
                    _estado_recebedor = dr["ESTADO"].ToString();
                    _cep_recebedor = dr["CEP_CLIENTE"].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string retirar_caracteres(string arquivo)
        {
            return arquivo.Replace("Ã", "A").Replace("Õ", "O").Replace("Ç", "C").Replace("Â", "A").Replace("Á", "A").Replace("À", "A")
                .Replace("Ô", "O").Replace("\r\n", " ").Replace("-", "").Replace("(", "").Replace(")", "").Replace("/", "").Replace("&", "e").Replace("'", "");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void tb_nome_motorista_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            selecionar_itens_romaneio("%");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirDia_Click(object sender, EventArgs e)
        {
            string buscaRomaneio = "",itemRomaneio = "";
            for (int i = 0; i < dgvRomaneios.Rows.Count; i++)
            {
                if (buscaRomaneio.Trim() == "")
                {
                    buscaRomaneio = " WHERE COD_ROMANEIO = '" + dgvRomaneios.Rows[i].Cells[0].Value.ToString() + "'";
                    itemRomaneio = " WHERE COD_ROMANEIO_IR = '" + dgvRomaneios.Rows[i].Cells[0].Value.ToString() + "'";
                }
                else
                {

                    buscaRomaneio += " OR COD_ROMANEIO = '" + dgvRomaneios.Rows[i].Cells[0].Value.ToString() + "'";
                    itemRomaneio += " OR COD_ROMANEIO_IR = '" + dgvRomaneios.Rows[i].Cells[0].Value.ToString() + "'";
                }
            }
            dsRomaneio_transporte imprimir = new dsRomaneio_transporte();
            fbConnection1.Open();
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                //fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM ROMANEIO" + buscaRomaneio;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(imprimir.ROMANEIO);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                //fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM ITENS_ROMANEIO" + itemRomaneio;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(imprimir.ITENS_ROMANEIO);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

            fbConnection1.Close();
            crRomaneio_transporte_dia novo_ped = new crRomaneio_transporte_dia();
            novo_ped.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(novo_ped);
            imprime.Show();
        }

        

       
    }
}