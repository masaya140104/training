using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 2, 4, 7, 8, 3, 4, 5, 1, 2, 3, 7, 3, 6, 7, 2, 6, 3, 8, 3, 1, 7, 1, 9, 3, 5, 3, 6, 7, 3, 9 };
            
            int minFigure = findMinFigure(data);

            Console.WriteLine("最小値は" + minFigure.ToString() + "です。");

            Console.ReadLine();
        }

        private static int findMinFigure(int[] data)
        {
            int min = 10;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < min)
                {
                    min = data[i];
                }
            }
            return min;
        }
    }
}
