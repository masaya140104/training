using System;
using System.Text;
using System.IO;

namespace 問題集入門_課題09_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Public\Documents\name.txt";
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

            string name = sr.ReadLine();

            sr.Close();

            Console.WriteLine("私は" + name + "です。");

            Console.ReadLine();
        }
    }
}
