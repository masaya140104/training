using System;

namespace 問題30
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'z';
            int i = 0;

            while (i < 26)
            {
                Console.Write(c.ToString());

                c--;
                i++;
            }

            Console.ReadLine();
        }
    }
}