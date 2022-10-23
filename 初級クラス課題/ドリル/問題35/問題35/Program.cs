using System;

namespace 問題35
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}