using System;

namespace 問題17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("大人の人数は何人ですか？");

            int adults = int.Parse(Console.ReadLine());

            Console.WriteLine("子供の人数は何人ですか？");

            int children = int.Parse(Console.ReadLine());

            int discount = adults / 2;

            children -= discount;

            int fee = adults * 1500 + children * 750;

            Console.WriteLine("料金は");
            Console.WriteLine("\\" + fee.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}
