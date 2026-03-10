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
    public partial class form_localiza_liberacao : Form
    {
        public string cod_selecionado;
        public string cnpj_empresa;
        public bool liberado_faturamento;
        public form_localiza_liberacao(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void form_localiza_liberacao_Load(object sender, EventArgs e)
        {
            selecionar_liberacoes(false);
        }

        private void selecionar_liberacoes(bool todos)
        {
            cod_selecionado = "";
            string _baixado = " AND BAIXADO_LIB = 0 ";
            string _liberado_faturamento = "";
            if (liberado_faturamento)
            {
                _baixado = "";
                _liberado_faturamento = " AND LIBERADO_FATURAMENTO_LIB = '1' ";
            }
            if (todos)
            {
                _baixado = "";
                _liberado_faturamento = "";
            }

            datLiberacao.SelectCommand.CommandText = "SELECT * FROM LIBERACAO WHERE CNPJ_EMISSOR_LIB = '" + cnpj_empresa + "' " + _baixado + _liberado_faturamento;
            datLiberacao.Fill(LIBERACAO);
        }

        private void dgvLiberacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                    cod_selecionado = dgvLiberacao.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Close();
                
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecionar_liberacoes(true);
        }
    }
}
