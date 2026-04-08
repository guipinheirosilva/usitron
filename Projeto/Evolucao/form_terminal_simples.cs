using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_terminal_simples : Form
    {
        public form_terminal_simples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Aguardando Material
Corte / Separação
Produção
Finalizado 
             */
            int indiceStatus = CmbIdxFindByValue(labelStatus.Text, cbStatus);
            bool autorizacao = true;
            if (currentMyComboBoxIndex < indiceStatus)
            {
                autorizacao = false;


                if (DialogResult.Yes == MessageBox.Show("Para mudar o Status da OP para uma operação anterior é necesssário autorização especial. Gostaria de digitar a senha?",
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
                            if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3" || usuario._cod_usuario == "4")
                            {
                                autorizacao = true;
                            }
                        }
                    }
                }
            }
            if (autorizacao)
            {
                try
                {
                    bool inspecao = true;
                    bool conjunto = false;
                    string cod_interno_produto = "";
                    try
                    {
                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText = @"SELECT COD_PRODUTO, op.QDE_FAB FROM PRODUTOS p inner join OP op on op.COND_PGTO = p.COD_FORNECEDOR_PRODUTO 
                                        where op.COD_OP = '" + tb_op.Text + "'";
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        fbConnection1.Close();
                        foreach (DataRow dr in dtSelect.Rows)
                        {
                            cod_interno_produto = dr["COD_PRODUTO"].ToString();
                            //     
                            FbCommand select1 = new FbCommand();
                            select1.Connection = fbConnection1;
                            fbConnection1.Open();
                            select1.CommandText = @"SELECT p.COD_PRODUTO as COD_INTERNO, p.COD_FORNECEDOR_PRODUTO as COD, p.DESCRICAO_PRODUTO as Descricao,  
                            (pk.QTDE_PK * " + Convert.ToDouble(dr[1].ToString()).ToString().Replace(".", "").Replace(",", ".") + @") as Qtde_Necessaria, 
                            P.estoque_atual_produto as Estoque_Atual, '' as Qtde_Lancada FROM PRODUTOS_KIT pk 
                            INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto WHERE pk.COD_KIT_PK = " + dr[0].ToString() + "";
                            FbDataAdapter datSelect1 = new FbDataAdapter();
                            datSelect1.SelectCommand = select1;
                            DataTable dtSelect1 = new DataTable();
                            datSelect1.Fill(dtSelect1);
                            fbConnection1.Close();
                            if (dtSelect1.Rows.Count > 0)
                            { conjunto = true; }
                        }
                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(ex.Message);
                    }

                    if (cbStatus.Text == "Inspeção")
                    {

                        try
                        {
                            FbCommand select = new FbCommand();
                            select.Connection = fbConnection1;
                            fbConnection1.Open();
                            select.CommandText = @"SELECT COD_PRODUTO, op.QDE_FAB FROM PRODUTOS p inner join OP op on op.COND_PGTO = p.COD_FORNECEDOR_PRODUTO 
                                        where op.COD_OP = '" + tb_op.Text + "'";
                            FbDataAdapter datSelect = new FbDataAdapter();
                            datSelect.SelectCommand = select;
                            DataTable dtSelect = new DataTable();
                            datSelect.Fill(dtSelect);
                            fbConnection1.Close();
                            foreach (DataRow dr in dtSelect.Rows)
                            {
                                //     
                                FbCommand select1 = new FbCommand();
                                select1.Connection = fbConnection1;
                                fbConnection1.Open();
                                select1.CommandText = @"SELECT p.COD_PRODUTO as COD_INTERNO, p.COD_FORNECEDOR_PRODUTO as COD, p.DESCRICAO_PRODUTO as Descricao,  
                            (pk.QTDE_PK * " + Convert.ToDouble(dr[1].ToString()).ToString().Replace(".", "").Replace(",", ".") + @") as Qtde_Necessaria, 
                            P.estoque_atual_produto as Estoque_Atual, '' as Qtde_Lancada FROM PRODUTOS_KIT pk 
                            INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto WHERE pk.COD_KIT_PK = " + dr[0].ToString() + "";
                                FbDataAdapter datSelect1 = new FbDataAdapter();
                                datSelect1.SelectCommand = select1;
                                DataTable dtSelect1 = new DataTable();
                                datSelect1.Fill(dtSelect1);
                                fbConnection1.Close();
                                if (dtSelect.Rows.Count == 0)
                                    inspecao = true;
                                foreach (DataRow dr1 in dtSelect.Rows)
                                {
                                    form_inspecao_componentes _inspecao = new form_inspecao_componentes();
                                    _inspecao.op = tb_op.Text;
                                    _inspecao.dtComponentes = dtSelect1;
                                    try
                                    {
                                        _inspecao.ShowDialog();
                                    }
                                    finally
                                    {
                                        inspecao = _inspecao.ok_tudo;
                                    }
                                }
                            }


                        }
                        catch (Exception ex)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(ex.Message);
                        }

                    }

                    if (inspecao)
                    {
                      
                        bool conjunto_inspecao = true;
                        if (conjunto && cbStatus.Text == "Finalizado" && labelStatus.Text != "Inspeção")
                            conjunto_inspecao = false;
                        if (!conjunto_inspecao)
                            MessageBox.Show("Quando for conjunto é obrigatório fazer a inspeção antes da finalização");
                        else
                        {
                            if (cbStatus.Text == "Finalizado")
                            {
                                if (tb_endereço.Text != "")
                                {
                                    FbCommand update1 = new FbCommand();
                                    update1.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    update1.CommandText =
                                        "UPDATE OP SET POSICAO_ATUAL_OP = '" + cbStatus.Text + "', FINALIZADO_OP = '1',  ENTREGOU_DIA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' " +
                                        "WHERE COD_OP = '" + tb_op.Text + "'";
                                    FbDataAdapter estoqueDataAdapter1 = new FbDataAdapter();
                                    estoqueDataAdapter1.UpdateCommand = update1;
                                    estoqueDataAdapter1.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();

                                    FbCommand update2 = new FbCommand();
                                    update2.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    update2.CommandText =
                                        "UPDATE PRODUTOS SET LOCALIZACAO_PRODUTO = '" + tb_endereço.Text + "' " +
                                        "WHERE COD_PRODUTO = '" + cod_interno_produto + "'";
                                    FbDataAdapter estoqueDataAdapter2 = new FbDataAdapter();
                                    estoqueDataAdapter2.UpdateCommand = update2;
                                    estoqueDataAdapter2.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();

                                    string cod_produto = buscar_cod_produto(tb_op.Text);
                                    classeEstoque estoque = new classeEstoque();
                                    estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                    estoque.calcular_estoque(cod_produto);
                                }
                                else
                                {
                                    MessageBox.Show("Para finalizar é obrigatório lançar o endereço da peça");
                                    conjunto_inspecao = false;
                                }
                            }
                            else
                            {
                                FbCommand update = new FbCommand();
                                update.Connection = fbConnection1;
                                fbConnection1.Open();
                                update.CommandText =
                                    "UPDATE OP SET POSICAO_ATUAL_OP = '" + cbStatus.Text + "' " +
                                    "WHERE COD_OP = '" + tb_op.Text + "'";
                                FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                                estoqueDataAdapter.UpdateCommand = update;
                                estoqueDataAdapter.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                        }
                       
                        //Inspeção
                        if (conjunto_inspecao)
                            MessageBox.Show("OP Atualizada para " + cbStatus.Text + "");
                    }
                    else
                    {
                        MessageBox.Show("Inspeção não realizada");
                    }
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não Autorizado");
            }


            tb_endereço.Text = "";
            labelStatus.Text = "Status Atual";
            tb_op.Text = "";
            cbStatus.Text = "";
            tb_op.Focus();


        }

        private bool buscar_estoque_componentes(string p)
        {
            throw new NotImplementedException();
        }

        private int CmbIdxFindByValue(string text, ComboBox cmbCd)
        {
            int c = 0; ;
            DataTable dtx = new DataTable();
            DataColumn col = new DataColumn();
            dtx.Columns.Add(col);
            for (int i = 0; i < cmbCd.Items.Count; i++)
            {
                dtx.Rows.Add(cmbCd.Items[i].ToString());
            }
            if (dtx != null)
            {
                foreach (DataRow dx in dtx.Rows)
                {
                    if (dx[0].ToString() == text)
                        return c;
                    c++;
                }
                return -1;
            }
            else
                return -1;
        }

        private void tb_op_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                labelStatus.Text = buscar_status(tb_op.Text);
            }
        }

        private string buscar_cod_produto(string op)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT COND_PGTO FROM OP WHERE COD_OP = '" + op + "'";
                fbConnection1.Open();
                FbDataAdapter itensDataAdapter = new FbDataAdapter();
                itensDataAdapter.SelectCommand = comando;
                DataSet itensDataSet = new DataSet();
                itensDataAdapter.Fill(itensDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itensDataSet.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }


        }

        private string buscar_status(string op)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT POSICAO_ATUAL_OP FROM OP WHERE COD_OP = '" + op + "'";
                fbConnection1.Open();
                FbDataAdapter itensDataAdapter = new FbDataAdapter();
                itensDataAdapter.SelectCommand = comando;
                DataSet itensDataSet = new DataSet();
                itensDataAdapter.Fill(itensDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itensDataSet.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }


        }
        int currentMyComboBoxIndex = -1;
        string comboBoxText = "";
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMyComboBoxIndex = cbStatus.SelectedIndex;
            comboBoxText = cbStatus.Text;
            if (comboBoxText == "Finalizado")
            {
                labelEndereco.Visible = true;
                tb_endereço.Visible = true;
                tb_endereço.Text = buscar_localizacao_cadastro(tb_op.Text);
                tb_endereço.Focus();
            }
            else
            {
                labelEndereco.Visible = false;
                tb_endereço.Visible = false;
            }
        }

        private string buscar_localizacao_cadastro(string op)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    @"SELECT LOCALIZACAO_PRODUTO FROM PRODUTOS p 
                    inner join OP op on p.COD_FORNECEDOR_PRODUTO = op.COND_PGTO WHERE op.COD_OP = '" + op + "'";
                fbConnection1.Open();
                FbDataAdapter itensDataAdapter = new FbDataAdapter();
                itensDataAdapter.SelectCommand = comando;
                DataSet itensDataSet = new DataSet();
                itensDataAdapter.Fill(itensDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in itensDataSet.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void form_terminal_simples_Load(object sender, EventArgs e)
        {

        }
    }
}
