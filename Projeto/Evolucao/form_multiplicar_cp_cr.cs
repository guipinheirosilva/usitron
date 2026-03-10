using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_multiplicar_cp_cr : Form
    {
        int n_multiplicar = 0;
        public bool _multiplicar_cp;
        public bool _multiplicar_cr;
        public string _cp_cod, _cp_descricao, _cp_valor, _cp_data_prevista, _cp_data_pgto, _cp_cod_forn, _cp_fornecedor, _cp_plano, _cp_carteira, _cp_nf, _cp_cc;
        public string _cr_cod, _cr_descricao, _cr_valor, _cr_data_prevista, _cr_data_pgto, _cr_cod_cliente, _cr_cliente, _cr_plano, _cr_carteira, _cr_nf, _cr_cc;

        public form_multiplicar_cp_cr()
        {
            InitializeComponent();
        }

        private void form_multiplicar_cp_cr_Load(object sender, EventArgs e)
        {
            if (_multiplicar_cp == true)
            {
                tb_data_prevista_inicial.Text = _cp_data_prevista;
            }
            if (_multiplicar_cr == true)
            {
                tb_data_prevista_inicial.Text = _cr_data_prevista;
            }
        }

        private string buscar_cc(string cod_cc)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM CONTAS_CORRENTES WHERE COD_CC = '" + cod_cc + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                fbConnection1.Close(); 
                DataRow dr = dsSelect.Tables[0].Rows[0];
                return dr[1].ToString();
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return "erro";
            }
        }
        private void multiplicar_cp(int _n, DateTime _data_inicial)
        {
            if (n_multiplicar == 0)
            {
                n_multiplicar = 1;
                if (_cp_descricao == "")
                    _cp_descricao = "null";
                else
                    _cp_descricao = "'" + _cp_descricao + "'";

                if (_cp_valor == "")
                    _cp_valor = "null";
                else
                    _cp_valor = "'" + _cp_valor + "'";

                if (_cp_data_pgto == "")
                    _cp_data_pgto = "null";
                else
                    _cp_data_pgto = "'" + _cp_data_pgto + "'";

                if (_cp_cod_forn == "")
                    _cp_cod_forn = "null";
                else
                    _cp_cod_forn = "'" + _cp_cod_forn + "'";

                if (_cp_fornecedor == "")
                    _cp_fornecedor = "null";
                else
                    _cp_fornecedor = "'" + _cp_fornecedor + "'";

                if (_cp_plano == "")
                    _cp_plano = "null";
                else
                    _cp_plano = "'" + _cp_plano + "'";

                if (_cp_carteira == "")
                    _cp_carteira = "null";
                else
                    _cp_carteira = "'" + _cp_carteira + "'";

                if (_cp_nf == "")
                    _cp_nf = "null";
                else
                    _cp_nf = "'" + _cp_nf + "'";

                string _descricao_cc = "null";
                if (_cp_cc == "")
                    _cp_cc = "null";
                else
                {
                    _descricao_cc = "'" + buscar_cc(_cp_cc) + "'";
                    _cp_cc = "'" + _cp_cc + "'";
                }


                string pessoa = "", cod_plano = "", plano = "", status = "";
                buscar_dados_cp(_cp_cod, out pessoa, out cod_plano, out plano, out status);
                if (cod_plano == "")
                    cod_plano = "null";
                


                int dia = Convert.ToInt16(tb_dia.Text);
                int mes = _data_inicial.Month;
                int ano = _data_inicial.Year;


                int n_parcela = 0;
                try
                {
                    n_parcela = Convert.ToInt32(tb_parcela_inicial.Text);
                }
                catch { }
                int parcela_final = 0;
                try
                {
                    parcela_final = Convert.ToInt32(tb_parcela_final.Text);
                }
                catch { }

                for (int i = 0; i < _n; i++)
                {
                    int n_item = i + 2;
                    int n_de_itens = _n + 1;
                    string _dia = dia.ToString();
                    try
                    {
                        try //tratar quando o dia não se encaixa no mês
                        {
                            DateTime _data = new DateTime();
                            _data = Convert.ToDateTime(_dia + "/" + mes.ToString() + "/" + ano.ToString());

                        }
                        catch 
                        { 
                            bool erro = true;
                            int dia2 = dia--;
                            while (erro)
                            {
                                _dia = dia2.ToString();
                                try
                                {
                                    DateTime _data = new DateTime();
                                    _data = Convert.ToDateTime(_dia + "/" + mes.ToString() + "/" + ano.ToString());
                                    erro = false;
                                }
                                catch {
                                    dia2--;
                                }
                            }
                        }
                        
                        //fazer o insert com um try que resolva quando o dia não tiver no mês Ex.: 30/02/2010
                        this.datContas_a_pagar.InsertCommand.CommandText =
                            "INSERT INTO CONTAS_A_PAGAR (VALOR_CP, DATA_PREVISTA_CP, COD_FORNECEDOR_CP, RAZAO_FORNECEDOR_CP, " +
                            "DESCRICAO_CP, PLANO_CP, CARTEIRA_CP, NF_CP, DUPLICATA_CP, CC_CP, DESCRICAO_CC_CP, PESSOA_CP, COD_PLANO_CP, STATUS_CP)" +
                            "VALUES (" + _cp_valor.Replace(".", "").Replace(",", ".") + ",'" + _dia + "." + mes.ToString() + "." + ano + "'," + _cp_cod_forn + "," + _cp_fornecedor + "," +
                            _cp_descricao + ",'" + plano + "'," + _cp_carteira + "," + _cp_nf + ",'" + n_parcela.ToString() + "/" + parcela_final.ToString() + "'," + _cp_cc + "," + _descricao_cc + 
                            ",'" + pessoa + "'," + cod_plano + ",'" + status + "')";
                        this.fbConnection1.Open();
                        this.datContas_a_pagar.InsertCommand.Connection = fbConnection1;
                        this.datContas_a_pagar.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        mes = mes + 1;
                        if (mes > 12)
                        {
                            mes = 1;
                            ano = ano + 1;
                        }
                        n_parcela++;
                    }
                    catch(Exception a)
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show(a.ToString());
                        /*
                        fbConnection1.Close(); 
                        if (mes == 2)
                            dia = 28;
                        else
                        {
                            dia = dia - 1;
                        }
                        try
                        {
                            "INSERT INTO CONTAS_A_PAGAR (VALOR_CP, DATA_PREVISTA_CP, COD_FORNECEDOR_CP, RAZAO_FORNECEDOR_CP, " +
                            "DESCRICAO_CP, PLANO_CP, CARTEIRA_CP, NF_CP, DUPLICATA_CP, CC_CP, DESCRICAO_CC_CP)" +
                            "VALUES (" + _cp_valor.Replace(".", "").Replace(",", ".") + ",'" + dia.ToString() + "." + mes.ToString() + "." + ano + "'," + _cp_cod_forn + "," + _cp_fornecedor + "," +
                            _cp_descricao + "," + _cp_plano + "," + _cp_carteira + "," + _cp_nf + ",'" + n_item.ToString() + "/" + n_de_itens.ToString() + "'," + _cp_cc + "," + _descricao_cc + ")";
                            this.fbConnection1.Open();
                            this.datContas_a_pagar.InsertCommand.Connection = fbConnection1;
                            this.datContas_a_pagar.InsertCommand.ExecuteNonQuery();
                            this.fbConnection1.Close(); 
                        }
                        catch
                        {
                            fbConnection1.Close(); 
                        }
                        dia = Convert.ToInt16(tb_dia.Text);
                        mes = mes + 1;
                        if (mes > 12)
                        {
                            mes = 1;
                            ano = ano + 1;
                        }
                        */
                    }
                }
                try
                {
                    if (_cp_descricao == "null")
                        _cp_descricao = "is null";
                    else
                        _cp_descricao = " = " + _cp_descricao + "";

                    if (_cp_valor == "null")
                        _cp_valor = "is null";
                    else
                        _cp_valor = " = " + _cp_valor + "";

                    if (_cp_data_pgto == "null")
                        _cp_data_pgto = "is null";
                    else
                        _cp_data_pgto = " = " + _cp_data_pgto + "";

                    if (_cp_cod_forn == "null")
                        _cp_cod_forn = "is null";
                    else
                        _cp_cod_forn = " = " + _cp_cod_forn + "";

                    if (_cp_fornecedor == "null")
                        _cp_fornecedor = " is null";
                    else
                        _cp_fornecedor = " = " + _cp_fornecedor + "";

                    if (_cp_plano == "null")
                        _cp_plano = " is null";
                    else
                        _cp_plano = " = " + _cp_plano + "";

                    if (_cp_carteira == "null")
                        _cp_carteira = "is null";
                    else
                        _cp_carteira = " = " + _cp_carteira + "";
                    this.datContas_a_pagar.SelectCommand.CommandText =
                                "SELECT * FROM CONTAS_A_PAGAR WHERE VALOR_CP " + _cp_valor.Replace(".", "").Replace(",", ".") + " AND COD_FORNECEDOR_CP " + _cp_cod_forn + " AND RAZAO_FORNECEDOR_CP " + _cp_fornecedor +
                         //       " AND DESCRICAO_CP " + _cp_descricao + " AND PLANO_CP " + _cp_plano + " AND CARTEIRA_CP " + _cp_carteira + " ORDER BY DATA_PREVISTA_CP";
                           " and NF_CP = " + _cp_nf + " ORDER BY DATA_PREVISTA_CP";
                    this.fbConnection1.Open();
                    this.datContas_a_pagar.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_pagar.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    datContas_a_pagar.Fill(CONTAS_A_PAGAR);
                }
                catch
                {
                    fbConnection1.Close(); 
                }
            }
            else
            {
                MessageBox.Show("Por favor, volte ao Contas a Pagar e Receber para repetir o procedimento");
            }
            
             
        }

private void buscar_dados_cp(string _cp_cod, out string pessoa, out string cod_plano, out string plano, out string status)
{
    pessoa = ""; cod_plano = ""; plano = ""; status = "";
    try
    {
        FbCommand select = new FbCommand();
        select.Connection = fbConnection1;
        select.CommandText = "SELECT PESSOA_CP, COD_PLANO_CP, PLANO_CP, STATUS_CP FROM CONTAS_A_PAGAR WHERE COD_CP = '" + _cp_cod + "'";
        fbConnection1.Open();
        FbDataAdapter datSelect = new FbDataAdapter();
        datSelect.SelectCommand = select;
        DataTable dtSelect = new DataTable();
        datSelect.Fill(dtSelect);
        fbConnection1.Close();
        foreach (DataRow dr in dtSelect.Rows)
        {
            pessoa =  dr["PESSOA_CP"].ToString();
            cod_plano = dr["COD_PLANO_CP"].ToString();
            plano = dr["PLANO_CP"].ToString();
            status = dr["STATUS_CP"].ToString();
        }
    }
    catch(Exception ex)
    {
        fbConnection1.Close();
        MessageBox.Show(ex.Message);

    }
}
private void buscar_dados_cr(string _cr_cod, out string pessoa, out string status)
{
    pessoa = ""; status = "";
    try
    {
        FbCommand select = new FbCommand();
        select.Connection = fbConnection1;
        select.CommandText = "SELECT PESSOA_CR, STATUS_CR FROM CONTAS_A_RECEBER WHERE COD_CR = '" + _cr_cod + "'";
        fbConnection1.Open();
        FbDataAdapter datSelect = new FbDataAdapter();
        datSelect.SelectCommand = select;
        DataTable dtSelect = new DataTable();
        datSelect.Fill(dtSelect);
        fbConnection1.Close();
        foreach (DataRow dr in dtSelect.Rows)
        {
            pessoa = dr["PESSOA_CR"].ToString();
            status = dr["STATUS_CR"].ToString();
        }
    }
    catch
    {
        fbConnection1.Close();
    }
}
        

        private void multiplicar_cr(int _n, DateTime _data_inicial)
        {
            if (n_multiplicar == 0)
            {
                n_multiplicar = 1;
                if (_cr_descricao == "")
                    _cr_descricao = "null";
                else
                    _cr_descricao = "'" + _cr_descricao + "'";

                if (_cr_valor == "")
                    _cr_valor = "null";
                else
                    _cr_valor = "'" + _cr_valor + "'";

                if (_cr_data_pgto == "")
                    _cr_data_pgto = "null";
                else
                    _cr_data_pgto = "'" + _cr_data_pgto + "'";

                if (_cr_cod_cliente == "")
                    _cr_cod_cliente = "null";
                else
                    _cr_cod_cliente = "'" + _cr_cod_cliente + "'";

                if (_cr_cliente == "")
                    _cr_cliente = "null";
                else
                    _cr_cliente = "'" + _cr_cliente + "'";

                if (_cr_plano == "")
                    _cr_plano = "null";
                else
                    _cr_plano = "'" + _cr_plano + "'";

                if (_cr_carteira == "")
                    _cr_carteira = "null";
                else
                    _cr_carteira = "'" + _cr_carteira + "'";
                if (_cr_nf == "")
                    _cr_nf = "null";
                else
                    _cr_nf = "'" + _cr_nf + "'";
                string _descricao_cc = "null";
                if (_cr_cc == "")
                    _cr_cc = "null";
                else
                {
                    _descricao_cc = "'" + buscar_cc(_cr_cc) + "'";
                    _cr_cc = "'" + _cr_cc + "'";
                }

                string pessoa = ""; string status = "";
                buscar_dados_cr(_cr_cod, out pessoa, out status);

                int dia = Convert.ToInt16(tb_dia.Text);
                int mes = _data_inicial.Month;
                int ano = _data_inicial.Year;
                string _dia = dia.ToString();

                int n_parcela = 0;
                try
                {
                    n_parcela = Convert.ToInt32(tb_parcela_inicial.Text);
                }
                catch { }
                int parcela_final = 0;
                try
                {
                    parcela_final = Convert.ToInt32(tb_parcela_final.Text);
                }
                catch { }

                for (int i = 0; i < _n; i++)
                {
                    int n_item = i + 2;
                    int n_de_itens = _n + 1;
                    try
                    {
                        try //tratar quando o dia não se encaixa no mês
                        {
                            DateTime _data = new DateTime();
                            _data = Convert.ToDateTime(_dia + "/" + mes.ToString() + "/" + ano.ToString());

                        }
                        catch
                        {
                            bool erro = true;
                            int dia2 = dia--;
                            while (erro)
                            {
                                _dia = dia2.ToString();
                                try
                                {
                                    DateTime _data = new DateTime();
                                    _data = Convert.ToDateTime(_dia + "/" + mes.ToString() + "/" + ano.ToString());
                                    erro = false;
                                }
                                catch
                                {
                                    dia2--;
                                }
                            }
                        }

                      
                        //fazer o insert com um try que resolva quando o dia não tiver no mês Ex.: 30/02/2010
                        this.datContas_a_receber.InsertCommand.CommandText =
                            "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, RAZAO_CLIENTE_CR, " +
                            "DESCRICAO_CR, PLANO_CR, CARTEIRA_CR, NF_CR, DUPLICATA_CR, CC_CR, DESCRICAO_CC_CR, PESSOA_CR, STATUS_CR) " +
                            "VALUES (" + _cr_valor.Replace(".", "").Replace(",", ".") + ",'" + _dia + "." + mes.ToString() + "." + ano + "'," + _cr_cod_cliente + "," + _cr_cliente + "," +
                            _cr_descricao + "," + _cr_plano + "," + _cr_carteira + "," + _cr_nf + ",'" + n_parcela.ToString() + "/" + parcela_final.ToString() + "'," + _cr_cc + "," + 
                            _descricao_cc + ",'" + pessoa + "','" + status + "')";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.InsertCommand.Connection = fbConnection1;
                        this.datContas_a_receber.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        mes = mes + 1;
                        if (mes > 12)
                        {
                            mes = 1;
                            ano = ano + 1;
                        }
                        n_parcela++;
                    }
                    catch(Exception a)
                    {

                        fbConnection1.Close(); 
                        MessageBox.Show(a.ToString());
                        /*
                        if (mes == 2)
                            dia = 28;
                        else
                        {
                            dia = dia - 1;
                        }
                        this.datContas_a_receber.InsertCommand.CommandText =
                        this.datContas_a_receber.InsertCommand.CommandText =
                            "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, RAZAO_CLIENTE_CR, " +
                            "DESCRICAO_CR, PLANO_CR, CARTEIRA_CR, NF_CR, DUPLICATA_CR, CC_CR, DESCRICAO_CC_CR)" +
                            "VALUES (" + _cr_valor.Replace(".", "").Replace(",", ".") + ",'" + dia.ToString() + "." + mes.ToString() + "." + ano + "'," + _cr_cod_cliente + "," + _cr_cliente + "," +
                            _cr_descricao + "," + _cr_plano + "," + _cr_carteira + "," + _cr_nf + ",'" + n_item.ToString() + "/" + n_de_itens.ToString() + "'," + _cr_cc + "," + _descricao_cc + ")";
                        this.fbConnection1.Open();
                        this.datContas_a_receber.InsertCommand.Connection = fbConnection1;
                        this.datContas_a_receber.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        dia = Convert.ToInt16(tb_dia.Text);
                        mes = mes + 1;
                        if (mes > 12)
                        {
                            mes = 1;
                            ano = ano + 1;
                        }
                        */
                    }
                }
                try
                {
                    if (_cr_descricao == "null")
                        _cr_descricao = "is null";
                    else
                        _cr_descricao = " = " + _cr_descricao + "";

                    if (_cr_valor == "null")
                        _cr_valor = "is null";
                    else
                        _cr_valor = " = " + _cr_valor + "";

                    if (_cr_data_pgto == "null")
                        _cr_data_pgto = "is null";
                    else
                        _cr_data_pgto = " = " + _cr_data_pgto + "";

                    if (_cr_cod_cliente == "null")
                        _cr_cod_cliente = "is null";
                    else
                        _cr_cod_cliente = " = " + _cr_cod_cliente + "";

                    if (_cr_cliente == "null")
                        _cr_cliente = " is null";
                    else
                        _cr_cliente = " = " + _cr_cliente + "";

                    if (_cr_plano == "null")
                        _cr_plano = " is null";
                    else
                        _cr_plano = " = " + _cr_plano + "";

                    if (_cr_carteira == "null")
                        _cr_carteira = "is null";
                    else
                        _cr_carteira = " = " + _cr_carteira + "";
                    this.datContas_a_receber.SelectCommand.CommandText =
                            "SELECT * FROM CONTAS_A_RECEBER WHERE VALOR_CR  " + _cr_valor.Replace(".", "").Replace(",", ".") + " AND COD_CLIENTE_CR " + _cr_cod_cliente + " AND RAZAO_CLIENTE_CR " + _cr_cliente +
                            " AND DESCRICAO_CR  " + _cr_descricao + " AND PLANO_CR  " + _cr_plano + " AND CARTEIRA_CR  " + _cr_carteira + " ORDER BY DATA_PREVISTA_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.SelectCommand.Connection = fbConnection1;
                    this.datContas_a_receber.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                    datContas_a_receber.Fill(CONTAS_A_RECEBER);
                }
                catch
                {
                    fbConnection1.Close(); 
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, volte ao Contas a Pagar e Receber para repetir o procedimento");
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(tb_n.Text);
                DateTime data_inicial = new DateTime();
                int dia = Convert.ToInt16(tb_dia.Text);
                if (_multiplicar_cr == true)
                {
                    try
                    {
                        data_inicial = Convert.ToDateTime(tb_data_prevista_inicial.Text);
                        data_inicial = data_inicial.AddMonths(1);
                        data_inicial = Convert.ToDateTime(dia + "/" + data_inicial.Month.ToString() + "/" + data_inicial.Year.ToString());
                        multiplicar_cr(n, data_inicial);
                    }
                    catch
                    {
                        if (data_inicial.Month == 2)
                            dia = 28;
                        else
                        {
                            dia = dia - 1;
                        }
                        data_inicial = Convert.ToDateTime(tb_data_prevista_inicial.Text);
                        data_inicial = data_inicial.AddMonths(1);
                        data_inicial = Convert.ToDateTime(dia + "/" + data_inicial.Month.ToString() + "/" + data_inicial.Year.ToString());
                        multiplicar_cr(n, data_inicial);
                    }
                }
                if (_multiplicar_cp == true)
                {
                    try
                    {
                        data_inicial = Convert.ToDateTime(tb_data_prevista_inicial.Text);
                        data_inicial = data_inicial.AddMonths(1);
                        data_inicial = Convert.ToDateTime(dia + "/" + data_inicial.Month.ToString() + "/" + data_inicial.Year.ToString());
                        multiplicar_cp(n, data_inicial);
                    }
                    catch
                    {
                        if (data_inicial.Month == 2)
                            dia = 28;
                        else
                        {
                            dia = dia - 1;
                        }
                        data_inicial = Convert.ToDateTime(tb_data_prevista_inicial.Text);
                        data_inicial = data_inicial.AddMonths(1);
                        data_inicial = Convert.ToDateTime(dia + "/" + data_inicial.Month.ToString() + "/" + data_inicial.Year.ToString());
                        multiplicar_cp(n, data_inicial);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro, verifique os campos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsContas_a_pagar, "CONTAS_A_PAGAR"].EndCurrentEdit();
            if (dsContas_a_pagar.HasChanges())
            {
                //MessageBox.Show("CHEGOU AQUI");
                fbConnection1.Open();
                datContas_a_pagar.UpdateCommand = cbContas_a_pagar.GetUpdateCommand();
                datContas_a_pagar.InsertCommand = cbContas_a_pagar.GetInsertCommand();
                datContas_a_pagar.DeleteCommand = cbContas_a_pagar.GetDeleteCommand();
                datContas_a_pagar.Update(dsContas_a_pagar, "CONTAS_A_PAGAR");
                dsContas_a_pagar.AcceptChanges();
                fbConnection1.Close(); 
            }
            this.BindingContext[dsContas_a_receber, "CONTAS_A_RECEBER"].EndCurrentEdit();
            if (dsContas_a_receber.HasChanges())
            {
                //MessageBox.Show("CHEGOU AQUI");
                fbConnection1.Open();
                datContas_a_receber.UpdateCommand = cbContas_a_receber.GetUpdateCommand();
                datContas_a_receber.InsertCommand = cbContas_a_receber.GetInsertCommand();
                datContas_a_receber.DeleteCommand = cbContas_a_receber.GetDeleteCommand();
                datContas_a_receber.Update(dsContas_a_receber, "CONTAS_A_RECEBER");
                dsContas_a_receber.AcceptChanges();
                fbConnection1.Close(); 
            }




        }

    }
}