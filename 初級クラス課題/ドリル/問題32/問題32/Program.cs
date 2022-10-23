using System;

namespace 問題32
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
            int j = 0;

            while (0 < i)
            {
                j = 0;
                while (j < 9)
                {
                    Console.WriteLine((i * (j + 1)).ToString());

                    j++;
                }

                i--;
            }

            Console.ReadLine();
        }
    }
}
