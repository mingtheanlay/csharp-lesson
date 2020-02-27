using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_Calculator
{
    public partial class Form1 : Form
    {
        private double one, two;
        public Form1()
        {
            InitializeComponent();

            cboOp.Items.Add("+ Addition");
            cboOp.Items.Add("- Substraction");
            cboOp.Items.Add("* Multiplication");
            cboOp.Items.Add("/ Division");

            txtOne.TextChanged += TxtOne_TextChanged;
            txtTwo.TextChanged += TxtTwo_TextChanged;
            cboOp.TextChanged += CboOp_TextChanged;

            btnClear.Click += BtnClear_Click;
            btnPerform.Click += BtnPerform_Click;
            btnClose.Click += BtnClose_Click;

            this.FormClosing += Form1_FormClosing;
            this.Activated += Form1_Activated;

            this.AcceptButton = btnPerform;
            this.CancelButton = btnClear;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtOne.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs msgBox)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to close?",
                "Closing",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question);

            if(result == DialogResult.No)
            {
                msgBox.Cancel = true;
            }
        }

        private void CboOp_TextChanged(object sender, EventArgs e)
        {
            btnPerform.Enabled = ((double.TryParse(txtOne.Text, out one)) &&
                   (double.TryParse(txtTwo.Text, out two)) &&
                   (cboOp.SelectedItem != null));

            txtResult.Clear();
        }

        private void TxtTwo_TextChanged(object sender, EventArgs e)
        {
            btnPerform.Enabled = ((double.TryParse(txtOne.Text, out one)) &&
                   (double.TryParse(txtTwo.Text, out two)) &&
                   (cboOp.SelectedItem != null));

            txtResult.Clear();
        }

        private void TxtOne_TextChanged(object sender, EventArgs e)
        {
            btnPerform.Enabled = ((double.TryParse(txtOne.Text, out one)) &&
                    (double.TryParse(txtTwo.Text, out two)) &&
                    (cboOp.SelectedItem != null));

            txtResult.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPerform_Click(object sender, EventArgs e)
        {
            int inputOp = cboOp.SelectedIndex;
            double result = 0;

            switch(inputOp)
            {
                case 0:
                    result = one + two;
                    break;
                case 1:
                    result = one - two;
                    break;
                case 2:
                    result = one * two;
                    break;
                case 3:
                    result = one / two;
                    break;
            }
            txtResult.Text = result.ToString("N2");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtOne.Clear();
            txtTwo.Clear();
            txtResult.Clear();
            cboOp.SelectedItem = null;
        }
    }
}
