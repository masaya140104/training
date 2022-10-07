using System;

namespace 問題入門集_課題04_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名字を入力して、Enterキーを押してください。");

            string lastName = Console.ReadLine();

            Console.WriteLine("名前を入力して、Enterキーを押してください。");

            string firstName = Console.ReadLine();

            string name = lastName + firstName;

            Console.WriteLine("あなたの名前は" + name + "ですね？");

            Console.WriteLine();
        }
    }
}