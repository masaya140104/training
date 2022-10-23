using System;

namespace 問題31
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(((i + 1) * (j + 1)).ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
