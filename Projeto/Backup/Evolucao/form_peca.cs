using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Evolucao
{
    public partial class form_peca : Form
    {
        string[,] copiar_dados = new string[50, 5];
        public string[] copiar_rota = new string[50];
        public string[] copy_copiar_rota = new string[50];
        public int n_rotas_copiadas;
        public bool nova_peca;
        public bool nova_op;
        public bool novo_sub;
        public string cod_novo_sub;
        public object peca_atual;
        public bool peca_existente;
        public string operacao_atual;
        
        public form_peca()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsDesenhos, "DESENHOS"].AddNew();
            adiciona_num_pecas();
            tbNrotas.Text = "0";
            tb_Nsub.Text = "0";
            cod_peca_desenhos.Focus();
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            this.BindingContext[dsDesenhos, "DESENHOS"].EndCurrentEdit();
            fbConnection2.Open();
            if (dsDesenhos.HasChanges())
            {
                datDesenhos.UpdateCommand = cbDesenhos.GetUpdateCommand();
                datDesenhos.InsertCommand = cbDesenhos.GetInsertCommand();
                datDesenhos.DeleteCommand = cbDesenhos.GetDeleteCommand();
                datDesenhos.Update(dsDesenhos, "DESENHOS");
                dsDesenhos.AcceptChanges();
            }
            //inserção na tabela de rotas
            this.BindingContext[dsRotas_peca, "ROTAS_PECA"].EndCurrentEdit();
            if(dsRotas_peca.HasChanges())
            {
                datRotas_peca.UpdateCommand = cbRotas_peca.GetUpdateCommand();
                datRotas_peca.InsertCommand = cbRotas_peca.GetInsertCommand();
                datRotas_peca.DeleteCommand = cbRotas_peca.GetDeleteCommand();
                datRotas_peca.Update(dsRotas_peca, "ROTAS_PECA");
                dsRotas_peca.AcceptChanges();
            }
            //inserção na tabela de sub
            /*this.BindingContext[dsSub, "SUB"].EndCurrentEdit();
            if (dsSub.HasChanges())
            {
                datSub.UpdateCommand = cbSub.GetUpdateCommand();
                datSub.InsertCommand = cbSub.GetInsertCommand();
                datSub.DeleteCommand = cbSub.GetDeleteCommand();
                datSub.Update(dsSub, "SUB");
                dsSub.AcceptChanges();
            }*/
            this.BindingContext[dsNum_ops, "NUM_OPS"].EndCurrentEdit();
            if (dsNum_ops.HasChanges())
            {
                //MessageBox.Show("num tem modificação");
                datNum_ops.UpdateCommand = cbNum_ops.GetUpdateCommand();
                datNum_ops.InsertCommand = cbNum_ops.GetInsertCommand();
                datNum_ops.DeleteCommand = cbNum_ops.GetDeleteCommand();
                datNum_ops.Update(dsNum_ops, "NUM_OPS");
                dsNum_ops.AcceptChanges();
            }
            this.BindingContext[dsNum_rotas_campo, "NUM_ROTAS_CAMPO"].EndCurrentEdit();
            if (dsNum_rotas_campo.HasChanges())
            {
                //MessageBox.Show("num_rotascampo tem modificação");
                datNum_rotas_campo.UpdateCommand = cbNum_rotas_campo.GetUpdateCommand();

                datNum_rotas_campo.InsertCommand = cbNum_rotas_campo.GetInsertCommand();
                datNum_rotas_campo.DeleteCommand = cbNum_rotas_campo.GetDeleteCommand();
                datNum_rotas_campo.Update(dsNum_rotas_campo, "NUM_ROTAS_CAMPO");
                dsNum_rotas_campo.AcceptChanges();
            }
            fbConnection2.Close();
            //atualiza num_pecas
            this.BindingContext[dsNum_desenhos, "NUM_DESENHOS"].EndCurrentEdit();
            if (dsNum_desenhos.HasChanges())
            {
                datNum_desenhos.UpdateCommand = cbNum_desenhos.GetUpdateCommand();
                datNum_desenhos.InsertCommand = cbNum_desenhos.GetInsertCommand();
                datNum_desenhos.DeleteCommand = cbNum_desenhos.GetDeleteCommand();
                datNum_desenhos.Update(dsNum_desenhos, "NUM_DESENHOS");
                dsNum_desenhos.AcceptChanges();
            }
        }

        private void Atualizar_numeros()
        {
            fbConnection2.Open();
            
            this.BindingContext[dsNum_ops, "NUM_OPS"].EndCurrentEdit();
            if (dsNum_ops.HasChanges())
            {
                //MessageBox.Show("num tem modificação");
                datNum_ops.UpdateCommand = cbNum_ops.GetUpdateCommand();
                datNum_ops.InsertCommand = cbNum_ops.GetInsertCommand();
                datNum_ops.DeleteCommand = cbNum_ops.GetDeleteCommand();
                datNum_ops.Update(dsNum_ops, "NUM_OPS");
                dsNum_ops.AcceptChanges();
            }
            this.BindingContext[dsNum_rotas_campo, "NUM_ROTAS_CAMPO"].EndCurrentEdit();
            if (dsNum_rotas_campo.HasChanges())
            {
                //MessageBox.Show("num_rotascampo tem modificação");
                datNum_rotas_campo.UpdateCommand = cbNum_rotas_campo.GetUpdateCommand();
                datNum_rotas_campo.InsertCommand = cbNum_rotas_campo.GetInsertCommand();
                datNum_rotas_campo.DeleteCommand = cbNum_rotas_campo.GetDeleteCommand();
                datNum_rotas_campo.Update(dsNum_rotas_campo, "NUM_ROTAS_CAMPO");
                dsNum_rotas_campo.AcceptChanges();
            }
            fbConnection2.Close();
        }

        private void form_desenhos_Load(object sender, EventArgs e)
        {
            datNum_desenhos.Fill(NUM_DESENHOS);
            //datDesenhos.Fill(DESENHOS);
            datRotas_peca.Fill(ROTAS_PECA);
            datClientes.Fill(CLIENTES);
            //datSub.Fill(SUB);
            datTipos_operacoes.Fill(TIPOS_OPERACOES);
            datOp.Fill(OP);
            datNum_ops.Fill(NUM_OPS);
            datNum_rotas_campo.Fill(NUM_ROTAS_CAMPO);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsDesenhos.Tables["DESENHOS"];
            dgvRota.AutoGenerateColumns = false;
            dgvRota.DataSource = dsRotas_peca.Tables["ROTAS_PECA"];
            dgvOp.AutoGenerateColumns = false;
            dgvOp.DataSource = dsOp.Tables["OP"];
            

            if (peca_existente == true)
            {
                //MessageBox.Show(peca_atual.ToString());
                this.datDesenhos.SelectCommand.CommandText =
                "SELECT * FROM DESENHOS WHERE COD_PECA = '" + peca_atual.ToString() + "'";
                this.fbConnection2.Open();
                this.datDesenhos.SelectCommand.Connection = fbConnection2;
                this.datDesenhos.SelectCommand.ExecuteNonQuery();
                datDesenhos.Fill(DESENHOS);
                this.fbConnection2.Close();
                verifica_sub();
                /*
                int variavel_peca = Convert.ToInt16(peca_atual);
                //pois o indice começa com zero
                variavel_peca--;
                //MessageBox.Show("op usada");
                //MessageBox.Show(qualquer_op.ToString());
                //data_pdf_text.Focus();
                this.BindingContext[dsDesenhos, "DESENHOS"].Position = variavel_peca;*/
            }
            else
            {
                if (nova_peca == true)
                {
                    datDesenhos.Fill(DESENHOS);
                    if (novo_sub == true) //se for uma peça sub
                    {
                        this.BindingContext[dsDesenhos, "DESENHOS"].AddNew();
                        adiciona_num_pecas();
                        tbNrotas.Text = "0";
                        tb_Nsub.Text = "0";
                        cod_peca_desenhos.Text = cod_novo_sub;
                    }
                    else //se não for uma peça sub
                    {
                        this.BindingContext[dsDesenhos, "DESENHOS"].AddNew();
                        adiciona_num_pecas();
                        tbNrotas.Text = "0";
                        tb_Nsub.Text = "0";
                    }

                }
            }


        }

        private void adiciona_num_pecas()
        {
            int variavel_num_pecas = Convert.ToInt16(tb_num_pecas.Text);
            variavel_num_pecas++;
            tb_num_pecas.Text = variavel_num_pecas.ToString();
            tb_posicao_peca.Text = tb_num_pecas.Text;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            //this.BindingContext[dsDesenhos, "DESENHOS"].
            this.BindingContext[dsDesenhos, "DESENHOS"].Position++;
            
            cod_peca_desenhos.Focus();
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsDesenhos, "DESENHOS"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsDesenhos, "DESENHOS"].Position--;
        }

        private void cod_peca_desenhos_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("chegou aqui");
            dsRotas_peca.Tables["ROTAS_PECA"].DefaultView.RowFilter = "desenho Like '" + cod_peca_desenhos.Text + "'";
            //dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cod_peca Like '" + cod_peca_desenhos.Text + " -" + "*'";
            //dsSub.Tables["SUB"].DefaultView.RowFilter = "cod_peca_sub Like '" + cod_peca_desenhos.Text + "*'";
            dsOp.Tables["OP"].DefaultView.RowFilter = "desenho_op_atual Like'" + cod_peca_desenhos.Text + "'";

        }
        private void verifica_sub()
        {
            this.datDesenhos.SelectCommand.CommandText =
                "SELECT * FROM DESENHOS WHERE COD_PECA LIKE '" + peca_atual.ToString() + " - %" + "'";
            this.fbConnection2.Open();
            this.datDesenhos.SelectCommand.Connection = fbConnection2;
            this.datDesenhos.SelectCommand.ExecuteNonQuery();
            datDesenhos.Fill(DESENHOS);
            //dsDesenhos.Tables["DESENHOS"].DefaultView.RowFilter = "cod_peca Like '" + cod_peca_desenhos.Text + " -" + "*'";
            this.fbConnection2.Close();
        }

        private void contasub(string cont)
        {
            for (int var_i = 0; var_i<500; var_i++)
            {
                if (cont.Equals(var_i.ToString()))
                {
                    var_i++;
                    tb_Nsub.Text = var_i.ToString();
                    break;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();

            contasub(tb_Nsub.Text);
            form_peca sub = new form_peca();
            try
            {
                sub.nova_peca = true;
                sub.novo_sub = true;
                sub.cod_novo_sub = cod_peca_desenhos.Text + " - " + tb_Nsub.Text;
                sub.copiar_rota = copiar_rota;
                sub.ShowDialog();
                
            }
            finally
            {
                sub.Dispose();
                Atualizar();
                datDesenhos.Fill(DESENHOS);
                datNum_desenhos.Fill(NUM_DESENHOS);

                //dataGridView1.DataSource = dsSub.Tables["SUB"];
                
            }
        }

        private void dgvRota_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(cod_peca_desenhos.Text != "")
                dgvRota.Rows[e.RowIndex].Cells["desenho_coluna"].Value = cod_peca_desenhos.Text;
            
        }

        private void contarotas(string n_rotas)
        {
            for (int var_i = 0; var_i < 100; var_i++)
            {
                if (n_rotas.Equals(var_i.ToString()))
                {
                    var_i++;
                    tbNrotas.Text = var_i.ToString();
                    return;
                }
            }
        }
        private void deleta_rotas(string n_rotas)
        {
            for (int var_i = 0; var_i < 100; var_i++)
            {
                if (n_rotas.Equals(var_i.ToString()))
                {
                    var_i--;
                    tbNrotas.Text = var_i.ToString();
                    return;
                }
            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_peca sub = new form_peca();
            try
            {
                sub.peca_existente = true;
                sub.peca_atual = dataGridView1.Rows[e.RowIndex].Cells["cod_peca_var"].Value;
                sub.ShowDialog();
            }
            finally
            {
                sub.Dispose();
                datDesenhos.Fill(DESENHOS);
            }
        }
        private void form_peca_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nova_peca == true)
                Atualizar(); //atualizar apenas numero de ops, rotas
            else
                Atualizar_numeros();
            
        }
        
        public void abre_op_Click(object sender, EventArgs e)
        {
            Atualizar();
            /*
            if (nova_op == true)
                nova_peca = true;
            if (nova_peca == true)
            {
             * */
                try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            try
                            {
                                //MessageBox.Show("Está na linha" + i.ToString());
                                //MessageBox.Show("Está na coluna" + j.ToString());
                                //MessageBox.Show(copiar_dados[j, i].ToString());
                                //PAREI AQUI!!! TEM QUE PARAR QUANDO LINHA = N. ROTAS + 1
                                //MessageBox.Show(copiar_dados[i, j].ToString());
                                copiar_dados[i, j] = dgvRota.Rows[i].Cells[j].Value.ToString();
                                //MessageBox.Show(copiar_dados[i, j].ToString());
                            }
                            catch (FormatException)
                            {
                                //break;
                            }
                        }
                        i++;
                        if (i.ToString().Equals(tbNrotas.Text))
                        {
                            //MessageBox.Show("passou no if");
                            break;
                        }
                        i--;
                    }
                }
                catch (FormatException)
                {
                }
                //int n_op_prov = Convert.ToInt16(tb_N_ops.Text);
                //n_op_prov++;
                //tb_N_ops.Text = n_op_prov.ToString();
                //insere_em_rotas_campo(); em vez disso será criado na ops direto
                form_op op_form = new form_op();
                //try
                //{
                    //op_form.n_op_peca = tb_N_ops.Text; 
                    //MessageBox.Show("Passou o n_op_peca");
                    op_form.tbNrotas_op = tbNrotas.Text;
                    op_form.copiar_dados_rota = copiar_dados;
                    op_form.desenho_variavel = cod_peca_desenhos.Text;
                    op_form.n_pdf_atual = tb_posicao.Text;
                    op_form.material_atual = material_des.Text;
                    op_form.espessura_atual = "";
                    op_form.Show();
                
                //}
                //finally
                //{
                //    op_form.Dispose();
                //    datOp.Fill(OP);
                //}
            //}
            /*else
                MessageBox.Show("Para criar uma nova OP você deve entrar em Ops - Adicionar - OP");*/
        }
        /*
        private void insere_em_rotas_campo()
        {
            string n_pdf_insert = tbN_pdf.Text;
            for (int k = 0; k < 100; k++)
            {
                int n_rotas_campo_prov = Convert.ToInt16(tbNum_rotas_campo.Text);
                n_rotas_campo_prov++;
                
                tbNum_rotas_campo.Text = n_rotas_campo_prov.ToString();
                this.datRotas_campo.InsertCommand.CommandText =
                "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, COD_ROTA_PECA, OPERACAO_CAMPO, DESENHO_CAMPO, POSICAO_FILA_CAMPO, OBSERVACAO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
                "VALUES ('" + tbNum_rotas_campo.Text + "','" + "*" + tbNum_rotas_campo.Text + "*" + "','" + copiar_dados[k, 1].ToString() + "','" + copiar_dados[k, 2].ToString() + "','" + copiar_dados[k, 3].ToString() + "','" + copiar_dados[k, 4].ToString() + "','" + n_pdf_insert + "','" + tb_N_ops.Text + "','0')";
                this.fbConnection2.Open();
                this.datRotas_campo.InsertCommand.Connection = fbConnection2;
                this.datRotas_campo.InsertCommand.ExecuteNonQuery();
                this.fbConnection2.Close();
                //MessageBox.Show("Record inserted Successfully");
                k++;
                if (k.ToString().Equals(tbNrotas.Text))
                {
                    //MessageBox.Show("passou no if");
                    break;
                }
                k--;
            }
            return;
            
        }
         
        */

        private void dgvOp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_op op_form = new form_op();
            //try
            //{
                //op_form.n_op_peca = tbNrotas.Text;
                //op_form.material_atual = material_des.Text;
                //MessageBox.Show("Passou o n_op_peca");
                op_form.cod_op_atual_variavel = dgvOp.Rows[e.RowIndex].Cells["cod_op_coluna"].Value;
                op_form.Show();
            //}
            //finally
            //{
            //    op_form.Dispose();
                
            //    dgvOp.AutoGenerateColumns = false;
            //    dgvOp.DataSource = dsOp.Tables["OP"];
            //    dsOp.Clear();
             //   datOp.Fill(OP);
            //}
            
        }

        private void dgvRota_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
            contarotas(tbNrotas.Text);
        }

        private void dgvRota_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            deleta_rotas(tbNrotas.Text);
        }

        private void dgvOp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsDesenhos, "DESENHOS"].Position = 100000000;
        }

        private void fbConnection2_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {

        }

        private void cod_peca_desenhos_DoubleClick(object sender, EventArgs e)
        {
            form_localiza_peca abre_peca = new form_localiza_peca();
            try
            {
                abre_peca.ShowDialog();
            }
            finally
            {
                abre_peca.Dispose();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verifica_sub();
        }

        private void bt_copiar_rota_Click(object sender, EventArgs e)
        {
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\COPIAR_ROTA.TXT");
            try
            {
                n_rotas_copiadas = Convert.ToInt32(tbNrotas.Text);
                using (StreamWriter texto = t.CreateText())
                {

                    for (int i = 0; i < 100; i++)
                    {
                        try
                        {


                            texto.WriteLine(dgvRota.Rows[i].Cells["col_operacao"].Value.ToString());

                            copiar_rota[i] = dgvRota.Rows[i].Cells["col_operacao"].Value.ToString();

                        }
                        catch (FormatException)
                        {

                        }

                        i++;
                        if (i.ToString().Equals(tbNrotas.Text))
                        {
                            break;
                        }
                        i--;
                    }
                }
            }
            catch (FormatException)
            {
            }
        }

        private void bt_colar_rota_Click(object sender, EventArgs e)
        {
            StreamReader objReader = new StreamReader("c:\\evolucao_dokinos\\COPIAR_ROTA.TXT");
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();

            foreach (string sOutput in arrText)
            {

                    this.datRotas_peca.InsertCommand.CommandText =
                        "INSERT INTO ROTAS_PECA (OPERACAO, DESENHO)" +
                          "VALUES ('" + sOutput + "', '" + cod_peca_desenhos.Text + "')";
                    this.fbConnection2.Open();
                    this.datRotas_peca.InsertCommand.Connection = fbConnection2;
                    this.datRotas_peca.InsertCommand.ExecuteNonQuery();
                    this.fbConnection2.Close();
                    dsRotas_peca.Clear();
                    this.datRotas_peca.SelectCommand.CommandText =
                        "SELECT * FROM ROTAS_PECA WHERE DESENHO LIKE '" + cod_peca_desenhos.Text + "'";
                    this.fbConnection2.Open();
                    this.datRotas_peca.SelectCommand.Connection = fbConnection2;
                    this.datRotas_peca.SelectCommand.ExecuteNonQuery();
                    datRotas_peca.Fill(ROTAS_PECA);
                    this.fbConnection2.Close();
                    contarotas(tbNrotas.Text);
                    
                    
                    
            }

        }

        private void btEletrodo_Click(object sender, EventArgs e)
        {
            form_op op_form = new form_op();
           // try
            //{
                //op_form.n_op_peca = tb_N_ops.Text; 
                //MessageBox.Show("Passou o n_op_peca");
                op_form.tbNrotas_op = tbNrotas.Text;
                //op_form.copiar_dados_rota = copiar_dados;
                op_form.desenho_variavel = cod_peca_desenhos.Text;
                op_form.n_pdf_atual = tb_posicao.Text;
                op_form.material_atual = material_des.Text;
                op_form.espessura_atual = "";
                op_form.eletrodo = true;
                op_form.Show();
            //}
            //finally
            //{
            //    op_form.Dispose();
           //     datOp.Fill(OP);
           // }
        }

        private void dgvRota_RowValidating_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (cod_peca_desenhos.Text != "")
                dgvRota.Rows[e.RowIndex].Cells["desenho_coluna"].Value = cod_peca_desenhos.Text;
        }

        private void dgvRota_UserAddedRow_1(object sender, DataGridViewRowEventArgs e)
        {
            contarotas(tbNrotas.Text);
        }

        private void dgvRota_UserDeletedRow_1(object sender, DataGridViewRowEventArgs e)
        {
            deleta_rotas(tbNrotas.Text);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            form_localiza_operacao abre = new form_localiza_operacao();
            try
            {
                //this.Close();
                abre.ShowDialog();

            }
            finally
            {
                abre.Dispose();
                try
                {
                    operacao_atual = abre.operacao_escolhida;
                    this.datRotas_peca.InsertCommand.CommandText =
                    "INSERT INTO ROTAS_PECA (OPERACAO, DESENHO)" +
                      "VALUES ('" + operacao_atual + "', '" + cod_peca_desenhos.Text + "')";
                    this.fbConnection2.Open();
                    this.datRotas_peca.InsertCommand.Connection = fbConnection2;
                    this.datRotas_peca.InsertCommand.ExecuteNonQuery();
                    this.fbConnection2.Close();
                    dsRotas_peca.Clear();
                    this.datRotas_peca.SelectCommand.CommandText =
                        "SELECT * FROM ROTAS_PECA WHERE DESENHO LIKE '" + cod_peca_desenhos.Text + "'";
                    this.fbConnection2.Open();
                    this.datRotas_peca.SelectCommand.Connection = fbConnection2;
                    this.datRotas_peca.SelectCommand.ExecuteNonQuery();
                    datRotas_peca.Fill(ROTAS_PECA);
                    this.fbConnection2.Close();
                    contarotas(tbNrotas.Text);

                }
                catch
                {
                    MessageBox.Show("Erro na inserção de operação");
                }
                


            }
        }

        
    }
}