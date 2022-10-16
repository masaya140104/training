using System;

namespace 問題37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = {55, 72, 89, 81, 76, 64, 97, 49, 45, 74};

            double x = 0;

            for (int i = 0; i < points.Length; i++)
            {
                x += points[i];
            }

            x /= points.Length;

            Console.WriteLine("平均値は");
            Console.WriteLine(x.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}
