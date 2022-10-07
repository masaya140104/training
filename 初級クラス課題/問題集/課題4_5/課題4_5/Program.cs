using System;

namespace 問題入門集_課題04_5
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

            number1++;

            number2--;

            Console.WriteLine(number1.ToString());
            Console.WriteLine(number2.ToString());

            Console.ReadLine();
        }
    }
}