using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Person
    {
        private string name = "NA";
        private string gender = "NA";
        public int age = 0;

        public Person()
        {
            this.age = 1;
        }

        public Person(string name, string gender, int age)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string GetInfo()
        {
            return string.Format("Name: {0}; Gender: {1}; Age: {2}", this.name, this.gender, this.age);
        }

        public int GetAge()
        {
            return this.age;
        }
    }
}
