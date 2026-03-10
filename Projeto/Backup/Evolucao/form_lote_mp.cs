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
    public partial class form_lote_mp : Form
    {
        public string cod_lote;
        public string cod_mp, descricao_mp, dimensoes, material, cnpj_cliente, nome_cliente, qtde, nota_fiscal;
        public bool excluir;
        public form_lote_mp()
        {
            InitializeComponent();
        }

        private void form_lote_mp_Load(object sender, EventArgs e)
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
                    "CNPJ_CLIENTE_LR, CLIENTE_LR, QTDE_LR, NOTA_FISCAL_LR, DATA_LIBERACAO_LR) VALUES " + 
                    "(" + cod_mp + "," + descricao_mp + "," + dimensoes + "," + material + "," + cnpj_cliente + "," + 
                    nome_cliente + "," + qtde + "," + nota_fiscal + ",'" + DateTime.Now.ToShortDateString().Replace("/",".") + "')";
                    datLote_recebimento.InsertCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datLote_recebimento.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    datLote_recebimento.SelectCommand.CommandText =
                        "SELECT * FROM LOTE_RECEBIMENTO WHERE COD_LR = '" + buscar_ultimo_inserido() + "'";
                    datLote_recebimento.SelectCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datLote_recebimento.SelectCommand.ExecuteNonQuery();
                    datLote_recebimento.Fill(LOTE_RECEBIMENTO);
                    fbConnection1.Close();
                    tb_qtde.Focus();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private string buscar_ultimo_inserido()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_LR FROM LOTE_RECEBIMENTO ORDER BY COD_LR DESC";
                FbDataAdapter datLr = new FbDataAdapter();
                datLr.SelectCommand = select;
                DataSet dsLr = new DataSet();
                datLr.Fill(dsLr);
                fbConnection1.Close();
                DataRow dr = dsLr.Tables[0].Rows[0];
                return dr[0].ToString();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_qtde.Text != "")
                Salvar();
            else
            {
                MessageBox.Show("O campo Qtde é obrigatório");
                tb_qtde.BackColor = Color.Red;
                tb_qtde.Focus();
                
            }
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
        }

        private void form_lote_mp_FormClosed(object sender, FormClosedEventArgs e)
        {
            cod_lote = tb_cod_lote.Text;
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
                                catch {
                                    fbConnection1.Close();
                                }

                            }

                        }
                    }
                    catch { }

                }
            }
        }
    }
}