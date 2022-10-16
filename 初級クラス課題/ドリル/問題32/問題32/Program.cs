using System;

namespace 問題32
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
            int s = 0;

            while (0 < i)
            {
                s = 0;
                while (s < 9)
                {
                    Console.WriteLine(i * (s + 1));

                    s++;
                }

                i--;
            }

            Console.ReadLine();
        }
    }
}
