using System;

namespace 問題9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");

            string x = Console.ReadLine();

            Console.WriteLine("数値を入力してください。");

            string y = Console.ReadLine();

            Console.WriteLine("数値を入力してください。");

            string z = Console.ReadLine();

            double result = double.Parse(x) * (double.Parse(y) + double.Parse(z));

            Console.WriteLine("計算結果は");

            Console.WriteLine(result.ToString());

            Console.ReadLine();
        }
    }
}