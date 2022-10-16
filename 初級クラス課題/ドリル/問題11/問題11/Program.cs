using System;

namespace 問題11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("年齢を入力してください。");

            string age = Console.ReadLine();           

            if (int.Parse(age) >= 18)
            {
                Console.WriteLine("乗用車の免許が取得できます。");
            }
            else
            {
                Console.WriteLine("乗用車の免許が取得できません。");
            }

            Console.ReadLine();
        }
    }
}