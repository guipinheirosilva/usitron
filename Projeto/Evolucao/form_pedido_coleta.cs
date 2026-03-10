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
    public partial class form_pedido_coleta : Form
    {
        public string empresa_emissora, cnpj_empresa_emissora;
        public form_pedido_coleta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                datPedido_coleta.InsertCommand.CommandText =
                    "INSERT INTO PEDIDO_COLETA (DATA_EMISSAO_PC, HORA_EMISSAO_PC, " +
                    "EMITENTE_PC, CNPJ_EMITENTE_PC) VALUES (" +
                    "CURRENT_DATE, " +
                    "CURRENT_TIME, '" + empresa_emissora + "', '" +
                    cnpj_empresa_emissora + "')";
                datPedido_coleta.InsertCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datPedido_coleta.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
                string ultimo_pedido = buscar_ultimo_pedido(cnpj_empresa_emissora);
                selecionar_pedido(ultimo_pedido);
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_ultimo_pedido(string cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                "SELECT COD_PC FROM PEDIDO_COLETA WHERE CNPJ_EMITENTE_PC = '" + cnpj + "' ORDER BY COD_PC DESC";
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

        private void selecionar_pedido(string ultimo_pedido)
        {
            try
            {
                dsPedido_coleta.Clear();
                datPedido_coleta.SelectCommand.CommandText =
                "SELECT * FROM PEDIDO_COLETA WHERE COD_PC = '" + ultimo_pedido + "'";
                datPedido_coleta.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datPedido_coleta.SelectCommand.ExecuteNonQuery();
                datPedido_coleta.Fill(PEDIDO_COLETA);
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(true, "");
            try
            {
                cli.ShowDialog();
            }
            finally
            {
                tb_remetente_nome.Text = cli.cliente_escolhido;
                tb_remetente_cnpj.Text = cli.cnpj_escolhido;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(true, "");
            try
            {
                cli.ShowDialog();
            }
            finally
            {
                tb_destinatario_nome.Text = cli.cliente_escolhido;
                tb_destinatario_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            form_localiza_cliente cli = new form_localiza_cliente(true, "");
            try
            {
                cli.ShowDialog();
            }
            finally
            {
                tb_tomador_nome.Text = cli.cliente_escolhido;
                tb_tomador_cnpj.Text = cli.cnpj_escolhido;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void atualizar()
        {
            try
            {
                this.BindingContext[dsPedido_coleta, "PEDIDO_COLETA"].EndCurrentEdit();
                if (dsPedido_coleta.HasChanges())
                {
                    fbConnection1.Open();
                    datPedido_coleta.UpdateCommand = cbPedido_coleta.GetUpdateCommand();
                    datPedido_coleta.InsertCommand = cbPedido_coleta.GetInsertCommand();
                    datPedido_coleta.DeleteCommand = cbPedido_coleta.GetDeleteCommand();
                    datPedido_coleta.Update(dsPedido_coleta, "PEDIDO_COLETA");
                    dsPedido_coleta.AcceptChanges();
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
}