using System;

namespace 問題33
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = 0;

                for (int j = i; j < 10; j++)
                {
                    x += j + 1;
                }

                Console.WriteLine(x.ToString());
            }

            Console.ReadLine();
        }
    }
}
