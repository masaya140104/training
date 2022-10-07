using System;

namespace 問題入門集_課題04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力して、Enterキーを押してください。");

            string inputNumber1 = Console.ReadLine();

            Console.WriteLine("整数を入力して、Enterキーを押してください。");

            string inputNumber2 = Console.ReadLine();

            int number1 = int.Parse(inputNumber1);
            int number2 = int.Parse(inputNumber2);

            int result = number1 + number2;

            Console.WriteLine("計算結果は");
            Console.WriteLine(result.ToString());

            Console.ReadLine();
        }
    }
}
