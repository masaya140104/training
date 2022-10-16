using System;

namespace 問題26
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int i = 0;

            while (i < 100)
            {
                y = i + 1;

                if (y % 4 == 0)
                {
                    x += y;
                }

                i++;
            }

            Console.WriteLine("0～100までの4倍数の合計は");
            Console.WriteLine(x);
            Console.WriteLine("です。");

            Console.ReadLine();
        }
    }
}
