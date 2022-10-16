using System;
using System.Text;
using System.IO;

namespace 問題集入門_課題10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Public\Documents\10_2.txt";
            StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);

            int[] numbers = { 100, 200, 300, 400, 500 };

            for (int i = 0; i < numbers.Length; i++)
            {
                sw.WriteLine(numbers[i].ToString());
            }

            sw.Close();

            Console.WriteLine("ファイルを出力しました。");

            Console.ReadLine();
        }
    }
}
