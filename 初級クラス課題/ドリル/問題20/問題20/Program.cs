using System;

namespace 問題20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("アイスクリームの数を入力してください。");

            int iceCream = int.Parse(Console.ReadLine());

            Console.WriteLine("かき氷の数を入力してください。");

            int shavedIce = int.Parse(Console.ReadLine());

            Console.WriteLine("ジュースの数をを入力してください。");

            int juice = int.Parse(Console.ReadLine());

            

            

            int fee = iceCream * 150 + shavedIce * 300 + juice * 100; ;

            if ((iceCream + shavedIce + juice) % 10 == 0)
            {
                fee = fee * 8 / 10;
            }

            Console.WriteLine("料金は");
            Console.WriteLine("\\" + fee.ToString());
            Console.WriteLine("です。");

            Console.ReadLine();
        }
    }
}
