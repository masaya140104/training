using System;

namespace 問題14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたの年齢を入力してください。");

            string age = Console.ReadLine();

            if (int.Parse(age) <= 12)
            {
                Console.WriteLine("料金は");
                Console.WriteLine("\\250");
                Console.WriteLine("です。");
            }
            else if (12 < int.Parse(age) && int.Parse(age) <= 18)
            {
                Console.WriteLine("料金は");
                Console.WriteLine("\\500");
                Console.WriteLine("です。");
            }
            else
            {
                Console.WriteLine("料金は");
                Console.WriteLine("\\1000");
                Console.WriteLine("です。");
            }

            Console.ReadLine();
        }
    }
}
