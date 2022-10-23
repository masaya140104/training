using System;

namespace 問1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("消費税込み金額を計算します。");
            Console.WriteLine("金額を入力して、Enterキーを押してください。");

            double price = Math.Floor(1.08 * double.Parse(Console.ReadLine()));

            Console.WriteLine("税込み" + price.ToString() + "円になります。");

            Console.ReadLine();
        }
    }
}
