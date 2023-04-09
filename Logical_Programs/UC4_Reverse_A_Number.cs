using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class UC4_Reverse_A_Number
    {
        public static void ReverseNum()
        {
            Console.WriteLine("Enter a Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int rem;
            for(int i = n; i > 0; i /= 10)
            {
                rem = i % 10;
                reverse = reverse * 10 + rem;
            }
            Console.WriteLine("Reverse value of given number is "+reverse);
        }
    }
}
