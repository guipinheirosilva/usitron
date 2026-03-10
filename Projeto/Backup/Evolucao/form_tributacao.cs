using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Evolucao
{
    public partial class form_tributacao : Form
    {
        public string _origem;
        bool cofins;
        bool pis;
        public bool consulta;
        public string cod_variavel_trib, variavel_trib;

        //job futura
        public bool _reducao, _isenta;
        public string _porc_reducao, _porc_icms;


        public bool dentro_estado;
        public bool fora_estado;
        public bool prestacao_servico;
        public bool inserir_nova;
        public bool beneficiamento;
        public bool tributacao_suspensa;
        public bool selecionar;
        public bool copiar_trib;
        public string op_nova;
        public bool nf_nova;
        string cod_nova_trib;
        public string valor_total_prod;
        public string op_selecionada;
        public string item_selecionado;
        public string peca_selecionada;
        public string nf_selecionada;
        public string cod_trib;
        string decimal_correto;
        public double ipi_item_2;
        public double icm_item_2;
        public double iss_item_2;
        public string valor_icm_item_2 = "0";
        public string valor_iss_item_2 = "0";
        public string valor_ipi_item_2 = "0";
        public string valor_bc_item_2;
        public form_tributacao()
        {
            InitializeComponent();
        }

        private void rb_00_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "00";
           
        }

        private void rb_10_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "10";
            group_ST.Visible = true;

            cb_origem_mercadoria.Text = "0 - Nacional";
            cb_mod_det_bc_icms.Text = "0 - Margem Valor Agregado (%)";
            cb_st_mod_det_bc_icms.Text = "4 - Margem Valor Agregado (%)";
            tabControl1.SelectedTab = tabPage2;
            rb_ipi_nao_tributavel.Checked = true;
            cb_cod_sit_trib_n_trib.Text = "53 - Saída não tributada";

            procedimentos();
            salvar();
            this.Close();

        }

        private void rb_20_CheckedChanged(object sender, EventArgs e)
        {
            /*
            tb_tributacao_icms.Text = "20";
            label_perc_red_bc.Visible = true;
            tb_percentual_red_bc.Visible = true;
            procedimentos_de_reducao();
            this.Close();
             * */
        }

        private void procedimentos_de_reducao()
        {
            /*
            string perc_icms, perc_icms_st, perc_reducao, perc_reducao_st, perc_mar_val_ad_st, perc_icms_fe, perc_icms_st_fe,
             perc_reducao_fe, perc_reducao_st_fe, perc_mar_val_ad_st_fe, perc_ipi,
             perc_ipi_fe, perc_prest_serv, perc_prest_serv_fe, perc_pis, perc_cofins;
            buscar_valores_tributacao(out perc_icms, out perc_icms_st, out perc_reducao,
             out perc_reducao_st, out perc_mar_val_ad_st, out perc_icms_fe, out perc_icms_st_fe,
             out perc_reducao_fe, out perc_reducao_st_fe, out perc_mar_val_ad_st_fe, out perc_ipi,
             out perc_ipi_fe, out perc_prest_serv, out perc_prest_serv_fe, out perc_pis, out perc_cofins, variavel_trib, cod_variavel_trib);
            double _valor_total = Convert.ToDouble(valor_total_prod);
            */
            cb_origem_mercadoria.Text = "0 - Nacional";
            cb_mod_det_bc_icms.Text = "3 - Valor da Operação";
            tb_percentual_red_bc.Text = _porc_reducao;
            tb_aliquota_imposto.Text = _porc_icms;
            
            tabControl1.SelectedTab = tabPage2;
            rb_ipi_nao_tributavel.Checked = true;
            cb_cod_sit_trib_n_trib.Text = "53 - Saída não tributada";
            //tabControl1.SelectedTab = tabPage3;
            //calcular_pis();
            //tabControl1.SelectedTab = tabPage4;
            //calcular_cofins();
            
            procedimentos();


        }

        private void rb_30_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "30";
            label_mod_det_bc_icms.Visible = false;
            cb_mod_det_bc_icms.Visible = false;
            label_valor_bc_icms.Visible = false;
            tb_valor_bc_icms.Visible = false;
            label_aliq_imposto.Visible = false;
            tb_aliquota_imposto.Visible = false;
            label_valor_icms.Visible = false;
            tb_valor_icms.Visible = false;
            group_ST.Visible = true;

        }

        private void rb_40_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "40";
            label_mod_det_bc_icms.Visible = false;
            cb_mod_det_bc_icms.Visible = false;
            label_valor_bc_icms.Visible = false;
            tb_valor_bc_icms.Visible = false;
            label_aliq_imposto.Visible = false;
            tb_aliquota_imposto.Visible = false;
            label_valor_icms.Visible = false;
            tb_valor_icms.Visible = false;
        }

        private void rb_41_CheckedChanged(object sender, EventArgs e)
        {
            if (selecionar == false)
            {
                tb_tributacao_icms.Text = "41";
                cb_origem_mercadoria.Text = "0 - Nacional";
                cb_mod_det_bc_icms.Text = "3 - Valor da Operação";
                tabControl1.SelectedTab = tabPage2;
                rb_ipi_nao_tributavel.Checked = true;
                cb_cod_sit_trib_n_trib.Text = "53 - Saída não tributada";

                label_mod_det_bc_icms.Visible = true;
                cb_mod_det_bc_icms.Visible = true;
                label_valor_bc_icms.Visible = false;
                tb_valor_bc_icms.Visible = false;
                label_aliq_imposto.Visible = false;
                tb_aliquota_imposto.Visible = false;
                label_valor_icms.Visible = false;
                tb_valor_icms.Visible = false;
                procedimentos();
                salvar();
                this.Close();
            }
            

        }

        private void rb_50_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "50";
            label_mod_det_bc_icms.Visible = false;
            cb_mod_det_bc_icms.Visible = false;
            label_valor_bc_icms.Visible = false;
            tb_valor_bc_icms.Visible = false;
            label_aliq_imposto.Visible = false;
            tb_aliquota_imposto.Visible = false;
            label_valor_icms.Visible = false;
            tb_valor_icms.Visible = false;
        }

        private void rb_51_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "51";
            label_perc_red_bc.Visible = true;
            tb_percentual_red_bc.Visible = true;
        }

        private void rb_60_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "60";
            label_mod_det_bc_icms.Visible = false;
            cb_mod_det_bc_icms.Visible = false;
            label_valor_bc_icms.Visible = false;
            tb_valor_bc_icms.Visible = false;
            label_aliq_imposto.Visible = false;
            tb_aliquota_imposto.Visible = false;
            label_valor_icms.Visible = false;
            tb_valor_icms.Visible = false;
            group_ST.Visible = true;
            tb_st_aliq_imp.Visible = false;
            label_st_aliq_imp.Visible = false;
            label_st_mod_det_bc_icms.Visible = false;
            cb_st_mod_det_bc_icms.Visible = false;
            label_st_perc_mar_val_adi_icms.Visible = false;
            tb_st_perc_mar_val_icms.Visible = false;
            label_st_perc_red_bc_icms.Visible = false;
            tb_st_perc_red_bc_icms.Visible = false;
        }

        private void rb_70_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "70";
            label_perc_red_bc.Visible = true;
            tb_percentual_red_bc.Visible = true;
            group_ST.Visible = true;
        }

        private void rb_90_CheckedChanged(object sender, EventArgs e)
        {
            tb_tributacao_icms.Text = "90";
            label_perc_red_bc.Visible = true;
            tb_percentual_red_bc.Visible = true;
            group_ST.Visible = true;

        }

        private void rb_ipi_tributavel_CheckedChanged(object sender, EventArgs e)
        {
            //group_ipi_nao_tributavel.Visible = false;
        }

        private void rb_ipi_nao_tributavel_CheckedChanged(object sender, EventArgs e)
        {
            //group_ipi_tributavel.Visible = false;
        }

        private void form_tributacao_Load(object sender, EventArgs e)
        {
            
            if (item_selecionado != null && inserir_nova == true)
            {
                /* POIS A NG É SIMPLES
                nova_trib();
                
                if (_reducao == true)
                {
                  
                    tb_tributacao_icms.Text = "20";
                    rb_20.Checked = true;
                    label_perc_red_bc.Visible = true;
                    tb_percentual_red_bc.Visible = true;
                    procedimentos_de_reducao();
                   
                }
                else
                {
                    tb_tributacao_icms.Text = "00";
                    rb_00.Checked = true;
                    cb_origem_mercadoria.Text = "0 - Nacional";
                    cb_mod_det_bc_icms.Text = "3 - Valor da Operação";
                    tb_aliquota_imposto.Text = _porc_icms;
                    tb_valor_bc_icms.Text = valor_total_prod.ToString();
                    tabControl1.SelectedTab = tabPage2;
                    rb_ipi_nao_tributavel.Checked = true;
                    cb_cod_sit_trib_n_trib.Text = "53 - Saída não tributada";
                    procedimentos();
                }
                 
                nao_tributada();
                this.Close();
                rb_41.Checked = true;
                 * */
                nova_trib();
                rb_40.Checked = true;
                try
                {
                    isenta();
                    fbConnection1.Close();
                }
                catch
                {
                    MessageBox.Show("Erro na inserção de tributação");
                }
            }
            if (item_selecionado != null && selecionar == true)
            {
                selecionar_tributacao();
                if(consulta == false)
                    this.Close();
            }

        }
        private void nao_tributada()
        {
            if (selecionar == false)
            {
                tb_tributacao_icms.Text = "41";
                cb_origem_mercadoria.Text = "0 - Nacional";
                cb_mod_det_bc_icms.Text = "3 - Valor da Operação";
                tabControl1.SelectedTab = tabPage2;
                rb_ipi_nao_tributavel.Checked = true;
                cb_cod_sit_trib_n_trib.Text = "53 - Saída não tributada";

                label_mod_det_bc_icms.Visible = true;
                cb_mod_det_bc_icms.Visible = true;
                label_valor_bc_icms.Visible = false;
                tb_valor_bc_icms.Visible = false;
                label_aliq_imposto.Visible = false;
                tb_aliquota_imposto.Visible = false;
                label_valor_icms.Visible = false;
                tb_valor_icms.Visible = false;
                procedimentos();
                salvar();
                this.Close();
            }


        }

        private void isenta()
        {
            if (selecionar == false)
            {
                tb_tributacao_icms.Text = "40";
                cb_origem_mercadoria.Text = _origem;
                cb_mod_det_bc_icms.Text = "3 - Valor da Operação";
                tabControl1.SelectedTab = tabPage2;
                rb_ipi_nao_tributavel.Checked = true;
                cb_cod_sit_trib_n_trib.Text = "53 - Saída não tributada";

                label_mod_det_bc_icms.Visible = true;
                cb_mod_det_bc_icms.Visible = true;
                label_valor_bc_icms.Visible = false;
                tb_valor_bc_icms.Visible = false;
                label_aliq_imposto.Visible = false;
                tb_aliquota_imposto.Visible = false;
                label_valor_icms.Visible = false;
                tb_valor_icms.Visible = false;
                procedimentos();
                salvar();
                this.Close();
            }


        }

        private void calcular_valores_trib_st()
        {
            //calcular_aqui
            string perc_icms, perc_icms_st, perc_reducao, perc_reducao_st, perc_mar_val_ad_st, perc_icms_fe, perc_icms_st_fe,
             perc_reducao_fe, perc_reducao_st_fe, perc_mar_val_ad_st_fe, perc_ipi,
             perc_ipi_fe, perc_prest_serv, perc_prest_serv_fe, perc_pis, perc_cofins;
                buscar_valores_tributacao(out perc_icms, out perc_icms_st, out perc_reducao,
                 out perc_reducao_st, out perc_mar_val_ad_st, out perc_icms_fe, out perc_icms_st_fe,
                 out perc_reducao_fe, out perc_reducao_st_fe, out perc_mar_val_ad_st_fe, out perc_ipi,
                 out perc_ipi_fe, out perc_prest_serv, out perc_prest_serv_fe, out perc_pis, out perc_cofins, variavel_trib, cod_variavel_trib);
            double _valor_total = Convert.ToDouble(valor_total_prod);
            double bc_icms_st = 0, valor_icms_st=0,  valor_prov_icms_st=0, valor_prov_icms=0;
            if (dentro_estado == true)
            {
                try
                {
                    valor_prov_icms = _valor_total * (Convert.ToDouble(perc_icms)/100);
                    
                }
                catch { }
                try
                {
                    bc_icms_st = (_valor_total + (_valor_total * (Convert.ToDouble(perc_mar_val_ad_st)/100)));
                    valor_prov_icms_st =  bc_icms_st * (Convert.ToDouble(perc_icms_st)/100);
                }
                catch { }
                try
                {
                    valor_icms_st = valor_prov_icms_st - valor_prov_icms;
                    cb_st_mod_det_bc_icms.Text = "4 - Margem Valor Agregado (%)";
                    tb_st_perc_mar_val_icms.Text = perc_mar_val_ad_st;
                    tb_st_valor_bc_icms.Text = bc_icms_st.ToString("n2");
                    tb_st_aliq_imp.Text = perc_icms_st;
                    tb_st_val_icms.Text = valor_icms_st.ToString("n2");
                }
                catch{}

            }
            if (fora_estado == true)
            {
                try
                {
                    valor_prov_icms = _valor_total * (Convert.ToDouble(perc_icms_fe) / 100);

                }
                catch { }
                try
                {
                    bc_icms_st = (_valor_total + (_valor_total * (Convert.ToDouble(perc_mar_val_ad_st_fe) / 100)));
                    valor_prov_icms_st = bc_icms_st * (Convert.ToDouble(perc_icms_st_fe) / 100);
                }
                catch { }
                try
                {
                    valor_icms_st = valor_prov_icms_st - valor_prov_icms;
                    cb_st_mod_det_bc_icms.Text = "4 - Margem Valor Agregado (%)";
                    tb_st_perc_mar_val_icms.Text = perc_mar_val_ad_st_fe;
                    tb_st_valor_bc_icms.Text = bc_icms_st.ToString("n2");
                    tb_st_aliq_imp.Text = perc_icms_st_fe;
                    tb_st_val_icms.Text = valor_icms_st.ToString("n2");
                }
                catch { }
            }
            

             

            
            


        }

        private void buscar_valores_tributacao(out string perc_icms, out string perc_icms_st, out string perc_reducao,
            out string perc_reducao_st, out string perc_mar_val_ad_st, out string perc_icms_fe, out string perc_icms_st_fe,
            out string perc_reducao_fe, out string perc_reducao_st_fe, out string perc_mar_val_ad_st_fe, out string perc_ipi,
            out string perc_ipi_fe, out string perc_prest_serv, out string perc_prest_serv_fe, out string perc_pis, out string perc_cofins, string variavel, string cod_variavel)
        {
            perc_icms = ""; perc_icms_st = ""; perc_reducao = ""; perc_reducao_st = ""; perc_mar_val_ad_st  = ""; perc_icms_fe = ""; perc_icms_st_fe = "";
            perc_reducao_fe = ""; perc_reducao_st_fe = ""; perc_mar_val_ad_st_fe = ""; perc_ipi = ""; perc_ipi_fe = ""; perc_prest_serv = ""; perc_prest_serv_fe = ""; perc_pis = ""; perc_cofins = "";

            comando_select.CommandText = "SELECT * FROM TRIBUTACAO_EMPRESA WHERE COD_VARIAVEL_TRIB_EMP = '" + cod_variavel + "' AND VARIAVEL_TRIB_EMP= '" + variavel + "'";
            DataSet empresa = new DataSet();
            fbConnection1.Open();
            datTrib_empresa.SelectCommand = comando_select;
            datTrib_empresa.Fill(empresa);

            foreach (DataRow dr in empresa.Tables[0].Rows)
            {
                perc_icms = dr["PERC_ICMS_TRIB_EMP"].ToString();
                perc_icms_st = dr["PERC_ICMS_ST_TRIB_EMP"].ToString();
                perc_reducao = dr["PERC_REDUCAO_TRIB_EMP"].ToString();
                perc_reducao_st = dr["PERC_REDUCAO_ST_TRIB_EMP"].ToString();
                perc_mar_val_ad_st = dr["PERC_MAR_VAL_AD_ST_TRIB_EMP"].ToString();
                perc_icms_fe = dr["PERC_ICMS_FE_TRIB_EMP"].ToString();
                perc_icms_st_fe = dr["PERC_ICMS_ST_FE_TRIB_EMP"].ToString();
                perc_reducao_fe = dr["PERC_REDUCAO_FE_TRIB_EMP"].ToString();
                perc_reducao_st_fe = dr["PERC_REDUCAO_ST_FE_TRIB_EMP"].ToString();
                perc_mar_val_ad_st_fe = dr["PERC_MAR_VAL_AD_ST_FE_TRIB_EMP"].ToString();
                perc_ipi = dr["PERC_IPI_TRIB_EMP"].ToString();
                perc_ipi_fe = dr["PERC_IPI_FE_TRIB_EMP"].ToString();
                perc_prest_serv = dr["PERC_PREST_SERV_TRIB_EMP"].ToString();
                perc_prest_serv_fe = dr["PERC_PREST_SERV_FE_TRIB_EMP"].ToString();
                perc_pis = dr["PERC_PIS_TRIB_EMP"].ToString();
                perc_cofins = dr["PERC_COFINS_TRIB_EMP"].ToString();
                
            }
            this.fbConnection1.Close();


        }


        private void calcular_valores()
        {
            if (tb_tributacao_icms.Text == "10")
            {
                calcular_valores_trib_st();
            }
            else
            {
                /*
                string perc_icms, perc_icms_st, perc_reducao,
             perc_reducao_st, perc_mar_val_ad_st, perc_icms_fe, perc_icms_st_fe,
             perc_reducao_fe, perc_reducao_st_fe, perc_mar_val_ad_st_fe, perc_ipi,
             perc_ipi_fe, perc_prest_serv, perc_prest_serv_fe, perc_pis, perc_cofins;
                buscar_valores_tributacao(out perc_icms, out perc_icms_st, out perc_reducao,
                 out perc_reducao_st, out perc_mar_val_ad_st, out perc_icms_fe, out perc_icms_st_fe,
                 out perc_reducao_fe, out perc_reducao_st_fe, out perc_mar_val_ad_st_fe, out perc_ipi,
                 out perc_ipi_fe, out perc_prest_serv, out perc_prest_serv_fe, out perc_pis, out perc_cofins, variavel_trib, cod_variavel_trib);
                 * */
                /*
                if (dentro_estado == true)
                {
                    tb_aliquota_imposto.Text = perc_icms;
                    tb_percentual_red_bc.Text = perc_reducao;

                }
                */
                double valor_total_item = 0;
                try
                {
                    valor_total_item = Convert.ToDouble(valor_total_prod);
                }
                catch { }
                double valor_ali_icms = 0;
                try
                {
                    valor_ali_icms = Convert.ToDouble(tb_aliquota_imposto.Text);
                    icm_item_2 = valor_ali_icms;
                }
                catch { }
                double valor_ali_st_icms = 0;
                try
                {
                    valor_ali_st_icms = Convert.ToDouble(tb_st_aliq_imp.Text);
                }
                catch { }
                double valor_red_icm = 0;
                try
                {
                    valor_red_icm = Convert.ToDouble(tb_percentual_red_bc.Text);
                }
                catch { }

                double valor_ali_ipi = 0;
                try
                {
                    tabControl1.SelectedTab = tabPage2;
                    valor_ali_ipi = Convert.ToDouble(tb_ali_ipi.Text.Replace(",", "."));
                    ipi_item_2 = valor_ali_ipi;
                    tabControl1.SelectedTab = tabPage1;
                }
                catch { }
                double valor_ipi = (valor_total_item * valor_ali_ipi) / 100;
                valor_ipi_item_2 = valor_ipi.ToString("n2");
                if (cb_bc_com_ipi.Checked == true)
                {
                    valor_total_item = valor_total_item + valor_ipi;
                    tb_valor_bc_com_ipi.Text = valor_total_item.ToString("n2");

                }

                double valor_base_red_icm;
                double valor_icms_com_red;
                double valor_icms = 0;
                if (valor_red_icm > 0) //se tiver redução da base de cálculo
                {
                    valor_icms = (valor_total_item * valor_ali_icms) / 100;
                    valor_icms_com_red = valor_icms - (valor_icms * (valor_red_icm / 100));
                    valor_base_red_icm = valor_total_item - (valor_total_item * (valor_red_icm / 100));
                    tb_valor_bc_icms.Text = valor_base_red_icm.ToString("n2");
                    valor_bc_item_2 = valor_base_red_icm.ToString("n2");
                    valor_icm_item_2 = valor_icms_com_red.ToString("n2");
                    valor_icms = valor_icms_com_red;
                }
                else
                {
                    if (tb_tributacao_icms.Text != "41")
                    {
                        valor_icms = (valor_total_item * valor_ali_icms) / 100;
                        valor_icm_item_2 = valor_icms.ToString("n2");
                        tb_valor_bc_icms.Text = valor_total_item.ToString("n2");
                        valor_bc_item_2 = valor_total_item.ToString("n2");
                    }
                }
                double valor_st_icms = (valor_ali_st_icms * valor_total_item) / 100;
                //double valor_ipi = (valor_total_item * valor_ali_ipi)/100;
                
                    inserir_valores_itens();
                
                tb_valor_icms.Text = valor_icms.ToString("n2");
                tb_st_val_icms.Text = valor_st_icms.ToString("n2");
                tabControl1.SelectedTab = tabPage2;
                tb_valor_ipi.Text = valor_ipi.ToString("n2");
                tabControl1.SelectedTab = tabPage1;
            }
            

            
            


        }
        private void inserir_valores_itens()
        {
            try
            {
                if (valor_icm_item_2 == "")
                    valor_icm_item_2 = "0";
                this.datItens_nota.UpdateCommand.CommandText =
                        "UPDATE ITENS_NOTA SET VALOR_ICM_ITEM = '" + valor_icm_item_2 + "' WHERE COD_ITENS_NOTA = " + tb_cod_item.Text + "";
                this.fbConnection1.Open();
                this.datItens_nota.UpdateCommand.Connection = fbConnection1;
                this.datItens_nota.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { }
            try
            {
                this.datItens_nota.UpdateCommand.CommandText =
                        "UPDATE ITENS_NOTA SET IPI_ITEM = '" + ipi_item_2.ToString("n2").Replace(",", ".") + "' WHERE COD_ITENS_NOTA = " + tb_cod_item.Text + "";
                this.fbConnection1.Open();
                this.datItens_nota.UpdateCommand.Connection = fbConnection1;
                this.datItens_nota.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { }

            try
            {
                this.datItens_nota.UpdateCommand.CommandText =
                        "UPDATE ITENS_NOTA SET VALOR_IPI_ITEM = '" + valor_ipi_item_2.Replace(",", ".") + "' WHERE COD_ITENS_NOTA = " + tb_cod_item.Text + "";
                this.fbConnection1.Open();
                this.datItens_nota.UpdateCommand.Connection = fbConnection1;
                this.datItens_nota.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { }

            try
            {
                this.datItens_nota.UpdateCommand.CommandText =
                        "UPDATE ITENS_NOTA SET ICM_ITEM = '" + icm_item_2.ToString("n2").Replace(",", ".") + "' WHERE COD_ITENS_NOTA = " + tb_cod_item.Text + "";
                this.fbConnection1.Open();
                this.datItens_nota.UpdateCommand.Connection = fbConnection1;
                this.datItens_nota.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { }

            try
            {
                this.datItens_nota.UpdateCommand.CommandText =
                        "UPDATE ITENS_NOTA SET VALOR_BC_ITEM = '" + valor_bc_item_2 + "' WHERE COD_ITENS_NOTA = " + tb_cod_item.Text + "";
                this.fbConnection1.Open();
                this.datItens_nota.UpdateCommand.Connection = fbConnection1;
                this.datItens_nota.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { }

        }
        private void calcular_valores_iss()
        {
            tabControl1.SelectedTab = tabPage5;
            double valor_total_item = 0;
            try
            {
                valor_total_item = Convert.ToDouble(valor_total_prod.Replace(".", ","));
            }
            catch { }
            double valor_ali_iss = 0;
            try
            {
                valor_ali_iss = Convert.ToDouble(tb_ali_iss.Text);
                iss_item_2 = valor_ali_iss;
            }
            catch { }

            double valor_iss = 0;
            try
            {
                valor_iss = (valor_total_item * valor_ali_iss) / 100;
            }
            catch { }
            inserir_valores_itens_iss();
            tb_val_bas_cal_iss.Text = valor_total_item.ToString("n2");
            tb_val_iss.Text = valor_iss.ToString("n2");
            valor_iss_item_2 = valor_iss.ToString("n2");
            tabControl1.SelectedTab = tabPage1;


        }

        private void inserir_valores_itens_iss()
        {
            try
            {
                this.datItens_nota.UpdateCommand.CommandText =
                        "UPDATE ITENS_NOTA SET VALOR_ISS_ITEM = '" + valor_iss_item_2 + "' WHERE COD_ITENS_NOTA = " + tb_cod_item.Text + "";
                this.fbConnection1.Open();
                this.datItens_nota.UpdateCommand.Connection = fbConnection1;
                this.datItens_nota.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { }
        }
        private void selecionar_tributacao()
        {

                       this.datTributacao.SelectCommand.CommandText =
                       "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + item_selecionado + "'";
                        this.fbConnection1.Open();
                        this.datTributacao.SelectCommand.Connection = fbConnection1;
                        this.datTributacao.SelectCommand.ExecuteNonQuery();
                        datTributacao.Fill(TRIBUTACAO);
                        this.fbConnection1.Close();
                    
                    

                
                
            
            
            
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            Atualizar();
            
            
        }

        
        private void Atualizar()
        {
            this.BindingContext[dsTributacao, "TRIBUTACAO"].EndCurrentEdit();
            if (dsTributacao.HasChanges())
            {
                fbConnection1.Open();
                datTributacao.UpdateCommand = cbTributacao.GetUpdateCommand();
                datTributacao.InsertCommand = cbTributacao.GetInsertCommand();
                datTributacao.DeleteCommand = cbTributacao.GetDeleteCommand();
                datTributacao.Update(dsTributacao, "TRIBUTACAO");
                dsTributacao.AcceptChanges();
                datTributacao.Fill(TRIBUTACAO);
                fbConnection1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procedimentos();
        }

        private void procedimentos()
        {
                calcular_valores();
                Atualizar_arquivo();
        }

        private void Atualizar_arquivo_iss()
        {
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\Nfe\\TRIBUTACAO\\TRIB" + tb_trib.Text + ".txt");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine("M|");
                tabControl1.SelectedTab = tabPage5;
                texto.WriteLine("U|" + transforma_decimal(2, tb_val_bas_cal_iss.Text, 15) + "|" + transforma_decimal(2, tb_ali_iss.Text, 15) + "|" + transforma_decimal(2, tb_val_iss.Text, 15) + "|" + tb_cod_mun_oco_fat_ger_iss.Text + "|" + tb_cod_list_ser.Text + "|");
            }
        }

        private void Atualizar_arquivo()
        {
            FileInfo t = new FileInfo("c:\\evolucao_dokinos\\Nfe\\TRIBUTACAO\\TRIB" + tb_trib.Text +  ".txt");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine("M|");
                texto.WriteLine("N|");
                if (rb_00.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string mod_det_bc_icms = "";
                    mod_det_bc_icms = cb_mod_det_bc_icms.Text.Remove(1); 
                    string valor_bc_icms = transforma_decimal(2, tb_valor_bc_icms.Text, 15);
                    string aliq_imp = transforma_decimal(2, tb_aliquota_imposto.Text, 5);
                    string valor_icms = transforma_decimal(2, tb_valor_icms.Text, 15);
                    texto.WriteLine("N02|" + origem_merc + "|00|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" );
                    decimal_correto = "";
                }
                if (rb_10.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string mod_det_bc_icms = cb_mod_det_bc_icms.Text.Remove(1);
                    string valor_bc_icms = transforma_decimal(2, tb_valor_bc_icms.Text, 15);
                    string aliq_imp = transforma_decimal(2, tb_aliquota_imposto.Text, 5);
                    string valor_icms = transforma_decimal(2, tb_valor_icms.Text, 15);
                    string st_mod_det_bc_icms = cb_st_mod_det_bc_icms.Text.Remove(1);
                    string st_per_mar_val_adi_icm = transforma_decimal(2, tb_st_perc_mar_val_icms.Text, 5);
                    //if (st_per_mar_val_adi_icm == "0.00")
                      //  st_per_mar_val_adi_icm = "";
                    string st_per_red_bc_icm = transforma_decimal(2, tb_st_perc_red_bc_icms.Text, 5);
                    //if (st_per_red_bc_icm == "0.00")
                    //    st_per_red_bc_icm = "";
                    string st_val_bc_icm = transforma_decimal(2, tb_st_valor_bc_icms.Text, 15);
                    string st_ali_imp_icm = transforma_decimal(2, tb_st_aliq_imp.Text, 5);
                    string st_valor_icms = transforma_decimal(2, tb_st_val_icms.Text, 15);
                    texto.WriteLine("N03|" + origem_merc + "|10|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|" );
                    decimal_correto = "";
                }

                if (rb_20.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string mod_det_bc_icms = cb_mod_det_bc_icms.Text.Remove(1);
                    string per_red_bc = transforma_decimal(2, tb_percentual_red_bc.Text, 5);
                    //if (per_red_bc == "0.00")
                    //    per_red_bc = "";
                    string valor_bc_icms = transforma_decimal(2, tb_valor_bc_icms.Text, 15);
                    string aliq_imp = transforma_decimal(2, tb_aliquota_imposto.Text, 5);
                    string valor_icms = transforma_decimal(2, tb_valor_icms.Text, 15);
                    texto.WriteLine("N04|" + origem_merc + "|20|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|");
                    decimal_correto = "";
                }

                if (rb_30.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string st_mod_det_bc_icms = cb_st_mod_det_bc_icms.Text.Remove(1);
                    string st_per_mar_val_adi_icm = transforma_decimal(2, tb_st_perc_mar_val_icms.Text, 5);
                    //if (st_per_mar_val_adi_icm == "0.00")
                     //   st_per_mar_val_adi_icm = "";
                    string st_per_red_bc_icm = transforma_decimal(2, tb_st_perc_red_bc_icms.Text, 5);
                    //if (st_per_red_bc_icm == "0.00")
                       // st_per_red_bc_icm = "";
                    string st_val_bc_icm = transforma_decimal(2, tb_st_valor_bc_icms.Text, 15);
                    string st_ali_imp_icm = transforma_decimal(2, tb_st_aliq_imp.Text, 5);
                    string st_valor_icms = transforma_decimal(2, tb_st_val_icms.Text, 15);
                    texto.WriteLine("N05|" + origem_merc + "|10|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|");
                    decimal_correto = "";
                }

                if (rb_40.Checked == true || rb_41.Checked == true || rb_50.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string trib_icms = "";
                    if (rb_40.Checked == true)
                        trib_icms = "40";
                    if (rb_41.Checked == true)
                        trib_icms = "41";
                    if (rb_50.Checked == true)
                        trib_icms = "50";
                    texto.WriteLine("N06|" + origem_merc + "|" + trib_icms + "|");
                    decimal_correto = "";
                }

                if (rb_51.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string mod_det_bc_icms = cb_mod_det_bc_icms.Text.Remove(1);
                    string per_red_bc = transforma_decimal(2, tb_percentual_red_bc.Text, 5);
                    //if (per_red_bc == "0.00")
                        //per_red_bc = "";
                    string valor_bc_icms = transforma_decimal(2, tb_valor_bc_icms.Text, 15);
                    string aliq_imp = transforma_decimal(2, tb_aliquota_imposto.Text, 5);
                    string valor_icms = transforma_decimal(2, tb_valor_icms.Text, 15);
                    texto.WriteLine("N07|" + origem_merc + "|51|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|");
                    decimal_correto = "";
                }

                if (rb_60.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string st_val_bc_icm = transforma_decimal(2, tb_st_valor_bc_icms.Text, 15);
                    string st_valor_icms = transforma_decimal(2, tb_st_val_icms.Text, 15);
                    texto.WriteLine("N08|" + origem_merc + "|60|" + st_val_bc_icm + "|" + st_valor_icms + "|");
                    decimal_correto = "";
                }

                if (rb_70.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string mod_det_bc_icms = cb_mod_det_bc_icms.Text.Remove(1);
                    string per_red_bc = transforma_decimal(2, tb_percentual_red_bc.Text, 5);
                   // if (per_red_bc == "0.00")
                      //  per_red_bc = "";
                    string valor_bc_icms = transforma_decimal(2, tb_valor_bc_icms.Text, 15);
                    string aliq_imp = transforma_decimal(2, tb_aliquota_imposto.Text, 5);
                    string valor_icms = transforma_decimal(2, tb_valor_icms.Text, 15);
                    string st_mod_det_bc_icms = cb_st_mod_det_bc_icms.Text.Remove(1);
                    string st_per_mar_val_adi_icm = transforma_decimal(2, tb_st_perc_mar_val_icms.Text, 5);
                    //if (st_per_mar_val_adi_icm == "0.00")
                    //    st_per_mar_val_adi_icm = "";
                    string st_per_red_bc_icm = transforma_decimal(2, tb_st_perc_red_bc_icms.Text, 5);
                    //if (st_per_red_bc_icm == "0.00")
                    //    st_per_red_bc_icm = "";
                    string st_val_bc_icm = transforma_decimal(2, tb_st_valor_bc_icms.Text, 15);
                    string st_ali_imp_icm = transforma_decimal(2, tb_st_aliq_imp.Text, 5);
                    string st_valor_icms = transforma_decimal(2, tb_st_val_icms.Text, 15);
                    texto.WriteLine("N09|" + origem_merc + "|90|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + per_red_bc + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|");
                    decimal_correto = "";
                }

                if (rb_90.Checked == true)
                {
                    string origem_merc = cb_origem_mercadoria.Text.Remove(1);
                    string mod_det_bc_icms = cb_mod_det_bc_icms.Text.Remove(1);
                    string per_red_bc = transforma_decimal(2, tb_percentual_red_bc.Text, 5);
                    //if (per_red_bc == "0.00")
                    //    per_red_bc = "";
                    string valor_bc_icms = transforma_decimal(2, tb_valor_bc_icms.Text, 15);
                    string aliq_imp = transforma_decimal(2, tb_aliquota_imposto.Text, 5);
                    string valor_icms = transforma_decimal(2, tb_valor_icms.Text, 15);
                    string st_mod_det_bc_icms = cb_st_mod_det_bc_icms.Text.Remove(1);
                    string st_per_mar_val_adi_icm = transforma_decimal(2, tb_st_perc_mar_val_icms.Text, 5);
                    //if (st_per_mar_val_adi_icm == "0.00")
                   ///     st_per_mar_val_adi_icm = "";
                    string st_per_red_bc_icm = transforma_decimal(2, tb_st_perc_red_bc_icms.Text, 5);
                   // if (st_per_red_bc_icm == "0.00")
                    //    st_per_red_bc_icm = "";
                    string st_val_bc_icm = transforma_decimal(2, tb_st_valor_bc_icms.Text, 15);
                    string st_ali_imp_icm = transforma_decimal(2, tb_st_aliq_imp.Text, 5);
                    string st_valor_icms = transforma_decimal(2, tb_st_val_icms.Text, 15);
                    texto.WriteLine("N10|" + origem_merc + "|90|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + per_red_bc + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|");
                    decimal_correto = "";
                }
                //IPI
                tabControl1.SelectedTab = tabPage2;
                    texto.WriteLine("O|||||999|");
                    string cod_sit_tri_ipi = "";
                    if (rb_ipi_tributavel.Checked == true)
                    {
                         cod_sit_tri_ipi = cb_cod_sit_tri_ipi.Text.Remove(2);
                         string valor_ipi = transforma_decimal(2, tb_valor_ipi.Text, 15);
                         texto.WriteLine("O07|" + cod_sit_tri_ipi + "|" + valor_ipi + "|");
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
                    }
                    if (rb_ipi_nao_tributavel.Checked == true)
                    {
                        cod_sit_tri_ipi = cb_cod_sit_trib_n_trib.Text.Remove(2);
                        string valor_ipi = transforma_decimal(2, tb_valor_ipi.Text, 15);
                        texto.WriteLine("O08|" + cod_sit_tri_ipi + "|");
                        //texto.WriteLine("O08|" + cod_sit_tri_ipi + "|" + valor_ipi + "|");
                        /*
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
                tabControl1.SelectedTab = tabPage3;
                if (tb_aliq_pis.Text != "")
                {
                    texto.WriteLine("Q|");
                    texto.WriteLine("Q02|" + cb_cod_sit_trib_pis.Text[0] + cb_cod_sit_trib_pis.Text[1] + "|" + transforma_decimal(2, tb_valor_bc_pis.Text, 15) + "|" + transforma_decimal(2, tb_aliq_pis.Text, 5) + "|" + transforma_decimal(2, tb_valor_pis.Text, 15) + "|");
                }
                else
                {
                    texto.WriteLine("Q|");
                    texto.WriteLine("Q04|07|");
                }
                tabControl1.SelectedTab = tabPage4;
                if(tb_aliquota_cofins.Text != "")
                {
                        texto.WriteLine("S|");
                        texto.WriteLine("S02|" + cb_cod_sit_trib_cofins.Text[0] + cb_cod_sit_trib_cofins.Text[1] + "|" + transforma_decimal(2, tb_valor_bc_cofins.Text, 15) + "|" + transforma_decimal(2, tb_aliquota_cofins.Text, 5) + "|" + transforma_decimal(2, tb_valor_cofins.Text, 15) + "|");
                }
                else
                {
                   
                    texto.WriteLine("S|");
                    texto.WriteLine("S04|07|");
                }
                
                if (prestacao_servico == true)
                {
                    tabControl1.SelectedTab = tabPage5;
                    texto.WriteLine("U|" + transforma_decimal(2, tb_val_bas_cal_iss.Text, 15) + "|" + transforma_decimal(2, tb_ali_iss.Text, 15) + "|" + transforma_decimal(2, tb_val_iss.Text, 15) + "|" + tb_cod_mun_oco_fat_ger_iss.Text + "|" + tb_cod_list_ser.Text + "|");
                }

                    
                
            }

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
            //if (numero == "0,00")
              //  numero = "";

            return numero.Replace(",", ".");
            /*
            try
            {
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
                else
                {
                    numero = numero + ",00";
                    while (numero[pos_virgula].ToString() != ",")
                    {
                        pos_virgula++;
                    }
                    n = numero.Remove(pos_virgula);
                    pos_virgula++; //por que começa com 0

                }

                int numero_inteiro = Convert.ToInt32(n);
                decimal numero_decimal_1 = new decimal();
                decimal numero_decimal_2 = new decimal();
                numero_decimal_1 = Convert.ToDecimal(numero);
                numero_decimal_2 = Convert.ToDecimal(n);
                decimal numero_decimal = numero_decimal_1 - numero_decimal_2;
                int qtde_decimais = numero_decimal.ToString().Length - 2;
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
                //int tamanho = numero_correto.Length;
             *     return numero_correto;
            }
            catch
            {
                return "";
            }
                /*
                for (int j = numero_correto.Length; j < n_caracteres; j++)
                {
                    numero_correto = "0" + numero_correto;

                }
                 * */
            
        

        }

        private void form_tributacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            cod_trib = tb_trib.Text;
            Atualizar();
           
                Atualizar_arquivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nova_trib();
        }

        private void nova_trib()
        {

            //if (DialogResult.Yes == MessageBox.Show("Será cadastrado uma tributação, tem certeza?",
            //   "Confirma a inserção?", MessageBoxButtons.YesNo))
            //{
                try
                {

                    this.datTributacao.InsertCommand.CommandText =
                    "INSERT INTO TRIBUTACAO (COD_NF_TRIB) VALUES ('" + item_selecionado + "')";
                    this.fbConnection1.Open();
                    this.datTributacao.InsertCommand.Connection = fbConnection1;
                    this.datTributacao.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsTributacao.Clear();
                    this.datTributacao.SelectCommand.CommandText =
                           "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + item_selecionado + "'";
                    this.fbConnection1.Open();
                    this.datTributacao.SelectCommand.Connection = fbConnection1;
                    this.datTributacao.SelectCommand.ExecuteNonQuery();
                    datTributacao.Fill(TRIBUTACAO);
                    this.fbConnection1.Close();
               }
                catch
                {
                    fbConnection1.Close();
                }
                
            //}
        }

        private void cb_st_mod_det_bc_icms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_bc_com_ipi.Checked == true)
            {
                label_valor_bc_com_ipi.Visible = true;
                tb_valor_bc_com_ipi.Visible = true;
            }
            else
            {
                label_valor_bc_com_ipi.Visible = false;
                tb_valor_bc_com_ipi.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcular_valores();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            calcular_pis();
        }

        private void calcular_pis()
        {
            pis = true;
            string perc_icms, perc_icms_st, perc_reducao,
             perc_reducao_st, perc_mar_val_ad_st, perc_icms_fe, perc_icms_st_fe,
             perc_reducao_fe, perc_reducao_st_fe, perc_mar_val_ad_st_fe, perc_ipi,
             perc_ipi_fe, perc_prest_serv, perc_prest_serv_fe, perc_pis, perc_cofins;
            buscar_valores_tributacao(out perc_icms, out perc_icms_st, out perc_reducao,
             out perc_reducao_st, out perc_mar_val_ad_st, out perc_icms_fe, out perc_icms_st_fe,
             out perc_reducao_fe, out perc_reducao_st_fe, out perc_mar_val_ad_st_fe, out perc_ipi,
             out perc_ipi_fe, out perc_prest_serv, out perc_prest_serv_fe, out perc_pis, out perc_cofins, variavel_trib, cod_variavel_trib);

            cb_cod_sit_trib_pis.Text =  "01 - Operação Tributável (base de cálculo = valor da operação alíquota normal (cumulativo/não cumulativo))";
            tb_aliq_pis.Text = perc_pis;
            tb_valor_bc_pis.Text = valor_total_prod;
            try
            {
                double _valor_pis = Convert.ToDouble(tb_valor_bc_pis.Text) * (Convert.ToDouble(tb_aliq_pis.Text) / 100);
                tb_valor_pis.Text = _valor_pis.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Erro no cálculo do PIS");
            }
            
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            calcular_cofins();
        }

        private void calcular_cofins()
        {
            cofins = true;
            string perc_icms, perc_icms_st, perc_reducao,
             perc_reducao_st, perc_mar_val_ad_st, perc_icms_fe, perc_icms_st_fe,
             perc_reducao_fe, perc_reducao_st_fe, perc_mar_val_ad_st_fe, perc_ipi,
             perc_ipi_fe, perc_prest_serv, perc_prest_serv_fe, perc_pis, perc_cofins;
            buscar_valores_tributacao(out perc_icms, out perc_icms_st, out perc_reducao,
             out perc_reducao_st, out perc_mar_val_ad_st, out perc_icms_fe, out perc_icms_st_fe,
             out perc_reducao_fe, out perc_reducao_st_fe, out perc_mar_val_ad_st_fe, out perc_ipi,
             out perc_ipi_fe, out perc_prest_serv, out perc_prest_serv_fe, out perc_pis, out perc_cofins, variavel_trib, cod_variavel_trib);

            cb_cod_sit_trib_cofins.Text = "01 - Operação Tributável (base de cálculo = valor da operação alíquota normal (cumulativo/não cumulativo))";
            tb_aliquota_cofins.Text = perc_cofins;
            tb_valor_bc_cofins.Text = valor_total_prod;
            try
            {
                double _valor_cofins = Convert.ToDouble(tb_valor_bc_cofins.Text) * (Convert.ToDouble(tb_aliquota_cofins.Text) / 100);
                tb_valor_cofins.Text = _valor_cofins.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Erro no cálculo do COFINS");
            }
        }
            
        

       
    }
}