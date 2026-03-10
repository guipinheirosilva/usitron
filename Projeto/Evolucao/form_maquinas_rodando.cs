using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_maquinas_rodando : Form
    {
        public form_maquinas_rodando()
        {
            InitializeComponent();
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET HORAS_MAQUINA_RODANDO = 0";
            this.fbConnection1.Open();
            this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
            this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            for (int i = 0; i < dgvMaquinas_trabalhando.RowCount - 1; i++)
            {
                this.datRotas_campo.UpdateCommand.CommandText =
                "UPDATE ROTAS_CAMPO SET HORAS_MAQUINA_RODANDO = HORAS_MAQUINA_RODANDO + " + dgvMaquinas_trabalhando.Rows[i].Cells["col_horas"].Value.ToString().Replace(",",".") + 
                " WHERE COD_ROTA_CAMPO = '" + dgvMaquinas_trabalhando.Rows[i].Cells["col_rota"].Value.ToString() + "'";
                this.fbConnection1.Open();
                this.datRotas_campo.UpdateCommand.Connection = fbConnection1;
                this.datRotas_campo.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }
        }

        private void form_maquinas_rodando_Load(object sender, EventArgs e)
        {
            this.datMaquina_rodando.SelectCommand.CommandText =
             "SELECT * FROM MAQUINA_RODANDO";
            this.fbConnection1.Open();
            this.datMaquina_rodando.SelectCommand.Connection = fbConnection1;
            this.datMaquina_rodando.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
            datMaquina_rodando.Fill(MAQUINA_RODANDO);
        }
    }
}