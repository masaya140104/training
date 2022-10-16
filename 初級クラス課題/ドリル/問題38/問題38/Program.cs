using System;

namespace 問題38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = {35, 100, 69, 84, 91, 49, 54, 74, 55, 72};

            double x = 0;

            for (int i = 0; i < points.Length; i++)
            {
                if (x < points[i])
                {
                    x = points[i];
                }
            }

            Console.WriteLine("最大値は");
            Console.WriteLine(x.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}