using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{

    public class Person
    {
        private string name;
        private int age;

        //event
        public delegate void PersonHandler(Person p);
        public event PersonHandler Modified;

        public Person()
        {
            // Default contructor
        }

        public Person(string _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }

        public string GetInfo()
        {
            return (string.Format("Name: {0}; Age: {1}", this.name, this.age));
        }

        public object this[int index]
        {
            // object can be string or any variable
            // if the there are many variable use object
            get
            {
                if (index == 0)
                {
                    return this.name;
                }
                if (index == 1)
                {
                    return this.age;
                }
                throw new Exception("Invalid Index");
            }
        }

        public void SetData(string n, int a)
        {
            this.name = n;
            this.age = a;
            if (this.Modified != null)
            {
                this.Modified(this);
            }

        }
    }
}
