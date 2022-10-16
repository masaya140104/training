using System;

namespace 問題7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");

            string x = Console.ReadLine();

            Console.WriteLine("数値を入力してください。");

            string y = Console.ReadLine();

            int multiplication = int.Parse(x) * int.Parse(y);

            Console.WriteLine("掛け算すると");

            Console.WriteLine(multiplication);

            Console.ReadLine();
        }
    }
}
