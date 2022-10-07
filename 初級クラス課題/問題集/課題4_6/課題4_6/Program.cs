using System;

namespace 問題入門集_課題04_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力して、Enterキーを押してください。");

            string inputNumber1 = Console.ReadLine();

            Console.WriteLine("整数を入力して、Enterキーを押してください。");

            int number1 = int.Parse(inputNumber1);

            number1 += 10;

            Console.WriteLine(number1.ToString());

            Console.ReadLine();
        }
    }
}
