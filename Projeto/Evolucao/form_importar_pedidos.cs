using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Evolucao
{
    public partial class form_importar_pedidos : Form
    {
        public string cod_webservice_empresa;

        bool pedidos_importando;
        int qtde_pedidos_importando;
        int  cod_lote_pedidos_importando;
        DataTable datPedidos_importando;

        public form_importar_pedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            importar_pedidos();
        }
        private void importar_pedidos()
        {
            if (pedidos_importando)
            {
                MessageBox.Show("Importação em andamento. Aguarde a finalização");
            }
            else
            {
                labelProgresso.Text = "Importando Pedidos. Aguarde...";
                progressBar1.Value = 0;
                DateTime agora = DateTime.Now;
                int j = 0;


                webservice.Service1 webser = new webservice.Service1();
                if (razao_social_empresa.Contains("MUNHOZ"))
                {
                    webser.Timeout = 60000;
                }

                DataSet ds = new DataSet();
                if (cod_webservice_empresa != "")
                    ds = webser.importarXMLPedidos_cnpj(Convert.ToInt32(cod_webservice_empresa));
                else
                    ds = webser.importarXMLPedidos();

                //ArrayList al = new ArrayList();

                string[] al = new string[2000];
                int i = 0;

                int numero_pedidos = ds.Tables[0].Rows.Count;
                qtde_pedidos_importando = numero_pedidos;
                // int numero_itens_pedido 
                //int numero_pedidos = ds.Tables[0].Rows.Count;

                int lote_receb_web = 0;
                int ultimo_pedido_lote = 0;
                try
                {
                    progressBar1.Value = j;
                    progressBar1.Maximum = ds.Tables[0].Rows.Count;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        System.Threading.Thread.Sleep(750);
                        j++;
                        progressBar1.Value = j;
                        try
                        {
                            ultimo_pedido_lote = Convert.ToInt32(dr["COD_XML"].ToString());
                            if (lote_receb_web == 0)
                            {
                                lote_receb_web = inserir_lote_receb_web(ds.Tables[0].Rows.Count, dr["COD_XML"].ToString());
                                cod_lote_pedidos_importando = lote_receb_web;
                            }
                            bool pedido_repetido = false;
                            bool pedido_ok = false;


                            Object[] args = { dr["XML_XML"].ToString(), lote_receb_web, pedido_repetido, pedido_ok, dr["COD_XML"].ToString() };

                            //INCIO 
                            BackgroundWorker worker = new BackgroundWorker();

                            worker.DoWork += new DoWorkEventHandler(
                                delegate(object senderDoWord, DoWorkEventArgs eDoWork)
                                {
                                    Object[] arg = eDoWork.Argument as Object[];
                                    bool pedido_repetidoDoWork;
                                    bool pedido_okDoWork = inserir_pedido(arg[0].ToString(), Convert.ToInt32(arg[1]), out pedido_repetidoDoWork, arg[4].ToString());
                                    arg[2] = pedido_repetidoDoWork;
                                    arg[3] = pedido_okDoWork;
                                    arg[4] = dr["COD_XML"].ToString();
                                    eDoWork.Result = arg;

                                });
                            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                                delegate(object senderRunWorkerCompleted, RunWorkerCompletedEventArgs eRunWorkerCompleted)
                                {
                                    Object[] arg = eRunWorkerCompleted.Result as Object[];
                                    pedido_repetido = Convert.ToBoolean(arg[2]);
                                    pedido_ok = Convert.ToBoolean(arg[3]);
                                    if (Convert.ToBoolean(args[3]))
                                    {
                                        al[0] = dr["COD_XML"].ToString();
                                        webser.updateXMLsBaixados_cnpj(al, 1, Convert.ToInt32(cod_webservice_empresa));
                                        i++;
                                       // j++;
                                        //progressBar1.Value = j;
                                    }
                                    else
                                    {
                                        if (pedido_repetido)
                                        {
                                            string[] erro = new string[1];
                                            erro[0] = dr["COD_XML"].ToString();
                                            webser.updateXMLsBaixados_cnpj(erro, 1, Convert.ToInt32(cod_webservice_empresa));
                                            numero_pedidos--;
                                        }
                                        else
                                        {
                                            //MessageBox.Show("Erro no pedido da nuvem número: " + dr["COD_XML"].ToString() + " Número de lote de recebimento: " + lote_receb_web.ToString() + ". Contate o suporte.");
                                        }
                                        i++;
                                       // j++;
                                        //progressBar1.Value = j;
                                    }

                                });
                            worker.RunWorkerAsync(args);


                            //FIM

                            /*

                            if(Convert.ToBoolean(args[3]))
                            {
                                al[i] = dr["COD_XML"].ToString();
                                i++;
                            }
                            else
                            {
                                if (pedido_repetido)
                                {
                                    string[] erro = new string[1];
                                    erro[0] = dr["COD_XML"].ToString();
                                    webser.updateXMLsBaixados_cnpj(erro, 1, Convert.ToInt32(cod_webservice_empresa));
                                }
                                else
                                {
                                    MessageBox.Show("Erro no pedido da nuvem número: " + dr["COD_XML"].ToString() + " Número de lote de recebimento: " + lote_receb_web.ToString() + ". Contate o suporte.");
                                }
                            }
                             * */
                        }
                        catch { }

                    }
                }
                catch { }






                //  if (cod_webservice_empresa != "")
                //      webser.updateXMLsBaixados_cnpj(al, i, Convert.ToInt32(cod_webservice_empresa));
                //  else
                //      webser.updateXMLsBaixados(al, i);

                //  System.Threading.Thread.Sleep(10000);

                //  update_lrw(lote_receb_web, ultimo_pedido_lote);
                // atualiza_estoque_itens_inseridos(lote_receb_web);
                //  System.Threading.Thread.Sleep(30000);
                // recalcular_estoque();


                
                DateTime fim = DateTime.Now;
                TimeSpan diferenca = fim - agora;
                //   MessageBox.Show(diferenca.ToString());
                //   MessageBox.Show("Pedidos Importados. O processo continua... Aguarde 5 minutos para fechá-los e fatura-los.");

                //datPedidos_importando = buscar_pedidos(lote_receb_web.ToString());
               // while (datPedidos_importando.Rows.Count > numero_pedidos)
               // {
               //     datPedidos_importando = buscar_pedidos(lote_receb_web.ToString());
               // }

                //System.Threading.Thread.Sleep(10000);
                labelProgresso.Text = "Conferindo Pedidos. Aguarde ...";
                progressBar1.Value = 0;
                int buscar_pedidos = 0;
                string n_pedido =  "";
                DateTime _agora1 = DateTime.Now;
                while (!buscar_pedidos_inseridos(ds, out n_pedido) && DateTime.Now < _agora1.AddMinutes(2))
                {
                    System.Threading.Thread.Sleep(1000);
                    progressBar1.Value++;
                    if (progressBar1.Value >= progressBar1.Maximum)
                        progressBar1.Value = 0;
                    buscar_pedidos++;
                }
                if (buscar_pedidos == 200)
                {
                    MessageBox.Show("Existem pedidos não baixados: " + n_pedido);
                }

                labelProgresso.Text = "Conferindo Itens dos Pedidos. Aguarde ...";
                DateTime _agora = DateTime.Now;
                while (!buscar_itens_inseridos(ds) && DateTime.Now < _agora.AddMinutes(5))
                {
                    progressBar1.Value++;
                    if (progressBar1.Value >= progressBar1.Maximum)
                        progressBar1.Value = 0;
                }
                atualiza_estoque_itens_inseridos();
                update_lrw(lote_receb_web, ultimo_pedido_lote);
                update_lrw(0, 0);
                labelProgresso.Text = "Pedidos Importados";
                MessageBox.Show("Pedidos Importados");

                //timerPedidos_importando.Enabled = true;

            }
        }

        private bool buscar_pedidos_inseridos(DataSet ds, out string n_pedido)
        {
            n_pedido =  "";
            try
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    FbConnection _conexao = new FbConnection();
                    _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                        FbCommand select = new FbCommand();
                        select.Connection = _conexao;
                        select.CommandText =
                            @"SELECT * from PEDIDOS_VENDA pv
                        WHERE pv.ID_PEDIDO_CEL_PED_VENDA = '" + dr["ID_PEDIDO_XML"].ToString() +
                        "' AND pv.COD_VENDEDOR_PED_VENDA = '" + dr["ID_USUARIO_XML"].ToString() + "' ";
                       
                        _conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        _conexao.Close();
                        if (dtSelect.Rows.Count == 0)
                            n_pedido += " Pedido da Nuvem: " + dr["ID_PEDIDO_XML"].ToString() + " Vendedor: " + dr["ID_USUARIO_XML"].ToString();
                  
                }
                if (n_pedido != "")
                    return false;
                else
                    return true;
            }
            catch (Exception a)
            {
               // fbConnection1.Close();
                return false;
            }
        }

        private bool buscar_itens_inseridos(DataSet ds)
        {
            try
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        FbConnection _conexao = new FbConnection();
                        _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                        FbCommand select = new FbCommand();
                        select.Connection = _conexao;
                        select.CommandText =
                            @"SELECT COUNT(iped.COD_ITEM_VENDA), pv.QTDE_ITENS_PED_VENDA FROM ITENS_PEDIDO_VENDA iped  
                        INNER JOIN PEDIDOS_VENDA pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
                        WHERE pv.ID_PEDIDO_CEL_PED_VENDA = '" + dr["ID_PEDIDO_XML"].ToString() + 
                        "' AND pv.COD_VENDEDOR_PED_VENDA = '" + dr["ID_USUARIO_XML"].ToString() + "' " + 
                        "group by pv.QTDE_ITENS_PED_VENDA";
                        _conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataTable dtSelect = new DataTable();
                        datSelect.Fill(dtSelect);
                        _conexao.Close();
                       // if (dtSelect.Rows.Count == 0)
                        //    return false;
                        foreach (DataRow dr1 in dtSelect.Rows)
                        {
                            try
                            {
                                if (Convert.ToInt32(dr1[0].ToString()) < Convert.ToInt32(dr1[1].ToString()))
                                {
                                    return false;
                                }
                                else
                                {
                                    /*
                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    update.CommandText =
                                        "UPDATE PEDIDOS_VENDA pv set pv.VALOR_TOTAL_PED_VENDA = '" + dr1["VALOR_TOTAL_PROD_ITEM_VENDA"].ToString() + "', " +
                                        "pv.QTDE_ITENS_PED_VENDA = '" + dr1["QTDE_ITENS_PED_VENDA"].ToString() + "' WHERE pv.ID_PEDIDO_CEL_PED_VENDA = '" +
                                        dr["NOSSO_COD_PEDIDO"].ToString() + "'";
                                    fbConnection1.Open();
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                     * */
                                }
                            }
                            catch
                            {
                               // fbConnection1.Close();
                            }
                        }
                    }
                    catch
                    {
                        //fbConnection1.Close();
                    }
                }
                return true;
            }
            catch (Exception a)
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            datPedidos_importando = buscar_pedidos(cod_lote_pedidos_importando.ToString());
            //while (datPedidos_importando.Rows.Count > numero_pedidos)
            //{
            //    datPedidos_importando = buscar_pedidos(lote_receb_web.ToString());
            //}
            
            timerPedidos_importando.Enabled = true;
            progressBar1.Maximum = datPedidos_importando.Rows.Count;
            bool finalizou = true;
            int i = 0;
            foreach (DataRow dr in datPedidos_importando.Rows)
            {
                try
                {
                    FbConnection _conexao = new FbConnection();
                    _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT COUNT(COD_ITEM_VENDA) FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + dr[0].ToString() + "'";
                    select.Connection = _conexao;
                    _conexao.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    _conexao.Close();
                    foreach (DataRow dr1 in dtSelect.Rows)
                    {
                        if (Convert.ToInt32(dr1[0].ToString()) == Convert.ToInt32(dr[1].ToString()))
                        {
                            i++;
                        }
                    }
                   // return true;
                }
                catch (Exception a)
                {
                   // fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                    //return true;
                }
            }
            if (i > progressBar1.Value)
            {
                try
                {
                    progressBar1.Value = i;
                }
                catch { }
            }
            if (progressBar1.Value >= progressBar1.Maximum)
            {
               // System.Threading.Thread.Sleep(20000);
                pedidos_importando = false;
                
                webservice.Service1 webser = new webservice.Service1();
                // atualiza_estoque_itens_inseridos(cod_lote_pedidos_importando);
                while(pedidos_pendentes())
                {
                    
                    //importar_pedidos();
                }
                
                {
                    atualiza_estoque_itens_inseridos();
                    update_lrw(0, 0);
                    timerPedidos_importando.Enabled = false;
                    labelProgresso.Text = "Pedidos Importados";
                    MessageBox.Show("Pedidos Importados");
                    
                }
            }




        }

        private bool pedidos_pendentes()
        {
           // AQUI EU TERIA QUE CONSULTAR A NUVEM PARA VER SE TEM PEDIDO PENDENTES AINDA
            return false;
        }

        private DataTable buscar_pedidos(string lote)
        {
            DataTable retorno = new DataTable();
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_PED_VENDA, QTDE_ITENS_PED_VENDA, ID_PEDIDO_CEL_PED_VENDA FROM PEDIDOS_VENDA WHERE COD_LRW_PED_VENDA = '" + lote + "'";
                select.Connection = _conexao;
                _conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                _conexao.Close();
                retorno = dtSelect;
                return retorno;
            }
            catch(Exception a)
            {
              //  fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }
        private void recalcular_estoque()
        {
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                DateTime começo = DateTime.Now;
                int i = 0;
               // progressBar1.Value = i;
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, QTDE_UNIDADE_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, COD_PRODUTO FROM PRODUTOS";
                select.Connection = _conexao;
                _conexao.Open();
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataTable dtEstoque = new DataTable();
                datEstoque.Fill(dtEstoque);
                _conexao.Close();
                //progressBar1.Maximum = dtEstoque.Rows.Count;
                foreach (DataRow dr in dtEstoque.Rows)
                {
                    i++;
                   // progressBar1.Value = i;
                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        //estoque.calcular_estoque(dr[1].ToString(), dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                    }
                    catch { }
                }
               // progressBar1.Value = 0;
                DateTime fim = DateTime.Now;
                TimeSpan intervalo = fim - começo;
                //MessageBox.Show("Recalculado com sucesso! " + intervalo.ToString());
            }
            catch (Exception a)
            {
               // fbConnection1.Close();
            }
        }

       

        private void atualiza_estoque_itens_inseridos()
        {
            FbCommand select = new FbCommand();
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                select.CommandText =
                   @"SELECT DISTINCT(COD_SISTEMA_PROD_ITEM_VENDA), prod.cod_barras_produto,
prod.cod_barras_caixa_produto, prod.qtde_unidade_produto, prod.cnpj_fornecedor_produto, 
prod.COD_FORNECEDOR_PRODUTO 
  FROM ITENS_PEDIDO_VENDA ipv
INNER JOIN PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA
INNER JOIN PRODUTOS prod ON prod.cod_fornecedor_produto = ipv.cod_prod_item_venda
INNER JOIN lote_receb_web lrw on pv.cod_lrw_ped_venda = lrw.cod_lrw
WHERE lrw.ESTOQUE_CONFERIDO_LRW IS NULL";
                select.Connection = _conexao;
                _conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                _conexao.Close();
                progressBar1.Value = 0;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    labelProgresso.Text = "Recalculando estoque. Aguarde...";
                    progressBar1.Maximum = dtSelect.Rows.Count;
                    progressBar1.Value++;
                    string _dun = dr[2].ToString(), _qtde = dr[3].ToString(), _cnpj = dr[4].ToString(), _cod_fornecedor = dr[5].ToString();
                    string ean = dr[1].ToString();
                    // double custo = 0;
                    // string ean = buscar_ean_produto(dr[0].ToString(), out _dun, out _qtde, out _cnpj, out _cod_fornecedor, out custo);
                    if (ean != "null")
                        ean = "'" + ean + "'";
                    BackgroundWorker worker = new BackgroundWorker();
                    
                    worker.DoWork += new DoWorkEventHandler(
                        delegate(object senderDoWord, DoWorkEventArgs eDoWork)
                        {
                            try
                            {
                                classeEstoque estoque = new classeEstoque();
                                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                //estoque.calcular_estoque(_dun, ean.Replace("'", ""), _qtde, _cnpj, dr[0].ToString());
                            }
                            catch { }
                        });
                    worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                        delegate(object senderRunWorkerCompleted, RunWorkerCompletedEventArgs eRunWorkerCompleted)
                        {
                        });
                    worker.RunWorkerAsync();

                }
               
            }
            catch(Exception a)
            {
              //  fbConnection1.Close();
                MessageBox.Show(a.ToString());
                
            }
        }

        private void update_lrw(int lote_receb_web, int ultimo_pedido_lote)
        {
            try
            {

                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand update = new FbCommand();
                update.Connection = _conexao;
                _conexao.Open();
                if (lote_receb_web == 0 && ultimo_pedido_lote == 0)
                { //quando a chamada vem depois do acerto de estoque da importacao
                    update.CommandText =
                        "UPDATE LOTE_RECEB_WEB SET ESTOQUE_CONFERIDO_LRW = 1 WHERE ESTOQUE_CONFERIDO_LRW is null";
                }
                else
                {
                    update.CommandText =
                        "UPDATE LOTE_RECEB_WEB SET COD_WEB_FINAL_LRW = '" + ultimo_pedido_lote.ToString() +
                        "' WHERE COD_LRW = '" + lote_receb_web + "'";
                }
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                _conexao.Close();



            }
            catch (Exception a)
            {
               // fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private int inserir_lote_receb_web(int n_pedidos, string primeiro_pedido)
        {
            
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand insert = new FbCommand();
                insert.Connection = _conexao;
                _conexao.Open();
                insert.CommandText =
                    "INSERT INTO LOTE_RECEB_WEB (DATA_LRW, HORA_LRW, COD_WEB_INICIAL_LRW, COD_WEB_FINAL_LRW, NUMERO_PEDIDOS_LRW) " +
                    "VALUES (CURRENT_DATE, CURRENT_TIME, '" + primeiro_pedido.ToString() + "', '0', '" + n_pedidos.ToString() + "')  RETURNING COD_LRW";
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                int n_lote = Convert.ToInt32(datInsert.InsertCommand.ExecuteScalar());
                _conexao.Close();
                return Convert.ToInt32(n_lote.ToString());

            }
            catch
            {
               // fbConnection1.Close();
                return 0;
            }
        }
        //public bool verificaPedidoUnico_codweb(string codweb, out string id)
        //{

        //    id = "";
        //    int baixado = 0;
        //    int cancelado = 0;
        //    int impresso = 0;
        //    FbConnection conexao = new FbConnection();
        //    try
        //    {

        //        FbCommand select = new FbCommand();

        //        conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
        //        select.CommandText =
        //            "SELECT * FROM PEDIDOS_VENDA WHERE COD_WEB_PED_VENDA = '" + codweb +
        //            "'";
        //        select.Connection = conexao;
        //        conexao.Open();
        //        FbDataAdapter datSelect = new FbDataAdapter();
        //        datSelect.SelectCommand = select;
        //        DataSet dsSelect = new DataSet();

        //        datSelect.Fill(dsSelect);
        //        conexao.Close(); conexao.Dispose();
        //        foreach (DataRow drPedido in dsSelect.Tables[0].Rows)
        //        {
        //            return false;
        //            //    try
        //            //    {
        //            //        try
        //            //        {
        //            //            id = drPedido[0].ToString();
        //            //        }
        //            //        catch { id =  ""; }
        //            //        try
        //            //        {
        //            //            baixado = Convert.ToInt32(drPedido["BAIXADO_ESTOQUE_PED_VENDA"].ToString());
        //            //        }
        //            //        catch { baixado = 0; }
        //            //        try
        //            //        {
        //            //            cancelado = Convert.ToInt32(drPedido["CANCELADO_PED_VENDA"].ToString());
        //            //        }
        //            //        catch { cancelado = 0; }
        //            //        try
        //            //        {
        //            //            impresso = Convert.ToInt32(drPedido["IMPRESSO_PED_VENDA"].ToString());
        //            //        }
        //            //        catch { impresso = 0; }
        //            //        if (baixado == 1)
        //            //            return false;
        //            //        else if (cancelado == 1)
        //            //            return false;
        //            //        else if (impresso == 1)
        //            //            return false;
        //            //        else
        //            //            return true;
        //            //    }
        //            //    catch { return true; }
        //        }
        //        return true;
        //    }
        //    catch (Exception a)
        //    {
        //        conexao.Close(); conexao.Dispose();
        //        return false;
        //    }
        //}
        public bool verificaPedidoUnico(string idPedidoItem, string codUsuario, string cnpj, out string id, string codweb, string totalPedido)
        {

            id =  "";
            int baixado = 0;
            int cancelado = 0;
            int impresso = 0;
            FbConnection conexao = new FbConnection();
            try
            {

                FbCommand select = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT * FROM PEDIDOS_VENDA WHERE (ID_PEDIDO_CEL_PED_VENDA = " + idPedidoItem +
                    " AND COD_VENDEDOR_PED_VENDA = " + codUsuario + " and cnpj_ped_venda = '" + cnpj + "' and valor_total_ped_venda = " + totalPedido + ")" +
                    " OR COD_WEB_PED_VENDA = '" + codweb + "'";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();

                datSelect.Fill(dsSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow drPedido in dsSelect.Tables[0].Rows)
                {
                    return false;
                //    try
                //    {
                //        try
                //        {
                //            id = drPedido[0].ToString();
                //        }
                //        catch { id =  ""; }
                //        try
                //        {
                //            baixado = Convert.ToInt32(drPedido["BAIXADO_ESTOQUE_PED_VENDA"].ToString());
                //        }
                //        catch { baixado = 0; }
                //        try
                //        {
                //            cancelado = Convert.ToInt32(drPedido["CANCELADO_PED_VENDA"].ToString());
                //        }
                //        catch { cancelado = 0; }
                //        try
                //        {
                //            impresso = Convert.ToInt32(drPedido["IMPRESSO_PED_VENDA"].ToString());
                //        }
                //        catch { impresso = 0; }
                //        if (baixado == 1)
                //            return false;
                //        else if (cancelado == 1)
                //            return false;
                //        else if (impresso == 1)
                //            return false;
                //        else
                //            return true;
                //    }
                //    catch { return true; }
                }
                return true;
            }
            catch (Exception a)
            {
                conexao.Close(); conexao.Dispose();
                return false;
            }
        }

        private void verificar_se_id_novo_ja_existe(out bool existe, int novo_codigo, string idUsuario, string cnpj)
        {
            existe = false;
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";

            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM PEDIDOS_VENDA where id_pedido_cel_ped_venda = '" + novo_codigo.ToString() +
                    "' and cod_vendedor_ped_venda = '" + idUsuario + "' and cnpj_ped_venda = '" + cnpj + "'";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    existe = true;
                }
            }
            catch
            {
                conexao.Close(); conexao.Dispose();
            }
        }

        private string buscar_desconto_nota_cliente(string cnpj, out double porc_desconto, out string latitude, out string longitude)
        {
            string desconto_valor_nota =  ""; porc_desconto = 0;
            latitude = "0.00" ;
            longitude = "0.00";
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand sel = new FbCommand();
                FbDataAdapter datSel = new FbDataAdapter();
                DataTable dt = new DataTable();
                sel.Connection = _conexao;
                sel.CommandText = "SELECT DESCONTO_VALOR_NOTA_CLIENTE, DESCONTO_PONTUALIDADE_CLIENTE, LATITUDE_CLIENTE, LONGITUDE_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                datSel.SelectCommand = sel;
                _conexao.Open();
                datSel.Fill(dt);
                _conexao.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    try
                    {
                        desconto_valor_nota = dr[0].ToString();
                        porc_desconto = Convert.ToDouble(dr[1].ToString());
                    }
                    catch { }
                    try
                    {
                        latitude = Convert.ToDouble(dr[2].ToString()).ToString().Replace(".","").Replace(",",".");
                        longitude = Convert.ToDouble(dr[3].ToString()).ToString().Replace(".", "").Replace(",", ".");
                    }
                    catch { }
                    return desconto_valor_nota;
                }
                return desconto_valor_nota;
            }
            catch
            {
               // fbConnection1.Close();
                return desconto_valor_nota;
            }

        }

        private string buscar_ultimo_pedido_empresa(string cnpj_empresa)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT FIRST(1) N_PED_VENDA FROM PEDIDOS_VENDA pv WHERE CNPJ_EMISSOR_PED_VENDA = '" + cnpj_empresa + "' ORDER BY pv.N_PED_VENDA DESC";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "0";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "0";
            }
        }

        private bool inserir_pedido(string xml, int cod_lrw, out bool pedido_repetido, string cod_web)
        {
            pedido_repetido = false;
            try
            {
                string vendLog = "", idLog =  "";
                string log =  "";
                log += DateTime.Now.ToString() + ": Exportar Pedidos \r\n";

                string nome_unico = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt").Replace("/", "").Replace(":", "").Replace(".","").Replace(" ", "");
                //string caminho = @"c:\evolucao_vigor\xml_pedidos.xml";
                string caminho = @"c:\\evolucao\\exportacoes\" + nome_unico + ".xml";

                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(xml);
                }

             
                //string idItemPedido = "null", idPedidoItem = "null", idProduto = "null", nomeProduto = "", unidadeProduto = "",
                //    qtdeItem = "null", valorUnitarioItem = "null", valorTotalItem = "null", porcItem = "null";

                string codUsuario =  "";
                DataSet ds = new DataSet();
                ds.ReadXml(caminho);

                DataSet dsDefinitivo = new DataSet();
                foreach (DataRow dr3 in ds.Tables["modelo.Usuario"].Rows)
                {
                    //codUsuario = "'" + dr3["idUsuario"].ToString() + "'";
                    codUsuario = dr3["idUsuario"].ToString();
                    vendLog = codUsuario;
                    //criando um arquivo unico para esse usuario para não haver concorrencia



                }
                string cnpjPedido =  "";
                string _primeiro_id;
                DataRow dr1 = ds.Tables["modelo.Pedido"].Rows[0];
                {
                    _primeiro_id = dr1["idPedido"].ToString();
                    cnpjPedido = dr1["cnpjPedido"].ToString();
                }
                if (0 == 1)
                {
                    bool existe = true;
                    int novo_codigo = 0;
                    while (existe)
                    {
                        novo_codigo = novo_codigo + 1000000;
                        verificar_se_id_novo_ja_existe(out existe, novo_codigo + 1, codUsuario, cnpjPedido);
                    }
                    FbConnection conexao = new FbConnection();
                    conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";

                    FbCommand update = new FbCommand();
                    update.CommandText = "update pedidos_venda pv set pv.id_pedido_cel_ped_venda =  pv.id_pedido_cel_ped_venda + " + novo_codigo + " where pv.cod_vendedor_ped_venda = '" + codUsuario + "'";
                    update.Connection = conexao;
                    conexao.Open();
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    conexao.Close(); conexao.Dispose();
                }

                foreach (DataRow dr in ds.Tables["modelo.Pedido"].Rows)
                {
                    string idPedido = "", clientePedido = "", dataPedido = "", totalProdutoPedido = "null", totalPedido = "null",
                 totalDescontoPedido = "null", nomeVendedorPedido = "", codVendedorPedido = "null", idClientePedido = "null",
                 qtdeItens = "null", dataEntrega = "null", horaPedido = "null", condPgto = "", obsPedido = "", troca = "null", bonificacao = "null",
                 venda_direta = "null", fechado = "null", pv = "null", boleto_vd = "null", nf_vd_ped_venda = "null", cod_web_ped_venda = "null",
                 latitude = "null", longitude = "null", cod_tp = "null", descricao_tp = "null";

                    idPedido = dr["idPedido"].ToString();
                    dataPedido = dr["dataPedido"].ToString();
                    clientePedido = dr["clientePedido"].ToString();
                    cnpjPedido = dr["cnpjPedido"].ToString();
                    totalPedido = dr["totalPedido"].ToString();

                    try
                    {
                        latitude = dr["latitude"].ToString();
                        longitude = dr["longitude"].ToString();
                    }
                    catch
                    {
                        latitude = "0.00";
                        longitude = "0.00";
                    }
                    try
                    {
                        cod_tp = dr["codTp"].ToString();
                        descricao_tp = "'" + dr["descricaoTp"].ToString() + "'";
                    }
                    catch { }
                    string desconto_valor_nota =  ""; double porc_desconto = 0;

                    string _latitude_atual = "", _longitude_atual = "";

                    if(cnpjPedido != "")
                        desconto_valor_nota = buscar_desconto_nota_cliente(cnpjPedido, out porc_desconto, out _latitude_atual, out _longitude_atual);

                   // verificar_se_cliente_tem_localizacao(cnpjPedido, latitude, longitude);
                    try
                    {
                        if (Convert.ToDouble(_latitude_atual) == 0)
                        {
                            update_latitude_longitude(cnpjPedido, latitude, longitude);
                        }
                    }
                    catch { }
                    
                    qtdeItens = dr["qtdeItens"].ToString();
                    int _qtdeItens = 0;
                    try
                    {
                        _qtdeItens = Convert.ToInt32(qtdeItens);
                    }
                    catch
                    { }
                    if ((clientePedido == "_NOVO CLIENTE" || clientePedido == "") && _qtdeItens > 0)
                    {
                        try
                        {
                            string _cnpj = "null", _ie = "null", _razao = "null", _endereco = "null", _numero = "null", _bairro = "null", _cidade = "null",
                                _cep = "null", _estado = "null", _contato = "null", _email = "null", _telefone = "null", _cod_municipio = "null";
                            try
                            {
                                _cnpj = dr["cnpjClienteNovo"].ToString().Replace(".","").Replace("/", "").Replace("-", "");
                            }
                            catch { }
                            try
                            {
                                _ie = "'" + dr["ieClienteNovo"].ToString().Replace(".","").Replace("/", "").Replace("-", "") + "'";

                            }
                            catch { }
                            try
                            {
                                _razao = "'" + dr["razaoClienteNovo"].ToString().ToUpper() + "'";

                            }
                            catch { }
                            try
                            {
                                _endereco = "'" + dr["enderecoClienteNovo"].ToString().ToUpper() + "'";
                            }
                            catch { }
                            try
                            {
                                _numero = "'" + dr["numeroClienteNovo"].ToString().ToUpper() + "'";
                            }
                            catch { }
                            try
                            {
                                if (dr["bairroClienteNovo"].ToString().ToUpper().Length > 30)
                                {
                                    _bairro = "'" + dr["bairroClienteNovo"].ToString().ToUpper().Remove(30) + "'";
                                }
                                else
                                {
                                    _bairro = "'" + dr["bairroClienteNovo"].ToString().ToUpper() + "'";
                                }
                            }
                            catch { }
                            try
                            {
                                _cidade = "'" + dr["cidadeClienteNovo"].ToString().ToUpper() + "'";
                            }
                            catch { }
                            try
                            {
                                if (dr["estadoClienteNovo"].ToString().ToUpper().Length == 2)
                                    _estado = "'" + dr["estadoClienteNovo"].ToString().ToUpper() + "'";
                                else
                                    _estado = "'" + buscar_estado_empresa("ESTADO_EMPRESA") + "'";
                            }
                            catch { }
                            try
                            {
                                _contato = "'" + dr["contatoClienteNovo"].ToString().ToUpper() + "'";
                            }
                            catch { }
                            try
                            {
                                _email = "'" + dr["emailClienteNovo"].ToString() + "'";
                            }
                            catch { }
                            try
                            {
                                _telefone = "'" + dr["telefoneClienteNovo"].ToString() + "'";
                            }
                            catch { }
                            try
                            {
                                _cep = "'" + dr["cepClienteNovo"].ToString().Replace(".","").Replace("/", "").Replace("-", "") + "'";
                            }
                            catch { }

                            _cod_municipio = buscar_cod_mun(_cidade);
                            if (_cod_municipio == "")
                            {
                                MessageBox.Show("Código Cidade do cliente " + _razao + " não encontrado. ID Pedido: " + idPedido + ". Vendedor: " + codUsuario + ". Favor Verificar");
                                _cod_municipio = "null";
                            }
                            else
                            {
                                _cod_municipio = "'" + _cod_municipio + "'";
                            }
                            if (_cnpj.Replace("'", "") != "")
                            {
                                try
                                {
                                    string limite = "null";
                                    if (razao_social_empresa.Contains("LLOC"))
                                        limite = "0";
                                    clientePedido = _razao;
                                    cnpjPedido = _cnpj;
                                    _cnpj = "'" + _cnpj + "'";
                                    FbCommand insert = new FbCommand();
                                    FbConnection conexao = new FbConnection();
                                    conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                    insert.CommandText =
                                        "INSERT INTO CLIENTES (CNPJ, IE, RAZAO_SOCIAL, ENDERECO, NUMERO_CLIENTE, BAIRRO, CIDADE, ESTADO, CEP_CLIENTE, CONTATO1, EMAIL, " + 
                                        "FONE, COD_CIDADE_CLIENTE, ATIVO_CLIENTE, LIMITE_CREDITO_CLIENTE, LATITUDE_CLIENTE, LONGITUDE_CLIENTE) " +
                                        "VALUES (" + _cnpj + "," + _ie + "," + _razao + "," + _endereco + "," + _numero + "," + _bairro + "," + _cidade + "," +
                                        _estado + "," + _cep + "," + _contato + "," + _email + "," + _telefone + "," + _cod_municipio + ",'1'," + limite + "," + 
                                        latitude + "," + longitude + ")";
                                    insert.Connection = conexao;
                                    conexao.Open();
                                    FbDataAdapter datInsert = new FbDataAdapter();
                                    datInsert.InsertCommand = insert;
                                    datInsert.InsertCommand.ExecuteNonQuery();
                                    conexao.Close(); conexao.Dispose();
                                    inserir_vendedor_cliente(_cnpj, codUsuario);
                                }
                                catch
                                {

                                }
                            }
                        }
                        catch { }


                    }

                    totalProdutoPedido = dr["totalProdutoPedido"].ToString();
                    totalPedido = dr["totalPedido"].ToString();
                    totalDescontoPedido = dr["totalDescontoPedido"].ToString();
                    nomeVendedorPedido = dr["nomeVendedorPedido"].ToString();
                    codVendedorPedido = dr["codVendedorPedido"].ToString();
                    idClientePedido = dr["idClientePedido"].ToString();

                    try
                    {
                        string _hora = dr["horaPedido"].ToString();
                        horaPedido = "'" + Convert.ToDateTime(_hora).ToShortTimeString() + "'";
                    }
                    catch { }
                    dataEntrega = dr["dataEntrega"].ToString();
                    condPgto = dr["condPgto"].ToString();
                    obsPedido = dr["obsPedido"].ToString();
                    try
                    {
                        troca = dr["troca"].ToString();
                        bonificacao = dr["bonificacao"].ToString();
                        try
                        {
                            venda_direta = dr["faturado"].ToString();
                        }
                        catch { }
                        try
                        {
                            pv = dr["pv"].ToString();
                        }
                        catch { }
                        if (pv == "")
                            pv = "0";
                        try
                        {
                            boleto_vd = dr["boletoVd"].ToString();
                        }
                        catch { }
                        if (boleto_vd == "")
                            boleto_vd = "0";
                        try
                        {
                            nf_vd_ped_venda = dr["nfVd"].ToString();
                        }
                        catch { }
                        if (nf_vd_ped_venda == "")
                            nf_vd_ped_venda = "0";
                        try
                        {
                            cod_web_ped_venda = cod_web;
                        }
                        catch { }
                        if (cod_web_ped_venda == "")
                            cod_web_ped_venda = "0";

                        if (troca == "1")
                        {
                            condPgto = "2 - OUTROS";
                            obsPedido += " SR. MOTORISTA RETIRAR PRODUTOS AVARIADOS OU VENCIDOS / IDENTIFICADOS COM OS ITENS EM NOTA FISCAL / NÃO REALIZAR TROCA SE ESTIVER COM PRODUTOS FALTANDO";
                        }
                        if (troca == "")
                            troca = "0";
                        if (bonificacao == "")
                            bonificacao = "0";
                        if(bonificacao == "1")
                            condPgto = "2 - OUTROS";
                        if (venda_direta == "")
                        {
                            venda_direta = "0";
                        }
                        if (venda_direta == "1")
                        {
                            //condPgto = "0 - A Vista";
                            fechado = "1";
                        }


                       
                    }
                    catch { }
                    idLog = idPedido;
                    try
                    {
                        Convert.ToDouble(totalProdutoPedido);
                        totalProdutoPedido = "'" + totalProdutoPedido + "'";
                    }
                    catch { }
                    try
                    {
                        Convert.ToDouble(totalPedido);
                        if (totalPedido != "")
                            totalPedido = "'" + totalPedido + "'";
                    }
                    catch { }
                    try
                    {
                        Convert.ToDouble(totalDescontoPedido);
                        if (totalDescontoPedido != "")
                            totalDescontoPedido = "'" + totalDescontoPedido + "'";
                    }
                    catch { }
                    try
                    {
                        Convert.ToInt32(codVendedorPedido);
                        if (codVendedorPedido != "")
                            codVendedorPedido = "'" + codVendedorPedido + "'";
                    }
                    catch { }
                    try
                    {
                        Convert.ToInt32(idClientePedido);
                        if (idClientePedido != "")
                            idClientePedido = "'" + idClientePedido + "'";
                    }
                    catch { }
                    try
                    {
                        Convert.ToInt32(qtdeItens);
                        if (qtdeItens != "")
                            qtdeItens = "'" + qtdeItens + "'";
                    }
                    catch { }
                    try
                    {
                        Convert.ToDateTime(dataEntrega);
                        if (dataEntrega != "")
                            dataEntrega = "'" + dataEntrega.Replace("/", ".") + "'";
                    }
                    catch { dataEntrega = "null"; }
                    string id =  "";
                    double _total = 0;
                    try
                    {
                        _total = Convert.ToDouble(dr["totalPedido"].ToString().Replace(".", ","));
                    }
                    catch { }
                    if (_total > 0)
                    {                  
                        if (verificaPedidoUnico(idPedido, codUsuario, cnpjPedido, out id, cod_web, totalPedido))
                        {
                            FbCommand insert = new FbCommand();
                            FbConnection conexao = new FbConnection();
                            try
                            {
                                if (id != "")
                                {
                                    FbCommand delete = new FbCommand();
                                    delete.CommandText =
                                        "DELETE FROM PEDIDOS_VENDA WHERE ID_PEDIDO_CEL_PED_VENDA = " + idPedido + " AND COD_VENDEDOR_PED_VENDA = " + codUsuario;
                                    conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                    delete.Connection = conexao;
                                    conexao.Open();
                                    delete.ExecuteNonQuery();
                                    log += DateTime.Now.ToString() + ": Exportar Pedidos Delete Pedido Venda = " + delete.CommandText + "\r\n";
                                    conexao.Close();// conexao.Dispose();

                                    FbCommand deleteItem = new FbCommand();
                                    deleteItem.CommandText =
                                        "DELETE FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = " + id;
                                    conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                    deleteItem.Connection = conexao;
                                    conexao.Open();
                                    deleteItem.ExecuteNonQuery();
                                    conexao.Close(); //conexao.Dispose();
                                    log += DateTime.Now.ToString() + ": Exportar Pedidos Delete Item Pedido Venda = " + deleteItem.CommandText + "\r\n";
                                }
                            }
                            catch (Exception a)
                            {
                                conexao.Close(); //conexao.Dispose();
                            }
                            object id_pedido = new object();
                            try
                            {
                                string _porc_desconto = "null";
                                if (desconto_valor_nota == "1" && porc_desconto > 0)
                                {
                                    _porc_desconto = "'" + porc_desconto.ToString().Replace(".","").Replace(",", ".") + "'";
                                }
                                string ultimo_pedido = buscar_ultimo_pedido_empresa(cnpj_empresa);
                                int proximo_pedido = 0;
                               
                                if (proximo_pedido == 0)
                                {
                                    proximo_pedido = Convert.ToInt32(ultimo_pedido) + 1;
                                }
                                // tb_n_ped_novo.Text = proximo_pedido.ToString();
                                insert.Connection = conexao;
                                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                insert.CommandText =
                                     "INSERT INTO PEDIDOS_VENDA " +
                                    "(DATA_PED_VENDA," +
                                    "HORA_PED_VENDA , " +
                                    "CLIENTE_PED_VENDA, " +
                                    "CNPJ_PED_VENDA, " +
                                    "VALOR_TOTAL_PROD_PED_VENDA, " +
                                    "VALOR_TOTAL_PED_VENDA, " +
                                    "VALOR_DESCONTO_PED_VENDA, " +
                                    "VENDEDOR_PED_VENDA, " +
                                    "COD_VENDEDOR_PED_VENDA, " +
                                    "ID_PEDIDO_CEL_PED_VENDA, " +
                                    "QTDE_ITENS_PED_VENDA, " +
                                    "DATA_ENTREGA_PED_VENDA, " +
                                    "COND_PGTO_PED_VENDA, " +
                                    "OBS_PED_VENDA, " +
                                    "BONIFICACAO_PED_VENDA, " +
                                    "TROCA_PED_VENDA, " +
                                     "VENDA_DIRETA_PED_VENDA, " +
                                    "BAIXADO_ESTOQUE_PED_VENDA, COD_LRW_PED_VENDA, " +
                                    "PORC_DESCONTO_PED_VENDA, PV_PED_VENDA, " +
                                    "BOLETO_VD_PED_VENDA, NF_VD_PED_VENDA, COD_WEB_PED_VENDA, " +
                                    "LATITUDE_PED_VENDA, LONGITUDE_PED_VENDA, COD_TP_PED_VENDA, DESCRICAO_TP_PED_VENDA, N_PED_VENDA, CNPJ_EMISSOR_PED_VENDA, RAZAO_EMISSOR_PED_VENDA)" +
                                    "VALUES ('" + dataPedido + "'," +
                                    "" + horaPedido + ", " +
                                    "'" + clientePedido.Replace("'", "") + "'," +
                                    "'" + cnpjPedido.Replace("'", "") + "'," +
                                    totalProdutoPedido + "," +
                                    totalPedido + "," +
                                    totalDescontoPedido + "," +
                                    "'" + nomeVendedorPedido + "'," +
                                    codUsuario + ", " +
                                    "'" + idPedido + "', " +
                                    qtdeItens + ", " +
                                    dataEntrega + ", " +
                                    "'" + condPgto + "', " +
                                    "'" + obsPedido + "'," +
                                    bonificacao + "," +
                                    troca + "," +
                                    venda_direta + "," +
                                    fechado + "," + cod_lrw.ToString() + "," + _porc_desconto + "," +
                                    pv + "," + boleto_vd + "," +
                                    nf_vd_ped_venda + "," + cod_web_ped_venda + "," +
                                    latitude + "," + longitude + "," + cod_tp + "," + descricao_tp + "," + ultimo_pedido + ",'" + cnpj_empresa + "','" + razao_social_empresa + "') RETURNING COD_PED_VENDA";
                                conexao.Open();
                                log += DateTime.Now.ToString() + ": Exportar Pedidos Insert Pedido Venda = " + insert.CommandText + "\r\n";
                                id_pedido = insert.ExecuteScalar();
                                conexao.Close(); //conexao.Dispose();
                                //pedidosOk += idPedido + ";";

                                if (venda_direta == "1")
                                { //inserir duplicatas
                                    inserir_nova_forma_pgto(condPgto, id_pedido.ToString(), totalPedido, dataPedido);
                                    inserir_duplicatas_cr(id_pedido.ToString(), condPgto, cod_web_ped_venda, cnpjPedido.Replace("'", ""), clientePedido.Replace("'", ""), codUsuario);
                                }
                                try
                                {
                                    foreach (DataRow dr2 in ds.Tables["modelo.ItensPedido"].Rows)
                                    {
                                        System.Threading.Thread.Sleep(150);
                                        BackgroundWorker worker = new BackgroundWorker();

                                        worker.DoWork += new DoWorkEventHandler(
                                            delegate(object senderDoWord, DoWorkEventArgs eDoWork)
                                            {

                                                string idItemPedido = "null", idPedidoItem = "null", idProduto = "null", nomeProduto = "", unidadeProduto = "",
                                                    qtdeItem = "null", valorUnitarioItem = "null", valorTotalItem = "null", porcItem = "null";


                                                int baixado = 0, _venda_direta = 0;
                                                try
                                                {
                                                    idItemPedido = dr2["idItemPedido"].ToString();
                                                    idPedidoItem = dr2["idPedido"].ToString();
                                                    idProduto = dr2["idProduto"].ToString();
                                                    nomeProduto = dr2["nomeProduto"].ToString();
                                                    unidadeProduto = dr2["unidadeProduto"].ToString();
                                                    qtdeItem = dr2["qtdeItem"].ToString();

                                                    valorUnitarioItem = dr2["valorUnitarioItem"].ToString();
                                                    valorTotalItem = dr2["valorTotalItem"].ToString();


                                                    porcItem = dr2["porcItem"].ToString();

                                                    try
                                                    {
                                                        Convert.ToInt32(idItemPedido);
                                                        if (idItemPedido != "")
                                                            idItemPedido = "'" + idItemPedido + "'";
                                                    }
                                                    catch { }
                                                    try
                                                    {
                                                        Convert.ToInt32(idProduto);
                                                        if (idProduto != "")
                                                            idProduto = "'" + idProduto + "'";
                                                    }
                                                    catch { }
                                                    try
                                                    {
                                                        Convert.ToInt32(qtdeItem);
                                                        if (qtdeItem != "")
                                                            qtdeItem = "'" + qtdeItem + "'";
                                                    }
                                                    catch { }
                                                    try
                                                    {
                                                        Convert.ToDouble(valorUnitarioItem);
                                                        if (valorUnitarioItem != "")
                                                            valorUnitarioItem = "'" + valorUnitarioItem + "'";
                                                    }
                                                    catch { }
                                                    try
                                                    {
                                                        Convert.ToDouble(valorTotalItem);
                                                        if (valorTotalItem != "")
                                                            valorTotalItem = "'" + valorTotalItem + "'";
                                                    }
                                                    catch { }
                                                    try
                                                    {
                                                        Convert.ToDouble(porcItem);
                                                        if (porcItem != "")
                                                            porcItem = "'" + porcItem + "'";
                                                    }
                                                    catch { porcItem = "null"; }

                                                    string idPedidoSistema = id_pedido.ToString();


                                                    if (baixado == 0 && idPedidoSistema != "")
                                                    {
                                                        FbCommand insertItem = new FbCommand();
                                                        FbConnection _conexao = new FbConnection();
                                                        try
                                                        {
                                                            int kit = buscar_kit(idProduto);
                                                            if (kit == 1)
                                                            {
                                                                try
                                                                {
                                                                    FbCommand select = new FbCommand();
                                                                    _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                                                    select.Connection = _conexao;
                                                                    select.CommandText =
                                                                        "SELECT * FROM PRODUTOS_KIT WHERE COD_KIT_PK = " + idProduto +  "";
                                                                    _conexao.Open();
                                                                    FbDataAdapter datSelect = new FbDataAdapter();
                                                                    datSelect.SelectCommand = select;
                                                                    DataTable dtSelect = new DataTable();
                                                                    datSelect.Fill(dtSelect);
                                                                    _conexao.Close();
                                                                    foreach (DataRow dr_kit in dtSelect.Rows)
                                                                    {
                                                                        try
                                                                        {
                                                                            idProduto = idProduto.Replace("'", "");
                                                                            idItemPedido = dr2["idItemPedido"].ToString();
                                                                            idPedidoItem = dr2["idPedido"].ToString();
                                                                            string _idProduto = dr_kit["COD_PRODUTO_PK"].ToString();
                                                                            nomeProduto = dr_kit["DESCRICAO_PK"].ToString();

                                                                            qtdeItem = dr_kit["QTDE_PK"].ToString();
                                                                            double qtde_item = Convert.ToDouble(qtdeItem.Replace(".", ",")) * Convert.ToDouble(dr2["qtdeItem"].ToString().Replace(".", ","));
                                                                            qtdeItem = qtde_item.ToString("n2").Replace(".","").Replace(",", ".");
                                                                            valorUnitarioItem = dr_kit["VALOR_UNIT_PK"].ToString();
                                                                            try
                                                                            {
                                                                                double valor_item = Convert.ToDouble(qtdeItem.Replace(".", ",")) * Convert.ToDouble(valorUnitarioItem);
                                                                                valorTotalItem = valor_item.ToString();
                                                                            }
                                                                            catch { }


                                                                            //porcItem = dr2["porcItem"].ToString();

                                                                            try
                                                                            {
                                                                                Convert.ToInt32(idItemPedido);
                                                                                if (idItemPedido != "")
                                                                                    idItemPedido = "'" + idItemPedido + "'";
                                                                            }
                                                                            catch { }
                                                                            try
                                                                            {
                                                                                Convert.ToInt32(idProduto);
                                                                                if (idProduto != "")
                                                                                    idProduto = "'" + idProduto + "'";
                                                                            }
                                                                            catch { }
                                                                            try
                                                                            {
                                                                                Convert.ToDouble(qtdeItem);
                                                                                if (qtdeItem != "")
                                                                                    qtdeItem = "'" + qtdeItem + "'";
                                                                            }
                                                                            catch { }
                                                                            try
                                                                            {
                                                                                Convert.ToDouble(valorUnitarioItem);
                                                                                if (valorUnitarioItem != "")
                                                                                    valorUnitarioItem = "'" + Convert.ToDouble(valorUnitarioItem).ToString().Replace(".","").Replace(",", ".") + "'";
                                                                            }
                                                                            catch { }
                                                                            try
                                                                            {
                                                                                Convert.ToDouble(valorTotalItem);
                                                                                if (valorTotalItem != "")
                                                                                    valorTotalItem = "'" + Convert.ToDouble(valorTotalItem).ToString().Replace(".","").Replace(",", ".") + "'";
                                                                            }
                                                                            catch { }
                                                                            try
                                                                            {
                                                                                Convert.ToDouble(porcItem);
                                                                                if (porcItem != "")
                                                                                    porcItem = "'" + porcItem + "'";
                                                                            }
                                                                            catch { porcItem = "null"; }

                                                                            string _dun, _qtde, _cnpj, _cod_fornecedor;
                                                                            double custo = 0;
                                                                            string unidade = "UN";
                                                                            string ean = buscar_ean_produto(_idProduto, out _dun, out _qtde, out _cnpj, out _cod_fornecedor, out custo, out unidade);
                                                                            if (ean != "null")
                                                                                ean = "'" + ean + "'";



                                                                            double custo_produto = 0;
                                                                            try
                                                                            {
                                                                                custo_produto = custo * Convert.ToDouble(qtdeItem.Replace(".", ",").Replace("'", ""));
                                                                            }
                                                                            catch { }

                                                                            string cod_kit_promocao_item_venda = idProduto;

                                                                            try
                                                                            {
                                                                                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                                                                insertItem.Connection = _conexao;
                                                                                insertItem.CommandText =
                                                                                    "INSERT INTO ITENS_PEDIDO_VENDA " +
                                                                                    "(QTDE_ITEM_VENDA," +
                                                                                    "DESCRICAO_PROD_ITEM_VENDA, " +
                                                                                    "VALOR_UNIT_PROD_ITEM_VENDA, " +
                                                                                    "VALOR_TOTAL_PROD_ITEM_VENDA, " +
                                                                                    "UNIDADE_PROD_ITEM_VENDA, " +
                                                                                    "COD_PEDIDO_ITEM_VENDA, " +
                                                                                    "COD_VENDEDOR_ITEM_VENDA, " +
                                                                                    "COD_SISTEMA_PROD_ITEM_VENDA, " +
                                                                                    "PORC_DESC_ITEM_VENDA, EAN_ITEM_VENDA, CUSTO_ITEM_VENDA, COD_PROD_ITEM_VENDA, COD_KIT_PROMOCAO_ITEM_VENDA) " +
                                                                                    "VALUES (" + qtdeItem + "," +
                                                                                    "'" + nomeProduto + "'," +
                                                                                    valorUnitarioItem + "," +
                                                                                    valorTotalItem + "," +
                                                                                    "'" + unidade + "'," +
                                                                                    idPedidoSistema + "," +
                                                                                    codUsuario + "," +
                                                                                    _idProduto + ", " +
                                                                                    porcItem + "," + ean + "," +
                                                                                    custo_produto.ToString("n2").Replace(".","").Replace(",", ".") + ",'" +
                                                                                    _cod_fornecedor + "'," +
                                                                                    cod_kit_promocao_item_venda + ")";
                                                                                _conexao.Open();
                                                                                log += DateTime.Now.ToString() + ": Exportar Pedidos Insert Item Pedido Venda = " + insertItem.CommandText + "\r\n";
                                                                                insertItem.ExecuteNonQuery();
                                                                                _conexao.Close();
                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                MessageBox.Show(ex.ToString());
                                                                                // return false; 
                                                                            }
                                                                        }
                                                                        catch (Exception ex)
                                                                        {
                                                                            MessageBox.Show(ex.ToString());
                                                                        }
                                                                    }
                                                                }
                                                                catch (Exception ex)
                                                                {
                                                                    MessageBox.Show(ex.ToString());
                                                                }
                                                            }
                                                            else
                                                            {
                                                                string _dun, _qtde, _cnpj, _cod_fornecedor;
                                                                double custo = 0;
                                                                string unidade = "UN";
                                                                string ean = buscar_ean_produto(idProduto, out _dun, out _qtde, out _cnpj, out _cod_fornecedor, out custo, out unidade);
                                                                if (ean != "null")
                                                                    ean = "'" + ean + "'";



                                                                double custo_produto = 0;
                                                                try
                                                                {
                                                                    custo_produto = custo * Convert.ToDouble(qtdeItem.Replace(".", ","));
                                                                }
                                                                catch { }



                                                                try
                                                                {
                                                                    _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                                                    insertItem.Connection = _conexao;
                                                                    insertItem.CommandText =
                                                                        "INSERT INTO ITENS_PEDIDO_VENDA " +
                                                                        "(QTDE_ITEM_VENDA," +
                                                                        "DESCRICAO_PROD_ITEM_VENDA, " +
                                                                        "VALOR_UNIT_PROD_ITEM_VENDA, " +
                                                                        "VALOR_TOTAL_PROD_ITEM_VENDA, " +
                                                                        "UNIDADE_PROD_ITEM_VENDA, " +
                                                                        "COD_PEDIDO_ITEM_VENDA, " +
                                                                        "COD_VENDEDOR_ITEM_VENDA, " +
                                                                        "COD_SISTEMA_PROD_ITEM_VENDA, " +
                                                                        "PORC_DESC_ITEM_VENDA, EAN_ITEM_VENDA, CUSTO_ITEM_VENDA, COD_PROD_ITEM_VENDA) " +
                                                                        "VALUES (" + qtdeItem + "," +
                                                                        "'" + nomeProduto + "'," +
                                                                        valorUnitarioItem + "," +
                                                                        valorTotalItem + "," +
                                                                        "'" + unidade + "'," +
                                                                        idPedidoSistema + "," +
                                                                        codUsuario + "," +
                                                                        idProduto + ", " +
                                                                        porcItem + "," + ean + "," +
                                                                        custo_produto.ToString("n2").Replace(".","").Replace(",", ".") + ",'" + _cod_fornecedor + "')";
                                                                    _conexao.Open();
                                                                    log += DateTime.Now.ToString() + ": Exportar Pedidos Insert Item Pedido Venda = " + insertItem.CommandText + "\r\n";
                                                                    insertItem.ExecuteNonQuery();
                                                                    _conexao.Close(); _conexao.Dispose();
                                                                }
                                                                catch (Exception ex)
                                                                {
                                                                    MessageBox.Show(ex.ToString());
                                                                    // return false; 
                                                                }
                                                            }

                                                            log += "atualizar codigo \r\n";
                                                            string log2 =  "";
                                                            // atualizarCodFornecedorPedido(idPedidoSistema, idProduto, out log2);
                                                            /*
                                                            try
                                                            {
                                                                classeEstoque estoque = new classeEstoque();
                                                                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                                                estoque.calcular_estoque(_dun, ean.Replace("'", ""), _qtde, _cnpj, idProduto);
                                                            }
                                                            catch { }
                                                            */
                                                            log += log2;
                                                            log += "inseriu item \r\n";
                                                        }
                                                        catch (Exception a)
                                                        {

                                                            _conexao.Close(); _conexao.Dispose();
                                                            //return false;
                                                        }
                                                    }
                                                }
                                                catch (Exception a)
                                                {
                                                    //  return false;
                                                }
                                            });
                                        worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                                            delegate(object senderRunWorkerCompleted, RunWorkerCompletedEventArgs eRunWorkerCompleted)
                                            {
                                            });
                                        worker.RunWorkerAsync();

                                    }

                                }
                                catch (Exception a)
                                {
                                    conexao.Close(); conexao.Dispose();
                                    return false;
                                }
                            }
                            catch (Exception a)
                            {
                                conexao.Close(); conexao.Dispose();
                                return false;
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Pedido: " + idPedido  +  " do vendedor: " + codUsuario + " já existente no sistema");
                            pedido_repetido = true;
                            return false;
                        }

                    }
                    else
                    { //justificativas de não venda
                        if (dr["naoVendaJustificativa"].ToString() != "")
                        {
                            try
                            {
                                string naoVenda = "", contato = "", obs = "", cliente = "", cnpj = "", cod_vendedor = "", nome_vendedor = "";
                                int id_pedido = 0;
                                DateTime data = DateTime.Now;
                                try
                                {
                                    naoVenda = dr["naoVendaJustificativa"].ToString();
                                }
                                catch { }
                                try
                                {
                                    contato = dr["contatoJustificativa"].ToString();
                                }
                                catch { }
                                try
                                {
                                    obs = dr["obsJustificativa"].ToString();
                                }
                                catch { }
                                try
                                {
                                    cliente = dr["clientePedido"].ToString();
                                }
                                catch { }
                                try
                                {
                                    cnpj = dr["cnpjPedido"].ToString();
                                }
                                catch { }
                                try
                                {
                                    cod_vendedor = dr["codVendedorPedido"].ToString();
                                }
                                catch { }
                                try
                                {
                                    nome_vendedor = dr["nomeVendedorPedido"].ToString();
                                }
                                catch { }
                                try
                                {
                                    id_pedido = Convert.ToInt32(dr["idClientePedido"].ToString());
                                }
                                catch { }
                                try
                                {
                                    data = Convert.ToDateTime(dr["dataPedido"].ToString().Replace(".", "/"));
                                }
                                catch { }
                                try
                                {
                                    string _hora = dr["horaPedido"].ToString();
                                    horaPedido = "'" + Convert.ToDateTime(_hora).ToShortTimeString() + "'";
                                }
                                catch { }


                                FbConnection _conexao = new FbConnection();
                                FbCommand insert = new FbCommand();
                                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                insert.Connection = _conexao;
                                _conexao.Open();
                                insert.CommandText =
                                    "INSERT INTO MOTIVO_NAO_VENDA (DATA_MNV, HORA_MNV, ID_WEB_MNV, COD_VENDEDOR_MNV, NOME_VENDEDOR_MNV, MOTIVO_NAO_VENDA_MNV, CONTATO_MNV, OBSERVACOES_MNV, " +
                                    "CNPJ_CLIENTE_MNV, RAZAO_SOCIAL_CLIENTE_MNV, LATITUDE_MNV, LONGITUDE_MNV, COD_WEB_MNV) VALUES ('" +
                                    data.ToShortDateString().Replace("/", ".") + "'," + horaPedido + ",'" + id_pedido.ToString() + "','" + cod_vendedor + "','" + nome_vendedor + "','" +
                                    naoVenda + "','" + contato + "','" + obs + "','" + cnpj + "','" + cliente + "'," + latitude + "," + longitude + "," + cod_web_ped_venda + ")";
                                FbDataAdapter datInsert = new FbDataAdapter();
                                datInsert.InsertCommand = insert;
                                datInsert.InsertCommand.ExecuteNonQuery();
                                _conexao.Close();
                                return true;

                            }
                            catch
                            {

                                return true;

                            }
                        }
                        else
                            return true;
                    }
                }

                return true;
            }
            catch { return false; }
        }

        private void update_latitude_longitude(string cnpjPedido, string latitude, string longitude)
        {
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";

                FbCommand update = new FbCommand();
                update.Connection = _conexao;
                update.CommandText = "UPDATE CLIENTES SET LATITUDE_CLIENTE = '" + latitude + "', LONGITUDE_CLIENTE = '" + longitude + "' WHERE CNPJ = '" + cnpjPedido + "'";
                _conexao.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand.ExecuteNonQuery();
                _conexao.Close();
                _conexao.Dispose();


            }
            catch (Exception ex)
            {
                //fbConnection1.Close();
            }
        }

        private void verificar_se_cliente_tem_localizacao(string cnpjPedido, string latitude, string longitude)
        {
           
           
        }

        private void insere_fatura(string prazo, string data, string valor, string nf)
        {
            try
            {
                 FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                FbCommand update = new FbCommand();
                update.Connection = _conexao;
                update.CommandText =                 
                       "INSERT INTO FATURA_PEDIDO (PRAZO_FATURA_PED, DATA_VENC_FATURA_PED, VALOR_FATURA_PED, N_PEDIDO_FATURA_PED)" +
                        "VALUES ('" + prazo + "','" + data + "','" + valor + "','" + nf + "')";
                _conexao.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                _conexao.Close();
            }
            catch
            {
                //fbConnection1.Close();
                MessageBox.Show("erro na inserção da fatura do Pedido " + nf);
            }


        }

        
        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
          string prazo_4, string prazo_5, string prazo_6, string dataPedido, string totalProdutos, string n_pedido)
        {

            int numero_parcelas = 0;
            DateTime hoje = Convert.ToDateTime(dataPedido);// DateTime.Now;
            //hoje = DateTime.Now;
            try
            {
                numero_parcelas = Convert.ToInt32(n_parcelas);
            }
            catch
            {
                numero_parcelas = 0;
                //MessageBox.Show("Número de parcelas incorreto");
            }

            double valor = 0;
            try
            {
                if (numero_parcelas > 0)
                    valor = Convert.ToDouble(totalProdutos.Replace(".","").Replace(".", ",")) / numero_parcelas;
            }
            catch
            {

            }
            switch (numero_parcelas)
            {

                case 1:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        break;
                    }

                case 2:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        break;
                    }
                case 3:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        break;
                    }
                case 4:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        break;
                    }
                case 5:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        break;
                    }
                case 6:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        prazo = Convert.ToDouble(prazo_6);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), n_pedido);
                        break;
                    }



            }
        }

        private void inserir_nova_forma_pgto(string ja_escolhida, string n_pedido, string totalProduto, string dataPedido)
        {
            if (totalProduto != "")
            {

                form_forma_pgto localiza_forma = new form_forma_pgto();
                try
                {
                    localiza_forma.forma_pgto_ja_escolhida = ja_escolhida;
                    localiza_forma.busca_forma_escolhida = true;
                    localiza_forma.ShowDialog();
                }
                finally
                {
                    localiza_forma.Dispose();
                    //MessageBox.Show(localiza_peca.peca_escolhida);
                    //tb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
                   // apaga_faturas_anteriores();
                    acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                    localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6, dataPedido, totalProduto, n_pedido);
                }

            }
            else
                MessageBox.Show("Calcule o valor da Nota antes de inserir a forma de pagamento.");
        }

        private void detectar_numero_vencimentos_fatura(out int n_venc, string n_pedido)
        {
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = _conexao;
                comando_select.CommandText = "SELECT * " +
                    "FROM FATURA_PEDIDO WHERE N_PEDIDO_FATURA_PED = '" + n_pedido + "'";
                DataSet fatura = new DataSet();
                _conexao.Open();
                FbDataAdapter datFatura_nf = new FbDataAdapter();
                datFatura_nf.SelectCommand = comando_select;
                datFatura_nf.Fill(fatura);
                int n = 0;
                foreach (DataRow dr in fatura.Tables[0].Rows)
                {

                    _cod[n] = dr["COD_FATURA_PED"].ToString();
                    _valores[n] = dr["VALOR_FATURA_PED"].ToString();
                    _datas[n] = dr["DATA_VENC_FATURA_PED"].ToString();
                    n++;

                }

                _conexao.Close();
                n_venc = n;
            }
            catch
            {
               // fbConnection1.Close();
                n_venc = 0;
            }

        }

        private string buscar_tipo(string p)
        {
            string tipo =  "";
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand sel = new FbCommand();
                FbDataAdapter datSel = new FbDataAdapter();
                DataTable dt = new DataTable();
                sel.CommandText =
                    "SELECT TIPO_FORMA_PGTO FROM FORMA_PGTO WHERE DESCRICAO_FORMA_PGTO = '" + p + "'";
                sel.Connection = _conexao;
                datSel.SelectCommand = sel;
                _conexao.Open();
                datSel.Fill(dt);
                _conexao.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    tipo = dr[0].ToString();
                }
                return tipo;
            }
            catch (Exception a)
            {
               // fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return tipo;
            }
        }

        string[] _datas = new string[50];
        string[] _valores = new string[50];
        string[] _cod = new string[50];

        private void inserir_duplicatas_cr(string n_pedido, string condPgto, string codWeb, string cnpj_cliente, string nome_cliente, string cod_vendedor)
        {
            //apagar_itens_cr(cod_pedido);
            int _n_vencimentos;
            string forma_pgto =  "";

            //a parada é 6 pois é o numero máximo de parcelas
            for (int i = 0; i < 6; i++)
            {
                _cod[i] =  ""; _datas[i] =  ""; _valores[i] =  "";
            }
            detectar_numero_vencimentos_fatura(out _n_vencimentos, n_pedido);

            for (int i = 0; i < _n_vencimentos; i++)
            {

                string tipo = buscar_tipo(condPgto);
                bool continuar = true;
              
                if (continuar)
                {
                    try
                    {


                        FbConnection _conexao = new FbConnection();
                        _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                

                        int parcela_n = i + 1;
                        FbCommand insert = new FbCommand();
                        insert.Connection = _conexao;
                        insert.CommandText =
                        "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                        "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, NF_CR, TIPO_CR, SERIE_CR, CC_CR, DESCRICAO_CC_CR, FORMA_PGTO_CR, COD_WEB_CR) " +
                        "VALUES ('" + _valores[i].Replace(".","").Replace(",", ".") + "', '" + Convert.ToDateTime(_datas[i]).ToShortDateString().Replace("/", ".") +
                        "', '" + detectar_cod_cliente(cnpj_cliente) + "','" + nome_cliente +
                        "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. AO PEDIDO Nº " + n_pedido +
                        "', '" + parcela_n.ToString() + "','" + n_pedido + "','" + tipo + "','" + cod_vendedor + "','" + _cod_interno_banco + "','" +
                        _descricao_banco + "','" + condPgto + "'," + codWeb + ")";
                        _conexao.Open();
                        FbDataAdapter datInsert = new FbDataAdapter();
                        datInsert.InsertCommand = insert;
                        datInsert.InsertCommand.ExecuteNonQuery();
                        _conexao.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro na inserção da duplicata " + _cod[i].ToString() + ". " + ex.Message);
                       // fbConnection1.Close();
                    }
                }
            }

        }

        private string detectar_cod_cliente(string _cnpj)
        {
            string _cod = "0";
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = _conexao;
                comando_select.CommandText = "SELECT * " +
                    "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
                DataSet nf = new DataSet();
                _conexao.Open();
                FbDataAdapter datClientes = new FbDataAdapter();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(nf);
                int n = 0;
                foreach (DataRow dr in nf.Tables[0].Rows)
                {
                    _cod = dr["COD_CLIENTE"].ToString();
                }
                _conexao.Close();
                return _cod;
            }
            catch
            {
                //fbConnection1.Close();
                return _cod;
            }

        }

        private double buscar_custo(string idProduto)
        {
            double retorno = 0;
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand select = new FbCommand();
                select.Connection = _conexao;
                select.CommandText =
                    "SELECT CUSTO_PRODUTO from produtos WHERE COD_PRODUTO = " + idProduto +  "";
                _conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                _conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try { retorno = Convert.ToDouble(dr[0].ToString()); }
                    catch { }
                }
                return retorno;
            }
            catch (Exception a)
            {
               // fbConnection1.Close();
                return 0;
            }
        }

        private int buscar_kit(string idProduto)
        {
            int retorno = 0;
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                FbCommand select = new FbCommand();
                select.Connection = _conexao;
                select.CommandText =
                    "SELECT KIT_PROMOCIONAL_PRODUTO from produtos WHERE COD_PRODUTO = " + idProduto +  "";
                _conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                _conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try { retorno = Convert.ToInt32(dr[0].ToString()); }
                    catch { }
                }
                return retorno;
            }
            catch (Exception a)
            {
                //fbConnection1.Close();
                return 0;
            }
        }

        private double buscar_tabela_preco(string cod, string cnpj)
        {

            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand select = new FbCommand(); select.Connection = _conexao;
                select.CommandText =
                    "SELECT PRECO_PRODUTO_ITEM_TP FROM ITENS_TP itens " +
                    "INNER JOIN CLIENTES cli ON itens.COD_TABELA_ITEM_TP = cli.COD_TP_CLIENTE " +
                    " WHERE COD_PRODUTO_ITEM_TP = '" + cod + "' and cli.CNPJ = '" + cnpj + "'";
                select.Connection = _conexao;
                _conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                _conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double preco = 0;
                    try
                    {
                        preco = Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                    return preco;
                }
                return 0;
            }
            catch (Exception a)
            {
               // _conexao.Close();
                return 0;
            }
        }

        private string buscar_ean_produto(string idProduto, out string dun, out string qtde, out string cnpj,
            out string cod_fornecedor, out double custo, out string unidade)
        {
            dun =  ""; qtde =  ""; cnpj =  ""; cod_fornecedor =  ""; custo = 0; unidade = "UN";
            string retorno = "null";FbConnection conexao = new FbConnection();
            try
            {
                FbCommand select = new FbCommand();
                
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, QTDE_UNIDADE_PRODUTO, " +
                    "CNPJ_FORNECEDOR_PRODUTO, COD_FORNECEDOR_PRODUTO, CUSTO_PRODUTO, COD_UNIDADE_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = " + idProduto +  "";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        unidade = dr["COD_UNIDADE_PRODUTO"].ToString();
                    }
                    catch { }
                    dun = dr[1].ToString(); qtde = dr[2].ToString(); cnpj = dr[3].ToString();
                    cod_fornecedor = dr[4].ToString();
                    try
                    {
                        custo = Convert.ToDouble(dr[5].ToString());
                    }
                    catch { }
                    if(dr[0].ToString() != "")
                        return dr[0].ToString();

                    
                }
                return retorno;
            }
            catch
            {
                conexao.Close(); conexao.Dispose();
                return retorno;
            }
        }

        private string buscar_estado_empresa(string campo)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT " + campo + " FROM EMPRESA";
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return  "";
            }
            catch { return  ""; }

        }

        private void inserir_vendedor_cliente(string _cnpj, string codUsuario)
        {
            try
            {
                string codigoCliente = buscar_cod_cliente(_cnpj);
                string nomeVendedor = buscar_nome_vendedor(codUsuario);
                
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                FbCommand insereVendedor = new FbCommand();
                insereVendedor.CommandText =
                     "INSERT INTO vendedores_cliente (cod_cliente_vc, cod_vendedor_vc, nome_vendedor_vc) VALUES ('" + codigoCliente + "', " + codUsuario + ", '" + nomeVendedor + "')";
                FbDataAdapter datVendedores = new FbDataAdapter();
                datVendedores.InsertCommand = insereVendedor;
                datVendedores.InsertCommand.Connection = conexao;
                conexao.Open();
                datVendedores.InsertCommand.ExecuteNonQuery();
                conexao.Close(); conexao.Dispose();
            }
            catch (Exception a)
            {
                
            }

        }

        private string buscar_nome_vendedor(string codUsuario)
        {
            try
            {
                FbCommand select = new FbCommand();
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT NOME_VENDEDOR FROM VENDEDORES WHERE COD_VENDEDOR = " + codUsuario +  "";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return  "";

            }

            catch { return  ""; }
        }

        private string buscar_cod_cliente(string _cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_CLIENTE FROM CLIENTES WHERE CNPJ = " + _cnpj +  "";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return  "";

            }

            catch { return  ""; }
        }

        private string buscar_cod_mun(string _cidade)
        {
            try
            {

                foreach (DataRow dr in theDS.Tables[0].Select("F3 = " + _cidade.ToUpper().Replace("\t", "") + ""))
                {
                    return dr[1].ToString();
                }
                
                return  "";
            }
            catch {
                return  "";
            }
        }

        public void atualizarCodFornecedorPedido(string codPedido, string codProduto, out string log2)
        {
            log2 =  "";
            FbConnection conexao = new FbConnection();
            try
            {
                string codFornecedor =  "";
                FbCommand select = new FbCommand();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_FORNECEDOR_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = " + codProduto +  "";
                log2 += select.CommandText;
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();

                datSelect.Fill(dsSelect);
                conexao.Close(); //conexao.Dispose();
                DataRow drProduto = dsSelect.Tables[0].Rows[0];
                codFornecedor = "'" + drProduto[0].ToString() + "'";
                if (codFornecedor != "")
                {
                    FbCommand insertItem = new FbCommand();
                    try
                    {
                        insertItem.Connection = conexao;
                        conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                        insertItem.CommandText =
                            "UPDATE ITENS_PEDIDO_VENDA SET COD_PROD_ITEM_VENDA = " + codFornecedor +
                            " WHERE COD_SISTEMA_PROD_ITEM_VENDA = " + codProduto + " AND COD_PEDIDO_ITEM_VENDA = " + codPedido +  "";
                        conexao.Open();
                        insertItem.ExecuteNonQuery();
                        conexao.Close(); conexao.Dispose();
                    }
                    catch (Exception a)
                    {
                        log2 += "erro update codForn: " + a.Message;
                        conexao.Close(); conexao.Dispose();
                    }
                }
            }
            catch (Exception a)
            {
                log2 += "erro select codForn: " + a.Message;
                conexao.Close(); conexao.Dispose();
            }
        }
        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                   out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                   out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                   out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
           out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, 
            out string saida_estoque_pedido_empresa, out string cod_forn_empresa, out string cliente_inadimplente_empresa)
        {
            razao_social_empresa =  ""; nome_fantasia_empresa =  ""; cnpj_empresa =  ""; ie_empresa =  ""; im_empresa =  ""; cnae_empresa =  ""; endereco_empresa =  ""; n_endereco_empresa =  "";
            complemento_empresa =  ""; bairro_empresa =  ""; cidade_empresa =  ""; estado_empresa =  ""; cep_empresa =  ""; telefone_empresa =  ""; cod_cidade_empresa =  ""; pais_empresa =  "";
            cod_pais_empresa =  ""; licenca_dll_nfe_empresa =  ""; nome_certificado_nfe_empresa =  ""; assunto_nfe_email_empresa =  ""; smtp_nfe_empresa =  ""; email_nfe_empresa =  "";
            senha_email_nfe_empresa =  ""; logotipo_empresa =  ""; proxy_empresa =  ""; usuario_proxy_empresa =  ""; senha_proxy_empresa =  ""; crt_empresa =  ""; portaEmailEmpresa =  "";
            sslEmpresa =  ""; serie_empresa =  ""; boleto_pedido_empresa =  ""; saida_estoque_pedido_empresa =  ""; cod_forn_empresa =  ""; cliente_inadimplente_empresa =  "";
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand comando = new FbCommand();
                comando.Connection = _conexao;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND razao_social_empresa = 'CR FERRAMENTAS INDUSTRIA E COMERCIO LTDA'";
                DataSet empresa = new DataSet();
                _conexao.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                _conexao.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString();
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".","").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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
                    try
                    {
                        portaEmailEmpresa = dr["PORTA_EMAIL_EMP"].ToString();
                    }
                    catch { }
                    try
                    {
                        sslEmpresa = dr["SSL_EMP"].ToString();
                    }
                    catch { }

                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();

                    try
                    {
                        boleto_pedido_empresa = dr["BOLETO_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        saida_estoque_pedido_empresa = dr["SAIDA_ESTOQUE_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cod_forn_empresa = dr["COD_FORN_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cliente_inadimplente_empresa = dr["CLIENTE_INADIMPLENTE_EMPRESA"].ToString();
                    }
                    catch { }
                }

            }
            catch (Exception a)
            {
               // fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
       


        DataSet theDS = new DataSet();
        private void form_importar_pedidos_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'");
                //OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\munic.xls';Extended Properties='Excel 8.0;HDR=YES;\"");
                //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myOldExcelFile.xls;Extended Properties = "Excel 8.0;HDR=YES";
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Mun$]", theConnection);

                theDataAdapter.Fill(theDS);
                theConnection.Close();
            }
            catch { }

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa,
out serie_empresa, out boleto_pedido_empresa, out saida_estoque_pedido_empresa, out cod_forn_empresa, out cliente_inadimplente_empresa);

            buscar_dados_bancarios();
        }

        public string _cod_banco, _agencia, _dig_agencia, _cc, _dig_cc, _carteira, _multa, _mora, _dias_protesto, _codigo_no_banco, _descricao_banco, _cod_interno_banco;
        private void buscar_dados_bancarios()
        {
            _cod_banco =  ""; _agencia =  ""; _dig_agencia =  "";
            _cc =  ""; _dig_cc =  "";
            _carteira =  ""; _multa =  "";
            _mora =  ""; _dias_protesto =  "";
            _codigo_no_banco =  "";

            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand select = new FbCommand();
                select.Connection = _conexao;
                select.CommandText =
                    "SELECT * FROM CONTAS_CORRENTES WHERE BOLETO_CC = '1'";
                //select.Connection = _conexao;
                _conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                _conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    _cod_banco = dr["CODIGO_BANCO_CC"].ToString();
                    _agencia = dr["AGENCIA_CC"].ToString();
                    _dig_agencia = dr["DIG_AGENCIA_CC"].ToString();
                    _cc = dr["CONTA_CC"].ToString();
                    _dig_cc = dr["DIG_CONTA_CC"].ToString();
                    _multa = dr["MULTA_CC"].ToString();
                    _mora = dr["MORA_DIA_CC"].ToString();
                    _dias_protesto = dr["DIAS_PROTESTO_CC"].ToString();
                    _carteira = dr["CARTEIRA_CC"].ToString();
                    _codigo_no_banco = dr["CODIGO_NO_BANCO_CC"].ToString();
                    _cod_interno_banco = dr["COD_CC"].ToString();
                    _descricao_banco = dr["DESCRICAO_CC"].ToString();
                }

            }
            catch { 
               // fbConnection1.Close(); 
            }
        }

        //empresa
        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
           sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", saida_estoque_pedido_empresa = "", cod_forn_empresa = "", cliente_inadimplente_empresa =  "";

        private void button2_Click(object sender, EventArgs e)
        {
            if (!razao_social_empresa.Contains("JH") && !razao_social_empresa.Contains("RODRIGO") && !razao_social_empresa.Contains("MARCATTO"))// && !razao_social_empresa.Contains("CARLIATTO"))
            {
                if (cliente_inadimplente_empresa != "0")
                {
                    marcar_inadimplentes();
                }
            }
            DateTime inicio = new DateTime();
            DateTime fim = new DateTime();
            inicio = DateTime.Now;
            exportar_clientes(cod_webservice_empresa);
            fim = DateTime.Now;
            TimeSpan tempo = fim - inicio;
            //MessageBox.Show("Clientes: " + tempo.Seconds.ToString()) ;

            inicio = DateTime.Now;
            exportar_produtos(cod_webservice_empresa);
            fim = DateTime.Now;
            tempo = fim - inicio;
            //MessageBox.Show("Produtos: " + tempo.Seconds.ToString());

            
            exportar_vendedores(cod_webservice_empresa);
            // exportar_fornecedores_vendedores(cod_webservice_empresa);
            inicio = DateTime.Now;

            exportar_tabelas(cod_webservice_empresa);
            
            exportar_itens_tp(cod_webservice_empresa);
            fim = DateTime.Now;
            tempo = fim - inicio;
            //MessageBox.Show("Tabelas e itens: " + tempo.Seconds.ToString());

            inicio = DateTime.Now;
            exportar_itens_promocao(cod_webservice_empresa);
            fim = DateTime.Now;
            tempo = fim - inicio;
            ////MessageBox.Show("Promoção: " + tempo.Seconds.ToString());

            exportar_forma_pgto(cod_webservice_empresa);

            inicio = DateTime.Now;
            exportar_pedidos_faturados(cod_webservice_empresa);
            fim = DateTime.Now;
            tempo = fim - inicio;
           // MessageBox.Show("Pedidos: " + tempo.Seconds.ToString());

            inicio = DateTime.Now;
            exportar_itens_ped_faturados(cod_webservice_empresa);
            fim = DateTime.Now;
            tempo = fim - inicio;
           // MessageBox.Show("Itens Pedidos: " + tempo.Seconds.ToString());
            MessageBox.Show("Exportação concluída");
            //exportar_vendas(cod_webservice_empresa);
            /*exportacao_cliente_produto_vendedor ecpv = new exportacao_cliente_produto_vendedor();
           ecpv.exportar_clientes(cod_webservice_empresa);
           ecpv.exportar_produtos(cod_webservice_empresa);
           ecpv.exportar_vendedores(cod_webservice_empresa);*/
        }

        private void exportar_itens_ped_faturados(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
             FbCommand select_vendedores = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select_vendedores.Connection = conexao;
                select_vendedores.CommandText =
                    "SELECT COD_VENDEDOR FROM VENDEDORES";
                conexao.Open();
                FbDataAdapter datSelect_vendedores = new FbDataAdapter();
                datSelect_vendedores.SelectCommand = select_vendedores;
                DataTable dtSelect = new DataTable();
                datSelect_vendedores.Fill(dtSelect);
                conexao.Close();
               // bool ok = false;
                foreach (DataRow dr_vend in dtSelect.Rows)
                {
                    
                    try
                    {
                        FbCommand select = new FbCommand();

                        select.CommandText =
                            //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                         @"SELECT ipv.COD_SISTEMA_PROD_ITEM_VENDA, ipv.COD_PROD_ITEM_VENDA, ipv.QTDE_ITEM_VENDA, 
                 ipv.VALOR_UNIT_PROD_ITEM_VENDA, pv.COD_WEB_PED_VENDA, nf.N_NF, nf.DATA_EMISSAO_NF,  
                 pv.COD_PED_VENDA FROM
                 ITENS_PEDIDO_VENDA ipv
                 inner join PEDIDOS_VENDA pv ON ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA
                 INNER JOIN PEDIDOS_NF pnf on pv.COD_PED_VENDA = pnf.N_PEDIDO_NF
                 INNER JOIN NOTA_FISCAL nf on pnf.NF_PEDIDO_NF = nf.N_NF 
                WHERE DATA_EMISSAO_NF >= dateadd(-1 day to current_date) AND pv.COD_VENDEDOR_PED_VENDA = '" +
                         dr_vend[0].ToString() + "' AND pv.COD_WEB_PED_VENDA > 0";
                        select.Connection = conexao;
                        conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataSet dsSelect = new DataSet();
                        datSelect.Fill(dsSelect);
                        dsSelect.Tables[0].TableName = "ITENS_PEDIDO_VENDA";
                        dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\xml_itens_pedido_venda_" + dr_vend[0].ToString() + ".xml");
                        string arquivo = @"c:\\evolucao\\exportacoes\xml_itens_pedido_venda_" + dr_vend[0].ToString() + ".xml";
                        xml.Load(arquivo);
                        string _string_xml = GetXMLAsString(xml);
                        webservice.Service1 webser = new webservice.Service1();
                        if (cod_webservice_empresa != "")
                        {
                            ok = webser.exportar_offline_XML_itens_pedido_venda_cnpj(Convert.ToInt32(cod_webservice_empresa), 
                                Convert.ToInt16(dr_vend[0].ToString()),  _string_xml);
                        }
                        conexao.Close();
                       
                    }
                    catch (Exception a)
                    {

                        MessageBox.Show(a.ToString());
                    }
                }
                if (ok)
                {
                    //MessageBox.Show("Tabelas exportadas com sucesso!");
                }
                else
                    MessageBox.Show("Pedidos não exportados. Contate o suporte.");
        }

        private void exportar_pedidos_faturados(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            
                 FbCommand select_vendedores = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select_vendedores.Connection = conexao;
                select_vendedores.CommandText =
                    "SELECT COD_VENDEDOR FROM VENDEDORES";
                conexao.Open();
                FbDataAdapter datSelect_vendedores = new FbDataAdapter();
                datSelect_vendedores.SelectCommand = select_vendedores;
                DataTable dtSelect = new DataTable();
                datSelect_vendedores.Fill(dtSelect);
                conexao.Close();
               // bool ok = false;
                foreach (DataRow dr_vend in dtSelect.Rows)
                {
                    try
                    {
                        FbCommand select = new FbCommand();

                        select.CommandText =
                            //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                         "SELECT pv.COD_PED_VENDA, pv.COD_WEB_PED_VENDA, nf.N_NF, nf.DATA_EMISSAO_NF FROM PEDIDOS_VENDA pv " +
                         "INNER JOIN PEDIDOS_NF pnf on pv.COD_PED_VENDA = pnf.N_PEDIDO_NF " +
                         "INNER JOIN NOTA_FISCAL nf on pnf.NF_PEDIDO_NF = nf.N_NF " +
                         "WHERE DATA_EMISSAO_NF >= dateadd(-1 day to current_date) AND pv.COD_VENDEDOR_PED_VENDA = '" +
                         dr_vend[0].ToString() + "' AND pv.COD_WEB_PED_VENDA > 0";
                        select.Connection = conexao;
                        conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataSet dsSelect = new DataSet();
                        datSelect.Fill(dsSelect);
                        dsSelect.Tables[0].TableName = "PEDIDO_VENDA";
                        dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\xml_pedidos_venda_" + dr_vend[0].ToString() + ".xml");
                        string arquivo = @"c:\\evolucao\\exportacoes\xml_pedidos_venda_" + dr_vend[0].ToString() + ".xml";
                        xml.Load(arquivo);
                        string _string_xml = GetXMLAsString(xml);
                        webservice.Service1 webser = new webservice.Service1();
                        if (cod_webservice_empresa != "")
                        {
                            ok = webser.exportar_offline_XML_pedidos_venda_cnpj(Convert.ToInt32(cod_webservice_empresa), Convert.ToInt32(dr_vend[0].ToString()), _string_xml);
                        }
                        conexao.Close();

                    }
                    catch (Exception a)
                    {
                        conexao.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
            
            

        }


        private void exportar_fornecedores_vendedores(string cod_webservice_empresa)
        {
            
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            try
            {
                FbCommand select = new FbCommand();

                select.CommandText =
                    //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                 @"SELECT COD_MFV, COD_VENDEDOR_MFV, CNPJ_FORN_MFV, FORNECEDOR_MFV from METAS_FORNECEDOR_VENDEDOR mfv"; 
                    
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                dsSelect.Tables[0].TableName = "FORN_VENDEDOR";
                dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\forn_vendedor.xml");
                string arquivo = @"c:\\evolucao\\exportacoes\forn_vendedor.xml";
                xml.Load(arquivo);
                string _string_xml = GetXMLAsString(xml);
                webservice.Service1 webser = new webservice.Service1();
                if (cod_webservice_empresa != "")
                {
                   // ok = webser.exportar_offline_XML_forn_vendedor_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml);
                }

                if (ok)
                {
                    //MessageBox.Show("Vendedores exportados com sucesso!");
                }
                else
                    MessageBox.Show("Fornecedores dos Vendedores não exportados. Contate o suporte.");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        

        }

        private void exportar_forma_pgto(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            try
            {
                FbCommand select = new FbCommand();

                string _select = "SELECT * FROM FORMA_PGTO";
                if(razao_social_empresa.Contains("DISTRILAC"))
                {
                    _select =  "SELECT * FROM FORMA_PGTO WHERE TIPO_FORMA_PGTO = 'ATIVA'";
                }
                select.CommandText = _select;
                               
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                dsSelect.Tables[0].TableName = "FORMA_PGTO";
                dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\forma_pgto.xml");
                string arquivo = @"c:\\evolucao\\exportacoes\forma_pgto.xml";
                xml.Load(arquivo);
                string _string_xml = GetXMLAsString(xml);
                webservice.Service1 webser = new webservice.Service1();
                if (cod_webservice_empresa != "")
                {
                    ok = webser.exportar_offline_XML_forma_pgto_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml);
                }

                if (ok)
                {
                    //MessageBox.Show("Tabelas exportadas com sucesso!");
                }
                else
                    MessageBox.Show("Tabelas não exportadas. Contate o suporte.");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void exportar_tabelas(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            List<string> estados = new List<string>
            {

                "AC", // Acre
                "AL", // Alagoas
                "AP", // Amapá
                "AM", // Amazonas
                "BA", // Bahia
                "CE", // Ceará
                "DF", // Distrito Federal
                "ES", // Espírito Santo
                "GO", // Goiás
                "MA", // Maranhão
                "MT", // Mato Grosso
                "MS", // Mato Grosso do Sul
                "MG", // Minas Gerais
                "PA", // Pará
                "PB", // Paraíba
                "PR", // Paraná
                "PE", // Pernambuco
                "PI", // Piauí
                "RJ", // Rio de Janeiro
                "RN", // Rio Grande do Norte
                "RS", // Rio Grande do Sul
                "RO", // Rondônia
                "RR", // Roraima
                "SC", // Santa Catarina
                "SP", // São Paulo
                "SE", // Sergipe
                "TO"  // Tocantins
                
                 
            };

            // Usando um loop foreach para percorrer a lista
            foreach (string estado in estados)
            {
                try
                {

                    FbCommand select = new FbCommand();

                    select.CommandText =
                     //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                     "SELECT * FROM TABELA_PRECO where ESTADO_TABELA_PRECO = '" + estado + "'";
                    select.Connection = conexao;
                    conexao.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataSet dsSelect = new DataSet();
                    datSelect.Fill(dsSelect);
                    dsSelect.Tables[0].TableName = "TABELA_PRECO";
                    dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\xml_tabelas_preco_" + estado + ".xml");
                    string arquivo = @"c:\\evolucao\\exportacoes\xml_tabelas_preco_" + estado + ".xml";
                    xml.Load(arquivo);
                    string _string_xml = GetXMLAsString(xml);
                    conexao.Close();
                    webservice.Service1 webser = new webservice.Service1();
                    if (cod_webservice_empresa != "")
                    {
                        ok = webser.exportar_offline_XML_tabelas_estado_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml, estado);
                    }

                    if (ok)
                    {
                        //MessageBox.Show("Tabelas exportadas com sucesso!");
                    }
                    else
                        MessageBox.Show("Tabelas não exportadas. Contate o suporte.");
                }
                catch (Exception a)
                {
                    conexao.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void exportar_itens_promocao(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            try
            {
                FbCommand select = new FbCommand();

                select.CommandText =
                 "SELECT ipro.* FROM ITENS_PROMOCAO ipro INNER JOIN PROMOCAO pro on ipro.COD_PROMOCAO_IPRO = pro.COD_PROMOCAO " +
                 "WHERE '" + DateTime.Now.ToShortDateString().Replace("/", ".") +
                 "' between pro.DATA_INICIO_PROMOCAO AND pro.DATA_FIM_PROMOCAO";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                dsSelect.Tables[0].TableName = "ITENS_PROMOCAO";
                dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\itens_promocao.xml");
                string arquivo = @"c:\\evolucao\\exportacoes\itens_promocao.xml";
                xml.Load(arquivo);
                string _string_xml = GetXMLAsString(xml);
                webservice.Service1 webser = new webservice.Service1();
                if (cod_webservice_empresa != "")
                {
                    ok = webser.exportar_offline_XML_itens_promocao_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml);
                }

                if (ok)
                {
                    // MessageBox.Show("Itens TP exportadas com sucesso!");
                }
                else
                    MessageBox.Show("Itens Promoção não exportados. Contate o suporte.");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }


        private void exportar_itens_tp(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            List<string> estados = new List<string>
            {

                "AC", // Acre
                "AL", // Alagoas
                "AP", // Amapá
                "AM", // Amazonas
                "BA", // Bahia
                "CE", // Ceará
                "DF", // Distrito Federal
                "ES", // Espírito Santo
                "GO", // Goiás
                "MA", // Maranhão
                "MT", // Mato Grosso
                "MS", // Mato Grosso do Sul
                "MG", // Minas Gerais
                "PA", // Pará
                "PB", // Paraíba
                "PR", // Paraná
                "PE", // Pernambuco
                "PI", // Piauí
                "RJ", // Rio de Janeiro
                "RN", // Rio Grande do Norte
                "RS", // Rio Grande do Sul
                "RO", // Rondônia
                "RR", // Roraima
                "SC", // Santa Catarina
                "SP", // São Paulo
                "SE", // Sergipe
                "TO"  // Tocantins
                
                 
            };

            // Usando um loop foreach para percorrer a lista
            foreach (string estado in estados)
            {

                try
                {
                    FbCommand select = new FbCommand();

                    select.CommandText =
                     //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                     "SELECT itp.* FROM ITENS_TP itp INNER JOIN TABELA_PRECO tp on itp.COD_TABELA_ITEM_TP = tp.COD_TABELA_PRECO " + 
                     "WHERE tp.ESTADO_TABELA_PRECO = '" + estado + "' ";
                    select.Connection = conexao;
                    conexao.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataSet dsSelect = new DataSet();
                    datSelect.Fill(dsSelect);
                    dsSelect.Tables[0].TableName = "ITENS_TP";
                    dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\xml_itens_tp_" + estado + ".xml");
                    string arquivo = @"c:\\evolucao\\exportacoes\xml_itens_tp_" + estado + ".xml";
                    xml.Load(arquivo);
                    string _string_xml = GetXMLAsString(xml);
                    conexao.Close();
                    webservice.Service1 webser = new webservice.Service1();
                    if (cod_webservice_empresa != "")
                    {
                        ok = webser.exportar_offline_XML_itens_tp_estado_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml, estado);
                    }

                    if (ok)
                    {
                        // MessageBox.Show("Itens TP exportadas com sucesso!");
                    }
                    else
                        MessageBox.Show("Itens TP não exportadas. Contate o suporte.");
                }
                catch (Exception a)
                {
                    conexao.Close();
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void marcar_inadimplentes()
        {
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                FbCommand update1 = new FbCommand();
                update1.Connection = _conexao;
                update1.CommandText = "UPDATE CLIENTES SET INADIMPLENTE_CLIENTE = '0', DUPLICATAS_VENCIDAS_CLIENTE = null";
                _conexao.Open();
                FbDataAdapter datUpdate1 = new FbDataAdapter();
                datUpdate1.UpdateCommand = update1;
                datUpdate1.UpdateCommand.ExecuteNonQuery();
                _conexao.Close();
            }
            catch
            {
                //fbConnection1.Close();
            }
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";

                DateTime data_atrasado = DateTime.Now;
                while (data_atrasado.DayOfWeek == DayOfWeek.Monday || data_atrasado.DayOfWeek == DayOfWeek.Sunday)
                {
                    data_atrasado = data_atrasado.AddDays(-1);
                }

                if (razao_social_empresa.Contains("DISTRILAC"))
                {
                    data_atrasado = data_atrasado.AddDays(-4);
                }

                FbCommand select = new FbCommand();
                select.CommandText = "SELECT COD_CLIENTE_CR, DATA_PREVISTA_CR, VALOR_CR, NF_CR FROM CONTAS_A_RECEBER WHERE (RECEBIDO_CR IS NULL OR RECEBIDO_CR = 0) AND " +
                    "DATA_PREVISTA_CR < '" + data_atrasado.ToShortDateString().Replace("/", ".") + "' ORDER BY DATA_PREVISTA_CR DESC";


                //FbCommand select = new FbCommand();
                //select.CommandText = "SELECT COD_CLIENTE_CR, DATA_PREVISTA_CR, VALOR_CR, NF_CR FROM CONTAS_A_RECEBER WHERE (RECEBIDO_CR IS NULL OR RECEBIDO_CR = 0) AND " +
                //    "DATA_PREVISTA_CR < CURRENT_DATE ORDER BY DATA_PREVISTA_CR DESC";
                select.Connection = _conexao;
                _conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                _conexao.Close();
                
                string cod_cliente =  "";
                
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        cod_cliente = dr[0].ToString();
                        string duplicatas = "";
                        foreach (DataRow dr_2 in dtSelect.Select("COD_CLIENTE_CR = " + dr[0].ToString()))
                        {

                            duplicatas += "NF: " + dr_2[3].ToString() + " Vencimento: " + Convert.ToDateTime(dr_2[1].ToString()).ToShortDateString() +
                                " Valor: R$ " + Convert.ToDouble(dr_2[2].ToString()) + " /*/ \r\n"; //string.Format("teste de {0} string", Environment.NewLine);

                        }

                        if (duplicatas.Length > 1000)
                            duplicatas.Remove(1000);

                        if (cod_cliente == "2811")
                        {

                        }
                        try
                        {
                            FbConnection _conexao1 = new FbConnection();
                            _conexao1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";

                            FbCommand update = new FbCommand();
                            update.Connection = _conexao1;
                            update.CommandText = "UPDATE CLIENTES SET INADIMPLENTE_CLIENTE = '1', DUPLICATAS_VENCIDAS_CLIENTE = '" + duplicatas +
                                "' WHERE COD_CLIENTE = '" + cod_cliente + "'";
                            _conexao1.Open();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            _conexao1.Close();
                        }
                        catch
                        {
                            // fbConnection1.Close();
                        }
                    }
                    catch { }
                }
               
            }
            catch (Exception a)
            {
               // fbConnection1.Close();
                
            }
        
        }

        private void exportar_vendas(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            try
            {
                FbCommand select_vendedores = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select_vendedores.Connection = conexao;
                select_vendedores.CommandText =
                    "SELECT COD_VENDEDOR FROM VENDEDORES";
                conexao.Open();
                FbDataAdapter datSelect_vendedores = new FbDataAdapter();
                datSelect_vendedores.SelectCommand = select_vendedores;
                DataTable dtSelect = new DataTable();
                datSelect_vendedores.Fill(dtSelect);
                conexao.Close();
                bool ok = false;
                foreach (DataRow dr_vend in dtSelect.Rows)
                {
                    XmlDocument xml = new XmlDocument();
                    try
                    {
                        DateTime dia_atual = DateTime.Now;
                        DateTime primeiro_dia_mes = Convert.ToDateTime("01/" + dia_atual.AddMonths(-1).Month.ToString() + "/" + dia_atual.Year.ToString()); 


                        FbCommand select = new FbCommand();
                        select.CommandText =
                    "select  distinct(m.cod_mpv) as COD_VENDA, p.nome_familia_produto as FAMILIA_VENDA, " +
"cast((SELECT META_VALOR_MPV FROM METAS_PRODUTO_VENDEDOR m INNER JOIN VENDEDORES v ON m.COD_VENDEDOR_MPV = v.COD_VENDEDOR WHERE m.COD_VENDEDOR_MPV =  pv.cod_vendedor_ped_venda AND " +
                "m.FAMILIA_MPV = p.nome_familia_produto) as numeric(15,2)) as META_FAMILIA, " +

 "cast((select sum(inf2.PRECO_TOTAL_item) from itens_nota inf2   inner join nota_fiscal nf2        on nf2.n_nf = inf2.nf_item  inner join pedidos_nf pnf2        on pnf2.nf_pedido_nf = nf2.n_nf  " +
 "inner join pedidos_venda pv2        on pv2.cod_ped_venda = pnf2.n_pedido_nf   " +
 "inner join produtos p2 on (CAST(p2.cod_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50))  or CAST(p2.cod_fornecedor_produto AS VARCHAR(50)) = CAST(inf2.cod_item AS VARCHAR(50)))   " +
 "inner join cfo cfo2 on cfo2.n_cfo = inf2.cfop_item     inner join metas_produto_vendedor m2 on m2.COD_VENDEDOR_MPV = pv2.cod_vendedor_ped_venda and m2.familia_mpv = p2.NOME_FAMILIA_PRODUTO  " +
 "where nf2.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "'  " +
 "and nf2.data_emissao_nf <= '" + dia_atual.ToShortDateString().Replace("/", ".") + "'      and pv2.cod_vendedor_ped_venda = '" + dr_vend[0].ToString() + "'    and nf2.status_nfe like '%Autorizada%'   " +
 "and (inf2.cfop_item = '5102'        or inf2.cfop_item = '5405')  and cfo2.tributada_cfo = '1'           and p2.nome_familia_produto = p.nome_familia_produto) as numeric(15,3)) as VENDAS_TOTAIS_FAMILIA " +
 " from itens_nota item  " +
 " inner join nota_fiscal nf        on nf.n_nf = item.nf_item " +
 "inner join pedidos_nf pnf        on pnf.nf_pedido_nf = nf.n_nf " +
 "inner join pedidos_venda pv        on pv.cod_ped_venda = pnf.n_pedido_nf " +
 "inner join produtos p        on (CAST(p.cod_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50))  or CAST(p.cod_fornecedor_produto AS VARCHAR(50)) = CAST(item.cod_item AS VARCHAR(50))) " +
 "inner join cfo on cfo.n_cfo = item.cfop_item " +
 "inner join metas_produto_vendedor m on m.COD_VENDEDOR_MPV = pv.cod_vendedor_ped_venda and m.familia_mpv = p.NOME_FAMILIA_PRODUTO " +
 " where  nf.data_emissao_nf >= '" + primeiro_dia_mes.ToShortDateString().Replace("/", ".") + "'    and nf.data_emissao_nf <= '" + dia_atual.ToShortDateString().Replace("/", ".") + "'  " +
 " and pv.cod_vendedor_ped_venda = '" + dr_vend[0].ToString() + "' " +
 " and nf.status_nfe like '%Autorizada%'  " +
 " and cfo.tributada_cfo = '1' ";
                        select.Connection = conexao;
                        conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataSet dsSelect = new DataSet();
                        datSelect.Fill(dsSelect);
                        conexao.Close();
                        dsSelect.Tables[0].TableName = "CLIENTES";
                        dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\vendas_vendedor_" + dr_vend[0].ToString() + @".xml");
                        string arquivo = @"c:\\evolucao\\exportacoes\vendas_vendedor_" + dr_vend[0].ToString() + @".xml";
                        xml.Load(arquivo);

                        string _string_xml = GetXMLAsString(xml);

                        webservice.Service1 webser = new webservice.Service1();

                        if (cod_webservice_empresa != "")
                        {
                            ok = webser.exportar_offline_XML_vendas_cnpj(Convert.ToInt32(dr_vend[0].ToString()),
                                Convert.ToInt32(cod_webservice_empresa), _string_xml);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
                if (ok)
                    MessageBox.Show("Vendas exportadas com sucesso!");
                else
                    MessageBox.Show("Vendas não exportadas. Contate o suporte.");
                conexao.Dispose();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                conexao.Dispose();
            }
        }


        public void exportar_clientes(string cod_webservice_empresa)
        {

            FbConnection conexao = new FbConnection();
            try
            {
                FbCommand select_vendedores = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select_vendedores.Connection = conexao;
                select_vendedores.CommandText =
                    "SELECT COD_VENDEDOR FROM VENDEDORES";
                conexao.Open();
                FbDataAdapter datSelect_vendedores = new FbDataAdapter();
                datSelect_vendedores.SelectCommand = select_vendedores;
                DataTable dtSelect = new DataTable();
                datSelect_vendedores.Fill(dtSelect);
                conexao.Close();
                bool ok = false;
                foreach (DataRow dr_vend in dtSelect.Rows)
                {
                    XmlDocument xml = new XmlDocument();
                    try
                    {
                        FbCommand select = new FbCommand();
                        select.CommandText =
                     "SELECT C.*, fp.DESCRICAO_FORMA_PGTO as FORMA_PGTO_CLIENTE FROM CLIENTES C " +
                     "JOIN VENDEDORES_CLIENTE V ON C.COD_CLIENTE = V.COD_CLIENTE_VC " +
                     "LEFT JOIN FORMA_PGTO fp ON c.FORMA_PAGAMENTO_CLIENTE = fp.COD_FORMA_PGTO " + 
                     "WHERE C.ATIVO_CLIENTE = '1' AND V.COD_VENDEDOR_VC = '" + dr_vend[0].ToString() + "' order by C.RAZAO_SOCIAL";
                        select.Connection = conexao;
                        conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataSet dsSelect = new DataSet();
                        datSelect.Fill(dsSelect);
                        conexao.Close();
                        dsSelect.Tables[0].TableName = "CLIENTES";
                        dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\clientes_vendedor_" + dr_vend[0].ToString() + @".xml");
                        string arquivo = @"c:\\evolucao\\exportacoes\clientes_vendedor_" + dr_vend[0].ToString() + @".xml";
                        xml.Load(arquivo);

                        string _string_xml = GetXMLAsString(xml);

                        webservice.Service1 webser = new webservice.Service1();

                        if (cod_webservice_empresa != "")
                        {
                            ok = webser.exportar_offline_XML_clientes_cnpj(Convert.ToInt32(dr_vend[0].ToString()),
                                Convert.ToInt32(cod_webservice_empresa), _string_xml);
                        }
                    }
                    catch (Exception a)
                    {
                        conexao.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
                if (ok)
                {
                    //MessageBox.Show("Clientes exportados com sucesso!");
                }
                else
                    MessageBox.Show("Clientes não exportados. Contate o suporte.");
                conexao.Dispose();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                conexao.Dispose();
            }

        }

        public void exportar_produtos(string cod_webservice_empresa)
        {
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                    XmlDocument xml = new XmlDocument();
                    bool ok = false;
                    try
                    {
                        FbCommand select = new FbCommand();
                      
                        select.CommandText =
                         //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                         "SELECT COD_PRODUTO, (DESCRICAO_PRODUTO || ' - ' || COD_FORNECEDOR_PRODUTO)AS DESCRICAO_PRODUTO, COD_FORNECEDOR_PRODUTO, NOME_FORNECEDOR_PRODUTO, " +
                        " CNPJ_FORNECEDOR_PRODUTO, MARCA_PRODUTO, COD_UNIDADE_PRODUTO, QTDE_UNIDADE_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, DESCONTO_MAXIMO_PRODUTO, " +
                        " VALOR_PROMOCAO_PRODUTO, VALOR_VENDA_PRODUTOR_PRODUTO, UNIDADE_PRODUTO, COD_BARRAS_PRODUTO, PESO_UNIT_PRODUTO, NCM_PRODUTO, " + 
                        " ALIQUOTA_ICMS_PRODUTO, ALIQUOTA_ICMS_ST_PRODUTO, REDUCAO_ICMS_PRODUTO, IVA_PRODUTO, ST_SAIDA_PRODUTO, ALIQUOTA_FORA_ICMS_PRODUTO, " + 
                        " ALIQUOTA_ICMS_ST_FORA_PRODUTO, REDUCAO_FORA_PRODUTO, IVA_FORA_PRODUTO, ST_SAIDA_FORA_PRODUTO, ORIGEM_PRODUTO, CEST_PRODUTO, ESTOQUE_ATUAL_PRODUTO, " +
                        "ESTOQUE_DISPONIVEL_PRODUTO, CURRENT_TIME AS HORA_ESTOQUE, NOME_FAMILIA_PRODUTO, DESCRICAO_SUB_GRUPO_PRODUTO, DESCRICAO_GRUPO_PRODUTO, "  +
                        "CARACT_ADIC_PRODUTO, COD_BARRAS_CAIXA_PRODUTO FROM PRODUTOS " + 
                        "WHERE status_produto = '1' and NOME_FORNECEDOR_PRODUTO = 'ENTRELUX' order by DESCRICAO_PRODUTO";

                        
                        select.Connection = conexao;
                        conexao.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = select;
                        DataSet dsSelect = new DataSet();
                        datSelect.Fill(dsSelect);
                        dsSelect.Tables[0].TableName = "PRODUTOS";
                        dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\produtos.xml");
                        string arquivo = @"c:\\evolucao\\exportacoes\produtos.xml";
                        xml.Load(arquivo);
                        string _string_xml = GetXMLAsString(xml);
                        webservice.Service1 webser = new webservice.Service1();
                        if (cod_webservice_empresa != "")
                        {
                            ok = webser.exportar_offline_XML_produtos_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml);
                        }

                        if (ok)
                        {
                           // MessageBox.Show("Produtos exportados com sucesso!");
                        }
                        else
                            MessageBox.Show("Produtos não exportados. Contate o suporte.");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
        private string buscarNomeEmpresa() 
        {
            try
            {
                FbConnection _conexao = new FbConnection();
                _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                
                string nome =  "";
                FbCommand cmd = new FbCommand();
                cmd.CommandText = @"SELECT RAZAO_SOCIAL_EMPRESA FROM EMPRESA";
                cmd.Connection = _conexao;
                _conexao.Open();
                nome = Convert.ToString(cmd.ExecuteScalar());
                _conexao.Close();
                return nome;
            }
            catch (Exception)
            {
               // fbConnection1.Close();
                MessageBox.Show("Erro ao verificar nome da empresa");
                return  "";
            }

        }
        public void exportar_vendedores(string cod_webservice_empresa)
        {
            FbConnection conexao = new FbConnection();
            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
            XmlDocument xml = new XmlDocument();
            bool ok = false;
            try
            {
                FbCommand select = new FbCommand();

                select.CommandText =
                    //"SELECT * FROM PRODUTOS WHERE status_produto = '1' order by DESCRICAO_PRODUTO";
                 "SELECT * from vendedores where ativo_vendedor = 1";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();
                datSelect.Fill(dsSelect);
                dsSelect.Tables[0].TableName = "VENDEDORES";
                dsSelect.WriteXml(@"c:\\evolucao\\exportacoes\vendedores.xml");
                string arquivo = @"c:\\evolucao\\exportacoes\vendedores.xml";
                xml.Load(arquivo);
                string _string_xml = GetXMLAsString(xml);
                webservice.Service1 webser = new webservice.Service1();
                if (cod_webservice_empresa != "")
                {
                    ok = webser.exportar_offline_XML_vendedores_cnpj(Convert.ToInt32(cod_webservice_empresa), _string_xml);
                }

                if (ok)
                {
                    //MessageBox.Show("Vendedores exportados com sucesso!");
                }
                else
                    MessageBox.Show("Vendedores não exportados. Contate o suporte.");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        public string GetXMLAsString(XmlDocument myxml)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            myxml.WriteTo(tx);

            string str = sw.ToString();// 
            return str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscarNomeEmpresa();
        }

        private void Pedidos_back_DoWork(object sender, DoWorkEventArgs e)
        {
            Object[] arg = e.Argument as Object[];
            bool pedido_repetido;
            bool pedido_ok = inserir_pedido(arg[0].ToString(), Convert.ToInt32(arg[1]), out pedido_repetido, arg[4].ToString());
            arg[2] = pedido_repetido;
            arg[3] = pedido_ok;
            e.Result = arg;
        }

        private void Estoque_back_DoWork(object sender, DoWorkEventArgs e)
        {

        }

       

        

    }
}
