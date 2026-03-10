namespace Evolucao
{
    partial class form_gerar_xml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gerar_xml));
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.datCte = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommand4 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand2 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbCommand3 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.dsCte = new System.Data.DataSet();
            this.CTE = new System.Data.DataTable();
            this.COD_CTE = new System.Data.DataColumn();
            this.N_CTE = new System.Data.DataColumn();
            this.DATA_EMISSAO_CTE = new System.Data.DataColumn();
            this.HORA_EMISSAO_CTE = new System.Data.DataColumn();
            this.CFOP_CTE = new System.Data.DataColumn();
            this.NATUREZA_OPERACAO_CTE = new System.Data.DataColumn();
            this.EMITENTE_NOME_CTE = new System.Data.DataColumn();
            this.EMITENTE_CNPJ_CTE = new System.Data.DataColumn();
            this.REMETENTE_NOME_CTE = new System.Data.DataColumn();
            this.REMETENTE_CNPJ_CTE = new System.Data.DataColumn();
            this.DESTINATARIO_NOME_CTE = new System.Data.DataColumn();
            this.DESTINATARIO_CNPJ_CTE = new System.Data.DataColumn();
            this.EXPEDIDOR_NOME_CTE = new System.Data.DataColumn();
            this.EXPEDIDOR_CNPJ_CTE = new System.Data.DataColumn();
            this.RECEBEDOR_NOME_CTE = new System.Data.DataColumn();
            this.RECEBEDOR_CNPJ_CTE = new System.Data.DataColumn();
            this.TOMADOR_NOME_CTE = new System.Data.DataColumn();
            this.TOMADOR_CNPJ_CTE = new System.Data.DataColumn();
            this.PESO_CTE = new System.Data.DataColumn();
            this.PESO_AFERIDO_CTE = new System.Data.DataColumn();
            this.CUBAGEM_CTE = new System.Data.DataColumn();
            this.QTDE_VOLUMES_CTE = new System.Data.DataColumn();
            this.VALOR_MERCADO_CTE = new System.Data.DataColumn();
            this.AGENDAMENTO_CTE = new System.Data.DataColumn();
            this.SUB_TOTAL_CTE = new System.Data.DataColumn();
            this.BC_CTE = new System.Data.DataColumn();
            this.ALIQ_ICMS_CTE = new System.Data.DataColumn();
            this.VALOR_ICMS_CTE = new System.Data.DataColumn();
            this.VALOR_TOTAL_CTE = new System.Data.DataColumn();
            this.TIPO_FRETE_CTE = new System.Data.DataColumn();
            this.VEICULO_CTE = new System.Data.DataColumn();
            this.PLACA_CTE = new System.Data.DataColumn();
            this.UF_CTE = new System.Data.DataColumn();
            this.OBSERVACOES_CTE = new System.Data.DataColumn();
            this.STATUS_CTE = new System.Data.DataColumn();
            this.CCT_CTE = new System.Data.DataColumn();
            this.CDV_CTE = new System.Data.DataColumn();
            this.CHAVE_ACESSO_CTE = new System.Data.DataColumn();
            this.RECIBO_CTE = new System.Data.DataColumn();
            this.PROTOCOLO_CTE = new System.Data.DataColumn();
            this.MOTIVO_CANCELA_CTE = new System.Data.DataColumn();
            this.STATUS_INTERNO_CTE = new System.Data.DataColumn();
            this.ENTREGUE_CTE = new System.Data.DataColumn();
            this.COD_ROMANEIO_CTE = new System.Data.DataColumn();
            this.COD_BARRAS_CTE = new System.Data.DataColumn();
            this.TIPO_CTE = new System.Data.DataColumn();
            this.ORIGEM_CTE = new System.Data.DataColumn();
            this.DESTINO_CTE = new System.Data.DataColumn();
            this.EMITIDO_POR_CTE = new System.Data.DataColumn();
            this.MERCADORIA_CTE = new System.Data.DataColumn();
            this.N_FATURA_CTE = new System.Data.DataColumn();
            this.RECEBIDO_CTE = new System.Data.DataColumn();
            this.NAO_FATURAR_CTE = new System.Data.DataColumn();
            this.CTE_CNPJ = new System.Data.DataColumn();
            this.XML_AUTORIZADO = new System.Data.DataColumn();
            this.XML_CANCELADO = new System.Data.DataColumn();
            this.XML_INUTILIZADO = new System.Data.DataColumn();
            this.XML_ASSINADO = new System.Data.DataColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dsCte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE)).BeginInit();
            this.SuspendLayout();
            // 
            // fbConnection1
            // 
            this.fbConnection1.ConnectionString = resources.GetString("fbConnection1.ConnectionString");
            // 
            // datCte
            // 
            this.datCte.DeleteCommand = this.fbCommand4;
            this.datCte.InsertCommand = this.fbCommand2;
            this.datCte.SelectCommand = this.fbCommand1;
            this.datCte.UpdateCommand = this.fbCommand3;
            // 
            // fbCommand4
            // 
            this.fbCommand4.CommandTimeout = 30;
            // 
            // fbCommand2
            // 
            this.fbCommand2.CommandTimeout = 30;
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandText = "SELECT * FROM CTE";
            this.fbCommand1.CommandTimeout = 30;
            this.fbCommand1.Connection = this.fbConnection1;
            // 
            // fbCommand3
            // 
            this.fbCommand3.CommandTimeout = 30;
            // 
            // dsCte
            // 
            this.dsCte.DataSetName = "dsCte";
            this.dsCte.Namespace = "http://www.tempuri.org/dsCte.xsd";
            this.dsCte.Tables.AddRange(new System.Data.DataTable[] {
            this.CTE});
            // 
            // CTE
            // 
            this.CTE.Columns.AddRange(new System.Data.DataColumn[] {
            this.COD_CTE,
            this.N_CTE,
            this.DATA_EMISSAO_CTE,
            this.HORA_EMISSAO_CTE,
            this.CFOP_CTE,
            this.NATUREZA_OPERACAO_CTE,
            this.EMITENTE_NOME_CTE,
            this.EMITENTE_CNPJ_CTE,
            this.REMETENTE_NOME_CTE,
            this.REMETENTE_CNPJ_CTE,
            this.DESTINATARIO_NOME_CTE,
            this.DESTINATARIO_CNPJ_CTE,
            this.EXPEDIDOR_NOME_CTE,
            this.EXPEDIDOR_CNPJ_CTE,
            this.RECEBEDOR_NOME_CTE,
            this.RECEBEDOR_CNPJ_CTE,
            this.TOMADOR_NOME_CTE,
            this.TOMADOR_CNPJ_CTE,
            this.PESO_CTE,
            this.PESO_AFERIDO_CTE,
            this.CUBAGEM_CTE,
            this.QTDE_VOLUMES_CTE,
            this.VALOR_MERCADO_CTE,
            this.AGENDAMENTO_CTE,
            this.SUB_TOTAL_CTE,
            this.BC_CTE,
            this.ALIQ_ICMS_CTE,
            this.VALOR_ICMS_CTE,
            this.VALOR_TOTAL_CTE,
            this.TIPO_FRETE_CTE,
            this.VEICULO_CTE,
            this.PLACA_CTE,
            this.UF_CTE,
            this.OBSERVACOES_CTE,
            this.STATUS_CTE,
            this.CCT_CTE,
            this.CDV_CTE,
            this.CHAVE_ACESSO_CTE,
            this.RECIBO_CTE,
            this.PROTOCOLO_CTE,
            this.MOTIVO_CANCELA_CTE,
            this.STATUS_INTERNO_CTE,
            this.ENTREGUE_CTE,
            this.COD_ROMANEIO_CTE,
            this.COD_BARRAS_CTE,
            this.TIPO_CTE,
            this.ORIGEM_CTE,
            this.DESTINO_CTE,
            this.EMITIDO_POR_CTE,
            this.MERCADORIA_CTE,
            this.N_FATURA_CTE,
            this.RECEBIDO_CTE,
            this.NAO_FATURAR_CTE,
            this.CTE_CNPJ,
            this.XML_AUTORIZADO,
            this.XML_CANCELADO,
            this.XML_INUTILIZADO,
            this.XML_ASSINADO});
            this.CTE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CTE_CNPJ"}, false)});
            this.CTE.TableName = "CTE";
            // 
            // COD_CTE
            // 
            this.COD_CTE.AllowDBNull = false;
            this.COD_CTE.ColumnName = "COD_CTE";
            this.COD_CTE.DataType = typeof(int);
            // 
            // N_CTE
            // 
            this.N_CTE.ColumnName = "N_CTE";
            this.N_CTE.DataType = typeof(int);
            // 
            // DATA_EMISSAO_CTE
            // 
            this.DATA_EMISSAO_CTE.ColumnName = "DATA_EMISSAO_CTE";
            this.DATA_EMISSAO_CTE.DataType = typeof(System.DateTime);
            // 
            // HORA_EMISSAO_CTE
            // 
            this.HORA_EMISSAO_CTE.ColumnName = "HORA_EMISSAO_CTE";
            this.HORA_EMISSAO_CTE.DataType = typeof(System.DateTime);
            // 
            // CFOP_CTE
            // 
            this.CFOP_CTE.ColumnName = "CFOP_CTE";
            this.CFOP_CTE.MaxLength = 50;
            // 
            // NATUREZA_OPERACAO_CTE
            // 
            this.NATUREZA_OPERACAO_CTE.ColumnName = "NATUREZA_OPERACAO_CTE";
            this.NATUREZA_OPERACAO_CTE.MaxLength = 200;
            // 
            // EMITENTE_NOME_CTE
            // 
            this.EMITENTE_NOME_CTE.ColumnName = "EMITENTE_NOME_CTE";
            this.EMITENTE_NOME_CTE.MaxLength = 200;
            // 
            // EMITENTE_CNPJ_CTE
            // 
            this.EMITENTE_CNPJ_CTE.ColumnName = "EMITENTE_CNPJ_CTE";
            this.EMITENTE_CNPJ_CTE.MaxLength = 20;
            // 
            // REMETENTE_NOME_CTE
            // 
            this.REMETENTE_NOME_CTE.ColumnName = "REMETENTE_NOME_CTE";
            this.REMETENTE_NOME_CTE.MaxLength = 200;
            // 
            // REMETENTE_CNPJ_CTE
            // 
            this.REMETENTE_CNPJ_CTE.ColumnName = "REMETENTE_CNPJ_CTE";
            this.REMETENTE_CNPJ_CTE.MaxLength = 20;
            // 
            // DESTINATARIO_NOME_CTE
            // 
            this.DESTINATARIO_NOME_CTE.ColumnName = "DESTINATARIO_NOME_CTE";
            this.DESTINATARIO_NOME_CTE.MaxLength = 200;
            // 
            // DESTINATARIO_CNPJ_CTE
            // 
            this.DESTINATARIO_CNPJ_CTE.ColumnName = "DESTINATARIO_CNPJ_CTE";
            this.DESTINATARIO_CNPJ_CTE.MaxLength = 20;
            // 
            // EXPEDIDOR_NOME_CTE
            // 
            this.EXPEDIDOR_NOME_CTE.ColumnName = "EXPEDIDOR_NOME_CTE";
            this.EXPEDIDOR_NOME_CTE.MaxLength = 200;
            // 
            // EXPEDIDOR_CNPJ_CTE
            // 
            this.EXPEDIDOR_CNPJ_CTE.ColumnName = "EXPEDIDOR_CNPJ_CTE";
            this.EXPEDIDOR_CNPJ_CTE.MaxLength = 20;
            // 
            // RECEBEDOR_NOME_CTE
            // 
            this.RECEBEDOR_NOME_CTE.ColumnName = "RECEBEDOR_NOME_CTE";
            this.RECEBEDOR_NOME_CTE.MaxLength = 200;
            // 
            // RECEBEDOR_CNPJ_CTE
            // 
            this.RECEBEDOR_CNPJ_CTE.ColumnName = "RECEBEDOR_CNPJ_CTE";
            this.RECEBEDOR_CNPJ_CTE.MaxLength = 20;
            // 
            // TOMADOR_NOME_CTE
            // 
            this.TOMADOR_NOME_CTE.ColumnName = "TOMADOR_NOME_CTE";
            this.TOMADOR_NOME_CTE.MaxLength = 200;
            // 
            // TOMADOR_CNPJ_CTE
            // 
            this.TOMADOR_CNPJ_CTE.ColumnName = "TOMADOR_CNPJ_CTE";
            this.TOMADOR_CNPJ_CTE.MaxLength = 20;
            // 
            // PESO_CTE
            // 
            this.PESO_CTE.ColumnName = "PESO_CTE";
            this.PESO_CTE.DataType = typeof(double);
            // 
            // PESO_AFERIDO_CTE
            // 
            this.PESO_AFERIDO_CTE.ColumnName = "PESO_AFERIDO_CTE";
            this.PESO_AFERIDO_CTE.DataType = typeof(double);
            // 
            // CUBAGEM_CTE
            // 
            this.CUBAGEM_CTE.ColumnName = "CUBAGEM_CTE";
            this.CUBAGEM_CTE.DataType = typeof(double);
            // 
            // QTDE_VOLUMES_CTE
            // 
            this.QTDE_VOLUMES_CTE.ColumnName = "QTDE_VOLUMES_CTE";
            this.QTDE_VOLUMES_CTE.DataType = typeof(int);
            // 
            // VALOR_MERCADO_CTE
            // 
            this.VALOR_MERCADO_CTE.ColumnName = "VALOR_MERCADO_CTE";
            this.VALOR_MERCADO_CTE.DataType = typeof(double);
            // 
            // AGENDAMENTO_CTE
            // 
            this.AGENDAMENTO_CTE.ColumnName = "AGENDAMENTO_CTE";
            this.AGENDAMENTO_CTE.MaxLength = 200;
            // 
            // SUB_TOTAL_CTE
            // 
            this.SUB_TOTAL_CTE.ColumnName = "SUB_TOTAL_CTE";
            this.SUB_TOTAL_CTE.DataType = typeof(double);
            // 
            // BC_CTE
            // 
            this.BC_CTE.ColumnName = "BC_CTE";
            this.BC_CTE.DataType = typeof(double);
            // 
            // ALIQ_ICMS_CTE
            // 
            this.ALIQ_ICMS_CTE.ColumnName = "ALIQ_ICMS_CTE";
            this.ALIQ_ICMS_CTE.DataType = typeof(double);
            // 
            // VALOR_ICMS_CTE
            // 
            this.VALOR_ICMS_CTE.ColumnName = "VALOR_ICMS_CTE";
            this.VALOR_ICMS_CTE.DataType = typeof(double);
            // 
            // VALOR_TOTAL_CTE
            // 
            this.VALOR_TOTAL_CTE.ColumnName = "VALOR_TOTAL_CTE";
            this.VALOR_TOTAL_CTE.DataType = typeof(double);
            // 
            // TIPO_FRETE_CTE
            // 
            this.TIPO_FRETE_CTE.ColumnName = "TIPO_FRETE_CTE";
            this.TIPO_FRETE_CTE.MaxLength = 200;
            // 
            // VEICULO_CTE
            // 
            this.VEICULO_CTE.ColumnName = "VEICULO_CTE";
            this.VEICULO_CTE.MaxLength = 200;
            // 
            // PLACA_CTE
            // 
            this.PLACA_CTE.ColumnName = "PLACA_CTE";
            this.PLACA_CTE.MaxLength = 20;
            // 
            // UF_CTE
            // 
            this.UF_CTE.ColumnName = "UF_CTE";
            this.UF_CTE.MaxLength = 2;
            // 
            // OBSERVACOES_CTE
            // 
            this.OBSERVACOES_CTE.ColumnName = "OBSERVACOES_CTE";
            this.OBSERVACOES_CTE.MaxLength = 500;
            // 
            // STATUS_CTE
            // 
            this.STATUS_CTE.ColumnName = "STATUS_CTE";
            this.STATUS_CTE.MaxLength = 200;
            // 
            // CCT_CTE
            // 
            this.CCT_CTE.ColumnName = "CCT_CTE";
            this.CCT_CTE.MaxLength = 8;
            // 
            // CDV_CTE
            // 
            this.CDV_CTE.ColumnName = "CDV_CTE";
            this.CDV_CTE.MaxLength = 1;
            // 
            // CHAVE_ACESSO_CTE
            // 
            this.CHAVE_ACESSO_CTE.ColumnName = "CHAVE_ACESSO_CTE";
            this.CHAVE_ACESSO_CTE.MaxLength = 44;
            // 
            // RECIBO_CTE
            // 
            this.RECIBO_CTE.ColumnName = "RECIBO_CTE";
            this.RECIBO_CTE.MaxLength = 200;
            // 
            // PROTOCOLO_CTE
            // 
            this.PROTOCOLO_CTE.ColumnName = "PROTOCOLO_CTE";
            this.PROTOCOLO_CTE.MaxLength = 200;
            // 
            // MOTIVO_CANCELA_CTE
            // 
            this.MOTIVO_CANCELA_CTE.ColumnName = "MOTIVO_CANCELA_CTE";
            this.MOTIVO_CANCELA_CTE.MaxLength = 200;
            // 
            // STATUS_INTERNO_CTE
            // 
            this.STATUS_INTERNO_CTE.ColumnName = "STATUS_INTERNO_CTE";
            this.STATUS_INTERNO_CTE.MaxLength = 200;
            // 
            // ENTREGUE_CTE
            // 
            this.ENTREGUE_CTE.ColumnName = "ENTREGUE_CTE";
            this.ENTREGUE_CTE.DataType = typeof(int);
            // 
            // COD_ROMANEIO_CTE
            // 
            this.COD_ROMANEIO_CTE.ColumnName = "COD_ROMANEIO_CTE";
            this.COD_ROMANEIO_CTE.DataType = typeof(int);
            // 
            // COD_BARRAS_CTE
            // 
            this.COD_BARRAS_CTE.ColumnName = "COD_BARRAS_CTE";
            this.COD_BARRAS_CTE.DataType = typeof(byte[]);
            // 
            // TIPO_CTE
            // 
            this.TIPO_CTE.ColumnName = "TIPO_CTE";
            this.TIPO_CTE.MaxLength = 200;
            // 
            // ORIGEM_CTE
            // 
            this.ORIGEM_CTE.ColumnName = "ORIGEM_CTE";
            this.ORIGEM_CTE.MaxLength = 200;
            // 
            // DESTINO_CTE
            // 
            this.DESTINO_CTE.ColumnName = "DESTINO_CTE";
            this.DESTINO_CTE.MaxLength = 200;
            // 
            // EMITIDO_POR_CTE
            // 
            this.EMITIDO_POR_CTE.ColumnName = "EMITIDO_POR_CTE";
            this.EMITIDO_POR_CTE.DataType = typeof(int);
            // 
            // MERCADORIA_CTE
            // 
            this.MERCADORIA_CTE.ColumnName = "MERCADORIA_CTE";
            this.MERCADORIA_CTE.MaxLength = 100;
            // 
            // N_FATURA_CTE
            // 
            this.N_FATURA_CTE.ColumnName = "N_FATURA_CTE";
            this.N_FATURA_CTE.DataType = typeof(int);
            // 
            // RECEBIDO_CTE
            // 
            this.RECEBIDO_CTE.ColumnName = "RECEBIDO_CTE";
            this.RECEBIDO_CTE.DataType = typeof(int);
            // 
            // NAO_FATURAR_CTE
            // 
            this.NAO_FATURAR_CTE.ColumnName = "NAO_FATURAR_CTE";
            this.NAO_FATURAR_CTE.DataType = typeof(int);
            // 
            // CTE_CNPJ
            // 
            this.CTE_CNPJ.ColumnName = "CTE_CNPJ";
            this.CTE_CNPJ.MaxLength = 100;
            // 
            // XML_AUTORIZADO
            // 
            this.XML_AUTORIZADO.ColumnName = "XML_AUTORIZADO";
            // 
            // XML_CANCELADO
            // 
            this.XML_CANCELADO.ColumnName = "XML_CANCELADO";
            this.XML_CANCELADO.MaxLength = 2147483647;
            // 
            // XML_INUTILIZADO
            // 
            this.XML_INUTILIZADO.ColumnName = "XML_INUTILIZADO";
            this.XML_INUTILIZADO.MaxLength = 2147483647;
            // 
            // XML_ASSINADO
            // 
            this.XML_ASSINADO.ColumnName = "XML_ASSINADO";
            this.XML_ASSINADO.MaxLength = 2147483647;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // form_gerar_xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 60);
            this.Controls.Add(this.progressBar1);
            this.Name = "form_gerar_xml";
            this.Text = "Gerar XML";
            this.Load += new System.EventHandler(this.form_gerar_xml_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter datCte;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand4;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand3;
        private System.Data.DataSet dsCte;
        private System.Data.DataTable CTE;
        private System.Data.DataColumn COD_CTE;
        private System.Data.DataColumn N_CTE;
        private System.Data.DataColumn DATA_EMISSAO_CTE;
        private System.Data.DataColumn HORA_EMISSAO_CTE;
        private System.Data.DataColumn CFOP_CTE;
        private System.Data.DataColumn NATUREZA_OPERACAO_CTE;
        private System.Data.DataColumn EMITENTE_NOME_CTE;
        private System.Data.DataColumn EMITENTE_CNPJ_CTE;
        private System.Data.DataColumn REMETENTE_NOME_CTE;
        private System.Data.DataColumn REMETENTE_CNPJ_CTE;
        private System.Data.DataColumn DESTINATARIO_NOME_CTE;
        private System.Data.DataColumn DESTINATARIO_CNPJ_CTE;
        private System.Data.DataColumn EXPEDIDOR_NOME_CTE;
        private System.Data.DataColumn EXPEDIDOR_CNPJ_CTE;
        private System.Data.DataColumn RECEBEDOR_NOME_CTE;
        private System.Data.DataColumn RECEBEDOR_CNPJ_CTE;
        private System.Data.DataColumn TOMADOR_NOME_CTE;
        private System.Data.DataColumn TOMADOR_CNPJ_CTE;
        private System.Data.DataColumn PESO_CTE;
        private System.Data.DataColumn PESO_AFERIDO_CTE;
        private System.Data.DataColumn CUBAGEM_CTE;
        private System.Data.DataColumn QTDE_VOLUMES_CTE;
        private System.Data.DataColumn VALOR_MERCADO_CTE;
        private System.Data.DataColumn AGENDAMENTO_CTE;
        private System.Data.DataColumn SUB_TOTAL_CTE;
        private System.Data.DataColumn BC_CTE;
        private System.Data.DataColumn ALIQ_ICMS_CTE;
        private System.Data.DataColumn VALOR_ICMS_CTE;
        private System.Data.DataColumn VALOR_TOTAL_CTE;
        private System.Data.DataColumn TIPO_FRETE_CTE;
        private System.Data.DataColumn VEICULO_CTE;
        private System.Data.DataColumn PLACA_CTE;
        private System.Data.DataColumn UF_CTE;
        private System.Data.DataColumn OBSERVACOES_CTE;
        private System.Data.DataColumn STATUS_CTE;
        private System.Data.DataColumn CCT_CTE;
        private System.Data.DataColumn CDV_CTE;
        private System.Data.DataColumn CHAVE_ACESSO_CTE;
        private System.Data.DataColumn RECIBO_CTE;
        private System.Data.DataColumn PROTOCOLO_CTE;
        private System.Data.DataColumn MOTIVO_CANCELA_CTE;
        private System.Data.DataColumn STATUS_INTERNO_CTE;
        private System.Data.DataColumn ENTREGUE_CTE;
        private System.Data.DataColumn COD_ROMANEIO_CTE;
        private System.Data.DataColumn COD_BARRAS_CTE;
        private System.Data.DataColumn TIPO_CTE;
        private System.Data.DataColumn ORIGEM_CTE;
        private System.Data.DataColumn DESTINO_CTE;
        private System.Data.DataColumn EMITIDO_POR_CTE;
        private System.Data.DataColumn MERCADORIA_CTE;
        private System.Data.DataColumn N_FATURA_CTE;
        private System.Data.DataColumn RECEBIDO_CTE;
        private System.Data.DataColumn NAO_FATURAR_CTE;
        private System.Data.DataColumn CTE_CNPJ;
        private System.Data.DataColumn XML_AUTORIZADO;
        private System.Data.DataColumn XML_CANCELADO;
        private System.Data.DataColumn XML_INUTILIZADO;
        private System.Data.DataColumn XML_ASSINADO;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}