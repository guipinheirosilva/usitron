using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_conjunto_peca : Form
    {
        public string nome_escolhido;
        
        public form_conjunto_peca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            try
            {
                this.BindingContext[dsConjunto_peca, "CONJUNTO_PECA"].EndCurrentEdit();
                if (dsConjunto_peca.HasChanges())
                {
                    fbConnection1.Open();
                    datConjunto_peca.UpdateCommand = cbConjunto_peca.GetUpdateCommand();
                    datConjunto_peca.InsertCommand = cbConjunto_peca.GetInsertCommand();
                    datConjunto_peca.DeleteCommand = cbConjunto_peca.GetDeleteCommand();
                    datConjunto_peca.Update(dsConjunto_peca, "CONJUNTO_PECA");
                    dsConjunto_peca.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        private void form_conjunto_peca_Load(object sender, EventArgs e)
        {
            try
            {
                datConjunto_peca.SelectCommand.CommandText =
                    "SELECT * FROM CONJUNTO_PECA ORDER BY ORDEM_CONJUNTO";
                datConjunto_peca.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datConjunto_peca.SelectCommand.ExecuteNonQuery();
                datConjunto_peca.Fill(CONJUNTO_PECA);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void dgvConjuntos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nome_escolhido = dgvConjuntos.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }
    }
}