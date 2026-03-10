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
    public partial class form_op : Form
    {
        string cod_rota_desenho;
        double horas_previstas_contra_prova;
        bool erro_horas;
        public string[] copiar_rota = new string[50];
        string data_ent_prev;
        string data_fech_prev;
        public string desenho_variavel;
        public object cod_op_atual_variavel;
        public string n_pdf_atual;
        public string n_op_peca;
        public string material_atual;
        public string espessura_atual;
        public string[,] copiar_dados_rota = new string[50, 5];
        public string tbNrotas_op;
        public bool eletrodo;
        public string operacao_atual;
        //SEMANAS
        int numero_dias;
        int ano_atual;
        int numero_semanas;
        double horas_semana;
        double horas_acumuladas;
        int semana_ano;
        int ult_semana_ano;
        string operacao_semana;
        int rota_semana;
        int semana_atual;
        int ano;
        string rota_atual;
        string data_ini;
        string data_fim;

        public form_op()
        {
            InitializeComponent();
        }

        
        private void Atualizar()
        {
            this.BindingContext[dsOp, "OP"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsOp.HasChanges())
            {
                
                //MessageBox.Show("CHEGOU NO ATUALIZAR das ops");
                datOp.UpdateCommand = cbOp.GetUpdateCommand(); 
                datOp.InsertCommand = cbOp.GetInsertCommand();
                datOp.DeleteCommand = cbOp.GetDeleteCommand();
                datOp.Update(dsOp, "OP");
                dsOp.AcceptChanges();
                
            }
            //fbConnection1.Close();
            //dgvRotas_campo.Rows[0].Cells["op_rotas_coluna"].Value = tb_codigo_op.Text;
            this.BindingContext[dsRotas_campo, "ROTAS_CAMPO"].EndCurrentEdit();
            //fbConnection1.Open();
            if (dsRotas_campo.HasChanges())
            {

                //MessageBox.Show("CHEGOU NO ATUALIZAR do rotas");
                datRotas_campo.UpdateCommand = cbRotas_campo.GetUpdateCommand();
                datRotas_campo.InsertCommand = cbRotas_campo.GetInsertCommand();
                datRotas_campo.DeleteCommand = cbRotas_campo.GetDeleteCommand();
                datRotas_campo.Update(dsRotas_campo, "ROTAS_CAMPO");
                dsRotas_campo.AcceptChanges();

            }
            fbConnection1.Close();

            this.BindingContext[dsDesenhos, "DESENHOS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsDesenhos.HasChanges())
            {

                //MessageBox.Show("CHEGOU NO ATUALIZAR do rotas");
                datDesenhos.UpdateCommand = cbDesenhos.GetUpdateCommand();
                datDesenhos.InsertCommand = cbDesenhos.GetInsertCommand();
                datDesenhos.DeleteCommand = cbDesenhos.GetDeleteCommand();
                datDesenhos.Update(dsDesenhos, "DESENHOS");
                dsDesenhos.AcceptChanges();

            }
            fbConnection1.Close();

            this.BindingContext[dsAgenda_os, "AGENDA_OS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsAgenda_os.HasChanges())
            {

                //MessageBox.Show("CHEGOU NO ATUALIZAR do rotas");
                datAgenda_os.UpdateCommand = cbAgenda_os.GetUpdateCommand();
                datAgenda_os.InsertCommand = cbAgenda_os.GetInsertCommand();
                datAgenda_os.DeleteCommand = cbAgenda_os.GetDeleteCommand();
                datAgenda_os.Update(dsAgenda_os, "AGENDA_OS");
                dsAgenda_os.AcceptChanges();

            }
            fbConnection1.Close();
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOp, "OP"].Position++;
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOp, "OP"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOp, "OP"].Position--;
        }

        private void entrega_dia_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_op_Load(object sender, EventArgs e)
        {
            
            
            //MessageBox.Show("chegou no load");
            //se for uma op já existente

        }
        private void abre_pos(string cod_op_atual_variavel2)
        {
            //if (cod_op_atual_variavel != null)
            //{
                int qualquer_op = Convert.ToInt16(cod_op_atual_variavel2);
                this.datOp.SelectCommand.CommandText =
                "SELECT * FROM OP WHERE COD_OP = '" + qualquer_op.ToString() + "'";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                datOp.Fill(OP);
                this.fbConnection1.Close();
                //pois o indice começa com zero
                //qualquer_op--;
                //MessageBox.Show("op usada");
                //datRotas_campo.Fill(ROTAS_CAMPO);
                //MessageBox.Show(qualquer_op.ToString());
                //data_pdf_text.Focus();
                //this.BindingContext[dsOp, "OP"].Position = qualquer_op;
                //data_pdf_text.Focus();
                

                dgvRotas_campo.AutoGenerateColumns = false;
                dgvRotas_campo.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
                this.datRotas_campo.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
                this.fbConnection1.Open();
                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();
                //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like'" + tb_codigo_op.Text + "'";
                //tb_desenho.Text = desenho_variavel;
                //insere_op_rota();
           // }
        }
            //se for uma op nova
        private void criar_pos(string desenho_variavel2, string n_pdf_atual2, string material_atual2)
        {
            if (cbEletrodo.Checked == true)
            {
                //datOp.Fill(OP);
                //this.BindingContext[dsOp, "OP"].AddNew();
                this.datOp.InsertCommand.CommandText =
                "INSERT INTO OP (DESENHO_OP_ATUAL, N_PDF)" +
                "VALUES ('" + desenho_variavel2 + "','ELETRODOS')";
                this.fbConnection1.Open();
                this.datOp.InsertCommand.Connection = fbConnection1;
                this.datOp.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datOp.SelectCommand.CommandText =
                "SELECT * FROM OP WHERE N_PDF = 'ELETRODOS' AND DESENHO_OP_ATUAL = '" + desenho_variavel2 + "'";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                datOp.Fill(OP);
                this.fbConnection1.Close();
                //tb_codigo_op.Text = n_op_peca; 
                tb_peca.Text = desenho_variavel2;
                tb_posicao.Text = "ELETRODOS";
                //tb_n_pdf.Text = "ELETRODOS";
                //tb_material.Text = material_atual2;
                //tb_espessura.Text = espessura_atual;
                tb_obs.Text = "ELETRODOS";
                insere_eletrodos();
                //datRotas_campo.Fill(ROTAS_CAMPO);
                dgvRotas_campo.AutoGenerateColumns = false;
                dgvRotas_campo.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
                this.datRotas_campo.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
                this.fbConnection1.Open();
                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();
                //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like'" + tb_codigo_op.Text + "'";
            }
            else
            {
                if (cbProjeto.Checked == true)
                {
                    //datOp.Fill(OP);
                    //this.BindingContext[dsOp, "OP"].AddNew();
                    this.datOp.InsertCommand.CommandText =
                    "INSERT INTO OP (DESENHO_OP_ATUAL, N_PDF)" +
                    "VALUES ('" + desenho_variavel2 + "','PROJETO')";
                    this.fbConnection1.Open();
                    this.datOp.InsertCommand.Connection = fbConnection1;
                    this.datOp.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datOp.SelectCommand.CommandText =
                    "SELECT * FROM OP WHERE N_PDF = 'PROJETO' AND DESENHO_OP_ATUAL = '" + desenho_variavel2 + "'";
                    this.fbConnection1.Open();
                    this.datOp.SelectCommand.Connection = fbConnection1;
                    this.datOp.SelectCommand.ExecuteNonQuery();
                    datOp.Fill(OP);
                    this.fbConnection1.Close();
                    //tb_codigo_op.Text = n_op_peca; 
                    tb_peca.Text = desenho_variavel2;
                    tb_posicao.Text = "PROJETO";
                    //tb_n_pdf.Text = "ELETRODOS";
                    //tb_material.Text = material_atual2;
                    //tb_espessura.Text = espessura_atual;
                    tb_obs.Text = "PROJETO";
                    insere_projeto();
                    //datRotas_campo.Fill(ROTAS_CAMPO);
                    dgvRotas_campo.AutoGenerateColumns = false;
                    dgvRotas_campo.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
                    this.datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
                    this.fbConnection1.Open();
                    this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                    this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                    datRotas_campo.Fill(ROTAS_CAMPO);
                    this.fbConnection1.Close();
                    //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like'" + tb_codigo_op.Text + "'";
                }
                else
                {
                    if (cbPortaMolde.Checked == true)
                    {
                        //datOp.Fill(OP);
                        //this.BindingContext[dsOp, "OP"].AddNew();
                        this.datOp.InsertCommand.CommandText =
                        "INSERT INTO OP (DESENHO_OP_ATUAL, N_PDF)" +
                        "VALUES ('" + desenho_variavel2 + "','PORTA MOLDE')";
                        this.fbConnection1.Open();
                        this.datOp.InsertCommand.Connection = fbConnection1;
                        this.datOp.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datOp.SelectCommand.CommandText =
                        "SELECT * FROM OP WHERE N_PDF = 'PORTA MOLDE' AND DESENHO_OP_ATUAL = '" + desenho_variavel2 + "'";
                        this.fbConnection1.Open();
                        this.datOp.SelectCommand.Connection = fbConnection1;
                        this.datOp.SelectCommand.ExecuteNonQuery();
                        datOp.Fill(OP);
                        this.fbConnection1.Close();
                        //tb_codigo_op.Text = n_op_peca; 
                        tb_peca.Text = desenho_variavel2;
                        tb_posicao.Text = "PORTA MOLDE";
                        //tb_n_pdf.Text = "ELETRODOS";
                        //tb_material.Text = material_atual2;
                        //tb_espessura.Text = espessura_atual;
                        tb_obs.Text = "PORTA MOLDE";
                        insere_porta_molde();
                        //datRotas_campo.Fill(ROTAS_CAMPO);
                        dgvRotas_campo.AutoGenerateColumns = false;
                        dgvRotas_campo.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
                        this.datRotas_campo.SelectCommand.CommandText =
                        "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
                        this.fbConnection1.Open();
                        this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                        this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                        datRotas_campo.Fill(ROTAS_CAMPO);
                        this.fbConnection1.Close();
                        //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like'" + tb_codigo_op.Text + "'";
                    }



                    else
                    {
                        this.datOp.InsertCommand.CommandText =
                        "INSERT INTO OP (DESENHO_OP_ATUAL, N_PDF)" +
                        "VALUES ('" + desenho_variavel2 + "','" + n_pdf_atual2 + "')";
                        this.fbConnection1.Open();
                        this.datOp.InsertCommand.Connection = fbConnection1;
                        this.datOp.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datOp.SelectCommand.CommandText =
                        "SELECT * FROM OP WHERE N_PDF = '" + n_pdf_atual2 + "' AND DESENHO_OP_ATUAL = '" + desenho_variavel2 + "'";
                        this.fbConnection1.Open();
                        this.datOp.SelectCommand.Connection = fbConnection1;
                        this.datOp.SelectCommand.ExecuteNonQuery();
                        datOp.Fill(OP);
                        this.fbConnection1.Close();
                        //datOp.Fill(OP);
                        //this.BindingContext[dsOp, "OP"].AddNew();
                        //tb_codigo_op.Text = n_op_peca; 
                        //tb_peca.Text = desenho_variavel;
                        //tb_posicao.Text = n_pdf_atual;
                        //tb_n_pdf.Text = n_pdf_atual;
                        //tb_material.Text = material_atual;
                        //tb_espessura.Text = espessura_atual;

                        //insere_em_rotas_campo();


                        //datRotas_campo.Fill(ROTAS_CAMPO);
                        dgvRotas_campo.AutoGenerateColumns = false;
                        dgvRotas_campo.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
                        //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like'" + tb_codigo_op.Text + "'";
                        this.datRotas_campo.SelectCommand.CommandText =
                        "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
                        this.fbConnection1.Open();
                        this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                        this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                        datRotas_campo.Fill(ROTAS_CAMPO);
                        this.fbConnection1.Close();

                    }
                }
            }
            //datRotas_campo.Fill(ROTAS_CAMPO);

            //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "n_pdf_campo Like '" + tb_n_pdf.Text + "'";
            //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "desenho_campo Like '" + tb_peca.Text + "'";
            //insere_op_rota();

            //Atualizar();
            dgvRotas_campo.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }
            
            //DataGridView1.ClipboardCopyMode = 
    //DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

        private void insere_porta_molde()
        {
            //int n_rotas_campo_prov = Convert.ToInt16(tbNum_rotas_campo.Text);
            //n_rotas_campo_prov++;
            int zero = 0;
            //ajuste e montagem
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','AJUSTE E MONTAGEM','" + tb_peca.Text + "','" + tb_posicao.Text + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'AJUSTE E MONTAGEM' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'AJUSTE E MONTAGEM' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //ajuste e montagem adicionais
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','AJUSTE E MONTAGEM ADICIONAIS','" + tb_peca.Text + "','" + tb_posicao.Text + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'AJUSTE E MONTAGEM ADICIONAIS' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'AJUSTE E MONTAGEM ADICIONAIS' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //1º Try - out
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','1º TRY OUT','" + tb_peca.Text + "','" + tb_posicao.Text + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = '1º TRY OUT' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = '1º TRY OUT' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //Relatório Dimensional
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','RELATORIO DIMENSIONAL','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'RELATORIO DIMENSIONAL' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'RELATORIO DIMENSIONAL' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //Correções nas Cotas Reprov.
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','CORR. COTAS REPR.','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'CORR. COTAS REPR.' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'CORR. COTAS REPR.' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //2º TRY OUT
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','2º TRY OUT','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = '2º TRY OUT' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = '2º TRY OUT' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //3º TRY OUT
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','3º TRY OUT','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = '3º TRY OUT' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = '3º TRY OUT' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //Relatório Dimensional
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','RELATORIO DIMENSIONAL','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'RELATORIO DIMENSIONAL' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'RELATORIO DIMENSIONAL' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //ENTREGA DO FERRAMENTAL
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','ENTREGA DO FERRAMENTAL','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'ENTREGA DO FERRAMENTAL' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'ENTREGA DO FERRAMENTAL' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //AJUSTE RETIFICA
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','AJUSTE RETIFICA','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'AJUSTE RETIFICA' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'AJUSTE RETIFICA' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }


        private void insere_projeto()
        {
            //int n_rotas_campo_prov = Convert.ToInt16(tbNum_rotas_campo.Text);
            //n_rotas_campo_prov++;
            int zero = 0;
            //PRÉ PROJETO
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','PRE-PROJETO','" + tb_peca.Text + "','" + tb_posicao.Text + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'PRE-PROJETO' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'PRE-PROJETO' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //MODELAMENTO
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','MODELAMENTO','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'MODELAMENTO' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'MODELAMENTO' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //Compra de Material
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','COMPRA DE MATERIAL','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'COMPRA DE MATERIAL' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'COMPRA DE MATERIAL' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //Detalhamento/Principal
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','DETALHAMENTO/PRINCIPAL','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'DETALHAMENTO/PRINCIPAL' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'DETALHAMENTO/PRINCIPAL' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //PROJETO COMPLETO
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','PROJETO COMPLETO','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'PROJETO COMPLETO' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'PROJETO COMPLETO' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //REVISÃO DO PROJETO
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','REVISÃO DO PROJETO','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'REVISÃO DO PROJETO' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'REVISÃO DO PROJETO' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

        }


        
        private void insere_eletrodos()
        {
            //int n_rotas_campo_prov = Convert.ToInt16(tbNum_rotas_campo.Text);
            //n_rotas_campo_prov++;
            int zero = 0;
            //ELETRODO EROSAO
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','ELETRODO EROSÃO','" + tb_peca.Text + "','" + tb_posicao.Text + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'ELETRODO EROSÃO' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'ELETRODO EROSÃO' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //ELETRODO CNC
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','ELETRODO CNC','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'ELETRODO CNC' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'ELETRODO CNC' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //ELETRODO CNC RAS
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','ELETRODO CNC RAS','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'ELETRODO CNC RAS' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'ELETRODO CNC RAS' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //ADICIONAIS EROSÃO
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','ADICIONAIS EROSÃO','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'ADICIONAIS EROSÃO' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'ADICIONAIS EROSÃO' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            //ADICIONAIS CNC
            this.datRotas_campo.InsertCommand.CommandText =
            "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
            "VALUES ('*','ADICIONAIS CNC','" + tb_peca.Text + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "','" + zero.ToString() + "')";
            this.fbConnection1.Open();
            this.datRotas_campo.InsertCommand.Connection = fbConnection1;
            this.datRotas_campo.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //MessageBox.Show("chegou aqui");
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = 'ADICIONAIS CNC' AND RETRABALHO_ROTA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            this.datRotas_campo.UpdateCommand.CommandText =
            "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = 'ADICIONAIS CNC' AND COD_ROTA_PECA IS NULL";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();


        }



        private void insere_em_rotas_campo()
        {
            //string n_pdf_insert = tbN_pdf.Text;
            for (int k = 0; k < 100; k++)
            {
                
                int zero = 0;
                this.datRotas_campo.InsertCommand.CommandText =
                "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, POSICAO_FILA_CAMPO, OBSERVACAO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_MAQUINA_RODANDO, HORAS_PARADAS)" +
                "VALUES ('*','" + copiar_dados_rota[k, 1].ToString() + "','" + copiar_dados_rota[k, 2].ToString() + "','" + copiar_dados_rota[k, 3].ToString() + "','" + copiar_dados_rota[k, 4].ToString() + "','" + n_pdf_atual + "','" + tb_codigo_op.Text + "', 0, '" + zero.ToString() + "')";
                this.fbConnection1.Open();
                this.datRotas_campo.InsertCommand.Connection = fbConnection1;
                this.datRotas_campo.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = '" + copiar_dados_rota[k, 1].ToString() + "' AND RETRABALHO_ROTA IS NULL";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                
                this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = '" + copiar_dados_rota[k, 1].ToString() + "' AND COD_ROTA_PECA IS NULL";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                
                k++;
                if (k.ToString().Equals(tbNrotas_op))
                {
                    break;
                }
                k--;
            }
            return;

        }

        private void insere_op_rota()
        {
            for (int i = 0; i < Convert.ToInt16(n_op_peca); i++)
            {
                
                dgvRotas_campo.Rows[i].Cells["op_rotas_coluna"].Value = tb_codigo_op.Text;
            }
        }


        private void salva_registro_Click_1(object sender, EventArgs e)
        {
            /*if (dgvRotas_campo.Rows[0].Cells["op_rotas_coluna"].Value == null)
            {
                dgvRotas_campo.Rows[0].Cells["op_rotas_coluna"].Value = tb_codigo_op.Text;
                MessageBox.Show("passou pelo if");
            }
            MessageBox.Show(dgvRotas_campo.Rows[0].Cells["op_rotas_coluna"].Value.ToString());
            */
            Atualizar();

            update_rotas();
            for (int j = 0; j < dgvRotas_campo.RowCount; j++)
            {
                update_semana(dgvRotas_campo.Rows[j].Cells["col_cod"].Value.ToString(), j);
            }
        }

        private void update_rotas()
        {
            this.datRotas_campo.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET N_PDF_CAMPO = '" + tb_posicao.Text + "' WHERE OP_ROTA = '" + tb_codigo_op.Text + "'";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datRotas_campo.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET FUNCAO_ROTA = '" + tb_funcao.Text + "' WHERE OP_ROTA = '" + tb_codigo_op.Text + "'";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            try
            {
                this.datRotas_campo.UpdateCommand.CommandText =
                        "UPDATE ROTAS_CAMPO SET QTDE_ROTA = '" + tb_qtde.Text + "' WHERE OP_ROTA = '" + tb_codigo_op.Text + "'";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch {
                fbConnection1.Close();
            }
        }

        private void update_semana(string rota, int i)
        {
            this.datHoras_semana.UpdateCommand.CommandText =
                    "UPDATE HORAS_SEMANA SET POSICAO_OS_SEMANA = '" + tb_posicao.Text + "' WHERE ROTA_HORAS_SEMANA = '" + rota + "'";
            this.fbConnection1.Open();
            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            /*
            try
            {
                this.datHoras_semana.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET HORAS_OPERACAO_SEMANA = '" + dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString() + "' WHERE ROTA_HORAS_SEMANA = '" + rota + "'";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch {
                fbConnection1.Close();
            }
             * */
            

        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOp, "OP"].AddNew();
        }

        private void form_op_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Atualizar();
        }

        private void tb_n_pdf_TextChanged(object sender, EventArgs e)
        {
            //dsRotas_peca.Tables["ROTAS_PECA"].DefaultView.RowFilter = "desenho Like '" + cod_peca_desenhos.Text + "'";
              //  MessageBox.Show("passou pelo filter do pdf");
                //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "n_pdf_campo Like '" + tb_n_pdf.Text + "'";
                
            
           
        }

       

        private void tb_peca_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("passou pelo filter da peça");
           // dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "desenho_campo Like '" + tb_peca.Text + "'";
            
        }

        

        private void dgvRotas_campo_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //dgvRotas_campo.Rows[e.RowIndex].Cells["peca_coluna"].Value = tb_peca.Text;
            //dgvRotas_campo.Rows[e.RowIndex].Cells["n_pdf_coluna"].Value = tb_n_pdf.Text;
        }

        private void dgvRotas_campo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //dgvRotas_campo.Rows[e.RowIndex].Cells["peca_coluna"].Value = tb_peca.Text;
            //dgvRotas_campo.Rows[e.RowIndex].Cells["n_pdf_coluna"].Value = tb_n_pdf.Text;
        }

        private void tb_codigo_op_TextChanged(object sender, EventArgs e)
        {
            //int op_variavel = Convert.ToInt16(tb_codigo_op.Text);
            //
            
            dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like '" + tb_codigo_op.Text + "'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.datOp.SelectCommand.CommandText =
                "SELECT * FROM OP WHERE COD_OP = '" + tb_codigo_op.Text + "'";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                if (tb_posicao.Text == "PORTA MOLDE")
                {
                    this.datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OPERACAO_CAMPO LIKE 'AJUSTE %' AND OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_NUM_ROTAS = '*' ORDER BY COD_ROTA_CAMPO";
                    this.fbConnection1.Open();
                    this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                    this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                else
                {
                    this.datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_NUM_ROTAS = '*' ORDER BY COD_ROTA_CAMPO";
                    this.fbConnection1.Open();
                    this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                    this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                dsConsulta imprime_op = new dsConsulta();
                fbConnection1.Open();
                //datTabela_impressao.Fill(dsRelatorio.TABELA_IMPRESSAO);
                datRotas_campo.Fill(imprime_op.ROTAS_CAMPO);
                datOp.Fill(imprime_op.OP);
                //datOperadores.Fill(dsRelatorio.OPERADORES);
                //datParadas.Fill(dsRelatorio.PARADAS);
                fbConnection1.Close();
                crNova_op op_nova = new crNova_op();
                op_nova.SetDataSource(imprime_op);
                op_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                op_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(op_nova);
                imprimir.Show();

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro na impressão");
            }
            /*
            form_crOp rpt = new form_crOp();
            string var_op = tb_codigo_op.Text;
            rpt.print_op = Convert.ToInt16(var_op);
            rpt.ShowDialog();*/
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOp, "OP"].Position = 10000000;
        }

        private void dgvRotas_campo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            form_rotas abre_rota = new form_rotas();
            try
            {
                abre_rota.rota_atual = dgvRotas_campo.Rows[e.RowIndex].Cells[0].Value;
                abre_rota.ShowDialog();
            }
            finally
            {
                abre_rota.Dispose();
                datRotas_campo.Fill(ROTAS_CAMPO);
            }
        }

        private void datRotas_campo_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {

        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {

            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {


                        for (int i = 0; i < dgvRotas_campo.RowCount; i++)
                        {
                            this.datHoras_semana.UpdateCommand.CommandText =
                            "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE ROTA_HORAS_SEMANA = '" + dgvRotas_campo.Rows[i].Cells["col_cod"].Value.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                            this.fbConnection1.Open();
                            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();

                            this.datHoras_semana.UpdateCommand.CommandText =
                            "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'OP 3' WHERE ROTA_HORAS_SEMANA = '" + dgvRotas_campo.Rows[i].Cells["col_cod"].Value.ToString() + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                            this.fbConnection1.Open();
                            this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                            this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();
                            /*
                            this.datHoras_semana.DeleteCommand.CommandText =
                            "DELETE FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + dgvRotas_campo.Rows[i].Cells["col_cod"].Value.ToString() + "'";
                            this.fbConnection1.Open();
                            this.datHoras_semana.DeleteCommand.Connection = fbConnection1;
                            this.datHoras_semana.DeleteCommand.ExecuteNonQuery();
                            this.fbConnection1.Close();
                             * */
                        }

                        this.datRotas_campo.DeleteCommand.CommandText =
                            "DELETE FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "'";
                        this.fbConnection1.Open();
                        this.datRotas_campo.DeleteCommand.Connection = fbConnection1;
                        this.datRotas_campo.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datOp.DeleteCommand.CommandText =
                            "DELETE FROM OP WHERE COD_OP = '" + tb_codigo_op.Text + "'";
                        this.fbConnection1.Open();
                        this.datOp.DeleteCommand.Connection = fbConnection1;
                        this.datOp.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();


                        //Atualizar();
                        dsOp.Clear();
                        dsRotas_campo.Clear();
                        dsHoras_semana.Clear();
                        datOp.Fill(OP);
                        datRotas_campo.Fill(ROTAS_CAMPO);
                    }
                    catch
                    {
                        MessageBox.Show("Erro na exclusão");
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }


        }

        private void dgvRotas_campo_Enter(object sender, EventArgs e)
        {

        }

        private void dgvRotas_campo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRotas_campo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRotas_campo_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                    int zero = 0;
                    int qtde = 0;
                    try
                    {
                        qtde = Convert.ToInt32(tb_qtde.Text);
                    }
                    catch
                    {
                        qtde = 1;
                    }
                    this.datRotas_campo.InsertCommand.CommandText =
                    "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, FUNCAO_ROTA, HORAS_PARADAS, QTDE_ROTA)" +
                    "VALUES ('*','" + operacao_atual + "','" + tb_peca.Text + "','" + tb_posicao.Text + "','" + tb_codigo_op.Text + "','" + tb_funcao.Text + "','" + zero.ToString() + "','" + qtde.ToString() + "')";
                    this.fbConnection1.Open();
                    this.datRotas_campo.InsertCommand.Connection = fbConnection1;
                    this.datRotas_campo.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    this.datRotas_campo.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = '" + operacao_atual + "' AND RETRABALHO_ROTA IS NULL";
                    this.fbConnection1.Open();
                    this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                    this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    
                    this.datRotas_campo.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = '" + operacao_atual + "' AND COD_ROTA_PECA IS NULL";
                    this.fbConnection1.Open();
                    this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                    this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsRotas_campo.Clear();

                    this.datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' ORDER BY COD_ROTA_CAMPO";
                    this.fbConnection1.Open();
                    this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                    this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                    datRotas_campo.Fill(ROTAS_CAMPO);
                    this.fbConnection1.Close();
                    //dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like'" + tb_codigo_op.Text + "'";
                }
                catch
                {
                    MessageBox.Show("Erro na inserção de operação");
                }
                


            }
        
        }

        private void dgvRotas_campo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Atualizar();
            if (dgvRotas_campo.Columns[e.ColumnIndex].Name == "Ok")
            {
                FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
                if (d.Exists == true)
                {
                    
                    if (dgvRotas_campo.Rows[e.RowIndex].Cells["col_sem"].Value.ToString() != "1")
                    {
                        try
                        {
                            if (dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_ENTRADA_PREV"].Value.ToString() != "")
                            {
                                rota_atual = dgvRotas_campo.Rows[e.RowIndex].Cells[0].Value.ToString();
                                excluir_semanas(rota_atual);
                                Atualizar();
                                int numero_dias;
                                numero_dias = contar_dias(Convert.ToDateTime(dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_ENTRADA_PREV"].Value),
                                       Convert.ToDateTime(dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_FECHAMENTO_PREV"].Value));

                                data_ent_prev = Convert.ToDateTime(dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_ENTRADA_PREV"].Value).ToShortDateString();
                                data_fech_prev = Convert.ToDateTime(dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_FECHAMENTO_PREV"].Value).ToShortDateString();
                                //MessageBox.Show("numero de dias " + numero_dias.ToString());
                                ano_atual = Convert.ToDateTime(dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_ENTRADA_PREV"].Value).Year;
                                semana_ano = 1 + conferir_semana(Convert.ToDateTime(dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_ENTRADA_PREV"].Value)) / 7;
                                ult_semana_ano = 1 + conferir_semana(Convert.ToDateTime(dgvRotas_campo.Rows[e.RowIndex].Cells["DATA_FECHAMENTO_PREV"].Value)) / 7;
                                /*
                                if (numero_dias % 7 == 0)
                                    numero_semanas = numero_dias / 7;
                                else
                                    numero_semanas = (numero_dias / 7) + 1;
                                */
                                numero_semanas = (ult_semana_ano - semana_ano) + 1;

                                if (numero_semanas < 0)
                                    numero_semanas = (53 - semana_ano) + ult_semana_ano;
                                if (dgvRotas_campo.Rows[e.RowIndex].Cells["col_horas_previstas"].Value.ToString() != "")
                                {
                                    horas_previstas_contra_prova = Convert.ToDouble(dgvRotas_campo.Rows[e.RowIndex].Cells["col_horas_previstas"].Value);
                                    horas_semana = Convert.ToDouble(dgvRotas_campo.Rows[e.RowIndex].Cells["col_horas_previstas"].Value) / numero_semanas;
                                }
                                else
                                {
                                    horas_semana = 0;
                                }


                                operacao_semana = dgvRotas_campo.Rows[e.RowIndex].Cells["col_operacao"].Value.ToString();
                                rota_semana = Convert.ToInt32(dgvRotas_campo.Rows[e.RowIndex].Cells["col_cod"].Value);
                                //buscar_horas_disponiveis(dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString());

                                semana_atual = semana_ano;
                                ano = ano_atual;
                                bool passou_ano = false;
                                for (int j = 0; j < numero_semanas; j++)
                                {
                                    if (semana_ano > 53 && ano != 2028 && j != 0 && passou_ano == false)
                                    {
                                        passou_ano = true;
                                        semana_ano = 2;
                                        ano = ano_atual + 1;
                                        if (ano == 2012 || ano == 2017 || ano == 2023 || ano == 2034 || ano == 2040 || ano == 2045 || ano == 2051)
                                            semana_ano = 1;
                                    }
                                    if (semana_ano > 54 && ano == 2028 && j != 0 && passou_ano == false)
                                    {
                                        passou_ano = true;
                                        semana_ano = 2;
                                        ano = ano + 1;

                                    }
                                    if (semana_ano == 1 && j == 0 && passou_ano == false)
                                    {
                                        if (ano != 2012 || ano != 2017 || ano != 2023 || ano != 2034 || ano != 2040 || ano != 2045 || ano != 2051)
                                        {
                                            passou_ano = true;
                                            semana_ano = 53;
                                            ano = ano_atual - 1;
                                        }
                                    }

                                    
                                    tb_semana.Text = semana_ano.ToString();
                                    string operacao_atual = "'" + label_operacao.Text + "'";
                                    if (label_operacao.Text == "CNC (Acab.)" || label_operacao.Text == "CNC (Desbaste)")
                                        operacao_atual = "'CNC (Acab.)' OR OPERACAO_SEMANA = 'CNC (Desbaste)'";
                                    //MessageBox.Show(operacao_atual);
                                    //verificar se deu certo com cnc
                                    //buscar_semana_operacao(operacao_atual, semana_ano, ano);
                                    inserir_nas_semanas(semana_ano, horas_semana, operacao_semana, rota_semana, numero_semanas, ano, tb_peca.Text, tb_posicao.Text);
                                    //verificar_horas_das_semanas(Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()), numero_semanas, i + 1);

                                    buscar_semana_operacao(operacao_atual, semana_ano, ano);
                                    semana_ano++;
                                }
                                if (erro_horas == true)
                                    MessageBox.Show("Erro na inserção");
                                else
                                {
                                    update_sem_rotas(dgvRotas_campo.Rows[e.RowIndex].Cells["col_cod"].Value.ToString());
                                }
                                erro_horas = false;
                            }
                            dsRotas_campo.Clear();
                            datRotas_campo.Fill(ROTAS_CAMPO);
                            //                buscar_semana_operacao(label_operacao.Text, semana_ano, numero_semanas, ano_atual);
                            //verificar_horas_das_semanas(Convert.ToDouble(dgvRotas_campo.Rows[e.RowIndex].Cells["col_horas_previstas"].Value.ToString()), numero_semanas);
                            //inserir_nas_semanas(semana_ano, horas_semana, operacao_semana, rota_semana, numero_semanas, ano_atual, tb_peca.Text, tb_posicao.Text); //falta fazer o inserir no banco, junto com o atualizar
                            //                buscar_semana_operacao(label_operacao.Text, semana_ano, numero_semanas, ano_atual);
                        }
                        catch
                        {
                            MessageBox.Show("Erro na linha " + e.RowIndex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Essa rota já foi inserida, para reinseri-la a coluna 'Sem' deve estar zerada");
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem acesso a esse recurso");
                }

            
            }


        }
        

        private void inserir()
        {
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                if (dgvRotas_campo.Rows[i].Cells["col_sem"].Value.ToString() != "1")
                {
                    try
                    {
                        if (dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value.ToString() != "")
                        {
                            rota_atual = dgvRotas_campo.Rows[i].Cells[0].Value.ToString();
                            excluir_semanas(rota_atual);
                            Atualizar();
                            int numero_dias;
                            numero_dias = contar_dias(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value),
                                   Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value));
                            
                            data_ent_prev = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value).ToShortDateString();
                            data_fech_prev = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value).ToShortDateString();
                            //MessageBox.Show("numero de dias " + numero_dias.ToString());
                            ano_atual = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value).Year;
                            semana_ano = 1 + conferir_semana(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value)) / 7;
                            ult_semana_ano = 1 + conferir_semana(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value)) / 7;
                            /*
                            if (numero_dias % 7 == 0)
                                numero_semanas = numero_dias / 7;
                            else
                                numero_semanas = (numero_dias / 7) + 1;
                            */
                            numero_semanas = (ult_semana_ano - semana_ano) + 1;

                            if (numero_semanas < 0)
                                numero_semanas = (53 - semana_ano) + ult_semana_ano;
                            if (dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString() != "")
                            {
                                horas_previstas_contra_prova = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value);
                                horas_semana = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value) / numero_semanas;
                            }
                            else
                            {
                                horas_semana = 0;
                            }


                            operacao_semana = dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString();
                            rota_semana = Convert.ToInt32(dgvRotas_campo.Rows[i].Cells["col_cod"].Value);
                            //buscar_horas_disponiveis(dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString());

                            semana_atual = semana_ano;
                            ano = ano_atual;
                            bool passou_ano = false;
                            for (int j = 0; j < numero_semanas; j++)
                            {
                                
                                if (semana_ano > 53 && ano != 2028 && j != 0 && passou_ano == false)
                                {
                                    passou_ano = true;
                                    semana_ano = 2;
                                    ano = ano_atual + 1;
                                    if (ano == 2012 || ano == 2017 || ano == 2023 || ano == 2034 || ano == 2040 || ano == 2045 || ano == 2051)
                                        semana_ano = 1;
                                }
                                if (semana_ano > 54 && ano == 2028 && j != 0 && passou_ano == false)
                                {
                                    passou_ano = true;
                                    semana_ano = 2;
                                    ano = ano + 1;

                                }
                                if (semana_ano == 1 && j == 0 && passou_ano == false)
                                {
                                    if (ano != 2012 || ano != 2017 || ano != 2023 || ano != 2034 || ano != 2040 || ano != 2045 || ano != 2051)
                                    {
                                        passou_ano = true;
                                        semana_ano = 53;
                                        ano = ano_atual - 1;
                                    }
                                }
                                tb_semana.Text = semana_ano.ToString();
                                string operacao_atual = "'" + label_operacao.Text + "'";
                                if (label_operacao.Text == "CNC (Acab.)" || label_operacao.Text == "CNC (Desbaste)")
                                    operacao_atual = "'CNC (Acab.)' OR OPERACAO_SEMANA = 'CNC (Desbaste)'";
                                //MessageBox.Show(operacao_atual);
                                //verificar se deu certo com cnc
                                //buscar_semana_operacao(operacao_atual, semana_ano, ano);
                                
                                inserir_nas_semanas(semana_ano, horas_semana, operacao_semana, rota_semana, numero_semanas, ano, tb_peca.Text, tb_posicao.Text);
                                //verificar_horas_das_semanas(Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()), numero_semanas, i + 1);

                                buscar_semana_operacao(operacao_atual, semana_ano, ano);
                                semana_ano++;
                            }
                        }
                        //                buscar_semana_operacao(label_operacao.Text, semana_ano, numero_semanas, ano_atual);
                        //verificar_horas_das_semanas(Convert.ToDouble(dgvRotas_campo.Rows[e.RowIndex].Cells["col_horas_previstas"].Value.ToString()), numero_semanas);
                        //inserir_nas_semanas(semana_ano, horas_semana, operacao_semana, rota_semana, numero_semanas, ano_atual, tb_peca.Text, tb_posicao.Text); //falta fazer o inserir no banco, junto com o atualizar
                        //                buscar_semana_operacao(label_operacao.Text, semana_ano, numero_semanas, ano_atual);
                        if (erro_horas == true)
                            MessageBox.Show("Erro na inserção");
                        else
                        {
                            update_sem_rotas(dgvRotas_campo.Rows[i].Cells["col_cod"].Value.ToString());
                        }
                        erro_horas = false;
                    }
                    catch
                    {
                        MessageBox.Show("Erro na linha " + i.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Essa rota já foi inserida, para reinseri-la a coluna Sem deve estar zerada");
                }

            }
            Atualizar();
            dsRotas_campo.Clear();
            datRotas_campo.Fill(ROTAS_CAMPO);
        }

        private void update_sem_rotas(string rota_atual)
        {
            this.datRotas_campo.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET INSERIDO_SEMANA = 1 WHERE COD_ROTA_CAMPO = '" + rota_atual + "'";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

        }

        private void verificar_horas_das_semanas(double horas_a_incluir, int num_semanas, int semana_atual)
        {
            /*
            // modo antigo confimando as semanas
            double total_horas_semana1 = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    if (dataGridView1.Rows[i].Cells["col_horas"].Value.ToString() != "0")
                    {
                        total_horas_semana1 = total_horas_semana1 + Convert.ToDouble(dataGridView1.Rows[i].Cells["col_horas"].Value);
                    }
                }
                catch 
                {
                    MessageBox.Show("Erro no total_horas_semana1");
                }
            }

            double horas_atualizadas = total_horas_semana1 + (horas_a_incluir/num_semanas);
           
            tb_horas_semana.Text = horas_atualizadas.ToString();

            try
            {
                if (horas_atualizadas > Convert.ToDouble(label_horas_disponiveis.Text))
                {
                    if (DialogResult.Yes == MessageBox.Show("Essa semana está com seu tempo cheio, tem certeza que quer continuar?",
                    "Tem certeza que quer continuar?", MessageBoxButtons.YesNo))
                    {
                        inserir_nas_semanas(semana_ano, horas_semana + horas_acumuladas, operacao_semana, rota_semana, numero_semanas, ano, tb_peca.Text, tb_posicao.Text);
                        horas_acumuladas = 0;

                    }
                    else
                    {
                        if (numero_semanas == semana_atual)
                        {
                            MessageBox.Show("Por favor, ajuste suas datas de início e fim pois não existem semanas diponíveis dentro de sua previsão");
                            //string rota_atual = dgvRotas_campo.Rows[e.RowIndex].Cells[0].Value.ToString();
                            excluir_semanas(rota_atual);
                        }
                        else
                        {
                            //MessageBox.Show(numero_semanas.ToString());
                            horas_acumuladas = horas_semana;
                            tb_horas_semana.Text = total_horas_semana1.ToString();
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("chegou");
                    inserir_nas_semanas(semana_ano, horas_semana + horas_acumuladas, operacao_semana, rota_semana, numero_semanas, ano, tb_peca.Text, tb_posicao.Text);
                    horas_acumuladas = 0;
                    //inserir_nas_semanas(semana_ano, horas_semana, operacao_semana, rota_semana, numero_semanas, ano_atual, tb_peca.Text, tb_posicao.Text);
                }
            }
            catch
            {
                MessageBox.Show("Erro na inserção, chame o responsável");
            }
                
            */
        }

        private void excluir_semanas(string rota)
        {
            
                this.datHoras_semana.UpdateCommand.CommandText =
                "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE ROTA_HORAS_SEMANA = '" + rota + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datHoras_semana.UpdateCommand.CommandText =
                "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'OP 1' WHERE ROTA_HORAS_SEMANA = '" + rota + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
           
            /*
            this.datHoras_semana.DeleteCommand.CommandText =
            "DELETE FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + rota + "'";
            this.fbConnection1.Open();
            this.datHoras_semana.DeleteCommand.Connection = fbConnection1;
            this.datHoras_semana.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            //buscar_semana_operacao(operacao_atual, semana_ano, ano);
            */

        }
        private void buscar_horas_disponiveis(string operacao)
        {
            dsTipos_operacoes.Clear();
            this.datTipos_operacoes.SelectCommand.CommandText =
            "SELECT * FROM TIPOS_OPERACOES WHERE TIPO = '" + operacao + "'" ;
            this.fbConnection1.Open();
            this.datTipos_operacoes.SelectCommand.Connection = fbConnection1;
            this.datTipos_operacoes.SelectCommand.ExecuteNonQuery();
            datTipos_operacoes.Fill(TIPOS_OPERACOES);
            this.fbConnection1.Close();

        }
        private void buscar_semana_operacao(string operacao, int semana, int ano_atual)
        {
            dsHoras_semana.Clear();
            this.datHoras_semana.SelectCommand.CommandText =
            "SELECT * FROM HORAS_SEMANA WHERE N_SEMANA = '" + semana.ToString() + "' AND (OPERACAO_SEMANA = " + operacao + ")" 
            + " AND ANO_SEMANA = '" + ano_atual.ToString() + "' ORDER BY OS_SEMANA";
            this.fbConnection1.Open();
            this.datHoras_semana.SelectCommand.Connection = fbConnection1;
            this.datHoras_semana.SelectCommand.ExecuteNonQuery();
            datHoras_semana.Fill(HORAS_SEMANA);
            this.fbConnection1.Close();
        }

        // falta fazer uma melhor formatação do datagrid
        // falta avançar as semanas

        private DateTime primeiro_dia_semana(int semana_ano)
        {
            DateTime data_inicio = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime data = data_inicio.AddDays(7 * (semana_ano - 1));
            while (data.DayOfWeek != DayOfWeek.Monday)
                data = data.AddDays(-1);

            return data;


        }

        private void inserir_nas_semanas(int semana, double horas, string operacao, int rota, int numero_sem, int ano_semana, string os_semana, string posicao_semana)
        {
            if (numero_sem > 1 && horas == horas_previstas_contra_prova && horas != 0)
                erro_horas = true;
            else
            {
                try
                {
                    //MessageBox.Show("horas " + horas.ToString("n2"));
                    this.datHoras_semana.InsertCommand.CommandText =
                        "INSERT INTO HORAS_SEMANA (N_SEMANA, DATA_INICIO_SEMANA, DATA_FIM_SEMANA, ANO_SEMANA, OPERACAO_SEMANA, ROTA_HORAS_SEMANA, HORAS_OPERACAO_SEMANA, OS_SEMANA, POSICAO_OS_SEMANA)" +
                            "VALUES ('" + semana.ToString() + "','" + data_ent_prev.Replace("/", ".") + "','" + data_fech_prev.Replace("/", ".") + "','" + ano_semana.ToString() + "','" + operacao + "','" + rota.ToString() + "','" + horas.ToString().Replace(",", ".") + "','" + os_semana + "','" + posicao_semana + "')";
                    this.fbConnection1.Open();
                    this.datHoras_semana.InsertCommand.Connection = fbConnection1;
                    this.datHoras_semana.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                    erro_horas = true;
                }
            }
           
            
        }

        
        private int conferir_semana(DateTime data_inicial)
        {
            DateTime primeiro_dia = new DateTime(data_inicial.Year, 1, 1);
            while (primeiro_dia.DayOfWeek != DayOfWeek.Monday)
                primeiro_dia = primeiro_dia.AddDays(-1);
            while (data_inicial.DayOfWeek != DayOfWeek.Monday)
                data_inicial = data_inicial.AddDays(-1);
            TimeSpan numero_dias = data_inicial.Subtract(primeiro_dia);
            //MessageBox.Show("numero de dias "+ numero_dias.TotalDays.ToString());
            int numero_semana = Convert.ToInt32(numero_dias.Days.ToString());
            return numero_semana;
        }
        private int contar_dias(DateTime ultimo, DateTime primeiro)
        {
            TimeSpan numero_dias = primeiro.Subtract(ultimo);
            return Convert.ToInt32(numero_dias.Days.ToString());
        }

        private void dgvRotas_campo_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                int anterior = Convert.ToInt32(tb_semana.Text);
                anterior--;
                tb_semana.Text = anterior.ToString();
            }
            catch
            {
                MessageBox.Show("Impossível fazer essa operação");
            }
            buscar_semana_operacao("'" + label_operacao.Text + "'", Convert.ToInt32(tb_semana.Text), ano_atual);
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            try
            {
                int proximo = Convert.ToInt32(tb_semana.Text);
                proximo++;
                tb_semana.Text = proximo.ToString();
            }
            catch
            {
                tb_semana.Text = "1";
            }
            buscar_semana_operacao("'" + label_operacao.Text + "'", Convert.ToInt32(tb_semana.Text), ano_atual);
        }

        private void dgvRotas_campo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = dgvRotas_campo.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = dgvRotas_campo.CurrentCell.RowIndex;
                int col = dgvRotas_campo.CurrentCell.ColumnIndex;
                foreach (string line in lines)
                {
                    if (row < dgvRotas_campo.RowCount && line.Length >
0)
                    {
                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                        {
                            if (col + i < this.dgvRotas_campo.ColumnCount)
                            {
                                //MessageBox.Show(Convert.ToString(Convert.ChangeType(cells[i], dgvRotas_campo[col + i, row].ValueType)));
                                try
                                {
                                    dgvRotas_campo[col + i, row].Value = Convert.ChangeType(cells[i], dgvRotas_campo[col + i, row].ValueType);
                                }
                                catch { }
                            }
                            else
                            {
                                break;
                            }
                        }
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir_os();
        }

        private void abrir_os()
        {
            string nova_os = tb_os.Text;
            dsDesenhos.Clear();
            this.datDesenhos.SelectCommand.CommandText =
                "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "'";
            this.fbConnection1.Open();
            this.datDesenhos.SelectCommand.Connection = fbConnection1;
            this.datDesenhos.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datDesenhos.Fill(DESENHOS);
            if (tb_os.Text == "")
            {
                MessageBox.Show("Essa OS não existe");
            }
            else
            {
                comando_select.CommandText = "SELECT N_PDF, COD_OP" +
                " FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_os.Text + //"" + 
                "' ORDER BY N_PDF";
                DataSet posicoes = new DataSet();
                fbConnection1.Open();
                datOp.SelectCommand = comando_select;

                datOp.Fill(posicoes);


                dgvPosicoes.DataSource = posicoes;
                dgvPosicoes.DataMember = posicoes.Tables[0].TableName;
                dgvPosicoes.Columns[0].Width = 73;
                dgvPosicoes.Columns[1].Width = 50;
                fbConnection1.Close();

                dsAgenda_os.Clear();

                this.datAgenda_os.SelectCommand.CommandText =
                "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
                this.fbConnection1.Open();
                this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                datAgenda_os.Fill(AGENDA_OS);
                this.fbConnection1.Close();
            }
        }

        private void dgvPosicoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dsOp.Clear();
            abre_pos(dgvPosicoes.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void bt_nova_pos_Click(object sender, EventArgs e)
        {
            if (cbEletrodo.Checked == false && cbPortaMolde.Checked == false && cbProjeto.Checked == false && tb_nova_pos.Text == "")
                MessageBox.Show("Digite um nome para a posição por favor");
            else
            {
                dsOp.Clear();
                criar_pos(tb_os.Text, tb_nova_pos.Text, "");
            }
        }

        private void bt_copiar_rota_Click(object sender, EventArgs e)
        {
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\COPIAR_ROTA.TXT");
            try
            {
                //n_rotas_copiadas = Convert.ToInt32(tbNrotas.Text);
                using (StreamWriter texto = t.CreateText())
                {

                    for (int i = 0; i < dgvRotas_campo.RowCount; i++)
                    {
                        try
                        {


                            texto.WriteLine(dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString());

                            copiar_rota[i] = dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString();

                        }
                        catch (FormatException)
                        {

                        }

                        //i++;
                       // if (i.ToString().Equals(tbNrotas.Text))
                       // {
                       //     break;
                       // }
                      //  i--;
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
                this.datRotas_campo.InsertCommand.CommandText =
                "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS)" +
                    "VALUES ('*','" + sOutput + "','" + tb_peca.Text + "','" + tb_posicao.Text + "','" + tb_codigo_op.Text + "','0.0')";
                this.fbConnection1.Open();
                this.datRotas_campo.InsertCommand.Connection = fbConnection1;
                this.datRotas_campo.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datRotas_campo.UpdateCommand.CommandText =
                    "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO WHERE OPERACAO_CAMPO = '" + sOutput + "' AND RETRABALHO_ROTA IS NULL";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();


                this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE OPERACAO_CAMPO = '" + sOutput + "' AND COD_ROTA_PECA IS NULL";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                dsRotas_campo.Clear();
                this.datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA LIKE '" + tb_codigo_op.Text + "' ORDER BY COD_ROTA_CAMPO";
                this.fbConnection1.Open();
                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();
                //contarotas(tbNrotas.Text);
                


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_cronograma_detalhado crono = new form_cronograma_detalhado();
            crono.abrir_os = true;
            crono.os_atual = tb_os.Text;
            crono.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_funcao.Visible = true;
            
        }

        private void lb_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_funcao.Text = lb_funcao.SelectedItem.ToString();
            lb_funcao.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nova_os = tb_os.Text;
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo criar uma nova OS?",
                "Confirma?", MessageBoxButtons.YesNo))
            {
                dsDesenhos.Clear();
                this.datDesenhos.SelectCommand.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "'";
                this.fbConnection1.Open();
                this.datDesenhos.SelectCommand.Connection = fbConnection1;
                this.datDesenhos.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datDesenhos.Fill(DESENHOS);
                if (tb_os.Text != "")
                    MessageBox.Show("Essa OS já existe");
                else
                {

                    //dsDesenhos.Clear();
                    this.datDesenhos.InsertCommand.CommandText =
                           "INSERT INTO DESENHOS (N_OS_PECA)" +
                           "VALUES ('" + nova_os + "')";
                    this.fbConnection1.Open();
                    this.datDesenhos.InsertCommand.Connection = fbConnection1;
                    this.datDesenhos.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    

                    this.datDesenhos.SelectCommand.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "' order by cod_peca ";
                    this.fbConnection1.Open();
                    this.datDesenhos.SelectCommand.Connection = fbConnection1;
                    this.datDesenhos.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    datDesenhos.Fill(DESENHOS);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsDesenhos, "DESENHOS"].EndCurrentEdit();
            //fbConnection1.Open();
            if (dsDesenhos.HasChanges())
            {

                //MessageBox.Show("CHEGOU NO ATUALIZAR do rotas");
                datDesenhos.UpdateCommand = cbDesenhos.GetUpdateCommand();
                datDesenhos.InsertCommand = cbDesenhos.GetInsertCommand();
                datDesenhos.DeleteCommand = cbDesenhos.GetDeleteCommand();
                datDesenhos.Update(dsDesenhos, "DESENHOS");
                dsDesenhos.AcceptChanges();

            }
            fbConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inserir();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                excluir(dgvRotas_campo.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecione a linha inteira por favor");
                fbConnection1.Close();
            }
        }
        private void excluir(string cod)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                    "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        
                        
                        this.datRotas_campo.DeleteCommand.CommandText =
                        "DELETE FROM ROTAS_CAMPO WHERE COD_ROTA_CAMPO = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datRotas_campo.DeleteCommand.Connection = fbConnection1;
                        this.datRotas_campo.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        
                        this.datHoras_semana.UpdateCommand.CommandText =
                           "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" + DateTime.Now.ToShortDateString().Replace("/", ".") + "' WHERE ROTA_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                        this.fbConnection1.Open();
                        this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                        this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datHoras_semana.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET EXCLUIDO_ONDE_SEMANA = 'OP 2' WHERE ROTA_HORAS_SEMANA = '" + cod + "' AND DATA_EXCLUSAO_SEMANA IS NULL";
                        this.fbConnection1.Open();
                        this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                        this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        /*
                        this.datHoras_semana.DeleteCommand.CommandText =
                        "DELETE FROM HORAS_SEMANA WHERE ROTA_HORAS_SEMANA = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datHoras_semana.DeleteCommand.Connection = fbConnection1;
                        this.datHoras_semana.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                         * */
                        comecar();

                    }
                    catch
                    {
                        MessageBox.Show("Selecione a linha inteira por favor");
                        fbConnection1.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }
        
        }

        private void comecar()
        {
            dsRotas_campo.Clear();
            this.datRotas_campo.SelectCommand.CommandText =
                    "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' ORDER BY COD_ROTA_CAMPO";
            this.fbConnection1.Open();
            this.datRotas_campo.SelectCommand.Connection = fbConnection1;
            this.datRotas_campo.SelectCommand.ExecuteNonQuery();
            datRotas_campo.Fill(ROTAS_CAMPO);
            this.fbConnection1.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            cod_rota_desenho = "x://" + tb_os.Text + "-(" + tb_cliente.Text + ")//projeto//OS " + tb_os.Text + "-" + tb_posicao.Text + ".dwg";
            System.Diagnostics.Process.Start(@cod_rota_desenho);
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            this.datAgenda_os.InsertCommand.CommandText =
                    "INSERT INTO AGENDA_OS (OS_AGENDA_OS, CLIENTE_AGENDA_OS, DESCRICAO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS, TIPO_OCORRENCIA_AGENDA_OS, FINALIZADO_AGENDA_OS)" +
                    "VALUES ('" + tb_os.Text + "','" + tb_cliente.Text + "','" + tb_descricao.Text + "','" + Convert.ToDateTime(dtData_agenda.Text).ToShortDateString().Replace("/",".") + "','" + Convert.ToDateTime(dtHora_agenda.Text).ToShortTimeString() + "','" + cbTipo_ocorrencia.Text + "','0')";
            this.fbConnection1.Open();
            this.datAgenda_os.InsertCommand.Connection = fbConnection1;
            this.datAgenda_os.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            dsAgenda_os.Clear();

            this.datAgenda_os.SelectCommand.CommandText =
            "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
            this.fbConnection1.Open();
            this.datAgenda_os.SelectCommand.Connection = fbConnection1;
            this.datAgenda_os.SelectCommand.ExecuteNonQuery();
            datAgenda_os.Fill(AGENDA_OS);
            this.fbConnection1.Close();
            tb_descricao.Text = "";
            cbTipo_ocorrencia.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Atualizar();
            dsAgenda_os.Clear();

            this.datAgenda_os.SelectCommand.CommandText =
            "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
            this.fbConnection1.Open();
            this.datAgenda_os.SelectCommand.Connection = fbConnection1;
            this.datAgenda_os.SelectCommand.ExecuteNonQuery();
            datAgenda_os.Fill(AGENDA_OS);
            this.fbConnection1.Close();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                excluir_agenda(dgvAgenda.SelectedRows[0].Cells["col_cod_agenda"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecione a linha inteira por favor");
                fbConnection1.Close();
            }
        }

        private void excluir_agenda(string cod)
        {
            FileInfo d = new FileInfo("c:\\evolucao_dokinos\\seg_del.txt");
            if (d.Exists == true)
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                    "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {


                        this.datAgenda_os.DeleteCommand.CommandText =
                        "DELETE FROM AGENDA_OS WHERE COD_AGENDA_OS = '" + cod + "'";
                        this.fbConnection1.Open();
                        this.datAgenda_os.DeleteCommand.Connection = fbConnection1;
                        this.datAgenda_os.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        
                        dsAgenda_os.Clear();

                        this.datAgenda_os.SelectCommand.CommandText =
                        "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
                        this.fbConnection1.Open();
                        this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                        this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                        datAgenda_os.Fill(AGENDA_OS);
                        this.fbConnection1.Close();
                        

                    }
                    catch
                    {
                        MessageBox.Show("Selecione a linha inteira por favor");
                        fbConnection1.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esse recurso");
            }

        }

        private void tb_os_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                abrir_os();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form_localiza_op os = new form_localiza_op();
            try
            {
                os.ShowDialog();
            }
            finally
            {
                os.Dispose();

                string nova_os = os.os_escolhida;
                dsDesenhos.Clear();
                this.datDesenhos.SelectCommand.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "'";
                this.fbConnection1.Open();
                this.datDesenhos.SelectCommand.Connection = fbConnection1;
                this.datDesenhos.SelectCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datDesenhos.Fill(DESENHOS);
                if (tb_os.Text == "")
                {
                    MessageBox.Show("Essa OS não existe");
                }
                else
                {
                    dsOp.Clear();
                    comando_select.CommandText = "SELECT N_PDF, COD_OP" +
                    " FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_os.Text + //"" + 
                    "' ORDER BY N_PDF";
                    DataSet posicoes = new DataSet();
                    fbConnection1.Open();
                    datOp.SelectCommand = comando_select;

                    datOp.Fill(posicoes);


                    dgvPosicoes.DataSource = posicoes;
                    dgvPosicoes.DataMember = posicoes.Tables[0].TableName;
                    dgvPosicoes.Columns[0].Width = 73;
                    dgvPosicoes.Columns[1].Width = 50;
                    fbConnection1.Close();

                    dsAgenda_os.Clear();

                    this.datAgenda_os.SelectCommand.CommandText =
                    "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
                    this.fbConnection1.Open();
                    this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                    this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                    datAgenda_os.Fill(AGENDA_OS);
                    this.fbConnection1.Close();
                }
            }
        
        }

        

    }
}