using System;

namespace 問題24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 9)
            {
                Console.WriteLine(((i + 1) * 7).ToString());

                i++;
            }

            Console.ReadLine();
        }
    }
}