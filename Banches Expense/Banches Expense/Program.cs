using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banches_Expense
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
        public static TextBox txt = null;
        public static string[] branches = new string[] { "Branch 1", "Branch 2", "Branh 3" };
        public static double[][] amounts = new double[branches.Length][];

        public static string TextualAmountsFor(string br)
        {
            int index = Array.IndexOf(branches, br);
            if(index < 0)
            {
                return "";
            }

            double[] values = amounts[index];
            if(values == null)
            {
                return "";
            }

            string result = null;
            foreach(double ele in values)
            {
                if(result != null)
                {
                    result += "; ";
                }
                result += ele.ToString();
            }
            return result;
        }

        public static double TotalAmountFor(string br)
        {
            int index = Array.IndexOf(branches, br);
            if(index < 0)
            {
                return 0;
            }

            double[] values = amounts[index];
            if(values==null)
            {
                return 0;
            }

            double result = 0;
            foreach(double ele in values)
            {
                result += ele;
            }
            return result;
        }

        public static double TotalAmount()
        {
            double result = 0;
            foreach(double[] values in amounts)
            {
                if(values == null)
                {
                    continue;
                }
                foreach(double ele in values)
                {
                    result += ele;
                }
            }
            return result;
        }
    }
}
