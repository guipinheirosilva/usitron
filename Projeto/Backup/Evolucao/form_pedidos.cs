using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_pedidos : Form
    {
        //variaveis detecta_fatura
        string[] _datas = new string[50];
        string[] _valores = new string[50];
        string[] _cod = new string[50];

        public bool abrir;
        public string cod_a_abrir;
        public form_pedidos()
        {
            InitializeComponent();
        }

        private void tb_descricao_peca_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    form_localiza_produto localiza_item = new form_localiza_produto();
                    try
                    {
                        localiza_item.buscar = true;
                        localiza_item.ShowDialog();
                    }
                    finally
                    {
                        localiza_item.Dispose();
                        if (localiza_item.cod_produto_escolhido == "")
                        { }
                        else
                        {
                            localizar_item(localiza_item.cod_produto_escolhido);
                        }

                    }

                    break;
            }
            
        }

        private void localizar_item(string cod)
        {
            
            try
            {
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod + "'";
                DataSet prod = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close();
                
                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    tb_cod_fornecedor.Text = dr["COD_FORNECEDOR_PRODUTO"].ToString();
                   tb_descricao_produto.Text = dr["DESCRICAO_PRODUTO"].ToString();
                   tb_unid_item.Text = dr["COD_UNIDADE_PRODUTO"].ToString();
                   tb_preco_unit_item.Text = dr["VALOR_VENDA_PRODUTOR_PRODUTO"].ToString();
                   tb_descricao_item.Text = dr["DESCRICAO_ITEM_PRODUTO"].ToString();
                   tb_marca.Text = dr["MARCA_PRODUTO"].ToString();
                   tb_cod_sistema.Text = dr["COD_PRODUTO"].ToString();

                }
            }
            catch
            {

                fbConnection1.Close();
            }
             




        }

        private void form_pedidos_Load(object sender, EventArgs e)
        {
            if (abrir == true)
            {
                localizar_pedido(cod_a_abrir);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string aliq_ipi = "", aliq_icms = "", iva_item = "", perc_red_icms = "", aliq_icms_st = "", st_item = "", cod_item = "", descricao_item = "", unid_item = "", qtde_item = "", valor_unit_item = "",
                valor_total_item = "", valor_bc_icms_item = "", valor_bc_ipi_item = "", valor_icms_item = "", valor_ipi_item = "", cod_vendedor = "";
            try
            {
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + tb_cod_sistema.Text + "'";
                DataSet prod = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close();
                
                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    aliq_ipi = dr["ALIQUOTA_IPI_PRODUTO"].ToString();
                    aliq_icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                    perc_red_icms = dr["REDUCAO_FORA_PRODUTO"].ToString();
                }
            }
            catch
            {

                fbConnection1.Close();
            }

            double _valor_total = 0, _bc_icms = 0, _bc_ipi = 0, _red_bc_icms = 0, _valor_ipi = 0, _valor_icms = 0;
            try
            {
                _valor_total = Convert.ToDouble(tb_preco_unit_item.Text) * Convert.ToDouble(tb_qtde_item.Text);
            }
            catch { }
            //calcular aqui a redução por estado
            _bc_icms = _valor_total;
            _bc_ipi = _valor_total;
            _bc_icms = _valor_total;
            
            try
            {
                _valor_ipi = _bc_ipi * Convert.ToDouble(aliq_ipi);
            }
            catch{}
            try
            {
                _valor_icms = _bc_icms * Convert.ToDouble(aliq_icms);
                
            }
            catch { }



            if (aliq_ipi == "")
                aliq_ipi = "null";
            else
                aliq_ipi = "'" + aliq_ipi.Replace(".", "").Replace(",", ".") + "'";

            if (aliq_icms == "")
                aliq_icms = "null";
            else
                aliq_icms = "'" + aliq_icms.Replace(".", "").Replace(",", ".") + "'";

            cod_item = tb_cod_fornecedor.Text;
            if (cod_item == "")
                cod_item = "null";
            else
                cod_item = "'" + cod_item + "'";

            descricao_item = tb_descricao_produto.Text;
            if (descricao_item == "")
                descricao_item = "null";
            else
                descricao_item = "'" + descricao_item + "'";

            unid_item = tb_unid_item.Text;
            if (unid_item == "")
                unid_item = "null";
            else
                unid_item = "'" + unid_item + "'";

            qtde_item = tb_qtde_item.Text;
            if (qtde_item == "")
              qtde_item= "null";
            else
                qtde_item = "'" + qtde_item.Replace(",",".") + "'";

            cod_vendedor = tb_cod_vendedor.Text;
            if (cod_vendedor == "")
                cod_vendedor = "null";
            else
                cod_vendedor = "'" + cod_vendedor + "'";

            valor_unit_item = tb_preco_unit_item.Text;
            if (valor_unit_item == "")
                valor_unit_item = "null";
            else
                valor_unit_item = "'" + valor_unit_item.Replace(".","").Replace(",", ".") + "'";

            valor_total_item = _valor_total.ToString("n2");
            if (valor_total_item == "")
                valor_total_item = "null";
            else
                valor_total_item = "'" + valor_total_item.Replace(".", "").Replace(",", ".") + "'";

            valor_bc_icms_item = _bc_icms.ToString("n2");
            if (valor_bc_icms_item == "")
                valor_bc_icms_item = "null";
            else
                valor_bc_icms_item = "'" + valor_bc_icms_item.Replace(".", "").Replace(",", ".") + "'";

            valor_bc_ipi_item = _bc_ipi.ToString("n2");
            if (valor_bc_ipi_item == "")
                valor_bc_ipi_item = "null";
            else
                valor_bc_ipi_item = "'" + valor_bc_ipi_item.Replace(".", "").Replace(",", ".") + "'";

            valor_icms_item = _valor_icms.ToString("n2");
            if (valor_icms_item == "")
                valor_icms_item = "null";
            else
                valor_icms_item = "'" + valor_icms_item.Replace(".", "").Replace(",", ".") + "'";

            valor_ipi_item = _valor_ipi.ToString("n2");
            if (valor_ipi_item == "")
                valor_ipi_item = "null";
            else
                valor_ipi_item = "'" + valor_ipi_item.Replace(".", "").Replace(",", ".") + "'";
            string cod_sistema = "null";
            if (tb_cod_sistema.Text != "")
                cod_sistema = "'" + tb_cod_sistema.Text + "'";
            string descricao_item_produto = "null";
            if(tb_descricao_item.Text != "")
                descricao_item_produto = "'" + tb_descricao_item.Text + "'" ;
            string marca = "null";
            if (tb_marca.Text != "")
                marca = "'" + tb_marca.Text + "'";
            string prazo = "null";
            if (tb_prazo.Text != "")
                prazo = "'" + tb_prazo.Text + "'";
            

            try
            {
                this.datItens_ped_venda.InsertCommand.CommandText =
                   "INSERT INTO ITENS_PEDIDO_VENDA (COD_PROD_ITEM_VENDA, DESCRICAO_PROD_ITEM_VENDA, UNIDADE_PROD_ITEM_VENDA, QTDE_ITEM_VENDA, VALOR_UNIT_PROD_ITEM_VENDA, VALOR_TOTAL_PROD_ITEM_VENDA, BC_ICMS_PROD_ITEM_VENDA, ALIQ_ICMS_PROD_ITEM_VENDA, VALOR_ICMS_ITEM_VENDA, " +
                   "BC_IPI_PROD_ITEM_VENDA, ALIQ_IPI_PROD_ITEM_VENDA, VALOR_IPI_ITEM_VENDA, COD_PEDIDO_ITEM_VENDA, COD_VENDEDOR_ITEM_VENDA, DATA_PEDIDO_ITEM_VENDA, COD_SISTEMA_PROD_ITEM_VENDA, DESCRICAO_ITEM_PROD_ITEM_VENDA, MARCA_ITEM_VENDA, PRAZO_ITEM_VENDA) " +
                   "VALUES (" + cod_item + "," + descricao_item + "," + unid_item + "," + qtde_item + "," + valor_unit_item + "," + valor_total_item + "," + valor_bc_icms_item + "," + aliq_icms + "," + valor_icms_item + "," +
                   valor_bc_ipi_item + "," + aliq_ipi + "," + valor_ipi_item + "," + tb_n_pedido.Text + "," + cod_vendedor + ",'" + Convert.ToDateTime(tb_data_pedido.Text).ToShortDateString().Replace("/",".") + "'," + cod_sistema + "," + descricao_item_produto + "," + marca + "," + prazo + ")";
                this.fbConnection1.Open();
                this.datItens_ped_venda.InsertCommand.Connection = fbConnection1;
                this.datItens_ped_venda.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                dsItens_ped_venda.Clear();
                this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + tb_n_pedido.Text + "'";
                this.fbConnection1.Open();
                this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
                this.fbConnection1.Close();

                tb_cod_fornecedor.Text = ""; tb_descricao_produto.Text = ""; tb_descricao_item.Text = "";
                tb_unid_item.Text = ""; tb_qtde_item.Text = ""; tb_preco_unit_item.Text = "";
                tb_marca.Text = ""; tb_prazo.Text = ""; tb_cod_sistema.Text = "";
                calcular();
                tb_cod_sistema.Focus();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro na inserção");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcular();
            
        }
        private void calcular()
        {
            double valor_total = 0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    valor_total = valor_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value) * Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value);

                }
                catch { }

            }
            tb_total_prod.Text = valor_total.ToString("n2");
            double total_desconto = 0;
            try
            {
                total_desconto = valor_total * Convert.ToDouble(tb_porc_desconto.Text)/100;
            }
            catch { }
            tb_valor_desconto.Text = total_desconto.ToString("n2");
            double valor_total_pedido = valor_total - total_desconto;
            tb_total_pedido.Text = valor_total_pedido.ToString("n2");
        }
        

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            calcular();
            salvar();
        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsPedidos_venda, "PEDIDOS_VENDA"].EndCurrentEdit();
                if (dsPedidos_venda.HasChanges())
                {
                    fbConnection1.Open();
                    datPedidos_venda.UpdateCommand = cbPedidos_venda.GetUpdateCommand();
                    datPedidos_venda.InsertCommand = cbPedidos_venda.GetInsertCommand();
                    datPedidos_venda.DeleteCommand = cbPedidos_venda.GetDeleteCommand();
                    datPedidos_venda.Update(dsPedidos_venda, "PEDIDOS_VENDA");
                    dsPedidos_venda.AcceptChanges();
                    fbConnection1.Close();
                }
                this.BindingContext[dsItens_ped_venda, "ITENS_PEDIDO_VENDA"].EndCurrentEdit();
                if (dsItens_ped_venda.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_ped_venda.UpdateCommand = cbItens_ped_venda.GetUpdateCommand();
                    datItens_ped_venda.InsertCommand = cbItens_ped_venda.GetInsertCommand();
                    datItens_ped_venda.DeleteCommand = cbItens_ped_venda.GetDeleteCommand();
                    datItens_ped_venda.Update(dsItens_ped_venda, "ITENS_PEDIDO_VENDA");
                    dsItens_ped_venda.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch
            {
                fbConnection1.Close();
            }

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            criar_item();
        }

        private void criar_item()
        {
           

            try
            {
                this.datPedidos_venda.DeleteCommand.CommandText =
                    "DELETE FROM PEDIDOS_VENDA WHERE CLIENTE_PED_VENDA = 'NOVO'";
                this.fbConnection1.Open();
                this.datPedidos_venda.DeleteCommand.Connection = fbConnection1;
                this.datPedidos_venda.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                
                this.datPedidos_venda.InsertCommand.CommandText =
                    "INSERT INTO PEDIDOS_VENDA (CLIENTE_PED_VENDA)" +
                    "VALUES ('NOVO')";
                this.fbConnection1.Open();
                this.datPedidos_venda.InsertCommand.Connection = fbConnection1;
                this.datPedidos_venda.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();



                dsPedidos_venda.Clear();
                dsItens_ped_venda.Clear();
                this.datPedidos_venda.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDOS_VENDA WHERE CLIENTE_PED_VENDA = 'NOVO'";
                this.fbConnection1.Open();
                this.datPedidos_venda.SelectCommand.Connection = fbConnection1;
                this.datPedidos_venda.SelectCommand.ExecuteNonQuery();
                datPedidos_venda.Fill(PEDIDOS_VENDA);
                this.fbConnection1.Close();

                tb_data_pedido.Text = DateTime.Now.ToShortDateString();

            }


            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private void bt_localizar_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido localiza_item = new form_pesquisa_pedido();
            try
            {
                localiza_item.consulta = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_ped_escolhido == "")
                { }
                else
                {
                    localizar_pedido(localiza_item.cod_ped_escolhido);
                }

            }
        }

        private void localizar_pedido(string cod)
        {
            try
            {
                dsPedidos_venda.Clear();
                dsItens_ped_venda.Clear();
                this.datPedidos_venda.SelectCommand.CommandText =
                "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datPedidos_venda.SelectCommand.Connection = fbConnection1;
                this.datPedidos_venda.SelectCommand.ExecuteNonQuery();
                datPedidos_venda.Fill(PEDIDOS_VENDA);
                this.fbConnection1.Close();

                this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
                this.fbConnection1.Close();

            }
            catch {
                fbConnection1.Close();
            }




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
                form_busca_contato cont = new form_busca_contato();
                try
                {
                    cont.cod_cli_forn = localiza_cliente.cod_escolhido;
                    cont.cli_forn = "CLIENTE";
                    cont.ShowDialog();
                }
                finally
                {
                    contatotextBox.Text = cont.valores[0, 1];
                    emailtextBox.Text = cont.valores[0, 0];
                    teltextBox.Text = cont.valores[0, 2];
                }
                //tb_dados_adicionais.Text = "#C.FISC.: " + tb_class_fiscal.Text + "#" + tb_dados_adicionais.Text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (cb_baixado_est.Checked == false)
            {
                baixar_do_estoque();
                //inserir_duplicatas_cr();
            }
            */
            imprimir();
        }
        private void apagar_itens_cr()
        {
            this.datContas_a_receber.DeleteCommand.CommandText =
            "DELETE FROM CONTAS_A_RECEBER WHERE NF_CR = '" + tb_n_pedido.Text + "'";
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
                    "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. AO PEDIDO Nº " + tb_n_pedido.Text +
                    "', '" + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + "','" + tb_n_pedido.Text + "')";
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

        private string detectar_cod_cliente(string _cnpj)
        {
            string _cod = "";
            comando_select.CommandText = "SELECT * " +
                "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
            DataSet nf = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            datClientes.Fill(nf);
            int n = 0;
            foreach (DataRow dr in nf.Tables[0].Rows)
            {

                _cod = dr["COD_CLIENTE"].ToString();

            }
            fbConnection1.Close();
            return _cod;

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
                    numero = Convert.ToDouble(numero).ToString("n2");
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

        private void detectar_numero_vencimentos_fatura(out int n_venc)
        {
            try
            {
                comando_select.CommandText = "SELECT * " +
                    "FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_pedido.Text + "' AND NF_OU_PEDIDO_FATURA = 'PEDIDO'";
                DataSet fatura = new DataSet();
                fbConnection1.Open();
                datFatura_nf.SelectCommand = comando_select;
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

        private void acertar_imp_duplicatas()
        {
            try
            {
                string valor_total = transforma_decimal(2, tb_total_pedido.Text, 15);
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
            catch
            {
                MessageBox.Show("Erro na inserção das duplicatas");
                fbConnection1.Close();
            }
        }
        private void imprimir()
        {
            try
            {
                localizar_pedido(tb_n_pedido.Text);
                
                acertar_imp_duplicatas();
                dsPedidos imprimir = new dsPedidos();
                fbConnection1.Open();
                
                datPedidos_venda.Fill(imprimir.PEDIDOS_VENDA);
                
                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
                //this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                //datClientes.Fill(CLIENTES);
                //this.fbConnection1.Close();
                datClientes.Fill(imprimir.CLIENTES);
                datImp_duplicatas.Fill(imprimir.IMP_DUPLICATAS);
                datItens_ped_venda.Fill(imprimir.ITENS_PEDIDO_VENDA);
                fbConnection1.Close();
                crPedido_venda novo_ped = new crPedido_venda();
                novo_ped.SetDataSource(imprimir);
                form_imprimir imprime = new form_imprimir(novo_ped);
                imprime.orcamento = true;
                imprime.n_orcamento = tb_n_pedido.Text;
                imprime.Show();
            }
            catch
            {
                fbConnection1.Close();
            }
        }
        //CONTAS A RECEBER ATRAVÉS DO PEDIDO
        /*
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
        */
        private void baixar_do_estoque()
        {
            bool erro = false;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    this.datProdutos.UpdateCommand.CommandText =
                    "UPDATE PRODUTOS SET ESTOQUE_ATUAL_PRODUTO = (ESTOQUE_ATUAL_PRODUTO - " + dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString() + ") WHERE COD_PRODUTO = '" + dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString() + "'";
                    this.fbConnection1.Open();
                    this.datProdutos.UpdateCommand.Connection = fbConnection1;
                    this.datProdutos.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                    erro = true;
                    MessageBox.Show("Erro");
                }

            }
            if (erro == false)
            {
                cb_baixado_est.Checked = true;
                salvar();                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA";
            this.fbConnection1.Open();
            this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
            this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
            datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
            this.fbConnection1.Close();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Tem certeza que deseja excluir o pedido?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    //Excluir itens do pedido de venda---------------------------------------------------//
                    datItens_ped_venda.DeleteCommand.CommandText =
                    "DELETE FROM itens_pedido_venda WHERE cod_pedido_item_venda = " + tb_n_pedido.Text;
                    datItens_ped_venda.DeleteCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datItens_ped_venda.DeleteCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    dsItens_ped_venda.Clear();
                    //-----------------------------------------------------------------------------------//

                    //Excluir o pedido de venda----------------------------------------------------------//
                    datPedidos_venda.DeleteCommand.CommandText =
                        "DELETE FROM pedidos_venda WHERE cod_ped_venda = " + tb_n_pedido.Text;
                    datPedidos_venda.DeleteCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datPedidos_venda.DeleteCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    dsPedidos_venda.Clear();
                    //-----------------------------------------------------------------------------------//
                    
                    MessageBox.Show("Pedido excluído com sucesso!");
                }
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Não foi possível excluir o pedido de venda!\nErro: " + a.Message);
            }
        }

        private void apaga_faturas_anteriores()
        {
            try
            {
                this.datFatura_nf.DeleteCommand.CommandText =
                        "DELETE FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_pedido.Text + "' AND NF_OU_PEDIDO_FATURA = 'PEDIDO'";
                this.fbConnection1.Open();
                this.datFatura_nf.DeleteCommand.Connection = fbConnection1;
                this.datFatura_nf.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao apagar faturas");
            }
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
            double valor = Convert.ToDouble(tb_total_pedido.Text) / numero_parcelas;

            switch (numero_parcelas)
            {

                case 1:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }

                case 2:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 3:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 4:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 5:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 6:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_6);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }



            }
        }

        private void insere_fatura(string prazo, string data, string valor, string nf)
        {
            try
            {
                this.datFatura_nf.InsertCommand.CommandText =
                        "INSERT INTO FATURA_NF (PRAZO_FATURA, DATA_VENC_FATURA, VALOR_FATURA, NF_FATURA, NF_OU_PEDIDO_FATURA)" +
                        "VALUES ('" + prazo + "','" + data + "','" + valor + "','" + nf + "','PEDIDO')";
                this.fbConnection1.Open();
                this.datFatura_nf.InsertCommand.Connection = fbConnection1;
                this.datFatura_nf.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("erro na inserção da fatura");
            }


        }

        private void tb_forma_pgto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tb_total_pedido.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Você quer inserir uma nova forma de pagamento?",
               "Confirmação?", MessageBoxButtons.YesNo))
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
                        tb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
                        apaga_faturas_anteriores();
                        acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                        localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6);
                    }
                }
                form_fatura fatura = new form_fatura();
                try
                {

                    fatura.nf = tb_n_pedido.Text;
                    fatura.ShowDialog();
                }
                finally { }
            }
            else
                MessageBox.Show("Calcule o valor do Pedido antes de inserir a forma de pagamento.");
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cb_baixado_est.Checked == true)
            {
                voltar_para_estoque();
            }

        }

        private void voltar_para_estoque()
        { }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cbRecebido.Checked == false)
            {
                inserir_duplicatas_cr();
            }
            else
            {
                MessageBox.Show("Pedido já foi pago");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            enviar_email();
        }
            private void enviar_email()
        {
            string _caminho_arquivo = "c:\\evolucao_dokinos\\ORCAMENTOS\\" + "ORCAMENTO_" + tb_n_pedido.Text + ".pdf";
            string _assunto = "Novo Orçamento: " + tb_n_pedido.Text;
            string _mensagem = "Segue anexo Orçamento sob n.º " + tb_n_pedido.Text + " emitido em " + Convert.ToDateTime(tb_data_pedido.Text).ToShortDateString();
            Email_orcamento novo_email = new Email_orcamento();
            bool _erro;
            novo_email.EnviarEmail(emailtextBox.Text, _assunto, _mensagem, _caminho_arquivo, out _erro);
            if (_erro == false)
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
                inserir_historico_email(emailtextBox.Text, _caminho_arquivo, _assunto);
            }
            else
            {
                if (barra_status.Text == "Status Atual")
                    barra_status.Text = "";
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }
        }

        private string detectar_email()
        {
            comando_select.CommandText = "SELECT EMAIL " +
                "FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
            DataSet cliente = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            datClientes.Fill(cliente);
            string cliente_atual = "";
            foreach (DataRow dr in cliente.Tables[0].Rows)
            {

                cliente_atual = dr["EMAIL"].ToString();
            }

            this.fbConnection1.Close();
            return cliente_atual;

        }
        private void inserir_historico_email(string destinatario, string caminho, string tipo)
        {
            try
            {
                this.datEmails_enviados.InsertCommand.CommandText =
                           "INSERT INTO EMAILS_ENVIADOS (DESTINATARIO_EMAIL_ENVIADO, DATA_EMAIL_ENVIADO, TIPO_EMAIL_ENVIADO, HORA_EMAIL_ENVIADO, CAMINHO_ARQUIVO_EMAIL_ENVIADO)" +
                           "VALUES ('" + destinatario + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + tipo + "','" + DateTime.Now.ToShortTimeString() + "','" + caminho + "')";
                this.fbConnection1.Open();
                this.datEmails_enviados.InsertCommand.Connection = fbConnection1;
                this.datEmails_enviados.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro na inserção do histórico de emails enviados");
                fbConnection1.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void tb_cod_sistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_cod_sistema.Text == "")
                { }
                else
                {
                    localizar_item(tb_cod_sistema.Text);
                    tb_qtde_item.Focus();
                }
            }
        }

        

        




    }
}