using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using FirebirdSql.Data.FirebirdClient;

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
            try
            {
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao_dokinos\\excel\\produtos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Plan1$]", theConnection);
                DataSet theDS = new DataSet();
                System.Data.DataTable dtu = new System.Data.DataTable();
                theDataAdapter.Fill(dtu);
                this.dgvCrono.DataSource = dtu.DefaultView;
            }
            catch
            {

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
                            cst = "" + cst.Replace("`","") + "";
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
                        ipi = "'" + dgvCrono.Rows[i].Cells[11].Value.ToString().Replace(".", "").Replace(",", ".").Replace("%","") + "'";
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
                        valor_icms_normal = Convert.ToDouble(dgvCrono.Rows[i].Cells[12].Value.ToString())/100 * bc_normal;
                        valor_icms_com_st = (bc_com_ipi + (bc_com_ipi * Convert.ToDouble(dgvCrono.Rows[i].Cells[13].Value.ToString())/100)) * Convert.ToDouble(dgvCrono.Rows[i].Cells[12].Value.ToString())/100 - valor_icms_normal;
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
                            valor_venda = "'" + venda.ToString("n2").Replace(".","").Replace(",",".") + "'";
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
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao_dokinos\\excel\\produtos.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
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
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao_dokinos\\excel\\clientes-vigor.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
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
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:/evolucao/excel/estoque-jmacedo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Produtos$]", theConnection);
            DataSet theDS = new DataSet();
            theDataAdapter.Fill(theDS);
            int i = 0;

            try
            {
                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO NOTA_FISCAL_ENT (N_NF_ENT, DATA_ENTR_SAI_NF_ENT,BAIXADA_NF_ENT) " +
                    "VALUES ('99999','22.10.2013',1)";
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
                        codEan = dr[3].ToString();
                        qtde = dr[6].ToString().Replace(".", "").Replace(",", ".");

                        try
                        {
                            //INSERT ENTRADA PRODUTO
                            FbCommand insert_itens = new FbCommand();
                            insert_itens.Connection = fbConnection1;
                            fbConnection1.Open();
                            insert_itens.CommandText =
                            "INSERT INTO itens_nota_ent " +
                                "(descricao_item_ent, qtde_item_ent, nf_item_ent, data_insercao_item_ent_nota, cod_item_est_item_ent, cod_sistema_nf_item_ent, baixado_item_ent, unidade_item_ent, cod_ean_item_ent) " +
                                "VALUES ('" + descricao + "'," + qtde + ",'99999','22.10.2013','" + codProduto + "','" + cod_sistema_ultima_nf_ent + "','1','" + un + "', '" + codEan + "')";
                            datItens_nota_ent.InsertCommand = insert_itens;
                            datItens_nota_ent.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        catch
                        {
                            fbConnection1.Close();
                        }
                        classeEstoque est = new classeEstoque();
                        est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        est.acertarEstoqueProdutosIni(codProduto);
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
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao_dokinos\\excel\\tabela-todos-os-produtos-jmacedo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
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
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao_dokinos\\excel\\farinhas-jmacedo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
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
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source='c:\\evolucao_dokinos\\excel\\mix-jmacedo.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
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

    }
}