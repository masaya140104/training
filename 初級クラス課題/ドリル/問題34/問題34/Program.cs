using System;

namespace 問題34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j;

            while (i > 0)
            {
                int x = 0;

                j = i;

                while (j <= 10)
                {
                    x += j;

                    j++;
                }

                i--;

                Console.WriteLine(x.ToString());
            }

            Console.ReadLine();
        }
    }
}
