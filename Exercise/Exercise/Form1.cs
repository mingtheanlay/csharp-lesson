using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnClear.Click += btnClear_Click;
            btnCalc.Click += btnCalc_Click;

            this.AcceptButton = btnCalc;
            this.CancelButton = btnClear;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtA.Text);
            double b = Double.Parse(txtB.Text);
            double c = Double.Parse(txtC.Text);
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            txtArea.Text = area.ToString("N3");

            txtA.ReadOnly = true;
            txtB.ReadOnly = true;
            txtC.ReadOnly = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtArea.Clear();

            txtA.ReadOnly = false;
            txtB.ReadOnly = false;
            txtC.ReadOnly = false;
            txtA.Focus();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
