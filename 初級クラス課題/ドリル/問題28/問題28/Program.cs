using System;

namespace 問題28
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'z';
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(c.ToString());

                c--;
            }

            Console.ReadLine();
        }
    }
}