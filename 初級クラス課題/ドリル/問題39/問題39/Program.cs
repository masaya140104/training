using System;

namespace 問題39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = {83, 93, 42, 54, 64, 65, 82, 31, 98, 69};

            double x = 100;

            for (int i = 0; i < points.Length; i++)
            {
                if (x > points[i])
                {
                    x = points[i];
                }
            }

            Console.WriteLine("最小値は");
            Console.WriteLine(x.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}
