using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Count = " + count.ToString());
                count++;
            }

            Console.ReadLine();
        }
    }
}
