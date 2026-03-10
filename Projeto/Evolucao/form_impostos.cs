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
    public partial class form_impostos : Form
    {
        public string descricao_escolhida;
        public string porc_escolhida;

        public string[] _descricao_escolhida = new string[100];
        public string[] _porc_escolhida = new string[100];
        public int numero_de_itens;

        public form_impostos()
        {
            InitializeComponent();
        }

        private void form_impostos_Load(object sender, EventArgs e)
        {
            dgv_impostos.AutoGenerateColumns = false;
            dgv_impostos.DataSource = dsImpostos.Tables["IMPOSTOS"];
            datImpostos.Fill(IMPOSTOS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = dgv_impostos.SelectedRows.Count - 1; i >= 0; i--)
            {
                _descricao_escolhida[i] = dgv_impostos.SelectedRows[j].Cells["col_descricao"].Value.ToString();
                _porc_escolhida[i] = dgv_impostos.SelectedRows[j].Cells["col_porc"].Value.ToString();
                j++;
            }
            numero_de_itens = dgv_impostos.SelectedRows.Count;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsImpostos, "IMPOSTOS"].EndCurrentEdit();
            if (dsImpostos.HasChanges())
            {
                fbConnection1.Open();

                datImpostos.UpdateCommand = cbImpostos.GetUpdateCommand();
                datImpostos.InsertCommand = cbImpostos.GetInsertCommand();
                datImpostos.DeleteCommand = cbImpostos.GetDeleteCommand();
                datImpostos.Update(dsImpostos, "IMPOSTOS");
                dsImpostos.AcceptChanges();
                fbConnection1.Close();
            }
        }
    }
}
