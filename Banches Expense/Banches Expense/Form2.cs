using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banches_Expense
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
            txtAmount.Text = Program.TextualAmountsFor(br);
        }
    }
}
