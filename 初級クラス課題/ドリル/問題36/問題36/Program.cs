using System;

namespace 問題36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = { 65, 55, 78, 90, 85, 76, 80, 95, 50, 45 };

            int x = 0;

            for (int i = 0; i < points.Length; i++)
            {
                x += points[i];
            }

            Console.WriteLine("合計値は");
            Console.WriteLine(x.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}
