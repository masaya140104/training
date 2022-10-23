using System;

namespace 問題41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = { 50, 49, 62, 59, 35, 90, 48, 51, 60, 61 };

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] < 50)
                {
                    Console.WriteLine(points[i].ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
