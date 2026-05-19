using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using FirebirdSql.Data.FirebirdClient;
using System.Collections;
using Evolucao.Modelos;

namespace Evolucao
{
    public partial class form_crono_excel : Form
    {
        public form_crono_excel()
        {
            InitializeComponent();
        }

        private void form_crono_excel_Load(object sender, EventArgs e)
        {
            preencher_cidades();
        }

        DataTable dtCidades = new DataTable();
        private void preencher_cidades()
        {
            try
            {

                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Mun$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(dtCidades);
                theConnection.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.Message);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCrono.RowCount - 1; i++)
            {

                try
                {
                    string valor_venda = "null", cst = "null";
                    string cod_forn = "null", ncm = "null", descricao = "null", marca = "null", unidade = "null", custo = "null",
                        ipi = "null", icms = "null", iva = "null", descricao_item = "null", cfop_item = "null", local_item = "null", estoque_item = "null";

                    if (dgvCrono.Rows[i].Cells[6].Value.ToString() != "")
                    {
                        try
                        {

                            cst = dgvCrono.Rows[i].Cells[6].Value.ToString();
                            if (cst[0].ToString() == "0")
                            {
                                cst = "'0 - Nacional'";
                            }
                            if (cst[0].ToString() == "1")
                            {
                                cst = "'1 - Estrangeira - Importação direta'";
                            }
                            if (cst[0].ToString() == "2")
                            {
                                cst = "'2 - Estrangeira - Adquirida no mercado interno'";
                            }
                            cst = "" + cst.Replace("`", "") + "";
                        }
                        catch { }
                    }
                    if (dgvCrono.Rows[i].Cells[1].Value.ToString() != "")
                        local_item = "'" + dgvCrono.Rows[i].Cells[1].Value.ToString() + "'";
                    if (dgvCrono.Rows[i].Cells[2].Value.ToString() != "")
                        estoque_item = "'" + dgvCrono.Rows[i].Cells[2].Value.ToString() + "'";
                    if (dgvCrono.Rows[i].Cells[3].Value.ToString() != "")
                        cod_forn = "'" + dgvCrono.Rows[i].Cells[3].Value.ToString() + "'";
                    if (dgvCrono.Rows[i].Cells[5].Value.ToString() != "")
                        ncm = "'" + dgvCrono.Rows[i].Cells[5].Value.ToString() + "'";
                    if (dgvCrono.Rows[i].Cells[7].Value.ToString() != "")
                        descricao = "'" + dgvCrono.Rows[i].Cells[7].Value.ToString() + "'";
                    if (dgvCrono.Rows[i].Cells[8].Value.ToString() != "")
                        marca = "'" + dgvCrono.Rows[i].Cells[8].Value.ToString() + "'";
                    if (dgvCrono.Rows[i].Cells[9].Value.ToString() != "")
                        unidade = "'" + dgvCrono.Rows[i].Cells[9].Value.ToString() + "'";

                    if (dgvCrono.Rows[i].Cells[11].Value.ToString() != "")
                        ipi = "'" + dgvCrono.Rows[i].Cells[11].Value.ToString().Replace(".", "").Replace(",", ".").Replace("%", "") + "'";
                    if (dgvCrono.Rows[i].Cells[12].Value.ToString() != "")
                        icms = "'" + dgvCrono.Rows[i].Cells[12].Value.ToString().Replace(".", "").Replace(",", ".").Replace("%", "") + "'";
                    if (dgvCrono.Rows[i].Cells[13].Value.ToString() != "")
                        iva = "'" + dgvCrono.Rows[i].Cells[13].Value.ToString().Replace(".", "").Replace(",", ".").Replace("%", "") + "'";
                    if (dgvCrono.Rows[i].Cells[14].Value.ToString() != "")
                        descricao_item = "'" + dgvCrono.Rows[i].Cells[14].Value.ToString() + "'";
                    if (descricao_item == "'''")
                        descricao_item = "null";
                    if (dgvCrono.Rows[i].Cells[19].Value.ToString() != "")
                        cfop_item = "'" + dgvCrono.Rows[i].Cells[19].Value.ToString() + "'";
                    else
                        cfop_item = "'5403'";
                    try
                    {
                        double bc_com_ipi, valor_icms_normal, valor_icms_com_st, valor_ipi;
                        double bc_normal = Convert.ToDouble(dgvCrono.Rows[i].Cells[10].Value.ToString());
                        valor_ipi = bc_normal * Convert.ToDouble(dgvCrono.Rows[i].Cells[11].Value.ToString()) / 100;
                        bc_com_ipi = bc_normal + valor_ipi;
                        valor_icms_normal = Convert.ToDouble(dgvCrono.Rows[i].Cells[12].Value.ToString()) / 100 * bc_normal;
                        valor_icms_com_st = (bc_com_ipi + (bc_com_ipi * Convert.ToDouble(dgvCrono.Rows[i].Cells[13].Value.ToString()) / 100)) * Convert.ToDouble(dgvCrono.Rows[i].Cells[12].Value.ToString()) / 100 - valor_icms_normal;
                        double valor_custo_total = bc_normal + valor_ipi + valor_icms_com_st;

                        string _custo_total = "null";
                        if (valor_custo_total > 0)
                            _custo_total = valor_custo_total.ToString("n2").Replace(".", "").Replace(",", ".");

                        if (dgvCrono.Rows[i].Cells[10].Value.ToString() != "")
                            custo = "'" + _custo_total + "'";
                        if (custo == "'null'")
                            custo = "null";

                        double venda = valor_custo_total * 2;

                        if (venda > 0)
                            valor_venda = "'" + venda.ToString("n2").Replace(".", "").Replace(",", ".") + "'";
                    }
                    catch
                    {

                    }
                    this.datProdutos.InsertCommand.CommandText =
                    "INSERT INTO PRODUTOS (COD_FORNECEDOR_PRODUTO, NCM_PRODUTO, DESCRICAO_PRODUTO, MARCA_PRODUTO, COD_UNIDADE_PRODUTO, CUSTO_PRODUTO, " +
                    "ALIQUOTA_IPI_PRODUTO, ALIQUOTA_ICMS_PRODUTO, IVA_PRODUTO, DESCRICAO_ITEM_PRODUTO, VALOR_VENDA_PRODUTOR_PRODUTO, ORIGEM_PRODUTO, " +
                    "CFOP_ENTRADA_PRODUTO, LOCAL_PRODUTO, ESTOQUE_ATUAL_PRODUTO) " +
                    "VALUES (" + cod_forn + "," + ncm + "," + descricao + "," + marca + "," + unidade + "," + custo + "," +
                    ipi + "," + icms + "," + iva + "," + descricao_item + "," + valor_venda + "," + cst + "," +
                    cfop_item + "," + local_item + "," + estoque_item + ")";
                    this.fbConnection1.Open();
                    this.datProdutos.InsertCommand.Connection = fbConnection1;
                    this.datProdutos.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    /*
                    try
                    {
                        if (Convert.ToInt32(estoque_item) > 0)
                        {
                            this.datItens_nf_entrada.InsertCommand.CommandText =
                    "INSERT INTO ITENS_NF_ENTRADA (COD_FORNECEDOR_PRODUTO, NCM_PRODUTO, DESCRICAO_PRODUTO, MARCA_PRODUTO, COD_UNIDADE_PRODUTO, CUSTO_PRODUTO, " +
                    "ALIQUOTA_IPI_PRODUTO, ALIQUOTA_ICMS_PRODUTO, IVA_PRODUTO, DESCRICAO_ITEM_PRODUTO, VALOR_VENDA_PRODUTOR_PRODUTO, ORIGEM_PRODUTO, " +
                    "CFOP_ENTRADA_PRODUTO, LOCAL_PRODUTO, ESTOQUE_ATUAL_PRODUTO) " +
                    "VALUES (" + cod_forn + "," + ncm + "," + descricao + "," + marca + "," + unidade + "," + custo + "," +
                    ipi + "," + icms + "," + iva + "," + descricao_item + "," + valor_venda + "," + cst + "," +
                    cfop_item + "," + local_item + "," + estoque_item + ")";
                            this.fbConnection1.Open();
                            this.datItens_nf_entrada.InsertCommand.Connection = fbConnection1;
                            this.datItens_nf_entrada.InsertCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 
                        }
                    }
                    catch
                    {
                        fbConnection1.Close(); 
                    }
                     * */
                    try
                    {
                        int j = i % 2000;

                        if (j == 0)
                        {
                            MessageBox.Show(i.ToString());
                        }

                    }

                    catch { }
                }
                catch
                {
                    fbConnection1.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\produtos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Result$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE PRODUTOS SET CNPJ_FORNECEDOR_PRODUTO = '14998371004530', NOME_FORNECEDOR_PRODUTO = 'J. MACEDO S.A.'" +
                            " WHERE COD_BARRAS_PRODUTO = '" + dr[3].ToString() + "'";
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        fbConnection1.Open();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_CLIENTE, CNPJ FROM CLIENTES";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                DataTable dtSelect = new DataTable();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE CLIENTES SET CNPJ = '" + dr[1].ToString().Replace("/", "").Replace(" ", "")
                        .Replace("-", "").Replace(".", "") + "' WHERE COD_CLIENTE = '" + dr[0].ToString() + "'";
                        fbConnection1.Open();
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
                }
                //PEDIDOS
                FbCommand select2 = new FbCommand();
                select2.CommandText =
                    "SELECT COD_PED_VENDA, CNPJ_PED_VENDA FROM PEDIDOS_VENDA";
                select2.Connection = fbConnection1;
                fbConnection1.Open();
                DataTable dtSelect2 = new DataTable();
                FbDataAdapter datSelect2 = new FbDataAdapter();
                datSelect2.SelectCommand = select2;
                datSelect2.Fill(dtSelect2);
                fbConnection1.Close();
                foreach (DataRow dr2 in dtSelect2.Rows)
                {
                    try
                    {
                        FbCommand update2 = new FbCommand();
                        update2.Connection = fbConnection1;
                        update2.CommandText =
                            "UPDATE PEDIDOS_VENDA SET CNPJ_PED_VENDA = '" + dr2[1].ToString().Replace("/", "").Replace(" ", "")
                        .Replace("-", "").Replace(".", "") + "' WHERE COD_PED_VENDA = '" + dr2[0].ToString() + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate2 = new FbDataAdapter();
                        datUpdate2.UpdateCommand = update2;
                        datUpdate2.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }

                //NOTAS
                FbCommand select3 = new FbCommand();
                select3.CommandText =
                    "SELECT COD_SISTEMA_NF, CNPJ_CLIENTE_FORN FROM NOTA_FISCAL";
                select3.Connection = fbConnection1;
                fbConnection1.Open();
                DataTable dtSelect3 = new DataTable();
                FbDataAdapter datSelect3 = new FbDataAdapter();
                datSelect3.SelectCommand = select3;
                datSelect3.Fill(dtSelect3);
                fbConnection1.Close();
                foreach (DataRow dr3 in dtSelect3.Rows)
                {
                    try
                    {
                        FbCommand update3 = new FbCommand();
                        update3.Connection = fbConnection1;
                        update3.CommandText =
                            "UPDATE NOTA_FISCAL SET CNPJ_CLIENTE_FORN = '" + dr3[1].ToString().Replace("/", "").Replace(" ", "")
                        .Replace("-", "").Replace(".", "") + "' WHERE COD_SISTEMA_NF = '" + dr3[0].ToString() + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate3 = new FbDataAdapter();
                        datUpdate3.UpdateCommand = update3;
                        datUpdate3.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }



            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\clientes-vigor.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [CLIENTES$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE clientes SET classificacao_clientes = " + dr[3].ToString() + " " +
                                "WHERE cod_cliente = " + dr[0].ToString();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/estoque.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
            DataSet theDS = new DataSet();
            theDataAdapter.Fill(theDS);
            int i = 0;

            try
            {
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO NOTA_FISCAL_ENT (N_NF_ENT, CNPJ_CLIENTE_FORN_ENT, CLIENTE_FORN_NF_ENT, DATA_EMISSAO_NF_ENT, DATA_ENTR_SAI_NF_ENT,BAIXADA_NF_ENT) " +
                    "VALUES ('99999', '88304001000766', 'Harald Ind.e Com de Alimentos Ltda', '29.06.2014', '29.06.2014', 1)";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.InsertCommand = insert;
                datTabela.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

            string cod_sistema_ultima_nf_ent = buscar_ultimo_cod_nf_sistema();
            foreach (DataRow dr in theDS.Tables[0].Rows)
            {
                FbDataAdapter datClientes = new FbDataAdapter();
                FbDataAdapter datItens_nota_ent = new FbDataAdapter();

                try
                {

                    string codProduto, descricao, qtde, un, codEan;

                    if (i > 0)
                    {
                        codProduto = dr[0].ToString().Replace(".", "").Trim();
                        descricao = dr[1].ToString();
                        un = "UN";
                        //codEan = dr[3].ToString();

                        qtde = dr[2].ToString().Replace(".", "").Replace(",", ".");
                        codEan = buscarEan(codProduto);
                        try
                        {
                            //INSERT ENTRADA PRODUTO
                            FbCommand insert_itens = new FbCommand();
                            insert_itens.Connection = fbConnection1;
                            fbConnection1.Open();
                            insert_itens.CommandText =
                            "INSERT INTO itens_nota_ent " +
                                "(descricao_item_ent, qtde_item_ent, nf_item_ent, data_insercao_item_ent_nota, cod_item_ent, cod_sistema_nf_item_ent, baixado_item_ent, unidade_item_ent, cod_ean_item_ent) " +
                                "VALUES ('" + descricao + "'," + qtde + ",'99999','29.06.2014','" + codProduto + "','" + cod_sistema_ultima_nf_ent + "','1','" + un + "', '" + codEan + "')";
                            datItens_nota_ent.InsertCommand = insert_itens;
                            datItens_nota_ent.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch
                        {
                            fbConnection1.Close();
                        }
                        /*classeEstoque est = new classeEstoque();
                        est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        est.acertarEstoqueProdutosIni(codProduto);*/
                    }
                    i = i + 1;
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
            MessageBox.Show("Entrada efetuada com sucesso!");
        }

        private string buscarEan(string codProduto)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_BARRAS_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = '" + codProduto + "'";
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

        private string buscar_ultimo_cod_nf_sistema()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_SISTEMA_NF_ENT FROM NOTA_FISCAL_ENT ORDER BY COD_SISTEMA_NF_ENT DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "0";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0";
            }
        }

        private void btnClassificarJmacedo_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\tabela-todos-os-produtos-jmacedo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Produtos$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE produtos SET cnpj_fornecedor_produto = '14998371004530', nome_fornecedor_produto = 'J. MACEDO S.A.' " +
                                "WHERE cod_produto = " + dr[0].ToString();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("Produtos classificados com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnClassificarFarinhasJmacedo_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\farinhas-jmacedo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Produtos$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE produtos SET cod_grupo_produto = 1, descricao_grupo_produto = 'FARINHA' " +
                                "WHERE cod_produto = " + dr[0].ToString();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("Farinhas classificadas com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnClassificarMixJmacedo_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\mix-jmacedo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Produtos$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE produtos SET cod_grupo_produto = 2, descricao_grupo_produto = 'MIX' " +
                                "WHERE cod_produto = " + dr[0].ToString();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("Mix classificados com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT CHAVE_NF_CNF, COD_CNF FROM CTE_NOTAS_FISCAIS";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                DataTable dtSelect = new DataTable();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE CTE_NOTAS_FISCAIS C SET C.CHAVE_NF_CNF = '" + dr[0].ToString().Replace(" ", "")
                            + "' WHERE C.COD_CNF = '" + dr[1].ToString() + "'";
                        fbConnection1.Open();
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
                }
            }
            catch
            {
            }
        }

        private void btnImportarQtdeUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\qtdeestoque.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE produtos SET cod_unidade_produto = '" + dr[1].ToString() + "', descricao_unidade_produto = '" + dr[2].ToString() + "', qtde_unidade_produto = " + dr[3].ToString() +
                                "WHERE cod_produto = " + dr[0].ToString();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("Qtdes das unidades importadas com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }


        private void btnAtualizarCodBarrasHarald_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\produtos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE produtos SET cod_barras_caixa_produto = '" + dr[5].ToString() + "'" +
                                "WHERE cod_fornecedor_produto like '" + dr[0].ToString() + "'";
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("Códigos de barras das caixas dos produtos foram atualizados com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnRecalcularEstoqueHarald_Click(object sender, EventArgs e)
        {
            DataTable dtProdutos = new DataTable();

            try
            {
                /*SELECIONAR PRODUTOS HARALD*/
                datProdutos.SelectCommand.CommandText =
                    "SELECT p.* " +
                    "FROM produtos p " +
                    "WHERE p.cnpj_fornecedor_produto like '88304001000766' " +
                    "ORDER BY p.cod_produto";
                datProdutos.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datProdutos.SelectCommand.ExecuteNonQuery();
                datProdutos.Fill(dtProdutos);
                fbConnection1.Close();

                /*RECALCULAR E ATUALIZAR O SALDO DE CADA PRODUTO HARALD*/
                for (int i = 0; i < dtProdutos.Rows.Count; i++)
                {
                    //classeEstoque estoque = new classeEstoque();
                    //estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                    //estoque.calcular_estoque(dtProdutos.Rows[i]["cod_barras_caixa_produto"].ToString(),
                    //    dtProdutos.Rows[i]["cod_barras_produto"].ToString(), dtProdutos.Rows[i]["qtde_unidade_produto"].ToString(),
                    //    dtProdutos.Rows[i]["cnpj_fornecedor_produto"].ToString(), dtProdutos.Rows[i]["cod_produto"].ToString());
                }

                MessageBox.Show("Estoque Harald Recalculado com sucesso!");
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Houve um erro ao recalcular o estoque da Harald!\nErro: " + a.Message);
            }
        }

        private void btnMarcarBarrinhasHarald_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\barrinhas-harald.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE produtos SET cod_sub_grupo_produto = 1, descricao_sub_grupo_produto = 'BARRINHAS' " +
                                "WHERE cod_produto = " + dr[0].ToString();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("As barrinhas Harald foram marcadas com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnRecalcularEstoqueJmacedo_Click(object sender, EventArgs e)
        {
            DataTable dtProdutos = new DataTable();
            try
            {
                /*SELECIONAR PRODUTOS JMACEDO*/
                datProdutos.SelectCommand.CommandText =
                    "SELECT p.* " +
                    "FROM produtos p " +
                    "WHERE p.cnpj_fornecedor_produto like '14998371004530' " +
                    "ORDER BY p.cod_produto";
                datProdutos.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datProdutos.SelectCommand.ExecuteNonQuery();
                datProdutos.Fill(dtProdutos);
                fbConnection1.Close();

                ///*RECALCULAR E ATUALIZAR O SALDO DE CADA PRODUTO JMACEDO*/
                //for (int i = 0; i < dtProdutos.Rows.Count; i++)
                //{
                //    classeEstoque estoque = new classeEstoque();
                //    estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                //    estoque.calcular_estoque(dtProdutos.Rows[i]["cod_barras_caixa_produto"].ToString(), dtProdutos.Rows[i]["cod_barras_produto"].ToString(),
                //        dtProdutos.Rows[i]["qtde_unidade_produto"].ToString(), dtProdutos.Rows[i]["cnpj_fornecedor_produto"].ToString(), dtProdutos.Rows[i]["cod_produto"].ToString());
                //}

                MessageBox.Show("Estoque JMacedo Recalculado com sucesso!");
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Houve um erro ao recalcular o estoque da JMacedo!\nErro: " + a.Message);
            }
        }

        private void btnInativarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\produtos-inativos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE produtos SET status_produto = '0'" +
                                "WHERE cod_fornecedor_produto like '" + dr[0].ToString() + "'";
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("Produtos inativados com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnInativarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\clientes-inativos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (theDS.Tables[0].Rows.IndexOf(dr) > 0)
                    {
                        //MessageBox.Show(dr[0].ToString());
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE clientes SET ativo_cliente = 0 " +
                                "WHERE cod_cliente = " + dr[0].ToString();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            fbConnection1.Open();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();

                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.Message);
                        }
                    }
                }

                MessageBox.Show("Os clientes inativos foram atualizados com sucesso!");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ArrayList erro = new ArrayList();
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT distinct(i.cod_ean_item_ent) FROM ITENS_NOTA_ENT I " +
                    "join nota_fiscal_ent n on i.nf_item_ent = n.n_nf_ent " +
                    "WHERE n.cnpj_cliente_forn_ent = '14998371004530' " +
                    "and (i.cod_ean_item_ent is not null or i.cod_ean_item_ent <> '')";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                DataTable dtSelect = new DataTable();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    string codEan = dr[0].ToString();
                    FbCommand selectProduto = new FbCommand();
                    selectProduto.CommandText =
                        "SELECT * FROM PRODUTOS P " +
                        "WHERE (p.cod_barras_produto = '" + codEan + "' " +
                        "OR p.cod_barras_caixa_produto = '" + codEan + "')";
                    selectProduto.Connection = fbConnection1;
                    fbConnection1.Open();
                    DataTable dtSelectProduto = new DataTable();
                    FbDataAdapter datSelectProduto = new FbDataAdapter();
                    datSelectProduto.SelectCommand = selectProduto;
                    datSelectProduto.Fill(dtSelectProduto);
                    fbConnection1.Close();
                    string cod = "";
                    foreach (DataRow drP in dtSelectProduto.Rows)
                    {
                        cod = dr[0].ToString();
                    }
                    if (cod == "")
                    {
                        erro.Add(codEan);
                    }
                }
                MessageBox.Show("Concluído");
                string a = "pausa";
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT distinct(COD_SISTEMA_PROD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA WHERE COD_PROD_ITEM_VENDA IS NULL AND COD_SISTEMA_PROD_ITEM_VENDA IS NOT NULL";//COD_SISTEMA_PROD_ITEM_VENDA COD_ITEM_VENDA
                select.Connection = fbConnection1;
                fbConnection1.Open();
                DataTable dtSelect = new DataTable();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        string codItem, codProduto, codForn;
                        codProduto = dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString();
                        select = new FbCommand();
                        select.CommandText =
                            "SELECT COD_FORNECEDOR_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = '" + codProduto + "'";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        DataTable dtSelect2 = new DataTable();
                        FbDataAdapter datSelect2 = new FbDataAdapter();
                        datSelect2.SelectCommand = select;
                        datSelect2.Fill(dtSelect2);
                        fbConnection1.Close();
                        DataRow dr2 = dtSelect2.Rows[0];
                        codForn = dr2[0].ToString();

                        if (codForn != "" && codForn != null)
                        {
                            FbCommand insertItem = new FbCommand();
                            try
                            {
                                insertItem.Connection = fbConnection1;
                                insertItem.CommandText =
                                    "UPDATE ITENS_PEDIDO_VENDA SET COD_PROD_ITEM_VENDA = '" + codForn +
                                    "' WHERE COD_PROD_ITEM_VENDA IS NULL AND COD_SISTEMA_PROD_ITEM_VENDA = '" + codProduto + "'";
                                fbConnection1.Open();
                                insertItem.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                            catch (Exception a)
                            {

                                fbConnection1.Close();
                            }
                        }
                    }
                    catch (Exception a)
                    {

                        fbConnection1.Close();
                    }
                }
            }
            catch (Exception a)
            {

                fbConnection1.Close();
            }
            MessageBox.Show("Fim");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\familias.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        double peso = 0, valor_promocao = 0, valor_produto = 0;
                        string familia = "";
                        if (dr[0].ToString() != "")
                        {
                            if (dr[2].ToString().ToUpper() == "X")
                            {
                                FbCommand delete = new FbCommand();
                                delete.Connection = fbConnection1;
                                delete.CommandText =
                                    "DELETE FROM PRODUTOS WHERE COD_PRODUTO = '" + dr[0].ToString() + "'";
                                FbDataAdapter datDelete = new FbDataAdapter();
                                datDelete.DeleteCommand = delete;
                                fbConnection1.Open();
                                datDelete.DeleteCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                            else
                            {
                                try
                                {
                                    peso = Convert.ToDouble(dr[2].ToString());
                                }
                                catch { }

                                try
                                {
                                    valor_promocao = Convert.ToDouble(dr[4].ToString());
                                }
                                catch { }


                                try
                                {
                                    valor_produto = Convert.ToDouble(dr[3].ToString());
                                }
                                catch { }

                                try
                                {
                                    familia = dr[7].ToString();
                                }
                                catch { }

                                FbCommand update = new FbCommand();
                                update.Connection = fbConnection1;
                                update.CommandText =
                                    "UPDATE PRODUTOS SET PESO_UNIT_PRODUTO = '" + peso.ToString().Replace(".", "").Replace(",", ".") +
                                    "', VALOR_PROMOCAO_PRODUTO = '" + valor_promocao.ToString().Replace(".", "").Replace(",", ".") + "', " +
                                    "VALOR_VENDA_REVEND_PRODUTO = '" + valor_produto.ToString().Replace(".", "").Replace(",", ".") +
                                    "', NOME_FAMILIA_PRODUTO = '" + familia + "' " +
                                    "WHERE COD_PRODUTO = '" + dr[0].ToString() + "'";
                                fbConnection1.Open();
                                FbDataAdapter datUpdate = new FbDataAdapter();
                                datUpdate.UpdateCommand = update;
                                datUpdate.UpdateCommand.ExecuteNonQuery();
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
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT DISTINCT (NOME_FAMILIA_PRODUTO) FROM PRODUTOS";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                int i = 1;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        insert.CommandText =
                            "INSERT INTO FAMILIA_PRODUTO (COD_FP, FAMILIA_FP) VALUES ('" + i.ToString() + "', '" + dr[0].ToString() + "')";
                        fbConnection1.Open();
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close();


                        i++;
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\classificacao.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        insert.CommandText =
                            "INSERT INTO CLASSIFICACAO_CLIENTES (COD, DESCRICAO) VALUES ('" + dr[0].ToString() + "', '" + dr[1].ToString() + "')";
                        fbConnection1.Open();
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        fbConnection1.Close();



                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }
        }

        private string retirar_caracteres_depois(string palavra)
        {
            string retorno = palavra.Replace("  ", "").Replace("'", "").Replace("&", "e").Replace("\"", "").Replace("'", "");
            try
            {
                if (retorno[retorno.Length - 1].ToString() == " ")
                    retorno = retorno.Remove(retorno.Length - 1);
            }
            catch { }

            return retorno;
        }

        //DataSet theDS = new DataSet();
        private string buscar_cod_mun(string _cidade, string _estado)
        {
            try
            {

                foreach (DataRow dr in dtCidades.Select("F3 = '" + _cidade.ToUpper().Replace("\t", "") + "' AND F1 = '" + _estado + "'"))
                {
                    return dr[1].ToString();
                }

                return "";
            }
            catch
            {
                return "";
            }
        }

        private string buscar_cod_cliente(string _cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_CLIENTE FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "";

            }

            catch { return ""; }
        }

        private string buscar_cod_vendedor(string codUsuario)
        {
            try
            {
                FbCommand select = new FbCommand();
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_VENDEDOR FROM VENDEDORES WHERE NOME_VENDEDOR = '" + codUsuario + "'";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "";

            }

            catch { return ""; }
        }

        private void inserir_vendedor_cliente(string _cnpj, string nomeUsuario)
        {
            try
            {
                string codigoCliente = buscar_cod_cliente(_cnpj);
                string nomeVendedor = nomeUsuario;
                string codVendedor = buscar_cod_vendedor(nomeUsuario);
                if (nomeVendedor != "")
                {
                    FbConnection conexao = new FbConnection();
                    conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                    FbCommand insereVendedor = new FbCommand();
                    insereVendedor.CommandText =
                         "INSERT INTO vendedores_cliente (cod_cliente_vc, cod_vendedor_vc, nome_vendedor_vc) VALUES ('" + codigoCliente + "', " + codVendedor + ", '" + nomeVendedor + "')";
                    FbDataAdapter datVendedores = new FbDataAdapter();
                    datVendedores.InsertCommand = insereVendedor;
                    datVendedores.InsertCommand.Connection = conexao;
                    conexao.Open();
                    datVendedores.InsertCommand.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception a)
            {

            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\clientes.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                /*
                OleDbConnection theConnection1 = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter1 = new OleDbDataAdapter("SELECT * FROM [Mun$]", theConnection1);
                DataSet dsmunic = new DataSet();
                theDataAdapter1.Fill(dsmunic);
                theConnection.Close();
                */
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    FbDataAdapter datSelect = new FbDataAdapter();
                    FbCommand select = new FbCommand();
                    try
                    {
                        string _cod_municipio = "", _razao = "", _cidade = retirar_caracteres_depois(dr[5].ToString());
                        _cod_municipio = dr[14].ToString();
                        if (_cod_municipio == "")
                        {
                            _cod_municipio = buscar_cod_mun(dr[5].ToString(), dr[6].ToString());
                            if (_cod_municipio == "")
                                _cod_municipio = "null";
                            else
                                _cod_municipio = "'" + _cod_municipio + "'";
                        }
                        else
                            _cod_municipio = "'" + _cod_municipio + "'";

                        int forma_pgto = 0;
                        //try
                        //{
                        //     forma_pgto = Convert.ToInt32(dr[15].ToString());
                        // }
                        //  catch{}
                        int pessoa_fisica = 0;
                        string cnpj = dr[1].ToString();
                        string ie = dr[10].ToString();
                        
                        string cod_cliente = "0";
                        try
                        {
                            cod_cliente = Convert.ToInt32(dr[18].ToString()).ToString();
                        }
                        catch { }
                        string tipo_cliente = "0";
                        if (dr[17].ToString().Contains("Fornecedores"))
                            tipo_cliente = "1";
                        //if (dr[28].ToString() == "2")
                        //    tipo_cliente = "INDUSTRIALIZACAO";
                        //if (dr[28].ToString() == "2")
                        //    tipo_cliente = "REVENDA";
                        //if (dr[28].ToString() == "2")
                        //    tipo_cliente = "CONSUMO";

                        select.CommandText =
                             "INSERT INTO CLIENTES (RAZAO_SOCIAL, CNPJ, ENDERECO, NUMERO_CLIENTE, BAIRRO, CIDADE, ESTADO, CEP_CLIENTE, COD_CIDADE_CLIENTE, " +
                             "ATIVO_CLIENTE, NOME_FANTASIA, FONE, IE, DIA_VISITA_CLIENTE, FREQUENCIA_VISITA_CLIENTE, FORMA_PAGAMENTO_CLIENTE, EMAIL, " +
                             "COMPLEMENTO_CLIENTE, PESSOA_FISICA_CLIENTE, " +
                             "FORNECEDOR_CLIENTE, COD_CLIENTE) VALUES " +
                             "('" + retirar_caracteres_depois(dr[0].ToString()) + "','" + retirar_caracteres_depois(cnpj) + "','" +
                             retirar_caracteres_depois(dr[2].ToString()) + "','" + retirar_caracteres_depois(dr[3].ToString()) + "','" +
                             retirar_caracteres_depois(dr[4].ToString()) + "','" + retirar_caracteres_depois(dr[5].ToString()) + "','" +
                             retirar_caracteres_depois(dr[6].ToString()) + "','" + retirar_caracteres_depois(dr[7].ToString()) + "'," + _cod_municipio + ",'1','" +
                            retirar_caracteres_depois(dr[8].ToString()) + "','" + retirar_caracteres_depois(dr[9].ToString()) + "','" + ie + "','" + retirar_caracteres_depois(dr[12].ToString()) + "','" +
                            retirar_caracteres_depois(dr[13].ToString()) + "','" + forma_pgto.ToString() + "','" + retirar_caracteres_depois(dr[16].ToString()) + "','" + retirar_caracteres_depois(dr[15].ToString()) + "', " +
                            pessoa_fisica.ToString() + ",'" +  tipo_cliente + "','" + cod_cliente + "')";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        datSelect.SelectCommand = select;
                        datSelect.SelectCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                        // inserir_vendedor_cliente(dr[1].ToString(), dr[11].ToString().ToUpper());
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        // MessageBox.Show(a.ToString());
                    }
                }


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\produtos_vigor.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[2].ToString() != "")
                        {
                            string ncm = dr[14].ToString();
                            if (ncm.Length == 7)
                                ncm = "0" + ncm;
                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            insert.CommandText =
                                "INSERT INTO PRODUTOS (COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, COD_UNIDADE_PRODUTO, " +
                                "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO, ICMS_S_N_PRODUTO, ST_SAIDA_PRODUTO, ICMS_FORA_S_N_PRODUTO, ST_SAIDA_FORA_PRODUTO, NCM_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, " +
                                "NOME_FORNECEDOR_PRODUTO, QTDE_UNIDADE_PRODUTO, CUSTO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, VALOR_PROMOCAO_PRODUTO, COEFICIENTE_LUCRO_PRODUTO) VALUES ('" +
                                dr[2].ToString() + "', '" + dr[2].ToString() + "','" + dr[3].ToString().Replace("\t", "") + "','" + dr[11].ToString() + "','" + dr[13].ToString() + "','UN','UN','1', '1', '500', '1', '500', '" +
                                ncm + "','13324184000197','VIGOR ALIMENTOS SA','" + dr[6].ToString() + "','" + Convert.ToDouble(dr[25].ToString()).ToString("n2").Replace(",", ".") + "','" +
                                Convert.ToDouble(dr[28].ToString()).ToString("n2").Replace(",", ".") + "','" + Convert.ToDouble(dr[26].ToString()).ToString("n2").Replace(",", ".") + "','" +
                            Convert.ToDouble(dr[27].ToString()).ToString().Replace(",", ".") + "')";
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime começo = DateTime.Now;
                int i = 0;
                progressBar1.Value = i;
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, QTDE_UNIDADE_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, COD_FORNECEDOR_PRODUTO FROM PRODUTOS where status_produto = 1";
                select.Connection = fbConnection1;
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataTable dtEstoque = new DataTable();
                datEstoque.Fill(dtEstoque);
                fbConnection1.Close();
                progressBar1.Maximum = dtEstoque.Rows.Count;
                foreach (DataRow dr in dtEstoque.Rows)
                {
                    i++;
                    progressBar1.Value = i;
                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dr[4].ToString());
                    }
                    catch { }
                }
                progressBar1.Value = 0;
                DateTime fim = DateTime.Now;
                TimeSpan intervalo = fim - começo;
                MessageBox.Show("Recalculado com sucesso! " + intervalo.ToString());
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        static string RemoverCaracteresEspeciais(string input)
        {
            // Remove aspas simples, & e espaços em branco à esquerda e à direita
            return input.Replace("'", "").Replace("&", "").Trim();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\produtos_vigor_novo.xls';Extended Properties='Excel 12.0;HDR=NO;IMEX=1;'");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);

                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                FbCommand insert = new FbCommand();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (0 == 0)
                        {
                            string ncm = RemoverCaracteresEspeciais(dr[13].ToString());
                            if (ncm.Length == 7)
                                ncm = "0" + ncm;

                            string cst = " null", icms = "null", reducao = "null", pis_cofins = "0";
                            if (dr[9].ToString() != "")
                            {
                                cst = RemoverCaracteresEspeciais(dr[9].ToString());
                                if (cst == "20")
                                {
                                    try
                                    {
                                        icms = Convert.ToDouble(dr[11].ToString()).ToString().Replace(".", "").Replace(",", ".");
                                    }
                                    catch { }
                                    try
                                    {
                                        reducao = Convert.ToDouble(dr[10].ToString()).ToString().Replace(".", "").Replace(",", ".");
                                    }
                                    catch { }
                                }
                            }
                            try
                            {
                                if (Convert.ToDouble(dr[15].ToString()) > 0)
                                {
                                    pis_cofins = "1";
                                }
                            }
                            catch { }

                            string status = "1";
                            //if (dr[21].ToString() != "1")
                            //{
                            //    status = "0";
                            //}

                            double venda_sugerido = 0, venda_minimo = 0, coeficiente = 0;
                            try
                            {
                                venda_sugerido = Convert.ToDouble(dr[18].ToString().Replace("R$ ", ""));
                            }
                            catch { }
                            try
                            {
                                venda_minimo = Convert.ToDouble(dr[19].ToString());
                            }
                            catch { }
                            try
                            {
                                coeficiente = Convert.ToDouble(dr[20].ToString());
                            }
                            catch { }

                            string familia = "";
                            familia = RemoverCaracteresEspeciais(dr[4].ToString());

                            string grupo = "";
                            grupo = RemoverCaracteresEspeciais(dr[2].ToString());

                            string subgrupo = "";
                            subgrupo = RemoverCaracteresEspeciais(dr[26].ToString());
                            //apagar caso ja exista
                            /*
                            FbCommand delete = new FbCommand();
                            delete.Connection = fbConnection1;
                            delete.CommandText =
                                " DELETE FROM PRODUTOS WHERE COD_PRODUTO = '" + dr[5].ToString() + "' ";
                            fbConnection1.Open();
                            delete.ExecuteNonQuery();
                            fbConnection1.Close();
                            */

                           
                            insert.Connection = fbConnection1;

                            string peso = "0";
                            try
                            {
                                peso = dr[8].ToString() == "" ? "0.0" : Convert.ToDouble(dr[8].ToString()).ToString().Replace(",", ".");
                            }
                            catch { }
                            string preco_custo_st = "0";
                            try
                            {
                                preco_custo_st = dr[17].ToString() == "" ? "0.0" : Convert.ToDouble(dr[17].ToString()).ToString("n2").Replace(".", "").Replace(",", ".");
                            }
                            catch { }
                            string cnpj_forn = "null", nome_forn = "null";
                            //try
                            //{
                            //    cnpj_forn = "'16995420000195'";
                            //    nome_forn = "'" + RemoverCaracteresEspeciais(dr[30].ToString()) + "'";
                            //}
                            //catch { }


                            string cest = "";

                            string rateio = "null";
                            try
                            {
                                if (dr[29].ToString() != "")
                                    rateio = "'" + dr[29].ToString() + "'";
                            }
                            catch { }
                           
                            if (dr[5].ToString() == "")
                            {

                                insert.CommandText =
                                    "INSERT INTO PRODUTOS (COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, COD_UNIDADE_PRODUTO, " +
                                    "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO, ICMS_S_N_PRODUTO, ST_SAIDA_PRODUTO, ICMS_FORA_S_N_PRODUTO, ST_SAIDA_FORA_PRODUTO, NCM_PRODUTO, QTDE_UNIDADE_PRODUTO, CUSTO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, VALOR_PROMOCAO_PRODUTO, COEFICIENTE_LUCRO_PRODUTO, PESO_UNIT_PRODUTO, " +
                                    "ALIQUOTA_ICMS_PRODUTO, REDUCAO_ICMS_PRODUTO, PIS_COFINS_PRODUTO, NOME_FAMILIA_PRODUTO, DESCRICAO_GRUPO_PRODUTO, CEST_PRODUTO, DESCRICAO_SUB_GRUPO_PRODUTO, COD_ALTERNATIVO_PRODUTO, NOME_FORNECEDOR_PRODUTO, CNPJ_FORNECEDOR_PRODUTO) VALUES (" +
                                    "'" + RemoverCaracteresEspeciais(dr[28].ToString()) + "','" +
                                    RemoverCaracteresEspeciais(dr[6].ToString().Replace("\t", "").Replace("'", "")) + "','" +
                                    RemoverCaracteresEspeciais(dr[0].ToString()).Replace(".", "") + "','" + RemoverCaracteresEspeciais(dr[1].ToString()).Replace(".", "") + "','" +
                                    RemoverCaracteresEspeciais(dr[3].ToString()) + "','" + RemoverCaracteresEspeciais(dr[3].ToString()) + "','" +
                                    status + "', '1', " + cst + ", '1', " + cst + ", '" +
                                    ncm + "','" + RemoverCaracteresEspeciais(dr[7].ToString().Replace(",", ".")) + "','" + preco_custo_st + "','" +
                                    venda_sugerido.ToString("n2").Replace(".", "").Replace(",", ".") + "','" + venda_minimo.ToString("n2").Replace(".", "").Replace(",", ".") + "','" +
                                coeficiente.ToString().Replace(",", ".") + "','" + peso + "'," + icms + "," +
                                reducao + "," + pis_cofins + ",'" + familia + "','" + grupo + "','" + cest + "','" + subgrupo + "'," + rateio + "," + nome_forn + "," + cnpj_forn + ")";
                                fbConnection1.Open();
                                FbDataAdapter datInsert = new FbDataAdapter();
                                datInsert.InsertCommand = insert;
                                datInsert.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                            else
                            {
                                insert.CommandText =
                                   "INSERT INTO PRODUTOS (COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, COD_UNIDADE_PRODUTO, " +
                                   "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO, ICMS_S_N_PRODUTO, ST_SAIDA_PRODUTO, ICMS_FORA_S_N_PRODUTO, ST_SAIDA_FORA_PRODUTO, NCM_PRODUTO, QTDE_UNIDADE_PRODUTO, CUSTO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, VALOR_PROMOCAO_PRODUTO, COEFICIENTE_LUCRO_PRODUTO, PESO_UNIT_PRODUTO, " +
                                   "ALIQUOTA_ICMS_PRODUTO, REDUCAO_ICMS_PRODUTO, PIS_COFINS_PRODUTO, NOME_FAMILIA_PRODUTO, DESCRICAO_GRUPO_PRODUTO, CEST_PRODUTO, DESCRICAO_SUB_GRUPO_PRODUTO, COD_ALTERNATIVO_PRODUTO, NOME_FORNECEDOR_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, COD_PRODUTO) VALUES (" +
                                   "'" + RemoverCaracteresEspeciais(dr[28].ToString()) + "','" +
                                   RemoverCaracteresEspeciais(dr[6].ToString().Replace("\t", "").Replace("'", "")) + "','" +
                                   RemoverCaracteresEspeciais(dr[0].ToString()).Replace(".", "") + "','" + RemoverCaracteresEspeciais(dr[1].ToString()).Replace(".", "") + "','" +
                                   RemoverCaracteresEspeciais(dr[3].ToString()) + "','" + RemoverCaracteresEspeciais(dr[3].ToString()) + "','" +
                                   status + "', '1', " + cst + ", '1', " + cst + ", '" +
                                   ncm + "','" + RemoverCaracteresEspeciais(dr[7].ToString().Replace(",", ".")) + "','" + preco_custo_st + "','" +
                                   venda_sugerido.ToString("n2").Replace(".", "").Replace(",", ".") + "','" + venda_minimo.ToString("n2").Replace(".", "").Replace(",", ".") + "','" +
                               coeficiente.ToString().Replace(",", ".") + "','" + peso + "'," + icms + "," +
                               reducao + "," + pis_cofins + ",'" + familia + "','" + grupo + "','" + cest + "','" + subgrupo + "'," + rateio + "," + nome_forn + "," + cnpj_forn + ",'" + dr[5].ToString() + "')";
                                fbConnection1.Open();
                                FbDataAdapter datInsert = new FbDataAdapter();
                                datInsert.InsertCommand = insert;
                                datInsert.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                       // MessageBox.Show(a.ToString());
                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/produtos_carolina_novo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[0].ToString() != "")
                        {
                            string ncm = dr[13].ToString();
                            if (ncm.Length == 7)
                                ncm = "0" + ncm;

                            string cst = dr[9].ToString(), icms = "null", reducao = "null", pis_cofins = "0";
                            if (cst == "20")
                            {
                                icms = "18";
                                reducao = "33.33";
                            }
                            try
                            {
                                if (Convert.ToDouble(dr[15].ToString()) > 0)
                                {
                                    pis_cofins = "1";
                                }
                            }
                            catch { }
                            //if (verificarProduto(dr[5].ToString()) == true)
                            //{
                            //    FbCommand update = new FbCommand();
                            //    update.Connection = fbConnection1;
                            //    update.CommandText = "UPDATE PRODUTOS SET  CUSTO_PRODUTO = @CUSTO,VALOR_VENDA_REVEND_PRODUTO = @VLR_VENDA, VALOR_PROMOCAO_PRODUTO = @VLR_PROMO WHERE COD_PRODUTO LIKE @COD";
                            //    update.Parameters.AddWithValue("@CUSTO", Convert.ToDouble(dr[18].ToString()).ToString("n2").Replace(",", "."));
                            //    update.Parameters.AddWithValue("@VLR_VENDA", Convert.ToDouble(dr[18].ToString()).ToString("n2").Replace(",", "."));
                            //    update.Parameters.AddWithValue("@VLR_PROMO", Convert.ToDouble(dr[18].ToString()).ToString("n2").Replace(",", "."));
                            //    update.Parameters.AddWithValue("@COD",dr[5].ToString());
                            //    fbConnection1.Open();
                            //    FbDataAdapter datInsert = new FbDataAdapter();
                            //    datInsert.UpdateCommand = update;
                            //    datInsert.UpdateCommand.ExecuteNonQuery();
                            //    fbConnection1.Close();
                            //}
                            //else 
                            //{
                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            insert.CommandText =
                                "INSERT INTO PRODUTOS (COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, COD_UNIDADE_PRODUTO, " +
                                "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO, ICMS_S_N_PRODUTO, ST_SAIDA_PRODUTO, ICMS_FORA_S_N_PRODUTO, ST_SAIDA_FORA_PRODUTO, NCM_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, " +
                                "NOME_FORNECEDOR_PRODUTO, QTDE_UNIDADE_PRODUTO, CUSTO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, VALOR_PROMOCAO_PRODUTO, COEFICIENTE_LUCRO_PRODUTO, PESO_UNIT_PRODUTO, " +
                                "ALIQUOTA_ICMS_PRODUTO, REDUCAO_ICMS_PRODUTO, PIS_COFINS_PRODUTO) VALUES ('" +
                                dr[5].ToString() + "', '" + dr[5].ToString() + "','" + dr[6].ToString().Replace("\t", "") + "','" + dr[0].ToString() + "','" + dr[1].ToString() + "','UN','UN','1', '1', " + cst + ", '1', " + cst + ", '" +
                                ncm + "','77655009000165','LATICINIOS CAROLINA LTDA','" + dr[7].ToString() + "','" + Convert.ToDouble(dr[17].ToString()).ToString("n2").Replace(",", ".") + "','" +
                                Convert.ToDouble(dr[18].ToString()).ToString("n2").Replace(",", ".") + "','" + Convert.ToDouble(dr[19].ToString()).ToString("n2").Replace(",", ".") + "','" +
                            Convert.ToDouble(dr[20].ToString()).ToString().Replace(",", ".") + "','" + Convert.ToDouble(dr[8].ToString()).ToString().Replace(",", ".") + "'," + icms + "," +
                            reducao + "," + pis_cofins + ")";
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                            //}

                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }

        }
        private Boolean verificarProduto(string cod)
        {
            FbCommand cmd = new FbCommand();
            cmd.Connection = fbConnection1;
            cmd.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO LIKE @COD ";
            cmd.Parameters.AddWithValue("@COD", cod);
            FbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    return true;
                }
            }
            return false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/familia.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[0].ToString() != "")
                        {


                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE PRODUTOS SET NOME_FAMILIA_PRODUTO = '" + dr[4].ToString() + "' WHERE COD_PRODUTO = '" + dr[0].ToString() + "'";
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
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/novos_precos.xlsx';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Planilha2$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        string custo = "0";
                        string precomin = "";
                        string precomax = "";


                        if (dr[12].ToString() == "")
                            precomax = "null";
                        else
                            precomax = Convert.ToDouble(dr[12].ToString()).ToString().Replace(".", "").Replace(",", ".");

                        if (dr[12].ToString() == "")
                            precomin = "null";
                        else
                            precomin = Convert.ToDouble(dr[12].ToString()).ToString().Replace(".", "").Replace(",", ".");

                        if (dr[0].ToString() != "")
                        {
                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE PRODUTOS SET VALOR_VENDA_REVEND_PRODUTO = " + precomax + " , VALOR_PROMOCAO_PRODUTO = " + precomin + " WHERE COD_FORNECEDOR_PRODUTO = '" + dr[0].ToString() + "'";
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
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }


            /*
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/novos_precos_vigor.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[0].ToString() != "")
                        {
                           

                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE PRODUTOS SET VALOR_VENDA_REVEND_PRODUTO = '" + 
                                Convert.ToDouble(dr[4].ToString()).ToString("n2").Replace(".","").Replace(",",".") + "', " + 
                                "VALOR_PROMOCAO_PRODUTO = '" + 
                                Convert.ToDouble(dr[3].ToString()).ToString("n2").Replace(".","").Replace(",",".") + "' " +
                                "WHERE COD_PRODUTO = '" + dr[0].ToString() + "'";
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
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }

        */
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/dia_visita.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[0].ToString() != "")
                        {


                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE CLIENTES SET DIA_VISITA_CLIENTE = '" +
                                dr[7].ToString() + "' " +
                                "WHERE CNPJ = '" + dr[0].ToString() + "'";
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
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }



        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_PRODUTO, COD_BARRAS_PRODUTO FROM PRODUTOS";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                FbCommand select_itens = new FbCommand();
                select_itens.CommandText =
                    "SELECT infe.COD_ITENS_NOTA, infe.COD_ITEM FROM ITENS_NOTA infe " +
                    "INNER JOIN NOTA_FISCAL nf ON infe.nf_ITEM = nf.N_NF " +
                    "WHERE nf.DATA_EMISSAO_NF >= '09.06.2016' and (COD_EAN_ITEM IS NULL OR COD_EAN_ITEM = '')";
                select_itens.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect_itens = new FbDataAdapter();
                datSelect_itens.SelectCommand = select_itens;
                DataTable dtSelect_itens = new DataTable();
                datSelect_itens.Fill(dtSelect_itens);
                fbConnection1.Close();

                foreach (DataRow dr in dtSelect_itens.Rows)
                {
                    foreach (DataRow dr_ean in dtSelect.Select("COD_PRODUTO = '" + dr[1].ToString() + "'"))
                    {
                        try
                        {
                            FbCommand update = new FbCommand();
                            update.CommandText = "UPDATE ITENS_NOTA SET COD_EAN_ITEM = '" + dr_ean[1].ToString() + "' WHERE " +
                                " COD_ITENS_NOTA = '" + dr[0].ToString() + "'";
                            update.Connection = fbConnection1;
                            fbConnection1.Open();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch { fbConnection1.Close(); }

                    }
                }





            }
            catch { fbConnection1.Close(); }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/produtos_outros_forn.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {

                    try
                    {
                        if (dr[2].ToString() != "")
                        {
                            string ncm = dr[13].ToString();
                            if (ncm.Length == 7)
                                ncm = "0" + ncm;

                            string cst = dr[9].ToString(), icms = "null", reducao = "null", pis_cofins = "0";
                            if (cst == "20")
                            {
                                icms = "18";
                                reducao = "33.33";
                            }
                            try
                            {
                                if (Convert.ToDouble(dr[15].ToString()) > 0)
                                {
                                    pis_cofins = "1";
                                }
                            }
                            catch { }

                            string status = "0";
                            if (Convert.ToDouble(dr[19].ToString()) > 0)
                            {
                                status = "1";
                            }

                            double venda_sugerido = 0, venda_minimo = 0, coeficiente = 0;
                            try
                            {
                                venda_sugerido = Convert.ToDouble(dr[18].ToString());
                            }
                            catch { }
                            try
                            {
                                venda_minimo = Convert.ToDouble(dr[19].ToString());
                            }
                            catch { }
                            try
                            {
                                coeficiente = Convert.ToDouble(dr[20].ToString());
                            }
                            catch { }

                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            insert.CommandText =
                               "INSERT INTO PRODUTOS (COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, COD_UNIDADE_PRODUTO, " +
                                "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO, ICMS_S_N_PRODUTO, ST_SAIDA_PRODUTO, ICMS_FORA_S_N_PRODUTO, ST_SAIDA_FORA_PRODUTO, NCM_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, " +
                                "NOME_FORNECEDOR_PRODUTO, QTDE_UNIDADE_PRODUTO, CUSTO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, VALOR_PROMOCAO_PRODUTO, COEFICIENTE_LUCRO_PRODUTO, PESO_UNIT_PRODUTO, " +
                                "ALIQUOTA_ICMS_PRODUTO, REDUCAO_ICMS_PRODUTO, PIS_COFINS_PRODUTO, ESTOQUE_ATUAL_PRODUTO) VALUES ('" +
                                dr[5].ToString() + "', '" + dr[5].ToString() + "','" + dr[6].ToString().Replace("\t", "") + "','" + dr[0].ToString() + "','" + dr[1].ToString() + "','UN','UN','" + status + "', '1', " + cst + ", '1', " + cst + ", '" +
                                ncm + "','" + tb_cnpj.Text + "','" + tb_razao.Text + "','" + dr[7].ToString() + "','" + Convert.ToDouble(dr[17].ToString()).ToString("n2").Replace(",", ".") + "','" +
                                venda_sugerido.ToString("n2").Replace(",", ".") + "','" + venda_minimo.ToString("n2").Replace(",", ".") + "','" +
                            coeficiente.ToString().Replace(",", ".") + "','" + Convert.ToDouble(dr[8].ToString()).ToString().Replace(",", ".") + "'," + icms + "," +
                            reducao + "," + pis_cofins + ", " + dr[22].ToString() + " )";
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                            //inserir_entrada_itens_outros_forn(dr);
                        }


                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }

                }

                MessageBox.Show("Importação concluida");

            }
            catch { fbConnection1.Close(); }

        }
        private void inserir_entrada_itens_outros_forn(DataRow linha)
        {
            try
            {
                ModeloProduto prod = new ModeloProduto();
                double total = 0;
                prod.DESCRICAO_PRODUTO = linha[6].ToString().Replace("\t", "");
                prod.UNIDADE_PRODUTO = "UN";
                prod.ESTOQUE_ATUAL_PRODUTO = double.Parse(linha[22].ToString());
                prod.VALOR_VENDA_REVEND_PRODUTO = double.Parse(linha[19].ToString());
                prod.COD_PRODUTO = int.Parse(linha[5].ToString());
                total = prod.VALOR_VENDA_REVEND_PRODUTO * prod.ESTOQUE_ATUAL_PRODUTO;
                int cont = 0;
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                insert.CommandText = @"INSERT INTO ITENS_NOTA_ENT (descricao_item_ent,unidade_item_ent,qtde_item_ent,preco_unit_item_ent,
                preco_total_item_ent,nf_item_ent,pedido_compra_item_ent,cod_item_ent,cfop_item_ent,
                data_insercao_item_ent_nota,n_linha_ped_item_ent,cod_item_ped_item_ent,cod_item_est_item_ent,cod_sistema_nf_item_ent,
                cod_ean_item_ent,BAIXADO_ITEM_ENT) VALUES ('" + prod.DESCRICAO_PRODUTO + "', 'UN', " + prod.ESTOQUE_ATUAL_PRODUTO + ", " +
                " " + prod.VALOR_VENDA_REVEND_PRODUTO.ToString().Replace(",", ".") + ", " + (total.ToString().Replace(",", ".")) + ", 999, 999, " +
                " " + prod.COD_PRODUTO + ", '1101', '19.01.2017', " + cont + ", " + prod.COD_PRODUTO + ", " + prod.COD_PRODUTO + ", 999, " + prod.COD_PRODUTO + ",1)";
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                datInsert.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\clientes.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();


                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        string _cod_municipio = "", _razao = "", _cidade = retirar_caracteres_depois(dr[5].ToString());
                        // _cod_municipio = buscar_cod_mun(_cidade, dsmunic);
                        if (_cod_municipio == "")
                        {
                            //MessageBox.Show("Código Cidade do cliente " + _razao + " não encontrado. Favor Verificar");
                            _cod_municipio = "null";
                        }
                        else
                            _cod_municipio = "'" + _cod_municipio + "'";
                        FbCommand select = new FbCommand();
                        select.CommandText =
                             "INSERT INTO CLIENTES (RAZAO_SOCIAL, CNPJ, ENDERECO, NUMERO_CLIENTE, BAIRRO, CIDADE, ESTADO, CEP_CLIENTE, COD_CIDADE_CLIENTE, " +
                             "ATIVO_CLIENTE, FONE, IE) VALUES " +
                             "('" + dr[1].ToString() + "','" + retirar_caracteres_depois(dr[12].ToString()) + "','" +
                             retirar_caracteres_depois(dr[2].ToString()) + "','" + retirar_caracteres_depois(dr[3].ToString()) + "','" +
                             retirar_caracteres_depois(dr[4].ToString()) + "','" + retirar_caracteres_depois(dr[5].ToString()) + "','" +
                             retirar_caracteres_depois(dr[6].ToString()) + "','" + retirar_caracteres_depois(dr[7].ToString()) + "'," + _cod_municipio + ",'1','" +
                            dr[8].ToString() + "','" + dr[14].ToString() + "')";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        datSelect.SelectCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                        //inserir_vendedor_cliente(dr[1].ToString(), dr[11].ToString().ToUpper());
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\produtos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();

                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[0].ToString() != "")
                        {
                            string ncm = dr[11].ToString();
                            if (ncm.Length == 7)
                                ncm = "0" + ncm;
                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            insert.CommandText =
                                "INSERT INTO PRODUTOS (COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, COD_UNIDADE_PRODUTO, " +
                                "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO, ICMS_S_N_PRODUTO, ST_SAIDA_PRODUTO, ICMS_FORA_S_N_PRODUTO, ST_SAIDA_FORA_PRODUTO, NCM_PRODUTO, " +
                                "NOME_FORNECEDOR_PRODUTO, QTDE_UNIDADE_PRODUTO, CUSTO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, ESTOQUE_ATUAL_PRODUTO) VALUES ('" +
                                dr[0].ToString() + "', '" + dr[0].ToString() + "','" + dr[2].ToString().Replace("\t", "") + "','" + dr[0].ToString() + "','" + dr[0].ToString() + "','UN','UN','1', '1', '101', '1', '101', '" +
                                ncm + "','" + dr[3].ToString() + "','1','" + Convert.ToDouble(dr[4].ToString()).ToString("n2").Replace(",", ".") + "','" +
                                Convert.ToDouble(dr[6].ToString()).ToString("n2").Replace(",", ".") + "'," + dr[7].ToString() + ")";
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();

                            FbCommand insert1 = new FbCommand();
                            insert1.Connection = fbConnection1;
                            insert1.CommandText =
                                "INSERT INTO ITENS_NOTA_ENT (NF_ITEM_ENT, QTDE_ITEM_ENT, QTDE_LOTE_ITEM_ENT, BAIXADO_ITEM_ENT, COD_EAN_ITEM_ENT, COD_SISTEMA_NF_ITEM_ENT) " +
                                "VALUES('9999990', " + dr[7].ToString() + "," + dr[7].ToString() + ",1,'" + dr[0].ToString() + "','1')";
                            fbConnection1.Open();
                            FbDataAdapter datInsert1 = new FbDataAdapter();
                            datInsert1.InsertCommand = insert1;
                            datInsert1.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();

                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }
        }

        private void btnAtualizarPrecoCuto_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/preco_custo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet ds = new DataSet();
                theDataAdapter.Fill(ds);
                theConnection.Close();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        FbCommand cmd = new FbCommand();
                        cmd.CommandText = @"UPDATE PRODUTOS SET CUSTO_PRODUTO = cast(" + dr[2].ToString().Replace(",", ".") + " as numeric(18,2)),VALOR_PROMOCAO_PRODUTO = cast(" + dr[2].ToString().Replace(",", ".") + " / COEFICIENTE_LUCRO_PRODUTO as numeric(18,2)),VALOR_VENDA_REVEND_PRODUTO = cast(" + dr[2].ToString().Replace(",", ".") + " / (COEFICIENTE_LUCRO_PRODUTO - 0.05) as numeric(18,2)) WHERE COD_PRODUTO like '" + dr[0].ToString().Replace(",", "") + "'";
                        cmd.Connection = fbConnection1;
                        fbConnection1.Open();
                        cmd.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao abrir o arquivo em no excel");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/precos_antigos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        //ATUALIZANDO CUSTO ITENS_NOTA
                        FbCommand update = new FbCommand();
                        update.CommandText = "UPDATE ITENS_NOTA inf SET inf.custo_item = " +
                         Convert.ToDouble(dr[4].ToString()).ToString().Replace(".", "").Replace(",", ".") + " * inf.qtde_item " +
                         "where inf.nf_item > '" + dr[2].ToString() + "' AND inf.nf_item <= '" + dr[3].ToString() + "' and " +
                         "inf.cod_item = '" + dr[0].ToString() + "'";
                        update.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        /*
                        update.CommandText = "UPDATE ITENS_NOTA inf SET inf.custo_item = '" +
                            Convert.ToDouble(dr[4].ToString()).ToString().Replace(".", "").Replace(",", ".") + "' " +
                            "where inf.cod_itens_nota in " +
                            "(select inf2.cod_itens_nota from itens_nota inf2 " +
                            "inner join nota_fiscal nf on inf2.nf_item = nf.n_nf " +
                            "where nf.data_emissao_nf > '" + Convert.ToDateTime(dr[2].ToString()).ToShortDateString().Replace("/", ".") + "' and " +
                            "nf.data_emissao_nf <= '" + Convert.ToDateTime(dr[3].ToString()).ToShortDateString().Replace("/", ".") + "' and " +
                            "inf2.cod_item = '" + dr[0].ToString() + "')";
                         * */


                        //ATUALIZANDO ITENS_NFCE
                        //ATUALIZANDO CUSTO ITENS_NOTA
                        FbCommand update1 = new FbCommand();
                        update1.CommandText = "UPDATE ITENS_NFCE inf SET inf.custo_infce = " +
                         Convert.ToDouble(dr[4].ToString()).ToString().Replace(".", "").Replace(",", ".") + " * inf.qtde_infce " +
                         "where inf.cod_infce > '" + dr[5].ToString() + "' AND inf.cod_infce <= '" + dr[6].ToString() + "' and " +
                         "inf.cod_estoque_infce = '" + dr[0].ToString() + "'";
                        update1.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datUpdate1 = new FbDataAdapter();
                        datUpdate1.UpdateCommand = update1;
                        datUpdate1.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        /*
                        FbCommand update_nfce = new FbCommand();
                        update_nfce.CommandText = "UPDATE ITENS_NFCE inf SET inf.custo_infce = '" +
                            Convert.ToDouble(dr[4].ToString()).ToString().Replace(".", "").Replace(",", ".") + "' " +
                            "where inf.cod_infce in " +
                            "(select inf2.cod_infce from itens_nfce inf2 " +
                            "inner join nfce nf on inf2.cod_pedido_infce = nf.pedido_nfce " +
                            "where nf.data_emissao_nfce > '" + Convert.ToDateTime(dr[2].ToString()).ToShortDateString().Replace("/", ".") + "' and " +
                            "nf.data_emissao_nfce <= '" + Convert.ToDateTime(dr[3].ToString()).ToShortDateString().Replace("/", ".") + "' and " +
                            "inf2.cod_estoque_infce = '" + dr[0].ToString() + "')";
                        update_nfce.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datUpdate_nfce = new FbDataAdapter();
                        datUpdate_nfce.UpdateCommand = update_nfce;
                        datUpdate_nfce.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                         * */
                    }
                    catch (Exception a) { fbConnection1.Close(); }
                }

                FbCommand update2 = new FbCommand();
                update2.CommandText = "UPDATE ITENS_NOTA inf SET inf.custo_item = inf.preco_total_item * 0.60 " +
                 "where inf.custo_item is null";
                update2.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdate2 = new FbDataAdapter();
                datUpdate2.UpdateCommand = update2;
                datUpdate2.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();


                FbCommand update_nfce2 = new FbCommand();
                update_nfce2.CommandText = "UPDATE ITENS_NFCE inf SET inf.custo_infce = inf.VALOR_TOTAL_INFCE * 0.6 " +
                    "where inf.custo_infce is null";
                update_nfce2.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdate_nfce2 = new FbDataAdapter();
                datUpdate_nfce2.UpdateCommand = update_nfce2;
                datUpdate_nfce2.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();


            }
            catch
            {
                fbConnection1.Close();
            }

        }

        public double GetRandomNumber(double minimum, double maximum)
        {

            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM PLANOS";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                for (int i = 1; i <= 12; i++)
                {
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        try
                        {
                            Random rnd = new Random();
                            int dia = new int();
                            dia = rnd.Next(1, 30);
                            //System.Threading.Thread.Sleep(1000);

                            double valor = new double();
                            valor = GetRandomNumber(500, 700);
                            System.Threading.Thread.Sleep(500);

                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            FbDataAdapter datContas_a_pagar = new FbDataAdapter();
                            insert.CommandText =
                               "INSERT INTO CONTAS_A_PAGAR (VALOR_CP, DATA_PREVISTA_CP, COD_FORNECEDOR_CP, RAZAO_FORNECEDOR_CP, " +
                               "DESCRICAO_CP, PLANO_CP, CARTEIRA_CP, NF_CP, DUPLICATA_CP, CC_CP, DESCRICAO_CC_CP)" +
                               "VALUES (" + valor.ToString().Replace(".", "").Replace(",", ".") +
                               ",'" + dia.ToString() + "." + i.ToString() + ".2016'" +
                                ",0,'FORN TESTE','" +
                               dr["NOME_PLANO"].ToString() +
                               " DESCRICAO TESTE','" + dr["NOME_PLANO"].ToString() + "',null,0,1,null,null)";
                            fbConnection1.Open();
                            datContas_a_pagar.InsertCommand = insert;
                            datContas_a_pagar.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch { fbConnection1.Close(); }

                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivoImportacao = new OpenFileDialog();

            try
            {
                DialogResult result = arquivoImportacao.ShowDialog();
                string caminho = "";
                if (result == DialogResult.OK) // Test result.
                {
                    caminho = arquivoImportacao.FileName;

                }
                Console.WriteLine(result); // <-- For debugging use.

                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='" + caminho + "';Extended Properties=\'Excel 8.0;HDR=NO;IMEX=1;\'");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet tabelaExcel = new DataSet();
                theDataAdapter.Fill(tabelaExcel);
                theConnection.Close();

                foreach (DataRow linhaExcel in tabelaExcel.Tables[0].Rows)
                {
                    try
                    {
                        string cod_produto = linhaExcel[0].ToString();
                        string ncm_produto = linhaExcel[2].ToString();
                      
                        if (cod_produto != "")
                        {
                            FbCommand cmdUpdate = new FbCommand();
                            FbDataAdapter datCmdUpdate = new FbDataAdapter();

                            cmdUpdate.CommandText = "UPDATE PRODUTOS SET NCM_PRODUTO = '" + ncm_produto + "' " +
                                " WHERE (COD_FORNECEDOR_PRODUTO = '" + cod_produto + "')";
                            cmdUpdate.Connection = fbConnection1;
                            datCmdUpdate.UpdateCommand = cmdUpdate;
                            fbConnection1.Open();
                            datCmdUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                    }
                    catch { fbConnection1.Close(); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT prod.COD_PRODUTO, prod.CUSTO_PRODUTO  " +
                    " FROM PRODUTOS prod ";

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
                        //ATUALIZANDO CUSTO ITENS_NOTA
                        FbCommand update = new FbCommand();
                        update.CommandText = "UPDATE ITENS_NOTA inf SET inf.custo_item = " +
                         Convert.ToDouble(dr[1].ToString()).ToString().Replace(".", "").Replace(",", ".") + " " +
                         "where " +
                         "(inf.cod_item = '" + dr[0].ToString() + "')";
                        update.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                        //ATUALIZANDO CUSTO PEDIDOS
                        FbCommand update1 = new FbCommand();
                        update1.CommandText = "UPDATE ITENS_PEDIDO_VENDA inf SET inf.CUSTO_ITEM_VENDA = " +
                         Convert.ToDouble(dr[1].ToString()).ToString().Replace(".", "").Replace(",", ".") + " " +
                         "where " +
                         "(inf.COD_PROD_ITEM_VENDA = '" + dr[0].ToString() + "' OR inf.COD_SISTEMA_PROD_ITEM_VENDA = '" + dr[0].ToString() + "')";
                        update1.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datUpdate1 = new FbDataAdapter();
                        datUpdate1.UpdateCommand = update1;
                        datUpdate1.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        /*
                        //ATUALIZANDO CUSTO PRODUTOS
                        FbCommand update2 = new FbCommand();
                        update2.CommandText = "UPDATE PRODUTOS inf SET inf.CUSTO_PRODUTO = " +
                         Convert.ToDouble(dr[1].ToString()).ToString().Replace(".", "").Replace(",", ".") + " / " +
                         Convert.ToDouble(dr[2].ToString()).ToString().Replace(".", "").Replace(",", ".") + " " +
                         "where inf.COD_PRODUTO = '" + dr[3].ToString() + "'";
                        update2.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datUpdate2 = new FbDataAdapter();
                        datUpdate2.UpdateCommand = update2;
                        datUpdate2.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                        */
                    }
                    catch (Exception a) { fbConnection1.Close(); }
                }

            }
            catch
            {
                fbConnection1.Close();
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            FbCommand sel = new FbCommand();
            FbDataAdapter datSel = new FbDataAdapter();
            DataTable dt = new DataTable();
            sel.Connection = fbConnection1;
            sel.CommandText = "SELECT COD_PRODUTO, COD_BARRAS_PRODUTO FROM PRODUTOS";
            datSel.SelectCommand = sel;
            fbConnection1.Open();
            datSel.Fill(dt);
            fbConnection1.Close();
            int i = 0;
            progressBar1.Maximum = dt.Rows.Count;
            foreach (DataRow dr in dt.Rows)
            {
                i++;
                progressBar1.Value = i;
                try
                {
                    FbCommand upd = new FbCommand();
                    FbDataAdapter datUpd = new FbDataAdapter();
                    upd.Connection = fbConnection1;
                    upd.CommandText =
                        "UPDATE ITENS_NOTA_ENT SET COD_EAN_ITEM_ENT = '" + dr[1].ToString() +
                        "' WHERE COD_ITEM_ENT = '" + dr[0].ToString() + "'";
                    datUpd.UpdateCommand = upd;
                    fbConnection1.Open();
                    datUpd.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
            MessageBox.Show("Concluido.");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivoImportacao = new OpenFileDialog();

            try
            {
                DialogResult result = arquivoImportacao.ShowDialog();
                string caminho = "";
                if (result == DialogResult.OK) // Test result.
                {
                    caminho = arquivoImportacao.FileName;

                }
                Console.WriteLine(result); // <-- For debugging use.

                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='" + caminho + "';Extended Properties=\'Excel 8.0;HDR=NO;IMEX=1;\'");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet tabelaExcel = new DataSet();
                theDataAdapter.Fill(tabelaExcel);
                theConnection.Close();
                int i = 0;
                progressBar1.Maximum = tabelaExcel.Tables[0].Rows.Count;
                foreach (DataRow linhaExcel in tabelaExcel.Tables[0].Rows)
                {
                    i++;
                    progressBar1.Value = i;
                    if (linhaExcel[1].ToString().ToUpper() == "X")
                    {
                        try
                        {
                            FbCommand upd = new FbCommand();
                            FbDataAdapter datUpd = new FbDataAdapter();
                            upd.Connection = fbConnection1;
                            upd.CommandText =
                                "UPDATE CLIENTES SET ICMS_CLIENTE = 12 WHERE CNPJ = '" + linhaExcel[0].ToString() + "'";
                            datUpd.UpdateCommand = upd;
                            fbConnection1.Open();
                            datUpd.UpdateCommand.ExecuteNonQuery();
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
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\fornecedores_vernicar.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                /*
                OleDbConnection theConnection1 = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter1 = new OleDbDataAdapter("SELECT * FROM [Mun$]", theConnection1);
                DataSet dsmunic = new DataSet();
                theDataAdapter1.Fill(dsmunic);
                theConnection.Close();
                */
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    FbCommand select = new FbCommand();
                    try
                    {
                        string _cod_municipio = "", _razao = "", _cidade = retirar_caracteres_depois(dr[5].ToString());

                        int pessoa_fisica = 0;
                        if (dr[17].ToString() == "F")
                            pessoa_fisica = 1;
                        string email = dr[16].ToString();
                        if (email.Length > 50)
                            email.Remove(50);
                        select.CommandText =
                             "INSERT INTO FORNECEDORES (RAZAO_SOCIAL_FORN, CNPJ_CPF_FORN, ENDERECO_FORN, BAIRRO_FORN, " +
                             "CIDADE_FORN, ESTADO_FORN, CEP_FORN, " +
                             "ATIVO_FORN, NOME_FORN, TEL_FORN, IE_RG_FORN, EMAIL_FORN) VALUES " +
                             "('" + dr[0].ToString() + "','" + retirar_caracteres_depois(dr[1].ToString()) + "','" +
                             retirar_caracteres_depois(dr[2].ToString()) + ", " + dr[3].ToString() + "','" +
                             retirar_caracteres_depois(dr[4].ToString()) + "','" + retirar_caracteres_depois(dr[5].ToString()) + "','" +
                             retirar_caracteres_depois(dr[6].ToString()) + "','" + dr[7].ToString() + "','1', '" + dr[8].ToString() + "','" +
                        dr[9].ToString() + "','" + dr[10].ToString() + "','" + email + "')";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        datSelect.SelectCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                    }
                }


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {

                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * from contas_a_receber";
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
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        fbConnection1.Open();
                        update.CommandText =
                            "UPDATE PEDIDOS_VENDA SET DATA_BAIXA_PED_VENDA = '" + Convert.ToDateTime(dr["DATA_CRIACAO_CR"].ToString()).ToShortDateString().Replace("/", ".") + "' " +
                            "WHERE COD_PED_VENDA = '" + dr["NF_CR"].ToString() + "' AND BAIXADO_ESTOQUE_PED_VENDA = '1'";
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch { fbConnection1.Close(); }

                }


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/produtos_dale_novo.xlsx';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[5].ToString() != "")
                        {
                            string ncm = dr[13].ToString();
                            if (ncm.Length == 7)
                                ncm = "0" + ncm;


                            string cst = dr[9].ToString(), icms = "null", reducao = "null", pis_cofins = "0";

                            try
                            {
                                icms = Convert.ToDouble(dr[11].ToString()).ToString().Replace(",", ".");
                            }
                            catch
                            {

                            }
                            try
                            {
                                if (Convert.ToDouble(dr[15].ToString()) > 0)
                                {
                                    pis_cofins = "1";
                                }
                            }
                            catch { }

                            string status = "1";
                            if (dr[21].ToString() == "X")
                            {
                                status = "0";
                            }

                            double venda_sugerido = 0, venda_minimo = 0, coeficiente = 0;
                            try
                            {
                                venda_sugerido = Convert.ToDouble(dr[18].ToString());
                            }
                            catch { }
                            try
                            {
                                venda_minimo = Convert.ToDouble(dr[19].ToString());
                            }
                            catch { }
                            try
                            {
                                coeficiente = Convert.ToDouble(dr[20].ToString());
                            }
                            catch { }

                            string familia = "";
                            familia = dr[4].ToString();

                            string grupo = "";
                            grupo = dr[2].ToString();

                            string tipo_pis = "", cst_pis = "";
                            tipo_pis = dr[23].ToString();
                            cst_pis = dr[22].ToString();

                            double aliquota_pis = 0;
                            double aliquota_cofins = 0;
                            try
                            {
                                aliquota_pis = Convert.ToDouble(dr[15].ToString());
                                aliquota_cofins = Convert.ToDouble(dr[16].ToString());

                            }
                            catch { }

                            double ipi = 0;
                            try
                            {
                                ipi = Convert.ToDouble(dr[24].ToString());
                            }
                            catch { }


                            string unidade = dr[3].ToString();


                            //apagar caso ja exista
                            try
                            {

                                FbCommand delete = new FbCommand();
                                delete.Connection = fbConnection1;
                                delete.CommandText =
                                    " DELETE FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + dr[5].ToString() + "' ";
                                fbConnection1.Open();
                                delete.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                            catch { fbConnection1.Close(); }

                            FbCommand insert = new FbCommand();
                            insert.Connection = fbConnection1;
                            insert.CommandText =
                                "INSERT INTO PRODUTOS (COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, COD_UNIDADE_PRODUTO, " +
                                "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO, NCM_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, VALOR_PROMOCAO_PRODUTO) VALUES ('" +
                                dr[5].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString().Replace("\t", "").Replace("Ê", "E") + "','" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + unidade + "','" + unidade + "','" + status + "', '" +
                                ncm + "','" +
                                venda_sugerido.ToString("n2").Replace(",", ".") + "','" + venda_minimo.ToString("n2").Replace(",", ".") + "')";
                            fbConnection1.Open();
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }

        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/clientes_rota.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[0].ToString() != "")
                        {


                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE CLIENTES SET COD_ROTEIRO_CLIENTE = '" +
                                dr[31].ToString() + "' " +
                                "WHERE COD_CLIENTE = '" + Convert.ToInt32(dr[0].ToString()).ToString() + "'";
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
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }

        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT *  FROM NOTA_FISCAL";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    FbCommand update = new FbCommand();
                    update.CommandText =
                        "UPDATE CONTAS_A_RECEBER SET FORMA_PGTO_CR = '" + dr["FORMA_PGTO_NF"].ToString() + "' WHERE NF_CR = '" + dr["N_NF"].ToString() + "'";
                    update.Connection = fbConnection1;
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

        private void button35_Click(object sender, EventArgs e)
        {
            /*
            //PRODUTOS
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, VALOR_PROMOCAO_PRODUTO FROM PRODUTOS ";
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
                        double valor_venda = 0, valor_promocao = 0;
                        try { valor_venda = Convert.ToDouble(dr[1].ToString()) * 10; }
                        catch { }
                        try { valor_promocao = Convert.ToDouble(dr[2].ToString()) * 10; }
                        catch { }



                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE PRODUTOS SET VALOR_VENDA_REVEND_PRODUTO = '" + valor_venda.ToString("n2").Replace(".", "").Replace(",", ".") + "' , " +
                            "VALOR_PROMOCAO_PRODUTO = '" + valor_promocao.ToString("n2").Replace(".", "").Replace(",", ".") + "' " +
                            "WHERE COD_PRODUTO = '" + dr[0].ToString() + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch { fbConnection1.Close(); }
                }
            }
            catch (Exception a) 
            {
                fbConnection1.Close();
            }
            //ITENS TP
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_ITEM_TP, PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP FROM ITENS_TP ";
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
                        double valor_venda = 0, valor_promocao = 0;
                        try { valor_venda = Convert.ToDouble(dr[1].ToString()) * 10; }
                        catch { }
                        try { valor_promocao = Convert.ToDouble(dr[2].ToString()) * 10; }
                        catch { }



                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE ITENS_TP SET PRECO_PRODUTO_ITEM_TP = '" + valor_venda.ToString("n2").Replace(".", "").Replace(",", ".") + "' , " +
                            "PRECO_MINIMO_ITEM_TP = '" + valor_promocao.ToString("n2").Replace(".", "").Replace(",", ".") + "' " +
                            "WHERE COD_ITEM_TP = '" + dr[0].ToString() + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch { fbConnection1.Close(); }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
             * */
            //ITENS PEDIDO
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT ipv.COD_ITEM_VENDA, ipv.QTDE_ITEM_VENDA, ipv.VALOR_UNIT_PROD_ITEM_VENDA FROM ITENS_PEDIDO_VENDA ipv " +
                    "INNER JOIN PEDIDOS_VENDA pv on ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA " +
                    "WHERE (pv.BAIXADO_ESTOQUE_PED_VENDA = 0 OR pv.BAIXADO_ESTOQUE_PED_VENDA is null) ";
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
                        double qtde = 0, valor = 0;
                        try { qtde = Convert.ToDouble(dr[1].ToString()) / 10; }
                        catch { }
                        try { valor = Convert.ToDouble(dr[2].ToString()) * 10; }
                        catch { }



                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            //      "UPDATE ITENS_PEDIDO_VENDA SET QTDE_ITEM_VENDA = '" + qtde.ToString("n2").Replace(".", "").Replace(",", ".") + "' , " +
                            //     "VALOR_UNIT_PROD_ITEM_VENDA = '" + valor.ToString("n2").Replace(".", "").Replace(",", ".") + "' " +

                       "UPDATE ITENS_PEDIDO_VENDA SET UNIDADE_PROD_ITEM_VENDA = 'CX' " +
                        "WHERE COD_ITEM_VENDA = '" + dr[0].ToString() + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch { fbConnection1.Close(); }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT COD_SISTEMA_NF, N_NF FROM NOTA_FISCAL";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        fbConnection1.Open();
                        update.CommandText =
                                "UPDATE ITENS_NOTA SET COD_SISTEMA_NF_ITEM = '" + dr[0].ToString() + "' WHERE NF_ITEM = '" + dr[1].ToString() + "' ";

                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\forma_pgto.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataTable theDS = new DataTable();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in dtCidades.Rows)
                {
                    //terminar depois
                    try
                    {
                        FbCommand insert = new FbCommand();
                        insert.Connection = fbConnection1;
                        insert.CommandText = "INSERT INTO FORMA_PGTO SET (COD_FORMA_PGTO, DESCRICAO_FORMA_PGTO, N_PARCELAS_FORMA_PGTO";
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }
            }
            catch { }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\transportadoras.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Planilha1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                /*
                OleDbConnection theConnection1 = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter1 = new OleDbDataAdapter("SELECT * FROM [Mun$]", theConnection1);
                DataSet dsmunic = new DataSet();
                theDataAdapter1.Fill(dsmunic);
                theConnection.Close();
                */
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    FbDataAdapter datSelect = new FbDataAdapter();
                    FbCommand select = new FbCommand();
                    try
                    {

                        string cnpj = dr[11].ToString();
                        if (cnpj == "00000000000000" || cnpj == "")
                            cnpj = dr[0].ToString();

                        select.CommandText =
                             "INSERT INTO TRANSPORTADORAS (COD_TRANSPORTADORA, RAZAO_SOCIAL_TRANSPORTADORA, ENDERECO_TRANSPORTADORA, BAIRRO_TRANSPORTADORA, " +
                             "CIDADE_TRANSPORTADORA, ESTADO_TRANSPORTADORA, CNPJ_TRANSPORTADORA, IE_TRANSPORTADORA, FONE_TRANSPORTADORA, " +
                             "EMAIL_TRANSPORTADORA) VALUES " +
                             "('" + retirar_caracteres_depois(dr[0].ToString()) + "','" + retirar_caracteres_depois(dr[1].ToString()) + "','" +
                             retirar_caracteres_depois(dr[3].ToString()) + "','" + retirar_caracteres_depois(dr[4].ToString()) + "','" +
                             retirar_caracteres_depois(dr[5].ToString()) + "','" + retirar_caracteres_depois(dr[6].ToString()) + "','" +
                             retirar_caracteres_depois(cnpj) + "','" + retirar_caracteres_depois(dr[12].ToString()) + "','" +
                            retirar_caracteres_depois(dr[7].ToString()) + "','" + retirar_caracteres_depois(dr[14].ToString()) + "')";
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        datSelect.SelectCommand = select;
                        datSelect.SelectCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                        // inserir_vendedor_cliente(dr[1].ToString(), dr[11].ToString().ToUpper());
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.Message);
                    }
                }


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }

        }

        private void button39_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/itens-estoque.xlsx';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
            DataSet theDS = new DataSet();
            theDataAdapter.Fill(theDS);

            FbDataAdapter datEstoque = new FbDataAdapter();
            DataTable dtEstoque = new DataTable();
            FbCommand insertEstoque = new FbCommand();

            int i = 0;

            if (theDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                            insertEstoque.CommandText =
                                "INSERT INTO estoque (COD_ESTOQUE, ITEM_ESTOQUE, DESCRICAO_ESTOQUE, CNPJ_PROPRIETARIO_ESTOQUE, NOME_PROPRIETARIO_ESTOQUE, UNIDADE_ESTOQUE, NCM_ESTOQUE) " +
                                "VALUES ('" + dr[2].ToString() + "', '" + dr[3].ToString() + "','" + dr[4].ToString().Replace("\t", "").Replace("'", "''") + "','" +
                                dr[1].ToString() + "','" + dr[0].ToString() + "','" + dr[6].ToString() + "','" + dr[5].ToString() + "')";
                            datEstoque.InsertCommand = insertEstoque;
                            datEstoque.InsertCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datEstoque.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        
                    }
                    catch (Exception a)
                    {
                        theConnection.Close();
                        fbConnection1.Close();
                        MessageBox.Show("Não foi possível inserir os ítens novos no cadastro de estoque!\nErro: " + a.Message);
                    }
                }

                MessageBox.Show("Importação nos ítens novos foi concluída com sucesso!");
            }

        }

        private void button40_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao\\excel\\itens-estoque.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
            DataSet theDS = new DataSet();
            theDataAdapter.Fill(theDS);

            FbDataAdapter datEstoque = new FbDataAdapter();
            DataTable dtEstoque = new DataTable();
            FbCommand insertEstoque = new FbCommand();

            int i = 0;

            if (theDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (i > 0)
                        {
                            //0 ITENS
                            //1 DESCRIÇÃO	
                            //2 GRUPO	
                            //3 COD BARRAS	
                            //4 UNIDADE	
                            //5 TIPO_ITEM_ESTOQUE	
                            //6 OBSERVAÇÃO

                            insertEstoque.CommandText =
                                "INSERT INTO estoque (ITEM_ESTOQUE,GRUPO_ESTOQUE,COD_BARRAS_ITEM_FABRICANTE,unidade_estoque, tipo_item_estoque, OBSERVACOES_ESTOQUE) " +
                                "VALUES ('" + dr[1] + "', '" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "','" + dr[6] + "')";
                            datEstoque.InsertCommand = insertEstoque;
                            datEstoque.InsertCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datEstoque.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }

                        i++;
                    }
                    catch (Exception a)
                    {
                        theConnection.Close();
                        fbConnection1.Close();

                        MessageBox.Show("Não foi possível inserir os ítens novos no cadastro de estoque!\nErro: " + a.Message);
                    }
                }

                MessageBox.Show("Importação nos ítens novos foi concluída com sucesso!");
            }


        }

        private string retirar_caracteres(string palavra)
        {
            return palavra.Replace("'", "").Replace("&", "e").TrimEnd();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            ImportarExcel importar = new ImportarExcel();
            var ds = importar.importarXLS(@"c:\\evolucao\\excel\financeiro.xlsx");

            List<string> erros = new List<string>();

            foreach (DataRow dr in ds.Tables["crcp"].Rows)
            {
                string nf = retirar_caracteres(dr[6].ToString()),
                    fornecedor = retirar_caracteres(dr[3].ToString()),
                    plano = retirar_caracteres(dr[16].ToString()),
                    descricao = retirar_caracteres(dr[4].ToString()),
                    observacoes = retirar_caracteres(dr[22].ToString()),
                    duplicata = retirar_caracteres(dr[7].ToString()),
                    cod_cliforn = retirar_caracteres(dr[17].ToString());

                DateTime data_criacao = DateTime.Now;
                DateTime data_prevista = DateTime.Now;
                decimal valor = 0;
                int pago = 0;
                try
                {
                    try
                    {
                       // data_criacao = Convert.ToDateTime(dr[21].ToString());
                    }
                    catch { }
                    try
                    {
                        data_prevista = Convert.ToDateTime(dr[10].ToString());
                    }
                    catch { }

                    valor = Convert.ToDecimal(dr[9].ToString());
                }

                catch { }
                string cod_cc = "null", descricao_cc = "";
                buscar_cc(dr[21].ToString(), out cod_cc, out descricao_cc);

                

                //try
                //{
                //    cod_cc = dr[15].ToString();
                //    descricao_cc = dr[16].ToString();
                //}
                //catch { }
                if (dr[0].ToString().ToUpper() == "D")
                {
                    string empresa = "1";

                    string _nf = nf;

                    string sufixo = "";

                    if (_nf.Contains("-"))
                    {
                        sufixo = _nf.Split('-')[1];
                    }

                    if (sufixo == "JR")
                    {
                        empresa = "2";
                    }


                    FbCommand insert = new FbCommand();
                    try
                    {
                        valor = valor * -1;

                        insert.Connection = fbConnection1;

                        insert.CommandText =
                        @"
INSERT INTO CONTAS_A_PAGAR
(
    RAZAO_FORNECEDOR_CP, DESCRICAO_CP, NF_CP,
    DATA_PREVISTA_CP, VALOR_CP, PLANO_CP, OBSERVACOES_CP, DATA_CRIACAO_CP,
    DUPLICATA_CP, CC_CP, DESCRICAO_CC_CP, PESSOA_CP, COD_FORNECEDOR_CP
)
VALUES
(
    @FORN, @DESC, @NF,
    @DATA_PREV, @VALOR, @PLANO, @OBS, @DATA_CRIACAO,
    @DUP, @CC, @DESC_CC, @PESSOA, @CODFORN
)";

                        insert.Parameters.Clear();
                        insert.Parameters.AddWithValue("@FORN", fornecedor);
                        insert.Parameters.AddWithValue("@DESC", descricao);
                        insert.Parameters.AddWithValue("@NF", nf);
                        insert.Parameters.AddWithValue("@DATA_PREV", data_prevista);   // DateTime
                        insert.Parameters.AddWithValue("@VALOR", valor);              // decimal/double
                        insert.Parameters.AddWithValue("@PLANO", plano);
                        insert.Parameters.AddWithValue("@OBS", observacoes);
                        insert.Parameters.AddWithValue("@DATA_CRIACAO", data_criacao); // DateTime
                        insert.Parameters.AddWithValue("@DUP", duplicata);
                        int ccInt;
                        if (int.TryParse((cod_cc ?? "").Trim(), out ccInt))
                            insert.Parameters.Add("@CC", FbDbType.Integer).Value = ccInt;
                        else
                            insert.Parameters.Add("@CC", FbDbType.Integer).Value = DBNull.Value;
                        //nsert.Parameters.AddWithValue("@CC", cod_cc);
                        insert.Parameters.AddWithValue("@DESC_CC", descricao_cc);
                        insert.Parameters.AddWithValue("@PESSOA", empresa);
                        insert.Parameters.AddWithValue("@CODFORN", cod_cliforn);       // int/long

                        fbConnection1.Open();
                        insert.ExecuteNonQuery();
                        fbConnection1.Close();
                        //insert.Connection = fbConnection1;
                        //insert.CommandText =
                        //    @"INSERT INTO CONTAS_A_PAGAR (RAZAO_FORNECEDOR_CP, DESCRICAO_CP, NF_CP, 
                        //    DATA_PREVISTA_CP, VALOR_CP, PLANO_CP, OBSERVACOES_CP, DATA_CRIACAO_CP, 
                        //    DUPLICATA_CP, CC_CP, DESCRICAO_CC_CP, PESSOA_CP, COD_FORNECEDOR_CP) 
                        //    VALUES ('" + fornecedor + "','" + descricao + "','" +
                        //        nf + "','" + data_prevista.ToShortDateString().Replace("/",".") + "','" + 
                        //        valor.ToString().Replace(".","").Replace(",",".") + "','" + 
                        //        plano + "','" + observacoes + "','" +
                        //        data_criacao.ToShortDateString().Replace("/", ".") + "','" + duplicata + "','" + 
                        //        cod_cc + "','" + descricao_cc + "', '" + empresa + "', '" + cod_cliforn + ")";
                        //FbDataAdapter datInsert = new FbDataAdapter();
                        //fbConnection1.Open();
                        //datInsert.InsertCommand = insert;
                        //datInsert.InsertCommand.ExecuteNonQuery();
                        //fbConnection1.Close();
                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                if (dr[0].ToString().ToUpper() == "C")
                {
                    string empresa = "1";

                    string _nf = nf;

                    string numero = _nf.Split('-')[0];

                    int n_nf = 0;
                    try
                    {
                        n_nf = Convert.ToInt32(numero);
                    }
                    catch { }

                    if (n_nf > 1000 && n_nf < 5000)
                    {
                        empresa = "2";
                    }
                    

                    FbCommand insert = new FbCommand();
                    try
                    {
                        insert.Connection = fbConnection1;
                        insert.CommandText =
                        @"INSERT INTO CONTAS_A_RECEBER
(RAZAO_CLIENTE_CR, DESCRICAO_CR, NF_CR, DATA_PREVISTA_CR, VALOR_CR, PLANO_CR,
 OBSERVACOES_CR, DATA_CRIACAO_CR, DUPLICATA_CR, CC_CR, DESCRICAO_CC_CR, PESSOA_CR, COD_CLIENTE_CR)
VALUES
(@FORN, @DESC, @NF, @DATA_PREV, @VALOR, @PLANO, @OBS, @DATA_CRIACAO, @DUP, @CC, @DESC_CC, @PESSOA, @CODCLI)";

                        insert.Parameters.Clear();
                        insert.Parameters.AddWithValue("@FORN", fornecedor);
                        insert.Parameters.AddWithValue("@DESC", descricao);
                        insert.Parameters.AddWithValue("@NF", nf);
                        insert.Parameters.AddWithValue("@DATA_PREV", data_prevista);
                        insert.Parameters.AddWithValue("@VALOR", valor);
                        insert.Parameters.AddWithValue("@PLANO", plano);
                        insert.Parameters.AddWithValue("@OBS", observacoes);
                        insert.Parameters.AddWithValue("@DATA_CRIACAO", data_criacao);
                        insert.Parameters.AddWithValue("@DUP", duplicata);
                        int ccInt;
                        if (int.TryParse((cod_cc ?? "").Trim(), out ccInt))
                            insert.Parameters.Add("@CC", FbDbType.Integer).Value = ccInt;
                        else
                            insert.Parameters.Add("@CC", FbDbType.Integer).Value = DBNull.Value;
                        //insert.Parameters.AddWithValue("@CC", cod_cc);
                        insert.Parameters.AddWithValue("@DESC_CC", descricao_cc);
                        insert.Parameters.AddWithValue("@PESSOA", empresa);
                        insert.Parameters.AddWithValue("@CODCLI", cod_cliforn);

                        fbConnection1.Open();
                        insert.ExecuteNonQuery();
                        fbConnection1.Close();

                        //insert.Connection = fbConnection1;
                        //insert.CommandText =
                        //    @"INSERT INTO CONTAS_A_RECEBER (RAZAO_CLIENTE_CR, DESCRICAO_CR, NF_CR, 
                        //    DATA_PREVISTA_CR, VALOR_CR, PLANO_CR, OBSERVACOES_CR, DATA_CRIACAO_CR, 
                        //    DUPLICATA_CR,  CC_CR, DESCRICAO_CC_CR, PESSOA_CR, COD_CLIENTE_CR) 
                        //    VALUES ('" + fornecedor + "','" + descricao + "','" +
                        //        nf + "','" + data_prevista.ToShortDateString().Replace("/", ".") + "','" +
                        //        valor.ToString().Replace(".", "").Replace(",", ".") + "','" +
                        //        plano + "','" + observacoes + "','" +
                        //        data_criacao.ToShortDateString().Replace("/", ".") + "','" + duplicata + "','" +
                        //        cod_cc + "','" + descricao_cc + "', '" + empresa + "'," + cod_cliforn + ")";
                        //FbDataAdapter datInsert = new FbDataAdapter();
                        //fbConnection1.Open();
                        //datInsert.InsertCommand = insert;
                        //datInsert.InsertCommand.ExecuteNonQuery();
                        //fbConnection1.Close();
                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void buscar_cc(string cod_transmissao, out string cod_cc, out string descricao_cc)
        {
            cod_cc = "";
            descricao_cc = "";

            try
            {

                cod_transmissao = cod_transmissao.Trim().TrimStart('\'');
                FbCommand cmd = new FbCommand();
                cmd.Connection = fbConnection1;
                fbConnection1.Open();
                cmd.CommandText = "SELECT COD_CC, DESCRICAO_CC FROM CONTAS_CORRENTES WHERE COD_TRANSMISSAO = @COD_TRANSMISSAO";

                cmd.Parameters.AddWithValue("@COD_TRANSMISSAO", cod_transmissao);

                FbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cod_cc = dr["COD_CC"].ToString();
                    descricao_cc = dr["DESCRICAO_CC"].ToString();
                }
                else
                {
                    if(cod_transmissao != "" && cod_transmissao != " ")
                    {

                    }

                }

                fbConnection1.Close();
                dr.Close();
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                cod_cc = "";
                descricao_cc = "";
            }
        }

        private string buscar_descricao_mp(string item_estoque, out string item)
        {
            item = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DESCRICAO_ESTOQUE, cod_estoque FROM ESTOQUE WHERE ITEM_ESTOQUE = '" + item_estoque + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    item = dr[1].ToString();
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

        private void button42_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/componentes_clara.xlsx';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Definitiva$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close(); FbCommand insert = new FbCommand();
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if (dr[1].ToString() != "")// && Convert.ToDecimal(dr[4].ToString()) > 0)
                        {
                            string cod = "";
                            string descricao = buscar_descricao_mp(dr[5].ToString(), out cod);
                            double qtde = 0;
                            Double.TryParse(dr[8].ToString(), out qtde);
                            if (descricao == "")
                                descricao = dr[5].ToString();

                            int cod_prod = 0;
                            buscar_descricao(dr[1].ToString(), out cod_prod);
                            if (!verificar_se_ja_existe_item(cod, cod_prod))
                            {

                                FbCommand cmd = new FbCommand();
                                FbDataAdapter datItensProduto = new FbDataAdapter();
                                cmd.CommandText =
                                    @"INSERT INTO ITENS_PRODUTO (COD_ESTOQUE_IP, DESCRICAO_IP, QTDE_IP, COD_PRODUTO_IP, UN_IP, ITEM_IP) VALUES
                        ('" + cod + "','" + descricao + "','" + qtde.ToString().Replace(".", "").Replace(",", ".") + "','" + cod_prod.ToString() + "', 'KG','" + dr[5].ToString() + "')";
                                cmd.Connection = fbConnection1;
                                datItensProduto.InsertCommand = cmd;
                                fbConnection1.Open();
                                datItensProduto.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }

                        }

                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }
        }

        private bool verificar_se_ja_existe_item(string cod, int cod_prod)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText = "SELECT * FROM ITENS_PRODUTO where COD_ESTOQUE_IP = '" + cod.ToString() + "' AND COD_PRODUTO_IP = '" + cod_prod.ToString() + "'";
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
            catch (Exception ex)
            {
                fbConnection1.Close();
                return false;
            }
        }

        private string buscar_descricao(string codProduto, out int cod)
        {
            cod = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DESCRICAO_PRODUTO, COD_PRODUTO FROM PRODUTOS WHERE UPPER(COD_FORNECEDOR_PRODUTO) = UPPER('" + codProduto + "')";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    cod = Convert.ToInt32(dr[1].ToString());
                    return dr[0].ToString();
                }
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                insert.CommandText =
                    "INSERT INTO PRODUTOS (COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_UNIDADE_PRODUTO, " +
                    "DESCRICAO_UNIDADE_PRODUTO, STATUS_PRODUTO) VALUES ('" +
                    codProduto + "','" + codProduto + "','PC','PC','1') returning cod_produto";
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                object novo_cod = datInsert.InsertCommand.ExecuteScalar();
                fbConnection1.Close();
                cod = Convert.ToInt32(novo_cod);
                return codProduto;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "";
            }
        }

        private bool verificar_se_ja_existe_kit(string p1, string p2)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText = "SELECT * FROM PRODUTOS_KIT where COD_KIT_PK = '" + p1 + "' AND COD_PRODUTO_PK = '" + p2 + "'";
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
            catch (Exception ex)
            {
                fbConnection1.Close();
                return false;
            }
        }
        private void button43_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/componentes_clara.xlsx';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Definitiva$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close(); FbCommand insert = new FbCommand();



                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    try
                    {
                        if ((dr[0].ToString() != "" && dr[1].ToString() != "") && dr[0].ToString() != "" &&
                            (dr[1].ToString() != dr[0].ToString()))
                        {

                            int cod = 0;
                            string descricao = buscar_descricao(dr[1].ToString(), out cod);
                            if (descricao == "")
                                descricao = dr[1].ToString();
                            int cod_kit = 0;
                            buscar_descricao(dr[0].ToString(), out cod_kit);
                            double qtde = 0;
                            try
                            {
                                qtde = Convert.ToDouble(dr[6].ToString());
                            }
                            catch { }

                            if (!verificar_se_ja_existe_kit(cod_kit.ToString(), cod.ToString()))
                            {



                                insert.Connection = fbConnection1;
                                insert.CommandText =
                                    "INSERT INTO PRODUTOS_KIT (COD_KIT_PK, COD_PRODUTO_PK, DESCRICAO_PK, QTDE_PK) VALUES (" +
                                   cod_kit.ToString() + "," + cod.ToString() + ",'" + descricao + "','" +
                                    qtde.ToString().Replace(".", "").Replace(",", ".") + "')";
                                fbConnection1.Open();
                                FbDataAdapter datInsert = new FbDataAdapter();
                                datInsert.InsertCommand = insert;
                                datInsert.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                                
                            }
                        }

                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        //MessageBox.Show(a.ToString());
                    }

                }
            }
            catch { fbConnection1.Close(); }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:/evolucao/excel/mp_bralyx.xlsx';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();

                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [SALDO$]", theConnection);
                DataTable dsEstoque = new DataTable();
                theDataAdapter.Fill(dsEstoque);

                OleDbDataAdapter theDataAdapterNf = new OleDbDataAdapter("SELECT * FROM [NFS$]", theConnection);
                DataTable dsNf = new DataTable();
                theDataAdapterNf.Fill(dsNf);


                foreach (DataRow dr_nfs in dsNf.Rows)
                {
                    try
                    {
                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText =
                            "SELECT COD_SISTEMA_NF_ENT FROM NOTA_FISCAL_ENT WHERE N_NF_ENT = '" + dr_nfs[0].ToString() + "' AND DATA_EMISSAO_NF_ENT = '" +
                             Convert.ToDateTime(dr_nfs[1].ToString()).ToShortDateString().Replace("/", ".") + "'";
                        FbDataAdapter datNota_fiscal_ent = new FbDataAdapter();
                        datNota_fiscal_ent.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datNota_fiscal_ent.Fill(dtSelect);
                        fbConnection1.Close();

                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            FbCommand delete = new FbCommand();
                            delete.Connection = fbConnection1;
                            fbConnection1.Open();
                            delete.CommandText =
                                "DELETE FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + dr[0].ToString() + "'";
                            datNota_fiscal_ent.DeleteCommand = delete;
                            datNota_fiscal_ent.DeleteCommand.ExecuteNonQuery();
                            fbConnection1.Close();


                            FbCommand delete1 = new FbCommand();
                            delete1.Connection = fbConnection1;
                            fbConnection1.Open();
                            delete1.CommandText =
                                "DELETE FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_ITEM_ENT = '" + dr[0].ToString() + "'";
                            FbDataAdapter datItens_nota_ent = new FbDataAdapter();
                            datItens_nota_ent.DeleteCommand = delete1;
                            datItens_nota_ent.DeleteCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }


                        FbCommand insert_nf = new FbCommand();
                        insert_nf.Connection = fbConnection1;
                        fbConnection1.Open();
                        insert_nf.CommandText =
                            "INSERT INTO NOTA_FISCAL_ENT (N_NF_ENT, CLIENTE_FORN_NF_ENT, BAIXADA_NF_ENT, CNPJ_CLIENTE_FORN_ENT, DATA_EMISSAO_NF_ENT) " +
                            "VALUES ('" + dr_nfs[0].ToString() + "','BRALYX MAQUINAS INDUSTRIA E COMERCIO LTDA', '1', '74226242000134', '" +
                            Convert.ToDateTime(dr_nfs[1].ToString()).ToShortDateString().Replace("/", ".") + "') RETURNING COD_SISTEMA_NF_ENT";
                      //  FbDataAdapter datNota_fiscal_ent = new FbDataAdapter();
                        datNota_fiscal_ent.InsertCommand = insert_nf;
                        object ultimo_cod_sistema_nf_ent_inserida = datNota_fiscal_ent.InsertCommand.ExecuteScalar();
                        fbConnection1.Close();

                        foreach (DataRow dr in dsEstoque.Select("F4 = '" + dr_nfs[0].ToString() + "'"))
                        {
                            try
                            {

                                //INSERINDO ITEM NA NF ENTRADA
                                string cod_estoque = "";
                                string descricao = buscar_descricao_mp(dr[1].ToString(), out cod_estoque);
                                if (cod_estoque != "")
                                {
                                    FbCommand insert_item_nf = new FbCommand();
                                    insert_item_nf.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    insert_item_nf.CommandText =
                                        "INSERT INTO ITENS_NOTA_ENT (DESCRICAO_ITEM_ENT, QTDE_ITEM_ENT, NF_ITEM_ENT, " +
                                        "DATA_INSERCAO_ITEM_ENT_NOTA, NOME_PROPRIETARIO_ITEM_ENT, MATERIA_PRIMA_ITEM_ENT, " +
                                        "BAIXADO_ITEM_ENT, COD_ITEM_EST_ITEM_ENT, COD_SISTEMA_NF_ITEM_ENT, PRECO_UNIT_ITEM_ENT) VALUES ('" +
                                        dr[1].ToString() + " " + descricao + "'," + Convert.ToDecimal(dr[17].ToString()).ToString().Replace(".", "").Replace(",", ".") + ",'" + dr_nfs[0].ToString() + "','" +
                                        Convert.ToDateTime(dr_nfs[1].ToString()).ToShortDateString().Replace("/", ".") + "','BRALYX MAQUINAS INDUSTRIA E COMERCIO LTDA','1','1','" +
                                        cod_estoque + "','" + ultimo_cod_sistema_nf_ent_inserida + "','" + Convert.ToDecimal(dr[6].ToString()).ToString().Replace(".","").Replace(",",".") + 
                                        "') RETURNING COD_ITENS_NOTA_ENT";
                                    FbDataAdapter datItens_nota_ent = new FbDataAdapter();
                                    datItens_nota_ent.InsertCommand = insert_item_nf;
                                    object ultimo_item_nota_ent_inserido = datItens_nota_ent.InsertCommand.ExecuteScalar();
                                    fbConnection1.Close();



                                    //INSERINDO LOTE

                                    FbCommand insert_lote = new FbCommand();
                                    insert_lote.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    insert_lote.CommandText =
                                        "INSERT INTO LOTE_RECEBIMENTO (COD_PRODUTO_LR, DESCRICAO_LR,  " +
                                        "CLIENTE_LR, QTDE_LR, NOTA_FISCAL_LR, DATA_LIBERACAO_LR) VALUES ('" +
                                        cod_estoque + "','" + dr[1].ToString() + " " + descricao + "','BRALYX MAQUINAS INDUSTRIA E COMERCIO LTDA'," +
                                        Convert.ToDecimal(dr[17].ToString()).ToString().Replace(".", "").Replace(",", ".") + ",'" + dr_nfs[0].ToString() + "','" +
                                            Convert.ToDateTime(dr_nfs[1].ToString()).ToShortDateString().Replace("/", ".") + "') RETURNING COD_LR";
                                    FbDataAdapter datLote = new FbDataAdapter();
                                    datLote.InsertCommand = insert_lote;
                                    object ultimo_lote_inserido = datLote.InsertCommand.ExecuteScalar();
                                    fbConnection1.Close();

                                    //UPDATE LOTE NO ITENS_NOTA

                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    update.CommandText =
                                        "UPDATE ITENS_NOTA_ENT SET LOTE_ITEM_ENT = '" + ultimo_lote_inserido.ToString() + "', " +
                                        "QTDE_LOTE_ITEM_ENT = " + Convert.ToDecimal(dr[17].ToString()).ToString().Replace(".", "").Replace(",", ".") + ", " +
                                        "NOME_PROPRIETARIO_ITEM_ENT = 'BRALYX MAQUINAS INDUSTRIA E COMERCIO LTDA' WHERE COD_ITENS_NOTA_ENT = '" +
                                        ultimo_item_nota_ent_inserido + "'";
                                    datItens_nota_ent.UpdateCommand = update;
                                    datItens_nota_ent.UpdateCommand.ExecuteNonQuery();
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
                    catch (Exception ex)
                    {
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

        private void button45_Click(object sender, EventArgs e)
        {
            try
            {

                FbCommand select = new FbCommand();
                select.CommandText = @"SELECT lote_item_ent FROM ITENS_NOTA_ENT where lote_item_ent > 5 ";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dt = new DataTable();
                datSelect.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    calcular_estoque_lote(dr[0].ToString());
                }
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show("Erro:" + ex.Message);
            }

        }
            private void calcular_estoque_lote(string lote)
        {
            try
            {
                decimal entrada = 0, saidas = 0, estoque = 0;
                FbCommand select = new FbCommand();
                select.CommandText = @"SELECT infe.QTDE_ITEM_ENT FROM ITENS_NOTA_ENT infe 
                    WHERE lote_item_ent = '" + lote + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dt = new DataTable();
                datSelect.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    entrada = Convert.ToDecimal(dr[0].ToString());
                }

                FbCommand selectSaidas = new FbCommand();
                selectSaidas.CommandText = @"SELECT sum(infe.QTDE_ITEM) FROM ITENS_NOTA infe 
                    WHERE cod_ean_item = '" + lote + "'";
                selectSaidas.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelectSaidas = new FbDataAdapter();
                datSelectSaidas.SelectCommand = selectSaidas;
                DataTable dtSaidas = new DataTable();
                datSelectSaidas.Fill(dtSaidas);
                fbConnection1.Close();
                foreach (DataRow dr in dtSaidas.Rows)
                {
                    try
                    {
                        saidas = Convert.ToDecimal(dr[0].ToString());
                    }
                    catch { }
                }
                estoque = entrada - saidas;

                FbCommand update = new FbCommand();
                update.CommandText = @"UPDATE LOTE_RECEBIMENTO SET QTDE_LR = '" + estoque.ToString().Replace(".", "").Replace(",", ".") + @"' 
                                            WHERE COD_LR = '" + lote + "'";
                update.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                FbCommand updateItens = new FbCommand();
                updateItens.CommandText = @"UPDATE ITENS_NOTA_ENT SET QTDE_LOTE_ITEM_ENT = '" + estoque.ToString().Replace(".", "").Replace(",", ".") + @"' 
                                            WHERE LOTE_ITEM_ENT = '" + lote + "'";
                updateItens.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdateItens = new FbDataAdapter();
                datUpdateItens.UpdateCommand = updateItens;
                datUpdateItens.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

            private void button46_Click(object sender, EventArgs e)
            {
                /*  classeEstoque_material est = new classeEstoque_material();
            est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            est.calcular_estoque(cod_estoque);*/
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                        "SELECT COD_ESTOQUE FROM ESTOQUE";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        classeEstoque_material est = new classeEstoque_material();
                        est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        est.calcular_estoque(dr[0].ToString());
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }
            }

            private void button47_Click(object sender, EventArgs e)
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                        "SELECT COD_PRODUTO, COD_FORNECEDOR_PRODUTO FROM PRODUTOS";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        FbCommand insert = new FbCommand();
                        try
                        {
                            
                            insert.Connection = fbConnection1;
                            fbConnection1.Open();
                            insert.CommandText =
                                @"INSERT INTO DESENHOS_PRODUTO (LINK_DES_PRODUTO, COD_PROD_DES_PRODUTO) values ('\\Clarasrv\ti\PCP\DESENHOS_EVOLUCAO\" + dr[1].ToString() + ".pdf','" + dr[0].ToString() + "')";
                            FbDataAdapter datInsert = new FbDataAdapter();
                            datInsert.InsertCommand = insert;
                            datInsert.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception ex)
                        {
                            fbConnection1.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                }
            }

            private void button48_Click(object sender, EventArgs e)
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                        "SELECT COD_PRODUTO, COD_FORNECEDOR_PRODUTO FROM PRODUTOS WHERE STATUS_PRODUTO = 1";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        FbCommand insertItem = new FbCommand();
                        try
                        {
                            insertItem.Connection = fbConnection1;
                            insertItem.CommandText =
                                "UPDATE ITENS_PEDIDO_VENDA SET COD_SISTEMA_PROD_ITEM_VENDA = '" + dr[0].ToString() +
                                "' WHERE COD_PROD_ITEM_VENDA = '" + dr[1].ToString() + "'";
                            fbConnection1.Open();
                            insertItem.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch (Exception a)
                        {

                            fbConnection1.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }

            private void button49_Click(object sender, EventArgs e)
            {
                string[] vetorDados = new string[]
                {
                    "",
                    "RISCO",
                    "DESIGN",
                    "COMPRAS",
                    "CORTE",
                    "CHECK POINT1",
                    "SILK",
                    "BORDADO",
                    "PERSONALIZACAO",
                    "SUBLIMACAO",
                    "CHECKPOINT2",
                    "COSTURA INTERNA",
                    "COSTURA EXTERNA",
                    "CASEADO",
                    "TRAVETE",
                    "CHECKPOINT3",
                    "ACABAMENTO INTERNO",
                    "ACABAMENTO EXTERNO"
                };

                 OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao\\excel\\gruposxdias.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
            DataSet theDS = new DataSet();
            theDataAdapter.Fill(theDS);

            FbDataAdapter datEstoque = new FbDataAdapter();
            DataTable dtEstoque = new DataTable();
            FbCommand insertEstoque = new FbCommand();

            int i = 0;

            if (theDS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    if (i > 0)
                    {
                        try
                        {
                            string grupo = "", operacao = "", dias = "";
                            for (int j = 1; j <= 17; j++)
                            {
                                grupo = dr[0].ToString();
                                operacao = vetorDados[j];
                                dias = dr[j].ToString();
                                FbCommand insert = new FbCommand();
                                insert.CommandText =
                                    "INSERT INTO GRUPOS_OPERACOES_PRAZO (GRUPO_GOP, OPERACAO_GOP, DIAS_PRAZO_GOP) VALUES ('" + grupo + "','" + operacao + "','" + dias + "')";
                                insert.Connection = fbConnection1;
                                fbConnection1.Open();
                                insert.ExecuteNonQuery();
                                fbConnection1.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    i++;
                }
            }
            








            }

            private void button50_Click(object sender, EventArgs e)
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao\\excel\\gruposxdias.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);

                FbDataAdapter datEstoque = new FbDataAdapter();
                DataTable dtEstoque = new DataTable();
                FbCommand insertEstoque = new FbCommand();

                int i = 0;

                if (theDS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in theDS.Tables[0].Rows)
                    {
                        if (i > 0)
                        {
                            try
                            {
                                string grupo = "", operacao = "", dias = "";
                               
                                    grupo = dr[0].ToString();
                               
                            
                                    FbCommand insert = new FbCommand();
                                    insert.CommandText =
                                        "INSERT INTO GRUPOS (COD_GRUPO, DESCRICAO_GRUPO) VALUES ('" + i.ToString() + "','" + grupo + "')";
                                    insert.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    insert.ExecuteNonQuery();
                                    fbConnection1.Close();
                                

                            }
                            catch (Exception ex)
                            {
                                fbConnection1.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        i++;
                    }
                }
            }

        private void button51_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivoImportacao = new OpenFileDialog();

            try
            {
                DialogResult result = arquivoImportacao.ShowDialog();
                string caminho = "";
                if (result == DialogResult.OK) // Test result.
                {
                    caminho = arquivoImportacao.FileName;

                }
                Console.WriteLine(result); // <-- For debugging use.

                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='" + caminho + "';Extended Properties=\'Excel 8.0;HDR=NO;IMEX=1;\'");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", theConnection);
                DataSet tabelaExcel = new DataSet();
                theDataAdapter.Fill(tabelaExcel);
                theConnection.Close();

                foreach (DataRow linhaExcel in tabelaExcel.Tables[0].Rows)
                {
                    try
                    {
                        string cod_produto = linhaExcel[0].ToString();
                       
                        string cod_barras = linhaExcel[1].ToString();
                        if (cod_produto != "")
                        {
                            FbCommand cmdUpdate = new FbCommand();
                            FbDataAdapter datCmdUpdate = new FbDataAdapter();

                            cmdUpdate.CommandText = "UPDATE PRODUTOS SET  " +
                                " COD_BARRAS_PRODUTO = '" + cod_barras + "', " +
                                " COD_BARRAS_CAIXA_PRODUTO = '" + cod_barras + "' " +
                                " WHERE (COD_FORNECEDOR_PRODUTO = '" + cod_produto + "')";
                            cmdUpdate.Connection = fbConnection1;
                            datCmdUpdate.UpdateCommand = cmdUpdate;
                            fbConnection1.Open();
                            datCmdUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                    }
                    catch { fbConnection1.Close(); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivoImportacao = new OpenFileDialog();

            try
            {
                DialogResult result = arquivoImportacao.ShowDialog();
                string caminho = "";
                if (result == DialogResult.OK) // Test result.
                {
                    caminho = arquivoImportacao.FileName;

                }
                Console.WriteLine(result); // <-- For debugging use.

                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='" + caminho + "';Extended Properties=\'Excel 8.0;HDR=NO;IMEX=1;\'");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", theConnection);
                DataSet tabelaExcel = new DataSet();
                theDataAdapter.Fill(tabelaExcel);
                theConnection.Close();

                foreach (DataRow linhaExcel in tabelaExcel.Tables[0].Rows)
                {
                    try
                    {
                        string cod_produto = linhaExcel[0].ToString();

                        string cod_barras = linhaExcel[1].ToString();
                        if (cod_produto != "")
                        {
                            FbCommand cmdUpdate = new FbCommand();
                            FbDataAdapter datCmdUpdate = new FbDataAdapter();

                            cmdUpdate.CommandText = "UPDATE PRODUTOS SET  " +
                                " CARACT_ADIC_PRODUTO = '" + cod_barras + "' " +
                                " " +
                                " WHERE (COD_FORNECEDOR_PRODUTO = '" + cod_produto + "')";
                            cmdUpdate.Connection = fbConnection1;
                            datCmdUpdate.UpdateCommand = cmdUpdate;
                            fbConnection1.Open();
                            datCmdUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                    }
                    catch { fbConnection1.Close(); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select = new FbCommand();
                select.CommandText =
                    @"SELECT nfe.N_NF_ENT, emp.COD_EMPRESA FROM ITENS_NOTA_ENT inf 
                        inner join nota_fiscal_ent nfe on inf.COD_SISTEMA_NF_ITEM_ENT = nfe.COD_SISTEMA_NF_ENT 
                        INNER JOIN PEDIDO_COMPRA pc on pc.COD_PED = inf.PEDIDO_COMPRA_ITEM_ENT 
                        INNER JOIN EMPRESA emp on pc.CNPJ_EMISSOR_PED = emp.CNPJ_EMPRESA";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach(DataRow dr in dtSelect.Rows)
                {
                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    update.CommandText = "UPDATE CONTAS_A_PAGAR SET PESSOA_CP = '" + dr["COD_EMPRESA"].ToString() + 
                        "' where NF_CP = '" + dr["n_nf_ent"].ToString() + "'";
                    fbConnection1.Open();
                    update.ExecuteNonQuery();
                    fbConnection1.Close();
                }



            }
            catch (Exception ex)
            {

            }
        }
    }
}