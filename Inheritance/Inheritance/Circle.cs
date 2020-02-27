using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Circle : InterfaceShape
    {
        private double radius;

        public Circle(double r)
        {
            this.radius = r;
        }
        public virtual string ShapeType
        {
            get
            {
                return ("Circle");
            }
        }

        public double GetArea()
        {
            return (Math.PI * radius * radius);
        }

        double InterfaceShape.GetArea()
        {
            return this.GetArea();
        }

    }

    class Cylinder : Circle
    {
        private double height;

        public Cylinder(double r, double h) : base(r)
        {
            this.height = h;
        }

        public override string ShapeType
        {
            get
            {
                return ("Cylinder");
            }
        }

    }

}