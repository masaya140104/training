using System;

namespace 問題16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[2] {0, 0};

            Console.WriteLine("一人目の年齢を入力してください。");

            ages[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("二人目の年齢を入力してください。");

            ages[1] = int.Parse(Console.ReadLine());

            int fee = 0;

            if (80 <= ages[0] + ages[1])
            {
                fee = 2000;
            }
            else
            {
                for (int i = 0; i < ages.Length; i++)
                {
                    if (ages[i] <= 12)
                    {
                        fee += 700;
                    }
                    else if (ages[i] <= 18)
                    {
                        fee += 1000;
                    }
                    else if (ages[i] < 60)
                    {
                        fee += 1800;
                    }
                    else if (60 <= ages[i])
                    {
                        fee += 1200;
                    }
                }
            }

            Console.WriteLine("二人分の料金は");
            Console.WriteLine("\\" + fee.ToString());
            Console.WriteLine("になります。");

            Console.ReadLine();
        }
    }
}
