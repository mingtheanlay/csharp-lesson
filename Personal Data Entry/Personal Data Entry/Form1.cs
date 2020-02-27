using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Data_Entry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.tslInfo.Text = "";
            btnAdd.Click += BtnAdd_Click;
            txtName.TextChanged += DataEntry;
            txtAge.TextChanged += DataEntry;
            txtHeight.TextChanged += DataEntry;
        }

        private void DataEntry(object sender, EventArgs e)
        {
            tslInfo.Text = "";
            epError.SetError(sender as Control, "");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = "";
            byte age = 0;
            double height = 0.0;
            string info = "";
            string err = "";
            TextBox txt = null;
          
            // Validdating name
            try
            {
                name = this.GetName();
            }
            catch(Exception ex)
            {
                info = ex.Message;
                err += info + " ";
                txt = txtName;
                epError.SetError(txt, info);
            }

            // Validating age
            try
            {
                age = this.GetAge();
            }
            catch(Exception ex)
            {
                info = ex.Message;
                err += info + " ";
                txt = txtAge;
                epError.SetError(txt, info);
            }

            // Validating height
            try
            {
                height = this.GetHeight();
            }
            catch(Exception ex)
            {
                info = ex.Message;
                err += info + " ";
                txt = txtHeight;
                epError.SetError(txt, info);
            }

            if (txt != null)
            {
                txt.Focus();
                txt.SelectAll();
                tslInfo.Text = err;
                tslInfo.ForeColor = Color.Red;
                return;
            }
            txtName.Clear();
            txtAge.Clear();
            txtHeight.Clear();
            dgvPerson.Rows.Add(name, age, height);
            tslInfo.Text = "Seccessfully Added.";
            tslInfo.ForeColor = Color.Green;
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
                if(h > 2.50)
                {
                    throw new Exception("Height cannot be greater than 2.50.");
                }
                return h;
            }
            catch(OverflowException)
            {
                throw new Exception("Overflow double variable.");
            }
            catch(FormatException)
            {
                throw new Exception("Wrong format.");
            }
        }

        private byte GetAge()
        {
            string age = txtAge.Text.Trim();
            if(age.Equals("") == true)
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
            catch (OverflowException)
            {
                throw new Exception("Age is invalid.");
            }
            catch(FormatException)
            {
                throw new Exception("Age must be byte.");
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
