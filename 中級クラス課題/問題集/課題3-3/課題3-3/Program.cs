using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 5, 2, 7, 8, 3, 9, 6 };
            int[] array2 = { 12, 24, 63, 11, 29 };
            int[] array3 = { 1251, 3567, 9399, 6241 };

            int result = sum(array1);
            Console.WriteLine("array1の合計は" + result.ToString() + "です。");

            result = sum(array2);
            Console.WriteLine("array2の合計は" + result.ToString() + "です。");

            result = sum(array3);
            Console.WriteLine("array3の合計は" + result.ToString() + "です。");

            Console.ReadLine();
        }

        private static int sum(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            return result;
        }
    }
}
