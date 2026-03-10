using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pesquisa_requisicao : Form
    {
        public string descricao_escolhido;
        public string cod_escolhido;
        public string cod_item_escolhido;
        public string qtde_escolhida;
        public string unid_escolhida;
        public string item_escolhido;
        public bool fazer_pedido_item;
        public string requisicao_escolhida;

        public string cod_usuario;
        string autorizante = "";
        public string cnpj_empresa;
        public form_pesquisa_requisicao(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dsItens_req.Clear();
                this.datItens_req.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_REQUISICAO ORDER BY COD_ITEM_REQ DESC";
                this.fbConnection1.Open();
                this.datItens_req.SelectCommand.Connection = fbConnection1;
                this.datItens_req.SelectCommand.ExecuteNonQuery();
                datItens_req.Fill(ITENS_REQUISICAO);
                this.fbConnection1.Close(); 
                arruma_cores();
            }
            catch
            {
                fbConnection1.Close(); 
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsItens_req.Clear();
            this.datItens_req.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_REQUISICAO WHERE AUTORIZADO_POR_ITEM_REQ IS NOT NULL ORDER BY COD_ITEM_REQ DESC";
            this.fbConnection1.Open();
            this.datItens_req.SelectCommand.Connection = fbConnection1;
            this.datItens_req.SelectCommand.ExecuteNonQuery();
            datItens_req.Fill(ITENS_REQUISICAO);
            this.fbConnection1.Close(); 
            arruma_cores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dsItens_req.Clear();
            this.datItens_req.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_REQUISICAO WHERE AUTORIZADO_POR_ITEM_REQ IS NULL ORDER BY COD_ITEM_REQ DESC";
            this.fbConnection1.Open();
            this.datItens_req.SelectCommand.Connection = fbConnection1;
            this.datItens_req.SelectCommand.ExecuteNonQuery();
            datItens_req.Fill(ITENS_REQUISICAO);
            this.fbConnection1.Close(); 
            arruma_cores();
        }

        private void arruma_cores()
        {
            for (int i = 0; i < dgvItens_requisicao.RowCount; i++)
            {
                if (dgvItens_requisicao.Rows[i].Cells["col_situacao"].Value.ToString() == "REQUISIÇÃO AUTORIZADA")
                    dgvItens_requisicao.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                if (dgvItens_requisicao.Rows[i].Cells["col_situacao"].Value.ToString() == "AGUARDANDO AUTORIZAÇÃO NO PEDIDO DE COMPRA")
                    dgvItens_requisicao.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;
                if (dgvItens_requisicao.Rows[i].Cells["col_situacao"].Value.ToString() == "PEDIDO DE COMPRA AUTORIZADO")
                    dgvItens_requisicao.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                if (dgvItens_requisicao.Rows[i].Cells["col_situacao"].Value.ToString() == "REQUISIÇÃO AGUARDANDO RESPOSTA")
                    dgvItens_requisicao.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (autorizante == "")
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
                        if (usuario._nivel_acesso_usuario == "1" || usuario._nivel_acesso_usuario == "2")
                        {
                            autorizante = usuario._nome_usuario;
                            for (int i = 0; i < dgvItens_requisicao.RowCount; i++)
                            {
                                if (dgvItens_requisicao.Rows[i].Cells["col_autorizante"].Value.ToString() == "")
                                    inserir_autorizacao(dgvItens_requisicao.Rows[i].Cells["col_cod"].Value.ToString(), autorizante);
                                else
                                    MessageBox.Show("Item já autorizado");
                            }
                            dsItens_req.Clear();
                            datItens_req.Fill(ITENS_REQUISICAO);
                        }
                            
                        
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }
                    }
                    

                }
            }
            else
            {
                for(int i = 0; i < dgvItens_requisicao.RowCount; i++)
                {
                    inserir_autorizacao(dgvItens_requisicao.Rows[i].Cells["col_cod"].Value.ToString(), autorizante);
                }
                dsItens_req.Clear();
                datItens_req.Fill(ITENS_REQUISICAO);
            }
        
            
            
        
        }

        private void dgvItens_requisicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_requisicao.Columns[e.ColumnIndex].Name == "Aut")
            {
                if (dgvItens_requisicao.Rows[e.RowIndex].Cells["col_autorizante"].Value.ToString() == "")
                {
                    if (autorizante == "")
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
                                if (usuario._nivel_acesso_usuario == "1" || usuario._nivel_acesso_usuario == "2")
                                {
                                    autorizante = usuario._nome_usuario;
                                    inserir_autorizacao(dgvItens_requisicao.Rows[e.RowIndex].Cells["col_cod"].Value.ToString(), autorizante);
                                    dsItens_req.Clear();
                                    datItens_req.Fill(ITENS_REQUISICAO);
                                }
                                else
                                {
                                    MessageBox.Show("Usuário não autorizado");
                                }
                            }

                        }
                    }
                    else
                    {
                        inserir_autorizacao(dgvItens_requisicao.Rows[e.RowIndex].Cells["col_cod"].Value.ToString(), autorizante);
                        dsItens_req.Clear();
                        datItens_req.Fill(ITENS_REQUISICAO);
                    }
                }
                else
                    MessageBox.Show("Item já autorizado");


            }
            if (dgvItens_requisicao.Columns[e.ColumnIndex].Name == "Ok")
            {
                if (fazer_pedido_item == true)
                {
                    if (dgvItens_requisicao.Rows[e.RowIndex].Cells["col_situacao"].Value.ToString() == "REQUISIÇÃO AUTORIZADA")
                    {
                        cod_item_escolhido = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_cod_estoque"].Value.ToString();
                        descricao_escolhido = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                        cod_escolhido = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
                        qtde_escolhida = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_qtde"].Value.ToString();
                        unid_escolhida = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_unid"].Value.ToString();
                        item_escolhido = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_item"].Value.ToString();
                        requisicao_escolhida = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_requisicao"].Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("SITUAÇÃO DA REQUISIÇÃO: " + dgvItens_requisicao.Rows[e.RowIndex].Cells["col_situacao"].Value.ToString());
                    }
                    
                  

                }

            }
        }
        private void inserir_autorizacao(string _cod, string _autorizante)
        {
            this.datItens_req.UpdateCommand.CommandText =
                            "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = 'REQUISIÇÃO AUTORIZADA' WHERE COD_ITEM_REQ = " + _cod + "";
            this.fbConnection1.Open();
            this.datItens_req.UpdateCommand.Connection = fbConnection1;
            this.datItens_req.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 

            this.datItens_req.UpdateCommand.CommandText =
                            "UPDATE ITENS_REQUISICAO SET AUTORIZADO_POR_ITEM_REQ = '" + _autorizante + "' WHERE COD_ITEM_REQ = " + _cod + "";
            this.fbConnection1.Open();
            this.datItens_req.UpdateCommand.Connection = fbConnection1;
            this.datItens_req.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
        }

        private void dgvItens_requisicao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!fazer_pedido_item)
            {
                string _cod_req = "";
                comando_select.CommandText = "SELECT * FROM ITENS_REQUISICAO WHERE COD_ITEM_REQ = '" + dgvItens_requisicao.Rows[e.RowIndex].Cells["col_cod"].Value.ToString() + "'";
                DataSet req = new DataSet();
                fbConnection1.Open();
                datItens_req.SelectCommand = comando_select;
                datItens_req.Fill(req);
                fbConnection1.Close(); 
                foreach (DataRow dr in req.Tables[0].Rows)
                {
                    _cod_req = dr["COD_REQ_ITEM_REQ"].ToString();
                }
                form_requisicao requisicao = new form_requisicao(cnpj_empresa);
                try
                {
                    requisicao.cod_usuario = cod_usuario;
                    requisicao.abrir_requisicao = true;
                    requisicao.n_requisicao = _cod_req;
                    requisicao.ShowDialog();
                }
                finally
                {
                    requisicao.Dispose();
                }
            }
            else
            {
                requisicao_escolhida = dgvItens_requisicao.Rows[e.RowIndex].Cells["col_requisicao"].Value.ToString();
                this.Close();
            }
        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsItens_req.Tables["ITENS_REQUISICAO"].DefaultView.RowFilter = "DESCRICAO_ITEM_REQ Like '*" + tb_item.Text + "*'";
            }
            catch { }
            
        }

        private void form_pesquisa_requisicao_Load(object sender, EventArgs e)
        {
            dgvItens_requisicao.AutoGenerateColumns = false;
            dgvItens_requisicao.DataSource = dsItens_req.Tables["ITENS_REQUISICAO"];
        }

        private void tb_requisicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                try
                {
                    dsItens_req.Clear();
                    this.datItens_req.SelectCommand.CommandText =
                            "SELECT * FROM ITENS_REQUISICAO WHERE COD_REQ_ITEM_REQ = " + tb_requisicao.Text + " ORDER BY COD_ITEM_REQ DESC";
                    this.fbConnection1.Open();
                    this.datItens_req.SelectCommand.Connection = fbConnection1;
                    this.datItens_req.SelectCommand.ExecuteNonQuery();
                    datItens_req.Fill(ITENS_REQUISICAO);
                    this.fbConnection1.Close(); 
                }
                catch
                {
                    fbConnection1.Close(); 
                }
            }
        }

        
    }
}