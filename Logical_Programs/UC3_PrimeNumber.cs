using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class UC3_PrimeNumber
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a positive integer value");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 2)
            {
                Console.WriteLine(n + " is a prime number");
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(n + " is not a prime number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(n + " is a prime number");
                        break;
                    }
                }

            }   
        }
    }
}
