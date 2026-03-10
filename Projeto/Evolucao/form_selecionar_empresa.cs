using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_selecionar_empresa : Form
    {
        public bool consulta;
        public bool busca_dentro;
        public bool cte;
        public bool pedido_coleta;
        public string funcionario_emissor;
        public string cnpj_empresa_emissora;
        public string empresa_emissora;
        public form_selecionar_empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cte)
            {
                form_cte _cte = new form_cte();
                _cte.empresa_emissora = cbEmpresa.Text;
                _cte.cnpj_empresa_emissora = cbEmpresa.SelectedValue.ToString();
                _cte.funcionario_emissor = funcionario_emissor;
                _cte.Show();
                this.Close();
            }
            if (pedido_coleta)
            {
                form_pedido_coleta _pc = new form_pedido_coleta();
                _pc.empresa_emissora = cbEmpresa.Text;
                _pc.cnpj_empresa_emissora = cbEmpresa.SelectedValue.ToString();
                _pc.Show();
                this.Close();
            }
            if (busca_dentro)
            {
                empresa_emissora = cbEmpresa.Text;
                cnpj_empresa_emissora = cbEmpresa.SelectedValue.ToString();
                this.Close();
            }
            if (consulta)
            {
                form_pesquisa_cte _cte = new form_pesquisa_cte();
                _cte._cnpj_emitente = cbEmpresa.SelectedValue.ToString();
                _cte.empresa_emissora = cbEmpresa.Text;
                _cte.Show();
                this.Close();
            }

    

        }

        private void form_selecionar_empresa_Load(object sender, EventArgs e)
        {
            datEmpresa.Fill(EMPRESA);
        }
    }
}