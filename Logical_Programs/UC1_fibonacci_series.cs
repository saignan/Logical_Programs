using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class UC1_fibonacci_series
    {
        public static void fibonacci()
        {
            int first=0, second=1, temp;
            Console.WriteLine("Enter a value");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The list of the first " + n + " Fibonacci numbers are ");
            Console.Write(" " + first + " " + second);
            for (int i = 2; i < n; ++i)
            {
                temp = first + second;
                first = second;
                second = temp;
                Console.Write(" "+temp);
            }
        }

    }
}
