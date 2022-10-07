using System;

namespace 問題集入門_課題07_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "ひまわり", "バラ", "たんぽぽ", "チューリップ", "カスミソウ",
                                "朝顔", "ユリ", "アジサイ", "蓮", "スズラン"};

            for (int i = 0; i < flowers.Length; i++)
            {
                Console.WriteLine(flowers[i]);
            }

            Console.ReadLine();
        }
    }
}