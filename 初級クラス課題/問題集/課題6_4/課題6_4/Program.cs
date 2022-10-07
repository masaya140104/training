using System;

namespace 問題集入門編_課題06_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 9; i < 20; i++)
            {
                total = total + (i + 1);
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();
        }
    }
}
