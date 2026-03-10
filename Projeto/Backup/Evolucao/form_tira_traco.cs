using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_tira_traco : Form
    {
        public form_tira_traco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dgvOp.RowCount - 1; i++)
            {

                dgvOp.Rows[i].Cells["col_pos_peca"].Value = dgvOp.Rows[i].Cells["col_pos_peca"].Value.ToString().Replace("/", "-");
            }

        }

        private void form_tira_traco_Load(object sender, EventArgs e)
        {
            datOp.Fill(OP);
            datRotas_campo.Fill(ROTAS_CAMPO);
            datSemana.Fill(HORAS_SEMANA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvRotas.RowCount - 1; i++)
            {

                dgvRotas.Rows[i].Cells["col_pos"].Value = dgvRotas.Rows[i].Cells["col_pos"].Value.ToString().Replace("/", "-");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSemana.RowCount - 1; i++)
            {


                dgvSemana.Rows[i].Cells["col_pos_sem"].Value = dgvSemana.Rows[i].Cells["col_pos_sem"].Value.ToString().Replace("/", "-");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            //fbConnection1.Close();

            this.BindingContext[dsSemana, "HORAS_SEMANA"].EndCurrentEdit();
            //fbConnection1.Open();
            if (dsSemana.HasChanges())
            {

                //MessageBox.Show("CHEGOU NO ATUALIZAR do rotas");
                datSemana.UpdateCommand = cbSemana.GetUpdateCommand();
                datSemana.InsertCommand = cbSemana.GetInsertCommand();
                datSemana.DeleteCommand = cbSemana.GetDeleteCommand();
                datSemana.Update(dsSemana, "HORAS_SEMANA");
                dsSemana.AcceptChanges();

            }
            fbConnection1.Close();
        }
        
    }
}