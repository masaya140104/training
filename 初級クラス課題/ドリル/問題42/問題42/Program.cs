using System;

namespace 問題42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = { 59, 38, 95, 48, 55, 70, 61, 50, 49, 69 };

            for (int i = 0; i < points.Length; i++)
            {
                if (50 <= points[i] && points[i] < 70)
                {
                    Console.WriteLine(points[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
