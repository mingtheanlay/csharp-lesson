using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductValidating
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            tslInfo.Text = "";

            btnAdd.Click += BtnAdd_Click;
            btnClear.Click += BtnClear_Click;

            txtID.TextChanged += DataEntry;
            txtName.TextChanged += DataEntry;
            txtPrice.TextChanged += DataEntry;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtID.Clear();
            txtPrice.Clear();
        }

        private void DataEntry(object sender, EventArgs e)
        {
            toolstrip1.Text = "";
            erpStatus.SetError(sender as Control, "");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string id = "";
            string name = "";
            double price = 0.0;
            string info = "";
            TextBox txtBox = null;

            // Validate ID
            try
            {
                id = this.GetID();
            }
            catch(Exception ex)
            {
                info += ex.Message + " ";
                txtBox = txtID;
                erpStatus.SetError(txtBox, ex.Message);
            }

            // Validate Name
            try
            {
                name = this.GetName();
            }
            catch(Exception ex)
            {
                info += ex.Message + " ";
                txtBox = txtName;
                erpStatus.SetError(txtBox, ex.Message);
            }

            // Validate Price  
            try
            {
                price = this.GetPrice();
            }
            catch(Exception ex)
            {
                info += ex.Message + " ";
                txtBox = txtPrice;
                erpStatus.SetError(txtBox, ex.Message);
            }

            if(info == null)
            {
                txtBox.Focus();
                txtBox.SelectAll();
                tslInfo.Text = info;
                tslInfo.ForeColor = Color.Red;
                return;
            }
            else
            {
                Program.dgv.Rows.Add(id, name, price);
                tslInfo.Text = "Added Succesfully.";
                tslInfo.ForeColor = Color.Green;
            }

        }

        private double GetPrice()
        {
            string p = txtPrice.Text.Trim();
            if(p.Equals("")==true)
            {
                throw new Exception("Price is empty.");
            }
            try
            {
                double price = double.Parse(txtPrice.Text);
                if(price < 0)
                {
                    throw new Exception("Product cant be under 0.");
                }
                return price;
            }
            catch(OverflowException)
            {
                throw new Exception("Invalid Format.");
            }
            catch(FormatException)
            {
                throw new Exception("Wrong Format.");
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

        private string GetID()
        {
            string id = txtID.Text.Trim();
            if(id.Equals("")==true)
            {
                throw new Exception("ID is empty.");
            }
           
            if(id.StartsWith("P")==false)
            {
                throw new Exception("ID must start with P.");
            }

            return id;
            
        }
    }
}
