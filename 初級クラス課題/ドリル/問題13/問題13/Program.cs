using System;

namespace 問題13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("身長を入力してください。");

            string height = Console.ReadLine();

            if (int.Parse(height) >= 130)
            {
                Console.WriteLine("ジェットコースターに乗れます。");
            }
            else if (int.Parse(height) >= 120)
            {
                Console.WriteLine("保護者同伴でジェットコースターに乗れます。");
            }
            else
            {
                Console.WriteLine("ジェットコースターに乗れません。");
            }

            Console.ReadLine();
        }
    }
}