using System;
using System.Text;

namespace 問2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\tsubo\source\repos\training\初級クラス課題\昇級試験\問2\number.txt";
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

            int number = 0;

            while(-1 < sr.Peek())
            {
                number = int.Parse(sr.ReadLine());

                if (number >= 15)
                {
                    Console.WriteLine(number.ToString());
                }
            }

            sr.Close();

            Console.ReadLine();
        }
    }
}
