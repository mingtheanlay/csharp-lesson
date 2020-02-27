using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Rectangle : InterfaceShape
    {
        private double width, lenght;
        public Rectangle(double wd, double ln)
        {
            this.width = wd;
            this.lenght = ln;
        }

        public string ShapeType
        {
            get
            {
                return ("Rectangle");
            }
        }

        public double GetArea()
        {
            return (width * lenght);
        }
    }
}
