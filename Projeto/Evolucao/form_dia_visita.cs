using FirebirdSql.Data.FirebirdClient;
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
    public partial class form_dia_visita : Form
    {
        public string cod_dia_visita;
        public form_dia_visita()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            acertar_label();
        }

        private void acertar_label()
        {
            if (tb_dia_visita.Text.Length > 3)
                MessageBox.Show("Digite os 3 caracteres obrigatorios");
            else
            {
                string dia_visita = "", frequencia = "", semana_visita = "";
                try
                {
                    dia_visita = _dia_visita(tb_dia_visita.Text[0].ToString());
                }
                catch { }
                try
                {
                    frequencia = _frequencia(tb_dia_visita.Text[1].ToString());
                }
                catch { }
                try
                {
                    semana_visita = _semana_visita(tb_dia_visita.Text[2].ToString());
                }
                catch { }
                label_resultado.Text = "Dia de Visita: " + dia_visita + "\n\t Frequencia: " + frequencia + "\n\t" + semana_visita;
            }
        }
        private string _dia_visita(string cod)
        {
            switch (cod)
            {
                case "1":
                    return "DOMINGO";
                case "2":
                    return "SEGUNDA";
                case "3":
                    return "TERÇA";
                case "4":
                    return "QUARTA";
                case "5":
                    return "QUINTA";
                case "6":
                    return "SEXTA";
                case "7":
                    return "SÁBADO";
            }
            return "erro";
        }

        private string _frequencia(string cod)
        {
            switch (cod)
            {
                case "1":
                    return "SEMANAL";
                case "2":
                    return "QUINZENAL";
                case "3":
                    return "MENSAL";
                case "4":
                    return "BIMESTRAL";
                case "5":
                    return "TRIMESTRAL";
                case "6":
                    return "SEMESTRAL";
                case "7":
                    return "ANUAL";
            }
            return "erro";
        }

        private string _semana_visita(string cod)
        {
            switch (cod)
            {
                case "1":
                    return "SEMANA 1";
                case "2":
                    return "SEMANA 2";
                case "3":
                    return "SEMANA 3";
                case "4":
                    return "SEMANA 4";
            }
            return "erro";
        }

        private void form_dia_visita_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_dia_visita.Text.Length == 3)
            {
                cod_dia_visita = tb_dia_visita.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("É obrigatório o código ter 3 caracteres");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            FbCommand cmd = new FbCommand();

            cmd.Parameters.AddWithValue("@DATE", Convert.ToDateTime(dtData.Text);
           // cmd.Parameters.AddWithValue("@password", "abcd1234");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Connection = fbConnection1;
            fbConnection1.Open();
            cmd.ExecuteNonQuery();
            fbConnection1.Close();
             * */

           /*
            FbCommand testCMD = new FbCommand
            ("YearWeek", fbConnection1);

            testCMD.CommandType = CommandType.StoredProcedure;

            FbParameter RetVal = testCMD.Parameters.Add
               ("D", FbDbType.Date);
            RetVal.Direction = ParameterDirection.Input;
           // SqlParameter IdIn = testCMD.Parameters.Add
           //   ("@au_idIN", SqlDbType.VarChar, 11);
            IdIn.Direction = ParameterDirection.Input;
            SqlParameter NumTitles = testCMD.Parameters.Add
               ("@numtitlesout", SqlDbType.VarChar, 11);
            NumTitles.Direction = ParameterDirection.Output;

            IdIn.Value = "213-46-8915";
            PubsConn.Open();

            SqlDataReader myReader = testCMD.ExecuteReader();
            Console.WriteLine("Book Titles for this Author:");
            while (myReader.Read())
            {
                Console.WriteLine("{0}", myReader.GetString(2));
            };
            myReader.Close();
            Console.WriteLine("Number of Rows: " + NumTitles.Value);
            Console.WriteLine("Return Value: " + RetVal.Value);
            
            */
        }
    }
}
