﻿using System;

namespace 問題集入門_課題08_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int total = 0;

            int x = 0;
            while (x < 10)
            {
                total = total + numbers[x];
                x++;
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();
        }
    }
}