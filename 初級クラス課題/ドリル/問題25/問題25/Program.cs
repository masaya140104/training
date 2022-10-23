using System;

namespace 問題25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < 100; i++)
            {
                y = i + 1;

                if (y % 3 == 0)
                {
                    x += y;
                }
            }

            Console.WriteLine("0～100までの３倍数の合計は");
            Console.WriteLine(x.ToString());
            Console.WriteLine("です。");

            Console.ReadLine();
        }
    }
}