using System;

namespace 問題40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = { 51, 60, 61, 88, 39, 95, 59, 79, 90, 45 };

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] > 60)
                {
                    Console.WriteLine(points[i].ToString());
                }
            }

            Console.ReadLine();
        }
    }
}