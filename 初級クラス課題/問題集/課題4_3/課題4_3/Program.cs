using System;

namespace 問題入門集_課題04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("実数を入力して、Enterキーを押してください。");

            string inputNumber1 = Console.ReadLine();

            Console.WriteLine("実数を入力して、Enterキーを押してください。");

            string inputNumber2 = Console.ReadLine();

            double number1 = double.Parse(inputNumber1);
            double number2 = double.Parse(inputNumber2);

            double resultDouble = number1 + number2;

            Console.WriteLine("計算結果は");
            Console.WriteLine(resultDouble.ToString());

            int resultInt = (int)(number1 + number2);

            Console.WriteLine("整数での計算結果は");
            Console.WriteLine(resultInt.ToString());

            Console.ReadLine();
        }
    }
}
