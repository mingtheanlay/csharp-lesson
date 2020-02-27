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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAmount.Click += BtnAmount_Click;
        }

        private void BtnAmount_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
        }
    }
}
