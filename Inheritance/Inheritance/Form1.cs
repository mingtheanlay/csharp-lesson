using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        InterfaceShape shape = null;

        Rectangle rectangle = null;
        Circle circle = null;
        Kite kite = null;
        Cylinder cylinder = null;

        public Form1()
        {
            rectangle = new Rectangle(10, 3);
            shape = rectangle;

            circle = new Circle(20.20);
            shape = circle;

            kite = new Kite(3, 7);
            shape = kite;
            

            cylinder = new Cylinder(20.20, 15);
            shape = cylinder;

            InitializeComponent();
        }
    }
}
