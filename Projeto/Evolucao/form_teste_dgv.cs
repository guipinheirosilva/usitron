using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGridView;

namespace Evolucao
{
    public partial class form_teste_dgv : Form
    {
        public form_teste_dgv()
        {
            InitializeComponent();
        }

        private void form_teste_dgv_Load(object sender, EventArgs e)
        {
            SetupTreeGridView();
        }

        private void SetupTreeGridView()
        {
            // Inicializa o TreeGridView
            var treeGrid = new TreeGridView.TreeGridView
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(treeGrid);

            // Configurando as colunas do TreeGridView
            var columnProduct = new TreeGridView.TreeGridColumn { HeaderText = "Produto/Ingrediente" };
            var columnQuantity = new DataGridViewTextBoxColumn { HeaderText = "Quantidade" };
            var columnUnit = new DataGridViewTextBoxColumn { HeaderText = "Unidade" };

            treeGrid.Columns.Add(columnProduct);
            treeGrid.Columns.Add(columnQuantity);
            treeGrid.Columns.Add(columnUnit);

            // Adicionando dados com subníveis
            var productRow = new TreeGridView.TreeGridNode();
            productRow.Cells.Add(new DataGridViewTextBoxCell { Value = "Produto A" });
            productRow.Cells.Add(new DataGridViewTextBoxCell { Value = "100" });
            productRow.Cells.Add(new DataGridViewTextBoxCell { Value = "g" });
            treeGrid.Nodes.Add(productRow);

            var ingredientRow = new TreeGridView.TreeGridNode();
            ingredientRow.Cells.Add(new DataGridViewTextBoxCell { Value = "Ingrediente 1" });
            ingredientRow.Cells.Add(new DataGridViewTextBoxCell { Value = "50" });
            ingredientRow.Cells.Add(new DataGridViewTextBoxCell { Value = "g" });
            productRow.Nodes.Add(ingredientRow);

            var subIngredientRow = new TreeGridView.TreeGridNode();
            subIngredientRow.Cells.Add(new DataGridViewTextBoxCell { Value = "SubIngrediente 1.1" });
            subIngredientRow.Cells.Add(new DataGridViewTextBoxCell { Value = "25" });
            subIngredientRow.Cells.Add(new DataGridViewTextBoxCell { Value = "g" });
            ingredientRow.Nodes.Add(subIngredientRow);

            var ingredientRow2 = new TreeGridView.TreeGridNode();
            ingredientRow2.Cells.Add(new DataGridViewTextBoxCell { Value = "Ingrediente 2" });
            ingredientRow2.Cells.Add(new DataGridViewTextBoxCell { Value = "30" });
            ingredientRow2.Cells.Add(new DataGridViewTextBoxCell { Value = "ml" });
            productRow.Nodes.Add(ingredientRow2);

            productRow.Expand(); // Expande o nó inicial para visualização
        }

    }
}
