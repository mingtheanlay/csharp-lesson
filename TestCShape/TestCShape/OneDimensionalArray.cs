using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCShape
{
    class OneDimensionalArray
    {
        public void GetArray()
        {
            int[] arrVar = new int[5] { 3, 1, 2, 10, 20 };
            Array.Sort(arrVar);
            foreach (int element in arrVar)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
