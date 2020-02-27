using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();

            Person p1, p2, p3;
            p1 = new Person();
            p2 = new Person("Thean", "Male", 19);
            p3 = p2;

            this.persons.Add(p1);
            this.persons.Add(p2);
            this.persons.Add(p3);
            this.persons.Add(new Person("Mac", "Male", 30));

            foreach(Person ele in persons)
            {
                lstInfo.Items.Add(ele.GetInfo());
            }

            btnAdd.Click += BtnAdd_Click;
            btnMaxAge.Click += BtnMaxAge_Click;
        }

        private void BtnMaxAge_Click(object sender, EventArgs e)
        {
            Person maxPerson = this.persons[0];
            for(int i = 1; i < this.persons.Count; i++)
            {
                if(maxPerson.GetAge() < this.persons[i].GetAge())
                {
                    maxPerson = this.persons[i];
                }
            }

            MessageBox.Show("The maximun age is " + maxPerson.GetInfo(),
                "Max Age",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information
                );
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Person tempPerson = new Person(txtName.Text, txtGender.Text, int.Parse(txtAge.Text));
            this.persons.Add(tempPerson);
            lstInfo.Items.Add(tempPerson.GetInfo());
        }
    }
}
