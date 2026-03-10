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
    public partial class form_os_entregues : Form
    {
        public string[] ops_faturamento = new string[200];
        public int qtde_selecionada;
        public form_os_entregues()
        {
            InitializeComponent();
        }

        private void form_os_entregues_Load(object sender, EventArgs e)
        {
            try
            {
                dgvOp.AutoGenerateColumns = false;
                dgvOp.DataSource = dsOp.Tables["OP"];
                dsOp.Clear();
                this.datOp.SelectCommand.CommandText =
                    "SELECT first(1000) op.*, desenhos.CLIENTE FROM OP op INNER JOIN DESENHOS desenhos ON op.DESENHO_OP_ATUAL = desenhos.N_OS_PECA WHERE op.COD_OP IS NOT NULL " +
                    " ORDER BY op.cod_op DESC ";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datOp.Fill(OP);
                cores();
                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;
                int j = this.Height;
                dgvOp.Width = this.Width - 40;
                dgvOp.Height = this.Height - (dgvOp.Location.Y) - 40;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fbConnection1.Close();
                PrintAllErrs(dsOp);
            }
        }
        private void tb_cliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //dsOp.Tables["OP"].DefaultView.RowFilter = "CLIENTE_OP Like '" + tb_cliente.Text + "'";
            }
            catch { }
        }

        private void tb_os_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "DESENHO_OP_ATUAL Like '*" + tb_os.Text + "*'";
            }
            catch { }
            cores();
        }

        private void tb_ferramenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "FERRAMENTA_OP Like '*" + tb_ferramenta.Text + "*'";
            }
            catch { }
            cores();
        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "COND_PGTO Like '*" + tb_item.Text + "*'";
            }
            catch { }
            cores();
        }
        private void selecionar()
        {
            try
            {
                string faturado_01 = "";
                string nao_finalizada = "";
                string finalizada = "";
                string cliente = "";
                string campo = "";
                string urgente = "";
                string op = "";
                string item = "";
                string posicao_atual = "";
                if(tb_posicao.Text != "")
                    posicao_atual = " and POSICAO_ATUAL_OP Like '%" + tb_posicao.Text + "%'";
                if(tb_item.Text != "")
                    item = " and COND_PGTO Like '%" + tb_item.Text + "%'";
                if(txtLote.Text != "")
                    op = " AND (COD_OP = '" + txtLote.Text.Trim() + "' OR OP_MAE = '" + txtLote.Text.Trim() + "') ";
                if (cbUrgente.Checked)
                {
                    urgente = " AND op.URGENTE_OP = '1' ";
                }
                if (cb_faturado_01.Checked)
                {
                    faturado_01 = " AND op.FINALIZADO_OP = '1' AND op.CODIGO_OP = '01' ";
                }

                if (data_saidaradioButton.Checked)
                {
                    if (cb_faturado_01.Checked)
                    {
                        campo = " AND op.ENTREGOU_DIA >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                             "' AND op.ENTREGOU_DIA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    }
                    else
                    {
                        campo = " AND op.ENTREGOU_DIA >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                            "' AND op.ENTREGOU_DIA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    }
                }
                else
                {
                    if (data_entradaradioButton.Checked)
                    {
                        campo = " AND op.DATA_PDF >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                        "' AND op.DATA_PDF <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    }
                   
                }
                if (cb_finalizadas.Checked == true)
                    finalizada = " AND op.POSICAO_ATUAL_OP = 'Finalizado' ";
                if (naoentreguesCheckbox.Checked)
                    nao_finalizada = " AND op.POSICAO_ATUAL_OP != 'Finalizado' ";
                if (textBox1.Text != "")
                    cliente = " AND desenhos.CLIENTE = '" + textBox1.Text + "' ";






                dsOp.Clear();
                this.datOp.SelectCommand.CommandText =
                        "SELECT op.*, ipv.VALOR_TOTAL_PROD_ITEM_VENDA FROM OP op " +
                        " LEFT JOIN ITENS_PEDIDO_VENDA ipv on op.COD_OP = ipv.OP_INTERNA_ITEM_VENDA " + 
                        " WHERE op.COD_OP IS NOT NULL " +
                    campo + finalizada + nao_finalizada + cliente + faturado_01 + urgente + item +  op + posicao_atual + " ORDER BY op.cod_op DESC ";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datOp.Fill(OP);
                cores();
            }
            catch
            {
                fbConnection1.Close();
                PrintAllErrs(dsOp);
                // MessageBox.Show("Erro 101");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            selecionar();
        }
        private void PrintAllErrs(DataSet dataSet)
        {
            DataRow[] rowsInError;

            foreach (DataTable table in dataSet.Tables)
            {
                // Test if the table has errors. If not, skip it. 
                if (table.HasErrors)
                {
                    // Get an array of all rows with errors.
                    rowsInError = table.GetErrors();
                    // Print the error of each column in each row. 
                    for (int i = 0; i < rowsInError.Length; i++)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.WriteLine(column.ColumnName + " " +
                                rowsInError[i].GetColumnError(column));
                        }
                        // Clear the row errors
                        rowsInError[i].ClearErrors();
                    }
                }
            }
        }
        private void cores()
        {
            for (int i = 0; i < dgvOp.RowCount; i++)
            {
                if (dgvOp.Rows[i].Cells["col_pos_atual"].Value.ToString().Contains("ITEM ENTREGUE") || dgvOp.Rows[i].Cells["col_pos_atual"].Value.ToString().Contains("ITEM FINALIZADO"))
                {
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (dgvOp.Rows[i].Cells["URGENTE_OP"].Value.ToString() == "1")
                {
                    //VERMELHO
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (dgvOp.Rows[i].Cells["col_pos_atual"].Value.ToString().Contains("RESERVAD"))
                {
                    //ROXO
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.Orchid;
                }
                else if (dgvOp.Rows[i].Cells["col_pos_atual"].Value.ToString().Contains("Processo"))
                {
                    //AMARELO
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (dgvOp.Rows[i].Cells["col_pos_atual"].Value.ToString().Contains("Setup"))
                {
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.RosyBrown;
                }
                else if (dgvOp.Rows[i].Cells["col_pos_atual"].Value.ToString().Contains("Banho"))
                {
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else if (dgvOp.Rows[i].Cells["col_pos_atual"].Value.ToString().Contains("Corte"))
                {
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else if (dgvOp.Rows[i].Cells["col_fin"].Value.ToString() == "1")
                {
                    dgvOp.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "POSICAO_ATUAL_OP Like '*" + tb_posicao.Text + "*'";
            }
            catch { }
            cores();
        }

        private void tb_cliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsConsulta imprime_os = new dsConsulta();
            cb_faturado_01.Checked = true;
            selecionar();
            fbConnection1.Open();
            datOp.Fill(imprime_os.OP);
            fbConnection1.Close();
            crPosicao_os ficha_nova = new crPosicao_os();
            ficha_nova.SetDataSource(imprime_os);
            ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            form_imprimir imprimir = new form_imprimir(ficha_nova);
            imprimir.Show();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //form_localiza_cliente cli = new form_localiza_cliente();
            //try
            //{
            //    cli.ShowDialog();
            //}
            //finally
            //{
            //    textBox1.Text = cli.cliente_escolhido;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fbConnection1.Open();
            FbDataAdapter datDesenhos = new FbDataAdapter();
            comando_select.CommandText = "SELECT * FROM DESENHOS";
            datDesenhos.SelectCommand = comando_select;
            DataSet dsDesenhos = new DataSet();
            datDesenhos.Fill(dsDesenhos);
            fbConnection1.Close();
            foreach (DataRow dr in dsDesenhos.Tables[0].Rows)
            {
                try
                {
                    this.datOp.UpdateCommand.CommandText =
                        "UPDATE OP SET DATA_ENTRADA_OP = '" + Convert.ToDateTime(dr["data_abertura_peca"].ToString()).ToShortDateString().Replace("/", ".") +
                        "' WHERE DESENHO_OP_ATUAL = '" + dr["N_OS_PECA"].ToString() + "'";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                selecionar();
                dsImprimir_op imprime_os = new dsImprimir_op();
                fbConnection1.Open();
                datRotas_campo.Fill(imprime_os.ROTAS_CAMPO);
                datOp.Fill(imprime_os.OP);
                fbConnection1.Close();
                crOs_detalhada ficha_nova = new crOs_detalhada();
                ficha_nova.SetDataSource(imprime_os);
                ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(ficha_nova);
                imprimir.Show();

                
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            /*
            try
            {
                string os_escolhidas = "WHERE OP_ROTA = '" + dgvOp.Rows[0].Cells["col_cod_op"].Value.ToString() + "'";
                for (int i = 1; i < dgvOp.RowCount; i++)
                {
                    os_escolhidas = os_escolhidas + " OR OP_ROTA = '" + dgvOp.Rows[i].Cells["col_cod_op"].Value.ToString() + "'";
                }
                datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO " + os_escolhidas;
                datRotas_campo.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                fbConnection1.Close();

                dsImprimir_op imprime_os = new dsImprimir_op();
                fbConnection1.Open();
                datRotas_campo.Fill(imprime_os.ROTAS_CAMPO);
                datOp.Fill(imprime_os.OP);
                fbConnection1.Close();
                crOs_detalhada ficha_nova = new crOs_detalhada();
                ficha_nova.SetDataSource(imprime_os);
                ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(ficha_nova);
                imprimir.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            */

        }

        private void nf_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "NF_SAIDA_OP = '" + nf_tb.Text + "'";
            }
            catch { }
            cores();
        }

        private void tb_pedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "PEDIDO_OP Like '*" + tb_posicao.Text + "*'";
            }
            catch { }
            cores();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgvOp.SelectedRows.Count; i++)
            {
                string posicao_atual;
                if (verificar_se_e_faturada(dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString(), out posicao_atual))
                {
                    if (posicao_atual.Contains("RESERVADO") || cbSimulacao_nota.Checked)
                    {
                        ops_faturamento[i] = dgvOp.SelectedRows[i].Cells["col_cod_op"].Value.ToString();
                        qtde_selecionada = i + 1;
                    }
                    else
                    {
                        MessageBox.Show("O estoque dessa OS tem que estar RESERVADO para ser faturado. Avise o estoque");
                    }
                }
                else
                {
                    MessageBox.Show("Essa posição não pode ser faturada");
                }
            }
            
            this.Close();
        }

        private bool verificar_se_e_faturada(string op, out string posicao_atual)
        {
            posicao_atual = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT CODIGO_OP, NF_SAIDA_OP, POSICAO_ATUAL_OP FROM OP WHERE COD_OP = '" + op + "'";
                FbDataAdapter opDataAdapter = new FbDataAdapter();
                opDataAdapter.SelectCommand = select;
                DataSet opDataSet = new DataSet();
                opDataAdapter.Fill(opDataSet);
                fbConnection1.Close();
                DataRow dr = opDataSet.Tables[0].Rows[0];
                posicao_atual = dr[2].ToString();
                if (dr[0].ToString() == "00" && dr[1].ToString().Trim() == "")
                    return true;
                else
                    return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return false;
            }
        }

        private void tb_tipo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "CODIGO_OP LIKE '*" + tb_tipo.Text + "*'";
            }
            catch { }
            cores();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dsConsulta imprime_os = new dsConsulta();
            cb_faturado_01.Checked = true;
            selecionar();
            fbConnection1.Open();
            datOp.Fill(imprime_os.OP);
            fbConnection1.Close();
            string os = "";
            foreach (DataRow dr in imprime_os.OP.Rows)
            {
                if (os == "")
                {
                    os += " WHERE N_OS_PECA = '" + dr["DESENHO_OP_ATUAL"].ToString() + "'";
                }
                else
                {
                    os += " OR N_OS_PECA = '" + dr["DESENHO_OP_ATUAL"].ToString() + "'";
                }
            }
            if (os != "")
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = "SELECT * FROM DESENHOS " + os + " ORDER BY DATA_FINALIZACAO_OS";
                FbDataAdapter datDesenhos = new FbDataAdapter();
                datDesenhos.SelectCommand = select;
                datDesenhos.SelectCommand.ExecuteNonQuery();
                fbConnection1.Close();
                //datDesenhos.Fill(imprime_os.DESENHOS);
                crFaturamento_01_os ficha_nova = new crFaturamento_01_os();
                ficha_nova.SetDataSource(imprime_os);
                ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(ficha_nova);
                imprimir.Show();
            }
        }
        private void selecionarAntigo()
        {
            try
            {

                string nao_finalizada = "";
                string finalizada = "";
                string cliente = "";
                string campo = "";
                if (data_saidaradioButton.Checked)
                {
                    campo = " AND DATA_NF_SAIDA >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                    "' AND DATA_NF_SAIDA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                }
                else
                {
                    if (data_entradaradioButton.Checked)
                    {
                        campo = "AND DATA_ENTRADA_OP >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                        "' AND DATA_ENTRADA_OP <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                    }
                    else
                    {
                        if (data_entrada_previstaradioButton.Checked)
                        {
                            campo = "AND ENTREGOU_DIA >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + //"" + 
                            "' AND ENTREGOU_DIA <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
                        }
                    }
                }
                string os = "";
                if (tb_os.Text != "")
                    os = " AND DESENHO_OP_ATUAL Like UPPER('%" + tb_os.Text + "%')";
                string ferramenta = "";
                if (tb_ferramenta.Text != "")
                    ferramenta = " AND FERRAMENTA_OP Like UPPER('%" + tb_ferramenta.Text + "%')";
                string item = "";
                if (tb_item.Text != "")
                    item = " AND COND_PGTO Like UPPER('" + tb_item.Text + "%')";
                string posicao_atual = "";
                if (tb_posicao.Text != "")
                {
                    posicao_atual = " AND POSICAO_ATUAL_OP Like UPPER('%" + tb_posicao.Text + "%')";
                }

                if (cb_finalizadas.Checked == true)
                    finalizada = " AND POSICAO_ATUAL_OP LIKE '%ITEM FINALIZADO%' ";
                if (naoentreguesCheckbox.Checked)
                    nao_finalizada = " AND (POSICAO_ATUAL_OP NOT LIKE '%ITEM FINALIZADO%' OR POSICAO_ATUAL_OP IS NULL OR NF_SAIDA_OP IS NULL) ";
                if (textBox1.Text != "")
                    cliente = " AND CLIENTE_OP = '" + textBox1.Text + "' ";
                dsOp.Clear();
                this.datOp.SelectCommand.CommandText =
                        "SELECT * FROM OP WHERE COD_OP IS NOT NULL " +
                    campo + finalizada + nao_finalizada + cliente + os + ferramenta + item + posicao_atual + " ORDER BY N_PDF ";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datOp.Fill(OP);
                

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro 101");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                selecionar();
                
               
                dsConsulta imprime_os = new dsConsulta();
                fbConnection1.Open();
                datOp.Fill(imprime_os.OP);
               // datTabela.Fill(imprime_os.DESENHOS);
                fbConnection1.Close();
                crPosicao_os_resumo ficha_nova = new crPosicao_os_resumo();
                ficha_nova.SetDataSource(imprime_os);
                ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(ficha_nova);
                imprimir.Show();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            if (txtLote.Text.Trim() != "")
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = "COD_OP = '" + txtLote.Text.Trim() + "' OR OP_MAE = '" + txtLote.Text.Trim() + "' ";
                }
                catch { }
            }
            else
            {
                dsOp.Tables["OP"].DefaultView.RowFilter = "COD_OP IS NOT NULL";
            }
            cores();
        }

        private void form_os_entregues_SizeChanged(object sender, EventArgs e)
        {
            dgvOp.Width = this.Width - 40;
            dgvOp.Height = this.Height - (dgvOp.Location.Y) - 40;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //form_localiza_cliente localiza_cliente = new form_localiza_cliente();
            //try
            //{
            //    localiza_cliente.ShowDialog();
            //}
            //finally
            //{
            //    localiza_cliente.Dispose();
            //    textBox1.Text = localiza_cliente.cliente_escolhido;
            //}
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string campo = " WHERE data_inicio_ap >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") +
            //            "' AND data_inicio_ap <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "'";
            //    FbCommand select = new FbCommand();
            //    select.Connection = fbConnection1;
            //    fbConnection1.Open();
            //    select.CommandText =
            //        "select distinct(p.os_ap) as OP, op.desenho_op_atual AS OS, p.item_ap AS PECA, op.qde_fab AS QTDE " +
            //        "from apontamentos p " +
            //        "join op on p.os_ap = op.cod_op " + campo;
            //    FbDataAdapter datTabela = new FbDataAdapter();
            //    datTabela.SelectCommand = select;
            //    fbConnection1.Close();

            //    dsImprimir_op imprime_os = new dsImprimir_op();
            //    fbConnection1.Open();
            //    datTabela.Fill(imprime_os.PRODUCAO_OS);
            //    fbConnection1.Close();
            //    crProducao ficha_nova = new crProducao();
            //    ficha_nova.SetDataSource(imprime_os);
            //    ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            //    ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            //    form_imprimir imprimir = new form_imprimir(ficha_nova);
            //    imprimir.Show();
            //}
            //catch (Exception a)
            //{
            //    fbConnection1.Close();
            //    MessageBox.Show(a.ToString());
            //}
        }

        private void cbUrgente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUrgente.Checked)
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = " URGENTE_OP = '1' ";
                }
                catch { }
            }
            else
            {
                try
                {
                    dsOp.Tables["OP"].DefaultView.RowFilter = " URGENTE_OP IS NULL OR URGENTE_OP = 0 ";
                }
                catch { }
            }
            cores();
        }

        private void dgvOp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form_op op = new form_op();
            op.cod_op_atual_variavel = dgvOp.Rows[e.RowIndex].Cells["col_cod_op"].Value.ToString();
            op.codOsSistema = dgvOp.Rows[e.RowIndex].Cells["col_os"].Value.ToString();
            try
            {
                op.Show();
            }
            finally
            {

            }
        }

        
    }
}