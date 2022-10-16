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

                for (int s = i; s < 10; s++)
                {
                    x += s + 1;
                }

                Console.WriteLine(x.ToString());
            }

            Console.ReadLine();
        }
    }
}
