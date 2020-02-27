using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Studies
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static DataGridView dgv = null;

        public static string[] subjects = new string[] { 
            "C# Pl", 
            "Java PL", 
            "ISA", 
            "Network", 
            "Statistic" 
        };

        public static double Total(double [] values)
        {
            double result = 0;
            foreach (double ele in values) result += ele;
            return result;
        }
}

}


