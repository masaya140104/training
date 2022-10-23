using System;

namespace 問1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("消費税込み金額を計算します。");
            Console.WriteLine("金額を入力して、Enterキーを押してください。");

            double priceDouble = Math.Round(1.08 * double.Parse(Console.ReadLine()));

            int priceInt = (int)priceDouble;

            Console.WriteLine("税込み" + priceInt.ToString() + "円になります。");

            Console.ReadLine();
        }
    }
}
