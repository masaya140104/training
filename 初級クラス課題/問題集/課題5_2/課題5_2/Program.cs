using System;

namespace 問題集入門編_課題05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("点数を入力して、");
            Console.WriteLine("Enterキーを押してください。");

            string inputScore = Console.ReadLine();

            int score = int.Parse(inputScore);

            string judgement = string.Empty;
            if (score < 60)
            {
                judgement = "不合格";
            }            
            else
            {
                judgement = "合格";
            }

            Console.WriteLine(judgement + "です。");

            Console.ReadLine();
        }
    }
}
