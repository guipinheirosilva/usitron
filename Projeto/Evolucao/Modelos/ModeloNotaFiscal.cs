using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolucao.Modelos
{
    public class ModeloNotaFiscal
    {
        public int COD_SISTEMA_NF { get; set; }
        public int N_NF { get; set; }
        public int ENTRADA_NF { get; set; }
        public int SAIDA_NF { get; set; }
        public string FORMA_PGTO_NF { get; set; }
        public DateTime DATA_ENTR_SAI_NF { get; set; }
        public string DATA_EMISSAO_NF { get; set; }
        public DateTime DATA_VENCIMENTO_NF { get; set; }
        public string CFO_NF { get; set; }
        public string CFO_2_NF { get; set; }
        public string CLIENTE_FORN_NF { get; set; }
        public string ENDERECO_ENTREGA_NF { get; set; }
        public double BASE_CALC_ICMS_NF { get; set; }
        public double VALOR_ICMS_NF { get; set; }
        public double BASE_CALC_ICM_SUBS { get; set; }
        public double VALOR_ICM_SUBS { get; set; }
        public double VALOR_FRETE_NF { get; set; }
        public double VALOR_SEGURO_NF { get; set; }
        public double OUTRAS_DESP_NF { get; set; }
        public double VALOR_IPI_NF { get; set; }
        public double VALOR_TOT_PROD_NF { get; set; }
        public double VALOR_NOTA_NF { get; set; }
        public string TRANSPORTADORA_NF { get; set; }
        public int FRETE_CONTA_NF { get; set; }
        public string PLACA_VEICULO_NF { get; set; }
        public string ESTADO_VEICULO_NF { get; set; }
        public int QTDE_NF { get; set; }
        public string ESPECIE_NF { get; set; }
        public string MARCA_NF { get; set; }
        public double PESO_BRUTO_NF { get; set; }
        public double PESO_LIQUIDO_NF { get; set; }
        public string INF_COMPL_NF { get; set; }
        public string TIPO_MVTO_NF { get; set; }
        public string OBS_NF { get; set; }
        public string VALOR_EXTENSO_NF { get; set; }
        public int TRIBUTADA_NF { get; set; }
        public int COBRANCA_NF { get; set; }
        public int EXPORTACAO_NF { get; set; }
        public string UF_EMBARQUE_EXPORTACAO { get; set; }
        public string LOCAL_EMBARQUE_EXPORTACAO { get; set; }
        public int BENEFICIAMENTO_NF { get; set; }
        public string STATUS_NFE { get; set; }
        public string CHAVE_ACESSO_NFE { get; set; }
        public double VALOR_TOTAL_SERVICOS_NF { get; set; }
        public double BASE_CALCULO_ISS_NF { get; set; }
        public double VALOR_ISS_NF { get; set; }
        public string RECIBO_NFE { get; set; }
        public int ENTRADA_SAIDA_NF { get; set; }
        public string NATUREZA_OPERACAO_NF { get; set; }
        public string CNPJ_CLIENTE_FORN { get; set; }
        public string NOTA_STRING_NF { get; set; }
        public string END_NUMERO_STRING_NF { get; set; }
        public string RAZAO_SOCIAL_CL_NF { get; set; }
        public string IE_CL_NF { get; set; }
        public string CNPJ_CL_NF { get; set; }
        public string BAIRRO_CL_NF { get; set; }
        public string CIDADE_CL_NF { get; set; }
        public string ESTADO_CL_NF { get; set; }
        public string PAIS_CL_NF { get; set; }
        public string CEP_CL_NF { get; set; }
        public string FONE_CL_NF { get; set; }
        public string EMAIL_CL_NF { get; set; }
        public double VALOR_SIMPLES_NF { get; set; }
        public double ALIQUOTA_SIMPLES_NF { get; set; }
        public string N_PROTOCOLO_AUTORIZACAO_NF { get; set; }
        public int NFE_TESTE { get; set; }
        public DateTime DATA_AUTORIZACAO_NF { get; set; }
        public string HORA_AUTORIZACAO_NF { get; set; }
        public string ESTADO_CLIENTE_NF { get; set; }
        public int REFERENCIADA_NF { get; set; }
        public string N_NF_REFERENCIADA_NF { get; set; }
        public int SEQUENCIAL_CORRECAO_NF { get; set; }
        public string TEXTO_CORRECAO_NF { get; set; }
        public double TOTAL_TRIB_NF { get; set; }
        public string MOTIVO_CANCELAMENTO_NF { get; set; }
        public int LOTE_ENVIO_NF { get; set; }
    }
}
