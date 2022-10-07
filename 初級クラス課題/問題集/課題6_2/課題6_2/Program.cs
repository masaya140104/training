using System;

namespace 問題集入門編_課題06_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int counter = 9;

            while (counter < 20)
            {
                total = total + (counter + 1);

                counter++;
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();
        }
    }
}
