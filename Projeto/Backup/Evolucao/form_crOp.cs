using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_crOp : Form
    {
        public int print_op;
        public form_crOp()
        {
            InitializeComponent();
        }

        private void form_crOp_Load(object sender, EventArgs e)
        {
            crOp1.Parameter_op.Equals(print_op);
            //crOp1.ParameterFields.Equals(print_op);
        }
    }
}