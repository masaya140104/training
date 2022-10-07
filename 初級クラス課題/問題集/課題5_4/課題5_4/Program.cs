using System;

namespace 問題集入門編_課題05_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("購入したいジュース名を入力して、Enterキーを押してください。");
            Console.WriteLine("購入可能なジュースはは以下の通りです。");
            Console.WriteLine("オレンジジュース　コーラ　ウーロン茶　緑茶");

            string order = Console.ReadLine();

            if (order == "オレンジジュース")
            {
                Console.WriteLine("値段は250円になります。");
            }
            else if (order == "コーラ")
            {
                Console.WriteLine("値段は200円になります。");
            }
            else if (order == "ウーロン茶")
            {
                Console.WriteLine("値段は150円になります。");
            }
            else if (order == "緑茶")
            {
                Console.WriteLine("値段は0円です。");
            }
            else
            {
                Console.WriteLine("オレンジジュースかコーラかウーロン茶か緑茶を入力してください。");
            }

            Console.ReadLine();
        }
    }
}
