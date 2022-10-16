//using System;

namespace 問題14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("大人の人数は何人ですか？");

            string adult = Console.ReadLine();

            Console.WriteLine("子供の人数は何人ですか？");

            string child = Console.ReadLine();

            int fee = int.Parse(adult) * 1800 + int.Parse(child) * 900;

            Console.WriteLine("料金は");
            Console.WriteLine(fee.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}
