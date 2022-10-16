using System;
using System.Text;
using System.IO;

namespace 問題50
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\tsubo\source\repos\training\初級クラス課題\ドリル\問題50\numbers.txt", Encoding.UTF8);
            StreamWriter sw = new StreamWriter(@"C:\Users\tsubo\source\repos\training\初級クラス課題\ドリル\問題50\numbers_odd.txt", false, Encoding.UTF8);
            int number;

            for (int i = 0; i < sr.Peek(); i++)
            {
                number = int.Parse(sr.ReadLine());

                if (number % 2 == 1)
                {
                    sw.WriteLine(number.ToString());
                }
            }

            sr.Close();
            sw.Close();

            Console.ReadLine();
        }
    }
}
