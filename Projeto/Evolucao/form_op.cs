using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_op : Form
    {
        DataTable posicoes = new DataTable();
        string cod_rota_desenho;
        double horas_previstas_contra_prova;
        bool erro_horas;
        public string[] copiar_rota = new string[50];
       // string data_ent_prev;
        //string data_fech_prev;
        public string desenho_variavel;
        string cnpj_empresa;
        public object cod_op_atual_variavel;
        public string n_pdf_atual;
        public string n_op_peca;
        public string material_atual;
        public string espessura_atual;
        public string[,] copiar_dados_rota = new string[50, 5];
        public string tbNrotas_op;
        public bool eletrodo;
        public string operacao_atual;
        public string codOsSistema;
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
            try
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
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
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
            tb_os.Focus();
            if (cod_op_atual_variavel != null)
            {
                abre_pos(cod_op_atual_variavel.ToString());
                tb_os.Text = codOsSistema;
                abrir_os();
            }
            //MessageBox.Show("chegou no load");
            //se for uma op já existente

        }
        private void abre_pos(string cod_op_atual_variavel2)
        {
            //if (cod_op_atual_variavel != null)
            //{
            try
            {
                int qualquer_op = Convert.ToInt32(cod_op_atual_variavel2);
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


                selecionar_rotas();

                dsAgenda_os.Clear();
                this.datAgenda_os.SelectCommand.CommandText =
                "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' AND POSICAO_AGENDA_OS = '" + tb_posicao.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
                this.fbConnection1.Open();
                this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                datAgenda_os.Fill(AGENDA_OS);
                this.fbConnection1.Close();
                /*
                    dsOt.Clear();
                    this.datOt.SelectCommand.CommandText =
                    "SELECT * FROM OCORRENCIA_TECNICA WHERE COD_POSICAO_OT = '" + tb_codigo_op.Text + "' ORDER BY COD_OT";
                    this.fbConnection1.Open();
                    this.datOt.SelectCommand.Connection = fbConnection1;
                    this.datOt.SelectCommand.ExecuteNonQuery();
                    datOt.Fill(OCORRENCIA_TECNICA);
                    this.fbConnection1.Close();
                    */

                verificar_inspecao();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void selecionar_rotas()
        {
            try
            {
                dgvRotas_campo.AutoGenerateColumns = false;
                dgvRotas_campo.DataSource = dsRotas_campo.Tables["ROTAS_CAMPO"];
                dsRotas_campo.Clear();
                this.datRotas_campo.SelectCommand.CommandText =
                "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY POSICAO_FILA_CAMPO, COD_ROTA_CAMPO";
                this.fbConnection1.Open();
                this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                datRotas_campo.Fill(ROTAS_CAMPO);
                this.fbConnection1.Close();
            }

            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());

            }
        }

        private void verificar_inspecao()
        {
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                try
                {
                    if (dgvRotas_campo.Rows[i].Cells["col_inspecao"].Value.ToString() != "")
                        dgvRotas_campo.Rows[i].Cells[0].Style.BackColor = Color.Green;
                }
                catch { }
            }
            dgvRotas_campo.ClearSelection();
        }
        //se for uma op nova
        private void criar_pos(string desenho_variavel2, string n_pdf_atual2, string material_atual2)
        {
            try
            {
                comando_select.CommandText = "SELECT COD_CLIENTE FROM CLIENTES WHERE NOME_FANTASIA = '" + tb_cliente.Text + "'";
                DataSet clientes_2 = new DataSet();
                fbConnection1.Open();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(clientes_2);
                string codigo = "";
                foreach (DataRow dr in clientes_2.Tables[0].Rows)
                {
                    codigo = dr["COD_CLIENTE"].ToString();

                }

                this.fbConnection1.Close();

                //string codigo = "";
                if (n_pdf_atual2 == "")
                    n_pdf_atual2 = "null";
                else
                    n_pdf_atual2 = "'" + n_pdf_atual2 + "'";

                string qtde = "'1'";
                if (tb_qtde_produto.Text != "")
                    qtde = "'" + tb_qtde_produto.Text + "'";


                this.datOp.InsertCommand.CommandText =
                "INSERT INTO OP (DESENHO_OP_ATUAL, COND_PGTO, CLIENTE_OP, DATA_PDF, QDE_PDF, QDE_FAB, PEDIDO_INTERNO_OP)" +
                "VALUES ('" + desenho_variavel2 + "'," + n_pdf_atual2 + ",'" + codigo + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "'," + 
                qtde + "," + qtde + ", '" + desenho_variavel2 + "')";
                this.fbConnection1.Open();
                this.datOp.InsertCommand.Connection = fbConnection1;
                this.datOp.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datOp.SelectCommand.CommandText =
                "SELECT * FROM OP WHERE COD_OP = '" + buscar_ultima_insercao() + "'";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                datOp.Fill(OP);
                this.fbConnection1.Close();

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

                tb_pedido_op.Text = tb_pedido.Text;
                string descricao, revisao, materia_prima, preco, unidade, cod_materia_prima, dureza, ferramenta, posicao;
                string[,] operacao_escolhida = new string[200, 2];
                int numero_de_itens;
                buscar_informacoes_peca(n_pdf_atual2, out descricao, out revisao, out materia_prima, out preco, out unidade, 
                    out numero_de_itens, out operacao_escolhida, out cod_materia_prima, out dureza, out posicao, out ferramenta);
                tb_descricao_peca.Text = descricao;
                tb_revisao.Text = revisao;
                tb_ferramenta.Text = ferramenta;
                tbPosicao.Text = posicao;
                //tb_valor_unitario_peca.Text = preco;
                try
                {
                    tb_cod_mat.Text = cod_materia_prima;
                    tb_material.Text = materia_prima;

                    tb_dureza.Text = dureza;
                }
                catch { }
                tb_unidade.Text = unidade;
                tb_posicao.Text = buscar_ultima_posicao();
                if(tb_qtde_nova.Text != "")
                    tb_qtde.Text = tb_qtde_nova.Text;
                tb_valor_unitario_peca.Text = tb_valor_novo.Text;
                tb_item_orc.Text = tb_item_orc_novo.Text;
                tb_n_orcamento.Text = buscar_orcamento(tb_item_orc.Text);

                cb_codigo.Text = "00";
                if (cbRetrabalho.Checked)
                    cb_codigo.Text = "01";
                Atualizar();
                if(tb_item_orc.Text != "")
                    baixar_item_orc(tb_item_orc.Text);
                inserir_operacoes(numero_de_itens, operacao_escolhida);
                HasTextBox(novogroupBox);
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
                    "SELECT COD_OP FROM OP ORDER BY COD_OP DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "erro";

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "erro";
            }
        }

        private string buscar_orcamento(string cod_item_orc)
        {
            if(cod_item_orc != "")
            {
           try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_ORCAMENTO_ITEM_ORC FROM ITENS_ORCAMENTO WHERE COD_ITEM_ORC = '" + cod_item_orc + "'";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "erro";

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "erro";
            }
                }
            else
            {

                return "";
                }
        }

        protected void HasTextBox(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                if (c.HasChildren)
                {
                    HasTextBox(c);
                }
            }
            foreach (Control d in ctrl.Controls)
            {
                if (d is System.Windows.Forms.RadioButton)
                {
                    ((System.Windows.Forms.RadioButton)(d)).Checked = false;
                }

                if (d.HasChildren)
                {
                    HasTextBox(d);
                }
            }
            foreach (Control e in ctrl.Controls)
            {
                if (e is System.Windows.Forms.CheckBox)
                {
                    ((System.Windows.Forms.CheckBox)(e)).Checked = false;
                }

                if (e.HasChildren)
                {
                    HasTextBox(e);
                }
            }
        }

        private void baixar_item_orc(string cod)
        {
            if(cod != "")
            {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE ITENS_ORCAMENTO SET COD_OS_POS_ITEM_ORC = '" + tb_codigo_op.Text + "', STATUS_ITEM_ORC = 'ITEM APROVADO' " +
                    "WHERE COD_ITEM_ORC = '" + cod + "'";
                FbDataAdapter datItens_orc = new FbDataAdapter();
                datItens_orc.UpdateCommand = update;
                datItens_orc.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
                }
        }

        private string buscar_ultima_posicao()
        {
            try
            {
                /*
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM OP WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "'";
                fbConnection1.Open();
                FbDataAdapter opDataAdapter = new FbDataAdapter();
                DataSet opDataSet = new DataSet();
                opDataAdapter.SelectCommand = select;
                opDataAdapter.Fill(opDataSet);
                fbConnection1.Close();
                int numero = 1 + opDataSet.Tables[0].Rows.Count;
                return numero.ToString();
                 * */
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT N_PDF FROM OP WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "' ORDER BY COND_PGTO DESC";
                fbConnection1.Open();
                FbDataAdapter opDataAdapter = new FbDataAdapter();
                DataSet opDataSet = new DataSet();
                opDataAdapter.SelectCommand = select;
                opDataAdapter.Fill(opDataSet);
                fbConnection1.Close();
                int[] numeros = new int[2000];
                int i = 0;
                foreach (DataRow dr in opDataSet.Tables[0].Rows)
                {
                    try
                    {
                        numeros[i] = Convert.ToInt32(dr["N_PDF"].ToString());
                        i++;
                    }
                    catch
                    { }
                }
                Array.Sort(numeros);
                try
                {
                    int numero = 1 + numeros[numeros.Length - 1];
                    return numero.ToString();
                }
                catch { }
                return "erro";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "erro";
            }
        }

        private void buscar_informacoes_peca(string cod_peca, out string descricao, 
            out string revisao, out string materia_prima, out string preco, 
            out string unidade, out int numero_de_itens, out string[,] operacao_escolhida, out string cod_materia_prima, 
            out string dureza, out string posicao, out string ferramenta)
        {
            descricao = ""; revisao = ""; materia_prima = ""; preco = ""; unidade = "";
            numero_de_itens = 0; operacao_escolhida = null; cod_materia_prima = ""; dureza = "";
            posicao = ""; ferramenta = "";
            
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DESCRICAO_PECA, REVISAO_PECA, PRECO_PECA, COD_PECA, UNIDADE_PECA, DUREZA_PECA, COD_ALTERNATIVO1_PECA, COD_ALTERNATIVO2_PECA FROM PECAS " 
                    + "WHERE COD_DESENHO_PECA = " + cod_peca + "";
                FbDataAdapter datPeca = new FbDataAdapter();
                datPeca.SelectCommand = select;
                DataSet dsPeca = new DataSet();
                datPeca.Fill(dsPeca);
                fbConnection1.Close();
                foreach (DataRow dr in dsPeca.Tables[0].Rows)
                {
                    descricao = dr[0].ToString();
                    revisao = dr[1].ToString();
                    preco = dr[2].ToString();
                    unidade = dr[4].ToString();
                    dureza = dr[5].ToString();
                    ferramenta = dr[6].ToString();
                    posicao = dr[7].ToString();

                    //buscando matéria prima
                    FbCommand select_mp = new FbCommand();
                    select_mp.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_mp.CommandText =
                        "SELECT DESCRICAO_ITENS_MP_PECA, COD_PECA_ITENS_MP_PECA FROM ITENS_MATERIA_PRIMA_PECA " +
                        "WHERE COD_PECA_ITENS_MP_PECA = '" + dr[3].ToString() + "'";
                    FbDataAdapter datMp = new FbDataAdapter();
                    datMp.SelectCommand = select_mp;
                    DataSet dsMp = new DataSet();
                    datMp.Fill(dsMp);
                    fbConnection1.Close();
                    foreach (DataRow dr_mp in dsMp.Tables[0].Rows)
                    {
                        materia_prima = dr_mp[0].ToString();
                        cod_materia_prima = dr_mp[1].ToString();
                    }

                    //buscando rota
                    FbCommand select_rota = new FbCommand();
                    select_rota.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_rota.CommandText =
                        "SELECT DESCRICAO_ROTAS_PECA, QTDE_HORAS_ROTAS_PECA FROM ROTAS_PECA " +
                        "WHERE COD_PECA_ROTAS_PECA = '" + dr[3].ToString() + "'";
                    FbDataAdapter datRota = new FbDataAdapter();
                    datRota.SelectCommand = select_rota;
                    DataSet dsRota = new DataSet();
                    datRota.Fill(dsRota);
                    fbConnection1.Close();
                    int i = 0;
                    string[,] operacao = new string[200, 2];
                    foreach (DataRow dr_rota in dsRota.Tables[0].Rows)
                    {
                        operacao[i, 0] = dr_rota[0].ToString();
                        operacao[i, 1] = dr_rota[1].ToString();
                        i++;
                    }
                    numero_de_itens = i;
                    operacao_escolhida = operacao;
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }
            
            //DataGridView1.ClipboardCopyMode = 
    //DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

        private void insere_porta_molde()
        {
            //int n_rotas_campo_prov = Convert.ToInt32(tbNum_rotas_campo.Text);
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
            //int n_rotas_campo_prov = Convert.ToInt32(tbNum_rotas_campo.Text);
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
            //int n_rotas_campo_prov = Convert.ToInt32(tbNum_rotas_campo.Text);
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
            for (int i = 0; i < Convert.ToInt32(n_op_peca); i++)
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
            update_os();
            update_rotas();
            classeEstoque_pecas est = new classeEstoque_pecas();
            est.conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            est.conexao.Open();
            
            est.localizacao = buscar_localizacao_peca(tb_codigo_peca.Text);
             est.calcular_estoque(tb_codigo_peca.Text, tb_revisao.Text);
             est.atualizar_tabela(tb_codigo_peca.Text, tb_revisao.Text);
            est.conexao.Close();
            
            for (int j = 0; j < dgvRotas_campo.RowCount; j++)
            {
                update_semana(dgvRotas_campo.Rows[j].Cells["col_cod"].Value.ToString(), j);
            }
            inserir_semanas();
            if (tb_cod_mat.Text != "")
            {
                classeEstoque estoque = new classeEstoque();
                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                estoque.calcular_estoque(tb_cod_mat.Text);

            }
        }

        private string buscar_localizacao_peca(string cod)
        {
            string retorno = "sem localizacao";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT LOCAL_EST_PECA FROM ESTOQUE_PECAS WHERE PECA_EST_PECA = '" + cod.ToString() + "'";
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataSet dsEstoque = new DataSet();
                datEstoque.Fill(dsEstoque);
                fbConnection1.Close();
                foreach (DataRow dr in dsEstoque.Tables[0].Rows)
                {
                    retorno = dr[0].ToString();
                }
                if(retorno != "")
                    return retorno;
                else
                    return "sem localizacao";
            
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }


        private void update_os()
        {
            try
            {
                comando_select.CommandText = "SELECT COD_CLIENTE FROM CLIENTES WHERE NOME_FANTASIA = '" + tb_cliente.Text + "'";
                DataSet clientes_2 = new DataSet();
                fbConnection1.Open();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(clientes_2);
                string codigo = "";
                foreach (DataRow dr in clientes_2.Tables[0].Rows)
                {
                    codigo = dr["COD_CLIENTE"].ToString();

                }

                this.fbConnection1.Close();
                this.datOp.UpdateCommand.CommandText =
                        "UPDATE OP SET CLIENTE_OP = '" + codigo + "' WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "'";
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

        private void update_rotas()
        {
            try
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
                            "UPDATE ROTAS_CAMPO SET QTDE_ROTA = '" + tb_qtde_fab.Text + "' WHERE OP_ROTA = '" + tb_codigo_op.Text + "'";
                    this.fbConnection1.Open();
                    this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                    this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
            catch { fbConnection1.Close(); }
        }

        private void update_semana(string rota, int i)
        {
            try
            {
                this.datHoras_semana.UpdateCommand.CommandText =
                        "UPDATE HORAS_SEMANA SET POSICAO_OS_SEMANA = '" + tb_posicao.Text + "' WHERE ROTA_HORAS_SEMANA = '" + rota + "'";
                this.fbConnection1.Open();
                this.datHoras_semana.UpdateCommand.Connection = fbConnection1;
                this.datHoras_semana.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
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
            //int op_variavel = Convert.ToInt32(tb_codigo_op.Text);
            //
            
            dsRotas_campo.Tables["ROTAS_CAMPO"].DefaultView.RowFilter = "op_rota Like '" + tb_codigo_op.Text + "'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            imprimir_op(tb_codigo_op.Text, tb_codigo_peca.Text);
        }

        private void imprimir_op(string cod_op, string cod_produto)
        {
            try
            {
                dsConsulta imprime_op = new dsConsulta();
                  string cliente = "";
                string vendedor = buscar_vendedor_pedido(tb_pedido_op.Text, out cliente);
                if(tb_cliente.Text == "")
                    tb_cliente.Text = cliente;
                Atualizar();
                imprime_op.Vendedor.AddVendedorRow(vendedor);
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + cod_op + "' ORDER BY POSICAO_FILA_CAMPO";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.ROTAS_CAMPO);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }

                double qtde_fab = 0;
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM OP WHERE COD_OP = '" + cod_op + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.OP);
                    fbConnection1.Close();
                    foreach (DataRow dr in imprime_op.OP.Rows)
                    {
                        try
                        {
                            qtde_fab = Convert.ToDouble(dr["QDE_FAB"].ToString());
                        }
                        catch { }
                    }
                    this.datDesenhos.SelectCommand.CommandText =
                  "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + tb_os.Text + "'";
                    this.fbConnection1.Open();
                    this.datDesenhos.SelectCommand.Connection = fbConnection1;
                    this.datDesenhos.Fill(imprime_op.DESENHOS);
                    this.fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }

                string _cod_produto = buscar_cod_produto(cod_produto);
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM ITENS_PRODUTO inner join produtos on COD_PRODUTO_IP = cod_produto WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.ITENS_PRODUTO);
                    fbConnection1.Close();
                    foreach (DataRow dr in imprime_op.ITENS_PRODUTO.Rows)
                    {
                        _cod_produto = dr["COD_PRODUTO"].ToString();
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }

                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                             @"SELECT pk.*, p.COD_FORNECEDOR_PRODUTO as COD_FORN, (pk.QTDE_PK * " + qtde_fab.ToString().Replace(".", "").Replace(",", ".") +
                             @") AS QDE_COMPONENTE FROM PRODUTOS_KIT pk 
                            INNER JOIN produtos p on pk.COD_PRODUTO_PK = p.cod_produto WHERE pk.COD_KIT_PK = '" + _cod_produto + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprime_op.PRODUTOS_KIT);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }
                //Byte b = new Byte();
              

                //cr_nova_op_dale op_nova = new cr_nova_op_dale();
                crNova_op op_nova = new crNova_op();
                op_nova.SetDataSource(imprime_op);
                op_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                try
                {
                    op_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                }
                catch { }
                form_imprimir imprimir = new form_imprimir(op_nova);

                try
                {
                    Thread.Sleep(1000);
                    imprimir.ShowDialog();
                }
                finally
                {

                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText = "UPDATE OP SET IMPRESSO_OP = 1 WHERE COD_OP = '" + cod_op + "'";
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
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

                MessageBox.Show(ex.Message);
            }
        }

        private string buscar_vendedor_pedido(string pedido, out string cliente)
        {
            cliente = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT * FROM PEDIDOS_VENDA WHERE N_PED_VENDA = '" + pedido + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    cliente = dr["CLIENTE_PED_VENDA"].ToString();
                    return dr["VENDEDOR_PED_VENDA"].ToString();
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

        private string buscar_cod_produto(string cod_produto)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT * FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr["COD_PRODUTO"].ToString();
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

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOp, "OP"].Position = 10000000;
        }

        private void dgvRotas_campo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
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
             */
        }

        private void datRotas_campo_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {

        }

        private void apaga_registro_Click(object sender, EventArgs e)
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
                inserir_operacoes(abre.numero_de_itens, abre.operacao_escolhida);
            }

        }
        private void inserir_operacoes(int numero_de_itens, string[,] operacao_escolhida)
        {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    //DateTime comeco = DateTime.Now;
                    for (int i = 0; i < numero_de_itens; i++)
                    {
                        operacao_atual = operacao_escolhida[i,0];
                        int qtde = 0;
                        string horas_previstas = operacao_escolhida[i, 1];
                        //string abrev_atual = abre.abrev_escolhida[i];
                        try
                        {
                            qtde = Convert.ToInt32(tb_qtde_fab.Text);
                        }
                        catch
                        {
                            qtde = 1;
                        }

                        if (horas_previstas == "")
                        {
                            horas_previstas = "null";
                        }
                        else
                        {
                            //retirar 20% da previsão
                            double _horas_previstas = Convert.ToDouble(horas_previstas);// -(Convert.ToDouble(horas_previstas) * Convert.ToDouble("0,2"));
                            _horas_previstas = _horas_previstas;// *qtde;
                            horas_previstas = "'" + _horas_previstas.ToString().Replace(".", "").Replace(",", ".") + "'";
                        }
                        int zero = 0;
                        
                        
                        if (cb_codigo.Text == "")
                            cb_codigo.Text = "00";

                        int posicao_fila = dgvRotas_campo.RowCount + 1;

                        this.datRotas_campo.InsertCommand.CommandText =
                        "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, FUNCAO_ROTA, HORAS_PARADAS, " +
                        "QTDE_ROTA, CODIGO_OS_CAMPO, PREVISAO_HORAS_UNIT_ROTA, OBSERVACAO_CAMPO, POSICAO_FILA_CAMPO)" +
                        "VALUES ('*','" + operacao_atual + "','" + tb_peca.Text + "','" + tb_posicao.Text + "','" +
                        tb_codigo_op.Text + "','" + tb_funcao.Text + "','" + zero.ToString() + "','" + qtde.ToString() + "','" +
                        cb_codigo.Text + "'," + horas_previstas + ",' ', '" + posicao_fila.ToString() + "')";
                        this.fbConnection1.Open();
                        this.datRotas_campo.InsertCommand.Connection = fbConnection1;
                        this.datRotas_campo.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        int ultima_rota = buscar_ultima_rota();

                        this.datRotas_campo.UpdateCommand.CommandText =
                        "UPDATE ROTAS_CAMPO SET RETRABALHO_ROTA = COD_ROTA_CAMPO, COD_ROTA_PECA = COD_NUM_ROTAS||COD_ROTA_CAMPO||COD_NUM_ROTAS WHERE COD_ROTA_CAMPO = '" + ultima_rota.ToString() + "'";
                        this.fbConnection1.Open();
                        this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                        this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();


                       
                        dsRotas_campo.Clear();

                        /*
                        this.datRotas_campo.SelectCommand.CommandText =
                        "SELECT * FROM ROTAS_CAMPO WHERE OP_ROTA = '" + tb_codigo_op.Text + "' AND COD_ROTA_CAMPO = RETRABALHO_ROTA ORDER BY COD_ROTA_CAMPO";
                        this.fbConnection1.Open();
                        this.datRotas_campo.SelectCommand.Connection = fbConnection1;
                        this.datRotas_campo.SelectCommand.ExecuteNonQuery();
                        datRotas_campo.Fill(ROTAS_CAMPO);
                        this.fbConnection1.Close();
                         * */

                        selecionar_rotas();



                        
                    }

                    this.Cursor = Cursors.Default;
                }
                catch
                {
                    fbConnection1.Close();
                    MessageBox.Show("Erro na inserção de operação");
                }
               
                


            
        
        }

        private int buscar_ultima_rota()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT FIRST(1) COD_ROTA_CAMPO FROM ROTAS_CAMPO ORDER BY COD_ROTA_CAMPO DESC";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return Convert.ToInt32(dr[0].ToString());
                }
                return 0;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        

        private void inserir_semanas()
        {
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                if (dgvRotas_campo.Rows[i].Cells["col_sem"].Value.ToString() != "1")
                {
                    try
                    {
                        if (dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value.ToString().Trim() != "")
                        {
                            rota_atual = dgvRotas_campo.Rows[i].Cells[0].Value.ToString();
                            excluir_semanas(rota_atual);
                            Atualizar();
                            int numero_dias;
                            numero_dias = contar_dias(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value),
                                   Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value));
                           

                            //MessageBox.Show("numero de dias " + numero_dias.ToString());
                            string entrada_prevista = null;
                            try
                            {
                                entrada_prevista = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value.ToString()).ToShortDateString();
                            }
                            catch { }
                            string fim_previsto = null;
                            try
                            {
                                fim_previsto = Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value.ToString()).ToShortDateString();
                            }
                            catch { }

                            classeApontamentos apontamento = new classeApontamentos();
                            apontamento.fbConnection1.ConnectionString =
                                @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            DateTime[] primeiro_dia_semana = new DateTime[200];
                            DateTime[] ultimo_dia_semana = new DateTime[200];
                            int[] semana_numero = new int[200];
                            int n_semanas = 0;
                            apontamento.buscar_semanas(Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value.ToString()),
                                Convert.ToDateTime(dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value.ToString()),
                                out primeiro_dia_semana, out ultimo_dia_semana, out semana_numero, out n_semanas);
                           
                            if (dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString() != "")
                            {
                                horas_semana = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value) / n_semanas;
                            }
                            else
                            {
                                horas_semana = 0;
                            }
                            operacao_semana = dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString();
                            rota_semana = Convert.ToInt32(dgvRotas_campo.Rows[i].Cells["col_cod"].Value);
                            //buscar_horas_disponiveis(dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString());

                            for(int j = 0; j < n_semanas; j++)
                            {
                                inserir_nas_semanas(semana_numero[j], horas_semana, operacao_semana, 
                                    rota_semana, n_semanas, primeiro_dia_semana[j].Year, tb_peca.Text, 
                                    tb_posicao.Text, entrada_prevista, fim_previsto);
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
                    //MessageBox.Show("Essa rota já foi inserida, para reinseri-la a coluna Sem deve estar zerada");
                }

            }
            Atualizar();
            dsRotas_campo.Clear();
            datRotas_campo.Fill(ROTAS_CAMPO);
        }

        private void update_sem_rotas(string rota_atual)
        {
            try
            {
                this.datRotas_campo.UpdateCommand.CommandText =
                        "UPDATE ROTAS_CAMPO SET INSERIDO_SEMANA = 1 WHERE COD_ROTA_CAMPO = '" + rota_atual + "'";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

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
            try
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
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

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

        private void inserir_nas_semanas(int semana, double horas, string operacao, int rota, int numero_sem, 
            int ano_semana, string os_semana, string posicao_semana, string data_ent_prev, string data_fech_prev)
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
            tb_horas_previstas_restantes.Text = buscar_horas_previstas_restantes(tb_os.Text);
        }

        private string buscar_horas_previstas_restantes(string os)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT SUM(PREVISAO_PRODUCAO), SUM(SALDO_HORAS) FROM ROTAS_CAMPO WHERE DESENHO_CAMPO = '" + os + "' AND DATA_FECHAMENTO IS NULL";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                
                double resultado = -1;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        resultado = Convert.ToDouble(dr[0].ToString()) - Convert.ToDouble(dr[1].ToString());
                    }
                    catch { return resultado.ToString("n2"); }
                    return resultado.ToString("n2");
                }
                return resultado.ToString("n2");
                
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "-1";
            }
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
                codOsSistema = DESENHOS.Rows[0]["cod_peca"].ToString();
                
                selecinar_posicoes();

                
                
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

        private void selecinar_posicoes()
        {
            try
            {
                posicoes.Clear();
                comando_select.CommandText = "SELECT COND_PGTO, DESCRICAO_FERRAMENTA_OP, N_PDF, COD_OP" +
                " FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_os.Text + //"" + 
                "' ORDER BY COND_PGTO";
                
                fbConnection1.Open();
                FbDataAdapter opDataAdapter = new FbDataAdapter();
                opDataAdapter.SelectCommand = comando_select;
                opDataAdapter.Fill(posicoes);
                dgvPosicoes.DataSource = posicoes;
                //dgvPosicoes.DataMember = posicoes.TableName;
                dgvPosicoes.Columns[0].Width = 60;
                dgvPosicoes.Columns[1].Width = 60;
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void dgvPosicoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dsOp.Clear();
            dsRotas_campo.Clear();
            abre_pos(dgvPosicoes.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void bt_nova_pos_Click(object sender, EventArgs e)
        {
            if (tb_data_abertura.Text != "")
            {
                    dsOp.Clear();
                    criar_pos(tb_os.Text, tb_nova_pos.Text, "");
                    tb_data_entrada_pos.Text = tb_data_abertura.Text;
                    tb_data_entrega_pos.Text = tb_prazo_entrega_os.Text;
                    
                    Atualizar();
                    selecinar_posicoes();
            }
            else
            {
                MessageBox.Show("Digite uma data de abertura para a OS.");
            }
        }

        private void bt_copiar_rota_Click(object sender, EventArgs e)
        {
            FileInfo t = new FileInfo("c:\\evolucao\\COPIAR_ROTA.TXT");
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
            StreamReader objReader = new StreamReader("c:\\evolucao\\COPIAR_ROTA.TXT");
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();
            int posicao_fila = 1;
            foreach (string sOutput in arrText)
            {
                this.datRotas_campo.InsertCommand.CommandText =
                "INSERT INTO ROTAS_CAMPO (COD_NUM_ROTAS, OPERACAO_CAMPO, DESENHO_CAMPO, N_PDF_CAMPO, OP_ROTA, HORAS_PARADAS, POSICAO_FILA_CAMPO)" +
                    "VALUES ('*','" + sOutput + "','" + tb_peca.Text + "','" + tb_posicao.Text + "','" +
                    tb_codigo_op.Text + "','0.0', '" + posicao_fila.ToString() + "')";
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

                posicao_fila++;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_cronograma_detalhado_x x = new form_cronograma_detalhado_x();
            x.os_a_abrir = tb_os.Text;
            x.Show();
        }

        

        

        private void button4_Click(object sender, EventArgs e)
        {
            string nova_os = tb_os.Text;

            if (nova_os != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja mesmo criar uma nova OS?",
                    "Confirma?", MessageBoxButtons.YesNo))
                {
                    if (verificar_se_os_ja_existe(nova_os))
                        MessageBox.Show("Essa OS já existe");
                    else
                    {

                        dsDesenhos.Clear();
                        dsOp.Clear();
                        this.datDesenhos.InsertCommand.CommandText =
                               "INSERT INTO DESENHOS (N_OS_PECA)" +
                               "VALUES ('" + nova_os + "')";
                        this.fbConnection1.Open();
                        this.datDesenhos.InsertCommand.Connection = fbConnection1;
                        this.datDesenhos.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datDesenhos.SelectCommand.CommandText =
                        "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "' order by cod_peca";
                        this.fbConnection1.Open();
                        this.datDesenhos.SelectCommand.Connection = fbConnection1;
                        this.datDesenhos.SelectCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        datDesenhos.Fill(DESENHOS);
                        tb_data_abertura.Text = DateTime.Now.ToShortDateString();
                        Atualizar();
                        abrir_os();

                        txtNomePeca.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("É necessário informar um código para a nova OS!");
                tb_os.Focus();
            }
        }

        private bool verificar_se_os_ja_existe(string nova_os)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM DESENHOS WHERE N_OS_PECA = '" + nova_os + "'";
                FbDataAdapter datDes = new FbDataAdapter();
                datDes.SelectCommand = select;
                DataSet dsDes = new DataSet();
                datDes.Fill(dsDes);
                fbConnection1.Close();
                foreach (DataRow dr in dsDes.Tables[0].Rows)
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

        private string buscar_ultima_os()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT N_OS_PECA FROM DESENHOS ORDER BY COD_PECA DESC";
                FbDataAdapter osDataAdapter = new FbDataAdapter();
                osDataAdapter.SelectCommand = select;
                DataSet osDataSet = new DataSet();
                osDataAdapter.Fill(osDataSet);

                if (osDataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = osDataSet.Tables[0].Rows[0];
                    int retorno = Convert.ToInt32(dr[0].ToString()) + 1;
                    while (os_ja_existe(retorno))
                    {
                        retorno++;
                    }
                    return retorno.ToString();
                }
                else
                {
                    return "1";
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "erro";
            }
        }

        private bool os_ja_existe(int retorno)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_PECA FROM DESENHOS WHERE N_OS_PECA = '" + retorno.ToString() + "'";
                FbDataAdapter os = new FbDataAdapter();
                os.SelectCommand = select;
                DataSet dsOs = new DataSet();
                os.Fill(dsOs);
                fbConnection1.Close();
                foreach (DataRow dr in dsOs.Tables[0].Rows)
                {
                    return true;
                }
                return false;
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return false;
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
            inserir_semanas();
            
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
                    "INSERT INTO AGENDA_OS (OS_AGENDA_OS, CLIENTE_AGENDA_OS, DESCRICAO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS, TIPO_OCORRENCIA_AGENDA_OS, FINALIZADO_AGENDA_OS, POSICAO_AGENDA_OS, OBSERVACAO_AGENDA_OS)" +
                    "VALUES ('" + tb_os.Text + "','" + tb_cliente.Text + "','" + tb_descricao.Text + "','" + Convert.ToDateTime(dtData_agenda.Text).ToShortDateString().Replace("/",".") + "','" + Convert.ToDateTime(dtHora_agenda.Text).ToShortTimeString() + "','" + cbtipo_ocorrencia.Text + "','0', '" + tb_posicao.Text + "','" + tb_ocorrencia.Text + "')";
            this.fbConnection1.Open();
            this.datAgenda_os.InsertCommand.Connection = fbConnection1;
            this.datAgenda_os.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            dsAgenda_os.Clear();

            this.datAgenda_os.SelectCommand.CommandText =
            "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' AND POSICAO_AGENDA_OS = '" + tb_posicao.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
            this.fbConnection1.Open();
            this.datAgenda_os.SelectCommand.Connection = fbConnection1;
            this.datAgenda_os.SelectCommand.ExecuteNonQuery();
            datAgenda_os.Fill(AGENDA_OS);
            this.fbConnection1.Close();
            tb_descricao.Text = "";
            cbtipo_ocorrencia.Text = "";
            tb_ocorrencia.Text = "";
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

        private void tb_os_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                abrir_os();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalizar_posicoes()
        {
            if (DialogResult.Yes == MessageBox.Show("A(s) posição(ões) e suas operações serão finalizados, tem certeza?",
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
                        try
                        {
                            string cod_op = tb_codigo_op.Text;
                            if (cod_op == "")
                            {
                                FbCommand update_desenho = new FbCommand();
                                update_desenho.Connection = fbConnection1;
                                fbConnection1.Open();
                                update_desenho.CommandText =
                                    "UPDATE DESENHOS SET FINALIZADA_PECA = '1' WHERE N_OS_PECA = '" + tb_os.Text + "'";
                                FbDataAdapter datUpdate_desenho = new FbDataAdapter();
                                datUpdate_desenho.UpdateCommand = update_desenho;
                                datUpdate_desenho.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }

                            finalizar_todas_ops_da_os(tb_os.Text, cod_op);
                            apagar_todos_apontamentos_os(tb_os.Text, cod_op);

                            string where = "";
                            if (cod_op != "")
                                where = " AND COD_OP = '" + cod_op + "'";

                            FbCommand select_op = new FbCommand();
                            select_op.Connection = fbConnection1;
                            fbConnection1.Open();
                            select_op.CommandText =
                                "SELECT COD_OP FROM OP WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "' " + where;
                            FbDataAdapter datOp = new FbDataAdapter();
                            datOp.SelectCommand = select_op;
                            DataSet dsOp = new DataSet();
                            datOp.Fill(dsOp);
                            fbConnection1.Close();
                            foreach (DataRow dr_op in dsOp.Tables[0].Rows)
                            {
                                try
                                {
                                    FbCommand select_rotas = new FbCommand();
                                    select_rotas.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    select_rotas.CommandText =
                                        "SELECT COD_ROTA_CAMPO FROM ROTAS_CAMPO WHERE OP_ROTA = '" + dr_op[0].ToString() + "' ";
                                    FbDataAdapter datRotas = new FbDataAdapter();
                                    datRotas.SelectCommand = select_rotas;
                                    DataSet dsRotas = new DataSet();
                                    datRotas.Fill(dsRotas);
                                    fbConnection1.Close();
                                    foreach (DataRow dr_rotas in dsRotas.Tables[0].Rows)
                                    {
                                        DateTime data_fim = DateTime.Now;
                                        DateTime hora_fim = DateTime.Now;
                                        DateTime data_inicio = DateTime.Now;
                                        DateTime hora_inicio = DateTime.Now;
                                        buscar_data_hora_fechamento_no_ultimo_apontamento(dr_rotas[0].ToString(), dr_op[0].ToString(),
                                            out data_fim, out hora_fim, out data_inicio, out hora_inicio);

                                        FbCommand update_rota = new FbCommand();
                                        update_rota.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        update_rota.CommandText =
                                            "UPDATE ROTAS_CAMPO SET HORA_FECHAMENTO = '" + hora_fim.ToShortTimeString() + "', " +
                                            "DATA_FECHAMENTO = '" + data_fim.ToShortDateString().Replace("/", ".") + "', " +
                                            "HORA_ENTRADA = '" + hora_inicio.ToShortTimeString() + "', " +
                                            "DATA_ENTRADA = '" + data_inicio.ToShortDateString().Replace("/", ".") + "', " +
                                            "POSICAO_ATUAL = 'FINALIZADO', OBSERVACAO_CAMPO = OBSERVACAO_CAMPO || ' MODIFICADO PELA FINALIZAÇÃO DE OS' " +
                                            "WHERE COD_ROTA_CAMPO = '" + dr_rotas[0].ToString() + "' AND " +
                                            "(DATA_FECHAMENTO IS NULL OR POSICAO_ATUAL = 'NÃO NECESSÁRIA')";
                                        datRotas.UpdateCommand = update_rota;
                                        datRotas.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();

                                        FbCommand update_semana = new FbCommand();
                                        update_semana.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        update_semana.CommandText =
                                            "UPDATE HORAS_SEMANA SET SITUACAO_ROTA_SEMANA = 'FINALIZADO'" +
                                            " WHERE ROTA_HORAS_SEMANA = '" + dr_rotas[0].ToString() + "'";
                                        FbDataAdapter datUpdate_semana = new FbDataAdapter();
                                        datUpdate_semana.UpdateCommand = update_semana;
                                        datUpdate_semana.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();

                                        FbCommand update = new FbCommand();
                                        update.Connection = fbConnection1;
                                        fbConnection1.Open();
                                        update.CommandText =
                                            "UPDATE HORAS_SEMANA SET DATA_EXCLUSAO_SEMANA = '" +
                                            DateTime.Now.ToShortDateString().Replace("/", ".") +
                                            "', EXCLUIDO_ONDE_SEMANA = 'FECHAMENTO OS' WHERE ROTA_HORAS_SEMANA = '" +
                                            dr_rotas[0].ToString() +
                                            "' AND (HORAS_REAIS_OPERACAO IS NULL OR HORAS_REAIS_OPERACAO = 0) " +
                                            "AND DATA_EXCLUSAO_SEMANA IS NULL";
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
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.ToString());
                        }
                    }
                }
            }
        }

        private void finalizar_todas_ops_da_os(string os, string cod_op)
        {
            try
            {
                string where = "";
                if (cod_op != "")
                    where = " AND COD_OP = '" + cod_op + "'";

                FbCommand update_os = new FbCommand();
                update_os.Connection = fbConnection1;
                fbConnection1.Open();
                update_os.CommandText =
                    "UPDATE OP SET POSICAO_ATUAL_OP = 'ITEM_FINALIZADO', FINALIZADO_OP = '1' " +
                " WHERE (FINALIZADO_OP IS NULL OR FINALIZADO_OP = 0) AND DESENHO_OP_ATUAL = '" + os + "' " + where;
                FbDataAdapter datOs = new FbDataAdapter();
                datOs.UpdateCommand = update_os;
                datOs.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_data_hora_fechamento_no_ultimo_apontamento(string rota, string cod_op,
            out DateTime data_fim, out DateTime hora_fim,
            out DateTime data_inicio, out DateTime hora_inicio)
        {
            data_fim = DateTime.Now;
            hora_fim = DateTime.Now;
            data_inicio = DateTime.Now;
            hora_inicio = DateTime.Now;
            try
            {
                //PEGANDO INICIO
                FbCommand select_inicio = new FbCommand();
                select_inicio.Connection = fbConnection1;
                fbConnection1.Open();
                select_inicio.CommandText =
                    "SELECT DATA_INICIO_AP, HORA_INICIO_AP FROM APONTAMENTOS WHERE ROTA_AP = '" + rota + "' ORDER BY 1,2";
                FbDataAdapter datInicio = new FbDataAdapter();
                datInicio.SelectCommand = select_inicio;
                DataSet dsInicio = new DataSet();
                datInicio.Fill(dsInicio);
                fbConnection1.Close();
                foreach (DataRow dr_inicio in dsInicio.Tables[0].Rows)
                {
                    try
                    {
                        data_inicio = Convert.ToDateTime(dr_inicio[0].ToString());
                        hora_inicio = Convert.ToDateTime(dr_inicio[1].ToString());
                        break;
                    }
                    catch { }
                }
                if (dsInicio.Tables[0].Rows.Count == 0)
                { //SE NÃO TIVER APONTAMENTO IRÁ PEGAR A DATA DE FECHAMENTO PREVISTO DA OP COMO DATA DE FECHAMENTO
                    FbCommand select_op_inicio = new FbCommand();
                    select_op_inicio.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_op_inicio.CommandText =
                        "SELECT DATA_ENTRADA_OP FROM OP WHERE COD_OP = '" + cod_op + "'";
                    FbDataAdapter datTabela_op_inicio = new FbDataAdapter();
                    datTabela_op_inicio.SelectCommand = select_op_inicio;
                    DataSet dsTabela_op_inicio = new DataSet();
                    datTabela_op_inicio.Fill(dsTabela_op_inicio);
                    fbConnection1.Close();
                    foreach (DataRow dr_op_inicio in dsTabela_op_inicio.Tables[0].Rows)
                    {
                        try
                        {
                            data_fim = Convert.ToDateTime(dr_op_inicio[0].ToString());
                            hora_fim = Convert.ToDateTime("00:00:00");
                        }
                        catch
                        {
                            data_fim = DateTime.Now;
                            hora_fim = Convert.ToDateTime("00:00:00");

                        }
                    }
                }
                //PEGANDO FINALIZACAO
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT DATA_FIM_AP, HORA_FIM_AP FROM APONTAMENTOS WHERE ROTA_AP = '" + rota + "' ORDER BY 1,2 DESC";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    try
                    {
                        data_fim = Convert.ToDateTime(dr[0].ToString());
                        hora_fim = Convert.ToDateTime(dr[1].ToString());
                        break;
                    }
                    catch { }
                }
                if (dsTabela.Tables[0].Rows.Count == 0)
                { //SE NÃO TIVER APONTAMENTO IRÁ PEGAR A DATA DE FECHAMENTO PREVISTO DA OP COMO DATA DE FECHAMENTO
                    FbCommand select_op = new FbCommand();
                    select_op.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_op.CommandText =
                        "SELECT ENTREGA_DIA FROM OP WHERE COD_OP = '" + cod_op + "'";
                    FbDataAdapter datTabela_op = new FbDataAdapter();
                    datTabela_op.SelectCommand = select_op;
                    DataSet dsTabela_op = new DataSet();
                    datTabela_op.Fill(dsTabela_op);
                    fbConnection1.Close();
                    foreach (DataRow dr_op in dsTabela_op.Tables[0].Rows)
                    {
                        try
                        {
                            data_fim = Convert.ToDateTime(dr_op[0].ToString());
                            hora_fim = Convert.ToDateTime("00:00:00");
                        }
                        catch
                        {
                            data_fim = DateTime.Now;
                            hora_fim = Convert.ToDateTime("00:00:00");

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

        private void apagar_todos_apontamentos_os(string os, string cod_op)
        {
            try
            {
                string where = "";
                if (cod_op != "")
                    where = " AND OS_AP = '" + cod_op + "'";

                FbCommand delete = new FbCommand();
                delete.Connection = fbConnection1;
                fbConnection1.Open();
                delete.CommandText =
                    "DELETE FROM APONTAMENTOS WHERE DATA_FIM_AP IS NULL AND DESENHO_AP = '" + os + "' " + where;
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.DeleteCommand = delete;
                datTabela.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_rotas(string cod_op)
        {
            string retorno = "não existe";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_ROTA_CAMPO FROM ROTAS_CAMPO WHERE OP_ROTA = '" + cod_op + "' ORDER BY COD_ROTA_CAMPO";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                bool primeiro = true;
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    if (primeiro)
                    {
                        retorno = " AND (ROTA_AP = '" + dr[0].ToString() + "' ";
                        primeiro = false;
                    }
                    else
                    {
                        retorno = retorno + " OR ROTA_AP = '" + dr[0].ToString() + "'";
                    }
                }
                if (!primeiro)
                    retorno = retorno + ")";
                return retorno;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (cb_finalizado.Checked == false && tb_codigo_op.Text != "")
            {
                update_valor_hora();
                update_rotas_em_branco();
                tb_posicao_atual.Text = "ITEM FINALIZADO";
                cb_finalizado.Checked = true;
                DateTime entrega = new DateTime();
                entrega = DateTime.Now;
                //tb_data_entrega_pos.Text = entrega.ToShortDateString();
                tb_data_saida.Text = entrega.ToShortDateString();
                finalizar_posicoes();
            }


            
        }

        private void update_rotas_em_branco()
        {
            for(int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                double saldo = 0;
                try{saldo = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString());}
                catch{}
                if (saldo == 0)
                {
                    datRotas_campo.UpdateCommand.CommandText =
                            "UPDATE ROTAS_CAMPO SET POSICAO_ATUAL = 'NÃO NECESSÁRIA' " +
                            "WHERE COD_ROTA_CAMPO = '" + dgvRotas_campo.Rows[i].Cells["col_cod"].Value.ToString() + "'";
                    fbConnection1.Open();
                    datRotas_campo.UpdateCommand.Connection = fbConnection1;
                    datRotas_campo.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }

            }
        }

        private void update_valor_hora()
        {
            try
            {
                string fresa, retifica, retifica_optica, edm, torno, ewc_010, ewc_025, cnc, bancada, beneficiamento,
                    venda, prestacao_servico, retrabalho;
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
                fbConnection1.Open();
                FbDataAdapter clientesDataAdapter = new FbDataAdapter();
                clientesDataAdapter.SelectCommand = select;
                DataSet clientesDataSet = new DataSet();
                clientesDataAdapter.Fill(clientesDataSet);
                fbConnection1.Close();
                DataRow dr = clientesDataSet.Tables[0].Rows[0];
                fresa = dr["VALOR_FRESA_CLIENTE"].ToString();
                retifica = dr["VALOR_RETIFICA_CLIENTE"].ToString();
                retifica_optica = dr["VALOR_RETIFICA_OPTICA_CLIENTE"].ToString();
                edm = dr["VALOR_EDM_CLIENTE"].ToString();
                torno = dr["VALOR_TORNO_CLIENTE"].ToString();
                ewc_010 = dr["VALOR_EWC_CLIENTE"].ToString();
                ewc_025 = dr["VALOR_EWC015_CLIENTE"].ToString();
                cnc = dr["VALOR_CNC_CLIENTE"].ToString();
                bancada = dr["VALOR_BANCADA_CLIENTE"].ToString();
                beneficiamento = dr["PORC_BENEFICIAMENTO_CLIENTE"].ToString();
                venda = dr["PORC_VENDA_CLIENTE"].ToString();
                prestacao_servico = dr["PORC_PRESTACAO_SERV_CLIENTE"].ToString();
                retrabalho = dr["PORC_RETRABALHO_CLIENTE"].ToString();

                double impostos = 1;

                if (beneficiamento != "" && beneficiamento != "0")
                    impostos = 1 + Convert.ToDouble(beneficiamento)/100;
                else
                    if (venda != "" && venda != "0")
                        impostos = 1 + Convert.ToDouble(venda)/100;
                    else
                        if (prestacao_servico != "" && prestacao_servico != "0")
                            impostos = 1 + Convert.ToDouble(prestacao_servico)/100;
                        else
                            if (retrabalho != "" && retrabalho != "0")
                                impostos = 1 + Convert.ToDouble(retrabalho)/100;
                for (int i = 0; i < dgvRotas_campo.RowCount; i++)
                {
                    try
                    {
                        double valor_total = 0, valor_total_orc = 0;
                        string valor_hora = "null";
                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "Fresa")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(fresa) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString())* impostos;
                                valor_hora = "'" + fresa.Replace("'","") + "'";
                                valor_total_orc = Convert.ToDouble(fresa) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                        }
                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "Retífica")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(retifica) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString()) * impostos;
                                valor_hora = "'" + retifica.Replace("'", "") + "'";
                                valor_total_orc = Convert.ToDouble(retifica) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                        }

                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "Retífica Optica")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(retifica_optica) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString()) * impostos;
                                valor_hora = "'" + retifica_optica.Replace("'", "") + "'";
                                valor_total_orc = Convert.ToDouble(retifica_optica) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                           
                        }

                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "Erosão (EDM)")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(edm) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString()) * impostos;
                                valor_hora = "'" + edm.Replace("'", "") + "'";
                                valor_total_orc = Convert.ToDouble(edm) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                        }
                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "Torno")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(torno) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString()) * impostos;
                                valor_hora = "'" + torno.Replace("'", "") + "'"; 
                                valor_total_orc = Convert.ToDouble(torno) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                        }
                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "Erosão (EWC)")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(ewc_010) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString()) * impostos;
                                valor_hora = "'" + ewc_010.Replace("'", "") + "'";
                                valor_total_orc = Convert.ToDouble(ewc_010) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                        }
                        /*
                        if (ewc_010 == "")
                            ewc_010 = "null";
                        else
                            ewc_010 = "'" + ewc_010 + "'";
                        if (ewc_025 == "")
                            ewc_025 = "null";
                        else
                            ewc_025 = "'" + ewc_025 + "'";
                         * */
                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "CNC (Acab.)" ||
                            dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "CNC (Desbaste)")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(cnc) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString()) * impostos;
                                valor_hora = "'" + cnc.Replace("'", "") + "'";
                                valor_total_orc = Convert.ToDouble(cnc) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                        }

                        if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString() == "Bancada")
                        {
                            try
                            {
                                valor_total = Convert.ToDouble(bancada) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_saldo_horas"].Value.ToString()) * impostos;
                                valor_hora = "'" + bancada.Replace("'", "") + "'";
                                valor_total_orc = Convert.ToDouble(bancada) * Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) * impostos;
                            }
                            catch { valor_total = 0; valor_total_orc = 0; valor_hora = "null"; }
                        }

                        datRotas_campo.UpdateCommand.CommandText =
                            "UPDATE ROTAS_CAMPO SET VALOR_HORA_ROTA = " + valor_hora.Replace(".", "").Replace(",", ".") + "," +
                            "VALOR_TOTAL_ORC_ROTA = '" + valor_total_orc.ToString("n2").Replace(".", "").Replace(",", ".") + "'," +
                            "VALOR_TOTAL_ROTA = '" + valor_total.ToString("n2").Replace(".", "").Replace(",", ".") + "' " +
                            "WHERE COD_ROTA_CAMPO = '" + dgvRotas_campo.Rows[i].Cells["col_cod"].Value.ToString() + "'";
                        fbConnection1.Open();
                        datRotas_campo.UpdateCommand.Connection = fbConnection1;
                        datRotas_campo.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch {
                        fbConnection1.Close();
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            comando_select.CommandText = "SELECT *" +
                " FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_os.Text + //"" + 
                "' ORDER BY COND_PGTO";
            DataSet posicoes = new DataSet();
            fbConnection1.Open();
            datOp.SelectCommand = comando_select;
            fbConnection1.Close();
            //datOp.Fill(posicoes);    
                dsConsulta imprime_os = new dsConsulta();
                fbConnection1.Open();
                datDesenhos.Fill(imprime_os.DESENHOS);
                datOp.Fill(imprime_os.OP);
                fbConnection1.Close();
                crFicha_os ficha_nova = new crFicha_os();
                ficha_nova.SetDataSource(imprime_os);
                //ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                //ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(ficha_nova);
                imprimir.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            localiza_os();
            tb_horas_previstas_restantes.Text = buscar_horas_previstas_restantes(tb_os.Text);
        }
        
        private void localiza_os()
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
                if (nova_os != null)
                {
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
                        codOsSistema = DESENHOS.Rows[0]["cod_peca"].ToString();

                        dsOp.Clear();
                        comando_select.CommandText = "SELECT COND_PGTO, DESCRICAO_FERRAMENTA_OP, N_PDF, COD_OP" +
                        " FROM OP WHERE DESENHO_OP_ATUAL LIKE '" + tb_os.Text + //"" + 
                        "' ORDER BY COND_PGTO";
                        DataSet posicoes = new DataSet();
                        fbConnection1.Open();
                        datOp.SelectCommand = comando_select;

                        datOp.Fill(posicoes);


                        dgvPosicoes.DataSource = posicoes;
                        dgvPosicoes.DataMember = posicoes.Tables[0].TableName;
                        dgvPosicoes.Columns[0].Width = 60;
                        dgvPosicoes.Columns[1].Width = 60;
                        fbConnection1.Close();


                        dsAgenda_os.Clear();
                        /*
                        this.datAgenda_os.SelectCommand.CommandText =
                        "SELECT * FROM AGENDA_OS WHERE OS_AGENDA_OS = '" + tb_os.Text + "' ORDER BY FINALIZADO_AGENDA_OS, DATA_AGENDA_OS, HORA_AGENDA_OS";
                        this.fbConnection1.Open();
                        this.datAgenda_os.SelectCommand.Connection = fbConnection1;
                        this.datAgenda_os.SelectCommand.ExecuteNonQuery();
                        datAgenda_os.Fill(AGENDA_OS);
                        this.fbConnection1.Close();
                         * */
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            form_pesquisa_ferramenta fer = new form_pesquisa_ferramenta();
            try
            {
                fer.ferramenta_escolhida = tb_ferramenta.Text;
                fer.item_escolhido = tb_codigo_peca.Text;
                fer.ShowDialog();
            }
            finally
            {
                fer.Dispose();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*
            form_ocorrencia_tecnica ot = new form_ocorrencia_tecnica();
            try
            {
                ot.nova_ot = true;
                ot.codigo_pos = tb_codigo_op.Text;
                ot.ferramenta = tb_ferramenta.Text;
                ot.os = tb_peca.Text;
                ot.posicao = tb_posicao.Text;
                ot.ShowDialog();


            }
            finally
            {
                ot.Dispose();
                dsOt.Clear();
                datOt.Fill(OCORRENCIA_TECNICA);
            }
             * */
        }

        private void dgvOt_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            form_ocorrencia_tecnica ot = new  form_ocorrencia_tecnica();
            try
            {
                ot.abrir_ot = true;
                ot.ot_a_abrir = dgvOt.Rows[e.RowIndex].Cells["col_cod_ot"].Value.ToString();
                ot.ShowDialog();
            }
            finally
            {
                ot.Dispose();
                datOt.Fill(OCORRENCIA_TECNICA);
            }
             * */
        }

        private void button14_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                
                tb_cliente.Text = localiza_cliente.cliente_escolhido;

                

            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            form_tipo_ocorrencia tipo = new form_tipo_ocorrencia();
            try
            {
                tipo.ShowDialog();
            }
            finally
            {
                cbtipo_ocorrencia.Text = tipo.ocorrencia_escolhida;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                try
                {
                    this.datDesenhos.DeleteCommand.CommandText =
                        "DELETE FROM DESENHOS WHERE N_OS_PECA = '" + tb_os.Text + "'";
                    this.fbConnection1.Open();
                    this.datDesenhos.DeleteCommand.Connection = fbConnection1;
                    this.datDesenhos.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    localiza_os();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }


        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            form_pesquisa_orcamentos peca = new form_pesquisa_orcamentos();
            try
            {
                peca.ShowDialog();
            }
            finally
            {
                if (peca._cod_escolhido == null)
                {
                    peca._cod_escolhido = "";
                }
                buscar_item_orc(peca._cod_escolhido);
            }


        }

        private void buscar_item_orc(string cod)
        {
            if (cod != "")
            {
                try
                {
                   
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT COD_ITEM_ORC, MATERIAL_ITEM_ORC, QTDE_ITEM_ORC, VALOR_UNIT_ITEM_ORC FROM ITENS_ORCAMENTO" +
                        " WHERE COD_ITEM_ORC = '" + cod + "'";
                    FbDataAdapter datItens_orc = new FbDataAdapter();
                    datItens_orc.SelectCommand = select;
                    DataSet dsItens_orc = new DataSet();
                    datItens_orc.Fill(dsItens_orc);
                    fbConnection1.Close();
                    foreach (DataRow dr in dsItens_orc.Tables[0].Rows)
                    {
                        tb_nova_pos.Text = dr[1].ToString();
                        tb_item_orc_novo.Text = dr[0].ToString();
                        tb_qtde_nova.Text = dr[2].ToString();
                        tb_valor_novo.Text = dr[3].ToString();
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FbCommand select_op = new FbCommand();
            select_op.Connection = fbConnection1;
            fbConnection1.Open();
            select_op.CommandText =
                "SELECT * FROM OP WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "'";
            FbDataAdapter opDataAdapter = new FbDataAdapter();
            opDataAdapter.SelectCommand = select_op;
            fbConnection1.Close();
            
            FbCommand select_cliente = new FbCommand();
            select_cliente.Connection = fbConnection1;
            fbConnection1.Open();
            select_cliente.CommandText =
                "SELECT * FROM CLIENTES WHERE RAZAO_SOCIAL = '" + tb_cliente.Text + "'";
            FbDataAdapter clientesDataAdapter = new FbDataAdapter();
            clientesDataAdapter.SelectCommand = select_cliente;
            fbConnection1.Close();
            

           

            dsRomaneio imprime_os = new dsRomaneio();
            fbConnection1.Open();
            opDataAdapter.Fill(imprime_os.OP);
            clientesDataAdapter.Fill(imprime_os.CLIENTES);
            
            datDesenhos.Fill(imprime_os.DESENHOS);
            fbConnection1.Close();
            crRomaneio ficha_nova = new crRomaneio();
            ficha_nova.SetDataSource(imprime_os);
            ficha_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            ficha_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
            form_imprimir imprimir = new form_imprimir(ficha_nova);
            imprimir.Show();
        }

        

        private void button15_Click(object sender, EventArgs e)
        {
            if (dgvRotas_campo.SelectedRows.Count == 1)
            {
                form_rotas_X rota = new form_rotas_X();
                rota.rota = dgvRotas_campo.SelectedRows[0].Cells[0].Value.ToString();
                rota.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma rota por favor");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            form_pesquisa_peca peca = new form_pesquisa_peca();
            try
            {
                peca._os = true;
                peca.ShowDialog();
            }
            finally
            {
                tb_nova_pos_2.Text = peca.cod_desenho;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //if (tb_data_abertura.Text != "")
            //{
                    dsOp.Clear();
                    criar_pos(tb_os.Text, tb_nova_pos_2.Text, "");
                    tb_data_entrada_pos.Text = DateTime.Now.ToShortDateString();
                    tb_data_entrega_pos.Text = tb_prazo_entrega_os.Text;
                    tb_data_cadastro.Text = DateTime.Now.ToShortDateString();
                    acertar_horas_com_qtde();
                    Atualizar();
                    selecinar_posicoes();
            //}
            //else
            //{
            //    MessageBox.Show("Digite uma data de abertura para a OS.");
            //}
        }

        private void button18_Click(object sender, EventArgs e)
        {
            form_busca_item_estoque_mp localiza_item = new form_busca_item_estoque_mp(cnpj_empresa);
            try
            {
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_escolhido != "")
                    puxar_informacoes(localiza_item.cod_escolhido);
            }
        }
        private void puxar_informacoes(string cod)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT ITEM_ESTOQUE, DESCRICAO_ESTOQUE, ESPESSURA_ESTOQUE FROM ESTOQUE WHERE COD_ESTOQUE = '" + cod + "'";
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataSet dsEstoque = new DataSet();
                datEstoque.Fill(dsEstoque);
                fbConnection1.Close();
                foreach (DataRow dr in dsEstoque.Tables[0].Rows)
                {
                    tb_cod_mat.Text = cod;
                    tb_material.Text = dr[0].ToString();
                    if (dr[1].ToString() != "")
                        tb_material.Text = tb_material.Text + " " + dr[1].ToString();
                    tb_espessura.Text = dr[2].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }



        private void button19_Click(object sender, EventArgs e)
        {
            form_grupo_produto conj = new form_grupo_produto();
            //form_conjunto_peca conj = new form_conjunto_peca();
            try
            {
                conj.ShowDialog();
            }
            finally
            {
                tb_funcao.Text = conj.descricao;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data_inicial = Convert.ToDateTime(tb_data_entrada_pos.Text);

                for (int i = 0; i < dgvRotas_campo.RowCount; i++)
                {
                    int ordem_operacao_tipo_posterior = 0;
                    try
                    {
                        ordem_operacao_tipo_posterior = buscar_ordem_atual(dgvRotas_campo.Rows[i + 1].Cells["col_operacao"].Value.ToString());
                    }
                    catch { }
                    int ordem_operacao_tipo_atual = buscar_ordem_atual(dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString());
                    DateTime data_final = data_inicial.AddDays(Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()));
                    dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value = data_inicial.ToShortDateString();
                    dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value = data_final.ToShortDateString();
                    if (ordem_operacao_tipo_atual < ordem_operacao_tipo_posterior)
                    {
                        data_inicial = data_final.AddDays(1);
                    }
                    //"DATA_ENTRADA_PREV"; "DATA_FECHAMENTO_PREV";
                }
            }
            catch { }

            ////acertar_horas_x_qtde();
            //int prazo_em_dias = -1;
            //try
            //{
            //    //buscando dias uteis disponiveis
            //    prazo_em_dias = prazo_em_dias_sem_finais_semana(Convert.ToDateTime(tb_data_entrada_pos.Text),
            //        Convert.ToDateTime(tb_data_entrega_pos.Text));
            //}
            //catch { }
            //double total_horas_posicao = somar_horas_posicao();
            //if (prazo_em_dias > -1)
            //{
                
            //                        DateTime data_inicial = Convert.ToDateTime(tb_data_entrada_pos.Text);
            //        DateTime data_final = Convert.ToDateTime(tb_data_entrada_pos.Text);
            //        for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            //        {
            //            try
            //            {

            //                double qtde_dias_operacao = 0;
            //                qtde_dias_operacao = (prazo_em_dias *
            //                    Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString()) /
            //                    total_horas_posicao);
            //                while (data_inicial.DayOfWeek == DayOfWeek.Saturday ||
            //                    data_inicial.DayOfWeek == DayOfWeek.Sunday)
            //                    data_inicial = data_inicial.AddHours(24);
            //                dgvRotas_campo.Rows[i].Cells["DATA_ENTRADA_PREV"].Value = data_inicial.ToShortDateString();
            //                //int _qtde_int = buscar_inteiro(qtde_dias_operacao);
            //                double resto_das_horas = qtde_dias_operacao % 24;
            //                qtde_dias_operacao = qtde_dias_operacao - resto_das_horas;
            //                double dias = qtde_dias_operacao / 24;
            //                data_final = data_inicial;
            //                for (int j = 0; j < dias; j++)
            //                {
            //                    data_final = data_final.AddHours(24);
            //                    while (data_final.DayOfWeek == DayOfWeek.Saturday ||
            //                   data_final.DayOfWeek == DayOfWeek.Sunday)
            //                        data_final = data_final.AddHours(24);
            //                }
            //                data_final = data_final.AddHours(resto_das_horas);
            //                while (data_final.DayOfWeek == DayOfWeek.Saturday ||
            //                   data_final.DayOfWeek == DayOfWeek.Sunday)
            //                    data_final = data_final.AddHours(24);
            //                dgvRotas_campo.Rows[i].Cells["DATA_FECHAMENTO_PREV"].Value = data_final.ToShortDateString();
            //                data_inicial = data_final;//.AddHours(24);
            //            }
            //            catch { }

            //        }
            //    int linha_tratamento = 0;
            //    if (existe_tratamento_termico(out linha_tratamento))
            //    {
            //        try
            //        {
            //            //DIA FECHAMENTO OPERACAO ANTERIOR - 1
            //            if (Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento - 1].Cells["DATA_FECHAMENTO_PREV"].Value.ToString()) !=
            //                Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento - 1].Cells["DATA_ENTRADA_PREV"].Value.ToString()))
            //            {
            //                dgvRotas_campo.Rows[linha_tratamento - 1].Cells["DATA_FECHAMENTO_PREV"].Value =
            //                    Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento - 1].Cells["DATA_FECHAMENTO_PREV"].Value.ToString()).AddDays(-1).ToShortDateString();
            //                dgvRotas_campo.Rows[linha_tratamento].Cells["DATA_ENTRADA_PREV"].Value =
            //                    Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento].Cells["DATA_ENTRADA_PREV"].Value.ToString()).AddDays(-1).ToShortDateString();
            //            }
            //            //DIA ABERTURA OPERACAO ANTERIOR + 1
            //            if (Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento + 1].Cells["DATA_FECHAMENTO_PREV"].Value.ToString()) !=
            //                Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento + 1].Cells["DATA_ENTRADA_PREV"].Value.ToString()))
            //            {
            //                dgvRotas_campo.Rows[linha_tratamento + 1].Cells["DATA_ENTRADA_PREV"].Value =
            //                    Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento + 1].Cells["DATA_ENTRADA_PREV"].Value.ToString()).AddDays(1).ToShortDateString();
            //                dgvRotas_campo.Rows[linha_tratamento].Cells["DATA_FECHAMENTO_PREV"].Value =
            //                    Convert.ToDateTime(dgvRotas_campo.Rows[linha_tratamento].Cells["DATA_FECHAMENTO_PREV"].Value.ToString()).AddDays(1).ToShortDateString();
            //            }
            //            //2 DIAS PARA O TRATAMENTO
                        
                       


            //        }
            //        catch { }
            //    }
                
               
            //}
        }

        private int buscar_ordem_atual(string operacao)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                     "SELECT ORDEM_OPERACAO_TIPO FROM TIPOS_OPERACOES WHERE TIPO =  '" + operacao + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return Convert.ToInt16(dr[0].ToString());
                }
                return 0;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Operação sem ordem cadastrada");
                return 0;
            }
        }

        private bool existe_tratamento_termico(out int linha_tratamento)
        {
            linha_tratamento = 1000;
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                if (dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString().Contains("Tratamento"))
                {
                    linha_tratamento = i;
                    //return true;
                    return true;
                }
            }
            return false;
        }

        private void acertar_horas_x_qtde()
        {
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                double valor_unit = 0;
                double valor_total = 0;
                double qtde = 0;
                try
                {
                    valor_unit = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString());
                }
                catch { }
                try
                {
                    qtde = Convert.ToDouble(tb_qtde_fab.Text);
                }
                catch 
                {
                    MessageBox.Show("Digite a Quantidade a fabricar");
                }
                try
                {
                    valor_total = valor_unit * qtde;
                    dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value = valor_total.ToString("n2");
                }
                catch { }

            }
            Atualizar();
        }

        private int buscar_inteiro(double qtde_dias_operacao)
        {
            string _qtde = qtde_dias_operacao.ToString();
            int i = 0;
            string retorno = "";
            while (_qtde[i].ToString() != ",")
            {
                retorno = retorno + _qtde[i];
                i++;
            }
            return Convert.ToInt32(retorno);
        }

        private double somar_horas_posicao()
        {
            double horas = 0;
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                try
                {
                    horas = horas + Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value.ToString());
                }
                catch { }
            }
            return horas;
        }

        private int prazo_em_dias_sem_finais_semana(DateTime entrada, DateTime entrega)
        {
            try
            {
                DateTime dia_corrente = entrada;
                int dias = 0;
                for (int i = 0; dia_corrente < entrega; i++)
                {
                    if (dia_corrente.DayOfWeek == DayOfWeek.Saturday ||
                        dia_corrente.DayOfWeek == DayOfWeek.Sunday)
                    {
                        dia_corrente = dia_corrente.AddHours(24);
                    }
                    else
                    {
                        dias = dias + 24;
                        dia_corrente = dia_corrente.AddHours(24);
                    }
                }
                //dias = dias;
                return dias;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return 0;
            }
        }

        private void tb_posicoes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                posicoes.DefaultView.RowFilter = "COND_PGTO LIKE '*" + tb_posicoes.Text + "*'";
                //dsNota_fiscal.Tables["NOTA_FISCAL"].DefaultView.RowFilter = "CLIENTE_FORN_NF Like '*" + tb_cliente_2.Text + "*'";
            }
            catch { }
        }

        private void dgvPosicoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsOp.Clear();
            dsRotas_campo.Clear();
            abre_pos(dgvPosicoes.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void bt_abrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string caminho;
            caminho = openFileDialog1.FileName;
            pb_desenho.ImageLocation = caminho;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            //acertar_horas_com_qtde();
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                string dias = buscar_dias(tb_funcao.Text, dgvRotas_campo.Rows[i].Cells["col_operacao"].Value.ToString());
                dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value = dias;
                dgvRotas_campo.Rows[i].Cells["col_previsao_unit"].Value = dias;


            }
        }

        private string buscar_dias(string funcao, string operacao)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                     "SELECT DIAS_PRAZO_GOP FROM GRUPOS_OPERACOES_PRAZO WHERE grupo_gop =  '" + funcao + "' AND OPERACAO_GOP = '" + operacao + "'";
                fbConnection1.Open();
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
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0";
            }
        }

        private void acertar_horas_com_qtde()
        {
            for (int i = 0; i < dgvRotas_campo.RowCount; i++)
            {
                try
                {
                    double horas_unit = 0;
                    double qtde = 0;
                    double horas_totais = 0;
                    horas_unit = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_previsao_unit"].Value.ToString());
                    qtde = Convert.ToDouble(dgvRotas_campo.Rows[i].Cells["col_qtde"].Value.ToString());
                    horas_totais = horas_unit * qtde;
                    dgvRotas_campo.Rows[i].Cells["col_horas_previstas"].Value = horas_totais.ToString("n2");
                }
                catch { }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //string caminho;
            tb_caminho.Text = openFileDialog1.FileName.Replace("openFileDialog1", "");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@tb_caminho.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            form_resumo_os os = new form_resumo_os();
            os._os = tb_os.Text;
            os.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //string caminho;
            tb_caminho_2.Text = openFileDialog1.FileName.Replace("openFileDialog1", ""); ;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@tb_caminho_2.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                string replica = "0";
                if (cbParalizada.Checked)
                    replica = "1";
                datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET PARALIZADA_OP = '" + replica + "' " +
                    "WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "'";
                fbConnection1.Open();
                datOp.UpdateCommand.Connection = fbConnection1;
                datOp.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void btnConogramaMolde_Click(object sender, EventArgs e)
        {
            //formCronogramaMolde cronogramaMolde = new formCronogramaMolde(tb_os.Text, codOsSistema);
            //cronogramaMolde.Show();
        }

        private void btnControleMolde_Click(object sender, EventArgs e)
        {
            //dsControleItemMolde dadosControleItensMolde = new dsControleItemMolde();
            //dadosControleItensMolde.Clear();

            //if (tb_os.Text != "")
            //{
            //    /*SELECIONAR OS DADOS DO MOLDE*/
            //    datDesenhos.Fill(dadosControleItensMolde.DESENHOS);

            //    /*SELECIONAR TODAS AS POSIÇÕES DO MOLDE ABERTO*/
            //    datOp.Fill(dadosControleItensMolde.OP);

            //    /*SELECIONAR TODAS AS OPERAÇÕES DE CADA POSIÇÃO DO MOLDE*/
            //    datRotas_campo.SelectCommand.CommandText = "SELECT * FROM rotas_campo WHERE desenho_campo = '" + tb_os.Text + "'";
            //    datRotas_campo.SelectCommand.Connection = fbConnection1;
            //    fbConnection1.Open();
            //    datRotas_campo.SelectCommand.ExecuteNonQuery();
            //    datRotas_campo.Fill(dadosControleItensMolde.ROTAS_CAMPO);
            //    fbConnection1.Close();

            //    /*ALIMENTAR O RELATÓRIO E PASSAR OS VALORES DOS PARÂMETROS*/
            //    crControleItensMolde controleItensMolde = new crControleItensMolde();
            //    controleItensMolde.SetDataSource(dadosControleItensMolde);
            //    controleItensMolde.SetParameterValue(controleItensMolde.Parameter_nomeCliente.ParameterFieldName.ToString(), tb_cliente.Text);
            //    controleItensMolde.SetParameterValue(controleItensMolde.Parameter_nomeMolde.ParameterFieldName.ToString(), txtNomePeca.Text);
            //    controleItensMolde.SetParameterValue(controleItensMolde.Parameter_codMolde.ParameterFieldName.ToString(), tb_os.Text);

            //    /*EXIBIR RELATATÓRIO PARA IMPRESSÃO*/
            //    form_imprimir imprimir = new form_imprimir(controleItensMolde);
            //    imprimir.Show();

            //}
            //else
            //{
            //    MessageBox.Show("É necessário abrir um molde para exibir o controle!");
            //}
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                dsStatus_os status = new dsStatus_os();
                datDesenhos.Fill(status.DESENHOS);
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                         "SELECT * FROM cronograma_molde WHERE cod_peca_cm = " + this.codOsSistema;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(status.CRONOGRAMA_MOLDE);
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
                    select.CommandText =
                         "SELECT * FROM OP WHERE DESENHO_OP_ATUAL = '" + tb_os.Text + "' ORDER BY COND_PGTO";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(status.OP);
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
                    select.CommandText =
                        "SELECT * FROM ROTAS_CAMPO r INNER JOIN OP o ON r.OP_ROTA = o.COD_OP WHERE o.DESENHO_OP_ATUAL = '" + tb_os.Text + "'";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(status.ROTAS_CAMPO);
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
                    select.CommandText =
                        "SELECT * FROM ITENS_TERCEIROS WHERE OS_ITEM_TERCEIRO = '" + tb_os.Text + "' AND DATA_ENTRADA_ITEM_TERCEIRO IS NOT NULL";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(status.ITENS_TERCEIROS);
                    fbConnection1.Close();
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

                crStatus op_nova = new crStatus();
                op_nova.SetDataSource(status);
                op_nova.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                op_nova.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto;
                form_imprimir imprimir = new form_imprimir(op_nova);
                imprimir.Show();



            }

            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            form_valor_operacao_os os = new form_valor_operacao_os();
            os._os = tb_os.Text;
            os.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //string caminho;
            tb_caminho_3.Text = openFileDialog1.FileName.Replace("openFileDialog1", "");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@tb_caminho_3.Text);
        }

        private void tb_os_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_ferramenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_nova_pos_2_TextChanged(object sender, EventArgs e)
        {

        }





    }
}