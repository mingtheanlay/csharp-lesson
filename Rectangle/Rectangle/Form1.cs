using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle
{
    public partial class Form1 : Form
    {
        private int number = 0;
        private double width = 0;
        private double length = 0;
        public Form1()
        {
            InitializeComponent();

            btnAdd.Click += BtnAdd_Click;
            btnClear.Click += BtnClear_Click;
            btnShow.Click += BtnShow_Click;

            txtWidth.TextChanged += TxtWidth_TextChanged;
            txtLength.TextChanged += TxtLength_TextChanged;
        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (double.TryParse(txtLength.Text, out length) &&
                double.TryParse(txtWidth.Text, out width));
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (double.TryParse(txtLength.Text, out length) &&
                 double.TryParse(txtWidth.Text, out width));
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            double total = 0;
            for(int i=0; i < dgvRes.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvRes.Rows[i].Cells[3].Value);
            }

            DialogResult popup = MessageBox.Show("Total Area: " +  total.ToString(), 
                "Total",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtWidth.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to create new rectangle?",
                "Adding",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if(result == DialogResult.No)
            {
                return;
            }
            double area = width * length;
            number++;
            dgvRes.Rows.Add(number, width, length, area);
            btnClear.PerformClick();
        }

     
    }
}
