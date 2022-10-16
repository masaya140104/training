using System;

namespace 問題19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("アイスクリームの数を入力してください。");

            int  iceCream = int.Parse(Console.ReadLine());

            Console.WriteLine("かき氷の数を入力してください。");

            int shavedIce = int.Parse(Console.ReadLine());

            Console.WriteLine("ジュースの数をを入力してください。");

            int juice = int.Parse(Console.ReadLine());

            int juicePrice = juice * 100;

            if (juice % 12 == 0)
            {
                juicePrice = juicePrice * 9 / 10;
            }

            int fee = iceCream * 150 + shavedIce * 300 + juicePrice;

            Console.WriteLine("料金は");
            Console.WriteLine("\\" + fee.ToString());
            Console.WriteLine("です。");

            Console.ReadLine();
        }
    }
}