using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticOperation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnPerform;
            this.CancelButton = btnClear;

            txtNum1.Enter += PerformEnterBox;
            txtNum2.Enter += PerformEnterBox;

            this.Activated += Form_Activated;

            this.FormClosing += Form1_FormClosing;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs btnWindowsClose)
        {
            // if true can't close using windows close button (btnWindowsClose = true)
            // if false can close using windows close button (btnWindowsClose = false)

            // btnWindowsClose.Cancel = true;

            btnWindowsClose.Cancel = (MessageBox.Show("Do you want to close? ","Closing",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            btnClear.Focus();
        }

        private void PerformEnterBox(object sender, EventArgs e)
        {
            (sender as TextBox).Focus();
            (sender as TextBox).SelectAll();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSub_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMulti_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDiv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double result;

            result = num1 + num2;
            txtAdd.Text = result.ToString("N3");

            result = num1 - num2;
            txtSub.Text = result.ToString("N3");

            result = num1 * num2;
            txtMulti.Text = result.ToString("N3");

            result = num1 / num2;
            txtDiv.Text = result.ToString("N3");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtAdd.Clear();
            txtDiv.Clear();
            txtMulti.Clear();
            txtSub.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
