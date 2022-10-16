using System;

namespace 問題集入門_課題08_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i < 50; i++)
            {
                total += (i + 1);
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();
        }
    }
}