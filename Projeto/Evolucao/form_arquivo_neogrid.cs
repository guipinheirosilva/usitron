using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_arquivo_neogrid : Form
    {

        public form_arquivo_neogrid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classe_envio_arquivos_neogrid gera_arqs = new classe_envio_arquivos_neogrid(dtInicio.Text, dtTermino.Text);
            gera_arqs.gerar_clientes();
            gera_arqs.gerar_estoque();
            gera_arqs.gerar_produtos();
            gera_arqs.gerar_vendas();
            gera_arqs.gerar_vendedores();
            gera_arqs.gerar_csv_vendas();
            gera_arqs.gerar_csv_estoque();
           
            MessageBox.Show("Arquivos gerados");

        }

        private void gerar_csv_estoque()
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\NEOGRID\CSV_ESTOQUE_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\NEOGRID\RELVEN_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                { //13324184000197
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                     "select DISTINCT(prod.*) from PRODUTOS prod " +
                     //   "where prod.nome_fornecedor_produto like '%VIGOR%' AND prod.STATUS_PRODUTO = '1' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                     "where prod.nome_fornecedor_produto like '%VIGOR%' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        string qtde = "0.00";
                        try
                        {
                            double _qtde = 0;
                            try
                            {
                                _qtde = Convert.ToDouble(dr["ESTOQUE_ATUAL_PRODUTO"].ToString());
                                if (_qtde < 0)
                                    _qtde = 0;
                            }
                            catch { }
                            qtde = _qtde.ToString("n2");
                        }
                        catch { }
                        texto.WriteLine(dr["COD_PRODUTO"].ToString() + ";" + dr["COD_BARRAS_PRODUTO"].ToString() + ";" + dr["DESCRICAO_PRODUTO"].ToString() + ";" +
                            qtde);
                    }
                }
            }

        }

        private void gerar_csv_vendas()
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\NEOGRID\CSV_VENDAS_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".csv";
            //string caminhoAnsi = @"c:\\evolucao\\NEOGRID\RELVEN_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                { //13324184000197
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                    "	  select prod.cod_produto, prod.cod_barras_produto, prod.descricao_produto, 	" +
                        /*QTDE VENDAS */
"	 (select sum(infe1.qtde_item)	" +
"	  from itens_nota infe1	" +
"	inner join nota_fiscal nf1 on infe1.nf_item = nf1.n_nf	" +
"	inner join cfo cfo1 on cfo1.n_cfo = infe1.cfop_item	" +
"	inner join PEDIDOS_NF pnf1 on pnf1.NF_PEDIDO_NF = nf1.N_NF	" +
"	inner join PEDIDOS_VENDA  pv1 ON pnf1.N_PEDIDO_NF = pv1.COD_PED_VENDA	" +
"	inner join  produtos prod1 on infe1.cod_item = prod1.cod_produto	" +
"	where prod1.nome_fornecedor_produto like '%VIGOR%'	" +
"	and nf1.status_nfe like '%Autorizada%' and nf1.n_protocolo_autorizacao_nf is not null " +
"	and (infe1.cfop_item = '5102'	" +
"	or infe1.cfop_item = '5405')	" +
 " and nf1.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
 "and nf1.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
"	and prod1.cod_produto = prod.cod_produto	" +
"	) as QTDE_VENDAS,	" +
                        /* VALOR VENDAS */
"	(select sum(infe2.preco_total_item)	" +
"	  from itens_nota infe2	" +
"	inner join nota_fiscal nf2 on infe2.nf_item = nf2.n_nf	" +
"	inner join cfo cfo2 on cfo2.n_cfo = infe2.cfop_item	" +
"	inner join PEDIDOS_NF pnf2 on pnf2.NF_PEDIDO_NF = nf2.N_NF	" +
"	inner join PEDIDOS_VENDA  pv2 ON pnf2.N_PEDIDO_NF = pv2.COD_PED_VENDA	" +
"	inner join  produtos prod2 on infe2.cod_item = prod2.cod_produto	" +
"	where prod2.nome_fornecedor_produto like '%VIGOR%'	" +
"	and nf2.status_nfe like '%Autorizada%' 	 and nf2.n_protocolo_autorizacao_nf is not null " +
"	and (infe2.cfop_item = '5102'	" +
"	or infe2.cfop_item = '5405')	" +
 " and nf2.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
 "and nf2.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
"	and prod2.cod_produto = prod.cod_produto	" +
"	) as VALOR_VENDAS,	" +
                        /* QTDE CANCELADA E DEVOLVIDA */
"	(select sum(infe3.qtde_item)	" +
"	  from itens_nota infe3	" +
"	inner join nota_fiscal nf3 on infe3.nf_item = nf3.n_nf	" +
"	inner join cfo cfo3 on cfo3.n_cfo = infe3.cfop_item	" +
"	inner join PEDIDOS_NF pnf3 on pnf3.NF_PEDIDO_NF = nf3.N_NF	" +
"	inner join PEDIDOS_VENDA  pv3 ON pnf3.N_PEDIDO_NF = pv3.COD_PED_VENDA	" +
"	inner join  produtos prod3 on infe3.cod_item = prod3.cod_produto	" +
"	where prod3.nome_fornecedor_produto like '%VIGOR%'	 and nf3.n_protocolo_autorizacao_nf is not null " +
"	and ((nf3.status_nfe like '%Autorizada%'	" +
"	and (infe3.cfop_item = '5202')) or	" +
"	(nf3.status_nfe like '%Cancelada%'	" +
"	and (infe3.cfop_item = '5102'	" +
"	or infe3.cfop_item = '5405')))	" +
 " and nf3.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
 "and nf3.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
"	and prod3.cod_produto = prod.cod_produto	" +
"	) as QTDE_DEVOLVIDA_CANCELADA,	" +
                        /* VALOR CANCELA OU DEVOLUCAO */
"	(select sum(infe4.preco_total_item)	" +
"	  from itens_nota infe4	" +
"	inner join nota_fiscal nf4 on infe4.nf_item = nf4.n_nf	" +
"	inner join cfo cfo4 on cfo4.n_cfo = infe4.cfop_item	" +
"	inner join PEDIDOS_NF pnf4 on pnf4.NF_PEDIDO_NF = nf4.N_NF	" +
"	inner join PEDIDOS_VENDA  pv4 ON pnf4.N_PEDIDO_NF = pv4.COD_PED_VENDA	" +
"	inner join  produtos prod4 on infe4.cod_item = prod4.cod_produto	" +
"	where prod4.nome_fornecedor_produto like '%VIGOR%' and nf4.n_protocolo_autorizacao_nf is not null " +
"	and ((nf4.status_nfe like '%Autorizada%'	" +
"	and (infe4.cfop_item = '5202')) or	" +
"	(nf4.status_nfe like '%Cancelada%'	" +
"	and (infe4.cfop_item = '5102'	" +
"	or infe4.cfop_item = '5405')))	" +
 " and nf4.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
 "and nf4.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
"	and prod4.cod_produto = prod.cod_produto	" +
"	) as VALOR_DEVOLVIDA_CANCELADA,	" +
                        /* QTDE BONIFICACAO */
"	 (select sum(infe5.qtde_item)	" +
"	  from itens_nota infe5	" +
"	inner join nota_fiscal nf5 on infe5.nf_item = nf5.n_nf	" +
"	inner join cfo cfo5 on cfo5.n_cfo = infe5.cfop_item	" +
"	inner join PEDIDOS_NF pnf5 on pnf5.NF_PEDIDO_NF = nf5.N_NF	" +
"	inner join PEDIDOS_VENDA  pv5 ON pnf5.N_PEDIDO_NF = pv5.COD_PED_VENDA	" +
"	inner join  produtos prod5 on infe5.cod_item = prod5.cod_produto	" +
"	where prod5.nome_fornecedor_produto like '%VIGOR%'	" +
"	and nf5.status_nfe like '%Autorizada%' and nf5.n_protocolo_autorizacao_nf is not null 	" +
"	and (infe5.cfop_item = '5910'	" +
"	or infe5.cfop_item = '6910')	" +
 " and nf5.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
 "and nf5.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
                    "	and prod5.cod_produto = prod.cod_produto	" +
"	) as QTDE_BONIFICACOES,	" +
                        /* VALOR BONIFICACOES*/
"	(select sum(infe6.preco_total_item)	" +
"	  from itens_nota infe6	" +
"	inner join nota_fiscal nf6 on infe6.nf_item = nf6.n_nf	" +
"	inner join cfo cfo6 on cfo6.n_cfo = infe6.cfop_item	" +
"	inner join PEDIDOS_NF pnf6 on pnf6.NF_PEDIDO_NF = nf6.N_NF	" +
"	inner join PEDIDOS_VENDA  pv6 ON pnf6.N_PEDIDO_NF = pv6.COD_PED_VENDA	" +
"	inner join  produtos prod6 on infe6.cod_item = prod6.cod_produto	" +
"	where prod6.nome_fornecedor_produto like '%VIGOR%'	" +
"	and nf6.status_nfe like '%Autorizada%' and nf6.n_protocolo_autorizacao_nf is not null " +
"	and (infe6.cfop_item = '5910'	" +
"	or infe6.cfop_item = '6910')	" +
 " and nf6.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
 "and nf6.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' " +
"	and prod6.cod_produto = prod.cod_produto	" +
"	) as VALOR_BONIFICACOES	" +
"	  from itens_nota infe	" +
"	inner join nota_fiscal nf on infe.nf_item = nf.n_nf	" +
"	inner join cfo on cfo.n_cfo = infe.cfop_item	" +
"	inner join PEDIDOS_NF pnf on pnf.NF_PEDIDO_NF = nf.N_NF  	" +
"	inner join PEDIDOS_VENDA  pv ON pnf.N_PEDIDO_NF = pv.COD_PED_VENDA  	" +
"	inner join  produtos prod on infe.cod_item = prod.cod_produto  	" +
"	where prod.nome_fornecedor_produto like '%VIGOR%'  	" +
" and nf.n_protocolo_autorizacao_nf is not null " +
 " and nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
 "and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") +
 "'  group by prod.cod_produto, prod.cod_barras_produto, prod.descricao_produto";

                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        texto.WriteLine(dr[0].ToString() + ";" + dr[1].ToString() + ";" + dr[2].ToString() + ";" + dr[3].ToString() + ";" +
                            dr[4].ToString() + ";" + dr[5].ToString() + ";" + dr[6].ToString() + ";" + dr[7].ToString() + ";" + dr[8].ToString());
                    }
                }
            }
        }

        private void gerar_vendedores()
        {

            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\NEOGRID\RELVEN_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\NEOGRID\RELVEN_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                { //13324184000197
                    texto.WriteLine("01|RELVEN|050|1|" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmm")) + "|" +
                         cnpj_empresa + "|03887830009046|");

                    FbCommand select = new FbCommand();
                    select.CommandText =
                   select.CommandText =
                        "select distinct(vend.*) from vendedores vend " +
                        "LEFT join PEDIDOS_VENDA  pv ON vend.COD_VENDEDOR = pv.COD_VENDEDOR_PED_VENDA " +
                        "inner join PEDIDOS_NF pnf on pnf.N_PEDIDO_NF = pv.COD_PED_VENDA " +
                        "inner join nota_fiscal nf on pnf.NF_PEDIDO_NF = nf.N_NF " +
                        "inner join itens_nota infe  on infe.nf_item = nf.n_nf " +
                         "inner join cfo on cfo.n_cfo = infe.cfop_item " +
                        "inner join  produtos prod on infe.cod_item = prod.cod_produto " +
                        "where prod.nome_fornecedor_produto like '%VIGOR%' " +
                         "   and nf.status_nfe like '%Autorizada%'  and nf.n_protocolo_autorizacao_nf is not null " +
                       " and (infe.cfop_item = '5102'	" +
                        "	or infe.cfop_item = '5405')	" +
                        "and nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        texto.WriteLine("02|" + dr["NOME_VENDEDOR"].ToString() + "|" + dr["COD_VENDEDOR"].ToString() + "|NOME_SUPERVISOR|1|NOME_GERENTE|1|A||");
                    }
                }
            }
        }

        private void gerar_vendas()
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\NEOGRID\VENDAS_13324184000197_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\NEOGRID\VENDAS_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("01|VENDAS|051|1|" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmm")) + "|" +
                       retirar_caracteres(Convert.ToDateTime(dtInicio.Text).ToString("yyyyMMdd")) + "|" +
                       retirar_caracteres(Convert.ToDateTime(dtTermino.Text).ToString("yyyyMMdd")) + "|" +
                        cnpj_empresa + "|13324184000197|");

                    FbCommand select = new FbCommand();
                    /*select.CommandText =
                        "select distinct( nf.N_NF), nf.CNPJ_CLIENTE_FORN, cli.ESTADO, cli.CEP_CLIENTE, nf.DATA_EMISSAO_NF, pv.COD_VENDEDOR_PED_VENDA from clientes cli " +
                        "inner join nota_fiscal nf on cli.CNPJ = nf.CNPJ_CLIENTE_FORN " +
                        "inner join itens_nota infe  on infe.nf_item = nf.n_nf " +
                        "inner join cfo on cfo.n_cfo = infe.cfop_item " +
                        "inner join PEDIDOS_NF pnf on pnf.NF_PEDIDO_NF = nf.N_NF " + 
                        "inner join PEDIDOS_VENDA  pv ON pnf.N_PEDIDO_NF = pv.COD_PED_VENDA " + 
                        "inner join  produtos prod on infe.cod_item = prod.cod_produto " +
                        "where prod.nome_fornecedor_produto like '%VIGOR%' " +
                        "   and nf.status_nfe like '%Autorizada%' " +
                       " and (infe.cfop_item = '5102'	" +
                        "	or infe.cfop_item = '5405')	" +
                        "   and cfo.tributada_cfo = '1' " +
                        "and nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";*/

                    select.CommandText =
                        "select distinct( nf.N_NF), nf.CNPJ_CLIENTE_FORN, cli.ESTADO, cli.CEP_CLIENTE, nf.DATA_EMISSAO_NF, " +
                        "pv.COD_VENDEDOR_PED_VENDA, nf.status_nfe, nf.natureza_operacao_nf from clientes cli " +
                        "inner join nota_fiscal nf on cli.CNPJ = nf.CNPJ_CLIENTE_FORN " +
                        "inner join itens_nota infe  on infe.nf_item = nf.n_nf " +
                        "inner join cfo on cfo.n_cfo = infe.cfop_item " +
                        "inner join PEDIDOS_NF pnf on pnf.NF_PEDIDO_NF = nf.N_NF " +
                        "inner join PEDIDOS_VENDA  pv ON pnf.N_PEDIDO_NF = pv.COD_PED_VENDA " +
                        "inner join  produtos prod on infe.cod_item = prod.cod_produto " +
                        "where prod.nome_fornecedor_produto like '%VIGOR%' and nf.n_protocolo_autorizacao_nf is not null " +
                        // " and (infe.cfop_item = '5102'	" +
                        // "	or infe.cfop_item = '5405')	" +
                        //"   and cfo.tributada_cfo = '1' " +
                        " and nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                        " and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {//yyyy-MM-ddTHH:mm:ss
                        DateTime data_emissao_nf = Convert.ToDateTime(dr["data_emissao_nf"]);
                        /*String com o tipo da NFe (|01|,|02| ou |03|)*/
                        string tipo_nf = str_tipo_nf(dr["status_nfe"].ToString(), dr["natureza_operacao_nf"].ToString());


                        texto.WriteLine("02|01|" + dr["N_NF"].ToString() + "|" + serie_empresa + "|" + tipo_nf + "|" + retirar_caracteres(data_emissao_nf.ToString("yyyyMMddHHmm")) + "|" +
                            dr["COD_VENDEDOR_PED_VENDA"].ToString() + "|" + retirar_caracteres(dr["CNPJ_CLIENTE_FORN"].ToString()) + "|" + estado_empresa + "|" + cep_empresa + "|" +
                            dr["ESTADO"].ToString() + "|" + retirar_caracteres(dr["CEP_CLIENTE"].ToString()) + "|CIF|15|");

                        FbCommand select_itens = new FbCommand();
                        select_itens.CommandText =
                                "select prod.COD_PRODUTO, infe.QTDE_ITEM, infe.PRECO_UNIT_ITEM, infe.PRECO_TOTAL_ITEM, infe.VALOR_ICMS_ST_ITEM, " +
                                "infe.VALOR_ICM_ITEM, infe.VALOR_DESCONTO_ITEM, infe.cfop_item from itens_nota infe " +
                                "inner join  produtos prod on infe.cod_item = prod.cod_produto " +
                                "where infe.nf_item = '" + dr["N_NF"].ToString() + "' and prod.nome_fornecedor_produto like '%VIGOR%'";
                        select_itens.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datSelect_itens = new FbDataAdapter();
                        datSelect_itens.SelectCommand = select_itens;
                        DataTable dtSelect_itens = new DataTable();
                        datSelect_itens.Fill(dtSelect_itens);
                        fbConnection1.Close();
                        foreach (DataRow dr_itens in dtSelect_itens.Rows)
                        {
                            string valor_icms_st = "0.00", valor_icms = "0.00", valor_desconto = "0.00";
                            try
                            {
                                valor_icms_st = Convert.ToDouble(dr_itens["VALOR_ICMS_ST_ITEM"].ToString()).ToString("n2").Replace(".", "").Replace(",", ".");
                            }
                            catch { }
                            try
                            {
                                valor_icms = Convert.ToDouble(dr_itens["VALOR_ICM_ITEM"].ToString()).ToString("n2").Replace(".", "").Replace(",", ".");
                            }
                            catch { }
                            try
                            {
                                valor_desconto = Convert.ToDouble(dr_itens["VALOR_DESCONTO_ITEM"].ToString()).ToString("n2").Replace(".", "").Replace(",", ".");
                            }
                            catch { }

                            string bonificacao = "N";
                            if (dr_itens["cfop_item"].ToString() == "5910" || dr_itens["cfop_item"].ToString() == "6910")
                            {
                                bonificacao = "S";
                            }

                            texto.WriteLine("03|" + dr["N_NF"].ToString() + "|" + serie_empresa + "|" + tipo_nf + "|" +
                            dr_itens["COD_PRODUTO"].ToString() + "|" + Convert.ToDouble(dr_itens["QTDE_ITEM"].ToString()).ToString("n5").Replace(".", "").Replace(",", ".") + "|" +
                            Convert.ToDouble(dr_itens["PRECO_UNIT_ITEM"].ToString()).ToString("n2").Replace(".", "").Replace(",", ".") + "|" + bonificacao + "|" +
                            Convert.ToDouble(dr_itens["PRECO_TOTAL_ITEM"].ToString()).ToString("n2").Replace(".", "").Replace(",", ".") + "|" +
                             Convert.ToDouble(dr_itens["PRECO_TOTAL_ITEM"].ToString()).ToString("n2").Replace(".", "").Replace(",", ".") + "|0.00|0.00|" +
                             valor_icms_st + "|" +
                             valor_icms + "|" +
                             valor_desconto + "|");
                        }
                    }
                }
            }
        }

        //verifica o tipo da nota fiscal (Venda, Devolução, Cancelada) e retorna um inteiro indicando, como consta no layout NEOGRID.
        private string str_tipo_nf(string status_nf, string natureza_operacao_nf)
        {
            try
            {
                if (status_nf.ToUpper().Contains("CANCELADA"))
                    return "03";
                if (natureza_operacao_nf.ToUpper().Contains("DEV"))
                {
                    return "02";
                }
                else if (natureza_operacao_nf.ToUpper().Contains("VENDA"))
                {
                    return "01";
                }


                return "01";
            }
            catch
            {
                return "";
            }


        }

        private void gerar_produtos()
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\NEOGRID\RELPRO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\NEOGRID\RELPRO_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("01|RELPRO|051|1|" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmm")) + "|" +
                        cnpj_empresa + "|03887830009046|");

                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "select DISTINCT(COD_BARRAS_PRODUTO), COD_PRODUTO, DESCRICAO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, QTDE_UNIDADE_PRODUTO from PRODUTOS prod " +
                    //    "where prod.nome_fornecedor_produto like '%VIGOR%' AND prod.STATUS_PRODUTO = '1' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                       "where prod.nome_fornecedor_produto like '%VIGOR%' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        string valor_venda = "0.00";
                        try
                        {
                            valor_venda = Convert.ToDouble(dr["VALOR_VENDA_REVEND_PRODUTO"].ToString()).ToString("n2").Replace(".", "").Replace(",", ".");
                        }
                        catch { }
                        string qtde = "0.00000";
                        try
                        {
                            double _qtde = Convert.ToDouble(dr["QTDE_UNIDADE_PRODUTO"].ToString());
                            if (_qtde < 0)
                                _qtde = 0;
                            qtde = _qtde.ToString("n5").Replace(".", "").Replace(",", ".");
                        }
                        catch { }

                        texto.WriteLine("02|13324184000197|" + dr["COD_PRODUTO"].ToString() + "|" + dr["COD_BARRAS_PRODUTO"].ToString() + "|01|1.00000|" +
                           valor_venda + "|" + dr["DESCRICAO_PRODUTO"].ToString() + "|01|");
                    }
                }
            }
        }

        private void gerar_estoque()
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\NEOGRID\RELEST_13324184000197_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\NEOGRID\RELEST_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("01|RELEST|050|1|" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmm")) + "|" +
                        retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "|" + retirar_caracteres(data_documento.ToString("yyyyMMdd")) + "|" +
                         cnpj_empresa + "|13324184000197|");

                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "select DISTINCT(prod.*) from PRODUTOS prod " +
                       // "where prod.nome_fornecedor_produto like '%VIGOR%' AND prod.STATUS_PRODUTO = '1' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                    "where prod.nome_fornecedor_produto like '%VIGOR%' AND VALOR_VENDA_REVEND_PRODUTO > 0 ";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        string qtde = "0.00";
                        try
                        {
                            double _qtde = 0;
                            try
                            {
                                _qtde = Convert.ToDouble(dr["ESTOQUE_ATUAL_PRODUTO"].ToString());
                                if (_qtde < 0)
                                    _qtde = 0;
                            }
                            catch { }
                            qtde = _qtde.ToString("n2").Replace(".", "").Replace(",", ".");
                        }
                        catch { }
                        texto.WriteLine("02|" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmm")) + "|" + dr["COD_PRODUTO"].ToString() + "|" +
                            qtde + "|0.00|");
                    }
                }
            }
        }


        private void gerar_clientes()
        {
            DateTime data_documento = DateTime.Now;
            string caminho = @"c:\\evolucao\\NEOGRID\RELCLI_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + ".txt";
            string caminhoAnsi = @"c:\\evolucao\\NEOGRID\RELCLI_" + cnpj_empresa + "_" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmmss")) + "-ansi.txt";
            int erros = 0;
            int verificados = 0;

            if (criar_arquivo(caminho))
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine("01|RELCLI|050|1|" + retirar_caracteres(data_documento.ToString("yyyyMMddHHmm")) + "|" + cnpj_empresa + "|03887830009046|");

                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "select distinct(cli.*), cont.NOME_CONTATO from clientes cli " +
                        "left join contatos cont on cont.COD_CLIENTE_FORN_CONTATO = cli.COD_CLIENTE " +
                         "inner join nota_fiscal nf on cli.CNPJ = nf.CNPJ_CLIENTE_FORN " +
                        "inner join itens_nota infe  on infe.nf_item = nf.n_nf " +
                        "inner join  produtos prod on infe.cod_item = prod.cod_produto " +
                        "inner join cfo on cfo.n_cfo = infe.cfop_item " +
                        "where prod.nome_fornecedor_produto like '%VIGOR%' " +
                         "   and nf.status_nfe like '%Autorizada%' and nf.n_protocolo_autorizacao_nf is not null " +
                       "and (infe.cfop_item = '5102'	" +
                        "	or infe.cfop_item = '5405')	" +
                         "   and cfo.tributada_cfo = '1' " +
                        "and nf.data_emissao_nf >= '" + Convert.ToDateTime(dtInicio.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "and nf.data_emissao_nf <= '" + Convert.ToDateTime(dtTermino.Text).ToShortDateString().Replace("/", ".") + "' ";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    DataTable cnpjs = new DataTable();
                    DataColumn novaColuna = new DataColumn();
                    cnpjs.Columns.Add(novaColuna);
                    cnpjs.Rows.Add("");
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        if (cnpjs.Select("Column1 = '" + retirar_caracteres(dr["cnpj"].ToString()) + "'").Length == 0)
                        {
                            texto.WriteLine("02|" + retirar_caracteres(dr["cnpj"].ToString()) + "|" + retirar_caracteres(dr["cep_cliente"].ToString()) + "|" + dr["estado"].ToString() + "|" +
                                dr["cidade"].ToString() + "|" +
                                dr["endereco"].ToString() + " " + dr["numero_cliente"].ToString() + "|" + dr["bairro"].ToString() + "|" + dr["razao_social"].ToString() +
                                "|169|04|" + dr["fone"].ToString() + "|" + dr["NOME_CONTATO"].ToString() + "|");
                            cnpjs.Rows.Add(retirar_caracteres(dr["cnpj"].ToString()));
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
       out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
       out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
       out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa, out string crt_empresa, out string serie_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; serie_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA WHERE LICENCA_DLL_NFE_EMPRESA IS NOT NULL";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();
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
                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();
                }

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }

        private string acertar_numero(string numero, int tamanho)
        {
            int tamanho_texto = numero.Length;
            int tamanho_restante = tamanho - tamanho_texto;
            string zero = "";
            for (int i = 0; i < tamanho_restante; i++)
            {
                zero = zero + "0";
            }
            return zero + numero;
        }

        private string acertar_numero_decimal(string numero, int tamanho, int decimais, string caractere, string tipo)
        {
            int tamanho_texto = (numero.Length) + 1;
            int tamanho_restante = tamanho - tamanho_texto;
            string zero = "";
            for (int i = 0; i < tamanho_restante; i++)
            {
                zero = zero + "0";
            }
            string novo_numero = zero + numero;
            int local_caractere = 0;
            local_caractere = tipo == "p" ? ((tamanho - 1) - decimais) : (tamanho - decimais); //Subtrair 1 do tamanho quando o valor for 'preço'
            return novo_numero.Insert(local_caractere, caractere);
        }

        private string acertar_data(DateTime data)
        {
            string mes = data.Month.ToString();
            if (mes.Length == 1)
                mes = "0" + mes;
            string dia = data.Day.ToString();
            if (dia.Length == 1)
                dia = "0" + dia;
            return data.Year.ToString() + mes + dia;
        }

        private string acertar_tamanho(string nome, int n_caracteres)
        {
            try
            {
                string retorno = nome.Trim();
                int tamanho = retorno.Length;

                for (int i = tamanho; i < n_caracteres; i++)
                {
                    retorno = retorno + " ";
                }
                return retorno;
            }
            catch
            {
                return "";
            }
        }

        private string retirar_caracteres(string arquivo)
        {
            try
            {
                return arquivo.Replace("Ã", "A").Replace("Õ", "O").Replace("Ç", "C").Replace("Â", "A").Replace("Á", "A").Replace("À", "A")
                .Replace("Ô", "O").Replace("\r\n", " ").Replace("-", "").Replace("(", "").Replace(")", "").Replace("/", "")
                .Replace("&", "e").Replace("'", "").Replace(":", "").Replace(" ", "").Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "");
            }
            catch
            {
                return "";
            }
        }

        public Boolean criar_arquivo(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter(Name);
                Arquivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
         complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
         cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
         senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", serie_empresa = "";

        private void form_arquivo_neogrid_Load(object sender, EventArgs e)
        {

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out serie_empresa);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
