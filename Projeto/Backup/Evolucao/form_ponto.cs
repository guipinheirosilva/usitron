using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Evolucao
{
    public partial class form_ponto : Form
    {
        public form_ponto()
        {
            InitializeComponent();
        }

        private void form_ponto_Load(object sender, EventArgs e)
        {
            datCaminho_ponto.Fill(CAMINHO_PONTO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
            this.fbConnection1.Open();
            this.datApontamentos.DeleteCommand.CommandText =
                    "delete from apontamentos where cod_apontamento is not null";
            this.datApontamentos.DeleteCommand.Connection = fbConnection1;
            this.datApontamentos.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            Atualiza_banco();
        }

        private void Atualizar()
        {
            this.BindingContext[dsCaminho_ponto, "CAMINHO_PONTO"].EndCurrentEdit();
            if (dsCaminho_ponto.HasChanges())
            {
                //MessageBox.Show("CHEGOU AQUI");
                fbConnection1.Open();
                datCaminho_ponto.UpdateCommand = fbCommandBuilder1.GetUpdateCommand(); 
                datCaminho_ponto.InsertCommand = fbCommandBuilder1.GetInsertCommand();
                datCaminho_ponto.DeleteCommand = fbCommandBuilder1.GetDeleteCommand();
                datCaminho_ponto.Update(dsCaminho_ponto, "CAMINHO_PONTO");
                dsCaminho_ponto.AcceptChanges();
                //datClientes.Fill(CLIENTES);
                fbConnection1.Close();
            }
        }

        private void Atualiza_banco()
        {
            StreamReader objReader = new StreamReader(tb_caminho.Text);
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();

            foreach (string sOutput in arrText)
            {
                int i = 0;
                //int j = 0;
                string operador = "";
                string data_apontamento = "";
                string data_apontamento_banco = "";
                string hora_apontamento = "";
                string hora_apontamento_banco = "";
                string tipo_apontamento = "";
                //separando o operador
                for (i = 10; i < 15; i++)
                {
                    operador = operador + sOutput[i];

                }
                //separando a data
                for (i = 15; i < 21; i++)
                {
                    data_apontamento = data_apontamento + sOutput[i];
                }
                data_apontamento_banco = data_apontamento[2].ToString() + data_apontamento[3].ToString() + "/" + data_apontamento[0].ToString() + data_apontamento[1].ToString() + "/" + data_apontamento[4].ToString() + data_apontamento[5].ToString();

                //separando a hora
                for (i = 21; i < 25; i++)
                {
                    hora_apontamento = hora_apontamento + sOutput[i];
                }
                hora_apontamento_banco = hora_apontamento[0].ToString() + hora_apontamento[1].ToString() + ":" + hora_apontamento[2].ToString() + hora_apontamento[3].ToString();

                //separando tipo apontamento
                for (i = 25; i < 27; i++)
                {
                    tipo_apontamento = tipo_apontamento + sOutput[i];
                }

                if (tipo_apontamento == "00")
                {
                    this.fbConnection1.Open();
                    this.datApontamentos.UpdateCommand.CommandText =
                    "UPDATE APONTAMENTOS SET POSICAO_APONTAMENTO = 'F' WHERE OPERADOR_APONTAMENTO = '" + operador + "' AND DATA_ENTRADA_APONTAMENTO IS NOT NULL";
                    this.datApontamentos.UpdateCommand.Connection = fbConnection1;
                    this.datApontamentos.UpdateCommand.ExecuteNonQuery();
                    
                    this.datApontamentos.InsertCommand.CommandText =
                    "INSERT INTO APONTAMENTOS (OPERADOR_APONTAMENTO, DATA_ENTRADA_APONTAMENTO, HORA_ENTRADA_APONTAMENTO)" +
                    "VALUES ('" + operador + "','" + data_apontamento_banco + "','" + hora_apontamento_banco + "')";
                    this.datApontamentos.InsertCommand.Connection = fbConnection1;
                    this.datApontamentos.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                else
                {
                    this.fbConnection1.Open();
                    this.datApontamentos.UpdateCommand.CommandText =
                    "UPDATE APONTAMENTOS SET DATA_FECHAMENTO_APONTAMENTO = '" + data_apontamento_banco + "' WHERE OPERADOR_APONTAMENTO = '" + operador + "' AND POSICAO_APONTAMENTO IS NULL";
                    this.datApontamentos.UpdateCommand.Connection = fbConnection1;
                    this.datApontamentos.UpdateCommand.ExecuteNonQuery();
                    
                    this.datApontamentos.UpdateCommand.CommandText =
                    "UPDATE APONTAMENTOS SET HORA_FECHAMENTO_APONTAMENTO = '" + hora_apontamento_banco + "' WHERE OPERADOR_APONTAMENTO = '" + operador + "' AND POSICAO_APONTAMENTO IS NULL";
                    this.datApontamentos.UpdateCommand.Connection = fbConnection1;
                    this.datApontamentos.UpdateCommand.ExecuteNonQuery();
                    
                    this.fbConnection1.Close();
                }

                //MessageBox.Show(sOutput);
                //Console.WriteLine(sOutput);
            }
            //Console.ReadLine();

        }
    }
}