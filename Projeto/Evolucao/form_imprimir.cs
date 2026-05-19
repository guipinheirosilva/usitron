using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using System.IO;

namespace Evolucao
{
    public partial class form_imprimir : Form
    {
        public bool pedido_compra;
        public bool correcao;
        public bool orcamento_molde;
        public bool orcamento_peca;
        public bool requisicao;
        public bool nfe;
        public bool cte;
        public bool nfce;
        public bool nfce_email;
        public bool orcamento;
        public bool boleto;
        public bool ainda_e_orcamento;
        public string n_pedido_compra;
        public string n_requisicao;
        public string n_nfe;
        public string n_cte;
        public string n_nfce;
        public string n_orcamento;
        public string n_nfe_correcao;
        public string nome_fantasia;
        public string dataEmissao;
        public string ano_orcamento;

        public bool op;
        public int n_copias;
        public bool cte_direto;
        public bool imprimir_direto;
        public bool fechar_direto;
        public bool zoom150 = false;
        CrystalDecisions.CrystalReports.Engine.ReportClass relatorio1 = new CrystalDecisions.CrystalReports.Engine.ReportClass();
        
        public form_imprimir(CrystalDecisions.CrystalReports.Engine.ReportClass relatorio)
        {
            
            InitializeComponent();
            
            
            crystalReportViewer1.ReportSource = relatorio;
            relatorio1 = relatorio;
            // Não precisaremos exibir aquela área ao lado do relatório.
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            


            //crystalReportViewer1.PrintReport();
        }

        private void form_imprimir_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (op)
                {
                    if (imprimir_direto)
                    {
                        relatorio1.PrintToPrinter(1, false, 0, 0);
                        this.Close();
                    }
                }
                if (zoom150)
                    crystalReportViewer1.Zoom(150);
                //"\\localhost\\orcamentos"
                if (orcamento_molde == true)
                {
                    bool existe = Directory.Exists(@"c:\\evolucao\\ORCAMENTOS\\MOLDE");
                    if (existe == false)
                    {
                        Directory.CreateDirectory(@"c:\\evolucao\\ORCAMENTOS\\MOLDE");
                    }
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\ORCAMENTOS\\MOLDE\\ORCAMENTO_" + n_orcamento + ".pdf");
                    try { relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"\\localhost\\orcamentos\\MOLDE\\ORCAMENTO_" + n_orcamento + ".pdf"); }
                    catch { }
                }
                if (orcamento_peca == true)
                {
                    bool existe = Directory.Exists(@"c:\\evolucao\\ORCAMENTOS");
                    if (existe == false)
                    {
                        Directory.CreateDirectory(@"c:\\evolucao\\ORCAMENTOS");
                    }
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\ORCAMENTOS\\ORCAMENTO_" + n_orcamento + ".pdf");
                    try { relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"\\localhost\\ORCAMENTOS\\ORCAMENTO_" + n_orcamento + ".pdf"); }
                    catch { }
                }
                if (orcamento == true)
                {
                  
                    string descricao_impressao = "PEDIDO_VENDA";
                    if (ainda_e_orcamento)
                    {
                        descricao_impressao = "ORCAMENTO";
                    }
                   // relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\ORCAMENTOS\\" + descricao_impressao + "_" + n_orcamento + ".pdf");

                    if (imprimir_direto)
                    {
                        relatorio1.PrintToPrinter(1, false, 0, 0);
                        this.Close();
                    }
                    if (fechar_direto)
                        this.Close();
                    if(n_copias > 0)
                        relatorio1.PrintToPrinter(n_copias, false, 0, 0);
                }

                if (pedido_compra == true)
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\pedidos_compra\\PEDIDO_" + n_pedido_compra + ".pdf");
                if (requisicao == true)
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\REQUISICOES\\REQUISICAO_" + n_requisicao + ".pdf");
                if (nfe == true)
                {
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\NFE\\DANFES\\DANFE_NFE_" + n_nfe + ".pdf");
                    if (imprimir_direto)
                    {
                        relatorio1.PrintToPrinter(1, false, 0, 0);
                        this.Close();
                    }
                    if (n_copias > 0)
                        relatorio1.PrintToPrinter(n_copias, false, 0, 0);
                }

               
                if (nfce == true)
                {
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\nfce\\DANFES\\DANFE_NFCE_" + n_nfce + ".pdf");

                    if (nfce_email == true)
                        this.Close();
                }
                if (boleto == true)
                {
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\NFE\\BOLETOS\\BOLETO_NFE_" + n_nfe + ".pdf");
                    if (imprimir_direto)
                    {
                        relatorio1.PrintToPrinter(1, false, 0, 0);
                        this.Close();
                    }
                }
                if (cte == true)
                {
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\CTE\\DANFES\\DACTE_CTE_" + n_cte + ".pdf");

                    if (cte_direto)
                    {
                        relatorio1.PrintOptions.PaperSize = PaperSize.PaperA4;
                        relatorio1.PrintToPrinter(1, false, 0, 0);
                        this.Close();
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}