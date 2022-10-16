using System;

namespace 問題6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");

            string x = Console.ReadLine();

            Console.WriteLine("数値を入力してください。");

            string y = Console.ReadLine();

            int total = int.Parse(x) + int.Parse(y);

            Console.WriteLine("合計");

            Console.WriteLine(total.ToString());

            Console.ReadLine();
        }
    }
}
