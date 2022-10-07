using System;
using System.Text;
using System.IO;

namespace 問題集入門_課題10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Public\Documents\name_write.txt";
            StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);

            sw.WriteLine("坪倉雅弥");

            sw.Close();

            Console.WriteLine("ファイルを出力しました。");

            Console.ReadLine();
        }
    }
}
