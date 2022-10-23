using System;

namespace 問題23
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 9)
            {
                Console.WriteLine(((i + 1) * 3).ToString());

                i++;
            }

            Console.ReadLine();
        }
    }
}
