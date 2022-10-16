using System;

namespace 問題31
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int s = 0; s < 9; s++)
                {
                    Console.WriteLine((i + 1) * (s + 1));
                }
            }

            Console.ReadLine();
        }
    }
}
