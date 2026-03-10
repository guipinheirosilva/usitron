using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_localiza_cliente : Form
    {
        public string cliente_escolhido;
        public string cnpj_escolhido;
        public string estado_escolhido;
        public string cod_escolhido;
        public string cnpj_a_buscar;

        public form_localiza_cliente(bool cadastro)
        {
            InitializeComponent();
            if (!cadastro)
            {
                button1.Visible = false;
            }
        }

        private void form_localiza_cliente_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = dsClientes.Tables["CLIENTES"];
            if (cnpj_a_buscar != "" && cnpj_a_buscar != null)
            {
                selecionar(cnpj_a_buscar);
                dgvClientes.Focus(); dgvClientes.CurrentCell = dgvClientes.Rows[0].Cells[0];
            }
        }

        private void tb_localiza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "RAZAO_SOCIAL LIKE UPPER('*" + tb_localiza.Text + "*')";
            }
            catch { }
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_razao"].Value.ToString();
            cnpj_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cnpj"].Value.ToString();
            estado_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_estado"].Value.ToString();
            cod_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_razao"].Value.ToString();
            cnpj_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cnpj"].Value.ToString();
            estado_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_estado"].Value.ToString();
            cod_escolhido = dgvClientes.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_clientes cli = new form_clientes();
            try
            {
                cli.ShowDialog();
            }
            finally
            {
                cli.Dispose();
                datClientes.Fill(CLIENTES);
            }
        }

        private void tb_nome_fantasia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "NOME_FANTASIA LIKE '" + tb_nome_fantasia.Text + "*'";
            }
            catch { }
        }

        private void tb_cnpj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dsClientes.Tables["CLIENTES"].DefaultView.RowFilter = "CNPJ LIKE '" + tb_cnpj.Text + "*'";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selecionar("%");

        }

        private void selecionar(string cnpj)
        {
                try
            {
                string localiza = "";
                if (cnpj == "")
                    cnpj = "%";
                if (tb_localiza.Text != "")
                    localiza = " AND UPPER(RAZAO_SOCIAL) LIKE UPPER('%" + tb_localiza.Text + "%')";
                dsClientes.Clear();
                datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES where CNPJ like '" + cnpj + "%' " + localiza + " ORDER BY RAZAO_SOCIAL";
                datClientes.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datClientes.SelectCommand.ExecuteNonQuery();
                datClientes.Fill(CLIENTES);
                fbConnection1.Close();
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = dsClientes.Tables["CLIENTES"];
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selecionar(tb_cnpj.Text);
        }

        private void tb_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                selecionar(tb_cnpj.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selecionar("%");
        }

        private void dgvClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                //                if(linha = dgvClientes.RowCount)

                int linha = 0;
                //if (dgvClientes.CurrentRow.Index == dgvClientes.RowCount - 1)
                //    linha = dgvClientes.CurrentRow.Index;
                //else
                    linha = dgvClientes.CurrentRow.Index - 1;
                cliente_escolhido = dgvClientes.Rows[linha].Cells["col_razao"].Value.ToString();
                cnpj_escolhido = dgvClientes.Rows[linha].Cells["col_cnpj"].Value.ToString();
                estado_escolhido = dgvClientes.Rows[linha].Cells["col_estado"].Value.ToString();
                cod_escolhido = dgvClientes.Rows[linha].Cells["col_cod"].Value.ToString();
                this.Close();
            }
        }

        private void tb_localiza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                selecionar("%");
            }
        }

        
    }
}