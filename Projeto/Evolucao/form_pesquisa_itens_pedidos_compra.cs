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
    public partial class form_pesquisa_itens_pedidos_compra : Form
    {
        public form_pesquisa_itens_pedidos_compra()
        {
            InitializeComponent();
        }

        private void form_pesquisa_itens_pedidos_compra_Load(object sender, EventArgs e)
        {
            rdbPeriodo.Checked = true;
            dgvItens_ped.AutoGenerateColumns = false;
            dgvItens_ped.DataSource = dsItens_ped.Tables["ITENS_PEDIDO_COMPRA"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            form_localiza_forn localiza_forn = new form_localiza_forn(false, "");
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {

                localiza_forn.Dispose();
                try
                {
                    FbDataAdapter datFornecedores = new FbDataAdapter();
                    FbCommand comando_select = new FbCommand();
                    comando_select.Connection = fbConnection1;
                    string _nome_forn = "", _cnpj_forn = "";
                    comando_select.CommandText = "SELECT * FROM FORNECEDORES WHERE COD_FORN = '" + localiza_forn.forn_escolhido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    datFornecedores.SelectCommand = comando_select;
                    datFornecedores.Fill(forn);
                    fbConnection1.Close();
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        _nome_forn = dr["RAZAO_SOCIAL_FORN"].ToString();
                        _cnpj_forn = dr["CNPJ_CPF_FORN"].ToString();
                    }
                    if (_nome_forn != "")
                    {
                        tb_nome_forn.Text = _nome_forn;
                        tb_cnpj_forn.Text = _cnpj_forn;
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado ou com dados incompletos.");
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selecionar();
        }

        private void selecionar()
        {
            try
            {
                if (rdbTrimestre.Checked)
                {
                    int trimestre = (cbxTrimestre.SelectedIndex + 1);
                    int ano = Convert.ToInt32(nudAno.Value);
                    switch (trimestre)
                    {
                        case 1:
                            dtInicio.Value = new DateTime(ano, 1, 1);
                            dtTermino.Value = new DateTime(ano, 3, 31);
                            break;
                        case 2:
                            dtInicio.Value = new DateTime(ano, 4, 1);
                            dtTermino.Value = new DateTime(ano, 6, 30);
                            break;

                        case 3:
                            dtInicio.Value = new DateTime(ano, 7, 1);
                            dtTermino.Value = new DateTime(ano, 9, 30);
                            break;

                        case 4:
                            dtInicio.Value = new DateTime(ano, 10, 1);
                            dtTermino.Value = new DateTime(ano, 12, 31);
                            break;
                    }
                }
                dsItens_ped.Clear();
                string fornecedor = "";
                if (tb_cnpj_forn.Text != "")
                    fornecedor = " AND FORNECEDOR_ITEM_PED = '" + tb_cnpj_forn.Text + "' ";
                string cod = "";
                if (tb_cod.Text != "")
                    cod = " AND COD_ESTOQUE_ITEM_PED = '" + tb_cod.Text + "'";
                string descricao = "";
                if (tb_descricao.Text != "")
                    descricao = " AND DESCRICAO_ITEM_PED LIKE '%" + tb_descricao.Text + "%'";
                string item = "";
                if (tb_item.Text != "")
                    item = " AND ITEM_ITEM_PED LIKE '%" + tb_item.Text + "%'";

                datItens_ped.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE DATA_CHEGADA_ITEM_PED >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                    "DATA_CHEGADA_ITEM_PED <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'" + fornecedor + cod + descricao + item;
                datItens_ped.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_ped.SelectCommand.ExecuteNonQuery();
                datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                fbConnection1.Close();
                somar_valores();
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void somar_valores()
        {
            double valor_total = 0;
            for (int i = 0; i < dgvItens_ped.RowCount; i++)
            {
                valor_total = valor_total + Convert.ToDouble(dgvItens_ped.Rows[i].Cells["col_valor_total"].Value.ToString());
            }
            tb_valor_total.Text = valor_total.ToString("n2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            somar_valores();
        }

        private void tb_cod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_ped.Tables["ITENS_PEDIDO_COMPRA"].DefaultView.RowFilter = "COD_ESTOQUE_ITEM_PED = '" + tb_cod.Text + "'";
            }
            catch { }
        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_ped.Tables["ITENS_PEDIDO_COMPRA"].DefaultView.RowFilter = "ITEM_ITEM_PED LIKE '*" + tb_item.Text + "*'";
            }
            catch { }
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_ped.Tables["ITENS_PEDIDO_COMPRA"].DefaultView.RowFilter = "DESCRICAO_ITEM_PED LIKE '*" + tb_descricao.Text + "*'";
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selecionar();
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM FORNECEDORES";
                FbDataAdapter datForn = new FbDataAdapter();
                datForn.SelectCommand = select;
                datForn.SelectCommand.ExecuteNonQuery();
                dsItens_ped fat = new dsItens_ped();
                datItens_ped.Fill(fat.ITENS_PEDIDO_COMPRA);
                datForn.Fill(fat.FORNECEDORES);
                fbConnection1.Close();
                crItens_ped relatorio = new crItens_ped();
                relatorio.SetDataSource(fat);
                form_imprimir imp = new form_imprimir(relatorio);
                imp.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int trimestre = 0, ano = 0;
                if (rdbTrimestre.Checked)
                {
                    trimestre = (cbxTrimestre.SelectedIndex + 1);
                    ano = Convert.ToInt32(nudAno.Value);
                    switch (trimestre)
                    {
                        case 1:
                            dtInicio.Value = new DateTime(ano, 1, 1);
                            dtTermino.Value = new DateTime(ano, 3, 31);
                            break;
                        case 2:
                            dtInicio.Value = new DateTime(ano, 4, 1);
                            dtTermino.Value = new DateTime(ano, 6, 30);
                            break;

                        case 3:
                            dtInicio.Value = new DateTime(ano, 7, 1);
                            dtTermino.Value = new DateTime(ano, 9, 30);
                            break;

                        case 4:
                            dtInicio.Value = new DateTime(ano, 10, 1);
                            dtTermino.Value = new DateTime(ano, 12, 31);
                            break;
                    }
                }
                try
                {
                    //selecionando as empresas envolvidas
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT DISTINCT P.CNPJ_FORN_PED FROM PEDIDO_COMPRA P JOIN ITENS_PEDIDO_COMPRA I ON P.COD_PED = I.N_PEDIDO_ITEM_PED " +
                        "WHERE I.DATA_CHEGADA_ITEM_PED >= '" +
                        Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "I.DATA_CHEGADA_ITEM_PED <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();
                    dsIqf iqf = new dsIqf();
                    

                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        //selecionando itens de cada cliente
                        FbCommand select_itens = new FbCommand();
                        select_itens.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_itens.CommandText =
                            "SELECT I.CHEGOU_ITEM_PED, P.DATA_RETIRA_PED, I.DATA_CHEGADA_ITEM_PED, F.NOME_FORN " +
                            "FROM ITENS_PEDIDO_COMPRA I JOIN PEDIDO_COMPRA P ON P.COD_PED = I.N_PEDIDO_ITEM_PED "+
                            "JOIN FORNECEDORES F ON P.CNPJ_FORN_PED = F.CNPJ_CPF_FORN WHERE P.CNPJ_FORN_PED = '" + dr[0].ToString() + "' AND " +
                            "DATA_CHEGADA_ITEM_PED >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                            "DATA_CHEGADA_ITEM_PED <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        FbDataAdapter datItens = new FbDataAdapter();
                        datItens.SelectCommand = select_itens;
                        DataSet dsItens = new DataSet();
                        datItens.Fill(dsItens);
                        fbConnection1.Close();
                        int n_itens = dsItens.Tables[0].Rows.Count;
                        int itens_no_prazo = 0;
                        int itens_fora_prazo = 0;
                        int itens_aprovados = 0;
                        int itens_reprovados = 0;
                        string fornecedor = "";
                        foreach (DataRow dr_itens in dsItens.Tables[0].Rows)
                        {
                            fornecedor = dr_itens[3].ToString();
                            try
                            {
                                if (dr_itens[0].ToString() == "1")
                                {//SE ITEM JÁ CHEGOU
                                    itens_aprovados++;
                                    if (Convert.ToDateTime(dr_itens[1].ToString()) <
                                        Convert.ToDateTime(dr_itens[2].ToString()))
                                    {//SE DATA_LIMITE < DATA_CHEGADA
                                        itens_fora_prazo++;
                                    }
                                    else
                                    {
                                        itens_no_prazo++;
                                    }
                                }
                                //calculando IQF
                                
                            }
                            catch (Exception a)
                            {
                                //MessageBox.Show(a.ToString());
                            }
                        }
                        double _iqf = 0;
                        if ((itens_no_prazo > 0 || itens_fora_prazo > 0) && (itens_aprovados > 0 || itens_reprovados > 0))
                        {
                            _iqf = ((itens_no_prazo + (itens_fora_prazo * 0.5)) / (itens_no_prazo + itens_fora_prazo) +
                                (itens_aprovados + (itens_reprovados * 0)) / (itens_aprovados + itens_reprovados)) / 2;
                        }

                        iqf.IQF.AddIQFRow(dr[0].ToString(), fornecedor, itens_no_prazo, itens_fora_prazo,
                            itens_aprovados, itens_reprovados, _iqf);
                    }
                    iqf.Periodo.AddPeriodoRow(Convert.ToDateTime(dtInicio.Text), Convert.ToDateTime(dtTermino.Text),trimestre,ano);
                    crIqf2 relatorio = new crIqf2();
                    relatorio.SetDataSource(iqf);
                    form_imprimir imprime = new form_imprimir(relatorio);
                    imprime.Show();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void rdbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPeriodo.Checked)
            {
                dtInicio.Visible = true;
                dtTermino.Visible = true;
                lblInicio.Text = "Início";
                lblTermino.Text = "Término";
                nudAno.Visible = false;
                cbxTrimestre.Visible = false;
            }
            else
            {
                dtInicio.Visible = true;
                dtTermino.Visible = true;
            }
        }

        private void rdbTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTrimestre.Checked)
            {
                nudAno.Visible = true;
                cbxTrimestre.Visible = true;
                lblInicio.Text = "Trimestre";
                lblTermino.Text = "Ano";
                cbxTrimestre.SelectedIndex = 0;
                nudAno.Value = DateTime.Now.Year;
                dtInicio.Visible = false;
                dtTermino.Visible = false;
            }
            else
            {
                nudAno.Visible = true;
                cbxTrimestre.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int trimestre = 0, ano = 0;
                if (rdbTrimestre.Checked)
                {
                    trimestre = (cbxTrimestre.SelectedIndex + 1);
                    ano = Convert.ToInt32(nudAno.Value);
                    switch (trimestre)
                    {
                        case 1:
                            dtInicio.Value = new DateTime(ano, 1, 1);
                            dtTermino.Value = new DateTime(ano, 3, 31);
                            break;
                        case 2:
                            dtInicio.Value = new DateTime(ano, 4, 1);
                            dtTermino.Value = new DateTime(ano, 6, 30);
                            break;

                        case 3:
                            dtInicio.Value = new DateTime(ano, 7, 1);
                            dtTermino.Value = new DateTime(ano, 9, 30);
                            break;

                        case 4:
                            dtInicio.Value = new DateTime(ano, 10, 1);
                            dtTermino.Value = new DateTime(ano, 12, 31);
                            break;
                    }
                }
                try
                {
                    //selecionando as empresas envolvidas
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT DISTINCT P.COD_FORN_TERCEIRO FROM TERCEIROS P JOIN ITENS_TERCEIROS I ON P.COD_TERCEIRO = I.COD_TERCEIRO_ITEM_TERCEIRO " +
                        "WHERE I.DATA_ENTRADA_ITEM_TERCEIRO >= '" +
                        Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "I.DATA_ENTRADA_ITEM_TERCEIRO <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();
                    dsIqf iqf = new dsIqf();


                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        //selecionando itens de cada cliente
                        FbCommand select_itens = new FbCommand();
                        select_itens.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_itens.CommandText =
                            "SELECT '1', I.DATA_PREVISTA_ITEM_TERCEIRO, I.DATA_ENTRADA_ITEM_TERCEIRO, F.NOME_FORN " +
                            "FROM ITENS_TERCEIROS I JOIN TERCEIROS P ON P.COD_TERCEIRO = I.COD_TERCEIRO_ITEM_TERCEIRO " +
                            "JOIN FORNECEDORES F ON P.COD_FORN_TERCEIRO = F.COD_FORN WHERE P.COD_FORN_TERCEIRO = '" + dr[0].ToString() + "' AND " +
                            "I.DATA_ENTRADA_ITEM_TERCEIRO >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                            "I.DATA_ENTRADA_ITEM_TERCEIRO <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        FbDataAdapter datItens = new FbDataAdapter();
                        datItens.SelectCommand = select_itens;
                        DataSet dsItens = new DataSet();
                        datItens.Fill(dsItens);
                        fbConnection1.Close();
                        int n_itens = dsItens.Tables[0].Rows.Count;
                        int itens_no_prazo = 0;
                        int itens_fora_prazo = 0;
                        int itens_aprovados = 0;
                        int itens_reprovados = 0;
                        string fornecedor = "";
                        foreach (DataRow dr_itens in dsItens.Tables[0].Rows)
                        {
                            fornecedor = dr_itens[3].ToString();
                            try
                            {
                                if (dr_itens[0].ToString() == "1")
                                {//SE ITEM JÁ CHEGOU
                                    itens_aprovados++;
                                    if (Convert.ToDateTime(dr_itens[1].ToString()) <
                                        Convert.ToDateTime(dr_itens[2].ToString()))
                                    {//SE DATA_LIMITE < DATA_CHEGADA
                                        itens_fora_prazo++;
                                    }
                                    else
                                    {
                                        itens_no_prazo++;
                                    }
                                }
                                //calculando IQF

                            }
                            catch (Exception a)
                            {
                                //MessageBox.Show(a.ToString());
                            }
                        }
                        double _iqf = 0;
                        if ((itens_no_prazo > 0 || itens_fora_prazo > 0) && (itens_aprovados > 0 || itens_reprovados > 0))
                        {
                            _iqf = ((itens_no_prazo + (itens_fora_prazo * 0.5)) / (itens_no_prazo + itens_fora_prazo) +
                                (itens_aprovados + (itens_reprovados * 0)) / (itens_aprovados + itens_reprovados)) / 2;
                        }
                        if (fornecedor != "")
                        {
                            iqf.IQF.AddIQFRow(dr[0].ToString(), fornecedor, itens_no_prazo, itens_fora_prazo,
                                itens_aprovados, itens_reprovados, _iqf);
                        }
                    }
                    iqf.Periodo.AddPeriodoRow(Convert.ToDateTime(dtInicio.Text), Convert.ToDateTime(dtTermino.Text), trimestre, ano);
                    crIqf2 relatorio = new crIqf2();
                    relatorio.SetDataSource(iqf);
                    form_imprimir imprime = new form_imprimir(relatorio);
                    imprime.Show();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
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
            try
            {
                int trimestre = 0, ano = 0;
                if (rdbTrimestre.Checked)
                {
                    trimestre = (cbxTrimestre.SelectedIndex + 1);
                    ano = Convert.ToInt32(nudAno.Value);
                    switch (trimestre)
                    {
                        case 1:
                            dtInicio.Value = new DateTime(ano, 1, 1);
                            dtTermino.Value = new DateTime(ano, 3, 31);
                            break;
                        case 2:
                            dtInicio.Value = new DateTime(ano, 4, 1);
                            dtTermino.Value = new DateTime(ano, 6, 30);
                            break;

                        case 3:
                            dtInicio.Value = new DateTime(ano, 7, 1);
                            dtTermino.Value = new DateTime(ano, 9, 30);
                            break;

                        case 4:
                            dtInicio.Value = new DateTime(ano, 10, 1);
                            dtTermino.Value = new DateTime(ano, 12, 31);
                            break;
                    }
                }
                dsIqf iqf = new dsIqf();
                try
                {
                    //selecionando as empresas envolvidas
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT DISTINCT P.CNPJ_FORN_PED FROM PEDIDO_COMPRA P JOIN FORNECEDORES F ON P.CNPJ_FORN_PED = F.CNPJ_CPF_FORN JOIN ITENS_PEDIDO_COMPRA I ON P.COD_PED = I.N_PEDIDO_ITEM_PED " +
                        "WHERE F.PRODUTIVO_FORN = '1' AND I.DATA_CHEGADA_ITEM_PED >= '" +
                        Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "I.DATA_CHEGADA_ITEM_PED <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();



                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        //selecionando itens de cada cliente
                        FbCommand select_itens = new FbCommand();
                        select_itens.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_itens.CommandText =
                            "SELECT I.CHEGOU_ITEM_PED, P.DATA_RETIRA_PED, I.DATA_CHEGADA_ITEM_PED, F.NOME_FORN " +
                            "FROM ITENS_PEDIDO_COMPRA I JOIN PEDIDO_COMPRA P ON P.COD_PED = I.N_PEDIDO_ITEM_PED " +
                            "JOIN FORNECEDORES F ON P.CNPJ_FORN_PED = F.CNPJ_CPF_FORN WHERE P.CNPJ_FORN_PED = '" + dr[0].ToString() + "' AND " +
                            "DATA_CHEGADA_ITEM_PED >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                            "DATA_CHEGADA_ITEM_PED <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        FbDataAdapter datItens = new FbDataAdapter();
                        datItens.SelectCommand = select_itens;
                        DataSet dsItens = new DataSet();
                        datItens.Fill(dsItens);
                        fbConnection1.Close();
                        int n_itens = dsItens.Tables[0].Rows.Count;
                        int itens_no_prazo = 0;
                        int itens_fora_prazo = 0;
                        int itens_aprovados = 0;
                        int itens_reprovados = 0;
                        string fornecedor = "";
                        foreach (DataRow dr_itens in dsItens.Tables[0].Rows)
                        {
                            fornecedor = dr_itens[3].ToString();
                            try
                            {
                                if (dr_itens[0].ToString() == "1")
                                {//SE ITEM JÁ CHEGOU
                                    itens_aprovados++;
                                    if (Convert.ToDateTime(dr_itens[1].ToString()) <
                                        Convert.ToDateTime(dr_itens[2].ToString()))
                                    {//SE DATA_LIMITE < DATA_CHEGADA
                                        itens_fora_prazo++;
                                    }
                                    else
                                    {
                                        itens_no_prazo++;
                                    }
                                }
                                //calculando IQF

                            }
                            catch (Exception a)
                            {
                                //MessageBox.Show(a.ToString());
                            }
                        }
                        double _iqf = 0;
                        if ((itens_no_prazo > 0 || itens_fora_prazo > 0) && (itens_aprovados > 0 || itens_reprovados > 0))
                        {
                            _iqf = ((itens_no_prazo + (itens_fora_prazo * 0.5)) / (itens_no_prazo + itens_fora_prazo) +
                                (itens_aprovados + (itens_reprovados * 0)) / (itens_aprovados + itens_reprovados)) / 2;
                        }

                        iqf.IQF.AddIQFRow(dr[0].ToString(), fornecedor, itens_no_prazo, itens_fora_prazo,
                            itens_aprovados, itens_reprovados, _iqf);
                    }



                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                try
                {
                    //selecionando as empresas envolvidas
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT DISTINCT P.COD_FORN_TERCEIRO FROM TERCEIROS P JOIN FORNECEDORES F ON P.COD_FORN_TERCEIRO = F.COD_FORN JOIN ITENS_TERCEIROS I ON P.COD_TERCEIRO = I.COD_TERCEIRO_ITEM_TERCEIRO " +
                        "WHERE F.PRODUTIVO_FORN = '1' AND I.DATA_ENTRADA_ITEM_TERCEIRO >= '" +
                        Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "I.DATA_ENTRADA_ITEM_TERCEIRO <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.SelectCommand = select;
                    DataSet dsTabela = new DataSet();
                    datTabela.Fill(dsTabela);
                    fbConnection1.Close();



                    foreach (DataRow dr in dsTabela.Tables[0].Rows)
                    {
                        //selecionando itens de cada cliente
                        FbCommand select_itens = new FbCommand();
                        select_itens.Connection = fbConnection1;
                        fbConnection1.Open();
                        select_itens.CommandText =
                            "SELECT '1', I.DATA_PREVISTA_ITEM_TERCEIRO, I.DATA_ENTRADA_ITEM_TERCEIRO, F.NOME_FORN " +
                            "FROM ITENS_TERCEIROS I JOIN TERCEIROS P ON P.COD_TERCEIRO = I.COD_TERCEIRO_ITEM_TERCEIRO " +
                            "JOIN FORNECEDORES F ON P.COD_FORN_TERCEIRO = F.COD_FORN WHERE P.COD_FORN_TERCEIRO = '" + dr[0].ToString() + "' AND " +
                            "I.DATA_ENTRADA_ITEM_TERCEIRO >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                            "I.DATA_ENTRADA_ITEM_TERCEIRO <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        FbDataAdapter datItens = new FbDataAdapter();
                        datItens.SelectCommand = select_itens;
                        DataSet dsItens = new DataSet();
                        datItens.Fill(dsItens);
                        fbConnection1.Close();
                        int n_itens = dsItens.Tables[0].Rows.Count;
                        int itens_no_prazo = 0;
                        int itens_fora_prazo = 0;
                        int itens_aprovados = 0;
                        int itens_reprovados = 0;
                        string fornecedor = "";
                        foreach (DataRow dr_itens in dsItens.Tables[0].Rows)
                        {
                            fornecedor = dr_itens[3].ToString();
                            try
                            {
                                if (dr_itens[0].ToString() == "1")
                                {//SE ITEM JÁ CHEGOU
                                    itens_aprovados++;
                                    if (Convert.ToDateTime(dr_itens[1].ToString()) <
                                        Convert.ToDateTime(dr_itens[2].ToString()))
                                    {//SE DATA_LIMITE < DATA_CHEGADA
                                        itens_fora_prazo++;
                                    }
                                    else
                                    {
                                        itens_no_prazo++;
                                    }
                                }
                                //calculando IQF

                            }
                            catch (Exception a)
                            {
                                //MessageBox.Show(a.ToString());
                            }
                        }
                        double _iqf = 0;
                        if ((itens_no_prazo > 0 || itens_fora_prazo > 0) && (itens_aprovados > 0 || itens_reprovados > 0))
                        {
                            _iqf = ((itens_no_prazo + (itens_fora_prazo * 0.5)) / (itens_no_prazo + itens_fora_prazo) +
                                (itens_aprovados + (itens_reprovados * 0)) / (itens_aprovados + itens_reprovados)) / 2;
                        }
                        if (fornecedor != "")
                        {
                            iqf.IQF.AddIQFRow(dr[0].ToString(), fornecedor, itens_no_prazo, itens_fora_prazo,
                                itens_aprovados, itens_reprovados, _iqf);
                        }
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                iqf.Periodo.AddPeriodoRow(Convert.ToDateTime(dtInicio.Text), Convert.ToDateTime(dtTermino.Text), trimestre, ano);
                crIqf2 relatorio = new crIqf2();
                relatorio.SetDataSource(iqf);
                form_imprimir imprime = new form_imprimir(relatorio);
                imprime.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        
    }
}