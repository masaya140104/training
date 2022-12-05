using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aさん");
            hello();

            Console.WriteLine("Bさん");
            hello();

            Console.WriteLine("Aさん");
            goodEvening();

            Console.WriteLine("Bさん");
            goodEvening();

            Console.ReadLine();
        }

        private static void hello()
        {
            Console.WriteLine("こんにちは");
        }

        private static void goodEvening()
        {
            Console.WriteLine("こんばんは");
        }
    }
}
