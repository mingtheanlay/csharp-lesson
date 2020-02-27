using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddPerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = "";
            byte age = 0;
            double height = 0.0;

            // Validate Name
            try
            {
                name = this.GetName();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                txtName.Focus();
                txtName.SelectAll();
                return;
            }

            // Validate Height
            try
            {
                height = this.GetHeight();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            // Validate Age
            try
            {
                age = this.GetAge();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                txtAge.Focus();
                txtAge.SelectAll();
                return;
            }

            dgvPersons.Rows.Add(name, age, height);
            txtName.Clear();
            txtAge.Clear();
            txtHeight.Clear();

        }

        private byte GetAge()
        {
            string age = txtAge.Text.Trim();
            if(age.Equals(""))
            {
                throw new Exception("Age is empty.");
            }
            try
            {
                byte a = byte.Parse(txtAge.Text);
                if(a>125)
                {
                    throw new Exception("Age cant be greater than 125.");
                }
                return a;
            }
            catch(OverflowException)
            {
                throw new Exception("Invalid Format.");
            }
            catch(FormatException)
            {
                throw new Exception("Human cant be live that long.");
            }

        }
        private double GetHeight()
        {
            string height = txtHeight.Text.Trim();
            if(height.Equals("")==true)
            {
                throw new Exception("Height is empty.");
            }
            try
            {
                double h = double.Parse(txtHeight.Text);
                if(h <= 1.00)
                {
                    throw new Exception("Invalid Height.");
                }
                else if(h >= 2.50)
                {
                    throw new Exception("Invalid Height.");
                }
                return h;
            }
            catch(FormatException)
            {
                throw new Exception("Invalid Format");
            }
            catch(OverflowException)
            {
                throw new Exception("Human cant be this high.");
            }
        }

        private string GetName()
        {
            string name = txtName.Text.Trim();
            if(name.Equals("")==true)
            {
                throw new Exception("Name is empty.");
            }
            return name;
        }
    }
}
