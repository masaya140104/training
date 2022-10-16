using System;
using System.Text;
using System.IO;

namespace 問題48
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\tsubo\source\repos\training\初級クラス課題\ドリル\問題48\numbers2.txt", false, Encoding.UTF8);

            Random random = new Random();

            int x = 0;

            for (int i = 0; i < 10; i++)
            {
                x = random.Next(0, 100);
                sw.WriteLine(x.ToString());
            }

            sw.Close();

            Console.ReadLine();
        }
    }
}