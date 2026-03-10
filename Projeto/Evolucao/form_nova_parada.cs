using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_nova_parada : Form
    {
        public string rota;
        public string operador;
        public string maquina;
        public string data;
        public string hora;

        public form_nova_parada()
        {
            InitializeComponent();
        }

        private void form_nova_parada_Load(object sender, EventArgs e)
        {
            datParadas.Fill(PARADAS);
            this.BindingContext[dsParadas, "PARADAS"].AddNew();
            tb_data.Text = data;
            tb_hora.Text = hora;
            tb_maquina.Text = maquina;
            tb_operador.Text = operador;
            tb_rota.Text = rota;
            Atualizar();
            this.Close();

        }

        private void Atualizar()
        {
            //inserção na tabela de paradas
            this.BindingContext[dsParadas, "PARADAS"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsParadas.HasChanges())
            {
                datParadas.UpdateCommand = cbParadas.GetUpdateCommand();
                datParadas.InsertCommand = cbParadas.GetInsertCommand();
                datParadas.DeleteCommand = cbParadas.GetDeleteCommand();
                datParadas.Update(dsParadas, "PARADAS");
                dsParadas.AcceptChanges();
            }
            fbConnection1.Close(); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}