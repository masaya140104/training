using System;

namespace 問題入門集_課題03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してEnterキーを押してください");

            string inputName = Console.ReadLine();

            Console.WriteLine("年齢を入力してEnterキーを押してください。");

            string inputAge = Console.ReadLine();

            Console.WriteLine(inputName);

            Console.Write(inputAge);

            Console.ReadLine();
        }
    }
}
