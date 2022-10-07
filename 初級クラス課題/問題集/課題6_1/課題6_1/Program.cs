using System;

namespace 問題集入門編_課題06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int counter = 0;

            while(counter < 5)
            {
                total = total + (counter + 1);

                counter++;
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();
        }
    }
}
