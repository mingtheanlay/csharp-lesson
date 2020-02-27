using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Selling
{
    public partial class Form1 : Form
    {
        double total = 0, gTotal = 0;

        public Form1()
        {
            InitializeComponent();

            // Set Price of Product
            SetPrice(txtP1, 20);
            SetPrice(txtP2, 100);
            SetPrice(txtP3, 10);
            SetPrice(txtP4, 50);

            grpSale.Enabled = false;
            txtGTotal.Text = gTotal.ToString("N2");

            // Button
            btnNew.Click += BtnNew_Click;
            btnCommit.Click += BtnCommit_Click;

            // CheckBox
            chkB1.CheckedChanged += DoBookChecked;
            chkB2.CheckedChanged += DoBookChecked;
            chkB3.CheckedChanged += DoBookChecked;
            chkB4.CheckedChanged += DoBookChecked;

            // Quantity Changed
            txtQ1.TextChanged += DoQuantityChanged;
            txtQ2.TextChanged += DoQuantityChanged;
            txtQ3.TextChanged += DoQuantityChanged;
            txtQ4.TextChanged += DoQuantityChanged;


        }

        private void DoQuantityChanged(object sender, EventArgs e)
        {
            double price = 0, amount = 0;
            int qty = 0;
            TextBox txtSender = (sender as TextBox);
            TextBox txtA = null;

            if (txtSender == txtQ1)
            {
                txtA = txtA1;
                price = Convert.ToDouble(txtP1.Tag);
            }
            if (txtSender == txtQ2)
            {
                txtA = txtA2;
                price = Convert.ToDouble(txtP2.Tag);
            }
            if (txtSender == txtQ3)
            {
                txtA = txtA3;
                price = Convert.ToDouble(txtP3.Tag);
            }
            if (txtSender == txtQ4)
            {
                txtA = txtA4;
                price = Convert.ToDouble(txtP4.Tag);
            }

            int.TryParse(txtSender.Text, out qty);
            amount = qty * price;

            if (txtA.Tag != null)
            {
                total -= Convert.ToDouble(txtA.Tag);
            }

            total += amount;
            txtA.Tag = amount;

            if (amount == 0)
            {
                txtA.Clear();
            }
            else
            {
                txtA.Text = amount.ToString("N2");
                txtTotal.Text = total.ToString("N2");
                btnCommit.Enabled = (total > 0);
            }
        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            gTotal += total;
            grpSale.Enabled = false;
            txtGTotal.Text = gTotal.ToString("N2");
        }

        private void DoBookChecked(object sender, EventArgs e)
        {
            CheckBox chkSender = (sender as CheckBox);
            TextBox txtQ = null;

            if (chkSender == chkB1)
            {
                txtQ = txtQ1;
            }
            if (chkSender == chkB2)
            {
                txtQ = txtQ2;
            }
            if (chkSender == chkB3)
            {
                txtQ = txtQ3;
            }
            if (chkSender == chkB4)
            {
                txtQ = txtQ4;
            }
            if (chkSender.Checked == true)
            {
                txtQ.Text = "1";
                txtQ.ReadOnly = false;
            }
            else
            {
                txtQ.Clear();
                txtQ.ReadOnly = true;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            grpSale.Enabled = true;
            chkB1.Checked = false;
            chkB2.Checked = false;
            chkB3.Checked = false;
            chkB4.Checked = false;
            total = 0;
            txtTotal.Text = total.ToString("N2");
        }

        void SetPrice(TextBox txt, double p)
        {
            txt.Text = p.ToString("N2");
            txt.Tag = p;
        }


    }
}
