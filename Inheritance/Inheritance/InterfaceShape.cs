using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface InterfaceShape
    {
        string ShapeType { 
            //get with return;
            // set with variable = value;
            get; 

        }
        double GetArea();
    }
}
