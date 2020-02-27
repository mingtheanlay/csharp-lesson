using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Kite : InterfaceShape
    {
        private double dia1, dia2;

        public Kite(double dia1, double dia2)
        {
            this.dia1 = dia1;
            this.dia2 = dia2;
        }

        public string ShapeType
        {
            get
            {
                return ("Kite");
            }
        }

        public double GetArea()
        {
            return (dia1 * dia2 * 0.5);
        }
    }
}
