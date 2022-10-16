using System;

namespace 問題12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("年齢を入力してください。");

            string age = Console.ReadLine();

            if (int.Parse(age) >= 25)
            {
                Console.WriteLine("衆議院議員の被選挙権があります。");
            }
            else
            {
                Console.WriteLine("衆議院議員の被選挙権がありません。");
            }

            Console.ReadLine();
        }
    }
}