using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml;
using FirebirdSql.Data.FirebirdClient;
namespace Evolucao
{
    public partial class form_faturamento : Form
    {
        //variaveis detecta_fatura
        string[] _datas = new string[50];
        string[] _valores = new string[50];
        string[] _cod = new string[50];
        string nomeFantasia = "";
        bool _enviar = false;

        //variaveis da NFe

        string decimal_correto;
        NFe_Util_PL005a.Util util = new NFe_Util_PL005a.Util();
        //NFe_Util_PL005a.Util util = new NFe_Util_PL005a.Util();
        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        public bool erro;
        public bool abre_nf;
        public string nf_atual;
        string novo_valor;
        string dia;
        string mes;
        int pedido;
        bool primeiro_pedido = true;
        bool unico;


        public form_faturamento()
        {
            InitializeComponent();
        }

        private void form_faturamento_Load(object sender, EventArgs e)
        {
            datEmpresa.Fill(EMPRESA);
            try
            {
                string ultima_nota = buscar_ultima_nf().ToString();
                this.datNota_fiscal.SelectCommand.CommandText =
                "SELECT * FROM NOTA_FISCAL WHERE N_NF = '" + ultima_nota + "'";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close();

                this.datItens_nota.SelectCommand.CommandText =
                "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' order by cod_itens_nota";
                this.fbConnection1.Open();
                this.datItens_nota.SelectCommand.Connection = fbConnection1;
                this.datItens_nota.SelectCommand.ExecuteNonQuery();
                datItens_nota.Fill(ITENS_NOTA);
                this.fbConnection1.Close();

                this.datFatura_nf.SelectCommand.CommandText =
                "SELECT * FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                this.fbConnection1.Open();
                this.datFatura_nf.SelectCommand.Connection = fbConnection1;
                this.datFatura_nf.SelectCommand.ExecuteNonQuery();
                datFatura_nf.Fill(FATURA_NF);
                this.fbConnection1.Close();

                dsPedidos_nf.Clear();
                this.datPedidos_nf.SelectCommand.CommandText =
                "SELECT * FROM PEDIDOS_NF WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";
                /*"SELECT pnf.*, pv.vendedor_ped_venda " + 
                "FROM PEDIDOS_NF pnf " + 
                "INNER JOIN pedidos_venda pv " + 
                "ON pv.cod_ped_venda = pnf.n_pedido_nf " + 
                "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";*/                
                this.fbConnection1.Open();
                this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                datPedidos_nf.Fill(PEDIDOS_NF);
                this.fbConnection1.Close();
                dgvItens_nota.AutoGenerateColumns = false;
                dgvItens_nota.DataSource = dsItens_nota.Tables["ITENS_NOTA"];

            }
            catch
            {
                MessageBox.Show("erro");
                fbConnection1.Close();
            }

        }

        private void tb_descricao_DoubleClick(object sender, EventArgs e)
        {

        }


        private string diminue_casas_decimais(string valor_double)
        {
            int m = 0;
            string novo_valor = "";
            try
            {
                while (valor_double[m].ToString() != ",")
                {
                    m++;
                }
                try
                {
                    for (int n = 0; n <= m + 2; n++)
                    {
                        novo_valor = novo_valor + valor_double[n];
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    novo_valor = novo_valor + "0";
                }
            }
            catch (IndexOutOfRangeException)
            {
                novo_valor = valor_double + ",00";
            }


            //MessageBox.Show(novo_valor);
            return novo_valor;

        }
        private void novo_registro_Click(object sender, EventArgs e)
        {
            HasTextBox(this);
            dsDesenhos.Clear();
            dsItens_nota.Clear();
            dsFatura_nf.Clear();
            dsPedidos_nf.Clear();
            gbNfe.BackColor = SystemColors.Control;
            int n_nf_atual = buscar_ultima_nf();
            n_nf_atual++;
            this.datNota_fiscal.InsertCommand.CommandText =
                "INSERT INTO NOTA_FISCAL (N_NF, OBS_NF, VALOR_TOT_PROD_NF, VALOR_NOTA_NF)" +
                "VALUES ('" + n_nf_atual.ToString() + "', 'NOVO', 0, 0)";
            this.fbConnection1.Open();
            this.datNota_fiscal.InsertCommand.Connection = fbConnection1;
            this.datNota_fiscal.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            try
            {
                dsNota_fiscal.Clear();
                this.datNota_fiscal.SelectCommand.CommandText =
                    "SELECT * FROM NOTA_FISCAL WHERE N_NF = '" + n_nf_atual.ToString() + "'";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            //this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position = 100000000;
            radioSaida.Checked = true;
            tb_data_emissao.Text = Convert.ToDateTime(DateTime.Now).ToShortDateString();
            tb_frete.Text = "0";
        }

        private int buscar_ultima_nf()
        {
            int encontrada = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT N_NF FROM NOTA_FISCAL ORDER BY N_NF DESC";
                fbConnection1.Open();
                DataSet notas = new DataSet();
                datNota_fiscal.SelectCommand = select;
                datNota_fiscal.Fill(notas);

                if (notas.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = notas.Tables[0].Rows[0];
                    encontrada = Convert.ToInt32(dr[0].ToString());
                }
                else
                {
                    MessageBox.Show("Nenhuma nota encontrada");
                }
                fbConnection1.Close();
                return encontrada;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }

        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            //calcular();
            // MessageBox.Show(Extenso_Valor(Convert.ToDecimal(tb_total_nota.Text)));
            //tb_total_nota.Text = diminue_casas_decimais(tb_total_nota.Text);
            //label_valor_extenso.Visible = true;
            //label_valor_extenso.Text = Extenso_Valor(Convert.ToDecimal(tb_total_nota.Text)) + "#############";
            //tb_total_prod.Text = diminue_casas_decimais(tb_total_prod.Text);

            Atualizar(false);
        }

        private void Atualizar(bool excecao)
        {
            if (tb_protocolo_autorizacao.Text != "" && excecao == false)
            {
                MessageBox.Show("Impossível salvar, pois a NFe já foi autorizada");
            }
            else
            {
                try
                {
                    this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].EndCurrentEdit();
                    if (dsNota_fiscal.HasChanges())
                    {
                        //MessageBox.Show("CHEGOU AQUI");
                        fbConnection1.Open();
                        datNota_fiscal.UpdateCommand = cbNota_fiscal.GetUpdateCommand();
                        datNota_fiscal.InsertCommand = cbNota_fiscal.GetInsertCommand();
                        datNota_fiscal.DeleteCommand = cbNota_fiscal.GetDeleteCommand();
                        datNota_fiscal.Update(dsNota_fiscal, "NOTA_FISCAL");
                        dsNota_fiscal.AcceptChanges();
                        //datNota_fiscal.Fill(NOTA_FISCAL);
                        fbConnection1.Close();
                    }
                    this.BindingContext[dsItens_nota, "ITENS_NOTA"].EndCurrentEdit();
                    if (dsItens_nota.HasChanges())
                    {
                        //MessageBox.Show("CHEGOU AQUI");
                        fbConnection1.Open();
                        datItens_nota.UpdateCommand = cbItens_nota.GetUpdateCommand();
                        datItens_nota.InsertCommand = cbItens_nota.GetInsertCommand();
                        datItens_nota.DeleteCommand = cbItens_nota.GetDeleteCommand();
                        datItens_nota.Update(dsItens_nota, "ITENS_NOTA");
                        dsItens_nota.AcceptChanges();
                        //datItens_nota.Fill(NOTA_FISCAL);
                        fbConnection1.Close();
                    }

                    this.BindingContext[dsFatura_nf, "FATURA_NF"].EndCurrentEdit();
                    if (dsFatura_nf.HasChanges())
                    {
                        fbConnection1.Open();
                        datFatura_nf.UpdateCommand = cbFatura_nf.GetUpdateCommand();
                        datFatura_nf.InsertCommand = cbFatura_nf.GetInsertCommand();
                        datFatura_nf.DeleteCommand = cbFatura_nf.GetDeleteCommand();
                        datFatura_nf.Update(dsFatura_nf, "FATURA_NF");
                        dsFatura_nf.AcceptChanges();
                        fbConnection1.Close();
                    }
                    this.BindingContext[dsPedidos_nf, "PEDIDOS_NF"].EndCurrentEdit();
                    if (dsPedidos_nf.HasChanges())
                    {
                        //MessageBox.Show("CHEGOU AQUI");
                        fbConnection1.Open();
                        datPedidos_nf.UpdateCommand = cbPedidos_nf.GetUpdateCommand();
                        datPedidos_nf.InsertCommand = cbPedidos_nf.GetInsertCommand();
                        datPedidos_nf.DeleteCommand = cbPedidos_nf.GetDeleteCommand();
                        datPedidos_nf.Update(dsPedidos_nf, "PEDIDOS_NF");
                        dsPedidos_nf.AcceptChanges();
                        fbConnection1.Close();
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }


        }







        public string Extenso_Valor(decimal pdbl_Valor)
        {
            //MessageBox.Show(pdbl_Valor.ToString());
            string strValorExtenso = ""; //Variável que irá armazenar o valor por extenso do número informado

            string strNumero = ""; //Irá armazenar o número para exibir por extenso

            string strCentena = "";

            string strDezena = "";

            string strUnidade = "";

            decimal dblCentavos = 0;

            decimal dblValorInteiro = 0;

            int intContador = 0;

            bool bln_Bilhao = false;

            bool bln_Milhao = false;

            bool bln_Mil = false;

            bool bln_Real = false;

            bool bln_Unidade = false;

            //Verificar se foi informado um dado indevido

            if (pdbl_Valor == 0 || pdbl_Valor <= 0)
            {

                strValorExtenso = "Verificar se há valor negativo ou nada foi informado";

            }

            if (pdbl_Valor > (decimal)9999999999.99)
            {

                strValorExtenso = "Valor não suportado pela Função";

            }

            else //Entrada padrão do método
            {

                //Gerar Extenso Centavos

                dblCentavos = pdbl_Valor - (int)pdbl_Valor;
                //MessageBox.Show(dblCentavos.ToString());
                //Gerar Extenso parte Inteira

                dblValorInteiro = (int)pdbl_Valor;

                if (dblValorInteiro > 0)
                {

                    if (dblValorInteiro > 999)
                    {

                        bln_Mil = true;

                    }

                    if (dblValorInteiro > 999999)
                    {

                        bln_Milhao = true;

                        bln_Mil = false;

                    }

                    if (dblValorInteiro > 999999999)
                    {

                        bln_Mil = false;

                        bln_Milhao = false;

                        bln_Bilhao = true;

                    }

                    for (int i = (dblValorInteiro.ToString().Trim().Length) - 1; i >= 0; i--)
                    {

                        // strNumero = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) + 1, 1);

                        strNumero = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) - 1, 1);

                        switch (i)
                        { /*******/

                            case 9: /*Bilhão*

/*******/
                                {

                                    strValorExtenso = fcn_Numero_Unidade(strNumero) + ((int.Parse(strNumero) > 1) ? " BILHÕES DE" : " BILHÃO DE");

                                    bln_Bilhao = true;

                                    break;

                                }

                            case 8: /********/

                            case 5: //Centena*

                            case 2: /********/
                                {

                                    if (int.Parse(strNumero) > 0)
                                    {

                                        strCentena = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) - 1, 3);

                                        if (int.Parse(strCentena) > 100 && int.Parse(strCentena) < 200)
                                        {

                                            strValorExtenso = strValorExtenso + " CENTO E ";

                                        }

                                        else
                                        {

                                            strValorExtenso = strValorExtenso + " " + fcn_Numero_Centena(strNumero);

                                        }

                                        if (intContador == 8)
                                        {

                                            bln_Milhao = true;

                                        }

                                        else if (intContador == 5)
                                        {

                                            bln_Mil = true;

                                        }

                                    }

                                    break;

                                }

                            case 7: /*****************/

                            case 4: //Dezena de Milhão*

                            case 1: /*****************/
                                {

                                    if (int.Parse(strNumero) > 0)
                                    {

                                        strDezena = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) - 1, 2);//

                                        if (int.Parse(strDezena) > 10 && int.Parse(strDezena) < 20)
                                        {

                                            strValorExtenso = strValorExtenso + (Right(strValorExtenso, 5).Trim() == "ENTOS" ? " E " : " ")

                                            + fcn_Numero_Dezena0(Right(strDezena, 1));//corrigido

                                            bln_Unidade = true;

                                        }

                                        else
                                        {

                                            strValorExtenso = strValorExtenso + (Right(strValorExtenso, 5).Trim() == "ENTOS" ? " E " : " ")

                                            + fcn_Numero_Dezena1(Left(strDezena, 1));//corrigido

                                            bln_Unidade = false;

                                        }

                                        if (intContador == 7)
                                        {

                                            bln_Milhao = true;

                                        }

                                        else if (intContador == 4)
                                        {

                                            bln_Mil = true;

                                        }

                                    }

                                    break;

                                }

                            case 6: /******************/

                            case 3: //Unidade de Milhão*

                            case 0: /******************/
                                {

                                    if (int.Parse(strNumero) > 0 && !bln_Unidade)
                                    {

                                        if ((Right(strValorExtenso, 5).Trim()) == "ENTOS"

                                        || (Right(strValorExtenso, 3).Trim()) == "NTE"

                                        || (Right(strValorExtenso, 3).Trim()) == "NTA")
                                        {

                                            strValorExtenso = strValorExtenso + " E ";

                                        }

                                        else
                                        {

                                            strValorExtenso = strValorExtenso + " ";

                                        }

                                        strValorExtenso = strValorExtenso + fcn_Numero_Unidade(strNumero);

                                    }

                                    if (i == 6)
                                    {

                                        if (bln_Milhao || int.Parse(strNumero) > 0)
                                        {

                                            strValorExtenso = strValorExtenso + ((int.Parse(strNumero) == 1) && !bln_Unidade ? " MILHÃO DE" : " MILHÕES DE");

                                            bln_Milhao = true;

                                        }

                                    }

                                    if (i == 3)
                                    {

                                        if (bln_Mil || int.Parse(strNumero) > 0)
                                        {

                                            strValorExtenso = strValorExtenso + " MIL";

                                            bln_Mil = true;

                                        }

                                    }

                                    if (i == 0)
                                    {

                                        if ((bln_Bilhao && !bln_Milhao && !bln_Mil

                                        && Right((dblValorInteiro.ToString().Trim()), 3) == "0")

                                        || (!bln_Bilhao && bln_Milhao && !bln_Mil

                                        && Right((dblValorInteiro.ToString().Trim()), 3) == "0"))
                                        {

                                            strValorExtenso = strValorExtenso + " DE ";

                                        }

                                        strValorExtenso = strValorExtenso + ((int.Parse(dblValorInteiro.ToString())) > 1 ? " REAIS " : " REAL ");

                                    }

                                    bln_Unidade = false;

                                    break;

                                }

                        }

                    }//

                }

                if (dblCentavos > 0)
                {

                    if ((Decimal.Parse(dblCentavos.ToString()) > 0) && (dblCentavos < (decimal)0.1))
                    {

                        strNumero = Right((Decimal.Round(dblCentavos, 2)).ToString().Trim(), 1);

                        strValorExtenso = strValorExtenso + ((Decimal.Parse(dblCentavos.ToString()) > 0) ? " E " : " ")

                        + fcn_Numero_Unidade(strNumero) + ((Decimal.Parse(strNumero) > 1) ? " CENTAVOS " : " CENTAVO ");

                    }

                    else if (dblCentavos > (decimal)0.1 && dblCentavos < (decimal)0.2)
                    {

                        strNumero = Right(((Decimal.Round(dblCentavos, 2) - (decimal)0.1).ToString().Trim()), 1);

                        strValorExtenso = strValorExtenso + ((Decimal.Parse(dblCentavos.ToString()) > 0) ? " E " : " ")

                        + fcn_Numero_Dezena0(strNumero) + " CENTAVOS ";

                    }

                    else
                    {

                        if (dblCentavos > 0) //0#
                        {

                            strNumero = Right(dblCentavos.ToString().Trim(), 2);//Mid(dblCentavos.ToString().Trim(), 0, 1);//
                            //MessageBox.Show(strNumero);
                            strValorExtenso = strValorExtenso + ((int.Parse(strNumero) > 0) ? " E " : "")//((int.Parse(dblCentavos.ToString()) > 0) ? " e " : " ")

                            + fcn_Numero_Dezena1(Left(strNumero, 1));

                            if ((dblCentavos.ToString().Trim().Length) > 2)
                            {

                                strNumero = Right((Decimal.Round(dblCentavos, 2)).ToString().Trim(), 1);

                                if (int.Parse(strNumero) > 0)
                                {

                                    if (Mid(strValorExtenso.Trim(), strValorExtenso.Trim().Length - 2, 1) == "E")
                                    {

                                        strValorExtenso = strValorExtenso + " " + fcn_Numero_Unidade(strNumero);

                                    }

                                    else
                                    {

                                        strValorExtenso = strValorExtenso + " E " + fcn_Numero_Unidade(strNumero);

                                    }

                                }

                            }

                            strValorExtenso = strValorExtenso + " CENTAVOS ";

                        }

                    }

                }

                if (dblValorInteiro < 1) strValorExtenso = Mid(strValorExtenso.Trim(), 2, strValorExtenso.Trim().Length -

                2);

            }

            return strValorExtenso.Trim();

        }



        private string fcn_Numero_Dezena0(string pstrDezena0)
        {

            //Vetor que irá conter o número por extenso

            try
            {
                String[] array_Dezena0 = new String[10];

                array_Dezena0[1] = "ONZE";

                array_Dezena0[2] = "DOZE";

                array_Dezena0[3] = "TREZE";

                array_Dezena0[4] = "QUATORZE";

                array_Dezena0[5] = "QUINZE";

                array_Dezena0[6] = "DEZESSEIS";

                array_Dezena0[7] = "DEZESSETE";

                array_Dezena0[8] = "DEZOITO";

                array_Dezena0[9] = "DEZENOVE";

                return array_Dezena0[(Convert.ToInt32(pstrDezena0))].ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível colocar o valor por extenso");
                string erro = "erro";
                return erro;
            }
        }



        private string fcn_Numero_Dezena1(string pstrDezena1)
        {

            //Vetor que irá conter o número por extenso

            String[] array_Dezena1 = new String[10];

            array_Dezena1[1] = "DEZ";

            array_Dezena1[2] = "VINTE";

            array_Dezena1[3] = "TRINTA";

            array_Dezena1[4] = "QUARENTA";

            array_Dezena1[5] = "CINQUENTA";

            array_Dezena1[6] = "SESSENTA";

            array_Dezena1[7] = "SETENTA";

            array_Dezena1[8] = "OITENTA";

            array_Dezena1[9] = "NOVENTA";

            return array_Dezena1[Convert.ToInt32(pstrDezena1)].ToString();

        }



        private string fcn_Numero_Centena(string pstrCentena)
        {

            //Vetor que irá conter o número por extenso

            String[] array_Centena = new String[10];

            array_Centena[1] = "CEM";

            array_Centena[2] = "DUZENTOS";

            array_Centena[3] = "TREZENTOS";

            array_Centena[4] = "QUATROCENTOS";

            array_Centena[5] = "QUINHENTOS";

            array_Centena[6] = "SEISCENTOS";

            array_Centena[7] = "SETECENTOS";

            array_Centena[8] = "OITOCENTOS";

            array_Centena[9] = "NOVECENTOS";

            return array_Centena[(Convert.ToInt32(pstrCentena))].ToString();

        }



        private string fcn_Numero_Unidade(string pstrUnidade)
        {

            //Vetor que irá conter o número por extenso
            String[] array_Unidade = new String[10];
            //ArrayList array_Unidade = new ArrayList();

            array_Unidade[1] = "UM";

            array_Unidade[2] = "DOIS";

            array_Unidade[3] = "TRÊS";

            array_Unidade[4] = "QUATRO";

            array_Unidade[5] = "CINCO";

            array_Unidade[6] = "SEIS";

            array_Unidade[7] = "SETE";

            array_Unidade[8] = "OITO";

            array_Unidade[9] = "NOVE";

            return array_Unidade[(Convert.ToInt32(pstrUnidade))].ToString();

        }


        //Começa aqui os Métodos de Compatibilazação com VB 6 .........Left() Right() Mid()

        public static string Left(string param, int length)
        {

            //we start at 0 since we want to get the characters starting from the

            //left and with the specified lenght and assign it to a variable

            if (param == "")

                return "";

            string result = param.Substring(0, length);

            //return the result of the operation

            return result;

        }



        public static string Right(string param, int length)
        {

            //start at the index based on the lenght of the sting minus

            //the specified lenght and assign it a variable

            if (param == "")

                return "";

            string result = param.Substring(param.Length - length, length);

            //return the result of the operation

            return result;

        }



        public static string Mid(string param, int startIndex, int length)
        {

            //start at the specified index in the string ang get N number of

            //characters depending on the lenght and assign it to a variable

            string result = param.Substring(startIndex, length);

            //return the result of the operation

            return result;

        }



        public static string Mid(string param, int startIndex)
        {

            //start at the specified index and return all characters after it

            //and assign it to a variable

            string result = param.Substring(startIndex);

            //return the result of the operation

            return result;

        }



        private void tb_cliente_DoubleClick(object sender, EventArgs e)
        {

        }

        public Boolean criar_arquivo(String Name)
        {
            StreamWriter Arquivo;

            try
            {

                Arquivo = new StreamWriter("c:\\evolucao_dokinos\\NFE\\TXT\\" + Name);


                //Arquivo.
                Arquivo.Close();
                return true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                return false;

            }

        }


        private string transforma_zero(int tamanho_pretendido, int casas_decimais, string valor)
        {
            novo_valor = "";
            int tamanho_atual = valor.Length;
            int pos_virgula = 0;
            //int qtde_zeros_antes = 0;
            int qtde_zeros_depois = 0;
            if (valor.Contains(","))
            {
                while (valor[pos_virgula].ToString() != ",")
                {
                    pos_virgula++;
                }
                pos_virgula++; //por que começa com 0
                qtde_zeros_depois = casas_decimais - (tamanho_atual - pos_virgula);
                //MessageBox.Show(tamanho_atual.ToString());
                //MessageBox.Show(pos_virgula.ToString());
            }
            else
                qtde_zeros_depois = 4;
            if (casas_decimais == 0)
                qtde_zeros_depois = 0;
            for (int qtde_zeros = 0; qtde_zeros < qtde_zeros_depois; qtde_zeros++)
                valor = valor + "0";

            valor = valor.Replace(",", "");
            //MessageBox.Show(valor);
            return zero(tamanho_pretendido, valor);




        }

        private string depois(int tamanho_pretendido, string valor)
        {
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = valor + " ";
            }
            return valor;
        }
        private string transforma(int tamanho_pretendido, string valor)
        {
            valor = zero(tamanho_pretendido, valor);
            novo_valor = "";
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido; p++)
            {

                novo_valor = novo_valor + valor[p].ToString();
                //MessageBox.Show(novo_valor);
            }

            return novo_valor;

        }

        private string espaco_depois(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = valor + " ";
            }
            return valor;
        }

        private string zero(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = " " + valor;
            }
            return valor;
        }




        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position = 100000000;
        }

        private void b(object sender, EventArgs e)
        {

        }

        private void tb_n_nf_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_n_nf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            abre_nova();
        }

        private void abre_nova()
        {
            form_pesquisa_nf abre_nf = new form_pesquisa_nf();
            try
            {
                //this.Close();
                abre_nf.ShowDialog();
            }
            finally
            {
                abre_nf.Dispose();
                try
                {
                    dsNota_fiscal.Clear();
                    dsItens_nota.Clear();
                    dsFatura_nf.Clear();

                    nf_atual = abre_nf.nf_escolhida;
                    this.datNota_fiscal.SelectCommand.CommandText =
                    "SELECT * FROM NOTA_FISCAL WHERE N_NF = '" + nf_atual + "'";
                    /*"SELECT n.*, pv.vendedor_ped_venda " + 
                    "FROM NOTA_FISCAL n " + 
                    "INNER JOIN pedidos_nf pnf " + 
                    "ON pnf.nf_pedido_nf = n.n_nf " + 
                    "INNER JOIN pedidos_venda pv " + 
                    "ON pv.cod_ped_venda = pnf.n_pedido_nf " + 
                    "WHERE n.n_nf = '" + nf_atual + "'";*/
                    this.fbConnection1.Open();
                    this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                    this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                    datNota_fiscal.Fill(NOTA_FISCAL);
                    this.fbConnection1.Close();

                    this.datItens_nota.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' ORDER BY COD_ITENS_NOTA";
                    this.fbConnection1.Open();
                    this.datItens_nota.SelectCommand.Connection = fbConnection1;
                    this.datItens_nota.SelectCommand.ExecuteNonQuery();
                    datItens_nota.Fill(ITENS_NOTA);
                    this.fbConnection1.Close();

                    this.datFatura_nf.SelectCommand.CommandText =
                    "SELECT * FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                    this.fbConnection1.Open();
                    this.datFatura_nf.SelectCommand.Connection = fbConnection1;
                    this.datFatura_nf.SelectCommand.ExecuteNonQuery();
                    datFatura_nf.Fill(FATURA_NF);
                    this.fbConnection1.Close();


                    dsPedidos_nf.Clear();
                    this.datPedidos_nf.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDOS_NF WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";
                    /*"SELECT pnf.*, pv.vendedor_ped_venda " + 
                    "FROM PEDIDOS_NF pnf " + 
                    "INNER JOIN pedidos_venda pv " + 
                    "ON pv.cod_ped_venda = pnf.n_pedido_nf " + 
                    "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";*/
                    this.fbConnection1.Open();
                    this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                    this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                    datPedidos_nf.Fill(PEDIDOS_NF);
                    this.fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            inserir_itens();

        }
        private void inserir_itens()
        {
            if (tb_protocolo_autorizacao.Text == "")
            {
                Atualizar(false);

                try
                {
                    
                    if (tb_qtde_peca.Text == "" || tb_descricao_peca.Text == "" || tb_unid_peca.Text == "" ||
                        tb_ncm_peca.Text == "" || tb_cfo_peca.Text == "" || tb_preco_unit_peca.Text == "")
                    {
                        MessageBox.Show("Os itens: Descrição, Unidade, Qtde, Preço Unitário, NCM e CFOP são obrigatórios");
                        //tb_qtde_peca.Focus();

                    }

                    else
                    {
                        double preco_unit = Convert.ToDouble(tb_preco_unit_peca.Text);
                        double qtde = Convert.ToDouble(tb_qtde_peca.Text);

                        double preco_total = preco_unit * qtde;
                        string preco_unit_ponto = preco_unit.ToString().Replace(',', '.');
                        string preco_total_ponto = preco_total.ToString().Replace(',', '.');
                        string qtde_ponto = qtde.ToString().Replace(",", ".");
                        string prestacao_servico = "0";
                        string cfop;

                        //Se não for zero, então o sistema deverá deixar o campo vazio para buscar a CFOP automaticamente
                        if (tb_cfo_peca.Text == "0")
                        {
                            tb_cfo_peca.Text = "";
                        }
                        
                        if (cb_prestacao_servico.Checked == true)
                        {
                            prestacao_servico = "1";
                        }

                        string cod = "null", frete = "null", desconto = "null", outras_desp = "null", seguro = "null", ean = "null";
                        if (tb_cod_peca.Text != "")
                            cod = tb_cod_peca.Text;
                        if (tb_ean.Text != "")
                            ean = "'" + tb_ean.Text + "'";
                        if (tb_frete_item.Text != "")
                            frete = "'" + tb_frete_item.Text.Replace(".", "").Replace(",", ".") + "'";
                        if (tb_desconto_item.Text != "")
                            desconto = "'" + tb_desconto_item.Text.Replace(".", "").Replace(",", ".") + "'";
                        if (tb_outras_desp_item.Text != "")
                            outras_desp = "'" + tb_outras_desp_item.Text.Replace(".", "").Replace(",", ".") + "'";
                        if (tb_seguro_item.Text != "")
                            seguro = "'" + tb_seguro_item.Text.Replace(".", "").Replace(",", ".") + "'";
                        string pedido_compra = "null", item_pedido_compra = "null";
                        if (tb_pedido_compra.Text != "")
                            pedido_compra = "'" + tb_pedido_compra.Text + "'";
                        if (tb_n_item_pedido_compra.Text != "")
                            item_pedido_compra = "'" + tb_n_item_pedido_compra.Text + "'";
                        string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                            _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                            _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                            _tipo_cofins, _cst_cofins, _pCredICMS;


                        buscar_informacoes_produto(tb_cod_peca.Text, out _origem, out _cst, out _modalidade, out _icms,
                            out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                            out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                            out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                            out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);

                        if (tb_cfo_peca.Text == "")
                        {
                            if (tb_estado_cliente.Text == "SP")
                            {
                                if (rb_1904.Checked || rb_5904.Checked || rb_5910.Checked || rb_5202.Checked)
                                {
                                    if (rb_1904.Checked)
                                        tb_cfo_peca.Text = "1904";
                                    if (rb_5904.Checked)
                                        tb_cfo_peca.Text = "5904";
                                    if (rb_5910.Checked)
                                        tb_cfo_peca.Text = "5910";
                                    if (rb_5202.Checked)
                                        tb_cfo_peca.Text = "5202";
                                }
                                else
                                {
                                    if (_cst == "60")
                                    {
                                        tb_cfo_peca.Text = "5405";
                                    }
                                    if (_cst == "20")
                                    {
                                        tb_cfo_peca.Text = "5102";
                                    }
                                    if (_cst == "00")
                                    {
                                        tb_cfo_peca.Text = "5102";
                                    }
                                }
                            }
                            else
                                tb_cfo_peca.Text = "6404";
                        }

                        if (verificar_se_e_tributada(tb_cfo_peca.Text))
                        {
                            tabControl1.SelectedTab = tabPage5;
                            cbTributada.Checked = true;
                            tabControl1.SelectedTab = tabPage1;
                        }
                        else
                        {
                            tabControl1.SelectedTab = tabPage5;
                            cbNaoTributada.Checked = true;
                            rb_ipi_nao_tributado.Checked = true;
                            tabControl1.SelectedTab = tabPage1;
                        }

                        this.datItens_nota.InsertCommand.CommandText =
                        "INSERT INTO ITENS_NOTA (DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, PRECO_UNIT_ITEM," +
                        "PRECO_TOTAL_ITEM, NF_ITEM, NCM_ITEM, CFOP_ITEM, PRESTACAO_SERVICO_ITEM, COD_ITEM," +
                        "PEDIDO_COMPRA_ITEM, ITEM_PEDIDO_COMPRA_ITEM, VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM," +
                        "VALOR_OUTRAS_DESP_ITEM, VALOR_SEGURO_ITEM, COD_EAN_ITEM)" +
                        "VALUES ('" + tb_descricao_peca.Text + "','" + tb_unid_peca.Text + "','" + qtde_ponto +
                        "','" + preco_unit_ponto + "','" + preco_total_ponto + "','" + tb_n_nf.Text + "','" +
                        tb_ncm_peca.Text + "','" + tb_cfo_peca.Text + "','" + prestacao_servico + "'," + cod +
                        "," + pedido_compra + "," + item_pedido_compra + "," + frete + "," + desconto + "," +
                        outras_desp + "," + seguro + "," + ean + ")";
                        this.fbConnection1.Open();
                        this.datItens_nota.InsertCommand.Connection = fbConnection1;
                        this.datItens_nota.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        dsItens_nota.Clear();
                        this.datItens_nota.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' order by cod_itens_nota";
                        this.fbConnection1.Open();
                        this.datItens_nota.SelectCommand.Connection = fbConnection1;
                        this.datItens_nota.SelectCommand.ExecuteNonQuery();
                        datItens_nota.Fill(ITENS_NOTA);
                        this.fbConnection1.Close();


                        /*
                        buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
                            out _icms_st, out _reducao, out _iva, out _ipi, out _pis, out _cofins,
                            out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                            out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                            out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);
                        */

                        classeTributacao trib = new classeTributacao();
                        //PREENCHENDO VALORES SE ELES NÃO TIVEREM SIDO PREENCHIDOS JÁ
                        if (tb_cst.Text == "")
                            tb_cst.Text = _cst;
                        if (tb_mod_bc_item.Text == "")
                            tb_mod_bc_item.Text = _modalidade;
                        if (tb_mod_bc_st_item.Text == "")
                            tb_mod_bc_st_item.Text = _modalidade_st;
                        if (tb_origem_peca.Text == "")
                            tb_origem_peca.Text = _origem;
                        if (tb_icms_item.Text == "")
                            tb_icms_item.Text = _icms;
                        if (tb_icms_st.Text == "")
                            tb_icms_st.Text = _icms_st;
                        if (tb_reducao_item.Text == "")
                            tb_reducao_item.Text = _reducao;
                        if (tb_reducao_st_item.Text == "")
                            tb_reducao_st_item.Text = _reducao_st;
                        if (tb_iva_item.Text == "")
                            tb_iva_item.Text = _iva;
                        if (tb_ipi_item.Text == "")
                            tb_ipi_item.Text = _ipi;
                        if (tb_pis_item.Text == "")
                            tb_pis_item.Text = _pis;
                        if (tb_cofins_item.Text == "")
                            tb_cofins_item.Text = _cofins;
                        if (tb_iss_item.Text == "")
                            tb_iss_item.Text = _iss;
                        if (tb_origem_peca.Text == "")
                            tb_origem_peca.Text = _origem;
                        if (tb_aliquota_credito.Text == "")
                        {
                            tb_aliquota_credito.Text = _pCredICMS;
                        }
                        if (cbBC_com_ipi.Checked == false)
                        {
                            if (_bc_com_ipi == "1")
                                cbBC_com_ipi.Checked = true;
                        }
                        if ((rb_ipi_tributado.Checked == false && rb_ipi_nao_tributado.Checked == false))
                        {
                            if (_ipi_tributado == "1")
                            {
                                rb_ipi_tributado.Checked = true;
                            }
                            if (_ipi_n_tributado == "1" || !verificar_se_e_tributada(tb_cfo_peca.Text))
                            {
                                rb_ipi_nao_tributado.Checked = true;
                            }
                        }
                        if ((tb_cst_ipi_tributado.Text == "" || tb_cst_ipi_n_tributado.Text == ""))
                        {
                            if (_ipi_tributado == "1")
                            {
                                tb_cst_ipi_tributado.Text = _cst_ipi_tributado;
                            }
                            if (_ipi_n_tributado == "1" || !verificar_se_e_tributada(tb_cfo_peca.Text))
                            {
                                tb_cst_ipi_n_tributado.Text = _cst_ipi_n_tributado;
                            }
                        }
                        if (tb_tipo_pis.Text == "")
                        {
                            tb_tipo_pis.Text = _tipo_pis;
                        }
                        if (tb_cst_pis.Text == "")
                        {
                            tb_cst_pis.Text = _cst_pis;
                        }
                        if (tb_tipo_cofins.Text == "")
                        {
                            tb_tipo_cofins.Text = _tipo_cofins;
                        }
                        if (tb_cst_cofins.Text == "")
                        {
                            tb_cst_cofins.Text = _cst_cofins;
                        }


                        //SE FOR CFOP TRIBUTADA
                        if (cbTributada.Checked == true)
                        {



                            //TRIBUTACAO
                            //VALORES PADROES


                            trib.modBC = tb_mod_bc_item.Text[0].ToString();
                            trib.orig = tb_origem_peca.Text[0].ToString();
                            // SE FOR SIMPLES NACIONAL
                            if (_crt == "1")
                            {
                                double valor_ipi = 0;
                                trib.vBC = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                if (tb_cst.Text == "101")
                                {
                                    trib.CST = "101";
                                    trib.pCredSN = Convert.ToDouble(tb_aliquota_credito.Text);
                                    tb_aliquota_simples.Text = tb_aliquota_credito.Text;

                                    trib.cst101();
                                    trib.vBC = 0;
                                }
                                if (tb_cst.Text == "102")
                                {
                                    trib.CST = "102";
                                    trib.vBC = 0;
                                    //NÃO PRECISA DE MAIS NENHUMA INFORMAÇÃO
                                }
                                if (tb_cst.Text == "201")
                                {
                                    trib.CST = "201";
                                    trib.pCredSN = Convert.ToDouble(tb_aliquota_credito.Text);
                                    tb_aliquota_simples.Text = tb_aliquota_credito.Text;
                                    trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                    trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                    trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                    trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                    trib.cst201();
                                }
                                if (tb_cst.Text == "202")
                                {
                                    trib.CST = "202";
                                    trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                    trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                    trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                    trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                    trib.cst202();
                                }
                                if (tb_cst.Text == "500")
                                {
                                    trib.CST = "500";
                                    try
                                    {
                                        trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                        trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                    }
                                    catch
                                    {
                                        trib.pICMSST = Convert.ToDouble("0");
                                        trib.pMVAST = Convert.ToDouble("0");
                                    }

                                    trib.cst500();
                                }
                                //IPI
                                trib.cstIPINaoTributado = tb_cst_ipi_n_tributado.Text.Remove(2);
                                trib.ipiNaoTributado = true;
                                //PIS
                                trib.cstPIS = tb_cst_pis.Text.Remove(2);
                                trib.tipoPIS = tb_tipo_pis.Text;
                                //COFINS
                                trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                                trib.tipoCOFINS = tb_tipo_cofins.Text;
                                //ISS
                                if (tb_iss_item.Text != "")
                                {
                                    trib.BCISS = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                    trib.pISS = Convert.ToDouble(tb_iss_item.Text);
                                    trib.tipoISS = tb_tipo_servico.Text;
                                    trib.calcular_iss();
                                }
                            }
                            //SE FOR REGIME NORMAL
                            if (_crt == "3")
                            {
                                double valor_ipi = 0;
                                //IPI
                                if (rb_ipi_tributado.Checked == true)
                                {
                                    trib.BCIPI = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                    trib.pIPI = Convert.ToDouble(tb_ipi_item.Text);
                                    trib.cstIPITributado = tb_cst_ipi_tributado.Text.Remove(2);
                                    trib.ipiTributado = true;
                                    trib.calcular_ipi();
                                }
                                else
                                {
                                    trib.cstIPINaoTributado = tb_cst_ipi_n_tributado.Text.Remove(2);
                                    trib.ipiNaoTributado = true;
                                }
                                //PIS

                                if (tb_pis_item.Text != "")
                                {
                                    trib.BCPIS = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                    trib.pPIS = Convert.ToDouble(tb_pis_item.Text);
                                    trib.cstPIS = tb_cst_pis.Text.Remove(2);
                                    trib.tipoPIS = tb_tipo_pis.Text;
                                    trib.calcular_pis();
                                }
                                else
                                {
                                    trib.cstPIS = tb_cst_pis.Text.Remove(2);
                                    trib.tipoPIS = tb_tipo_pis.Text;
                                }
                                //COFINS
                                if (tb_cofins_item.Text != "")
                                {
                                    trib.BCCOFINS = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                    trib.pCOFINS = Convert.ToDouble(tb_cofins_item.Text);
                                    trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                                    trib.tipoCOFINS = tb_tipo_cofins.Text;
                                    trib.calcular_cofins();
                                }
                                else
                                {
                                    trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                                    trib.tipoCOFINS = tb_tipo_cofins.Text;
                                }
                                //ISS
                                if (tb_iss_item.Text != "")
                                {
                                    trib.BCISS = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                    trib.pISS = Convert.ToDouble(tb_iss_item.Text);
                                    trib.tipoISS = tb_tipo_servico.Text;
                                    trib.calcular_iss();
                                }
                                //ICMS

                                if (cbBC_com_ipi.Checked == true) //SE O IPI VIER EMBUTIDO NA BC DO ICMS
                                    valor_ipi = trib.vIPI;
                                trib.vBC = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);

                                if (tb_cst.Text == "00")//TRIBUTADA INTEGRALMENTE
                                {
                                    trib.CST = "00";
                                    trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                    trib.cst00();
                                }
                                if (tb_cst.Text == "10")//SUBST. TRIBUTARIA
                                {
                                    trib.CST = "10";
                                    trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                    trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                    trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                    trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                    trib.cst10();
                                }
                                if (tb_cst.Text == "20")//REDUCAO DE BC
                                {
                                    trib.CST = "20";
                                    trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                    trib.pRedBC = Convert.ToDouble(tb_reducao_item.Text);
                                    trib.cst20();
                                }
                                if (tb_cst.Text == "60")//ST COBRADA ANTERIORMENTE
                                {
                                    trib.CST = "60";
                                    trib.pICMS = 0;
                                    trib.pICMSST = 0;
                                    trib.vBC = 0;
                                    trib.cst60();
                                }
                                if (tb_cst.Text == "70")//SUBST. TRIBUTARIA
                                {
                                    trib.CST = "70";
                                    trib.pICMS = tb_icms_item.Text != "" ? Convert.ToDouble(tb_icms_item.Text) : 0;
                                    trib.pICMSST = tb_icms_st.Text != "" ? Convert.ToDouble(tb_icms_st.Text) : 0;
                                    trib.pMVAST = tb_iva_item.Text != "" ? Convert.ToDouble(tb_iva_item.Text) : 0;
                                    trib.pRedBC = tb_reducao_item.Text != "" ? Convert.ToDouble(tb_reducao_item.Text) : 0;
                                    trib.pRedBCST = tb_reducao_st_item.Text != "" ? Convert.ToDouble(tb_reducao_st_item.Text) : 0;
                                    trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                    trib.cst70();
                                }
                            }
                        }
                        else
                        {
                            trib.modBC = tb_mod_bc_item.Text[0].ToString();
                            trib.orig = tb_origem_peca.Text[0].ToString();
                            if (_crt == "1") //NÃO TRIBUTADA SIMPLES
                            {
                                tb_cst.Text = "400"; //NÃO TRIBUTADA
                                if (tb_mod_bc_item.Text == "")
                                    tb_mod_bc_item.Text = _modalidade;
                                if (tb_origem_peca.Text == "")
                                    tb_origem_peca.Text = _origem;
                                trib.CST = "400";
                            }
                            else //NÃO TRIBUTADA REGIME NORMAL
                            {

                                if (tb_cst.Text == "41")
                                    trib.CST = "41";
                                else
                                {
                                    if (tb_cst.Text == "40")
                                        trib.CST = "40";
                                    else
                                    {
                                        if (tb_cst.Text == "50")
                                            trib.CST = "50";
                                        else
                                            trib.CST = "41";
                                    }
                                }



                            }
                            trib.cstIPINaoTributado = tb_cst_ipi_n_tributado.Text.Remove(2);
                            trib.ipiNaoTributado = true;
                            trib.cstPIS = tb_cst_pis.Text.Remove(2);
                            trib.tipoPIS = tb_tipo_pis.Text;
                            trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                            trib.tipoCOFINS = tb_tipo_cofins.Text;

                        }
                        //UPDATE NO BANCO
                        trib.inserir_informacoes_item(buscar_ultimo_produto_inserido());
                        dsItens_nota.Clear();
                        this.datItens_nota.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' ORDER BY COD_ITENS_NOTA";
                        this.fbConnection1.Open();
                        this.datItens_nota.SelectCommand.Connection = fbConnection1;
                        this.datItens_nota.SelectCommand.ExecuteNonQuery();
                        datItens_nota.Fill(ITENS_NOTA);
                        this.fbConnection1.Close();
                    }
                    inserir_natureza();

                    HasTextBox(itemPanel);

                    calcular();
                    tb_descricao_peca.Focus();
                    Atualizar(false);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                    fbConnection1.Close();
                }
            }
            else
            {
                MessageBox.Show("NFe já autorizada");
            }

        }

        private string buscar_ultimo_produto_inserido()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_ITENS_NOTA FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text +
                    "' ORDER BY COD_ITENS_NOTA DESC";
                FbDataAdapter datSelect = new FbDataAdapter();
                DataSet dsSelect = new DataSet();
                datSelect.SelectCommand = select;
                datSelect.Fill(dsSelect);
                DataRow dr = dsSelect.Tables[0].Rows[0];
                fbConnection1.Close();
                if (dsSelect.Tables[0].Rows.Count > 0)
                    return dr[0].ToString();
                else
                {
                    MessageBox.Show("Não encontrado ultimo registro");
                    return "NÃO ENCONTRADO";
                }
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar ultimo item");
                return "ERRO";

            }

        }

        private void buscar_informacoes_produto(string cod_peca, out string _origem, out string _cst,
            out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
            out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
            out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
            out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
            out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
            out string _cst_cofins, out string _pCredICMS)
        {
            _cst = ""; _origem = ""; _modalidade = ""; _icms = ""; _icms_st = ""; _reducao = ""; _reducao_st = ""; _iva = ""; _ipi = "";
            _pis = ""; _cofins = ""; _iss = ""; _crt = ""; _aliquota_credito = ""; _modalidade_st = ""; _bc_com_ipi = "";
            _ipi_tributado = ""; _ipi_n_tributado = ""; _cst_ipi_tributado = ""; _cst_ipi_n_tributado = "";
            _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = "";
            try
            {
                //SE NÃO TIVER INFORMAÇÃO NO PRODUTO PEGARÁ A INFORMAÇÃO PADRÃO
                buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
                            out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                            out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                            out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                            out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod_peca + "'";
                fbConnection1.Open();
                FbDataAdapter produtosDataAdapter = new FbDataAdapter();
                produtosDataAdapter.SelectCommand = select;
                DataSet produtosDataSet = new DataSet();
                produtosDataAdapter.Fill(produtosDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in produtosDataSet.Tables[0].Rows)
                {
                    if (!pessoa_fisica(tb_cnpj_cliente.Text))
                    {
                        if (tb_estado_cliente.Text == "SP")
                        {
                            _cst = dr["ST_SAIDA_PRODUTO"].ToString();
                            _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                            _icms_st = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                            _reducao = dr["REDUCAO_ICMS_PRODUTO"].ToString();
                            _reducao_st = dr["REDUCAO_ST_PRODUTO"].ToString();
                            _iva = dr["IVA_PRODUTO"].ToString();
                        }
                        else  //FORA DO ESTADO
                        {
                            _cst = dr["ST_SAIDA_FORA_PRODUTO"].ToString();
                            _icms = dr["ALIQUOTA_FORA_ICMS_PRODUTO"].ToString();
                            _icms_st = dr["ALIQUOTA_ICMS_ST_FORA_PRODUTO"].ToString();
                            _reducao = dr["REDUCAO_FORA_PRODUTO"].ToString();
                            _reducao_st = dr["REDUCAO_ST_FORA_PRODUTO"].ToString();
                            _iva = dr["IVA_FORA_PRODUTO"].ToString();
                        }
                    }
                    else
                    {
                        //_cst = "00";
                        _cst = dr["ST_SAIDA_PRODUTO"].ToString();
                        if (_cst != "60")
                        {
                            _cst = "00";
                            _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                        }
                    }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private bool pessoa_fisica(string cnpj)
        {
            bool retorno = false;
            try
            {

                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                //comando_select.Connection = fbConnection1;
                FbDataAdapter cli = new FbDataAdapter();
                cli.SelectCommand = comando;
                DataSet cliente = new DataSet();
                cli.Fill(cliente);
                fbConnection1.Close();
                DataRow dr = cliente.Tables[0].Rows[0];
                if (dr["PESSOA_FISICA_CLIENTE"].ToString() == "1")
                    retorno = true;
                else
                    retorno = false;
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }


        protected void HasTextBox(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                if (c.HasChildren)
                {
                    HasTextBox(c);
                }
            }
            foreach (Control d in ctrl.Controls)
            {
                if (d is System.Windows.Forms.RadioButton)
                {
                    ((System.Windows.Forms.RadioButton)(d)).Checked = false;
                }

                if (d.HasChildren)
                {
                    HasTextBox(d);
                }
            }
            foreach (Control e in ctrl.Controls)
            {
                if (e is System.Windows.Forms.CheckBox)
                {
                    ((System.Windows.Forms.CheckBox)(e)).Checked = false;
                }

                if (e.HasChildren)
                {
                    HasTextBox(e);
                }
            }
        }



        private void LimpaCampos(Control controls)
        {
            foreach (Control ctrl in controls.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)(ctrl)).Text = string.Empty;
                }
                if (ctrl is System.Windows.Forms.CheckBox)
                {
                    ((System.Windows.Forms.CheckBox)(ctrl)).Checked = false;
                }
                if (ctrl is System.Windows.Forms.RadioButton)
                {
                    ((System.Windows.Forms.RadioButton)(ctrl)).Checked = false;
                }

            }
        }



        private double calcular_bc(string frete, string desconto,
            string outras_desp, string seguro, string preco_total_ponto, double valor_ipi)
        {
            double _frete = 0, _desconto = 0, _outras_desp = 0, _seguro = 0, _preco_total = 0;
            try
            {
                _frete = Convert.ToDouble(frete);
            }
            catch { }
            try
            {
                _desconto = Convert.ToDouble(desconto);
            }
            catch { }
            try
            {
                _outras_desp = Convert.ToDouble(outras_desp);
            }
            catch { }
            try
            {
                _seguro = Convert.ToDouble(seguro);
            }
            catch { }
            try
            {
                _preco_total = Convert.ToDouble(preco_total_ponto);
            }
            catch { }
            return _preco_total + _frete + _outras_desp + _seguro - _desconto + valor_ipi;

        }

        private void buscar_informacoes_padrao(out string _origem, out string _cst, out string _modalidade,
            out string _icms, out string _icms_st, out string _reducao, out string _reducao_st, out string _iva, out string _ipi,
            out string _pis, out string _cofins, out string _iss, out string _crt, out string _aliquota_credito,
            out string _modalidade_st, out string _bc_com_ipi,
            out string _ipi_tributado, out string _ipi_n_tributado,
            out string _cst_ipi_tributado, out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis,
            out string _tipo_cofins, out string _cst_cofins, out string _pCredICMS)
        {
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * FROM EMPRESA";
            fbConnection1.Open();
            DataSet inf_padrao = new DataSet();
            datEmpresa.SelectCommand = comando;
            datEmpresa.Fill(inf_padrao);
            fbConnection1.Close();
            DataRow dr = inf_padrao.Tables[0].Rows[0];
            _origem = dr["ORIGEM_EMPRESA"].ToString();
            _cst = dr["CST_EMPRESA"].ToString();
            _modalidade = dr["MOD_BC_EMPRESA"].ToString();
            _icms = dr["ICMS_EMPRESA"].ToString();
            _icms_st = dr["ICMS_ST_EMPRESA"].ToString();
            _reducao = dr["REDUCAO_EMPRESA"].ToString();
            _reducao_st = dr["REDUCAO_ST_EMPRESA"].ToString();
            _iva = dr["IVA_EMPRESA"].ToString();
            _ipi = dr["IPI_EMPRESA"].ToString();
            _pis = dr["PIS_EMPRESA"].ToString();
            _cofins = dr["COFINS_EMPRESA"].ToString();
            _iss = dr["ISS_EMPRESA"].ToString();
            _crt = dr["CRT_EMPRESA"].ToString();
            _aliquota_credito = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
            _modalidade_st = dr["MOD_BC_ST_EMPRESA"].ToString();
            _bc_com_ipi = dr["BC_COM_IPI_EMPRESA"].ToString();
            _ipi_tributado = dr["IPI_TRIB_EMPRESA"].ToString();
            _ipi_n_tributado = dr["IPI_N_TRIB_EMPRESA"].ToString();
            _cst_ipi_tributado = dr["CST_IPI_TRIB_EMPRESA"].ToString();
            _cst_ipi_n_tributado = dr["CST_IPI_N_TRIB_EMPRESA"].ToString();
            _tipo_pis = dr["TIPO_PIS_EMPRESA"].ToString();
            _cst_pis = dr["CST_PIS_EMPRESA"].ToString();
            _tipo_cofins = dr["TIPO_COFINS_EMPRESA"].ToString();
            _cst_cofins = dr["CST_COFINS_EMPRESA"].ToString();
            _pCredICMS = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
        }
        private bool verificar_se_e_tributada(string n_cfo)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT TRIBUTADA_CFO FROM CFO WHERE N_CFO = '" + n_cfo + "'";
                fbConnection1.Open();
                DataSet cfo = new DataSet();
                datCfo.SelectCommand = comando;
                datCfo.Fill(cfo);
                fbConnection1.Close();
                if (cfo.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Existem 2 CFOPs com o mesmo código, verifique.");
                    return false;
                }
                else
                {
                    DataRow dr = cfo.Tables[0].Rows[0];
                    if (dr[0].ToString() == "1")
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(abre_nf.ToString());
                fbConnection1.Close();
                return false;
            }

        }

        private void inserir_natureza()
        {
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * FROM CFO WHERE N_CFO = '" + tb_cfo_peca.Text + "'";
            DataSet cfo = new DataSet();
            fbConnection1.Open();
            datCfo.SelectCommand = comando;
            datCfo.Fill(cfo);
            string descricao = "";
            string observacao = "";
            foreach (DataRow dr in cfo.Tables[0].Rows)
            {
                descricao = dr["DESCRICAO_CFO"].ToString();
                observacao = dr["OBSERVACAO_CFO"].ToString();
            }

            this.fbConnection1.Close();
            if (tb_natureza_operacao.Text.Contains(descricao) == false)
            {
                if (tb_natureza_operacao.Text == "")
                    tb_natureza_operacao.Text = descricao;
                else
                    tb_natureza_operacao.Text = tb_natureza_operacao.Text + "/" + descricao;
            }

            if (tb_dados_adicionais.Text.Contains(observacao) == false)
            {

                if (tb_dados_adicionais.Text == "")
                    tb_dados_adicionais.Text = observacao;
                else
                    tb_dados_adicionais.Text = tb_dados_adicionais.Text + " / " + observacao;

            }
        }
        /*
        private string verificar_variavel_trib()
        {
            comando_select.CommandText = "SELECT * FROM EMPRESA";
            DataSet empresa = new DataSet();
            fbConnection1.Open();
            datTributacao.SelectCommand = comando_select;
            datTributacao.Fill(empresa);
            string _proprio = "", _cliente = "", _produto = "";
            foreach (DataRow dr in empresa.Tables[0].Rows)
            {

                _proprio = dr["TRIB_PROPRIA_EMPRESA"].ToString();
                _cliente = dr["TRIB_CLIENTE_EMPRESA"].ToString();
                _produto = dr["TRIB_PRODUTO_EMPRESA"].ToString();

            }
            fbConnection1.Close();

            if (_proprio == "1")
            {
                return "PROPRIA";
            }
            else
            {
                if (_cliente == "1")
                {
                    return "CLIENTE";
                }
                else
                {
                    if (_produto == "1")
                    {
                        return "PRODUTO";
                    }
                    else
                    {
                        MessageBox.Show("Você tem que escolher um tipo de tributação no cadastro da empresa");
                        return "ERRO";
                    }
                }
            }
        }

        private string verificar_cod_variavel_trib(string variavel, int linha_atual)
        {
            if (variavel == "PROPRIA")
            {
                return "1";
            }
            else
            {
                if (variavel == "CLIENTE")
                {
                    try
                    {
                        comando_select.CommandText = "SELECT COD_CLIENTE " +
                        "FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
                        DataSet cliente = new DataSet();
                        fbConnection1.Open();
                        datClientes.SelectCommand = comando_select;
                        datClientes.Fill(cliente);
                        string cliente_atual = "";
                        foreach (DataRow dr in cliente.Tables[0].Rows)
                        {

                            cliente_atual = dr["COD_CLIENTE"].ToString();
                        }

                        this.fbConnection1.Close();
                        return cliente_atual;
                    }
                    catch
                    {
                        fbConnection1.Close();
                        MessageBox.Show("Coloque um cliente válido");
                        return "0";
                    }
                }
                else
                {
                    if (variavel == "PRODUTO")
                    {
                        return dgvItens_nota.Rows[linha_atual].Cells["col_cod"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Você tem que escolher um tipo de tributação no cadastro da empresa");
                        return "0";
                    }
                }
            }
        }

        private void inserir_tributacao()
        {
            if (dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_prestacao_servico"].Value.ToString() == "1")
            {
                form_tributacao trib = new form_tributacao();
                try
                {

                    double preco_unit = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_preco_unit"].Value.ToString());
                    double qtde = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_qtde"].Value.ToString());
                    double preco_total = preco_unit * qtde;
                    trib.valor_total_prod = preco_total.ToString("n2");
                    trib.item_selecionado = dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_cod"].Value.ToString();
                    trib.inserir_nova = true;
                    trib.prestacao_servico = true;
                    
                    trib.ShowDialog();

                }
                finally
                {
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_iss"].Value = trib.valor_iss_item_2;
                    }
                    catch { }
                    string _st = "", _valor_bc_st = "", _valor_st = ""; 
                    comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                    DataSet _trib = new DataSet();
                    fbConnection1.Open();
                    datTributacao.SelectCommand = comando_select;
                    datTributacao.Fill(_trib);
                    int n = 0;
                    foreach (DataRow dr in _trib.Tables[0].Rows)
                    {

                        _st = dr["ICMS_TRI_ICM"].ToString();
                        _valor_bc_st = dr["ICMS_ST_VAL_BC_ICM"].ToString();
                        _valor_st = dr["ICMS_ST_VAL_ICM"].ToString();

                    }
                    fbConnection1.Close();
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_st"].Value = _st;
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc_st"].Value = _valor_bc_st;

                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_st"].Value = _valor_st;
                    }
                    catch { }
                    Atualizar(false);
                    //dsItens_nota.Clear();
                    //datItens_nota.Fill(ITENS_NOTA);
                    trib.Dispose();
                   
                }
            }
            else
            {
                form_tributacao trib = new form_tributacao();
                try
                {
                    double preco_unit = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_preco_unit"].Value.ToString());
                    double qtde = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_qtde"].Value.ToString());
                    double preco_total = preco_unit * qtde;
                    int linha_atual = dgvItens_nota.RowCount - 1;
                    
                    //trib.Opacity = 0;
                    trib.variavel_trib = verificar_variavel_trib();
                    trib.cod_variavel_trib = verificar_cod_variavel_trib(verificar_variavel_trib(), linha_atual);
                    trib.valor_total_prod = preco_total.ToString("n2");
                    trib.item_selecionado = dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_cod"].Value.ToString();
                    trib.inserir_nova = true;
                   
                    trib.ShowDialog();

                }
                finally
                {
                    try
                    {
                        string valor_ic = trib.valor_icm_item_2;
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = valor_ic;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = trib.ipi_item_2;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = trib.icm_item_2;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = trib.valor_bc_item_2;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = "0";
                    }
                    string _st = "", _valor_bc_st = "", _valor_st = "", _valor_ipi = "" ;
                    comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                    DataSet _trib = new DataSet();
                    fbConnection1.Open();
                    datTributacao.SelectCommand = comando_select;
                    datTributacao.Fill(_trib);
                    int n = 0;
                    foreach (DataRow dr in _trib.Tables[0].Rows)
                    {

                        _st = dr["ICMS_TRI_ICM"].ToString();
                        _valor_bc_st = dr["ICMS_ST_VAL_BC_ICM"].ToString();
                        _valor_st = dr["ICMS_ST_VAL_ICM"].ToString();
                        _valor_ipi = dr["IPI_VAL_IPI"].ToString();

                    }
                    fbConnection1.Close();
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_st"].Value = _st;
                    }
                    catch { }
                    try
                    {
                        if (_valor_bc_st != "")
                        {
                            dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc_st"].Value = _valor_bc_st;
                        }
                    }
                    catch { }
                    try
                    {
                        if (_valor_st != "")
                        {
                            dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_st"].Value = _valor_st;
                        }
                        
                    }
                    catch { }
                    try
                    {
                        if (_valor_ipi != "")
                        {
                            dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_ipi"].Value = _valor_ipi;
                        }

                    }
                    catch { }
                    
                    Atualizar(false);
                    //dsItens_nota.Clear();
                    //datItens_nota.Fill(ITENS_NOTA);
                    trib.Dispose();
                }
            }
                    
        }
         * */
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (tb_protocolo_autorizacao.Text == "")
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                   "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {
                        this.datNota_fiscal.DeleteCommand.CommandText =
                            "DELETE FROM NOTA_FISCAL WHERE N_NF = '" + tb_n_nf.Text + "'";
                        this.fbConnection1.Open();
                        this.datNota_fiscal.DeleteCommand.Connection = fbConnection1;
                        this.datNota_fiscal.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datItens_nota.DeleteCommand.CommandText =
                            "DELETE FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "'";
                        this.fbConnection1.Open();
                        this.datItens_nota.DeleteCommand.Connection = fbConnection1;
                        this.datItens_nota.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datFatura_nf.DeleteCommand.CommandText =
                            "DELETE FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                        this.fbConnection1.Open();
                        this.datFatura_nf.DeleteCommand.Connection = fbConnection1;
                        this.datFatura_nf.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        dsNota_fiscal.Clear();
                        dsItens_nota.Clear();
                        dsFatura_nf.Clear();

                        abre_nova();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Impossível excluir, NFe já foi autorizada");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            double valor_produtos = 0, ipi_total, icm_total = 0, valor_total = 0, valor_ipi_total = 0, valor_icm_total = 0,
                valor_bc_total = 0, valor_iss_total = 0, base_calculo_iss_total = 0, valor_bc_st_total = 0, valor_st_total = 0,
                valor_frete = 0, valor_desconto = 0, valor_outras_desp = 0, valor_seguro = 0, valor_simples = 0;

            for (int i = 0; i <= dgvItens_nota.RowCount - 1; i++)
            {
                if (dgvItens_nota.Rows[i].Cells["col_prestacao_servico"].Value.ToString() == "1")
                {
                    valor_iss_total = valor_iss_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_iss"].Value.ToString());
                    base_calculo_iss_total = base_calculo_iss_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                }
                else
                {
                    try
                    {
                        valor_simples = valor_simples + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_credito"].Value.ToString());
                    }
                    catch { }
                    try
                    {
                        valor_produtos = valor_produtos + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                    }
                    catch { }
                    
                    //-----------------------------------------------------------------------------------------//
                    if (verificar_se_existem_2_cfops())
                    {
                        if (verificar_se_e_tributada(dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()))
                        {
                            try
                            {
                                valor_total = valor_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        try
                        {
                            valor_total = valor_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                        }
                        catch { }
                    }
                    //----------------------------------------------------------------------------------------//


                    try
                    {
                        valor_icm_total = valor_icm_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_icm"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_ipi_total = valor_ipi_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_bc_total = valor_bc_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_bc"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_bc_st_total = valor_bc_st_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_bc_st"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_st_total = valor_st_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_frete = valor_frete + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_frete"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_desconto = valor_desconto + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_seguro = valor_seguro + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_seguro"].Value.ToString()));
                    }
                    catch { }

                    try
                    {
                        valor_outras_desp = valor_outras_desp + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_outras_desp"].Value.ToString()));
                    }
                    catch { }
                }
            }

            valor_total = valor_produtos + valor_ipi_total + base_calculo_iss_total +
                valor_st_total + valor_frete - valor_desconto + valor_seguro + valor_outras_desp;
            tb_base_calc_icm.Text = valor_bc_total.ToString("n2");
            tb_base_calc_iss.Text = base_calculo_iss_total.ToString("n2");
            tb_valor_total_iss.Text = valor_iss_total.ToString("n2");
            tb_valor_icm_st.Text = valor_st_total.ToString("n2");
            tb_base_cal_icm_st.Text = valor_bc_st_total.ToString("n2");
            tb_valor_icm.Text = valor_icm_total.ToString("n2");
            tb_valor_ipi.Text = valor_ipi_total.ToString("n2");
            tb_total_prod.Text = valor_produtos.ToString("n2");
            tb_total_nota.Text = valor_total.ToString("n2");
            tb_valor_fre.Text = valor_frete.ToString("n2");
            tb_valor_seg.Text = valor_seguro.ToString("n2");
            tb_desconto.Text = valor_desconto.ToString("n2");

            tb_outras_des_ace.Text = valor_outras_desp.ToString("n2");
            tb_valor_simples.Text = valor_simples.ToString("n2");

        }

        private bool verificar_se_existem_2_cfops()
        {
            bool existe = false;
            string cfop_inicial = dgvItens_nota.Rows[0].Cells["col_cfo"].Value.ToString();
            for (int i = 1; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    if (cfop_inicial != dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString())
                        existe = true;
                }
                catch { }

            }
            return existe;
        }



        private void tb_data_emissao_TextChanged(object sender, EventArgs e)
        {

        }



        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            finalizar_nf();
        }

        private void finalizar_nf()
        {
            for (int k = 0; k < dgvItens_nota.RowCount - 1; k++)
            {
                try
                {

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET SIT_ATUAL_OP = 'FATURADA' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_cod"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET NF_N = '" + tb_n_nf.Text + "' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_cod"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET ENTREGOU_DIA = '" + tb_data_emissao.Text.Replace("/", ".") + "' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_cod"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET SIT_ATUAL_OP = 'SEMI-FATURADA' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_mae"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch { }

            }
        }

        private void tb_NFe_Click(object sender, EventArgs e)
        {
            criar_arquivo("NFE" + tb_n_nf.Text + ".txt");
            escrever_no_arquivo_nfe();
        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa, out string crt_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    pais_empresa = dr["PAIS_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_NFE_EMPRESA"].ToString();
                    nome_certificado_nfe_empresa = dr["NOME_CERTIFICADO_NFE_EMPRESA"].ToString();
                    assunto_nfe_email_empresa = dr["ASSUNTO_NFE_EMAIL_EMPRESA"].ToString();
                    smtp_nfe_empresa = dr["SMTP_NFE_EMPRESA"].ToString();
                    email_nfe_empresa = dr["EMAIL_NFE_EMPRESA"].ToString();
                    senha_email_nfe_empresa = dr["SENHA_EMAIL_NFE_EMPRESA"].ToString();
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                }

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }

        private void escrever_no_arquivo_nfe()
        {
            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);


            int nfe = 2;
            if (cbNfe_teste.Checked == false)
                nfe = 1;

            DateTime emissao = Convert.ToDateTime(tb_data_emissao.Text);

            int tipo_doc_fiscal;
            if (radioEntrada.Checked == true)
                tipo_doc_fiscal = 0;
            else
                tipo_doc_fiscal = 1;

            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\NFE\\TXT\\" + "NFE" + tb_n_nf.Text + ".txt");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine("NOTA FISCAL |1|");
                string ano = Convert.ToDateTime(tb_data_emissao.Text).Year.ToString();
                ano = ano.Remove(0, 2);
                string mes = Convert.ToDateTime(tb_data_emissao.Text).Month.ToString();
                if (mes.Length == 1)
                    mes = "0" + mes;
                string _chaveNFe = "";
                string _tipo_emissao = "1"; //SE FOSSE CONTINGÊNCIA SERIA 2 
                string _msgResultado_cria, _cNF, _cDV;

                texto.WriteLine("A|2.00|NFe|");
                if (mes.Length == 1)
                    mes = "0" + mes;
                string dia = emissao.Day.ToString();
                if (dia.Length == 1)
                    dia = "0" + dia;
                DateTime sai_ent = new DateTime();
                string dia_saida, mes_saida, ano_saida;
                string data_completa = ""; //data saida
                try
                {
                    sai_ent = Convert.ToDateTime(tb_saida.Text);
                    dia_saida = sai_ent.Day.ToString();
                    if (dia_saida.Length == 1)
                        dia_saida = "0" + dia_saida;
                    mes_saida = sai_ent.Month.ToString();
                    if (mes_saida.Length == 1)
                        mes_saida = "0" + mes_saida;
                    ano_saida = sai_ent.Year.ToString();
                    data_completa = ano_saida + "-" + mes_saida + "-" + dia_saida;
                }

                catch { }
                texto.WriteLine("B|" + cod_cidade_empresa.Remove(2) + "||" + tb_natureza_operacao.Text + "|" + cb_forma_pgto.Text[0] + "|55|1|" + tb_n_nf.Text + "|" + emissao.Year.ToString() + "-" + mes + "-" + dia + "|" + data_completa + "||" + tipo_doc_fiscal.ToString() + "|" + cod_cidade_empresa + "|1|1||" + nfe.ToString() + "|1|0|2.0|||");
                //NO CASO DO POSTO EUROPA FAZER AQUI SE FOR VINCULADO COM CUPOM FISCAL (EX: B20J|2D|1234|1| B20J|2D|1235|2|
                texto.WriteLine("C|" + razao_social_empresa + "||" + ie_empresa + "||" + im_empresa + "|" + cnae_empresa + "|" + crt_empresa + "|");
                texto.WriteLine("C02|" + cnpj_empresa + "|");
                //texto.WriteLine("C02a|" + tb_cpf.Text + "|");
                texto.WriteLine("C05|" + endereco_empresa + "|" + n_endereco_empresa + "|" + complemento_empresa + "|" + bairro_empresa + "|" + cod_cidade_empresa + "|" + cidade_empresa + "|" + estado_empresa + "|" + cep_empresa + "|||" + telefone_empresa + "|");
                bool pessoa_fisica = false;
                string ie_cliente_2, cnpj_cliente_2, logradouro_cliente_2, n_logradouro_cliente_2, complemento_cliente_2, bairro_cliente_2, cod_municipio_cliente_2,
                 uf_cliente_2, cep_cliente_2, cod_pais_cliente_2, pais_cliente_2, telefone_cliente_2, cidade_cliente_2, email_cliente_2;
                buscar_dados_cliente(tb_cnpj_cliente.Text, out ie_cliente_2, out cnpj_cliente_2, out logradouro_cliente_2,
                    out n_logradouro_cliente_2, out complemento_cliente_2, out bairro_cliente_2,
                    out cod_municipio_cliente_2, out uf_cliente_2, out cep_cliente_2, out cod_pais_cliente_2,
                    out pais_cliente_2, out telefone_cliente_2, out cidade_cliente_2, out pessoa_fisica, out email_cliente_2);
                texto.WriteLine("E|" + tb_cliente.Text + "|" + ie_cliente_2.Replace(".", "").Replace("-", "") + "||" + email_cliente_2 + "|");
                if (pessoa_fisica == false)
                {
                    texto.WriteLine("E02|" + cnpj_cliente_2.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                }
                else
                {
                    texto.WriteLine("E03|" + cnpj_cliente_2.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                }
                texto.WriteLine("E05|" + logradouro_cliente_2 + "|" + n_logradouro_cliente_2 + "|" + complemento_cliente_2 + "|" + bairro_cliente_2 + "|" + cod_municipio_cliente_2 + "|" + cidade_cliente_2 + "|" + uf_cliente_2 + "|" + cep_cliente_2.Replace("-", "") + "|" + cod_pais_cliente_2 + "||" + telefone_cliente_2.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "") + "|");
                for (int i = 0; i < dgvItens_nota.RowCount; i++)
                {
                    //preparando campos
                    int numero = i + 1;
                    string qtde_prod = transforma_decimal(4, dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString(), 15);
                    string valor_unit_item = transforma_decimal(4, dgvItens_nota.Rows[i].Cells["col_preco_unit"].Value.ToString(), 21);
                    string cod_prod = dgvItens_nota.Rows[i].Cells["col_cod_op"].Value.ToString();
                    if (cod_prod == "")
                        cod_prod = "000000";
                    string valor_total_item = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString(), 15);
                    string frete = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_frete"].Value.ToString(), 15);
                    string seguro = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_seguro"].Value.ToString(), 15);
                    string desconto = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString(), 15);
                    string outras_desp = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_outras_desp"].Value.ToString(), 15);

                    texto.WriteLine("H|" + numero.ToString() + "|.|");
                    texto.WriteLine("I|" + cod_prod + "|" + dgvItens_nota.Rows[i].Cells["col_ean"].Value.ToString() + "|" + dgvItens_nota.Rows[i].Cells["col_descricao"].Value.ToString().Replace("Á", "A").Replace("Ã", "A") +
                        "|" + dgvItens_nota.Rows[i].Cells["col_ncm"].Value.ToString() +
                        "||" + dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString() +
                        "|" + dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString() +
                        "|" + qtde_prod + "|" + valor_unit_item + "|" + valor_total_item +
                        "|" + dgvItens_nota.Rows[i].Cells["col_ean"].Value.ToString() +
                        "|" + dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString() +
                        "|" + qtde_prod + "|" + valor_unit_item + "|" + frete +
                        "|" + seguro + "|" + desconto + "|" + outras_desp +
                        //ACREDITO QUE TODOS OS ITENS COMPOE O VALOR TOTAL DA NOTA, PORTANTO ABAIXO EM indTot é "0"
                        "|1" +
                        "|" + dgvItens_nota.Rows[i].Cells["col_pedido_compra"].Value.ToString() +
                        "|" + dgvItens_nota.Rows[i].Cells["col_item_pedido_compra"].Value.ToString() + "|");
                    //COLOCAR AQUI QUANDO FOR IMPORTACAO EX: UNIMAGNA 
                    //I18|.....
                    //COLOCAR AQUI L01 EUROPA ****VERIFICAR MODIFICAÇÕES CONFORME ITEM 9.28 DA NT
                    int linhas;
                    string[] tributacao = new string[200];
                    tributacao = txt_tributacao(dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString(),
                        out linhas, cod_municipio_cliente_2,
                        dgvItens_nota.Rows[i].Cells["col_tipo_servico"].ToString());
                    for (int l = 0; l < linhas; l++)
                    {
                        texto.WriteLine(tributacao[l]);
                    }
                }
                texto.WriteLine("W|");
                string base_cal_icm = transforma_decimal(2, tb_base_calc_icm.Text, 15);
                string valor_tot_icm = transforma_decimal(2, tb_valor_icm.Text, 15);
                string base_cal_icm_st = transforma_decimal(2, tb_base_cal_icm_st.Text, 15);
                string valor_tot_icm_st = transforma_decimal(2, tb_valor_icm_st.Text, 15);
                string valor_total_prod = transforma_decimal(2, tb_total_prod.Text, 15);
                string valor_total_frete = transforma_decimal(2, tb_valor_fre.Text, 15);
                string valor_total_seguro = transforma_decimal(2, tb_valor_seg.Text, 15);
                string valor_total_desc = transforma_decimal(2, tb_desconto.Text, 15);
                string valot_total_II = "0.00";
                string valor_total_ipi = transforma_decimal(2, tb_valor_ipi.Text, 15);
                string valor_pis = buscar_total_pis();
                string valor_cofins = buscar_total_cofins();
                string outras_des_ace = transforma_decimal(2, tb_outras_des_ace.Text, 15);
                string valor_total_nfe = transforma_decimal(2, tb_total_nota.Text, 15);
                texto.WriteLine("W02|" + base_cal_icm + "|" + valor_tot_icm + "|" + base_cal_icm_st + "|" + valor_tot_icm_st + "|" + valor_total_prod + "|" + valor_total_frete +
                    "|" + valor_total_seguro + "|" + valor_total_desc + "|" + valot_total_II + "|" + valor_total_ipi + "|" + valor_pis + "|" + valor_cofins + "|" + outras_des_ace + "|" + valor_total_nfe + "|");
                if (tb_valor_total_iss.Text != "")
                    texto.WriteLine("W17|" + transforma_decimal(2, tb_base_calc_iss.Text, 15) + "|" + transforma_decimal(2, tb_base_calc_iss.Text, 15) + "|" + transforma_decimal(2, tb_valor_total_iss.Text, 15) + "|||");
                texto.WriteLine("X|" + tb_frete.Text + "|");
                string _endereco_transp, _ie_transp, _uf_transp, _municipio_transp, _cnpj_transp;
                detectar_transportadora(tb_transportadora.Text, out _ie_transp, out _cnpj_transp, out _municipio_transp, out _uf_transp, out _endereco_transp);
                texto.WriteLine("X03|" + tb_transportadora.Text + "|" + _ie_transp.Replace(".", "").Replace("-", "") + "|" + _endereco_transp + "|" + _uf_transp + "|" + _municipio_transp + "|");
                texto.WriteLine("X04|" + _cnpj_transp.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                string peso_liquido = transforma_decimal(3, tb_peso_liquido.Text, 15);
                string peso_bruto = transforma_decimal(3, tb_peso_bruto.Text, 15);
                texto.WriteLine("X26|" + tb_qtde_volume.Text + "|" + tb_especie.Text + "|" + tb_marca.Text + "||" + peso_liquido + "|" + peso_bruto + "|");
                if (cb_forma_pgto.Text[0].ToString() == "1" || cb_forma_pgto.Text[0].ToString() == "0")
                {
                    string valor_total = transforma_decimal(2, buscar_valor_faturado().ToString(), 15);
                    texto.WriteLine("Y|");
                    texto.WriteLine("Y02|" + tb_n_nf.Text + "|" + valor_total + "||" + valor_total + "|");
                    int _n_vencimentos;

                    detectar_numero_vencimentos_fatura(out _n_vencimentos);
                    for (int v = 0; v < _n_vencimentos; v++)
                    {
                        DateTime venc = new DateTime();
                        venc = Convert.ToDateTime(_datas[v].ToString());
                        string mes_venc = venc.Month.ToString();
                        if (mes_venc.Length == 1)
                            mes_venc = "0" + mes_venc;
                        string dia_venc = venc.Day.ToString();
                        if (dia_venc.Length == 1)
                            dia_venc = "0" + dia_venc;
                        texto.WriteLine("Y07|" + _cod[v] + "|" + venc.Year.ToString() + "-" + mes_venc + "-" + dia_venc + "|" + transforma_decimal(2, _valores[v], 15) + "|");
                    }



                }
                texto.WriteLine("Z||" + tb_dados_adicionais.Text.Replace("\r\n", " ") + "|"); //tirando os enter do textbox
                if (cbExportacao.Checked == true)
                {
                    texto.WriteLine("ZA|" + tb_uf_exportacao.Text + "|" + tb_local_exportacao.Text + "|");
                }
            }
        }

        private string[] txt_tributacao(string cod, out int n_linhas, string cod_municipio, string cod_servico)
        {

            string[] texto = new string[200];
            int linhas = 2;
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM ITENS_NOTA WHERE COD_ITENS_NOTA = " + cod;
                DataSet item = new DataSet();
                fbConnection1.Open();
                FbDataAdapter itens_nota = new FbDataAdapter();
                itens_nota.SelectCommand = comando;
                itens_nota.Fill(item);
                fbConnection1.Close();
                DataRow dr = item.Tables[0].Rows[0];
                texto[0] = "M|";
                texto[1] = "N|";
                //CST 00
                if (dr["ST_ITEM"].ToString() == "00")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    texto[linhas] = "N02|" + origem_merc + "|00|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "10")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    texto[linhas] = "N03|" + origem_merc + "|10|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "20")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    texto[linhas] = "N04|" + origem_merc + "|20|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "30")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    texto[linhas] = "N05|" + origem_merc + "|30|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "40" || dr["ST_ITEM"].ToString() == "41" || dr["ST_ITEM"].ToString() == "50")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    texto[linhas] = "N06|" + origem_merc + "|" + dr["ST_ITEM"].ToString() + "|0| |"; //O DOIS ULTIMOS CAMPOS SÓ SERÃO USADOS SE FOR VENDA DE VEICULOS
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "51")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    texto[linhas] = "N07|" + origem_merc + "|51|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "60")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    // string st_val_bc_icm = transforma_decimal(2, tb_st_valor_bc_icms.Text, 15);
                    //string st_valor_icms = transforma_decimal(2, tb_st_val_icms.Text, 15);
                    texto[linhas] = "N08|" + origem_merc + "|60|0|0|"; //CONFORME CONTADOR DISSE É ZERO POIS NÃO TEM COMO SABER
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "70")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    texto[linhas] = "N09|" + origem_merc + "|70|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "90")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    texto[linhas] = "N10|" + origem_merc + "|90|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "101")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string aliq_simples = transforma_decimal(2, dr["ALIQUOTA_CREDITO_ITEM"].ToString(), 5);
                    string valor_credito = transforma_decimal(2, dr["VALOR_CREDITO_ITEM"].ToString(), 15);
                    texto[linhas] = "N10c|" + origem_merc + "|101|" + aliq_simples + "|" + valor_credito + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "102" || dr["ST_ITEM"].ToString() == "103" ||
                    dr["ST_ITEM"].ToString() == "300" || dr["ST_ITEM"].ToString() == "400")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    texto[linhas] = "N10d|" + origem_merc + "|" + dr["ST_ITEM"].ToString() + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "201")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string aliq_simples = transforma_decimal(2, dr["ALIQUOTA_CREDITO_ITEM"].ToString(), 5);
                    string valor_credito = transforma_decimal(2, dr["VALOR_CREDITO_ITEM"].ToString(), 15);
                    texto[linhas] = "N10e|" + origem_merc + "|201|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm +
                        "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms +
                        "|" + aliq_simples + "|" + valor_credito + "|";

                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "202" || dr["ST_ITEM"].ToString() == "203")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    texto[linhas] = "N10f|" + origem_merc + "|" + dr["ST_ITEM"].ToString() + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm +
                        "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "500")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string valor_bc_icms_st_retido = transforma_decimal(2, "0", 15);
                    string valor_icms_st_retido = transforma_decimal(2, "0", 15);
                    texto[linhas] = "N10g|" + origem_merc + "|500|" + valor_bc_icms_st_retido + "|" + valor_icms_st_retido + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "900")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    string aliq_simples = transforma_decimal(2, dr["ALIQUOTA_CREDITO_ITEM"].ToString(), 5);
                    string valor_credito = transforma_decimal(2, dr["VALOR_CREDITO_ITEM"].ToString(), 15);
                    texto[linhas] = "N10h|" + origem_merc + "|900|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + per_red_bc +
                        "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm +
                        "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms +
                        "|" + aliq_simples + "|" + valor_credito + "|";
                    linhas++;
                }
                //IPI
                texto[linhas] = ("O|||||999|");
                linhas++;
                string cod_sit_tri_ipi = "";
                if (dr["IPI_TRIB_ITEM"].ToString() == "1")
                {
                    cod_sit_tri_ipi = dr["CST_IPI_TRIB_ITEM"].ToString();
                    string valor_ipi = transforma_decimal(2, dr["VALOR_IPI_ITEM"].ToString(), 15);
                    texto[linhas] = "O07|" + cod_sit_tri_ipi + "|" + valor_ipi + "|";
                    linhas++;
                    string val_bc_ipi = transforma_decimal(2, dr["BC_IPI_ITEM"].ToString(), 15);
                    string ali_ipi = transforma_decimal(2, dr["IPI_ITEM"].ToString(), 5);
                    texto[linhas] = "O10|" + val_bc_ipi + "|" + ali_ipi + "|";
                    linhas++;
                    /* SE TIVER ALGUMA EMPRESA QUE COBRA IPI POR UNIDADE AVISAR
                    if (rb_por_alíquota.Checked == true)
                    {
                        string val_bc_ipi = transforma_decimal(2, tb_val_bc_ipi.Text, 15);
                        string ali_ipi = transforma_decimal(2, tb_ali_ipi.Text, 5);
                        texto.WriteLine("O10|" + val_bc_ipi + "|" + ali_ipi + "|");
                    }
                    if (rb_por_unidade.Checked == true)
                    {
                        string val_uni_trib = transforma_decimal(4, tb_val_uni_tri.Text, 15);
                        string qtd_tot_unit_pad = transforma_decimal(4, tb_qtd_uni_pad.Text, 16);
                        texto.WriteLine("O11|" + val_uni_trib + "|" + qtd_tot_unit_pad + "|");
                    }
                     * */
                }
                if (dr["IPI_N_TRIB_ITEM"].ToString() == "1")
                {
                    cod_sit_tri_ipi = dr["CST_IPI_N_TRIB_ITEM"].ToString();
                    texto[linhas] = "O08|" + cod_sit_tri_ipi + "|";
                    linhas++;
                }
                //PIS
                if (dr["CST_PIS_ITEM"].ToString() == "01" || dr["CST_PIS_ITEM"].ToString() == "02")
                {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q02|" + dr["CST_PIS_ITEM"].ToString() + "|" + transforma_decimal(2, dr["BC_PIS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["PIS_ITEM"].ToString(), 5) + "|" + transforma_decimal(2, dr["VALOR_PIS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                if (dr["CST_PIS_ITEM"].ToString() == "03")
                {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q03|" + dr["CST_PIS_ITEM"].ToString() + "|" + transforma_decimal(4, dr["QTDE_ITEM"].ToString(), 16) + "|" + transforma_decimal(2, dr["PIS_ITEM"].ToString(), 5) + "|" + transforma_decimal(2, dr["VALOR_PIS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                if (dr["CST_PIS_ITEM"].ToString() == "04" || dr["CST_PIS_ITEM"].ToString() == "06" ||
                    dr["CST_PIS_ITEM"].ToString() == "07" || dr["CST_PIS_ITEM"].ToString() == "08" ||
                    dr["CST_PIS_ITEM"].ToString() == "09")
                {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q04|" + dr["CST_PIS_ITEM"].ToString() + "|";
                    linhas++;
                }
                //COFINS
                if (dr["CST_COFINS_ITEM"].ToString() == "01" || dr["CST_COFINS_ITEM"].ToString() == "02")
                {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S02|" + dr["CST_COFINS_ITEM"].ToString() + "|" +
                        transforma_decimal(2, dr["BC_COFINS_ITEM"].ToString(), 15) + "|" +
                        transforma_decimal(2, dr["COFINS_ITEM"].ToString(), 5) + "|" +
                        transforma_decimal(2, dr["VALOR_COFINS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                if (dr["CST_COFINS_ITEM"].ToString() == "03")
                {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S03|" + dr["CST_COFINS_ITEM"].ToString() + "|" +
                        transforma_decimal(4, dr["QTDE_ITEM"].ToString(), 16) + "|" +
                        transforma_decimal(2, dr["COFINS_ITEM"].ToString(), 5) + "|" +
                        transforma_decimal(2, dr["VALOR_COFINS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                if (dr["CST_COFINS_ITEM"].ToString() == "04" || dr["CST_COFINS_ITEM"].ToString() == "06" ||
                    dr["CST_COFINS_ITEM"].ToString() == "07" || dr["CST_COFINS_ITEM"].ToString() == "08" ||
                    dr["CST_COFINS_ITEM"].ToString() == "09")
                {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S04|" + dr["CST_COFINS_ITEM"].ToString() + "|";
                    linhas++;
                }
                if (dr["PRESTACAO_SERVICO_ITEM"].ToString() == "1")
                {
                    texto[linhas] = "U|" + transforma_decimal(2, dr["BC_ISS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["ISS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["VALOR_ISS_ITEM"].ToString(), 15) + "|" + cod_municipio + "|" + cod_servico + "|N|";
                }

                n_linhas = linhas;
                return texto;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                n_linhas = linhas;
                return texto;
            }

        }

        private void buscar_dados_cliente(string cnpj,
            out string ie_cliente, out string cnpj_cliente,
            out string logradouro_cliente,
            out string n_logradouro_cliente,
            out string complemento_cliente,
            out string bairro_cliente,
            out string cod_municipio_cliente,
            out string uf_cliente, out string cep_cliente,
            out string cod_pais_cliente, out string pais_cliente,
            out string telefone_cliente, out string cidade_cliente,
            out bool pessoa_fisica, out string email_cliente)
        {
            ie_cliente = ""; cnpj_cliente = ""; logradouro_cliente = ""; n_logradouro_cliente = "";
            complemento_cliente = ""; bairro_cliente = ""; cod_municipio_cliente = "";
            uf_cliente = ""; cep_cliente = ""; cod_pais_cliente = ""; pais_cliente = "";
            telefone_cliente = ""; cidade_cliente = ""; pessoa_fisica = false; email_cliente = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                //comando_select.Connection = fbConnection1;
                datClientes.SelectCommand = comando;
                DataSet cliente = new DataSet();
                datClientes.Fill(cliente);
                fbConnection1.Close();
                DataRow dr = cliente.Tables[0].Rows[0];
                ie_cliente = dr["IE"].ToString();
                cnpj_cliente = dr["CNPJ"].ToString();
                logradouro_cliente = dr["ENDERECO"].ToString();
                n_logradouro_cliente = dr["NUMERO_CLIENTE"].ToString();
                complemento_cliente = dr["COMPLEMENTO_CLIENTE"].ToString();
                bairro_cliente = dr["BAIRRO"].ToString();
                cod_municipio_cliente = dr["COD_CIDADE_CLIENTE"].ToString();
                uf_cliente = dr["ESTADO"].ToString();
                cep_cliente = dr["CEP_CLIENTE"].ToString();
                cod_pais_cliente = dr["COD_PAIS_CLIENTE"].ToString();
                pais_cliente = dr["PAIS"].ToString();
                telefone_cliente = dr["FONE1"].ToString();
                cidade_cliente = dr["CIDADE"].ToString();
                email_cliente = dr["EMAIL"].ToString();
                if (dr["PESSOA_FISICA_CLIENTE"].ToString() == "1")
                    pessoa_fisica = true;
                else
                    pessoa_fisica = false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_total_pis()
        {
            double total_pis = 0;
            for (int p = 0; p < dgvItens_nota.RowCount; p++)
            {
                try
                {
                    total_pis = total_pis + Convert.ToDouble(dgvItens_nota.Rows[p].Cells["col_valor_pis"].Value.ToString());
                }
                catch { }
            }
            return transforma_decimal(2, total_pis.ToString("n2"), 15);
        }

        private string buscar_total_cofins()
        {
            double total_cofins = 0;
            for (int p = 0; p < dgvItens_nota.RowCount; p++)
            {
                try
                {
                    total_cofins = total_cofins + Convert.ToDouble(dgvItens_nota.Rows[p].Cells["col_valor_cofins"].Value.ToString());
                }
                catch { }
            }
            return transforma_decimal(2, total_cofins.ToString(), 15);
        }

        private void detectar_numero_vencimentos_fatura(out int n_venc)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * " +
                    "FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                DataSet fatura = new DataSet();
                fbConnection1.Open();
                datFatura_nf.SelectCommand = comando;
                datFatura_nf.Fill(fatura);
                int n = 0;
                foreach (DataRow dr in fatura.Tables[0].Rows)
                {

                    _cod[n] = dr["COD_FATURA"].ToString();
                    _valores[n] = dr["VALOR_FATURA"].ToString();
                    _datas[n] = dr["DATA_VENC_FATURA"].ToString();
                    n++;

                }

                this.fbConnection1.Close();
                n_venc = n;
            }
            catch
            {
                fbConnection1.Close();
                n_venc = 0;
            }

        }
        private void detectar_transportadora(string nome, out string ie, out string cnpj, out string municipio, out string uf, out string endereco)
        {

            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT RAZAO_SOCIAL_TRANSPORTADORA, ENDERECO_TRANSPORTADORA, IE_TRANSPORTADORA, " +
                "CNPJ_TRANSPORTADORA, CIDADE_TRANSPORTADORA, ESTADO_TRANSPORTADORA FROM TRANSPORTADORAS WHERE RAZAO_SOCIAL_TRANSPORTADORA = '" + nome + "'";
            DataSet transp = new DataSet();
            fbConnection1.Open();
            datTransportadoras.SelectCommand = comando;
            datTransportadoras.Fill(transp);
            endereco = ""; ie = ""; cnpj = ""; municipio = ""; uf = "";
            foreach (DataRow dr in transp.Tables[0].Rows)
            {
                nome = dr["RAZAO_SOCIAL_TRANSPORTADORA"].ToString();
                endereco = dr["ENDERECO_TRANSPORTADORA"].ToString();
                ie = dr["IE_TRANSPORTADORA"].ToString();
                cnpj = dr["CNPJ_TRANSPORTADORA"].ToString();
                municipio = dr["CIDADE_TRANSPORTADORA"].ToString();
                uf = dr["ESTADO_TRANSPORTADORA"].ToString();
            }

            this.fbConnection1.Close();
            //return nome_transp;


        }

        private void ler_arquivo_tributacao()
        {

        }

        private string transforma_decimal(int qtde_depois_virg, string numero, int n_caracteres)
        {

            int tamanho = numero.Length;
            int pos_virgula = 0;
            int qtde_decimais = 0;
            if (numero.Contains(","))
            {
                while (numero[pos_virgula].ToString() != ",")
                {
                    pos_virgula++;
                }
                pos_virgula++; //por que começa com 0
                qtde_decimais = tamanho - pos_virgula;
                if (qtde_decimais > qtde_depois_virg)
                {
                    numero = Convert.ToDouble(numero).ToString("n" + qtde_depois_virg.ToString());
                    numero = numero.Replace(".", "");
                }
                for (int i = qtde_decimais; i < qtde_depois_virg; i++)
                {
                    numero = numero + "0";
                }
            }
            else
            {
                if (numero == "")
                    numero = "0";
                numero = numero + ",";
                for (int i = qtde_decimais; i < qtde_depois_virg; i++)
                {
                    numero = numero + "0";
                }
            }

            return numero.Replace(",", ".");
            /*
            int pos_virgula = 0;
            string n = numero;
            if (numero.Contains(","))
            {
                while (numero[pos_virgula].ToString() != ",")
                {
                    pos_virgula++;
                }
                n = numero.Remove(pos_virgula);
                pos_virgula++; //por que começa com 0
                
                //MessageBox.Show(tamanho_atual.ToString());
                //MessageBox.Show(pos_virgula.ToString());
            }
            
            int numero_inteiro = Convert.ToInt32(n);
            decimal numero_decimal_1 = new decimal();
            decimal numero_decimal_2 = new decimal();
            numero_decimal_1 = Convert.ToDecimal(numero);
            numero_decimal_2 = Convert.ToDecimal(n);
            decimal numero_decimal = numero_decimal_1 - numero_decimal_2;
            int qtde_decimais = numero_decimal.ToString().Length - 2; //TIRANDO O 0.
            if (numero_decimal == 0)
                qtde_decimais = 0;
            else
            {
                if (qtde_decimais > qtde_depois_virg)
                    qtde_decimais = qtde_depois_virg + 2;
                string numero_decimal_string = numero_decimal.ToString();
                for (int p = 0; p < qtde_decimais; p++)
                {
                    decimal_correto = decimal_correto + numero_decimal_string[p].ToString();

                }
            }
            for (int j = 0; j < qtde_depois_virg - qtde_decimais; j++)
            {
                decimal_correto = decimal_correto + "0";
            }
            string numero_correto = numero_inteiro.ToString() + "." + decimal_correto;
            decimal_correto = "";
             * return numero_correto;
            //int tamanho = numero_correto.Length;
            /*
            for (int j = numero_correto.Length; j < n_caracteres; j++)
            {
                numero_correto = "0" + numero_correto;

            }
             * */

            /*
            int numero_inteiro = Convert.ToInt32(numero);
            int numero_decimal = Convert.ToInt32(numero) - numero_inteiro;
            int qtde_decimais = numero_decimal.ToString().Length;
            if (numero_decimal == 0)
                qtde_decimais = 0;
            else
            {
                for (int p = 2; p < qtde_decimais; p++)
                {
                    decimal_correto = decimal_correto + decimal_correto[p].ToString();

                }
            }
            for (int j = 0; j < qtde_depois_virg - qtde_decimais; j++)
            {
                decimal_correto = decimal_correto + "0";
            }
            string numero_correto = numero_inteiro.ToString() + "." + decimal_correto;
            decimal_correto = "";
            int tamanho = numero_correto.Length;
            for (int j = numero_correto.Length; j < tamanho; j++)
            {
                numero_correto = "0" + numero_correto;

            }
            return numero_correto;

            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_localiza_transportadora localiza_transportadora = new form_localiza_transportadora();
            try
            {
                localiza_transportadora.ShowDialog();
            }
            finally
            {
                localiza_transportadora.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                dsTransportadoras.Clear();
                tb_transportadora.Text = localiza_transportadora.transportadora_escolhida;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
                if(tb_qtde_volume.Text == "")
                {
                    MessageBox.Show("O volume da nota não foi preenchido!\nSe for necessário informar o volume, digite-o e gere o xml novamente.");
                }

                verificar_aproveitamento_credito();
                verificar_se_simples();
                verificar_cfop();
                Atualizar(false);
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

                detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);



                criar_arquivo("NFE" + tb_n_nf.Text + ".txt");
                escrever_no_arquivo_nfe();
                string arquivo;
                string caminho = "c:\\evolucao_dokinos\\NFE\\TXT\\NFE" + tb_n_nf.Text + ".txt";
                StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                arquivo = objReader.ReadToEnd();
                objReader.Close();
                string _txtNumerado, _erros, _msgResultado;
                int _qtErros;
                int resultado = 0;
                string _XML = util2.Txt2XML2G(arquivo, 1, "Evolucao", out _txtNumerado, out resultado, out _erros, out _qtErros, out _msgResultado);
                if (resultado == 6901)
                {
                    MessageBox.Show(_XML);
                    try
                    {
                        criar_arquivo_xml("NFE" + tb_n_nf.Text + ".xml");
                        FileInfo t = new FileInfo("c:\\evolucao_dokinos\\NFE\\XML\\" + "NFE" + tb_n_nf.Text + ".xml");
                        using (StreamWriter texto = t.CreateText())
                        {
                            texto.WriteLine(_XML);
                        }

                        barra_status.Text = "Arquivo XML gerado com sucesso";
                        tb_status_nfe.Text = "Arquivo XML gerado com sucesso";
                        gbNfe.BackColor = Color.Yellow;

                        tb_chave_acesso_nfe.Text = buscar_chave("c:\\evolucao_dokinos\\NFE\\xml\\" + "NFE" + tb_n_nf.Text + ".xml");
                        Atualizar(false);
                        criar_codigo_barras();

                    }
                    catch
                    {
                        barra_status.Text = "Erro, tente outra vez";
                        tb_status_nfe.Text = "Erro, tente outra vez";
                        gbNfe.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show(_erros);
                    MessageBox.Show(_msgResultado);
                }

        }

        private void verificar_cfop()
        {
            string texto = "";
            if (!pessoa_fisica(tb_cnpj_cliente.Text))
            {
                for (int j = 0; j < dgvItens_nota.RowCount; j++)
                {
                    if (dgvItens_nota.Rows[j].Cells["col_cfo"].Value.ToString() == "5102" ||
                        dgvItens_nota.Rows[j].Cells["col_cfo"].Value.ToString() == "6102")
                    {
                        int linha = j + 1;
                        if (!tb_dados_adicionais.Text.Contains("Linha " + linha.ToString()))
                            texto = texto + " Linha " + linha.ToString() + " Red: " + dgvItens_nota.Rows[j].Cells["col_reducao"].Value.ToString() +
                            " Aliq.: " + dgvItens_nota.Rows[j].Cells["col_icms"].Value.ToString() + "/";
                    }

                }
                string texto_anterior = tb_dados_adicionais.Text;
                string[] newLines = new string[2];
                newLines[0] = texto_anterior;
                newLines[1] = texto;
                tb_dados_adicionais.Lines = newLines;
            }
        }

        private void verificar_se_simples()
        {
            if (tb_dados_adicionais.Text.Contains("I - DOCUMENTO EMITIDO POR ME OU EPP OPTANTE PELO SIMPLES NACIONAL") == false)
            {
                if (empresa_simples())
                {
                    string texto_anterior = tb_dados_adicionais.Text;
                    string[] newLines = new string[3];
                    newLines[0] = "I - DOCUMENTO EMITIDO POR ME OU EPP OPTANTE PELO SIMPLES NACIONAL";
                    newLines[1] = "II - NÃO GERA DIREITO A CRÉDITO FISCAL DE ISS E DE IPI";
                    newLines[2] = texto_anterior;
                    tb_dados_adicionais.Lines = newLines;
                }
            }
        }

        private void verificar_aproveitamento_credito()
        {
            if (tb_dados_adicionais.Text.Contains("III - PERMITE O APROVEITAMENTO DO CRÉDITO DE ICMS") == false)
            {
                if (aproveita_credito())
                {
                    string texto_anterior = tb_dados_adicionais.Text;
                    string[] newLines = new string[2];
                    newLines[0] = "III - PERMITE O APROVEITAMENTO DO CRÉDITO DE ICMS NO VALOR DE R$ " + tb_valor_simples.Text +
                        ", CORRESPONDENTE À ALIQUOTA DE " + tb_aliquota_simples.Text + " % NOS TERMOS DO ART. 23 DA LC 123";
                    newLines[1] = texto_anterior;
                    tb_dados_adicionais.Lines = newLines;
                }
            }


        }

        private bool aproveita_credito()
        {
            try
            {
                FbCommand select_empresa = new FbCommand();
                select_empresa.Connection = fbConnection1;
                fbConnection1.Open();
                select_empresa.CommandText = "SELECT ST_ITEM FROM ITENS_NOTA WHERE NF_ITEM = " + tb_n_nf.Text;
                DataSet empresa = new DataSet();
                FbDataAdapter datEmpresa2 = new FbDataAdapter();
                datEmpresa2.SelectCommand = select_empresa;
                datEmpresa2.Fill(empresa);
                bool resultado = false;
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    if (dr[0].ToString() == "101" || dr[0].ToString() == "201")
                        resultado = true;
                }
                fbConnection1.Close();
                return resultado;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }

        private string buscar_chave(string caminho)
        {
            string chave = "";
            DataSet ds = new DataSet();
            ds.ReadXml(@caminho);
            DataTable dt = ds.Tables["infNFe"];
            DataRow dr = dt.Rows[0];
            chave = dr["Id"].ToString().Replace("NFe", "");
            return chave;
        }

        public void criar_codigo_barras()
        {
            try
            {
                SaveFileDialog file = new SaveFileDialog();
                file.FileName = "c:\\evolucao_dokinos\\NFE\\COD_BARRAS\\bar.jpg";
                BarcodeLib.Barcode bar = new BarcodeLib.Barcode();
                bar.Encode(BarcodeLib.TYPE.CODE128, tb_chave_acesso_nfe.Text);
                pb_codigo.Image = bar.Encode(BarcodeLib.TYPE.CODE128, tb_chave_acesso_nfe.Text, 300, 150);
                bar.SaveImage(file.FileName, BarcodeLib.SaveTypes.JPG);
            }
            catch
            {
                MessageBox.Show("1");
            }
        }

        public Boolean criar_arquivo_xml(String Name)
        {
            StreamWriter Arquivo;

            try
            {

                Arquivo = new StreamWriter("c:\\evolucao_dokinos\\NFE\\XML\\" + Name);


                //Arquivo.
                Arquivo.Close();
                return true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                return false;

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string _msgResultado, _erroXML;
            int _qtdErros;
            string arquivo;
            string caminho = "c:\\evolucao_dokinos\\NFE\\XML\\NFE" + tb_n_nf.Text + ".xml";
            StreamReader objReader = new StreamReader(caminho);
            ArrayList arrText = new ArrayList();
            arquivo = objReader.ReadToEnd();
            objReader.Close();
            int resultado = util.ValidaXML(arquivo, 1, out _msgResultado, out _qtdErros, out _erroXML);
            MessageBox.Show(resultado.ToString());
            MessageBox.Show(_msgResultado + " - " + _qtdErros.ToString() + " - " + _erroXML);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bt_enviarNFe.Enabled = false;
            if (_enviar == false)
            {
                if (tb_recibo.Text == "")
                {
                    _enviar = true;
                    string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

                    detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                            out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                            out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                            out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);
                    string proxy = proxy_empresa;
                    string usuario = usuario_proxy_empresa;
                    string senha = senha_proxy_empresa;
                    string licenca = licenca_dll_nfe_empresa;
                    string nomeCertificado = nome_certificado_nfe_empresa;
                    string _nroRecibo, _msgCabec, _msgDados, _msgRetWS, _msgResultado, _NFeAssinada;
                    string arquivo = "";
                    string caminho = "c:\\evolucao_dokinos\\NFE\\XML\\NFE" + tb_n_nf.Text + ".xml";
                    StreamReader objReader = new StreamReader(caminho);
                    ArrayList arrText = new ArrayList();
                    arquivo = objReader.ReadToEnd();
                    objReader.Close();
                    int resultado = 0;
                    int _cStat = 0;
                    string _dhRecbto = "";
                    string tMed = "";
                    string _xml = util2.EnviaNFe2G(estado_empresa, ref arquivo, nomeCertificado, "2.00", out _msgDados,
                        out _msgRetWS, out _cStat, out _msgResultado, out _nroRecibo, out _dhRecbto, out tMed,
                        proxy, usuario, senha, licenca);
                    resultado = _cStat;
                    //int resultado = util.EnviaNFeSCAN(estado_empresa, ref arquivo, out _nroRecibo, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, out _NFeAssinada, proxy, usuario, senha, licenca);

                    if (resultado == 103)
                    {
                        barra_status.Text = "NFe enviada com sucesso. Consulte o Status para autorizá-la";
                        gbNfe.BackColor = Color.Orange;
                        tb_status_nfe.Text = "NFe enviada com sucesso. Consulte o Status para autorizá-la";
                        salvar_xml_assinado(_xml);
                        tb_recibo.Text = _nroRecibo;
                        //DateTime data_hora = new DateTime();


                        Atualizar(false);
                        _enviar = false;
                    }
                    else
                    {
                        MessageBox.Show(_msgResultado, resultado.ToString());
                        _enviar = false;
                    }

                }
                else
                {
                    MessageBox.Show("Essa NF já foi enviada");
                }
            }
            else
            {
                MessageBox.Show("Aguarde");
            }
            bt_enviarNFe.Enabled = true;
        }
        private void apagar_itens_cr()
        {
            this.datContas_a_receber.DeleteCommand.CommandText =
            "DELETE FROM CONTAS_A_RECEBER WHERE NF_CR = '" + tb_n_nf.Text + "'";
            this.fbConnection1.Open();
            this.datContas_a_receber.DeleteCommand.Connection = fbConnection1;
            this.datContas_a_receber.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }


        private void inserir_duplicatas_cr()
        {
            apagar_itens_cr();
            int _n_vencimentos;
            //a parada é 6 pois é o numero máximo de parcelas
            for (int i = 0; i < 6; i++)
            {
                _cod[i] = ""; _datas[i] = ""; _valores[i] = "";
            }
            detectar_numero_vencimentos_fatura(out _n_vencimentos);

            for (int i = 0; i < _n_vencimentos; i++)
            {
                try
                {
                    int parcela_n = i + 1;
                    this.datContas_a_receber.InsertCommand.CommandText =
                    "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                    "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, NF_CR) " +
                    "VALUES ('" + _valores[i].Replace(".", "").Replace(",", ".") + "', '" + Convert.ToDateTime(_datas[i]).ToShortDateString().Replace("/", ".") +
                    "', '" + detectar_cod_cliente(tb_cnpj_cliente.Text) + "','" + tb_cliente.Text +
                    "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. A NF Nº " + tb_n_nf.Text +
                    "', '" + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + "','" + tb_n_nf.Text + "')";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.InsertCommand.Connection = fbConnection1;
                    this.datContas_a_receber.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    MessageBox.Show("Erro na inserção da duplicata " + _cod[i].ToString());
                    fbConnection1.Close();
                }
            }

        }

        private void salvar_xml_assinado(string xml_autorizado)
        {

            criar_arquivo_xml("NFE" + tb_n_nf.Text + "_assinadas.xml");
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\NFE\\assinadas\\" + "NFE" + tb_n_nf.Text + "_assinadas.xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }


        }

        private void radioEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEntrada.Checked == true)
                tb_ent_sai_nfe.Text = "0";
        }

        private void radioSaida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSaida.Checked == true)
                tb_ent_sai_nfe.Text = "1";
        }

        private void inserir_nova_forma_pgto()
        {
            if (tb_total_nota.Text != "")
            {

                form_forma_pgto localiza_forma = new form_forma_pgto();
                try
                {
                    localiza_forma.busca_forma_escolhida = true;
                    localiza_forma.ShowDialog();
                }
                finally
                {
                    localiza_forma.Dispose();
                    //MessageBox.Show(localiza_peca.peca_escolhida);
                    cb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
                    apaga_faturas_anteriores();
                    acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                    localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6);
                    try
                    {
                        dsFatura_nf.Clear();
                        this.datFatura_nf.SelectCommand.CommandText =
                        "SELECT * FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                        this.fbConnection1.Open();
                        this.datFatura_nf.SelectCommand.Connection = fbConnection1;
                        this.datFatura_nf.SelectCommand.ExecuteNonQuery();
                        datFatura_nf.Fill(FATURA_NF);
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }

                }

            }
            else
                MessageBox.Show("Calcule o valor da Nota antes de inserir a forma de pagamento.");
        }

        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
            string prazo_4, string prazo_5, string prazo_6)
        {

            int numero_parcelas = 0;
            DateTime hoje = DateTime.Now;
            //hoje = DateTime.Now;
            try
            {
                numero_parcelas = Convert.ToInt32(n_parcelas);
            }
            catch
            {
                numero_parcelas = 0;
                MessageBox.Show("Número de parcelas incorreto");
            }
            double valor = buscar_valor_faturado() / numero_parcelas;

            switch (numero_parcelas)
            {

                case 1:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        break;
                    }

                case 2:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        break;
                    }
                case 3:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        break;
                    }
                case 4:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        break;
                    }
                case 5:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        break;
                    }
                case 6:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        prazo = Convert.ToDouble(prazo_6);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                        break;
                    }



            }

        }

        private double buscar_valor_faturado()
        {
            double valor_faturado = 0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    if (verificar_se_e_faturado(dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()))
                    {
                        double preco_total = 0, ipi = 0, st = 0, frete = 0, desconto = 0, seguro = 0, outras_desp = 0;
                        try
                        {
                            preco_total = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            ipi = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            st = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            frete = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_frete"].Value.ToString());
                        }
                        catch
                        { }
                        try
                        {
                            desconto = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            seguro = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_seguro"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            outras_desp = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_outras_desp"].Value.ToString());
                        }
                        catch { }
                        valor_faturado = valor_faturado + preco_total + ipi + st + frete + seguro + outras_desp - desconto;

                    }
                }
                catch { }


            }
            return valor_faturado;
        }

        private bool verificar_se_e_faturado(string cfo)
        {
            if (verificar_se_e_tributada(cfo))
                return true;
            else
                return false;
        }
        private void insere_fatura(string prazo, string data, string valor, string nf)
        {

            this.datFatura_nf.InsertCommand.CommandText =
                    "INSERT INTO FATURA_NF (PRAZO_FATURA, DATA_VENC_FATURA, VALOR_FATURA, NF_FATURA)" +
                    "VALUES ('" + prazo + "','" + data + "','" + valor + "','" + nf + "')";
            this.fbConnection1.Open();
            this.datFatura_nf.InsertCommand.Connection = fbConnection1;
            this.datFatura_nf.InsertCommand.ExecuteNonQuery();
            this.fbConnection1.Close();


        }

        private void apaga_faturas_anteriores()
        {
            this.datFatura_nf.DeleteCommand.CommandText =
                    "DELETE FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
            this.fbConnection1.Open();
            this.datFatura_nf.DeleteCommand.Connection = fbConnection1;
            this.datFatura_nf.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }
        /*
        private void dgvItens_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_nota.Columns[e.ColumnIndex].Name == "Trib")
            {
                abrir_tributacao(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod"].Value.ToString(),
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_preco_total"].Value.ToString(),
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_prestacao_servico"].Value.ToString(), e.RowIndex);
            }
            
        }

        private void abrir_tributacao(string item, string valor, string prestacao, int linha)
        {
            form_tributacao trib = new form_tributacao();
            try
            {
                trib.variavel_trib = verificar_variavel_trib();
                trib.cod_variavel_trib = verificar_cod_variavel_trib(verificar_variavel_trib(), linha);
                trib.item_selecionado = item;
                trib.valor_total_prod = valor;
                if (prestacao == "1")
                    trib.prestacao_servico = true;
                trib.selecionar = true;
                
                trib.ShowDialog();

            }
            finally {
                try
                {
                    string valor_ic = trib.valor_icm_item_2;
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = valor_ic;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = "0";
                }
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = trib.ipi_item_2;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = "0";
                }
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = trib.icm_item_2;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = "0";
                }
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = trib.valor_bc_item_2;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = "0";
                }
                string _st = "", _valor_bc_st = "", _valor_st = "", _valor_ipi = "";
                comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                DataSet _trib = new DataSet();
                fbConnection1.Open();
                datTributacao.SelectCommand = comando_select;
                datTributacao.Fill(_trib);
                int n = 0;
                foreach (DataRow dr in _trib.Tables[0].Rows)
                {

                    _st = dr["ICMS_TRI_ICM"].ToString();
                    _valor_bc_st = dr["ICMS_ST_VAL_BC_ICM"].ToString();
                    _valor_st = dr["ICMS_ST_VAL_ICM"].ToString();
                    _valor_ipi = dr["IPI_VAL_IPI"].ToString();

                }
                fbConnection1.Close();
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_st"].Value = _st;
                }
                catch { }
                try
                {
                    if (_valor_bc_st != "")
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc_st"].Value = _valor_bc_st;
                    }
                }
                catch { }
                try
                {
                    if (_valor_st != "")
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_st"].Value = _valor_st;
                    }

                }
                catch { }
                try
                {
                    if (_valor_ipi != "")
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_ipi"].Value = _valor_ipi;
                    }

                }
                catch { }

                Atualizar(false);
                //dsItens_nota.Clear();
                //datItens_nota.Fill(ITENS_NOTA);
                trib.Dispose();
                /*
                if (dgvItens_nota.Rows[linha].Cells["col_prestacao_servico"].Value.ToString() == "1")
                {
                    dgvItens_nota.Rows[linha].Cells["col_valor_iss"].Value = trib.valor_iss_item_2;
                }
                else
                {
                    try
                    {
                        string valor_ic = trib.valor_icm_item_2;
                        dgvItens_nota.Rows[linha].Cells["col_valor_icm"].Value = valor_ic;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_valor_icm"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[linha].Cells["col_ipi"].Value = trib.ipi_item_2;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_ipi"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[linha].Cells["col_icms"].Value = trib.icm_item_2;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_icms"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[linha].Cells["col_valor_bc"].Value = trib.valor_bc_item_2;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_valor_bc"].Value = "0";
                    }
                    string _st = "";
                    comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                    DataSet _trib = new DataSet();
                    fbConnection1.Open();
                    datTributacao.SelectCommand = comando_select;
                    datTributacao.Fill(_trib);
                    int n = 0;
                    foreach (DataRow dr in _trib.Tables[0].Rows)
                    {

                        _st = dr["ICMS_TRI_ICM"].ToString();

                    }
                    fbConnection1.Close();
                    dgvItens_nota.Rows[linha].Cells["col_st"].Value = _st;
                    Atualizar(false);
                    //dsItens_nota.Clear();
                   //datItens_nota.Fill(ITENS_NOTA);
                    trib.Dispose();
                }
                 
            }
        }
        */
        private void tb_cfo_peca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form_localiza_cfo localiza_cfo = new form_localiza_cfo();
            try
            {
                localiza_cfo.ShowDialog();
            }
            finally
            {
                localiza_cfo.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                tb_cfo_peca.Text = localiza_cfo.cfo_escolhida;


            }
        }

        private void br_consultaStatus_Click(object sender, EventArgs e)
        {
            if (tb_protocolo_autorizacao.Text == "")
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

                detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);

                int ambiente = 2;
                if (cbNfe_teste.Checked == false)
                    ambiente = 1;
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgCabec, _msgDados, _msgRetWS, _msgResultado;
                string arquivo = "";
                string caminho = "c:\\evolucao_dokinos\\NFE\\assinadas\\" + "NFE" + tb_n_nf.Text + "_assinadas.xml";
                StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                arquivo = objReader.ReadToEnd();
                string recibo = tb_recibo.Text;
                string _dhProtocolo = "";
                string _nroProtocolo = "";
                string _cMsg = ""; string _xMsg = "";
                int cStat = 0;
                objReader.Close();
                string _procNF = util2.BuscaNFe2G(estado_empresa, ambiente, ref arquivo, recibo, nomeCertificado, "2.00", out _msgDados,
                    out _msgRetWS, out cStat, out _msgResultado, out _nroProtocolo, out _dhProtocolo, out _cMsg, out _xMsg, proxy, usuario,
                    senha, licenca);
                //int resultado = util2.ConsultaNF2G(estado_empresa, ambiente, nome_certificado_nfe_empresa,"2.00", out _msgDados, out _msgRetWS, out _msgResultado, tb_chave_acesso_nfe.Text, proxy, usuario, senha);
                //int resultado = util.BuscaNFeSCAN(estado_empresa, ambiente, estado_empresa, ref arquivo, ref recibo, out _procNF, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, proxy, usuario, senha, licenca);
                if (cStat == 0)
                {
                    barra_status.Text = "Ok";
                    tb_status_nfe.Text = "Ok";
                    //salvar_xml_autorizado(_NFeAssinada);
                }
                else
                {
                    if (cStat == 105)
                    {
                        barra_status.Text = "Lote em processamento";
                    }

                    else
                    {
                        if (cStat == 106)
                        {
                            barra_status.Text = "Lote não localizado";
                        }
                        else
                        {
                            if (cStat == 110)
                            {
                                barra_status.Text = "NFe Cancelada.";
                            }
                            else
                            {
                                if (cStat == 100)
                                {
                                    criar_codigo_barras();
                                    gerar_xml_autorizada(_procNF);
                                    barra_status.Text = "NFe Autorizada. ";
                                    tb_status_nfe.Text = "NFe Autorizada.";
                                    tb_protocolo_autorizacao.Text = _nroProtocolo;
                                    inserir_duplicatas_cr();

                                    //if (tb_cnpj_cliente = "14998371004530")
                                    //{
                                        //acertarEstoque();
                                    //}

                                    /*
                                    classe_particularidades part = new classe_particularidades();
                                    part.executar_particularidades(tb_n_nf.Text);
                                    
                                    inserir_status_pedido();
                                     * */
                                    gbNfe.BackColor = Color.GreenYellow;
                                    Atualizar(true);
                                    try
                                    {
                                        imprimir();
                                    }
                                    finally
                                    {
                                        enviar_email();
                                        Atualizar(true);
                                    }


                                }
                                else
                                {
                                    MessageBox.Show(_msgResultado, cStat.ToString());

                                }
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Essa NF já foi autorizada");
            }
        }

        private void acertarEstoque()
        {
            classeEstoque estoque = new classeEstoque();

            for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
            {
                estoque.acertarEstoqueProdutos(dgvItens_nota.Rows[i].Cells["col_ean"].Value.ToString());
            }
        }

        private void inserir_status_pedido()
        {
            for (int p = 0; p < dgvPedidos.RowCount; p++)
            {
                if (tb_status_nfe.Text == "NFe Autorizada.")
                {
                    try
                    {
                        this.datPedidos_venda.UpdateCommand.CommandText =
                            "UPDATE PEDIDOS_VENDA SET NF_PED_VENDA = '1' WHERE COD_PED_VENDA = '" + dgvPedidos.Rows[p].Cells["col_pedido"].Value.ToString() + "'";
                        this.fbConnection1.Open();
                        this.datPedidos_venda.UpdateCommand.Connection = fbConnection1;
                        this.datPedidos_venda.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                        MessageBox.Show("Erro na baixa do pedido");
                    }
                }
                else
                {
                    try
                    {
                        this.datPedidos_venda.UpdateCommand.CommandText =
                            "UPDATE PEDIDOS_VENDA SET NF_PED_VENDA = '0' WHERE COD_PED_VENDA = '" + dgvPedidos.Rows[p].Cells["col_pedido"].Value.ToString() + "'";
                        this.fbConnection1.Open();
                        this.datPedidos_venda.UpdateCommand.Connection = fbConnection1;
                        this.datPedidos_venda.UpdateCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                        MessageBox.Show("Erro no cancelamento da baixa do pedido");
                    }
                }
            }
        }

        private void gerar_xml_autorizada(string xml_autorizado)
        {
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }
        }

        private void enviar_email()
        {

            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
        complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
        cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
        senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);

            string _caminho_arquivo = "c:\\evolucao_dokinos\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml";
            string _caminho_danfe = "c:\\evolucao_dokinos\\NFE\\DANFES\\DANFE_NFE_" + tb_n_nf.Text + ".pdf";
            //var assunto
            string _assunto = assunto_nfe_email_empresa + " " + tb_chave_acesso_nfe.Text;
            double _valor_total = Convert.ToDouble(tb_total_nota.Text);
            string _mensagem = "<html xmlns:v='urn:schemas-microsoft-com:vml'" +
"xmlns:o='urn:schemas-microsoft-com:office:office'" +
"xmlns:w='urn:schemas-microsoft-com:office:word'" +
"xmlns='http://www.w3.org/TR/REC-html40'>" +

"<head>" +
"<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>" +
"<meta name=ProgId content=Word.Document>" +
"<meta name=Generator content='Microsoft Word 11'>" +
"<meta name=Originator content='Microsoft Word 11'>" +
"<link rel=File-List href='body_arquivos/filelist.xml'>" +
"<title>Prezado cliente,</title>" +
"</head>" +
"<body lang=PT-BR link=blue vlink=purple style='tab-interval:35.4pt' fontface = 'Arial'> " +
"<div class=Section1> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Prezado cliente,<o:p></o:p></span></p> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Segue anexo a Nota Fiscal Eletrônica em XML sob n.: <o:p></o:p></span></p>" +
"<p class=MsoPlainText><span class=GramE><span style='font-family:'Comic Sans MS';color:red'>" + tb_chave_acesso_nfe.Text + "</span><span" +
"style='font-family:'Comic Sans MS''>, série 001</span></span><span style='font-family:'Comic Sans MS''> de " + razao_social_empresa + ", no valor de R$ <span style='color:red'>" + _valor_total.ToString("n2") + ". </span><br> O DANFE segue em PDF e fisicamente com a mercadoria.<br><br><o:p></o:p></span></p>" +
        "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Atenciosamente,<o:p></o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-bidi-font-family:Arial'><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-no-proof:yes'>_________________________<br>" +
"Setor de Faturamento<br>" +
"Tel: " + telefone_empresa + "<br>" +
"e-mail: <a href='mailto:" + email_nfe_empresa + "'>" + email_nfe_empresa + "</a><br>" +
"</div>" +
"</body>" +
"</html>";
            Email novo_email = new Email();
            bool _erro;
            //var smtp, email, senha_email
            novo_email.EnviarEmail(detectar_email(), _assunto, _mensagem, _caminho_arquivo, _caminho_danfe, email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro);

            if (_erro == false)
            {
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
            }
            else
            {
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }
        }


        private string detectar_email()
        {
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT EMAIL " +
                "FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
            DataSet cliente = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando;
            datClientes.Fill(cliente);
            string cliente_atual = "";
            foreach (DataRow dr in cliente.Tables[0].Rows)
            {

                cliente_atual = dr["EMAIL"].ToString();
            }

            this.fbConnection1.Close();
            return cliente_atual;

        }

        private void bt_imprimirNFe_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void imprimir()
        {


            if (tb_protocolo_autorizacao.Text == "")
            {
                MessageBox.Show("Não esqueça de Consultar o Status da NFe");
            }


            if (cb_forma_pgto.Text[0].ToString() == "1" || cb_forma_pgto.Text[0].ToString() == "0")
            {
                string valor_total = buscar_valor_faturado().ToString("n2");
                int _n_vencimentos;
                //a parada é 6 pois é o numero máximo de parcelas
                for (int i = 0; i < 6; i++)
                {
                    _cod[i] = ""; _datas[i] = ""; _valores[i] = "";
                }
                detectar_numero_vencimentos_fatura(out _n_vencimentos);
                string cod1 = "0", cod2 = "0", cod3 = "0", cod4 = "0", cod5 = "0", cod6 = "0";
                string data1 = "01/01/2001", data2 = "01/01/2001", data3 = "01/01/2001", data4 = "01/01/2001", data5 = "01/01/2001", data6 = "01/01/2001";
                string valor1 = "0.0", valor2 = "0.0", valor3 = "0.0", valor4 = "0.0", valor5 = "0.0", valor6 = "0.0";
                try { cod1 = Convert.ToInt32(_cod[0]).ToString(); data1 = Convert.ToDateTime(_datas[0]).ToShortDateString().Replace("/", "."); valor1 = _valores[0].Replace(",", "."); }
                catch { }
                try { cod2 = Convert.ToInt32(_cod[1]).ToString(); data2 = Convert.ToDateTime(_datas[1]).ToShortDateString().Replace("/", "."); valor2 = _valores[1].Replace(",", "."); }
                catch { }
                try { cod3 = Convert.ToInt32(_cod[2]).ToString(); data3 = Convert.ToDateTime(_datas[2]).ToShortDateString().Replace("/", "."); valor3 = _valores[2].Replace(",", "."); }
                catch { }
                try { cod4 = Convert.ToInt32(_cod[3]).ToString(); data4 = Convert.ToDateTime(_datas[3]).ToShortDateString().Replace("/", "."); valor4 = _valores[3].Replace(",", "."); }
                catch { }
                try { cod5 = Convert.ToInt32(_cod[4]).ToString(); data5 = Convert.ToDateTime(_datas[4]).ToShortDateString().Replace("/", "."); valor5 = _valores[4].Replace(",", "."); }
                catch { }
                try { cod6 = Convert.ToInt32(_cod[5]).ToString(); data6 = Convert.ToDateTime(_datas[5]).ToShortDateString().Replace("/", "."); valor6 = _valores[5].Replace(",", "."); }
                catch { }
                this.datImp_duplicatas.DeleteCommand.CommandText =
                    "DELETE FROM IMP_DUPLICATAS";
                this.fbConnection1.Open();
                this.datImp_duplicatas.DeleteCommand.Connection = fbConnection1;
                this.datImp_duplicatas.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datImp_duplicatas.InsertCommand.CommandText =
                "INSERT INTO IMP_DUPLICATAS (COD_1_IMP_DUPLICATA, DATA_1_IMP_DUPLICATA, VALOR_1_IMP_DUPLICATA, " +
                "COD_2_IMP_DUPLICATA, DATA_2_IMP_DUPLICATA, VALOR_2_IMP_DUPLICATA, " +
                "COD_3_IMP_DUPLICATA, DATA_3_IMP_DUPLICATA, VALOR_3_IMP_DUPLICATA, " +
                "COD_4_IMP_DUPLICATA, DATA_4_IMP_DUPLICATA, VALOR_4_IMP_DUPLICATA, " +
                "COD_5_IMP_DUPLICATA, DATA_5_IMP_DUPLICATA, VALOR_5_IMP_DUPLICATA, " +
                "COD_6_IMP_DUPLICATA, DATA_6_IMP_DUPLICATA, VALOR_6_IMP_DUPLICATA) " +
                "VALUES ('" + cod1 + "', '" + data1 + "', '" + valor1 + "'," +
                "'" + cod2 + "', '" + data2 + "', '" + valor2 + "'," +
                "'" + cod3 + "', '" + data3 + "', '" + valor3 + "'," +
                "'" + cod4 + "', '" + data4 + "', '" + valor4 + "'," +
                "'" + cod5 + "', '" + data5 + "', '" + valor5 + "'," +
                "'" + cod6 + "', '" + data6 + "', '" + valor6 + "')";
                this.fbConnection1.Open();
                this.datImp_duplicatas.InsertCommand.Connection = fbConnection1;
                this.datImp_duplicatas.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                datImp_duplicatas.Fill(IMP_DUPLICATAS);
            }

            inserir_cst_impressao();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET NOTA_STRING_NF = '" + numero_nf(9, tb_n_nf.Text) + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            detectar_dados_cliente(tb_cnpj_cliente.Text);
            /*
            if (tb_natureza_operacao.Text.Contains("VENDA") == true )
            {
                inserir_simples(tb_n_nf.Text);
            }

            else
            {
                apagar_simples(tb_n_nf.Text);
            }
            */
            dsCfo.Clear();
            dsTransportadoras.Clear();
            this.datTransportadoras.SelectCommand.CommandText =
                "SELECT * FROM TRANSPORTADORAS WHERE RAZAO_SOCIAL_TRANSPORTADORA = '" + tb_transportadora.Text + "'";
            this.fbConnection1.Open();
            this.datTransportadoras.SelectCommand.Connection = fbConnection1;
            this.datTransportadoras.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            dsImprimir_op imprimir = new dsImprimir_op();
            fbConnection1.Open();
            datTransportadoras.Fill(imprimir.TRANSPORTADORAS);
            datItens_nota.Fill(imprimir.ITENS_NOTA);
            datEmpresa.Fill(imprimir.EMPRESA);
            fbConnection1.Close();

            //Pedidos da nota
            imprimir.PEDIDOS_NF.Clear();
            try
            {
                datPedidos_nf.SelectCommand.CommandText =
                    "SELECT pnf.*, pv.vendedor_ped_venda " +
                    "FROM PEDIDOS_NF pnf " +
                    "INNER JOIN pedidos_venda pv " +
                    "ON pv.cod_ped_venda = pnf.n_pedido_nf " +
                    "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";
                datPedidos_nf.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datPedidos_nf.SelectCommand.ExecuteNonQuery();
                datPedidos_nf.Fill(imprimir.PEDIDOS_NF);
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Não foi possível selecionar os pedidos para a impressão!\nErro: " + a.Message);
            }

            datNota_fiscal.Fill(imprimir.NOTA_FISCAL);
            if (cb_forma_pgto.Text[0].ToString() == "1" || cb_forma_pgto.Text[0].ToString() == "0")
                datImp_duplicatas.Fill(imprimir.IMP_DUPLICATAS);
            fbConnection1.Close();
            crNfe nova_nota = new crNfe();
            nova_nota.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(nova_nota);
            imprime.n_nfe = tb_n_nf.Text;
            imprime.nfe = true;
            imprime.Show();
        }


        private void inserir_cst_impressao()
        {
            if (!empresa_simples())
            {
                for (int q = 0; q < dgvItens_nota.RowCount; q++)
                {
                    try
                    {
                        datItens_nota.UpdateCommand.CommandText =
                            "UPDATE ITENS_NOTA SET ST_IMPRESSAO_ITEM = '" +
                            dgvItens_nota.Rows[q].Cells["col_origem"].Value.ToString() +
                            dgvItens_nota.Rows[q].Cells["col_st"].Value.ToString() +
                            "' WHERE COD_ITENS_NOTA = '" + dgvItens_nota.Rows[q].Cells["col_cod"].Value.ToString() + "'";
                        fbConnection1.Open();
                        datItens_nota.UpdateCommand.Connection = fbConnection1;
                        datItens_nota.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }
            }
            else
            {
                for (int q = 0; q < dgvItens_nota.RowCount; q++)
                {
                    try
                    {
                        datItens_nota.UpdateCommand.CommandText =
                            "UPDATE ITENS_NOTA SET ST_IMPRESSAO_ITEM = '" +
                            dgvItens_nota.Rows[q].Cells["col_st"].Value.ToString() +
                            "' WHERE COD_ITENS_NOTA = '" + dgvItens_nota.Rows[q].Cells["col_cod"].Value.ToString() + "'";
                        fbConnection1.Open();
                        datItens_nota.UpdateCommand.Connection = fbConnection1;
                        datItens_nota.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }
            }
        }

        private bool empresa_simples()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = "SELECT CRT_EMPRESA FROM EMPRESA";
                DataSet empresa = new DataSet();
                FbDataAdapter datEmpresa2 = new FbDataAdapter();
                datEmpresa2.SelectCommand = select;
                datEmpresa2.Fill(empresa);
                DataRow dr = empresa.Tables[0].Rows[0];
                fbConnection1.Close();
                if (dr[0].ToString() == "1")
                    return true;
                else
                    return false;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }

        private void inserir_simples(string numero)
        {
            string _aliquota = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * " +
                "FROM ALIQUOTA_SIMPLES";
            DataSet ali = new DataSet();
            fbConnection1.Open();
            datAliquota.SelectCommand = comando;
            datAliquota.Fill(ali);

            foreach (DataRow dr in ali.Tables[0].Rows)
            {
                _aliquota = dr["VALOR_ALIQUOTA"].ToString();
            }
            fbConnection1.Close();
            double _valor_prod = 0;
            double _valor_aliquota = 0;
            double _valor_com_aliquota = 0;
            try
            {
                _valor_prod = Convert.ToDouble(tb_total_prod.Text);
                _valor_aliquota = Convert.ToDouble(_aliquota); //falta calcular valor com aliquota e inserir no NOTAS_FISCAIS
                _valor_com_aliquota = (_valor_prod * _valor_aliquota) / 100;
            }
            catch
            {

            }

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET ALIQUOTA_SIMPLES_NF = '" + _valor_aliquota.ToString("n2").Replace(",", ".") + "' WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET VALOR_SIMPLES_NF = '" + _valor_com_aliquota.ToString("n2").Replace(".", "").Replace(",", ".") + "' WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();



        }

        private void apagar_simples(string numero)
        {


            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET ALIQUOTA_SIMPLES_NF = null WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET VALOR_SIMPLES_NF = null WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();



        }

        private string detectar_cod_cliente(string _cnpj)
        {
            string _cod = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * " +
                "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
            DataSet nf = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando;
            datClientes.Fill(nf);
            int n = 0;
            foreach (DataRow dr in nf.Tables[0].Rows)
            {

                _cod = dr["COD_CLIENTE"].ToString();

            }
            fbConnection1.Close();
            return _cod;

        }
        private void detectar_dados_cliente(string _cnpj)
        {
            string _endereco = "", _numero = "", _complemento = "", _razao_social = "", _ie = "", _bairro = "", _cidade = "", _estado = "", _pais = "", _cep = "", _fone = "", _email = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * " +
                "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
            DataSet nf = new DataSet();
            fbConnection1.Open();
            FbDataAdapter cliente = new FbDataAdapter();
            cliente.SelectCommand = comando;
            cliente.Fill(nf);

            int n = 0;
            foreach (DataRow dr in nf.Tables[0].Rows)
            {

                _endereco = dr["ENDERECO"].ToString();
                _numero = dr["NUMERO_CLIENTE"].ToString();
                _complemento = dr["COMPLEMENTO_CLIENTE"].ToString();
                _razao_social = dr["RAZAO_SOCIAL"].ToString();
                _ie = dr["IE"].ToString();
                _bairro = dr["BAIRRO"].ToString();
                _cidade = dr["CIDADE"].ToString();
                _estado = dr["ESTADO"].ToString();
                _pais = dr["PAIS"].ToString();
                _cep = dr["CEP_CLIENTE"].ToString();
                _fone = dr["FONE"].ToString();
                _email = dr["EMAIL"].ToString();
            }
            fbConnection1.Close();
            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET END_NUMERO_STRING_NF = '" + _endereco + ", " + _numero + " " + _complemento + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET RAZAO_SOCIAL_CL_NF = '" + _razao_social + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET IE_CL_NF = '" + _ie + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET CNPJ_CL_NF = '" + _cnpj + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET BAIRRO_CL_NF = '" + _bairro + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET CIDADE_CL_NF = '" + _cidade + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET ESTADO_CL_NF = '" + _estado + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET PAIS_CL_NF = '" + _pais + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET CEP_CL_NF = '" + _cep + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET FONE_CL_NF = '" + _fone + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }
        private string end_nf(string _cnpj)
        {
            string _endereco = "", _numero = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT ENDERECO, NUMERO_CLIENTE " +
                "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
            DataSet nf = new DataSet();
            fbConnection1.Open();
            FbDataAdapter cliente = new FbDataAdapter();
            cliente.SelectCommand = comando;
            cliente.Fill(nf);
            int n = 0;
            foreach (DataRow dr in nf.Tables[0].Rows)
            {

                _endereco = dr["ENDERECO"].ToString();
                _numero = dr["NUMERO_CLIENTE"].ToString();


            }

            fbConnection1.Close();
            return _endereco + ", " + _numero;
        }


        private string numero_nf(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            return valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true);
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                tb_cnpj_cliente.Text = localiza_cliente.cnpj_escolhido;
                tb_cliente.Text = localiza_cliente.cliente_escolhido;
                tb_estado_cliente.Text = localiza_cliente.estado_escolhido;
                //tb_dados_adicionais.Text = "#C.FISC.: " + tb_class_fiscal.Text + "#" + tb_dados_adicionais.Text;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            enviar_email();
        }

        private void bt_cancelarNFe_Click(object sender, EventArgs e)
        {
            if (tb_motivo_cancelamento.Text.Length < 15)
                MessageBox.Show("Digite o motivo do cancelamento com pelo menos 15 caracteres");
            else
            {

                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

                detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);
                if (tb_protocolo_autorizacao.Text == "")
                    tb_protocolo_autorizacao.Text = buscar_no_xml("c:\\evolucao_dokinos\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml", "nProt");
                int ambiente = 2;
                if (cbNfe_teste.Checked == false)
                    ambiente = 1;
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgCabec, _msgDados, _msgRetWS, _msgResultado, _retWS,
                    _nProtocolo_cancelamento, _dProtocolo_cancelamento;
                int resultado = 0;
                string _xml = util2.CancelaNF2G(estado_empresa, ambiente, nomeCertificado, "1.00", out _msgDados,
                    out _retWS, out resultado, out _msgResultado, tb_chave_acesso_nfe.Text, tb_protocolo_autorizacao.Text,
                    tb_motivo_cancelamento.Text, out _nProtocolo_cancelamento, out _dProtocolo_cancelamento,
                    proxy, usuario, senha, licenca);
                //int resultado = util.CancelaNFSCAN(estado_empresa, ambiente, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, tb_chave_acesso_nfe.Text, tb_protocolo_autorizacao.Text, tb_motivo_cancelamento.Text, proxy, usuario, senha, licenca);
                if (resultado == 101 || resultado == 151 || resultado == 135 || resultado == 155)
                {
                    gerar_xml_cancelada(_xml);
                    barra_status.Text = "NFe Cancelada com sucesso";
                    tb_status_nfe.Text = "NFe Cancelada com sucesso";
                    inserir_status_pedido();
                    gbNfe.BackColor = Color.Red;
                    Atualizar(true);
                }
                else
                {
                    MessageBox.Show(_msgResultado, resultado.ToString());
                    gerar_xml_cancelada(_xml);
                    barra_status.Text = "NFe não foi cancelada. Motivo da rejeição: " + buscar_no_xml("c:\\evolucao_dokinos\\NFE\\canceladas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml", "xMotivo");
                    tb_status_nfe.Text = "NFe não foi cancelada. Motivo da rejeição: " + buscar_no_xml("c:\\evolucao_dokinos\\NFE\\canceladas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml", "xMotivo"); ;

                }
            }
        }

        private void gerar_xml_cancelada(string xml_cancelada)
        {
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\NFE\\canceladas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_cancelada);
            }
        }

        private string buscar_no_xml(string caminho, string no)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminho);
            string data;
            XmlNode elementoData;
            //Usar para quando tiver links porque dá senão o xml não lê
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("ab", "http://www.portalfiscal.inf.br/nfe");
            elementoData = doc.SelectSingleNode("//ab:" + no, nsmgr);
            data = elementoData.InnerText;
            return data;

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            inserir_duplicatas_cr();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            tb_recibo.Text = "";
        }

        private void tb_cod_peca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                buscar_produto(tb_cod_peca.Text);
            }
        }


        private void tb_cod_peca_DoubleClick(object sender, EventArgs e)
        {
            /*
            form_produtos prod = new form_produtos();
            try
            {
                prod.busca = true;
                prod.ShowDialog();
            }
            finally
            {
                prod.Dispose();
                buscar_produto(prod.cod_escolhido);
            }
             * */
        }

        private void rb_nao_tributada_CheckedChanged(object sender, EventArgs e)
        {

            //Atualizar(false);
        }

        private void rb_pecas_CheckedChanged(object sender, EventArgs e)
        {
            //Atualizar(false);
            tb_ncm_peca.Text = "84669410";
        }

        private void rb_terminal_CheckedChanged(object sender, EventArgs e)
        {
            tb_ncm_peca.Text = "85369090";
            // Atualizar(false);
        }

        private void cb_ipi_suspenso_CheckedChanged(object sender, EventArgs e)
        {
            // Atualizar(false);
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            abre_nova();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inserir_nova_forma_pgto();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            /*
            Atualizar(false);
            form_produtos prod = new form_produtos();
            try
            {
                prod.busca = true;
                prod.ShowDialog();
            }
            finally
            {
                try
                {
                    if (prod.cod_escolhido != null)
                    {
                        buscar_produto(prod.cod_escolhido);
                    }
                }
                catch{}

            }
             * */

            form_pesquisa_pedido ped = new form_pesquisa_pedido();
            try
            {
                ped.selecao_nf = true;
                ped.ShowDialog();
            }
            finally
            {

                string cfop = "";

                for (int i = 0; i < ped.numero_pedidos; i++)
                {
                    
                    //Zerando cfop para novo pedido
                    cfop = "0";

                    //Vinculando nf com pedido
                    try
                    {
                        this.datPedidos_nf.InsertCommand.CommandText =
                        "INSERT INTO PEDIDOS_NF (NF_PEDIDO_NF, N_PEDIDO_NF)" +
                        "VALUES ('" + tb_n_nf.Text + "','" + ped.pedidos_selecionados[i] + "')";
                        this.fbConnection1.Open();
                        this.datPedidos_nf.InsertCommand.Connection = fbConnection1;
                        this.datPedidos_nf.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        dsPedidos_nf.Clear();
                        this.datPedidos_nf.SelectCommand.CommandText =
                        "SELECT * FROM PEDIDOS_NF WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";
                        /*"SELECT pnf.*, pv.vendedor_ped_venda " +
                        "FROM PEDIDOS_NF pnf " +
                        "INNER JOIN pedidos_venda pv " +
                        "ON pv.cod_ped_venda = pnf.n_pedido_nf " +
                        "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'"; */        
                        this.fbConnection1.Open();
                        this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                        this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                        datPedidos_nf.Fill(PEDIDOS_NF);
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        MessageBox.Show("erro na inserção do pedido-nf.");
                        fbConnection1.Close();
                    }

                    //inserindo o cliente

                    try
                    {
                        FbCommand comando = new FbCommand();
                        comando.Connection = fbConnection1;
                        comando.CommandText =
                            "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + ped.pedidos_selecionados[i] + "'";
                        DataSet pedido = new DataSet();
                        fbConnection1.Open();
                        datPedidos_venda.SelectCommand = comando;
                        datPedidos_venda.Fill(pedido);
                        string _cnpj = "";
                        string _cliente = "";
                        string _estado = "";
                        foreach (DataRow dr in pedido.Tables[0].Rows)
                        {
                            _cnpj = dr["CNPJ_PED_VENDA"].ToString();
                            _cliente = dr["CLIENTE_PED_VENDA"].ToString();
                        }
                        fbConnection1.Close();
                        tb_cnpj_cliente.Text = _cnpj;
                        tb_cliente.Text = _cliente;
                        bool pessoa_fisica;
                        string ie_cliente_2, cnpj_cliente_2, logradouro_cliente_2, n_logradouro_cliente_2, complemento_cliente_2, bairro_cliente_2, cod_municipio_cliente_2,
                 uf_cliente_2, cep_cliente_2, cod_pais_cliente_2, pais_cliente_2, telefone_cliente_2, cidade_cliente_2, email_cliente_2;
                        buscar_dados_cliente(tb_cnpj_cliente.Text, out ie_cliente_2, out cnpj_cliente_2, out logradouro_cliente_2,
                    out n_logradouro_cliente_2, out complemento_cliente_2, out bairro_cliente_2,
                    out cod_municipio_cliente_2, out uf_cliente_2, out cep_cliente_2, out cod_pais_cliente_2,
                    out pais_cliente_2, out telefone_cliente_2, out cidade_cliente_2, out pessoa_fisica, out email_cliente_2);
                        _estado = uf_cliente_2;
                        tb_estado_cliente.Text = _estado;
                    }
                    catch
                    {
                        MessageBox.Show("Erro na inserção do cliente");
                        fbConnection1.Close();
                    }


                    //inserindo os itens
                    try
                    {
                        FbCommand comando = new FbCommand();
                        comando.Connection = fbConnection1;
                        comando.CommandText =
                            "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + ped.pedidos_selecionados[i] + "'";
                        DataSet itens = new DataSet();
                        fbConnection1.Open();
                        datItens_pedido_venda.SelectCommand = comando;
                        datItens_pedido_venda.Fill(itens);
                        string[] _cod = new string[200];
                        string[] _descricao = new string[200];
                        string[] _unidade = new string[200];
                        string[] _qtde = new string[200];
                        string[] _valor_unit = new string[200];

                        int k = 0;
                        foreach (DataRow dr in itens.Tables[0].Rows)
                        {
                            _cod[k] = dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString();
                            _descricao[k] = dr["DESCRICAO_PROD_ITEM_VENDA"].ToString() + " " + dr["DESCRICAO_ITEM_PROD_ITEM_VENDA"].ToString();
                            _unidade[k] = dr["UNIDADE_PROD_ITEM_VENDA"].ToString();
                            _qtde[k] = dr["QTDE_ITEM_VENDA"].ToString();
                            _valor_unit[k] = dr["VALOR_UNIT_PROD_ITEM_VENDA"].ToString();

                            k++;
                        }
                        fbConnection1.Close();


                        //Verificando se tem CFOP padrão
                        if (cbxCfopPadrao.Checked)
                        {
                            if (tb_cfo_peca.Text != "")
                            {
                                cfop = tb_cfo_peca.Text;
                            }
                        }
                        
                        for (int j = 0; j < k; j++)
                        {
                            tb_cod_peca.Text = _cod[j];
                            tb_descricao_peca.Text = _descricao[j];
                            tb_unid_peca.Text = _unidade[j];
                            tb_qtde_peca.Text = _qtde[j];
                            tb_preco_unit_peca.Text = _valor_unit[j];
                            string origem = "";
                            string cst = "";
                            string ean = "";
                            tb_ncm_peca.Text = buscar_ncm_cfop_origem(_cod[j], tb_estado_cliente.Text, out origem, out cst, out ean);
                            

                            tb_cfo_peca.Text = cfop;

                            tb_origem_peca.Text = "0"; //só tem produto nacional
                            tb_ean.Text = ean;
                            //tb_cst.Text = cst;
                            if (tb_descricao_peca.Text != "")
                                inserir_itens();

                        }
                    }
                    catch
                    {
                        MessageBox.Show("erro na inserção do item");
                        fbConnection1.Close();
                    }

                }

            }
        }

        private string buscar_ncm_cfop_origem(string codigo, string estado, out string origem, out string cst, out string ean)
        {
            string cfop = "ERRO";
            origem = "ERRO";
            cst = "ERRO";
            ean = "ERRO";
            try
            {

                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT NCM_PRODUTO, CFOP_ENTRADA_PRODUTO, ORIGEM_PRODUTO, IVA_PRODUTO, COD_BARRAS_PRODUTO FROM PRODUTOS WHERE " +
                    "COD_PRODUTO = '" + codigo + "'";
                DataSet itens = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando;
                datProdutos.Fill(itens);
                fbConnection1.Close();
                string ncm = "ERRO", cfop_entrada = "ERRO";
                string iva = "";
                foreach (DataRow dr in itens.Tables[0].Rows)
                {
                    ncm = dr["NCM_PRODUTO"].ToString();
                    cfop_entrada = dr["CFOP_ENTRADA_PRODUTO"].ToString();
                    origem = dr["ORIGEM_PRODUTO"].ToString();
                    iva = dr["IVA_PRODUTO"].ToString();
                    ean = dr["COD_BARRAS_PRODUTO"].ToString();
                }
                if (cfop_entrada == "5101")
                {
                    if (estado == "SP")
                        cfop = "5102";
                    else
                        cfop = "6102";
                }
                if (cfop_entrada == "5102")
                {
                    if (estado == "SP")
                        cfop = "5102";
                    else
                        cfop = "6102";
                }
                if (cfop_entrada == "5403")
                {
                    if (estado == "SP")
                        cfop = "5405";
                    else
                        cfop = "6404";
                }
                if (cfop_entrada == "5401")
                {
                    if (estado == "SP")
                        cfop = "5405";
                    else
                        cfop = "6404";
                }
                double _iva = 0;
                try
                {
                    _iva = Convert.ToDouble(iva);
                }
                catch { }
                if (_iva > 0)
                {
                    cst = "500";
                }
                else
                {
                    cst = "101";
                }
                return ncm;
            }
            catch
            {
                fbConnection1.Close();
                return "ERRO";
            }
            //if(cfop_entrada == 
        }

        private void buscar_produto(string prod)
        {
            try
            {
                string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                     _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                     _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                     _tipo_cofins, _cst_cofins, _pCredICMS;
                buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
                    out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                    out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                    out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                    out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);


                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = " + prod + "";
                fbConnection1.Open();
                DataSet produto = new DataSet();
                datProdutos.SelectCommand = comando;
                datProdutos.Fill(produto);
                fbConnection1.Close();
                if (produto.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = produto.Tables[0].Rows[0];
                    tb_cod_peca.Text = dr["COD_PRODUTO"].ToString();
                    tb_descricao_peca.Text = dr["DESCRICAO_PRODUTO"].ToString();
                    tb_unid_peca.Text = dr["COD_UNIDADE_PRODUTO"].ToString();
                    tb_preco_unit_peca.Text = dr["PRECO_PRODUTO"].ToString();
                    tb_ncm_peca.Text = dr["NCM_PRODUTO"].ToString();
                    tb_origem_peca.Text = dr["ORIGEM_PRODUTO"].ToString();
                    tb_mod_bc_item.Text = dr["MOD_BC_PRODUTO"].ToString();
                    tb_mod_bc_st_item.Text = dr["MOD_BC_ST_PRODUTO"].ToString();
                    tb_cst.Text = dr["ST_SAIDA_PRODUTO"].ToString();
                    tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                    tb_ean.Text = dr["COD_BARRAS_PRODUTO"].ToString();
                    if (_crt == "3") //SE NÃO FOR SIMPLES NACIONAL
                    {
                        //ICMS
                        tb_icms_item.Text = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                        if (dr["BC_COM_IPI_PRODUTO"].ToString() == "1")
                            cbBC_com_ipi.Checked = true;
                        if (tb_estado_cliente.Text != estadolabel.Text)
                        {
                            string icms_st, iva, reducao, reducao_st, icms;
                            verificar_tributacao_cliente(tb_cnpj_cliente.Text, out icms_st, out iva,
                                out reducao, out reducao_st, out icms);
                            tb_cst.Text = _cst;
                            tb_icms_item.Text = icms;
                            if (tb_cst.Text == "00") //SUBST. TRIB
                            {
                                tb_icms_item.Text = icms;
                            }
                            if (tb_cst.Text == "10") //SUBST. TRIB
                            {
                                tb_icms_item.Text = icms_st;
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                                tb_iva_item.Text = iva;
                            }
                            if (tb_cst.Text == "20") //REDUCAO
                            {
                                tb_reducao_item.Text = reducao;
                            }
                            if (tb_cst.Text == "30") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_item.Text = icms_st;
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                                tb_iva_item.Text = iva;
                            }
                            if (tb_cst.Text == "70") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_item.Text = icms_st;
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                                tb_iva_item.Text = iva;
                                tb_reducao_st_item.Text = reducao_st;
                            }
                        }
                        else //DENTRO DO ESTADO
                        {
                            if (tb_cst.Text == "10") //SUBST. TRIB
                            {
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();//PEGA DA INFORMAÇÃO PADRAO
                                tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                            }
                            if (tb_cst.Text == "20") //REDUCAO
                            {
                                tb_reducao_item.Text = dr["REDUCAO_PRODUTO"].ToString();
                            }
                            if (tb_cst.Text == "30") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();//PEGA DA INFORMAÇÃO PADRAO
                                tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                            }
                            if (tb_cst.Text == "70") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();//PEGA DA INFORMAÇÃO PADRAO
                                tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                                tb_reducao_st_item.Text = dr["REDUCAO_ST_PRODUTO"].ToString();
                            }
                        }
                        //IPI
                        if (dr["IPI_TRIB_PRODUTO"].ToString() == "1")
                        {
                            rb_ipi_tributado.Checked = true;
                            tb_cst_ipi_tributado.Text = dr["CST_IPI_TRIB_PRODUTO"].ToString();
                            tb_ipi_item.Text = dr["IPI_PRODUTO"].ToString();
                        }
                        else
                        {
                            rb_ipi_nao_tributado.Checked = true;
                            tb_cst_ipi_n_tributado.Text = dr["CST_IPI_N_TRIB_PRODUTO"].ToString();
                        }

                        //PIS
                        tb_tipo_pis.Text = dr["TIPO_PIS_PRODUTO"].ToString();
                        tb_cst_pis.Text = dr["CST_PIS_PRODUTO"].ToString();
                        tb_pis_item.Text = dr["PIS_PRODUTO"].ToString();

                        //COFINS
                        tb_tipo_cofins.Text = dr["TIPO_COFINS_PRODUTO"].ToString();
                        tb_cst_cofins.Text = dr["CST_COFINS_PRODUTO"].ToString();
                        tb_cofins_item.Text = dr["COFINS_PRODUTO"].ToString();

                    }
                    else //SE FOR SIMPLES NACIONAL - PEGAR INFORMAÇÕES PADROES DA EMPRESA
                    {
                        tb_aliquota_credito.Text = _pCredICMS;
                        if (tb_estado_cliente.Text != estadolabel.Text) //FORA DO ESTADO
                        {//FORA DO ESTADO PEGA ALGUMAS INFORMAÇÕES DO CLIENTE
                            string icms_st, iva, reducao, reducao_st, icms;
                            verificar_tributacao_cliente(tb_cnpj_cliente.Text, out icms_st,
                                out iva, out reducao, out reducao_st, out icms);
                            if (tb_cst.Text == "201") //SUBST. TRIB
                            {
                                tb_icms_st.Text = icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = iva;
                                tb_icms_item.Text = _icms;
                            }
                            if (tb_cst.Text == "202") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_st.Text = icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = iva;
                                tb_icms_item.Text = _icms;
                            }
                        }
                        else
                        {//SE FOR DENTRO DO ESTADO PEGA INFORMAÇÃO PADRÃO DO EMITENTE
                            if (tb_cst.Text == "201") //SUBST. TRIB
                            {
                                tb_icms_st.Text = _icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = _iva;
                                tb_icms_item.Text = _icms;
                            }
                            if (tb_cst.Text == "202") //SUBST. TRIB
                            {
                                tb_icms_st.Text = _icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = _iva;
                                tb_icms_item.Text = _icms;
                            }
                        }
                        //IPI
                        rb_ipi_nao_tributado.Checked = true;
                        tb_cst_ipi_n_tributado.Text = dr["CST_IPI_N_TRIB_PRODUTO"].ToString();

                        //PIS
                        tb_tipo_pis.Text = dr["TIPO_PIS_PRODUTO"].ToString();
                        tb_cst_pis.Text = dr["CST_PIS_PRODUTO"].ToString();
                        tb_pis_item.Text = dr["PIS_PRODUTO"].ToString();

                        //COFINS
                        tb_tipo_cofins.Text = dr["TIPO_COFINS_PRODUTO"].ToString();
                        tb_cst_cofins.Text = dr["CST_COFINS_PRODUTO"].ToString();
                        tb_cofins_item.Text = dr["COFINS_PRODUTO"].ToString();

                    }


                    //ISS
                    if (dr["PRESTACAO_SERVICO_PRODUTO"].ToString() == "1")
                    {
                        tb_iss_item.Text = dr["ISS_PRODUTO"].ToString();
                        tb_tipo_servico.Text = dr["TIPO_SERVICO_PRODUTO"].ToString();
                        cb_prestacao_servico.Checked = true;
                    }
                }
            }


            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }

        }

        private void verificar_tributacao_cliente(string cnpj, out string icms_st, out string iva,
            out string reducao, out string reducao_st, out string icms)
        {
            icms_st = ""; iva = ""; reducao = ""; reducao_st = ""; icms = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT ICMS_ST_CLIENTE, IVA_CLIENTE, REDUCAO_CLIENTE, REDUCAO_ST_CLIENTE, ICMS_CLIENTE FROM CLIENTES " +
                    "WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                DataSet inf = new DataSet();
                datClientes.SelectCommand = comando;
                datClientes.Fill(inf);
                fbConnection1.Close();
                DataRow dr = inf.Tables[0].Rows[0];
                icms_st = dr[0].ToString();
                iva = dr[1].ToString();
                reducao = dr[2].ToString();
                reducao_st = dr[3].ToString();
                icms = dr[4].ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }


        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            tb_protocolo_autorizacao.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            classe_particularidades part = new classe_particularidades();
            part.executar_particularidades(tb_n_nf.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Atualizar(false);
            form_localiza_produto prod = new form_localiza_produto();
            try
            {

                prod.ShowDialog();
            }
            finally
            {
                try
                {
                    if (prod.cod_produto_escolhido != null)
                    {
                        buscar_produto(prod.cod_produto_escolhido);
                    }
                }
                catch { }

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tb_protocolo_autorizacao.Text == "")
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

                detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);

                int ambiente = 2;
                if (cbNfe_teste.Checked == false)
                    ambiente = 1;
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgCabec, _msgDados, _msgRetWS, _msgResultado;
                string arquivo = "";
                string caminho = "c:\\evolucao_dokinos\\NFE\\assinadas\\" + "NFE" + tb_n_nf.Text + "_assinadas.xml";
                StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                arquivo = objReader.ReadToEnd();
                string recibo = tb_recibo.Text;
                string _dhProtocolo = "";
                string _nroProtocolo = "";
                string _retCancNFe = "";
                string _cMsg = ""; string _xMsg = "";
                int resultado;
                int cStat = 0;
                objReader.Close();
                string _procNF = util2.CriaProcNFe2G("SP", ref arquivo, out _nroProtocolo, out _retCancNFe, out resultado, nomeCertificado, out _msgResultado, proxy, usuario, senha);
                if (resultado == 6201)
                {
                    criar_codigo_barras();
                    gerar_xml_autorizada(_procNF);
                    barra_status.Text = "NFe Autorizada. ";
                    tb_status_nfe.Text = "NFe Autorizada.";
                    string protocolo = _nroProtocolo;
                    try
                    {
                        protocolo = _nroProtocolo.Remove(15);
                    }
                    catch { }
                    tb_protocolo_autorizacao.Text = protocolo;
                    inserir_duplicatas_cr();
                    classe_particularidades part = new classe_particularidades();
                    part.executar_particularidades(tb_n_nf.Text);
                    gbNfe.BackColor = Color.GreenYellow;

                    Atualizar(true);
                    try
                    {
                        imprimir();
                    }
                    finally
                    {
                        enviar_email();
                        Atualizar(true);
                    }
                }
                else
                {
                    MessageBox.Show(_msgResultado, cStat.ToString());
                }
            }
            else
            {
                MessageBox.Show("Essa NF já foi autorizada");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tb_protocolo_autorizacao.Text != "")
            {
                string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
            complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
            cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
            senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

                detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                        out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                        out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                        out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);

                int ambiente = 2;
                if (cbNfe_teste.Checked == false)
                    ambiente = 1;
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgCabec, _msgDados, _msgRetWS, _msgResultado;
                string recibo = tb_recibo.Text;
                string _dhProtocolo = "";
                string _nroProtocolo = "";
                string _retCancNFe = "";
                string _cMsg = ""; string _xMsg = "";
                int resultado;
                int cStat = 0;
                if (tb_sequencial_correcao.Text == "")
                    tb_sequencial_correcao.Text = "1";
                else
                {
                    int seq = Convert.ToInt32(tb_sequencial_correcao.Text);
                    seq++;
                    tb_sequencial_correcao.Text = seq.ToString();
                }

                string _procNF = util2.EnviaCCe2G("SP", ambiente, nomeCertificado, "1.00", out _msgDados, out _msgRetWS, out cStat, out _msgResultado,
                    tb_chave_acesso_nfe.Text, tb_texto_correcao.Text, 0, Convert.ToInt32(tb_sequencial_correcao.Text), DateTime.Now.ToString(), out _nroProtocolo,
                    out _dhProtocolo, proxy, usuario, senha, licenca);
                if (cStat == 135)
                {
                    gerar_xml_corrigida(_procNF);
                    barra_status.Text = "NFe Corrigida. ";
                    Atualizar(true);
                    try
                    {
                        imprimir_corrigida();
                    }
                    finally
                    {
                        enviar_email_corrigida();
                        Atualizar(true);
                    }
                }
                else
                {
                    MessageBox.Show(_msgResultado, cStat.ToString());
                }
            }
            else
            {
                MessageBox.Show("Essa NF não foi autorizada, portanto não pode ser corrigida");
            }
        }

        private void enviar_email_corrigida()
        {
            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
       complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
       cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
       senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa);

            string _caminho_arquivo = "c:\\evolucao_dokinos\\NFE\\CORRIGIDAS\\NFE" + tb_chave_acesso_nfe.Text + " - " + tb_sequencial_correcao.Text + ".xml";
            string _caminho_danfe = "c:\\evolucao_dokinos\\NFE\\CORRIGIDAS\\NFE_CORRIGIDA_" + tb_n_nf.Text + ".pdf";
            //var assunto
            string _assunto = "Correção da NFe nº" + tb_n_nf.Text;
            string _mensagem = "<html xmlns:v='urn:schemas-microsoft-com:vml'" +
"xmlns:o='urn:schemas-microsoft-com:office:office'" +
"xmlns:w='urn:schemas-microsoft-com:office:word'" +
"xmlns='http://www.w3.org/TR/REC-html40'>" +

"<head>" +
"<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>" +
"<meta name=ProgId content=Word.Document>" +
"<meta name=Generator content='Microsoft Word 11'>" +
"<meta name=Originator content='Microsoft Word 11'>" +
"<link rel=File-List href='body_arquivos/filelist.xml'>" +
"<title>Prezado cliente,</title>" +
"</head>" +
"<body lang=PT-BR link=blue vlink=purple style='tab-interval:35.4pt' fontface = 'Arial'> " +
"<div class=Section1> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Prezado cliente,<o:p></o:p></span></p> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Segue anexo a Correção da Nota Fiscal Eletrônica em XML" +
"style='font-family:'Comic Sans MS''>, série 001</span></span><span style='font-family:'Comic Sans MS''> de " + razao_social_empresa +
". </span><br> A Carta de Correção segue em PDF.<br><br><o:p></o:p></span></p>" +
        "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Atenciosamente,<o:p></o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-bidi-font-family:Arial'><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-no-proof:yes'>_________________________<br>" +
"Setor de Faturamento<br>" +
"Tel: " + telefone_empresa + "<br>" +
"e-mail: <a href='mailto:" + email_nfe_empresa + "'>" + email_nfe_empresa + "</a><br>" +
"</div>" +
"</body>" +
"</html>";
            Email novo_email = new Email();
            bool _erro;
            //var smtp, email, senha_email
            novo_email.EnviarEmail(detectar_email(), _assunto, _mensagem, _caminho_arquivo, _caminho_danfe, email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro);

            if (_erro == false)
            {
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
            }
            else
            {
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }
        }

        private void gerar_xml_corrigida(string _procNF)
        {
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\NFE\\CORRIGIDAS\\NFE" + tb_chave_acesso_nfe.Text + " - " + tb_sequencial_correcao.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(_procNF);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            imprimir_corrigida();

        }
        private void imprimir_corrigida()
        {
            if (tb_protocolo_autorizacao.Text == "")
            {
                MessageBox.Show("Não esqueça de Consultar o Status da NFe");
            }

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET NOTA_STRING_NF = '" + numero_nf(9, tb_n_nf.Text) + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            dsImprimir_op imprimir = new dsImprimir_op();
            fbConnection1.Open();
            datEmpresa.Fill(imprimir.EMPRESA);

            datNota_fiscal.Fill(imprimir.NOTA_FISCAL);
            fbConnection1.Close();
            crCorrecao nova_nota = new crCorrecao();
            nova_nota.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(nova_nota);
            imprime.n_nfe_correcao = tb_n_nf.Text;
            imprime.nome_fantasia = nomeFantasia;
            imprime.dataEmissao = tb_data_emissao.Text.Replace("/", "-");
            imprime.correcao = true;
            imprime.Show();
        }
    }
}
        

