using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indexer
{
    public partial class Form2 : Form
    {
        Person selectedPerson;
        public Form2(Person p)
        {
            InitializeComponent();

            Person edit = new Person();
            this.selectedPerson = p;
            this.AddPersonToTextBox();

            btnUpdate.Click += BtnUpdate_Click;
            edit.Modified += Edit_Modified;
        }

        private void Edit_Modified(Person p)
        {
            this.AddPersonToTextBox();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            selectedPerson.SetData(txtName.Text, int.Parse(txtAge.Text));
        }

        void AddPersonToTextBox()
        {
            txtName.Text = this.selectedPerson[0].ToString();
            txtAge.Text = this.selectedPerson[1].ToString();
        }



    }
}
