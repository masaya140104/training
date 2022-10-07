using System;

namespace 問題入門集_課題04_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力して、Enterキーを押してください。");

            string name = Console.ReadLine();
            
            Console.WriteLine("年齢を入力して、Enterキーを押してください。");

            string age = Console.ReadLine();          

            Console.WriteLine("あなたの名前は" + name + "ですね？");

            Console.WriteLine("あなたの年齢は" + age + "ですね？");

            Console.WriteLine();
        }
    }
}
