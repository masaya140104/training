using System;

namespace 問題29
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';

            for (int i = 0; i < 26; i++)
            {
                Console.Write(c.ToString());

                c++;
            }

            Console.ReadLine();
        }
    }
}
