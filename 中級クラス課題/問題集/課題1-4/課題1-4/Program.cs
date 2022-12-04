using System;

namespace 問題集初級編_問題01_4
{
    class Prodram
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = rand1.Next(100);
                Console.WriteLine(number.ToString());
            }

            Console.WriteLine("----");

            for (int i = 0; i < 10; i++)
            {
                Random rand2 = new Random();
                int number = rand2.Next(100);
                Console.WriteLine(number.ToString());
            }

            Console.ReadLine();
        }
    }
}

///予想通りでした。