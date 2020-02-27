using System;
using System.Windows.Forms;

namespace Sa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStart.Click += ClicktheButton;
            btnProcess.Click += ClicktheButton;
            btnExit.Click += ClicktheButton;
            double result = 0;
            result = Sum(10, 10); // result = 20
            result = Sum(b: 20, a: 40);  // a = 40 + b = 20 = result = 60 
            Sum(20 * 2, 30 * 2, out result); // result = 100;
            Twice(ref result);// result = 200;

        }

        private void ClicktheButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("You click on " + btn.Text + " button");

            if (sender == this.btnExit)
            {
                this.Close();
            }

            if (sender == this.btnProcess)
            {
                MessageBox.Show("Code is not written yet.");
            }

            if (sender == this.btnStart)
            {
                (new Form1()).Show();
            }

        }

        private double Sum(double a, double b)
        {
            return a + b;
        }

        private void Sum(double a, double b, out double c)
        {
            c = a + b;
        }

        private void Twice(ref double value)
        {
            value = value * 2;
        }


    }
}
