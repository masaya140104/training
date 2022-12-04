using System;
using System.Runtime.CompilerServices;

namespace 問題集初級編_課題01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetingHello;
            string greetingForAlongTies;
            string name;

            greetingHello = "こんにちは。";
            greetingForAlongTies = "お久しぶりですね。";
            name = "IF 太郎";

            Console.WriteLine(name + "さん" + greetingHello);
            Console.WriteLine(greetingForAlongTies);

            string greetingGoodEvening;
            string greetingHowAreYou;

            greetingGoodEvening = "こんばんは。";
            greetingHowAreYou = "お元気ですか。";

            Console.WriteLine(name + "さん、" + greetingGoodEvening);
            Console.WriteLine(greetingHowAreYou);

            Console.ReadLine();
        }
    }
}

///予想通りでした