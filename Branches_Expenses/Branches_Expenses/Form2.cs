using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branches_Expenses
{
    public partial class Form2 : Form
    {
        string br = null;
        public Form2(string br)
        {
            InitializeComponent();
            this.br = br;
            cboBranch.DataSource = Program.branches;
            cboBranch.SelectedItem = br;
            txtAmounts.Text = Program.TextualAmountsFor(br);
            cboBranch.SelectedValueChanged += cboBranch_SelectedValueChanged;
            btnUpdate.Click += btnUpdate_Click;
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            string data = txtAmounts.Text;
            string[] arr = data.Split(',');
            double[] values = new double[arr.Length];
            for (int k = 0; k < values.Length; k++)
            {
                values[k] = double.Parse(arr[k]);
            }
            int index = Array.IndexOf(Program.branches, br);
            Program.amounts[index] = values;
            Program.dgv.Rows[index].Cells[1].Value = Program.TotalAmountsFor(br).ToString("C2");
            Program.dgv.Rows[index].Cells[2].Value = Program.TextualAmountsFor(br);
            Program.txt.Text = Program.TotalAmounts().ToString("C2");
        }

        void cboBranch_SelectedValueChanged(object sender, EventArgs e)
        {
            cboBranch.SelectedItem = br;
        }
    }
}
