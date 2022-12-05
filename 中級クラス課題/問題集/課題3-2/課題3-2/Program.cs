using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long result = factorial(5, 1, 1);     
            Console.WriteLine("5の階乗 = " + result.ToString());

            result = factorial(10, 1, 1);
            Console.WriteLine("10の階乗 = " + result.ToString());

            result = factorial(20, 1, 1);
            Console.WriteLine("20の階乗 = " + result.ToString());

            Console.ReadLine();
        }

        private static long factorial(int n, int i, long result)
        {
            while (i <= n)
            {
                result *= i;
                i++;
            }

            return result;
        }
    }
}
