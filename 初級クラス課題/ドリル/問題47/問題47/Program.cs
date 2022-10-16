using System;
using System.Text;
using System.IO;

namespace 問題47
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\tsubo\source\repos\training\初級クラス課題\ドリル\問題46\numbers.txt", Encoding.UTF8);

            int total = 0;

            while (-1 < sr.Peek())
            {
                int x = int.Parse(sr.ReadLine());

                total += x;
            }

            sr.Close();

            Console.WriteLine("合計は");
            Console.WriteLine(total.ToString());
            Console.WriteLine("です。");

            Console.ReadLine();
        }
    }
}