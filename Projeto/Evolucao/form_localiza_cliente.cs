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
    public partial class form_localiza_cliente : Form
    {
        public string cliente_escolhido;
        public string cnpj_escolhido;
        public string estado_escolhido;
        public string cod_escolhido;
        public string cnpj_a_buscar;
        public bool _cadastro;
        public bool pesquisa_fornecedor;
        public bool nf;
        public string cnpj_empresa;
        public form_localiza_cliente(bool cadastro, string cnpj_empresa)
        {
            InitializeComponent();
            if (!cadastro)
            {
                button1.Visible = false;
            }
            _cadastro = cadastro;
            this.cnpj_empresa = cnpj_empresa;

        }

        private void form_localiza_cliente_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = dsClientes.Tables["CLIENTES"];
            if (cnpj_a_buscar != "" && cnpj_a_buscar != null)
            {
                selecionar(cnpj_a_buscar);
                dgvClientes.Focus(); dgvClientes.CurrentCell = dgvClientes.Rows[0].Cells[0];
            }
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "RAZAO_SOCIAL LIKE UPPER('*" + tb_localiza.Text + "*')";
                totalizar_clientes();
            }
            catch { }
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_cadastro)
            {
                cliente_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_razao"].Value.ToString();
                cnpj_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cnpj"].Value.ToString();
                estado_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_estado"].Value.ToString();
                cod_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                this.Close();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_cadastro)
                {
                    cliente_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_razao"].Value.ToString();
                    cnpj_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cnpj"].Value.ToString();
                    estado_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_estado"].Value.ToString();
                    cod_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                    this.Close();
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_clientes cli = new form_clientes(cnpj_empresa);
            try
            {
                cli.fornecedor = pesquisa_fornecedor;
                cli.ShowDialog();
            }
            finally
            {
                cli.Dispose();
                datClientes.Fill(CLIENTES);
            }
        }

        private void tb_nome_fantasia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "NOME_FANTASIA LIKE '*" + tb_nome_fantasia.Text + "*'";
                totalizar_clientes();
            }
            catch { }
        }

        private void tb_cnpj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "CNPJ LIKE '" + tb_cnpj.Text + "*'";
                totalizar_clientes();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selecionar("%");

        }

        private void selecionar(string cnpj)
        {
            string clausula_where = "";
            try
            {
                if (tb_nome_fornecedor.Text != "" && !rbPositivados.Checked && !rbNao_positivados.Checked)
                {
                    MessageBox.Show("Quando o Fornecedor está selecionado, é obrigatório selecionar positivados ou não positivados");
                }
                else
                {
                    string localiza = "";
                    if (cnpj == "")
                        cnpj = "%";
                    if (tb_localiza.Text != "")
                        localiza = " AND UPPER(RAZAO_SOCIAL) LIKE UPPER('%" + tb_localiza.Text + "%')";
                    string vendedor = "", join_vendedor = "";
                    if (txtCodVendedor.Text != "")
                    {
                        join_vendedor = " INNER JOIN VENDEDOres_CLIENTE vc on vc.COD_CLIENTE_VC = c.COD_CLIENTE ";
                        vendedor = " AND vc.COD_VENDEDOR_VC = '" + txtCodVendedor.Text + "'";
                    }

                    string fornecedor = "", join_fornecedor = "";
                    if (tb_nome_fornecedor.Text != "")
                    {
                        join_fornecedor = " INNER JOIN PRODUTOS prod on prod.COD_PRODUTO = item.COD_ITEM ";
                        fornecedor = " AND prod.CNPJ_FORNECEDOR_PRODUTO = '" + tb_cod_fornecedor.Text + "'";
                    }

                    string tabelas = "";
                    if (tb_cod_tabela.Text != "")
                        tabelas = " AND COD_TP_CLIENTE = '" + tb_cod_tabela.Text + "'";

                    string ativos = "";
                    if (cbxClientesAtivos.Checked)
                        ativos = " AND ATIVO_CLIENTE = '1' ";
                    string desativos = "";
                    if (cbxClientesInativos.Checked)
                        desativos = " AND (ATIVO_CLIENTE = '0' OR ATIVO_CLIENTE IS NULL) ";


                    string join_positivados = "", positivados = "", qtde_nfs = "";
                    if (rbPositivados.Checked || rbNao_positivados.Checked)
                    {
                        join_positivados = "INNER JOIN NOTA_FISCAL nf ON nf.CNPJ_CLIENTE_FORN = c.CNPJ  INNER JOIN ITENS_NOTA item ON item.NF_ITEM = nf.N_NF ";
                        positivados = " and (nf.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                            "nf.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "') AND STATUS_NFE LIKE '%Autorizada%' and (item.CFOP_ITEM = '5102' OR item.CFOP_ITEM = '5405')";
                        if (cbContar_notas.Checked)
                        {
                            qtde_nfs = " , (SELECT count(DISTINCT(nf1.N_NF)) FROM NOTA_FISCAL nf1 " +
                                " inner join ITENS_NOTA inf1 ON nf1.N_NF = inf1.NF_ITEM " +
                                " WHERE 0 = 0 AND nf1.CNPJ_CLIENTE_FORN = c.CNPJ " +
                                " and (nf1.DATA_EMISSAO_NF >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                                " nf1.DATA_EMISSAO_NF <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") +
                                "') AND nf1.STATUS_NFE LIKE '%Autorizada%' and (inf1.CFOP_ITEM = '5102' OR inf1.CFOP_ITEM = '5405')) AS QTDE_NFS ";
                        }
                    }
                    string _fornecedor = "";// " AND (FORNECEDOR_CLIENTE IS NULL OR FORNECEDOR_CLIENTE = '0') ";
                   // if(pesquisa_fornecedor)
                   //     _fornecedor = " AND FORNECEDOR_CLIENTE = '1' ";
                   // if (nf)
                  //      _fornecedor = "";
                    clausula_where = "SELECT distinct(c.*) " + qtde_nfs + " FROM CLIENTES c " +
                        //  "LEFT JOIN forma_pgto fp ON fp.cod_forma_pgto = c.forma_pagamento_cliente " + 
                    join_vendedor +
                    join_positivados +
                    join_fornecedor +
                    "where CNPJ like '" +
                    cnpj + "%' " + localiza +
                    positivados +  _fornecedor +
                    vendedor + fornecedor + ativos + desativos + tabelas  + " ORDER BY RAZAO_SOCIAL";

                    dsClientes.Clear();
                    datClientes.SelectCommand.CommandText = clausula_where;

                    datClientes.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datClientes.SelectCommand.ExecuteNonQuery();
                    datClientes.Fill(dsClientes.Tables["CLIENTES"]);
                    fbConnection1.Close();

                    string n_positivados = "";
                    DataSet dsTodos = new DataSet();

                    if (rbNao_positivados.Checked)
                    {


                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        select.CommandText =
                            "SELECT distinct(c.*) " + qtde_nfs + " FROM CLIENTES c " +
                            //  "LEFT JOIN forma_pgto fp ON fp.cod_forma_pgto = c.forma_pagamento_cliente " + 
                   join_vendedor +
                   "where CNPJ like '" +
                   cnpj + "%' " + localiza +
                            //positivados +
                   vendedor + ativos + desativos + " ORDER BY RAZAO_SOCIAL";
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        fbConnection1.Open();
                        datSelect.Fill(dsTodos);
                        fbConnection1.Close();
                        foreach (DataRow dr_positivados in dsClientes.Tables[0].Rows)
                        {
                            foreach (DataRow dr in dsTodos.Tables[0].Select("COD_CLIENTE = " + dr_positivados["COD_CLIENTE"].ToString()))
                            {
                                dr.Delete();
                            }
                        }
                        dsClientes = dsTodos;
                        dsClientes.Tables[0].TableName = "CLIENTES";
                    }

                    dgvClientes.AutoGenerateColumns = false;
                    dgvClientes.DataSource = dsClientes.Tables["CLIENTES"];

                    totalizar_clientes();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void totalizar_clientes()
        {
            labelTotal_clientes.Text = "Total: " + dgvClientes.RowCount.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selecionar(tb_cnpj.Text);
        }

        private void tb_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                selecionar(tb_cnpj.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selecionar("%");

        }

        private void dgvClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                //                if(linha = dgvClientes.RowCount)

                int linha = 0;
                //if (dgvClientes.CurrentRow.Index == dgvClientes.RowCount - 1)
                //    linha = dgvClientes.CurrentRow.Index;
                //else
                    linha = dgvClientes.CurrentRow.Index - 1;
                cliente_escolhido = dgvClientes.Rows[linha].Cells["col_razao"].Value.ToString();
                cnpj_escolhido = dgvClientes.Rows[linha].Cells["col_cnpj"].Value.ToString();
                estado_escolhido = dgvClientes.Rows[linha].Cells["col_estado"].Value.ToString();
                cod_escolhido = dgvClientes.Rows[linha].Cells["col_cod"].Value.ToString();
                this.Close();
            }
        }

        private void tb_localiza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                selecionar("%");
            }
        }



        private void cbxClientesAtivos_Click(object sender, EventArgs e)
        {
           cbxClientesInativos.Checked = false;
           // //if (cbxClientesAtivos.Checked)
           //// {
           // //    dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "ativo_cliente = 1";
           // }
           // else
           // {
           //     dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "cod_cliente IS NOT NULL";
           // }
        }

        private void cbxClientesInativos_Click(object sender, EventArgs e)
        {
            cbxClientesAtivos.Checked = false;
            //if (cbxClientesInativos.Checked)
            //{
            //    dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "ativo_cliente = 0 or ";
            //}
            //else
            //{
            //    dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "cod_cliente IS NOT NULL";
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form_vendedores vendedores = new form_vendedores();

            try
            {
                vendedores.ShowDialog();
            }
            finally
            {
                txtCodVendedor.Text = vendedores.cod_vendedor_escolhido;
                txtNomeVendedor.Text = vendedores.vendedor_escolhido;

                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dsClientes clientes = new dsClientes();
                //datClientes.Fill(clientes.CLIENTES);
                string obs = "";
                if(rbPositivados.Checked)
                    obs = "Positivados";
                else
                    obs = "Não Positivados";

                if (tb_nome_fornecedor.Text != "")
                    obs += " - " + tb_nome_fornecedor.Text;
               
                for (int i = 0; i < dgvClientes.RowCount; i++)
                {
                    try
                    {
                        clientes.CLIENTES.AddCLIENTESRow(Convert.ToInt32(dgvClientes.Rows[i].Cells[0].Value.ToString()),
                            dgvClientes.Rows[i].Cells[2].Value.ToString(), dgvClientes.Rows[i].Cells[3].Value.ToString(),
                            "", "", dgvClientes.Rows[i].Cells[4].Value.ToString(),
                            dgvClientes.Rows[i].Cells[6].Value.ToString(),
                            dgvClientes.Rows[i].Cells[7].Value.ToString(), "", "",
                            dgvClientes.Rows[i].Cells[11].Value.ToString(),
                            "", "", "", "", "", "", "", dgvClientes.Rows[i].Cells[1].Value.ToString(), "", "", "", "", "",
                            "", "", "", DateTime.Now, "", "", "", "", "", "", "", "",
                            dgvClientes.Rows[i].Cells[5].Value.ToString(), "", 0, "", "", 1, DateTime.Now, 0, 0, "", "", "",
                            "", "", "", "", "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, "", "", 0, 0);
                    }
                    catch { }
                }
                string tipo = "Clientes";
                if(pesquisa_fornecedor)
                    tipo = "Fornecedores";
                clientes.Informacoes.AddInformacoesRow(txtNomeVendedor.Text, obs, 
                    dtInicial.Text, dtFinal.Text, tipo);

                crClientes listagemClientes = new crClientes();
                listagemClientes.SetDataSource(clientes);

                form_imprimir imprimirListagem = new form_imprimir(listagemClientes);
                imprimirListagem.Show();
            }
            catch(Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }

            
        }

        private void tb_bairro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "BAIRRO LIKE '*" + tb_bairro.Text + "*'";
                totalizar_clientes();
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá trocar o vendedor do cliente, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3"  || usuario._cod_usuario == "4")
                        {
                            form_vendedores vendedores = new form_vendedores();
                            string novo_vendedor, cod_novo_vendedor;
                            try
                            {
                                vendedores.ShowDialog();
                            }
                            finally
                            {
                                cod_novo_vendedor = vendedores.cod_vendedor_escolhido;
                                novo_vendedor = vendedores.vendedor_escolhido;
                                if (novo_vendedor != "")
                                {
                                    for (int i = 0; i < dgvClientes.SelectedRows.Count; i++)
                                    {
                                        try
                                        {
                                            if (!cb_adic_vend.Checked)
                                            {
                                                FbCommand delete = new FbCommand();
                                                delete.CommandText =
                                                    "DELETE FROM vendedores_cliente WHERE cod_cliente_vc = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                                delete.Connection = fbConnection1;
                                                fbConnection1.Open();
                                                FbDataAdapter datDelete = new FbDataAdapter();
                                                datDelete.DeleteCommand = delete;
                                                datDelete.DeleteCommand.ExecuteNonQuery();
                                                fbConnection1.Close();
                                            }

                                            FbCommand insereVendedor = new FbCommand();
                                            insereVendedor.CommandText =
                                                 "INSERT INTO vendedores_cliente (cod_cliente_vc, cod_vendedor_vc, nome_vendedor_vc) VALUES ('" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "', " +
                                                 cod_novo_vendedor + ", '" + novo_vendedor + "')";
                                            FbDataAdapter datVendedores = new FbDataAdapter();
                                            datVendedores.InsertCommand = insereVendedor;
                                            datVendedores.InsertCommand.Connection = fbConnection1; ;
                                            fbConnection1.Open();
                                            datVendedores.InsertCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.ToString());
                                        }

                                    }

                                }


                            }

                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }

                    }
                    MessageBox.Show("Acerto Realizado!");
                   
                    
                }


            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_cadastro)
            {
                form_clientes cli = new form_clientes(cnpj_empresa);
                try
                {
                    string cnpj = dgvClientes.Rows[e.RowIndex].Cells["col_cnpj"].Value.ToString();
                    cli.fornecedor = pesquisa_fornecedor;
                    cli.consulta = true;
                    cli.cliente_consulta = cnpj;
                    cli.ShowDialog();
                }
                finally
                {
                    selecionar("%");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá trocar o dia de visita do cliente, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3"  || usuario._cod_usuario == "4")
                        {
                            form_dia_visita dia = new form_dia_visita();
                            try
                            {
                                dia.ShowDialog();
                            }
                            finally
                            {
                                if (dia.cod_dia_visita != "")
                                {
                                    for (int i = 0; i < dgvClientes.SelectedRows.Count; i++)
                                    {
                                        try
                                        {
                                            FbCommand update = new FbCommand();
                                            update.CommandText =
                                                "UPDATE CLIENTES SET DIA_VISITA_CLIENTE = '" + dia.cod_dia_visita +
                                                "' WHERE COD_CLIENTE = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                            update.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.DeleteCommand = update;
                                            datUpdate.DeleteCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "CIDADE LIKE '*" + tb_cidade.Text + "*'";
                totalizar_clientes();
            }
            catch { }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "DIA_VISITA_CLIENTE LIKE '*" + tb_dia_visita.Text + "*'";
                totalizar_clientes();
            }
            catch { }
        }

        private string buscar_cod_tp(string descricao_tp)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                 "SELECT tp.COD_TABELA_PRECO FROM ITENS_TP itp " +
              "INNER JOIN TABELA_PRECO tp on tp.COD_TABELA_PRECO = itp.COD_TABELA_ITEM_TP " +
              "WHERE tp.NOME_TABELA_PRECO = '" + descricao_tp + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "0";
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá trocar a tabela de preços do(s) cliente(s)? Tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3"  || usuario._cod_usuario == "4")
                        {

                            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
                            try
                            {
                                localiza_cliente.ShowDialog();
                            }
                            finally
                            {
                                localiza_cliente.Dispose();
                                

                                if (localiza_cliente.cod_escolhido != "")
                                {
                                    for (int i = 0; i < dgvClientes.SelectedRows.Count; i++)
                                    {
                                        try
                                        {

                                            try
                                            {
                                                //apagando registros existentes
                                                string _cod_tp = buscar_cod_tp(dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString());
                                                try
                                                {
                                                    FbCommand delete = new FbCommand();
                                                    delete.CommandText =
                                                        "DELETE FROM TABELA_PRECO WHERE COD_TABELA_PRECO = '" + _cod_tp + "'";
                                                    delete.Connection = fbConnection1;
                                                    fbConnection1.Open();
                                                    FbDataAdapter datDelete = new FbDataAdapter();
                                                    datDelete.DeleteCommand = delete;
                                                    datDelete.DeleteCommand.ExecuteNonQuery();
                                                    fbConnection1.Close();
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                    fbConnection1.Close();
                                                }

                                                try
                                                {
                                                    FbCommand delete = new FbCommand();
                                                    delete.CommandText =
                                                        "DELETE FROM ITENS_TP WHERE COD_TABELA_ITEM_TP = '" + _cod_tp + "'";
                                                    delete.Connection = fbConnection1;
                                                    fbConnection1.Open();
                                                    FbDataAdapter datDelete = new FbDataAdapter();
                                                    datDelete.DeleteCommand = delete;
                                                    datDelete.DeleteCommand.ExecuteNonQuery();
                                                    fbConnection1.Close();
                                                }
                                                catch (Exception ex)
                                                {
                                                    //MessageBox.Show(ex.Message);
                                                    fbConnection1.Close();
                                                }



                                                FbCommand select = new FbCommand();
                                                select.Connection = fbConnection1;
                                                fbConnection1.Open();
                                                select.CommandText =
                                                  "SELECT itp.* FROM ITENS_TP itp " +
                                                  "INNER JOIN TABELA_PRECO tp on tp.COD_TABELA_PRECO = itp.COD_TABELA_ITEM_TP " +
                                                  "WHERE tp.NOME_TABELA_PRECO = '" + localiza_cliente.cod_escolhido + "'";
                                                FbDataAdapter datSelect = new FbDataAdapter();
                                                datSelect.SelectCommand = select;
                                                DataTable dtSelect = new DataTable();
                                                datSelect.Fill(dtSelect);
                                                fbConnection1.Close();
                                                object cod_tp = new object();
                                                if (dtSelect.Rows.Count > 0)
                                                {
                                                    FbCommand insert = new FbCommand();
                                                    insert.Connection = fbConnection1;
                                                    insert.CommandText =
                                                                "INSERT INTO TABELA_PRECO (NOME_TABELA_PRECO)" +
                                                                "VALUES ('" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "') RETURNING COD_TABELA_PRECO";
                                                    fbConnection1.Open();
                                                    FbDataAdapter datInsert = new FbDataAdapter();
                                                    datInsert.InsertCommand = insert;
                                                    cod_tp = datInsert.InsertCommand.ExecuteScalar();
                                                    fbConnection1.Close();

                                                    FbCommand update = new FbCommand();
                                                    update.CommandText =
                                                        "UPDATE CLIENTES SET COD_TP_CLIENTE = '" + cod_tp.ToString() +
                                                        "', DESCRICAO_TP_CLIENTE = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() +
                                                        "' WHERE COD_CLIENTE = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                                    update.Connection = fbConnection1;
                                                    fbConnection1.Open();
                                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                                    datUpdate.DeleteCommand = update;
                                                    datUpdate.DeleteCommand.ExecuteNonQuery();
                                                    fbConnection1.Close();
                                                }
                                                foreach (DataRow dr in dtSelect.Rows)
                                                {
                                                    FbCommand insertItens = new FbCommand();
                                                    insertItens.Connection = fbConnection1;
                                                    insertItens.CommandText =
                                                   "INSERT INTO ITENS_TP (COD_TABELA_ITEM_TP, COD_PRODUTO_ITEM_TP, DESCRICAO_PRODUTO_ITEM_TP, PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP)" +
                                                               "VALUES ('" + cod_tp.ToString() + "','" + dr["COD_PRODUTO_ITEM_TP"].ToString() + "','" + dr["DESCRICAO_PRODUTO_ITEM_TP"].ToString() + "','" +
                                                    Convert.ToDouble(dr["PRECO_PRODUTO_ITEM_TP"].ToString()).ToString().Replace(".", "").Replace(",", ".") + "','" +
                                                    Convert.ToDouble(dr["PRECO_MINIMO_ITEM_TP"].ToString()).ToString().Replace(".", "").Replace(",", ".") + "')";
                                                    fbConnection1.Open();
                                                    FbDataAdapter datInsertItens = new FbDataAdapter();
                                                    datInsertItens.InsertCommand = insertItens;
                                                    datInsertItens.InsertCommand.ExecuteNonQuery();
                                                    fbConnection1.Close();
                                                }
                                                
                                            }
                                            catch (Exception ex)
                                            {
                                                fbConnection1.Close();
                                                MessageBox.Show(ex.Message);
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
                        }
                    }
                }
            }
        

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá trocar a tabela de preços do(s) cliente(s)? Tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3"  || usuario._cod_usuario == "4")
                        {
                            form_forma_pgto tab = new form_forma_pgto();
                            try
                            {
                                tab.busca_forma_escolhida = true;
                                tab.ShowDialog();
                            }
                            finally
                            {
                                // localizarTabela(tab._cod, tab._descricao);

                                if (tab.cod_forma_pgto_escolhida != "")
                                {
                                    for (int i = 0; i < dgvClientes.SelectedRows.Count; i++)
                                    {
                                        try
                                        {
                                            FbCommand update = new FbCommand();
                                            update.CommandText =
                                                "UPDATE CLIENTES SET FORMA_PAGAMENTO_CLIENTE = '" + tab.cod_forma_pgto_escolhida +
                                                "' WHERE COD_CLIENTE = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                            update.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.DeleteCommand = update;
                                            datUpdate.DeleteCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAddFornecedores_Click(object sender, EventArgs e)
        {
            form_localiza_forn fornecedores = new form_localiza_forn(false, "");

            try
            {
                fornecedores.ShowDialog();
            }
            finally
            {
                fornecedores.Dispose();
                tb_nome_fornecedor.Text = fornecedores.razao_forn_escolhido;
                tb_cod_fornecedor.Text = fornecedores.cnpj_escolhido;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá desativar os clientes, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3"  || usuario._cod_usuario == "4")
                        {
                            for (int i = 0; i < dgvClientes.SelectedRows.Count; i++)
                            {
                                try
                                {
                                    FbCommand update = new FbCommand();
                                    update.CommandText =
                                        "UPDATE CLIENTES SET ATIVO_CLIENTE = NULL WHERE COD_CLIENTE = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                    update.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.DeleteCommand = update;
                                    datUpdate.DeleteCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(a.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form_localiza_tabela_preco tab = new form_localiza_tabela_preco();
            try
            {
                tab.ShowDialog();
            }
            finally
            {
                tb_cod_tabela.Text = tab._cod;
                tb_nome_tabela_preco.Text = tab._descricao;
            }
        
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá trocar o desconto do cliente, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3"  || usuario._cod_usuario == "4")
                        {
                            form_desconto_pontualidade dia = new form_desconto_pontualidade();
                            try
                            {
                                dia.ShowDialog();
                            }
                            finally
                            {
                                if (dia.desconto > 0)
                                {
                                    for (int i = 0; i < dgvClientes.SelectedRows.Count; i++)
                                    {
                                        try
                                        {
                                            FbCommand update = new FbCommand();
                                            update.CommandText =
                                                "UPDATE CLIENTES SET DESCONTO_PONTUALIDADE_CLIENTE = '" + dia.desconto.ToString().Replace(",",".") +
                                                "', DESCONTO_VALOR_CLIENTE = '" + dia.desconto_valor.ToString() + 
                                                "', DESCONTO_INSTRUCAO_CLIENTE = '" + dia.desconto_pontualidade.ToString() + "' " + 
                                                "WHERE COD_CLIENTE = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                            update.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.DeleteCommand = update;
                                            datUpdate.DeleteCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
        if (DialogResult.Yes == MessageBox.Show("Essa operação irá trocar o roteiro do cliente, tem certeza?",
              "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3"  || usuario._cod_usuario == "4")
                        {
                            form_roteiro dia = new form_roteiro();
                            try
                            {
                                dia.ShowDialog();
                            }
                            finally
                            {
                                if (dia.roteiro > 0)
                                {
                                    for (int i = 0; i < dgvClientes.SelectedRows.Count; i++)
                                    {
                                        try
                                        {
                                            FbCommand update = new FbCommand();
                                            update.CommandText =
                                                "UPDATE CLIENTES SET COD_ROTEIRO_CLIENTE = '" + dia.roteiro.ToString().Replace(",",".") +
                                                "' WHERE COD_CLIENTE = '" + dgvClientes.SelectedRows[i].Cells["col_cod"].Value.ToString() + "'";
                                            update.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.DeleteCommand = update;
                                            datUpdate.DeleteCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.ToString());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        
        }

        private void tb_roteiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "COD_ROTEIRO_CLIENTE = '" + tb_roteiro.Text + "'";
                totalizar_clientes();
            }
            catch
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "0 = 0 ";
                totalizar_clientes();
            }
        }

            

        
    }
}