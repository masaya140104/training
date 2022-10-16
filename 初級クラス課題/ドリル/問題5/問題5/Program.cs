using System;

namespace 問題5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("今日の天気を入力してください。");

            string text = Console.ReadLine();

            Console.WriteLine("今日の天気は");

            Console.WriteLine(text);

            Console.WriteLine("なんですね。");

            Console.ReadLine();
        }
    }
}