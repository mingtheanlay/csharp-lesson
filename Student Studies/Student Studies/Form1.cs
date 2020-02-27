using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Studies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.dgv = this.dgvStus;
            foreach (string ele in Program.subjects) {
                dgvStudies.Rows.Add(ele, null);
            }

            btnNew.Click += BtnNew_Click;

            dgvStus.SelectionChanged += DoStuChanged;
        }

        private void DoStuChanged(object sender, EventArgs e)
        {
            if(dgvStus.CurrentRow == null)
            {
                return;
            }

            if(dgvStus.CurrentRow.Tag == null) {
                return;
            }

            double[] scores = dgvStus.CurrentRow.Tag as double[];

            for(int k = 0; k < scores.Length; k++)
            {
                dgvStudies.Rows[k].Cells[1].Value = scores[k];
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            new Form2().Show(); 
        }
    }
}
