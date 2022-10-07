using System;

namespace 問題集入門編_課題05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("身長（170.5のように小数点第1まで）を入力して、");
            Console.WriteLine("Enterキーを押してください。");

            string inputHeight = Console.ReadLine();

            double height = double.Parse(inputHeight);

            string size = string.Empty;
            if (height < 165.0)
            {
                size = "S";
            }
            else if (height < 175.0)
            {
                size = "M";
            }
            else if (height < 185.0)
            {
                size = "L";
            }
            else
            {
                size = "LL";
            }

            Console.WriteLine("あなたの服のサイズは" + size + "になります。");

            Console.ReadLine();
        }
    }
}