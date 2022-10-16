using System;

namespace 問題18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("大人の人数は何人ですか？");

            int adults = int.Parse(Console.ReadLine());

            Console.WriteLine("子供の人数は何人ですか？");

            int children = int.Parse(Console.ReadLine());

            int adultsPrice = adults * 1500;

            if (adults >= 10)
            {
                adultsPrice = adultsPrice * 9 / 10;
            }

            int fee = adultsPrice + children * 750;

            Console.WriteLine("料金は");
            Console.WriteLine("\\" + fee.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}
