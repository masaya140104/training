using System;

namespace 問題8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");

            string x = Console.ReadLine();

            Console.WriteLine("数値を入力してください。");

            string y = Console.ReadLine();

            int subtraction = int.Parse(x) - int.Parse(y);

            Console.WriteLine("引き算すると");

            Console.WriteLine(subtraction.ToString());

            Console.ReadLine();
        }
    }
}
