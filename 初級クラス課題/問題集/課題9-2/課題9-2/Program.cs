using System;
using System.Text;
using System.IO;

namespace 問題集入門_課題09_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Public\Documents\receipt.txt";
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

            int total = 0;

            while (-1 < sr.Peek())
            {
                string price = sr.ReadLine();

                Console.WriteLine(price + "円");

                total += int.Parse(price);
            }

            sr.Close();

            Console.WriteLine("合計" + total.ToString() + "円");

            Console.ReadLine();
        }
    }
}
