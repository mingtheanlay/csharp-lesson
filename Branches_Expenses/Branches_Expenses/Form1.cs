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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.dgv = this.dgvBranch;
            Program.txt = txtTotal;

            foreach (string b in Program.branches)
            {
                dgvBranch.Rows.Add(b, Program.TotalAmountsFor(b).ToString("C2"), Program.TextualAmountsFor(b));
            }
            txtTotal.Text = Program.TotalAmounts().ToString("C2");
            btnEdit.Click += btnEdit_Click;
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            string br = dgvBranch.CurrentRow.Cells[0].Value.ToString();
            Form2 frm = new Form2(br);
            frm.Show();
        }
    }
}
