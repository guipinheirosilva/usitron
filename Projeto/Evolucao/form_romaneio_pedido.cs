using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace Evolucao
{
    public partial class form_romaneio_pedido : Form
    {
        public string cod_usuario;
        string placaVeiculo;
        FbDataAdapter datEmpresa = new FbDataAdapter();
        public form_romaneio_pedido()
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
                if (tb_nome_motorista.Text != "")
                    motorista = "'" + tb_nome_motorista.Text + "'";

                string vendedor = "null";
                if (tb_vendedor.Text != "")
                    vendedor = "'" + tb_vendedor.Text + "'";
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO ROMANEIO (DATA_ROMANEIO, PLACA_VEICULO_ROMANEIO, ROTEIRO_ROMANEIO, MOTORISTA_ROMANEIO, VENDEDOR_ROMANEIO) " +
                    "VALUES ('" + Convert.ToDateTime(dtData_atual.Text).ToShortDateString().Replace("/", ".") +
                    "','" + placa + "','" + roteiro + "'," + motorista + "," + vendedor + ")";
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
                            Convert.ToDouble(dr_new[15].ToString()).ToString().Replace(",", ".") + "," +
                            Convert.ToDouble(dr_new[16].ToString()).ToString().Replace(",", ".") + "," +
                            ordem_original.ToString() + ",'" +
                            Convert.ToDateTime(dr_new[17].ToString()).ToShortDateString().Replace("/", ".") + "','CTE', '" + dr_new[18].ToString() + "')";
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
                "SELECT * FROM ROMANEIO WHERE DATA_ROMANEIO = '" + Convert.ToDateTime(data).ToShortDateString().Replace("/", ".") + "'" +
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
            catch (Exception a)
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
            try
            {
                if (tb_romaneio_selecionado.Text == "")
                {
                    MessageBox.Show("Selecione um romaneio!");
                }
                else
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
                    datEmpresa.SelectCommand.CommandText = "select logotipo_empresa, cod_empresa from empresa where LICENCA_DLL_NFE_EMPRESA is not null";
                    datEmpresa.Fill(imprimir.EMPRESA);
                    fbConnection1.Close();

                    crRomaneio_transporte novo_ped = new crRomaneio_transporte();
                    novo_ped.SetDataSource(imprimir);
                    form_imprimir imprime = new form_imprimir(novo_ped);
                    imprime.Show();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
      complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
      cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
      senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "", sslEmpresa = "", serie_empresa = "";

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                 out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                 out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                 out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
         out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                DataSet empresa = new DataSet();
                fbConnection1.Open();

                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    pais_empresa = dr["PAIS_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_NFE_EMPRESA"].ToString();
                    nome_certificado_nfe_empresa = dr["NOME_CERTIFICADO_NFE_EMPRESA"].ToString();
                    assunto_nfe_email_empresa = dr["ASSUNTO_NFE_EMAIL_EMPRESA"].ToString();
                    smtp_nfe_empresa = dr["SMTP_NFE_EMPRESA"].ToString();
                    email_nfe_empresa = dr["EMAIL_NFE_EMPRESA"].ToString();
                    senha_email_nfe_empresa = dr["SENHA_EMAIL_NFE_EMPRESA"].ToString();
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                    try
                    {
                        portaEmailEmpresa = dr["PORTA_EMAIL_EMP"].ToString();
                    }
                    catch { }
                    try
                    {
                        sslEmpresa = dr["SSL_EMP"].ToString();
                    }
                    catch { }

                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void form_romaneio_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa);

            selecionar_romaneios_dia(dtData_atual.Text);

        }


        private void tb_chave_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_chave_cte.Text.Length == 44)
                {
                    adicionar_nfe(retirar_zeros(tb_chave_cte.Text.Substring(26, 8)), tb_chave_cte.Text.Substring(6, 14));
                }
                else
                {
                    adicionar_pedido(tb_chave_cte.Text, cnpj_empresa, false);

                }
                tb_chave_cte.Text = "";
            }
        }

        private void adicionar_nfe(string _n_cte, string _cnpj_emitente)
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
                    string cod_cte = buscar_cod_nfe(_n_cte, _cnpj_emitente, out _destinatario, out _cnpj_destinatario,
                        out _recebedor, out _cnpj_recebedor, out _endereco_rec, out _numero_recebedor,
                        out _complemento_recebedor, out _bairro_recebedor, out _cidade_recebedor, out _estado_recebedor,
                        out _cep_recebedor, out _peso, out _volumes, out _cubagem,
                        out _valor_cte, out _valor_carga, out _cnpj_remetente, out _remetente, out ordem_coleta, out _data_cte, out _tipo);
                    string ja_foi_devolvido = "null";
                    if (verificar_se_ja_foi_devolvido(_n_cte, _cnpj_emitente))
                        ja_foi_devolvido = "'1'";
                    //string 


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
                        Convert.ToDateTime(_data_cte).ToShortDateString().Replace("/", ".") + "','NFE','" +
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
                                "UPDATE PEDIDOS_VENDA SET PLACA_PED_VENDA = '" + placaVeiculo + "'" +
                                " WHERE COD_PED_VENDA = '" + _n_cte + "'";
                            FbDataAdapter datTabelaCte = new FbDataAdapter();
                            datTabelaCte.UpdateCommand = updateCte;
                            datTabelaCte.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao inserir placa no PEDIDO");
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

        private void adicionar_pedido(string _n_cte, string _cnpj_emitente, bool venda_direta)
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
                    string cod_cte = buscar_cod_pedido(_n_cte, _cnpj_emitente, out _destinatario, out _cnpj_destinatario,
                        out _recebedor, out _cnpj_recebedor, out _endereco_rec, out _numero_recebedor,
                        out _complemento_recebedor, out _bairro_recebedor, out _cidade_recebedor, out _estado_recebedor,
                        out _cep_recebedor, out _peso, out _volumes, out _cubagem,
                        out _valor_cte, out _valor_carga, out _cnpj_remetente, out _remetente, out ordem_coleta, out _data_cte, out _tipo);
                    string ja_foi_devolvido = "null";
                    if (verificar_se_ja_foi_devolvido(_n_cte, _cnpj_emitente))
                        ja_foi_devolvido = "'1'";

                    string n_nf = "";
                    string forma_pgto = buscar_forma_pgto(_n_cte, out n_nf);
                    _peso = buscar_peso(n_nf);
                    if (_volumes == "")
                        _volumes = "0";
                    
                    FbCommand insert_itens = new FbCommand();
                    insert_itens.Connection = fbConnection1;
                    fbConnection1.Open();
                    int ordem = Convert.ToInt32(dgvItens_romaneio.RowCount.ToString()) + 1;
                    insert_itens.CommandText =
                        "INSERT INTO ITENS_ROMANEIO (COD_CTE_COLETA_IR, COD_ROMANEIO_IR, " +
                        "DESTINATARIO_IR, CNPJ_DESTINATARIO_IR, RECEBEDOR_IR, CNPJ_RECEBEDOR_IR, " +
                        "ENDERECO_REC_IR, N_REC_IR, COMPLEMENTO_REC_IR, BAIRRO_REC_IR, CIDADE_REC_IR, " +
                        "ESTADO_REC_IR, CEP_REC_IR, PESO_IR, VOLUMES_IR, CUBAGEM_IR, VALOR_CTE_IR, VALOR_CARGA_IR, " +
                        "ORDEM_ENTREGA_IR, DATA_CTE_COLETA_IR, TIPO_IR, CNPJ_EMITENTE_IR, JA_DEVOLVIDO_IR, CNPJ_REMETENTE_IR, REMETENTE_IR, FORMA_PGTO_IR, NF_IR)" +
                        "VALUES ('" + _n_cte + "','" + tb_romaneio_selecionado.Text + "','" +
                        _destinatario + "','" + _cnpj_destinatario + "','" +
                        _recebedor + "','" + _cnpj_recebedor + "','" +
                        _endereco_rec + "','" + _numero_recebedor + "','" +
                        _complemento_recebedor + "','" + _bairro_recebedor + "','" +
                        _cidade_recebedor + "','" + _estado_recebedor + "','" +
                        _cep_recebedor + "'," + _peso + ",'" +
                        _volumes + "','" + Convert.ToDouble(_cubagem).ToString().Replace(",", ".") + "','" +
                        Convert.ToDouble(_valor_cte).ToString().Replace(",", ".") + "','" +
                        Convert.ToDouble(_valor_carga).ToString().Replace(",", ".") + "','" +
                        ordem.ToString() + "','" +
                        Convert.ToDateTime(_data_cte).ToShortDateString().Replace("/", ".") + "','PEDIDO','" +
                        _cnpj_emitente + "'," + ja_foi_devolvido + ", '" + _cnpj_remetente + "','" + _remetente + "'," + forma_pgto + "," + n_nf + ")";

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
                                "UPDATE PEDIDOS_VENDA SET PLACA_PED_VENDA = '" + placaVeiculo + "'" +
                                " WHERE COD_PED_VENDA = '" + _n_cte + "'";
                            FbDataAdapter datTabelaCte = new FbDataAdapter();
                            datTabelaCte.UpdateCommand = updateCte;
                            datTabelaCte.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Erro ao inserir placa no PEDIDO");
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
                if(!venda_direta)
                    MessageBox.Show(retorno);
            }

        }

        private string buscar_peso(string n_nf)
        {
            string peso = "null";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT PESO_LIQUIDO_NF FROM NOTA_FISCAL nf " +
                    " WHERE N_NF = '" + n_nf + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        peso = "'" + Convert.ToDouble(dr[0].ToString()).ToString().Replace(".","").Replace(",",".") + "'";
                    }
                    catch { }
                    return peso;
                }
                return peso;
            }
            catch { fbConnection1.Close(); return peso; }
        }

        private string buscar_forma_pgto(string _n_cte, out string nf)
        {
            nf = "null";
            string retorno = "null";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT FORMA_PGTO_NF, N_NF FROM NOTA_FISCAL nf " +
                    "INNER JOIN PEDIDOS_NF pnf ON nf.N_NF = pnf.NF_PEDIDO_NF " +
                    " WHERE pnf.N_PEDIDO_NF = '" + _n_cte + "' AND nf.STATUS_NFE like '%Autorizada%'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    nf = dr[1].ToString();
                    return "'" + dr[0].ToString() + "'";
                }
                return retorno;
            }
            catch { fbConnection1.Close(); return retorno; }
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
            _endereco_rec = ""; _numero_recebedor = ""; _cnpj_remetente = ""; _remetente = "";
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
                    if (dr["CUBAGEM_CTE"].ToString() != "")
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
        private string buscar_cod_nfe(string _n_cte, string _cnpj_emitente, out string _destinatario,
    out string _cnpj_destinatario, out string _recebedor, out string _cnpj_recebedor,
    out string _endereco_rec, out string _numero_recebedor, out string _complemento_recebedor,
    out string _bairro_recebedor, out string _cidade_recebedor, out string _estado_recebedor,
    out string _cep_recebedor, out string _peso, out string _volumes,
    out string _cubagem, out string _valor_cte, out string _valor_carga,
    out string _cnpj_remetente, out string _remetente,
    out string ordem_coleta, out string _data_cte, out string _tipo)
        {
            _destinatario = ""; _cnpj_destinatario = ""; _recebedor = ""; _cnpj_recebedor = "";
            _endereco_rec = ""; _numero_recebedor = ""; _cnpj_remetente = ""; _remetente = "";
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
                    "SELECT * FROM NOTA_FISCAL WHERE " +
                    "N_NF = '" + _n_cte + "' ";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    _destinatario = retirar_caracteres(dr["CLIENTE_FORN_NF"].ToString());
                    _cnpj_destinatario = dr["CNPJ_CLIENTE_FORN"].ToString();
                    _recebedor = retirar_caracteres(dr["CLIENTE_FORN_NF"].ToString());
                    _cnpj_recebedor = "";// dr["CNPJ_PED_VENDA"].ToString();
                    _remetente = "";// retirar_caracteres(razao_social_empresa);
                    _cnpj_remetente = cnpj_empresa;
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
                    _peso = "0";// dr["PESO_CTE"].ToString();
                    _volumes = "0"; //dr["QTDE_VOLUMES_CTE"].ToString();
                    _valor_carga = dr["VALOR_NOTA_NF"].ToString();
                    // if (dr["CUBAGEM_CTE"].ToString() != "")
                    //     _cubagem = dr["CUBAGEM_CTE"].ToString();
                    //_valor_cte = dr["VALOR_TOTAL_CTE"].ToString();
                    _data_cte = dr["DATA_EMISSAO_NF"].ToString();
                    try
                    {
                        return dr["N_NF"].ToString();
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

        private string buscar_cod_pedido(string _n_cte, string _cnpj_emitente, out string _destinatario,
        out string _cnpj_destinatario, out string _recebedor, out string _cnpj_recebedor,
        out string _endereco_rec, out string _numero_recebedor, out string _complemento_recebedor,
        out string _bairro_recebedor, out string _cidade_recebedor, out string _estado_recebedor,
        out string _cep_recebedor, out string _peso, out string _volumes,
        out string _cubagem, out string _valor_cte, out string _valor_carga,
        out string _cnpj_remetente, out string _remetente,
        out string ordem_coleta, out string _data_cte, out string _tipo)
        {
            _destinatario = ""; _cnpj_destinatario = ""; _recebedor = ""; _cnpj_recebedor = "";
            _endereco_rec = ""; _numero_recebedor = ""; _cnpj_remetente = ""; _remetente = "";
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
                    "SELECT ped.*, c.NOME_FANTASIA FROM PEDIDOS_VENDA ped " + 
                    "INNER JOIN CLIENTES c on ped.CNPJ_PED_VENDA = c.CNPJ " + 
                    " WHERE " +
                    "ped.COD_PED_VENDA = '" + _n_cte + "' ";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    _destinatario = retirar_caracteres(dr["NOME_FANTASIA"].ToString());
                    _cnpj_destinatario = dr["CNPJ_PED_VENDA"].ToString();
                    _recebedor = retirar_caracteres(dr["CLIENTE_PED_VENDA"].ToString());
                    _cnpj_recebedor = "";// dr["CNPJ_PED_VENDA"].ToString();
                    _remetente = "";// retirar_caracteres(razao_social_empresa);
                    _cnpj_remetente = cnpj_empresa;
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
                    _peso = "0";// dr["PESO_CTE"].ToString();
                    _volumes = dr["QTDE_TOTAL_PED_VENDA"].ToString();
                    _valor_carga = dr["VALOR_TOTAL_PED_VENDA"].ToString();
                    // if (dr["CUBAGEM_CTE"].ToString() != "")
                    //     _cubagem = dr["CUBAGEM_CTE"].ToString();
                    //_valor_cte = dr["VALOR_TOTAL_CTE"].ToString();
                    _data_cte = dr["DATA_PED_VENDA"].ToString();
                    try
                    {
                        return dr["COD_PED_VENDA"].ToString();
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
            form_busca_romaneio rom = new form_busca_romaneio();
            string romaneio_selecionado = "";
            try
            {
                rom.ShowDialog();
                romaneio_selecionado = rom.n_romaneio;
                dsItens_romaneio.Clear();
            }
            finally
            {
                try
                {
                    dsRomaneio.Clear();
                    FbCommand sel = new FbCommand();
                    sel.Connection = fbConnection1;
                    sel.CommandText = "SELECT * FROM ROMANEIO WHERE COD_ROMANEIO = " + romaneio_selecionado;
                    fbConnection1.Open();
                    datRomaneio.SelectCommand = sel;
                    datRomaneio.Fill(ROMANEIO);
                    fbConnection1.Close();
                    tb_romaneio_selecionado.Text = dgvRomaneios.Rows[0].Cells[0].Value.ToString();
                    placaVeiculo = dgvRomaneios.Rows[0].Cells[1].Value.ToString();
                    selecionar_itens_romaneio(dgvRomaneios.Rows[0].Cells[0].Value.ToString());
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            salvar_itens_romaneio();
            inserir_romaneio_boleto();
        }

        private void inserir_romaneio_boleto()
        {
            for (int i = 0; i < dgvItens_romaneio.Rows.Count; i++)
            {
                try
                {
                    if (dgvItens_romaneio.Rows[i].Cells["col_devolvido"].Value.ToString() == "1")
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE CONTAS_A_RECEBER SET ROMANEIO_CR = null " +
                            "WHERE NF_CR = '" + dgvItens_romaneio.Rows[i].Cells["col_nf"].Value.ToString() + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                    }
                    else
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                           "UPDATE CONTAS_A_RECEBER SET ROMANEIO_CR = '" + dgvItens_romaneio.Rows[i].Cells["col_romaneio"].Value.ToString() + "' " +
                            "WHERE NF_CR = '" + dgvItens_romaneio.Rows[i].Cells["col_nf"].Value.ToString() + "'";
                        fbConnection1.Open();
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
            string buscaRomaneio = "", itemRomaneio = "";
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

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {

                dsRomaneio_transporte transp = new dsRomaneio_transporte();
                FbCommand select1 = new FbCommand();
                try
                {

                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    select1.CommandText =
                        "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                    FbDataAdapter datTabela1 = new FbDataAdapter();
                    datTabela1.SelectCommand = select1;
                    datTabela1.Fill(transp.EMPRESA);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    //MessageBox.Show(a.ToString());
                }

                FbCommand select = new FbCommand();
                try
                {

                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM ROMANEIO WHERE " +
                        "COD_ROMANEIO = '" + tb_romaneio_selecionado.Text + "' ";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(transp.ROMANEIO);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                // FbCommand select = new FbCommand();
                select.CommandText =
                    "select  prod.cod_produto, prod.descricao_produto, sum(iped.qtde_item_venda), prod.QTDE_UNIDADE_PRODUTO, prod.DESCRICAO_GRUPO_PRODUTO from itens_pedido_venda iped " +
                    "inner join itens_romaneio irom on irom.cod_cte_coleta_ir = iped.cod_pedido_item_venda " +
                    "inner join romaneio rom on rom.cod_romaneio = irom.cod_romaneio_ir " +
                    "inner join produtos prod on cast(iped.cod_prod_item_venda as varchar(30)) = cast(prod.COD_PRODUTO as varchar(30)) " + 
                    "where rom.cod_romaneio = " + tb_romaneio_selecionado.Text + " " +
                    "group by prod.DESCRICAO_GRUPO_PRODUTO, prod.descricao_produto, prod.cod_produto,  prod.QTDE_UNIDADE_PRODUTO order by 1 ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        int qtde_caixas = 0;
                        int sobra = 0;
                        int qtde_por_caixa = 0;
                        double qtde_produto = 0;
                        try { qtde_por_caixa = Convert.ToInt32(dr[3].ToString()); }
                        catch { }
                        try { qtde_produto = Convert.ToDouble(dr[2].ToString()); }
                        catch { }
                        if (qtde_por_caixa > 0)
                        {
                            double valor = qtde_produto;
                            int parteInteira = (int)valor;
                            double parteFracionaria = valor - parteInteira;
                            parteFracionaria = parteFracionaria * 10;

                            //dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2].ToString()),
                            //    parteInteira.ToString() + " cxs e " + parteFracionaria.ToString("n0") + " unid.", "");
                        }
                    }
                    catch { }
                }
                crRomaneio_Produtos novo_ped = new crRomaneio_Produtos();
                novo_ped.SetDataSource(transp);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();


            }
            catch { fbConnection1.Close(); }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {

                dsRomaneio_transporte transp = new dsRomaneio_transporte();
                FbCommand select1 = new FbCommand();
                try
                {

                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    select1.CommandText =
                        "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                    FbDataAdapter datTabela1 = new FbDataAdapter();
                    datTabela1.SelectCommand = select1;
                    datTabela1.Fill(transp.EMPRESA);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

                FbCommand select = new FbCommand();
                try
                {

                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM ROMANEIO WHERE " +
                        "COD_ROMANEIO = '" + tb_romaneio_selecionado.Text + "' ";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(transp.ROMANEIO);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                // FbCommand select = new FbCommand();
                select.CommandText =
                    "select prod.cod_produto, prod.descricao_produto, sum(iped.qtde_item_venda), prod.QTDE_UNIDADE_PRODUTO from itens_pedido_venda iped " +
                    "inner join itens_romaneio irom on irom.cod_cte_coleta_ir = iped.cod_pedido_item_venda " +
                    "inner join romaneio rom on rom.cod_romaneio = irom.cod_romaneio_ir " +
                    "inner join produtos prod on iped.cod_prod_item_venda = prod.COD_PRODUTO " +
                    "where rom.cod_romaneio = " + tb_romaneio_selecionado.Text + " AND irom.DEVOLVIDO_IR = '1'" +
                    "group by  prod.descricao_produto, prod.cod_produto, prod.QTDE_UNIDADE_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        int qtde_caixas = 0;
                        int sobra = 0;
                        int qtde_por_caixa = 0;
                        int qtde_produto = 0;
                        try { qtde_por_caixa = Convert.ToInt32(dr[3].ToString()); }
                        catch { }
                        try { qtde_produto = Convert.ToInt32(dr[2].ToString()); }
                        catch { }
                        qtde_caixas = qtde_produto / qtde_por_caixa;
                        sobra = qtde_produto % qtde_por_caixa;

                      //  transp.Produtos.AddProdutosRow(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2].ToString()), 
                       //     qtde_caixas.ToString() + " cxs e " + sobra.ToString() + " unid.", "");
                    }
                    catch { }
                }
                crRomaneio_retorno novo_ped = new crRomaneio_retorno();
                novo_ped.SetDataSource(transp);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();


            }
            catch { fbConnection1.Close(); }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {

                dsRomaneio_transporte transp = new dsRomaneio_transporte();
                FbCommand select1 = new FbCommand();
                try
                {

                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    select1.CommandText =
                        "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                    FbDataAdapter datTabela1 = new FbDataAdapter();
                    datTabela1.SelectCommand = select1;
                    datTabela1.Fill(transp.EMPRESA);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

                FbCommand select = new FbCommand();
                try
                {

                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM ROMANEIO WHERE " +
                        "COD_ROMANEIO = '" + tb_romaneio_selecionado.Text + "' ";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(transp.ROMANEIO);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                // FbCommand select = new FbCommand();
                select.CommandText =
                    "select  prod.cod_produto, prod.descricao_produto, sum(iped.qtde_item_venda), prod.QTDE_UNIDADE_PRODUTO, prod.DESCRICAO_GRUPO_PRODUTO from itens_pedido_venda iped " +
                    "inner join pedidos_venda pv on pv.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " + 
                    "inner join itens_romaneio irom on irom.cod_cte_coleta_ir = iped.cod_pedido_item_venda " +
                    "inner join romaneio rom on rom.cod_romaneio = irom.cod_romaneio_ir " +
                    "inner join produtos prod on iped.cod_prod_item_venda = prod.COD_PRODUTO " +
                    "where rom.cod_romaneio = " + tb_romaneio_selecionado.Text + " and TROCA_PED_VENDA = '1' " +
                    "group by prod.DESCRICAO_GRUPO_PRODUTO, prod.descricao_produto, prod.cod_produto,  prod.QTDE_UNIDADE_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        int qtde_caixas = 0;
                        int sobra = 0;
                        int qtde_por_caixa = 0;
                        int qtde_produto = 0;
                        try { qtde_por_caixa = Convert.ToInt32(dr[3].ToString()); }
                        catch { }
                        try { qtde_produto = Convert.ToInt32(dr[2].ToString()); }
                        catch { }
                        qtde_caixas = qtde_produto / qtde_por_caixa;
                        sobra = qtde_produto % qtde_por_caixa;

                       // transp.Produtos.AddProdutosRow(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2].ToString()), 
                       //     qtde_caixas.ToString() + " cxs e " + sobra.ToString() + " unid.", "");
                    }
                    catch { }
                }
                crRomaneio_Troca novo_ped = new  crRomaneio_Troca();
                novo_ped.SetDataSource(transp);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.Show();


            }
            catch { fbConnection1.Close(); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime dataRomaneio;
            if (txtRomaneio.Text != "")
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT DATA_ROMANEIO FROM ROMANEIO WHERE COD_ROMANEIO = '" + txtRomaneio.Text + "'";
                    select.Connection = fbConnection1;
                    FbDataAdapter datTable = new FbDataAdapter();
                    DataSet dsTable = new DataSet();
                    datTable.SelectCommand = select;
                    fbConnection1.Open();
                    datTable.Fill(dsTable);
                    fbConnection1.Close();
                    DataRow dr = dsTable.Tables[0].Rows[0];
                    if (dr[0].ToString().Trim() != "")
                    {
                        dataRomaneio = Convert.ToDateTime(dr[0].ToString());
                        dtData_atual.Value = dataRomaneio;
                        selecionar_romaneios_dia(dtData_atual.Text);
                        if (dgvRomaneios.RowCount > 0)
                        {
                            int linha = 0;
                            for (int i = 0; i < dgvRomaneios.RowCount; i++)
                            {
                                if (dgvRomaneios.Rows[i].Cells["col_cod"].Value.ToString() == txtRomaneio.Text)
                                {
                                    linha = i;
                                }
                            }
                            dgvRomaneios.Rows[linha].Selected = true;
                            dgvRomaneios.CurrentCell = dgvRomaneios.Rows[linha].Cells[0];
                        }
                        dsItens_romaneio.Clear();
                        tb_romaneio_selecionado.Text = txtRomaneio.Text;
                        selecionar_itens_romaneio(txtRomaneio.Text);
                    }
                    else
                    {
                        MessageBox.Show("Romaneio Não Encontrado");
                    }
                }
                catch (Exception a)
                {
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_romaneio_selecionado.Text == "")
                {
                    MessageBox.Show("Selecione um romaneio!");
                }
                else
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
                    datEmpresa.SelectCommand.CommandText = "select logotipo_empresa, cod_empresa from empresa where LICENCA_DLL_NFE_EMPRESA is not null";
                    datEmpresa.Fill(imprimir.EMPRESA);
                    fbConnection1.Close();


                    FbCommand select_itens = new FbCommand();
                    select_itens.CommandText =
                   "select  prod.cod_produto, prod.descricao_produto, sum(iped.qtde_item_venda), prod.QTDE_UNIDADE_PRODUTO, prod.DESCRICAO_GRUPO_PRODUTO, irom.ORDEM_ENTREGA_IR, iped.cod_item_venda from itens_pedido_venda iped " +
                   "inner join itens_romaneio irom on irom.cod_cte_coleta_ir = iped.cod_pedido_item_venda " +
                   "inner join romaneio rom on rom.cod_romaneio = irom.cod_romaneio_ir " +
                   "inner join produtos prod on cast(iped.cod_prod_item_venda as varchar(30)) = cast(prod.COD_PRODUTO as varchar(30)) " +
                   "inner join pedidos_venda ped on ped.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +
                   "where rom.cod_romaneio = " + tb_romaneio_selecionado.Text + " " +
                   "group by prod.DESCRICAO_GRUPO_PRODUTO, prod.descricao_produto, prod.cod_produto, prod.QTDE_UNIDADE_PRODUTO, irom.ORDEM_ENTREGA_IR, iped.cod_item_venda " +
                   "order by iped.cod_item_venda" ;
                    select_itens.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_itens = new FbDataAdapter();
                    datSelect_itens.SelectCommand = select_itens;
                    DataTable dtSelect = new DataTable();
                    datSelect_itens.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        try
                        {
                            /*
                            int qtde_caixas = 0;
                            int sobra = 0;
                            int qtde_por_caixa = 0;
                            int qtde_produto = 0;
                            try { qtde_por_caixa = Convert.ToInt32(dr[3].ToString()); }
                            catch { }
                            try { qtde_produto = Convert.ToInt32(dr[2].ToString()); }
                            catch { }
                            if (qtde_por_caixa > 0)
                            {
                                qtde_caixas = qtde_produto / qtde_por_caixa;
                                sobra = qtde_produto % qtde_por_caixa;
                            }
                            imprimir.Produtos_itens.AddProdutos_itensRow(dr[0].ToString(), dr[1].ToString(), 
                                Convert.ToDouble(dr[2].ToString()), qtde_caixas.ToString() + " cxs e " + sobra.ToString() + " unid.", 
                                Convert.ToInt32(dr[5].ToString()));
                             * */
                            int qtde_caixas = 0;
                            int sobra = 0;
                            int qtde_por_caixa = 0;
                            double qtde_produto = 0;
                            try { qtde_por_caixa = Convert.ToInt32(dr[3].ToString()); }
                            catch { }
                            try { qtde_produto = Convert.ToDouble(dr[2].ToString()); }
                            catch { }
                            if (qtde_por_caixa > 0)
                            {
                                double valor = qtde_produto;
                                int parteInteira = (int)valor;
                                double parteFracionaria = valor - parteInteira;
                                parteFracionaria = parteFracionaria * 10;
                                imprimir.Produtos_itens.AddProdutos_itensRow(dr[0].ToString(), dr[1].ToString(),
                               Convert.ToDouble(dr[2].ToString()), parteInteira.ToString() + " cxs e " + parteFracionaria.ToString("n0") + " unid.",
                               Convert.ToInt32(dr[5].ToString()));
                                //transp.Produtos.AddProdutosRow(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2].ToString()), parteInteira.ToString() + " cxs e " + parteFracionaria.ToString("n0") + " unid.");
                            }
                        }
                        catch { }
                    }



                    crRomaneio_transporte_itens novo_ped = new crRomaneio_transporte_itens();
                    novo_ped.SetDataSource(imprimir);
                    form_imprimir imprime = new form_imprimir(novo_ped);
                    imprime.Show();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                vend.Dispose();
                tb_vendedor.Text = vend.vendedor_escolhido;
            }
        }
        
        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                salvar_itens_romaneio();
                salvar_romaneios();
                puxar_pedidos_da_venda_direta_no_romaneio(tb_romaneio_selecionado.Text);
                puxar_nf_coletadas_no_dia(tb_romaneio_selecionado.Text);
                //ao criar o romaneio colocar um valor de saida + os ticket a receber de saida
                // calcular agora os itens que sairam (pedidos saida, nfs pegas no caminho)
                FbCommand select = new FbCommand();
                select.CommandText =
                       "select  prod.cod_produto, prod.descricao_produto, sum(iped.qtde_item_venda) as qtde_item, prod.QTDE_UNIDADE_PRODUTO " +
                       "from itens_pedido_venda iped " +
                       "inner join pedidos_venda pv on pv.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +
                       "inner join itens_romaneio irom on irom.cod_cte_coleta_ir = iped.cod_pedido_item_venda " +
                       "inner join romaneio rom on rom.cod_romaneio = irom.cod_romaneio_ir " +
                       "inner join produtos prod on cast(iped.cod_prod_item_venda as varchar(30)) = cast(prod.COD_PRODUTO as varchar(30)) " +
                       "where rom.cod_romaneio = " + tb_romaneio_selecionado.Text + " AND (pv.SAIDA_VENDA_DIRETA_PED_VENDA = '1') "  +
                       " and (irom.DEVOLVIDO_IR = 0 or irom.DEVOLVIDO_IR is null) " +
                       "group by prod.descricao_produto, prod.cod_produto,  prod.QTDE_UNIDADE_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect_saida = new DataTable();
                datSelect.Fill(dtSelect_saida);
                fbConnection1.Close();

                // calcular os itens que foram entregues (pedidos normais que foram entregues + pedidos da venda_direta)
                select.CommandText =
                       "select  prod.cod_produto as cod, prod.descricao_produto, sum(iped.qtde_item_venda) as qtde_entregue " +
                       "from itens_pedido_venda iped " +
                       "inner join pedidos_venda pv on pv.COD_PED_VENDA = iped.COD_PEDIDO_ITEM_VENDA " +
                       "inner join itens_romaneio irom on irom.cod_cte_coleta_ir = iped.cod_pedido_item_venda " +
                       "inner join romaneio rom on rom.cod_romaneio = irom.cod_romaneio_ir " +
                       "inner join produtos prod on cast(iped.cod_prod_item_venda as varchar(30)) = cast(prod.COD_PRODUTO as varchar(30)) " +
                       "where rom.cod_romaneio = " + tb_romaneio_selecionado.Text + " AND  (pv.SAIDA_VENDA_DIRETA_PED_VENDA = '0' or pv.SAIDA_VENDA_DIRETA_PED_VENDA is null)" +
                       " and (irom.DEVOLVIDO_IR = 0 or irom.DEVOLVIDO_IR is null) " +
                       "group by prod.descricao_produto, prod.cod_produto, prod.QTDE_UNIDADE_PRODUTO ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                datSelect.SelectCommand = select;
                DataTable dtSelect_entregues = new DataTable();
                datSelect.Fill(dtSelect_entregues);
                fbConnection1.Close();

                dsRomaneio_transporte romaneio = new dsRomaneio_transporte();
                FbCommand select1 = new FbCommand();
                try
                {

                    select1.Connection = fbConnection1;
                    fbConnection1.Open();
                    select1.CommandText =
                        "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                    FbDataAdapter datTabela1 = new FbDataAdapter();
                    datTabela1.SelectCommand = select1;
                    datTabela1.Fill(romaneio.EMPRESA);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    //MessageBox.Show(a.ToString());
                }

                //FbCommand select = new FbCommand();
                try
                {

                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT * FROM ROMANEIO WHERE " +
                        "COD_ROMANEIO = '" + tb_romaneio_selecionado.Text + "' ";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(romaneio.ROMANEIO);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

                
                foreach (DataRow dr in dtSelect_saida.Rows)
                {
                    try
                    {
                        string cod = dr["cod_produto"].ToString();
                        string descricao = dr["descricao_produto"].ToString();
                        string qtde_saida = dr["qtde_item"].ToString();
                        string qtde_entregues = "0,00";
                        foreach (DataRow dr_entregas in dtSelect_entregues.Select("cod = '" + cod + "'"))
                            qtde_entregues = dr_entregas["qtde_entregue"].ToString();

                        double qtde_retorno = Convert.ToDouble(qtde_saida) - Convert.ToDouble(qtde_entregues);
                        double qtde_cx = 1;
                        try
                        {
                           qtde_cx = Convert.ToDouble(dr["QTDE_UNIDADE_PRODUTO"].ToString());
                        }
                        catch { }

                        int qtde_caixas = 0, sobra = 0;
                        if (qtde_cx >= 1)
                        {
                            try
                            {
                                qtde_caixas = Convert.ToInt32(qtde_retorno) / Convert.ToInt32(qtde_cx);
                                sobra = Convert.ToInt32(qtde_retorno) % Convert.ToInt32(qtde_cx);
                            }
                            catch { }
                        }
                        

                        romaneio.ProdutosxRetorno.AddProdutosxRetornoRow(cod, descricao, Convert.ToDouble(qtde_saida),
                            Convert.ToDouble(qtde_entregues), qtde_retorno, qtde_caixas.ToString() + " cxs e " + sobra.ToString() + " unid.");

                    }
                    catch { }

                }

                //selecionando totais de formas_pgto
                select.CommandText =
                       "select  pv.COND_PGTO_PED_VENDA, sum(pv.VALOR_TOTAL_PED_VENDA) as valor " +
                       "from pedidos_venda pv " +
                       "inner join itens_romaneio irom on irom.cod_cte_coleta_ir = pv.cod_ped_venda " +
                       "inner join romaneio rom on rom.cod_romaneio = irom.cod_romaneio_ir " +
                       "where rom.cod_romaneio = " + tb_romaneio_selecionado.Text + " AND  (pv.SAIDA_VENDA_DIRETA_PED_VENDA = '0' or pv.SAIDA_VENDA_DIRETA_PED_VENDA is null)" +
                       " and (irom.DEVOLVIDO_IR = 0 or irom.DEVOLVIDO_IR is null) " +
                       "group by pv.COND_PGTO_PED_VENDA ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                datSelect.SelectCommand = select;
                DataTable dtSelect_pgto = new DataTable();
                datSelect.Fill(dtSelect_pgto);
                fbConnection1.Close();

                string nome_vendedor = "";
                DateTime data = new DateTime();
                double valor_entregue_saida = 0;
                buscar_dados_romaneio(tb_romaneio_selecionado.Text, out nome_vendedor, out data, out valor_entregue_saida);

                double a_vista = 0, a_prazo = 0, outros = 0;
                foreach (DataRow dr in dtSelect_pgto.Rows)
                {
                    try
                    {
                        if (dr[0].ToString().Substring(0, 1) == "0")
                            a_vista = Convert.ToDouble(dr[1].ToString());
                        else if (dr[0].ToString().Substring(0, 1) == "1")
                            a_prazo = Convert.ToDouble(dr[1].ToString());
                        else if (dr[0].ToString().Substring(0, 1) == "2")
                            outros = Convert.ToDouble(dr[1].ToString());
                        else outros = Convert.ToDouble(dr[1].ToString());
                    }
                    catch { outros = Convert.ToDouble(dr[1].ToString()); }
                }

                romaneio.ValoresxRetorno.AddValoresxRetornoRow(valor_entregue_saida, a_vista + a_prazo + outros, a_prazo, a_vista, outros);

                crRetorno_venda_direta novo_ped = new crRetorno_venda_direta();
                novo_ped.SetDataSource(romaneio);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.ShowDialog();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            
            // calcular a diferença entre saida - entrada
            // calcular totais dos valores em dinheiro e boleto
        }

        private void puxar_nf_coletadas_no_dia(string cod_romaneio)
        {
            try
            {
                try
                {
                    string vendedor = "";
                    DateTime data_romaneio = new DateTime();
                    double valor_entregue = 0;
                    buscar_dados_romaneio(cod_romaneio, out vendedor, out data_romaneio, out valor_entregue);


                    FbCommand select = new FbCommand();
                    select.CommandText =
                      //  "SELECT COD_PEDIDO FROM PEDIDOS_VENDA WHERE VENDEDOR_PED_VENDA = '" + vendedor + "' " +
                     //   "AND DATA_EMISSAO_PED = '" + data_romaneio.ToShortDateString().Replace("/", ".") + "' and NF_ENTRADA_PED_VENDA IS NOT NULL ";
                    "SELECT COD_PED_VENDA FROM PEDIDOS_VENDA WHERE VENDEDOR_PED_VENDA = '" + vendedor + "' " +
                "AND DATA_PED_VENDA = '" + data_romaneio.ToShortDateString().Replace("/", ".") + "'  and NF_ENTRADA_PED_VENDA IS NOT NULL ";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        adicionar_pedido(dr[0].ToString(), cnpj_empresa, true);
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }
                /*
                DateTime dia_romaneio = new DateTime();
                string vendedor = "";
                buscar_dados_romaneio(tb_romaneio_selecionado.Text, out vendedor, out dia_romaneio);
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText = 
                    "SELECT * FROM NOTA_FISCAL_ENT nf " + 
                    "INNER JOIN ITENS_NOTA_ENT 
                */

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void puxar_pedidos_da_venda_direta_no_romaneio(string cod_romaneio)
        {
            try
            {
                string vendedor = "";
                DateTime data_romaneio = new DateTime();
                double valor_entregue = 0;
                buscar_dados_romaneio(cod_romaneio, out vendedor, out data_romaneio, out valor_entregue);


                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_PED_VENDA FROM PEDIDOS_VENDA WHERE VENDEDOR_PED_VENDA = '" + vendedor + "' " + 
                    "AND DATA_PED_VENDA = '" + data_romaneio.ToShortDateString().Replace("/",".") + "' and VENDA_DIRETA_PED_VENDA = '1' ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                     adicionar_pedido(dr[0].ToString(), cnpj_empresa, true);
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void buscar_dados_romaneio(string cod_romaneio, out string vendedor, out DateTime data_romaneio, out double valor_saida)
        {
            vendedor = "";
            DateTime dt = new DateTime(2000, 1, 1);
            data_romaneio = dt;
            valor_saida = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM ROMANEIO WHERE COD_ROMANEIO = '" + cod_romaneio + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    vendedor = dr["VENDEDOR_ROMANEIO"].ToString();
                    data_romaneio = Convert.ToDateTime(dr["DATA_ROMANEIO"].ToString());
                    try
                    {
                        valor_saida = Convert.ToDouble(dr["VALOR_ROMANEIO"].ToString());
                    }
                    catch { }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void dgvItens_romaneio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
         * string caminho = @"c:\\evolucao\\NEOGRID\CSV_ESTOQUE_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\NEOGRID\RELVEN_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                { //13324184000197
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                     "select DISTINCT(prod.*) from PRODUTOS prod " +
                     //   "where prod.nome_fornecedor_produto like '%VIGOR%' AND prod.STATUS_PRODUTO = '1' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                     "where prod.nome_fornecedor_produto like '%VIGOR%' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        string qtde = "0.00";
                        try
                        {
                            double _qtde = 0;
                            try
                            {
                                _qtde = Convert.ToDouble(dr["ESTOQUE_ATUAL_PRODUTO"].ToString());
                                if (_qtde < 0)
                                    _qtde = 0;
                            }
                            catch { }
                            qtde = _qtde.ToString("n2");
                        }
                        catch { }
                        texto.WriteLine(dr["COD_PRODUTO"].ToString() + ";" + dr["COD_BARRAS_PRODUTO"].ToString() + ";" + dr["DESCRICAO_PRODUTO"].ToString() + ";" +*/
        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = @"c:\\evolucao\\roteirizacao\CSV_ROMANEIO_" + tb_romaneio_selecionado.Text + ".csv";
                if (criar_arquivo(caminho))
                {
                    FileInfo t = new FileInfo(caminho);
                    using (StreamWriter texto = t.CreateText())
                    {

                        FbCommand select = new FbCommand();
                        select.CommandText =
                        "SELECT * FROM ITENS_ROMANEIO ir WHERE ir.COD_ROMANEIO_IR LIKE '" +
                        tb_romaneio_selecionado.Text + "' " +
                        " ORDER BY ORDEM_ENTREGA_IR";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        fbConnection1.Close();
                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            texto.WriteLine(dr["ENDERECO_REC_IR"].ToString().Replace(";", "") + ";" + dr["N_REC_IR"].ToString() + ";" + dr["CIDADE_REC_IR"].ToString().Replace(";", "") + ";" +
                                dr["ESTADO_REC_IR"].ToString() + ";BRASIL;" + dr["CEP_REC_IR"].ToString() + ";;;;;" + dr["VALOR_CARGA_IR"].ToString() +
                                ";;" + dr["COD_CTE_COLETA_IR"].ToString() + " - " + dr["DESTINATARIO_IR"].ToString().Replace(";", "") + ";");
                        }
                    }
                }

                
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        public Boolean criar_arquivo(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(Name);
                Arquivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}