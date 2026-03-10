using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolucao.Modelos
{
    public class ModeloProduto
    {
        public int COD_PRODUTO { get; set; }
        public int COD_GRUPO_PRODUTO { get; set; }
        public string DESCRICAO_GRUPO_PRODUTO { get; set; }
        public int COD_SUB_GRUPO_PRODUTO { get; set; }
        public string DESCRICAO_SUB_GRUPO_PRODUTO { get; set; }
        public string DESCRICAO_PRODUTO { get; set; }
        public string CARACT_ADIC_PRODUTO { get; set; }
        public string COD_BARRAS_PRODUTO { get; set; }
        public string COD_ONU_PRODUTO { get; set; }
        public string CLASSE_TOXIC_PRODUTO { get; set; }
        public string COD_UNIDADE_PRODUTO { get; set; }
        public string DESCRICAO_UNIDADE_PRODUTO { get; set; }
        public double META_ANUAL_PRODUTO { get; set; }
        public string COD_REDUZIDO_PRODUTO { get; set; }
        public int TAB_PRODUTO { get; set; }
        public double META_SEMESTRAL_PRODUTO { get; set; }
        public double ESTOQUE_ATUAL_PRODUTO { get; set; }
        public double ESTOQUE_RESERVADO_PRODUTO { get; set; }
        public double ESTOQUE_MINIMO_PRODUTO { get; set; }
        public double ESTOQUE_ENCOMENDADO_PRODUTO { get; set; }
        public double ESTOQUE_MAXIMO_PRODUTO { get; set; }
        public double ESTOQUE_MEDIO_PRODUTO { get; set; }
        public double CUSTO_PRODUTO { get; set; }
        public double CUSTO_MED_PRODUTO { get; set; }
        public double VALOR_VENDA_PRODUTOR_PRODUTO { get; set; }
        public double VALOR_VENDA_REVEND_PRODUTO { get; set; }
        public double VALOR_PROMOCAO_PRODUTO { get; set; }
        public double OUTRO_VALOR_PRODUTO { get; set; }
        public double LUCRO_PRODUTO { get; set; }
        public DateTime ULT_REAJ_PRODUTO { get; set; }
        public int PROD_RECEITA_PRODUTO { get; set; }
        public string STATUS_PRODUTO { get; set; }
        public int ICMS_S_N_PRODUTO { get; set; }
        public double ALIQUOTA_ICMS_PRODUTO { get; set; }
        public double REDUCAO_FORA_PRODUTO { get; set; }
        public double ALIQUOTA_IPI_PRODUTO { get; set; }
        public int PIS_PRODUTO { get; set; }
        public int COFINS_PRODUTO { get; set; }
        public double COMISSAO_PRODUTO { get; set; }
        public int COD_MARCA_PRODUTO { get; set; }
        public string MARCA_PRODUTO { get; set; }
        public double IVA_PRODUTO { get; set; }
        public string NCM_PRODUTO { get; set; }
        public string DESCRICAO_ITEM_PRODUTO { get; set; }
        public string COD_FORNECEDOR_PRODUTO { get; set; }
        public string CFOP_ENTRADA_PRODUTO { get; set; }
        public string ORIGEM_PRODUTO { get; set; }
        public string LOCALIZACAO_PRODUTO { get; set; }
        public string ST_PRODUTO { get; set; }
        public int ICMS_FORA_S_N_PRODUTO { get; set; }
        public double ALIQUOTA_FORA_ICMS_PRODUTO { get; set; }
        public double REDUCAO_ICMS_PRODUTO { get; set; }
        public double IVA_FORA_PRODUTO { get; set; }
        public double ALIQUOTA_ICMS_ST_PRODUTO { get; set; }
        public double ALIQUOTA_ICMS_ST_FORA_PRODUTO { get; set; }
        public string ST_SAIDA_PRODUTO { get; set; }
        public string ST_SAIDA_FORA_PRODUTO { get; set; }
        public string MOD_BC_PRODUTO { get; set; }
        public double IPI_PRODUTO { get; set; }
        public double ICMS_PRODUTO { get; set; }
        public double ISS_PRODUTO { get; set; }
        public int PRESTACAO_SERVICO_PRODUTO { get; set; }
        public double REDUCAO_PRODUTO { get; set; }
        public string MOD_BC_ST_PRODUTO { get; set; }
        public double REDUCAO_ST_PRODUTO { get; set; }
        public int IPI_TRIB_PRODUTO { get; set; }
        public int IPI_N_TRIB_PRODUTO { get; set; }
        public string CST_IPI_TRIB_PRODUTO { get; set; }
        public string CST_IPI_N_TRIB_PRODUTO { get; set; }
        public string TIPO_PIS_PRODUTO { get; set; }
        public string CST_PIS_PRODUTO { get; set; }
        public string TIPO_COFINS_PRODUTO { get; set; }
        public string CST_COFINS_PRODUTO { get; set; }
        public string TIPO_SERVICO_PRODUTO { get; set; }
        public int BC_COM_IPI_PRODUTO { get; set; }
        public double REDUCAO_ST_FORA_PRODUTO { get; set; }
        public string UNIDADE_PRODUTO { get; set; }
        public string CNPJ_FORNECEDOR_PRODUTO { get; set; }
        public string NOME_FORNECEDOR_PRODUTO { get; set; }
        public double DESCONTO_MAXIMO_PRODUTO { get; set; }
        public int QTDE_UNIDADE_PRODUTO { get; set; }
        public string COD_BARRAS_CAIXA_PRODUTO { get; set; }
        public string NOME_FAMILIA_PRODUTO { get; set; }
        public double PESO_UNIT_PRODUTO { get; set; }
        public int PIS_COFINS_PRODUTO { get; set; }
        public double COEFICIENTE_LUCRO_PRODUTO { get; set; }
        public int CORTAR_SEM_ESTOQUE_PRODUTO { get; set; }
        public double ESTOQUE_DISPONIVEL_PRODUTO { get; set; }
        public double ESTOQUE_RESERVA_FECHADA_PRODUTO { get; set; }
        public string COD_ITEM_PEDIDO { get; set; }

    }
}
