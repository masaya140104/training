using System;

namespace 問題10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたの名字を入力してください。");

            string lastName = Console.ReadLine();

            Console.WriteLine("あなたの名前を入力してください。");

            string firstName = Console.ReadLine();

            Console.WriteLine("あなたの名前は");

            Console.WriteLine(lastName + firstName);

            Console.WriteLine("ですね。");

            Console.ReadLine();
        }
    }
}
