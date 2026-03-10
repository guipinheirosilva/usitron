using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_area_atuacao : Form
    {
        int novox = 0;
        public form_area_atuacao()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
            try
            {
                this.datArea_forn.InsertCommand.CommandText =
                    "INSERT INTO AREA_ATUACAO_FORN(DESCRICAO_AREA_FORN) VALUES('novo')";
                this.fbConnection1.Open();
                this.datArea_forn.InsertCommand.Connection = fbConnection1;
                this.datArea_forn.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datArea_forn.Fill(AREA_ATUACAO_FORN);
                this.BindingContext[dsArea_forn, "AREA_ATUACAO_FORN"].Position = 100000000;
                tb_descricao.Focus();
            }
            
            
            catch
            {
                MessageBox.Show("Erro validando...");
                this.datArea_forn.InsertCommand.CommandText =
                    "INSERT INTO AREA_ATUACAO_FORN(DESCRICAO_AREA_FORN) VALUES('novo" + novox++ + "'"; 
                this.fbConnection1.Open();
                this.datArea_forn.InsertCommand.Connection = fbConnection1;
                this.datArea_forn.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datArea_forn.Fill(AREA_ATUACAO_FORN);
                this.BindingContext[dsArea_forn, "AREA_ATUACAO_FORN"].Position = 100000000;
                tb_descricao.Focus();

            
            }
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                this.datArea_forn.DeleteCommand.CommandText =
                "DELETE FROM AREA_ATUACAO_FORN WHERE COD_AREA_FORN = '" + codigo.Text + "'";
                this.fbConnection1.Open();
                this.datArea_forn.DeleteCommand.Connection = fbConnection1;
                this.datArea_forn.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                dsArea_forn.Clear();
                datArea_forn.Fill(AREA_ATUACAO_FORN);
                
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            this.BindingContext[dsArea_forn, "AREA_ATUACAO_FORN"].EndCurrentEdit();
            if (dsArea_forn.HasChanges())
            {
                fbConnection1.Open();
                datArea_forn.UpdateCommand = fbCommandBuilder1.GetUpdateCommand(); 
                datArea_forn.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                datArea_forn.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                datArea_forn.Update(dsArea_forn, "AREA_ATUACAO_FORN");
                dsArea_forn.AcceptChanges();
                datArea_forn.Fill(AREA_ATUACAO_FORN);
                fbConnection1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            localizar();

        }

        private void localizar()
        {
            form_localiza_area_forn localiza_area = new form_localiza_area_forn();
            try
            {
                localiza_area.ShowDialog();
            }
            finally
            {
                localiza_area.Dispose();
                try
                {
                    dsArea_forn.Clear();
                    this.datArea_forn.SelectCommand.CommandText =
                    "SELECT * FROM AREA_ATUACAO_FORN WHERE COD_AREA_FORN = '" + localiza_area.area_escolhida + "'";
                    this.fbConnection1.Open();
                    this.datArea_forn.SelectCommand.Connection = fbConnection1;
                    this.datArea_forn.SelectCommand.ExecuteNonQuery();
                    datArea_forn.Fill(AREA_ATUACAO_FORN);
                    this.fbConnection1.Close();
                }
                catch {
                    this.fbConnection1.Close();
                }
                

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsForn.Clear();
            this.datForn.SelectCommand.CommandText =
            "SELECT * FROM FORNECEDORES WHERE TIPO_MATERIAL = '" + tb_descricao.Text + "' OR " +
            "TIPO_MATERIAL_2 = '" + tb_descricao.Text + "' OR " +
            "TIPO_MATERIAL_3 = '" + tb_descricao.Text + "' OR " +
            "TIPO_MATERIAL_4 = '" + tb_descricao.Text + "'";
            this.fbConnection1.Open();
            this.datForn.SelectCommand.Connection = fbConnection1;
            this.datForn.SelectCommand.ExecuteNonQuery();
            datForn.Fill(FORNECEDORES);
            this.fbConnection1.Close();

        }
    }
}