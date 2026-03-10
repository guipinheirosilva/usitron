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
    public partial class form_outros_serviços : Form
    {
        public string descricao_escolhida;
        public string valor_escolhido;

        public string[] _cod_escolhido = new string[100];
        public string[] _descricao_escolhida = new string[100];
        public string[] _valor_escolhido = new string[100];
        public int numero_de_itens;

        public form_outros_serviços()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsOutrosServicos, "OUTROS_SERVICOS"].EndCurrentEdit();
            if (dsOutrosServicos.HasChanges())
            {
                fbConnection1.Open();

                datOutrosServicos.UpdateCommand = cbOutrosServicos.GetUpdateCommand();
                datOutrosServicos.InsertCommand = cbOutrosServicos.GetInsertCommand();
                datOutrosServicos.DeleteCommand = cbOutrosServicos.GetDeleteCommand();
                datOutrosServicos.Update(dsOutrosServicos, "OUTROS_SERVICOS");
                dsOutrosServicos.AcceptChanges();
                fbConnection1.Close();
            }
        }

        private void dgvMateria_prima_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                descricao_escolhida = dgvMateria_prima.Rows[e.RowIndex].Cells["col_descricao"].Value.ToString();
                valor_escolhido = dgvMateria_prima.Rows[e.RowIndex].Cells["col_valor"].Value.ToString();
                this.Close();
            }
            catch { }
        }

        private void form_outros_serviços_Load(object sender, EventArgs e)
        {
            dgvMateria_prima.AutoGenerateColumns = false;
            //dgvMateria_prima.DataSource = dsOutrosServicos.Tables["OUTROS_SERVICOS"];
            datOutrosServicos.Fill(OUTROS_SERVICOS);
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            dsOutrosServicos.Tables["OUTROS_SERVICOS"].DefaultView.RowFilter = "DESCRICAO_OUTRO_SERV LIKE '*" + tb_descricao.Text + "*'";
        }

        private void datOutrosServicos_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = dgvMateria_prima.SelectedRows.Count - 1; i >= 0; i--)
            {
                _cod_escolhido[i] = dgvMateria_prima.SelectedRows[j].Cells["col_cod"].Value.ToString();
                _descricao_escolhida[i] = dgvMateria_prima.SelectedRows[j].Cells["col_descricao"].Value.ToString();
                _valor_escolhido[i] = dgvMateria_prima.SelectedRows[j].Cells["col_valor"].Value.ToString();
                j++;
            }
            numero_de_itens = dgvMateria_prima.SelectedRows.Count;
            this.Close();
        }
    }
}
