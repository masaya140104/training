using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string message = string.Empty;
            if (number < 8)
            {
                message = "8より小さいです。";
            }
            else
            {
                message = "8以上です。";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
