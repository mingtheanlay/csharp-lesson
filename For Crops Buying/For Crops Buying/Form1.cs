using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Crops_Buying
{
    public partial class Form1 : Form
    {
        string[] provs = new string[] { "Battambang", "Kampot", "Kandal", "Takeo" };
        string[] crops = new string[] { "Bean", "Corn", "Rice" };
        double[,] paids = new double[,];

        public Form1()
        {
            InitializeComponent();

            cboProvince.DataSource = provs;
            cboCrop.DataSource = crops;

            foreach (string ele in provs)
            {
                dgvCropBuying.Rows.Add(ele);
            }

            btnCommit.Click += BtnCommit_Click;
        }

        void ReadToDgv()
        {
            for (int i = 0; i < paids.GetLength(0); i++)
            {
                for (int r = 0; r < paids.GetLength(1); r++)
                {
                    dgvCropBuying.Rows[i].Cells[r + 1].Value = paids[i, r];
                }
            }
        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            int cropsIndex = cboCrop.SelectedIndex;
            int proIndex = cboProvince.SelectedIndex;
            int sum = 0;

            dgvCropBuying.Rows[proIndex].Cells[cropsIndex + 1].Value = txtAmount.Text;

            for (int s = 0; s < dgvCropBuying.Columns.Count - 1; s++)
            {
                if(s==0)
                {
                    continue;
                }
                sum += Convert.ToInt32(dgvCropBuying.Rows[proIndex].Cells[s].Value);
            }
            dgvCropBuying.Rows[proIndex].Cells[4].Value = sum.ToString();
            sum = 0;
        }
    }
}
