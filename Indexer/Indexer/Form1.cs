using System;
using System.Windows.Forms;

namespace Indexer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Person person = new Person("Thean", 20);
            object res1 = person[0];
            object res2 = person[1];

            this.AddPerson(new Person("ABC", 21));
            this.AddPerson(new Person("Dummy", 22));

            btnEdit.Click += BtnEdit_Click;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(dgvPers.CurrentRow.Tag as Person);
            form2.Show();
        }

        void AddPerson(Person p)
        {
            int index = dgvPers.Rows.Add(p[0], p[1]);
            dgvPers.Rows[index].Tag = p;
            p.Modified += Person_Modified;

            if (p == null)
            {
                return;
            }
        }

        void Person_Modified(Person p)
        {
            foreach (DataGridViewRow rw in dgvPers.Rows)
            {
                if (rw.Tag.Equals(p) == true)
                {
                    rw.SetValues(p[0], p[1]);
                    break;
                }
            }
        }
    }
}
