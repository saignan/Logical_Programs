using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class UC2_PerfectNumber
    {
        public static void Perfect_Number()
        {
            Console.WriteLine("Enter a value");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    result = result + i;
                }
            }
            if (n == result)
            {
                Console.WriteLine("Entered value is perfect number");
            }
            else
            {
                Console.WriteLine("Entered value is not perfect");
            }
        }
    }
}
