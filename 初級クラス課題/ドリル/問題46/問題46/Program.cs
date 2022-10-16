using System;
using System.Text;
using System.IO;

namespace 問題46
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\tsubo\source\repos\training\初級クラス課題\ドリル\問題46\numbers.txt", Encoding.UTF8);

            while (-1 < sr.Peek())
            {
                string text = sr.ReadLine();

                Console.WriteLine(text);
            }

            sr.Close();

            Console.ReadLine();
        }
    }
}
