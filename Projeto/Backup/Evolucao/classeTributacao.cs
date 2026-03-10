using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    class classeTributacao
    {
        //PROPRIEDADES

        //ICMS
        public string orig;
        public string CST; //PARA OPERAÇÃO NORMAL
        public string modBC;
        public double vBC;
        public double pICMS;
        public double vICMS;
        public double pRedBC;

        public string modBCST;
        public double pMVAST;
        public double pRedBCST;
        public double vBCST;
        public double pICMSST;
        public double vICMSST;

       
        //SIMPLES NACIONAL
        public double pCredSN;
        public double vCredICMSSN;

        //IPI
        public double BCIPI;
        public double pIPI;
        public double vIPI;
        public bool ipiTributado;
        public bool ipiNaoTributado;
        public string cstIPITributado;
        public string cstIPINaoTributado;
        public string ipiTributado_2;
        public string ipiNaoTributado_2;

        //PIS
        public double BCPIS;
        public double pPIS;
        public double vPIS;
        public string tipoPIS;
        public string cstPIS;

        //COFINS
        public double BCCOFINS;
        public double pCOFINS;
        public double vCOFINS;
        public string tipoCOFINS;
        public string cstCOFINS;

        //ISS
        public double BCISS;
        public double pISS;
        public double vISS;
        public string tipoISS;

        public void cst00() //ICMS NORMAL
        {
            vICMS = vBC * pICMS/100;
        }

        public void cst10() // ICMS COM ST
        {
            vICMS = vBC * pICMS / 100;
            vBCST = vBC + (vBC * pMVAST/100);
            double valor_temp_icms_st = vBCST * pICMSST/100;
            vICMSST =  valor_temp_icms_st - vICMS;
        }

        public void cst20() // ICMS COM REDUCAO
        {
            vBC = vBC - (vBC * pRedBC / 100);
            vICMS = vBC * pICMS / 100;
        }

        public void cst70() // REDUCAO E ST
        {
            /*
            vBC = vBC - (vBC * pRedBCST / 100);
            vICMS = vBC * pICMS / 100;
            vBCST = vBC + (vBC * pMVAST / 100);
            double valor_temp_icms_st = vBCST * pICMSST / 100;
            vICMSST = valor_temp_icms_st - vICMS;
             * */
            double _vBC = vBC;
            vBC = vBC - (vBC * pRedBC / 100);
            vICMS = vBC * pICMS / 100;
            vBCST = _vBC - (_vBC * pRedBCST / 100); //reduzindo
            vBCST = vBCST + (vBCST * pMVAST / 100); //st
            double vICMS_temp = vBC * pICMS / 100;
            double valor_temp_icms_st = vBCST * pICMSST / 100;
            vICMSST = valor_temp_icms_st - vICMS_temp;
        }

        public void inserir_informacoes_item(string item)
        {
            try
            {
                //TRATANDO VALORES EM BRANCO
                string _orig = "null", _CST = "null", _modBC = "null",
                    _vBC = "null", _pICMS = "null", _vICMS = "null", _pRedBC = "null",
                    _modBCST = "null", _pMVAST = "null", _pRedBCST = "null", _vBCST = "null",
                    _pICMSST = "null", _vICMSST = "null", _pCredSN = "null", _vCredICMSSN = "null",
                    _BCIPI = "null", _vIPI = "null", _pIPI = "null", _cstIPITributado = "null", _cstIPINaoTributado = "null",
                    _BCPIS = "null", _pPIS = "null", _vPIS = "null", _tipoPIS = "null", _cstPIS = "null",
                    _BCCOFINS = "null", _pCOFINS = "null", _vCOFINS = "null", _tipoCOFINS = "null", _cstCOFINS = "null",
                    _BCISS = "null", _pISS = "null", _vISS = "null", _tipoISS = "null";

                
                try
                {
                    if (orig != "")
                        _orig = "'" + orig + "'";
                }
                catch { }
                try
                {
                    if (CST != "")
                        _CST = "'" + CST + "'";
                }
                catch { }
                //ICMS
                try
                {
                    if (modBC != "")
                        _modBC = "'" + modBC + "'";
                }
                catch { }
                try
                {
                    if (vBC > 0)
                        _vBC = "'" + vBC.ToString("n2").Replace(".","") + "'";//.Replace(".","").Replace(",",".") + "'";
                }
                catch { }
                try
                {
                    if (pICMS > 0)
                        _pICMS = "'" + pICMS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vICMS > 0)
                        _vICMS = "'" + vICMS.ToString() + "'";//.Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pRedBC > 0)
                        _pRedBC = "'" + pRedBC.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (modBCST != "")
                        _modBCST = "'" + modBCST + "'";
                }
                catch { }
                try
                {
                    if (pMVAST > 0)
                        _pMVAST = "'" + pMVAST.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pRedBCST > 0)
                        _pRedBCST = "'" + pRedBCST.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vBCST > 0)
                        _vBCST = "'" + vBCST.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pICMSST > 0)
                        _pICMSST = "'" + pICMSST.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vICMSST > 0)
                        _vICMSST = "'" + vICMSST.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                //CREDITO SIMPLES
                try
                {
                    if (pCredSN > 0)
                        _pCredSN = "'" + pCredSN.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vCredICMSSN > 0)
                        _vCredICMSSN = "'" + vCredICMSSN.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                //IPI
                try
                {
                    if (BCIPI > 0)
                        _BCIPI = "'" + BCIPI.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vIPI > 0)
                        _vIPI = "'" + vIPI.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pIPI > 0)
                        _pIPI = "'" + pIPI.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (cstIPITributado != "")
                        _cstIPITributado = "'" + cstIPITributado + "'";
                }
                catch { }
                try
                {
                    if (cstIPINaoTributado != "")
                        _cstIPINaoTributado = "'" + cstIPINaoTributado + "'";
                }
                catch { }
                if (ipiTributado)
                {
                    ipiTributado_2 = "'1'";
                    ipiNaoTributado_2 = "null";
                }
                else
                {
                    ipiTributado_2 = "null";
                    ipiNaoTributado_2 = "'1'";
                }
                //PIS
                try
                {
                    if (BCPIS > 0)
                        _BCPIS = "'" + BCPIS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pPIS > 0)
                        _pPIS = "'" + pPIS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vPIS > 0)
                        _vPIS = "'" + vPIS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (tipoPIS != "")
                        _tipoPIS = "'" + tipoPIS + "'";
                }
                catch { }
                try
                {
                    if (cstPIS != "")
                        _cstPIS = "'" + cstPIS + "'";
                }
                catch { }
                //COFINS
                try
                {
                    if (BCCOFINS > 0)
                        _BCCOFINS = "'" + BCCOFINS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pCOFINS > 0)
                        _pCOFINS = "'" + pCOFINS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vCOFINS > 0)
                        _vCOFINS = "'" + vCOFINS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (tipoCOFINS != "")
                        _tipoCOFINS = "'" + tipoCOFINS + "'";
                }
                catch { }
                try
                {
                    if (cstCOFINS != "")
                        _cstCOFINS = "'" + cstCOFINS + "'";
                }
                catch { }
                //ISS
                try
                {
                    if (BCISS > 0)
                        _BCISS = "'" + BCISS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pISS > 0)
                        _pISS = "'" + pISS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vISS > 0)
                        _vISS = "'" + vISS.ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (tipoISS != "")
                        _tipoISS = "'" + tipoISS + "'";
                }
                catch { }
               
                FbCommand comando_select = new FbCommand();
                comando_select.CommandText =
                    "UPDATE ITENS_NOTA SET ORIGEM_ITEM = " + _orig + ", " +
                    "ST_ITEM = " + _CST + ", " +
                    "VALOR_BC_ITEM = " + _vBC + ", " +
                    //ICMS
                    "ICM_ITEM = " + _pICMS + ", " +
                    "VALOR_ICM_ITEM = " + _vICMS + ", " +
                    "REDUCAO_ITEM = " + _pRedBC + ", " +
                    "MOD_BC_ITEM = " + _modBC + ", " +
                    "MOD_BC_ST_ITEM = " + _modBCST + ", " +
                    "IVA_ITEM = " + _pMVAST + ", "+ 
                    "REDUCAO_ST_ITEM = " + _pRedBCST + ", " +
                    "VALOR_BC_ICMS_ST_ITEM = " + _vBCST + ", " +
                    "ICMS_ST_ITEM = " + _pICMSST + ", " + 
                    "VALOR_ICMS_ST_ITEM = " + _vICMSST  + ", " +
                    //SIMPLES
                    "ALIQUOTA_CREDITO_ITEM = " + _pCredSN + ", "+
                    "VALOR_CREDITO_ITEM = " + _vCredICMSSN + ", " +
                    //IPI
                    "BC_IPI_ITEM = " + _BCIPI + ", " + 
                    "IPI_ITEM = " + _pIPI + ", " +
                    "VALOR_IPI_ITEM = " + _vIPI + ", " +
                    "IPI_TRIB_ITEM = " + ipiTributado_2  + ", " + 
                    "IPI_N_TRIB_ITEM = " + ipiNaoTributado_2 + ", " + 
                    "CST_IPI_TRIB_ITEM = " + _cstIPITributado + ", " +
                    "CST_IPI_N_TRIB_ITEM = " + _cstIPINaoTributado + ", " +
                    //PIS
                    "BC_PIS_ITEM = " + _BCPIS + ", " + 
                    "PIS_ITEM = " + _pPIS + ", " + 
                    "VALOR_PIS_ITEM = " + _vPIS + ", " +
                    "TIPO_PIS_ITEM = " + _tipoPIS + ", " +
                    "CST_PIS_ITEM = " + _cstPIS + ", " +
                    //COFINS
                    "BC_COFINS_ITEM = " + _BCCOFINS + ", " +
                    "COFINS_ITEM = " + _pCOFINS + ", " +
                    "VALOR_COFINS_ITEM = " + _vCOFINS + ", " +
                    "TIPO_COFINS_ITEM = " + _tipoCOFINS + ", " +
                    "CST_COFINS_ITEM = " + _cstCOFINS + ", " +
                    //ISS
                    "BC_ISS_ITEM = " + _BCISS + ", " +
                    "ISS_ITEM = " + _pISS + ", " +
                    "VALOR_ISS_ITEM = " + _vISS + ", " +
                    "TIPO_SERVICO_ITEM = " + _tipoISS + " " +
                "WHERE COD_ITENS_NOTA = '" + item + "'";
                FbDataAdapter datItens_nota = new FbDataAdapter();
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                conexao.Open();
                comando_select.Connection = conexao;
                datItens_nota.UpdateCommand = comando_select;
                datItens_nota.UpdateCommand.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception a)
            {
                form_erro erro = new form_erro();
                erro.erro = a.ToString();
                erro.ShowDialog();
            }
        }

        public void cst101()
        {
            vCredICMSSN = pCredSN * vBC / 100;
        }

        public void cst201()
        {
            vCredICMSSN = pCredSN * vBC / 100;
            vICMS = vBC * pICMS / 100;
            vBCST = vBC + (vBC * pMVAST / 100);
            double valor_temp_icms_st = vBCST * pICMSST / 100;
            vICMSST = valor_temp_icms_st - vICMS;
            pICMS = 0;
            vICMS = 0; //ZERAR O ICMS PORQUE QUANDO É SIMPLES NACIONAL NÃO DESTACA NA NF O ICMS QUANDO TEM ST
            vBC = 0; //IDEM, NÃO TEM BASE DE CALCULO ICMS QUANDO É SIMPLES
        }

        public void cst202()
        {
            vICMS = vBC * pICMS / 100;
            vBCST = vBC + (vBC * pMVAST / 100);
            double valor_temp_icms_st = vBCST * pICMSST / 100;
            vICMSST = valor_temp_icms_st - vICMS;
            pICMS = 0;
            vICMS = 0; //ZERAR O ICMS PORQUE QUANDO É SIMPLES NACIONAL NÃO DESTACA NA NF O ICMS QUANDO TEM ST
            vBC = 0; //IDEM, NÃO TEM BASE DE CALCULO ICMS QUANDO É SIMPLES
        }

        public void cst500()
        {
            //vBCST = vBC + (vBC * pMVAST / 100);
            vICMS = 0; //ZERAR O ICMS PORQUE QUANDO É SIMPLES NACIONAL NÃO DESTACA NA NF O ICMS QUANDO TEM ST
            vBC = 0; //IDEM, NÃO TEM BASE DE CALCULO ICMS QUANDO É SIMPLES
            
        }

        internal void calcular_ipi()
        {
            vIPI = BCIPI * pIPI / 100;
        }

        internal void calcular_pis()
        {
            vPIS = BCPIS * pPIS / 100;
        }

        internal void calcular_cofins()
        {
            vCOFINS = BCCOFINS * pCOFINS / 100;
        }

        internal void calcular_iss()
        {
            vISS = BCISS * pISS / 100;
        }

        internal void cst60()
        {
            vBCST = 0;
            vICMSST = 0;
        }
    }
}
