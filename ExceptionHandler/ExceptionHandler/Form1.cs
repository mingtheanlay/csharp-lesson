using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAge.Click += BtnAge_Click;
        }

        private void BtnAge_Click(object sender, EventArgs e)
        {
            string info = "";
            try
            {
                byte age = this.GetAge();
                MessageBox.Show("You age is " + age.ToString());
                return;
            }

            catch(FormatException)
            {
                info = "Invalid format of age";
            }

            catch(OverflowException)
            {
                info = "The number must be between 1 to 125.";
            }

            catch(Exception ex)
            {
                info = ex.Message;
            }

            MessageBox.Show(info, "Getting",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            txtAge.Focus();
            txtAge.SelectAll();
        }

        private byte GetAge()
        {
            byte a = byte.Parse(txtAge.Text);

            if(txtAge.Text.Trim().Equals(""))
            {
                throw new Exception("Age is empty");
            }

            if(a > 125)
            {
                    throw new Exception("Invalid human age.");
            }

            return a;
        }
    }
}
