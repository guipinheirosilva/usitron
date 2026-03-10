using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_imprimir_2 : Form
    {
        public bool pedido_compra;
        public bool correcao;
        public bool requisicao;
        public bool nfe;
        public bool cte;
        public bool orcamento;
        public string n_pedido_compra;
        public string n_requisicao;
        public string n_nfe;
        public string n_cte;
        public string n_orcamento;
        public string n_nfe_correcao;
        public string nome_fantasia;
        public string dataEmissao;

        public bool cte_direto;

        CrystalDecisions.CrystalReports.Engine.ReportClass relatorio1 = new CrystalDecisions.CrystalReports.Engine.ReportClass();
        public form_imprimir_2(CrystalDecisions.CrystalReports.Engine.ReportClass relatorio)
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
                if (orcamento == true)
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\ORCAMENTOS\\ORCAMENTO_" + n_orcamento + ".pdf");
                if (pedido_compra == true)
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\pedidos_compra\\PEDIDO_" + n_pedido_compra + ".pdf");
                if (requisicao == true)
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\REQUISICOES\\REQUISICAO_" + n_requisicao + ".pdf");
                if (nfe == true)
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\NFE\\DANFES\\DANFE_NFE_" + n_nfe + ".pdf");
                if (cte == true)
                {
                    relatorio1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\\evolucao\\CTE\\DANFES\\DACTE_CTE_" + n_cte + ".pdf");
                    if (cte_direto)
                    {
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