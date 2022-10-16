using System;

namespace 問題34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int s;

            while (i > 0)
            {
                int x = 0;

                s = i;

                while (s <= 10)
                {
                    x += s;

                    s++;
                }

                i--;

                Console.WriteLine(x.ToString());
            }

            Console.ReadLine();
        }
    }
}
