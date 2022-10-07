using System;
using System.ComponentModel;

namespace 問題集入門_課題07_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(numbers[i].ToString());

                i++;
            }

            Console.ReadLine();
        }
    }
}