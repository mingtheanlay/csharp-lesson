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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cboGender.DataSource = new string[]
            {
                "Male", "Female"
            };
            foreach(string ele in Program.subjects)
            {
                dgvStudent.Rows.Add(ele, null);
            }
            btnCreate.Click += BtnCreate_Click;
            btnClear.Click += BtnClear_Click;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtStudent.Clear();
            cboGender.SelectedItem = null;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            double[] scores = new double[Program.subjects.Length];
            for(int k = 0; k < scores.Length; k++)
            {
                scores[k] = Convert.ToDouble(dgvStudent.Rows[k].Cells[1].Value);
            }

            int index = Program.dgv.Rows.Add(txtStudent.Text, cboGender.SelectedItem, Program.Total(scores));
            Program.dgv.Rows[index].Tag = scores;

            if (Program.dgv.Rows.Count == 1)
            {
                Program.dgv.Rows[0].Selected = true;
            }
        }
    }
}
