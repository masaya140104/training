using System;

namespace 問題集入門編_課題06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                total = total + (i + 1);
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();
        }
    }
}